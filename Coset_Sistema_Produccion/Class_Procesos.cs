using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Procesos
    {
        public List<Proceso_electricos> Adquiere_procesos_disponibles_en_base_datos()
        {
            List<Proceso_electricos> procesos_disponibles = new List<Proceso_electricos>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_ingenieria_procesos());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql(), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    procesos_disponibles.Add(new Proceso_electricos()
                    {
                        Codigo = mySqlDataReader["Codigo_proceso"].ToString(),
                        Nombre = mySqlDataReader["nombre_proceso"].ToString(),
 
                    });
                }
            }
            catch (Exception ex)
            {
                procesos_disponibles.Add(new Proceso_electricos()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return procesos_disponibles;
        }

        private string Configura_Cadena_Conexion_MySQL_ingenieria_procesos()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=ingenieria;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }

        private string Commando_leer_Mysql()
        {
            return "SELECT * FROM procesos";
        }
    }
    public class Proceso_electricos
    {
        public string Codigo = "";
        public string Nombre = "";
        public string error = "";
    }
}
