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
            List<Material> Material_existente_disponibles_materiales = new List<Material>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_materiales());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_busqueda_material(material), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    Material_existente_disponibles_materiales.Add(new Material()
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
                        precio = mySqlDataReader["material_precio"].ToString(),

                    });
                }
            }
            catch (Exception ex)
            {
                Material_existente_disponibles_materiales.Add(new Material()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return Material_existente_disponibles_materiales;
        }

        public List<Material> Adquiere_materiales_busqueda_entrada_materiales_en_base_datos(Material material)
        {
            List<Material> Material_existente_disponibles_materiales = new List<Material>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_materiales());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_busqueda_entrada_material(material), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    Material_existente_disponibles_materiales.Add(new Material()
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
                        precio = mySqlDataReader["material_precio"].ToString(),

                    });
                }
            }
            catch (Exception ex)
            {
                Material_existente_disponibles_materiales.Add(new Material()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return Material_existente_disponibles_materiales;
        }

        private string Commando_leer_Mysql_busqueda_entrada_material(Material material)
        {
            return "SELECT * FROM materiales WHERE codigo_material LIKE '%" + material.Codigo +
                 "%' OR codigo_proveedor LIKE '%" + material.Codigo_proveedor + "%' OR material_descripcion LIKE '%" +
                 material.Descripcion + "%';";
        }

        public List<Material> Adquiere_agregar_materiales_busqueda_en_base_datos(Material material)
        {
            List<Material> Material_existente_disponibles_materiales = new List<Material>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_materiales());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_busqueda_material_agregar(material), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    Material_existente_disponibles_materiales.Add(new Material()
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
                        precio = mySqlDataReader["material_precio"].ToString(),

                    });
                }
            }
            catch (Exception ex)
            {
                Material_existente_disponibles_materiales.Add(new Material()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return Material_existente_disponibles_materiales;
        }

        public List<Material> Adquiere_materiales_Consulta_en_base_datos(Material material, string criterio_busqueda)
        {
            List<Material> Material_existente_disponibles_materiales = new List<Material>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_materiales());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_consulta_material(material, criterio_busqueda), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    Material_existente_disponibles_materiales.Add(new Material()
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
                        precio = mySqlDataReader["material_precio"].ToString(),


                    });
                }
            }
            catch (Exception ex)
            {
                Material_existente_disponibles_materiales.Add(new Material()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return Material_existente_disponibles_materiales;
        }

        public List<Material> Adquiere_materiales_Consulta_Entrada_materiales_en_base_datos(Partida_orden_compra material)
        {
            List<Material> Material_existente_disponibles_entrada_materiales = new List<Material>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_materiales());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_consulta_entrada_material(material), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    Material_existente_disponibles_entrada_materiales.Add(new Material()
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
                        precio = mySqlDataReader["material_precio"].ToString(),

                    });
                }
            }
            catch (Exception ex)
            {
                Material_existente_disponibles_entrada_materiales.Add(new Material()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return Material_existente_disponibles_entrada_materiales;
        }

        private string Commando_leer_Mysql_consulta_entrada_material(Partida_orden_compra material)
        {
            return "SELECT * FROM materiales WHERE codigo_proveedor = '" + material.Parte +
                 "' AND  material_descripcion ='" + material.Descripcion+ "';";
        }

        private string Commando_leer_Mysql_consulta_material(Material material, string criterio_busqueda)
        {
            if (criterio_busqueda == "CodigoMaterial")
            {
                return "SELECT * FROM materiales WHERE codigo_material LIKE '%" + material.Codigo  + "%';";
            }
            else if(criterio_busqueda == "CodigoProveedor")
            {
                return "SELECT * FROM materiales WHERE codigo_proveedor LIKE '%" + material.Codigo_proveedor + "%';";
            }
            else if(criterio_busqueda == "Descripcion")
            {
                return "SELECT * FROM materiales WHERE material_descripcion LIKE '%" +
                    material.Descripcion  + "%';";
            }
            else if(criterio_busqueda == "Ubicacion")
            {
                return "SELECT * FROM materiales WHERE material_ubicacion LIKE '%" +
                    material.Ubicacion + "%';";
            }
            else if(criterio_busqueda == "Marca")
            {
                return "SELECT * FROM materiales WHERE material_marca LIKE '%" + material.Marca + "%';";
            }
            else
            {
                return "";
            }
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
                    "material_foto,material_precio) " +
                    "VALUES('" + material.Codigo + "','" + material.Codigo_proveedor + "','" +
                    material.Descripcion + "','" + material.Unidad_medida + "','" + material.Marca + "','" +
                    material.Ubicacion + "','" + material.Cantidad + "','" + material.Maximo + "','" +
                    material.Minimo + "','" + material.foto + "','" + material.precio + "');";
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
              "',material_ubicacion='" + Actualiza_material.Ubicacion +
              "',material_cantidad='" + Actualiza_material.Cantidad +
              "',material_maximo='" + Actualiza_material.Maximo +
              "',material_minimo='" + Actualiza_material.Minimo +
              "',material_foto='" + Actualiza_material.foto +
              "',material_precio='" + Actualiza_material.precio +
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
        public string precio = "";
        public string error = "";
        

    }
     
}
