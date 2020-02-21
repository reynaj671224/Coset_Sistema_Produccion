using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Integracion_Procesos
    {

        public List<Integracion_proceso> Adquiere_secuencia_proceso_integracion_busqueda_en_base_datos(Integracion_proceso integracion_Proceso)
        {
            List<Integracion_proceso> secuencia_existente_disponibles_integracion = new List<Integracion_proceso>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_integracion_proceso());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_busqueda_integracion_proceso(integracion_Proceso), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    secuencia_existente_disponibles_integracion.Add(new Integracion_proceso()
                    {
                        Empleado = mySqlDataReader["empleado"].ToString(),
                        estado = mySqlDataReader["estado"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                secuencia_existente_disponibles_integracion.Add(new Integracion_proceso()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return secuencia_existente_disponibles_integracion;
        }

        private string Commando_leer_Mysql_busqueda_integracion_proceso(Integracion_proceso integracion_Proceso)
        {
            return "SELECT * FROM integracion_procesos WHERE empleado='" + integracion_Proceso.Empleado +"';";
        }

        public string Inserta_nuevo_integracion_proceso_base_datos(Integracion_proceso integracion_Proceso)
        {
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_integracion_proceso());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_insertar_en_base_de_datos_integracion_proceso(integracion_Proceso), connection);
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

        private string Configura_cadena_comando_insertar_en_base_de_datos_integracion_proceso(Integracion_proceso integracion_Proceso)
        {
            return "INSERT INTO secuencia_produccion(empleado,estado) " +
                   "VALUES('" + integracion_Proceso.Empleado + "','" +integracion_Proceso.estado + "'); ";

        }
        private string Configura_Cadena_Conexion_MySQL_integracion_proceso()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server +
                ";Database=produccion;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }
    }
    public class Integracion_proceso
    {
        public string Empleado = "";
        public string estado = "";
        public string error = "";
    }
}
