using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Partidas_Cotizaciones
    {
        public List<Partida_cotizacion> Adquiere_partidas_cotizacion_disponibles_en_base_datos(string Codigo_cotizacion)
        {
            List<Partida_cotizacion> clientes_disponibles = new List<Partida_cotizacion>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_ingenieria_partidas_cotizacion());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql(Codigo_cotizacion), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    clientes_disponibles.Add(new Partida_cotizacion()
                    {
                        Codigo = (int) mySqlDataReader["codigo_partida"],
                        Numero = mySqlDataReader["numero_partida"].ToString(),
                        Cantidad = mySqlDataReader["cantidad_partida"].ToString(),
                        Parte = mySqlDataReader["parte_partida"].ToString(),
                        Descripcion = mySqlDataReader["descripcion_partida"].ToString(),
                        Precio = mySqlDataReader["precio_partida"].ToString(),
                        Importe = mySqlDataReader["importe_partida"].ToString(),
                        Codigo_cotizacion = mySqlDataReader["codigo_cotizacion"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                clientes_disponibles.Add(new Partida_cotizacion()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return clientes_disponibles;

        }
        private string Commando_leer_Mysql(string Codigo_cotizacion)
        {
            return "SELECT * FROM partidas_cotizaciones WHERE codigo_cotizacion='" + Codigo_cotizacion + "';";
        }

        private string Configura_Cadena_Conexion_MySQL_ingenieria_partidas_cotizacion()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=ingenieria;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }
    }
    public class Partida_cotizacion
    {
        public int Codigo = 0;
        public string Numero = "";
        public string Cantidad = "";
        public string Parte = "";
        public string Descripcion = "";
        public string Precio = "";
        public string Importe = "";
        public string Codigo_cotizacion = "";
        public string error = "";
    }
}
