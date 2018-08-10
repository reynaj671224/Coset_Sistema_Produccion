using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Autos
    {
        public List<Auto> Adquiere_autos_disponibles_en_base_datos()
        {
            List<Auto> autos_disponibles = new List<Auto>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_autos());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_autos_disponibles(), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    autos_disponibles.Add(new Auto()
                    {
                        Placas = mySqlDataReader["placas"].ToString(),
                        Marca = mySqlDataReader["marca"].ToString(),
                        Color = mySqlDataReader["color"].ToString(),
                        Modelo = mySqlDataReader["modelo"].ToString(),
                        Descripcion = mySqlDataReader["descripcion"].ToString(),
                        Status = mySqlDataReader["status"].ToString()

                    });
                }
            }
            catch (Exception ex)
            {
                autos_disponibles.Add(new Auto()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return autos_disponibles;
        }

        public List<Auto> Adquiere_autos_usando_en_base_datos()
        {
            List<Auto> autos_disponibles = new List<Auto>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_autos());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_autos_usando(), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    autos_disponibles.Add(new Auto()
                    {
                        Placas = mySqlDataReader["placas"].ToString(),
                        Marca = mySqlDataReader["marca"].ToString(),
                        Color = mySqlDataReader["color"].ToString(),
                        Modelo = mySqlDataReader["modelo"].ToString(),
                        Descripcion = mySqlDataReader["descripcion"].ToString(),
                        Status = mySqlDataReader["status"].ToString()

                    });
                }
            }
            catch (Exception ex)
            {
                autos_disponibles.Add(new Auto()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return autos_disponibles;
        }

        private string Commando_leer_autos_usando()
        {
            return "SELECT * FROM autos where status='Usando';";
        }

        public string Inserta_datos_auto(Auto auto)
        {
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_autos());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_insertar_auto_en_base_de_datos(auto), connection);
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

        public string Modifica_datos_auto(Auto auto)
        {
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_autos());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_modificar_auto_en_base_de_datos(auto), connection);
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

        public string Modifica_datos_status_auto(string status)
        {
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_autos());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_modificar_status_auto_en_base_de_datos(status), connection);
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

        private string Configura_cadena_comando_modificar_status_auto_en_base_de_datos(string status)
        {
            throw new NotImplementedException();
        }

        public string Elimina_datos_auto(Auto auto)
        {
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_autos());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_eliminar_en_base_de_datos_autos(auto), connection);
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
        private string Configura_cadena_comando_eliminar_en_base_de_datos_autos(Auto auto)
        {
            return "DELETE from autos where placas='" +
               auto.Placas + "';";
        }

        private string Configura_cadena_comando_modificar_auto_en_base_de_datos(Auto auto)
        {
            return "UPDATE autos set  marca='" + auto.Marca +
               "',color='" + auto.Color +
               "',modelo='" + auto.Modelo +
               "',descripcion='" + auto.Descripcion +
               "',status='" + auto.Status +
               "' where placas='" + auto.Placas + "';";
        }

        private string Configura_cadena_comando_insertar_auto_en_base_de_datos(Auto auto)
        {
            return "INSERT INTO autos(placas, marca,color,modelo,descripcion,status) " +
               "VALUES('" + auto.Placas + "','" + auto.Marca + "'," +
               "'" + auto.Color + "','" + auto.Modelo + "'" +
               ",'" + auto.Descripcion + "','" + auto.Status + "');";
        }

        private string Commando_leer_autos_disponibles()
        {
            return "SELECT * FROM autos ORDER BY ABS(placas);";
        }

        private string Configura_Cadena_Conexion_MySQL_almacen_autos()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=almacen;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }
    }
    public class Auto
    {
        public string Placas = "";
        public string Marca = "";
        public string Modelo = "";
        public string Color = "";
        public string Descripcion = "";
        public string Status = "";
        public string error = "";
    }
}
