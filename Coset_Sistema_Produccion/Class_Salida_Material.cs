using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Salida_Material
    {
        public List<Salida_Material> Adquiere_salida_materiales_busqueda_en_base_datos(Salida_Material material)
        {
            List<Salida_Material> Material_existente_disponibles_salida_materiales = new List<Salida_Material>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_materiales());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_busqueda_salida_material(material), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    Material_existente_disponibles_salida_materiales.Add(new Salida_Material()
                    {
                        Codigo = mySqlDataReader["codigo_salida"].ToString(),
                        Proyecto = mySqlDataReader["proyecto"].ToString(),
                        Fecha = mySqlDataReader["fecha"].ToString(),
                        Codigo_material = mySqlDataReader["codigo_material"].ToString(),
                        Cantidad = mySqlDataReader["cantidad_material"].ToString(),
                        Codigo_proveedor = mySqlDataReader["codigo_proveedor_material"].ToString(),
                        Nombre_empleado = mySqlDataReader["nombre_empleado"].ToString(),
                        Descripcion_material = mySqlDataReader["descripcion_material"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                Material_existente_disponibles_salida_materiales.Add(new Salida_Material()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return Material_existente_disponibles_salida_materiales;
        }

        private string Configura_Cadena_Conexion_MySQL_almacen_materiales()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=almacen;Uid=root;Pwd=" + 
                Coset_Sistema_Produccion.password_server + ";";
        }

        private string Commando_leer_Mysql_busqueda_salida_material(Salida_Material material)
        {
            return "SELECT * FROM salida_material where codigo_material ='" + material.Codigo_material + "';";
        }

        public string Inserta_nuevo_salida_material_base_datos(Salida_Material material)
        {
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_materiales());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_insertar_en_base_de_datos_salida_material(material), connection);
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

        private string Configura_cadena_comando_insertar_en_base_de_datos_salida_material(Salida_Material salida_Material)
        {
            return "INSERT INTO salida_material(proyecto, fecha,codigo_material," +
                   "cantidad_material,codigo_proveedor_material,nombre_empleado,descripcion_material) " +
                   "VALUES('" + salida_Material.Proyecto + "','" + salida_Material.Fecha + "','" +
                   salida_Material.Codigo_material + "','" + salida_Material.Cantidad + "','" + salida_Material.Codigo_proveedor + "','" +
                   salida_Material.Nombre_empleado + "','" + salida_Material.Descripcion_material + "');";
        }
    }
    public class Salida_Material
    {
        public string Codigo = "";
        public string Proyecto = "";
        public string Fecha = "";
        public string Codigo_material = "";
        public string Cantidad = "";
        public string Codigo_proveedor = "";
        public string Nombre_empleado = "";
        public string Descripcion_material = "";
        public string error = "";
    }
}
