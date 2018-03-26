using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Materiales
    {
        public List<Material> Adquiere_materiales_busqueda_requisiciones_en_base_datos(Material material)
        {
            List<Material> Material_existente_disponibles_requisiciones = new List<Material>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_materiales());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql(material.Codigo_proveedor, material.Descripcion), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    Material_existente_disponibles_requisiciones.Add(new Material()
                    {
                        Codigo = mySqlDataReader["codigo_material"].ToString(),
                        Codigo_proveedor = mySqlDataReader["codigo_proveedor"].ToString(),
                        Descripcion = mySqlDataReader["material_descripcion"].ToString(),
                        Unidad_medida = mySqlDataReader["material_unidad_medida"].ToString(),
                        Marca = mySqlDataReader["material_marca"].ToString(),
                        Ubicacion= mySqlDataReader["material_ubicacion"].ToString(),

                    });
                }
            }
            catch (Exception ex)
            {
                Material_existente_disponibles_requisiciones.Add(new Material()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return Material_existente_disponibles_requisiciones;
        }
        public string Inserta_nuevo_material_base_datos(Material material)
        {
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_materiales());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_insertar_en_base_de_datos_material(material), connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                connection.Close();
                return ex.Message;
            }

            connection.Close();
            return "NO errores";

        }

        private string Configura_cadena_comando_insertar_en_base_de_datos_material(Material material)
        {
            return "INSERT INTO ordenes_compra(codigo_material, codigo_proveedor,material_descripcion," +
                    "material_unidad_medida,material_marca,material_ubicacion,material_cantidad,material_maximo,material_minimo," +
                    "material_foto) " +
                    "VALUES('" + material.Codigo + "','" + material.Codigo_proveedor + "','" +
                    material.Descripcion + "','" + material.Unidad_medida + "','" + material.Marca + "','" +
                    material.Ubicacion + "','" + material.Cantidad + "','" + material.Maximo + "','" +
                    material.Minimo + "','" + material.foto + "');";
        }

        private string Commando_leer_Mysql(string codigo_proveedor, string descripcion)
        {
            throw new NotImplementedException();
        }

        private string Configura_Cadena_Conexion_MySQL_almacen_materiales()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=almacen;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }
    }
    public class Material
    {
        public string Codigo = "";
        public string Codigo_proveedor = "";
        public string Descripcion = "";
        public string Unidad_medida = "";
        public string Marca = "";
        public string Ubicacion = "";
        public string Cantidad = "";
        public string Maximo = "";
        public string Minimo = "";
        public string foto = "";
        public string error = "";

    }
}
