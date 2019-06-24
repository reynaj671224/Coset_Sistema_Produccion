﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Actividades_Proceso_Electrico
    {
        public List<Actividad_Proceso_Electrico> Adquiere_actividad_procesos_disponibles_en_base_datos()
        {
            List<Actividad_Proceso_Electrico> procesos_electricos_disponibles = new List<Actividad_Proceso_Electrico>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_ingenieria_procesos());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql(), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    procesos_electricos_disponibles.Add(new Actividad_Proceso_Electrico()
                    {
                        Actividad = mySqlDataReader["actividad"].ToString(),
                        Notas = mySqlDataReader["notas"].ToString(),

                    });
                }
            }
            catch (Exception ex)
            {
                procesos_electricos_disponibles.Add(new Actividad_Proceso_Electrico()
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
            return "SELECT * FROM actividades_procesos_electricos";
        }
    }
    public class Actividad_Proceso_Electrico
    {
        public int Codigo = 0;
        public string Codigo_Proceso_Electrico = "";
        public string Actividad = "";
        public string Notas = "";
        public string error = "";
    }
}
