using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Devolucion_Material
    {
        public List<Devolucion_Material> Adquiere_devolucion_materiales_busqueda_en_base_datos(Devolucion_Material material)
        {
            List<Devolucion_Material> Material_existente_disponibles_devolucion_materiales = new List<Devolucion_Material>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_materiales());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_busqueda_devolucion_material(material), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    Material_existente_disponibles_devolucion_materiales.Add(new Devolucion_Material()
                    {
                        Codigo = mySqlDataReader["codigo_devolucion"].ToString(),
                        Proyecto = mySqlDataReader["proyecto"].ToString(),
                        Fecha = mySqlDataReader["fecha"].ToString(),
                        Codigo_material = mySqlDataReader["codigo_material"].ToString(),
                        Cantidad = mySqlDataReader["cantidad_material"].ToString(),
                        Codigo_proveedor = mySqlDataReader["codigo_proveedor_material"].ToString(),
                        Nombre_empleado = mySqlDataReader["nombre_empleado"].ToString(),
                        Motivo_devolucion = mySqlDataReader["motivo_devolucion"].ToString(),
                        Descripcion_material = mySqlDataReader["descripcion_material"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                Material_existente_disponibles_devolucion_materiales.Add(new Devolucion_Material()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return Material_existente_disponibles_devolucion_materiales;
        }

        public List<Devolucion_Material> Adquiere_devolucion_materiales_busqueda_usuario_en_base_datos(Devolucion_Material material)
        {
            List<Devolucion_Material> Material_existente_disponibles_devolucion_materiales = new List<Devolucion_Material>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_materiales());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_busqueda_devolucion_usuario(material), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    Material_existente_disponibles_devolucion_materiales.Add(new Devolucion_Material()
                    {
                        Codigo = mySqlDataReader["codigo_devolucion"].ToString(),
                        Proyecto = mySqlDataReader["proyecto"].ToString(),
                        Fecha = mySqlDataReader["fecha"].ToString(),
                        Codigo_material = mySqlDataReader["codigo_material"].ToString(),
                        Cantidad = mySqlDataReader["cantidad_material"].ToString(),
                        Codigo_proveedor = mySqlDataReader["codigo_proveedor_material"].ToString(),
                        Nombre_empleado = mySqlDataReader["nombre_empleado"].ToString(),
                        Motivo_devolucion = mySqlDataReader["motivo_devolucion"].ToString(),
                        Descripcion_material = mySqlDataReader["descripcion_material"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                Material_existente_disponibles_devolucion_materiales.Add(new Devolucion_Material()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return Material_existente_disponibles_devolucion_materiales;
        }

        public List<Devolucion_Material> Adquiere_devolucion_materiales_proyecto_busqueda_en_base_datos(Devolucion_Material material)
        {
            List<Devolucion_Material> Material_existente_disponibles_devolucion_materiales = new List<Devolucion_Material>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_materiales());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_busqueda_devolucion_material_proyecto(material), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    Material_existente_disponibles_devolucion_materiales.Add(new Devolucion_Material()
                    {
                        Codigo = mySqlDataReader["codigo_devolucion"].ToString(),
                        Proyecto = mySqlDataReader["proyecto"].ToString(),
                        Fecha = mySqlDataReader["fecha"].ToString(),
                        Codigo_material = mySqlDataReader["codigo_material"].ToString(),
                        Cantidad = mySqlDataReader["cantidad_material"].ToString(),
                        Codigo_proveedor = mySqlDataReader["codigo_proveedor_material"].ToString(),
                        Nombre_empleado = mySqlDataReader["nombre_empleado"].ToString(),
                        Motivo_devolucion = mySqlDataReader["motivo_devolucion"].ToString(),
                        Descripcion_material = mySqlDataReader["descripcion_material"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                Material_existente_disponibles_devolucion_materiales.Add(new Devolucion_Material()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return Material_existente_disponibles_devolucion_materiales;
        }

        private string Commando_leer_Mysql_busqueda_devolucion_material_proyecto(Devolucion_Material material)
        {
            return "SELECT * FROM devolucion_material where proyecto ='" + material.Proyecto + "';";
        }

        private string Configura_Cadena_Conexion_MySQL_almacen_materiales()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=almacen;Uid=root;Pwd=" +
                Coset_Sistema_Produccion.password_server + ";";
        }

        private string Commando_leer_Mysql_busqueda_devolucion_material(Devolucion_Material material)
        {
            return "SELECT * FROM devolucion_material where codigo_material ='" + material.Codigo_material + "';";
        }

        private string Commando_leer_Mysql_busqueda_devolucion_usuario(Devolucion_Material material)
        {
            return "SELECT * FROM devolucion_material where nombre_empleado ='" + material.Nombre_empleado + "';";
        }

        public string Inserta_nuevo_devolucion_material_base_datos(Devolucion_Material material)
        {
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_materiales());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_insertar_en_base_de_datos_devolucion_material(material), connection);
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

        private string Configura_cadena_comando_insertar_en_base_de_datos_devolucion_material(Devolucion_Material devolucion_Material)
        {
            return "INSERT INTO devolucion_material(proyecto, fecha,codigo_material," +
                   "cantidad_material,codigo_proveedor_material,nombre_empleado,motivo_devolucion,descripcion_material) " +
                   "VALUES('" + devolucion_Material.Proyecto + "','" + devolucion_Material.Fecha + "','" +
                   devolucion_Material.Codigo_material + "','" + devolucion_Material.Cantidad + "','" + devolucion_Material.Codigo_proveedor + "','" +
                   devolucion_Material.Nombre_empleado + "','" + devolucion_Material.Motivo_devolucion + "','" + devolucion_Material.Descripcion_material + "');";
        }
    }
    public class Devolucion_Material
    {
        public string Codigo = "";
        public string Proyecto = "";
        public string Fecha = "";
        public string Codigo_material = "";
        public string Cantidad = "";
        public string Codigo_proveedor = "";
        public string Nombre_empleado = "";
        public string Motivo_devolucion = "";
        public string Descripcion_material = "";
        public string error = "";
    }
}
