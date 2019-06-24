using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Procesos_Electrico
    {
        public List<Proceso_Electrico> Adquiere_procesos_disponibles_en_base_datos()
        {
            List<Proceso_Electrico> procesos_electricos_disponibles = new List<Proceso_Electrico>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_ingenieria_procesos());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql(), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    procesos_electricos_disponibles.Add(new Proceso_Electrico()
                    {
                        Codigo = mySqlDataReader["codigo_proceso"].ToString(),
                        Nombre = mySqlDataReader["nombre_proceso"].ToString(),

                    });
                }
            }
            catch (Exception ex)
            {
                procesos_electricos_disponibles.Add(new Proceso_Electrico()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return procesos_electricos_disponibles;
        }

        private string Configura_Cadena_Conexion_MySQL_ingenieria_procesos()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=ingenieria;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }

        private string Commando_leer_Mysql()
        {
            return "SELECT * FROM procesos_electricos";
        }
    }

    public class Proceso_Electrico
    {
        public string Codigo = "";
        public string Nombre = "";
        public string error = "";
    }
}
