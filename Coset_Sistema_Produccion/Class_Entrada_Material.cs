using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Entrada_Material
    {
        public List<Entrada_Material> Adquiere_entrada_materiales_busqueda_en_base_datos(Entrada_Material material)
        {
            List<Entrada_Material> Material_existente_disponibles_entrada_materiales = new List<Entrada_Material>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_materiales());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_busqueda_entrada_material(material), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    Material_existente_disponibles_entrada_materiales.Add(new Entrada_Material()
                    {
                        Codigo = mySqlDataReader["codigo_entrada"].ToString(),
                        Orden_compra = mySqlDataReader["orden_compra"].ToString(),
                        Fecha = mySqlDataReader["fecha"].ToString(),
                        Codigo_material = mySqlDataReader["codigo_material"].ToString(),
                        Cantidad= mySqlDataReader["cantidad_material"].ToString(),
                        Codigo_proveedor = mySqlDataReader["codigo_proveedor_material"].ToString(),
                        Nombre_empleado = mySqlDataReader["nombre_empleado"].ToString(),
                        Descripcion_material = mySqlDataReader["descripcion_material"].ToString(),
                        Precio = mySqlDataReader["precio"].ToString(),
                        Divisa = mySqlDataReader["divisa"].ToString(),
                        Referencia = mySqlDataReader["referencia_entrada"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                Material_existente_disponibles_entrada_materiales.Add(new Entrada_Material()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return Material_existente_disponibles_entrada_materiales;
        }

        public List<Entrada_Material> Adquiere_entrada_materiales_busqueda_en_base_datos_no_orden_compra(Entrada_Material material)
        {
            List<Entrada_Material> Material_existente_disponibles_entrada_materiales = new List<Entrada_Material>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_materiales());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_busqueda_entrada_material_no_orden_compra(material), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    Material_existente_disponibles_entrada_materiales.Add(new Entrada_Material()
                    {
                        Codigo = mySqlDataReader["codigo_entrada"].ToString(),
                        Orden_compra = mySqlDataReader["orden_compra"].ToString(),
                        Fecha = mySqlDataReader["fecha"].ToString(),
                        Codigo_material = mySqlDataReader["codigo_material"].ToString(),
                        Cantidad = mySqlDataReader["cantidad_material"].ToString(),
                        Codigo_proveedor = mySqlDataReader["codigo_proveedor_material"].ToString(),
                        Nombre_empleado = mySqlDataReader["nombre_empleado"].ToString(),
                        Descripcion_material = mySqlDataReader["descripcion_material"].ToString(),
                        Precio = mySqlDataReader["precio"].ToString(),
                        Divisa = mySqlDataReader["divisa"].ToString(),
                        Referencia = mySqlDataReader["referencia_entrada"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                Material_existente_disponibles_entrada_materiales.Add(new Entrada_Material()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return Material_existente_disponibles_entrada_materiales;
        }

        private string Commando_leer_Mysql_busqueda_entrada_material_no_orden_compra(Entrada_Material material)
        {
            return "SELECT * FROM entrada_material where codigo_material ='" + material.Codigo_material  +
                "'and orden_compra ='NA';";
        }

        private string Commando_leer_Mysql_busqueda_entrada_material(Entrada_Material material)
        {
            return "SELECT * FROM entrada_material where codigo_material ='" + material.Codigo_material +
                "' and orden_compra ='"+ material.Orden_compra + "' and descripcion_material ='" + 
                    material.Descripcion_material + "' and partida ='" + material.partida + "';";
        }

        public string Inserta_nuevo_entrada_material_base_datos(Entrada_Material material)
        {
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_materiales());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_insertar_en_base_de_datos_entrada_material(material), connection);
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

        private string Configura_cadena_comando_insertar_en_base_de_datos_entrada_material(Entrada_Material entrada_Material)
        {
            return "INSERT INTO entrada_material(orden_compra, fecha,codigo_material," +
                   "cantidad_material,codigo_proveedor_material,nombre_empleado,descripcion_material,precio,divisa,referencia_entrada, partida) " +
                   "VALUES('" + entrada_Material.Orden_compra + "','" + entrada_Material.Fecha + "','" +
                   entrada_Material.Codigo_material + "','" + entrada_Material.Cantidad + "','" + entrada_Material.Codigo_proveedor + "','" +
                   entrada_Material.Nombre_empleado + "','" + entrada_Material.Descripcion_material + "','" + entrada_Material.Precio +
                   "','" + entrada_Material.Divisa + "','" + entrada_Material.Referencia + "','"+ entrada_Material.partida +"');";
        }

        private string Configura_Cadena_Conexion_MySQL_almacen_materiales()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=almacen;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }
    }
    public class Entrada_Material
    {
        public string Codigo = "";
        public string Orden_compra = "";
        public string Fecha = "";
        public string Codigo_material = "";
        public string Cantidad = "";
        public string Codigo_proveedor = "";
        public string Nombre_empleado = "";
        public string Descripcion_material = "";
        public string Precio = "";
        public string Divisa = "";
        public string Referencia = "";
        public string partida = "";
        public string error = "";

    }
}
