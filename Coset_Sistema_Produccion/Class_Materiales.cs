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
        public List<Material> Adquiere_materiales_busqueda_en_base_datos(Material material)
        {
            List<Material> Material_existente_disponibles_requisiciones = new List<Material>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_materiales());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_busqueda_material(material), connection);
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
                        Ubicacion = mySqlDataReader["material_ubicacion"].ToString(),
                        Cantidad = mySqlDataReader["material_cantidad"].ToString(),
                        Minimo = mySqlDataReader["material_minimo"].ToString(),
                        Maximo = mySqlDataReader["material_maximo"].ToString(),
                        foto = mySqlDataReader["material_foto"].ToString(),

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

        public List<Material> Adquiere_agregar_materiales_busqueda_en_base_datos(Material material)
        {
            List<Material> Material_existente_disponibles_requisiciones = new List<Material>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_materiales());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_busqueda_material_agregar(material), connection);
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
                        Ubicacion = mySqlDataReader["material_ubicacion"].ToString(),
                        Cantidad = mySqlDataReader["material_cantidad"].ToString(),
                        Minimo = mySqlDataReader["material_minimo"].ToString(),
                        Maximo = mySqlDataReader["material_maximo"].ToString(),
                        foto = mySqlDataReader["material_foto"].ToString(),

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

        public List<Material> Adquiere_materiales_Consulta_en_base_datos(Material material)
        {
            List<Material> Material_existente_disponibles_requisiciones = new List<Material>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_materiales());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_consulta_material(material), connection);
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
                        Ubicacion = mySqlDataReader["material_ubicacion"].ToString(),
                        Cantidad = mySqlDataReader["material_cantidad"].ToString(),
                        Minimo = mySqlDataReader["material_minimo"].ToString(),
                        Maximo = mySqlDataReader["material_maximo"].ToString(),
                        foto = mySqlDataReader["material_foto"].ToString(),

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

        private string Commando_leer_Mysql_consulta_material(Material material)
        {
             return "SELECT * FROM materiales WHERE codigo_material LIKE '%" + material.Codigo +
                 "%' OR codigo_proveedor LIKE '%" + material.Codigo_proveedor + "%' OR material_descripcion LIKE '%" +
                 material.Descripcion + "%' OR material_marca LIKE '%" + material.Marca + "%' OR material_marca LIKE '%" +
                 material.Ubicacion + "%';";
        }

        private string Commando_leer_Mysql_busqueda_material_agregar(Material material)
        {
            return "SELECT * FROM materiales WHERE codigo_proveedor LIKE '%" + material.Codigo_proveedor + 
                "%' OR material_descripcion LIKE '%" + material.Descripcion + "%';";
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
            return "INSERT INTO materiales(codigo_material, codigo_proveedor,material_descripcion," +
                    "material_unidad_medida,material_marca,material_ubicacion,material_cantidad,material_maximo,material_minimo," +
                    "material_foto) " +
                    "VALUES('" + material.Codigo + "','" + material.Codigo_proveedor + "','" +
                    material.Descripcion + "','" + material.Unidad_medida + "','" + material.Marca + "','" +
                    material.Ubicacion + "','" + material.Cantidad + "','" + material.Maximo + "','" +
                    material.Minimo + "','" + material.foto + "');";
        }

        private string Commando_leer_Mysql_busqueda_material(Material material)
        {

            return "SELECT * FROM materiales WHERE codigo_material LIKE '%" + material.Codigo +
                 "%' OR codigo_proveedor LIKE '%" + material.Codigo_proveedor + "%' OR material_descripcion LIKE '%" +
                 material.Descripcion + "%' OR material_marca LIKE '%" + material.Marca + "%';";
        }

        private string Configura_Cadena_Conexion_MySQL_almacen_materiales()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=almacen;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }
        public string Actualiza_base_datos_materiales(Material Actualiza_material)
        {
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_materiales());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_modificar_en_base_de_datos_materiales(Actualiza_material), connection);
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

        private string Configura_cadena_comando_modificar_en_base_de_datos_materiales(Material Actualiza_material)
        {
            return "UPDATE materiales set  codigo_proveedor='" + Actualiza_material.Codigo_proveedor +
              "',material_descripcion='" + Actualiza_material.Descripcion +
              "',material_unidad_medida='" + Actualiza_material.Unidad_medida +
              "',material_marca='" + Actualiza_material.Marca +
              "',material_ubicacion='" + Actualiza_material.Descripcion +
              "',material_cantidad='" + Actualiza_material.Cantidad +
              "',material_maximo='" + Actualiza_material.Maximo +
              "',material_minimo='" + Actualiza_material.Minimo +
              "',material_foto='" + Actualiza_material.foto +
              "' where codigo_material='" + Actualiza_material.Codigo + "';";
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
    public class Materiales_agregar_seleccion:Material
    {
        public string Opreacion_materiales = "";
        public string Seleccion_materiales = "";
    }
     
}
