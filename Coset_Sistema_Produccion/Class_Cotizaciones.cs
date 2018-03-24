using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Cotizaciones
    {
        public List<Cotizacion> Adquiere_cotizaciones_disponibles_en_base_datos()
        {
            List<Cotizacion> cotizaciones_disponibles = new List<Cotizacion>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_ingenieria_cotizaciones());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql(), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    cotizaciones_disponibles.Add(new Cotizacion()
                    {
                        Codigo = mySqlDataReader["codigo_cotizacion"].ToString(),
                        Nombre = mySqlDataReader["cliente_nombre"].ToString(),
                        Fecha_cotizacion = mySqlDataReader["fecha_cotizacion"].ToString(),
                        Fecha_entrega = mySqlDataReader["fecha_entrega"].ToString(),
                        Atencion = mySqlDataReader["atencion_cotizacion"].ToString(),
                        Atencion_copia = mySqlDataReader["atencion_copia"].ToString(),
                        Orden_compra = mySqlDataReader["orden_compra"].ToString(),
                        Proyecto = mySqlDataReader["proyecto"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                cotizaciones_disponibles.Add(new Cotizacion()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return cotizaciones_disponibles;

        }
        private string Commando_leer_Mysql()
        {
            return "SELECT * FROM cotizaciones";
        }

        private string Configura_Cadena_Conexion_MySQL_ingenieria_cotizaciones()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=ingenieria;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }
    }
    public class Cotizacion
    {
        public string Codigo = "";
        public string Nombre = "";
        public string Fecha_cotizacion = "";
        public string Fecha_entrega = "";
        public string Atencion = "";
        public string Atencion_copia = "";
        public string Orden_compra = "";
        public string Proyecto = "";
        public string error = "";
    }
}
