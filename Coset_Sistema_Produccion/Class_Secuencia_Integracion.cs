using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;




namespace Coset_Sistema_Produccion
{
    public class Class_Secuencia_Integracion
    {

        public List<Secuencia_integracion> Adquiere_secuencia_integracion_busqueda_en_base_datos(Secuencia_integracion secuencia_Integracion)
        {
            List<Secuencia_integracion> secuencia_existente_disponibles_integracion = new List<Secuencia_integracion>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_secuencia_integracion());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_busqueda_secuencia_integracion(secuencia_Integracion), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    secuencia_existente_disponibles_integracion.Add(new Secuencia_integracion()
                    {
                        Codigo = mySqlDataReader["codigo"].ToString(),
                        Empleado = mySqlDataReader["empleado"].ToString(),
                        inicio_proceso = mySqlDataReader["inicio_proceso"].ToString(),
                        final_proceso = mySqlDataReader["final_proceso"].ToString(),
                        proceso = mySqlDataReader["proceso"].ToString(),
                        estado = mySqlDataReader["estado"].ToString(),
                        actividad = mySqlDataReader["actividad"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                secuencia_existente_disponibles_integracion.Add(new Secuencia_integracion()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return secuencia_existente_disponibles_integracion;

        }

        private string Commando_leer_Mysql_busqueda_secuencia_integracion(Secuencia_integracion secuencia_Integracion)
        {
            return "SELECT * FROM secuencia_integracion WHERE empleado='" + secuencia_Integracion.Empleado +
                "' and estado='Iniciado';";
        }

        public string Inserta_nuevo_secuencia_integracion_base_datos(Secuencia_integracion secuencia_Integracion)
        {
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_secuencia_integracion());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_insertar_en_base_de_datos_secuencia_integracion(secuencia_Integracion), connection);
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

        private string Configura_cadena_comando_insertar_en_base_de_datos_secuencia_integracion(Secuencia_integracion secuencia_Integracion)
        {
            return "INSERT INTO secuencia_integracion(empleado," +
                   "inicio_proceso,final_proceso,proceso,actividad,estado) " +
                   "VALUES('" + secuencia_Integracion.Empleado + "','" +secuencia_Integracion.inicio_proceso + "','" + 
                   secuencia_Integracion.final_proceso + "','" + secuencia_Integracion.proceso + "','" +
                   secuencia_Integracion.actividad  + "','" + secuencia_Integracion.estado + "'); ";

        }

        public string Actualiza_base_datos_secuencia_integracion(Secuencia_integracion secuencia_Integracion)
        {
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_secuencia_integracion());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_en_base_de_datos_modificar_secuencia_integracion(secuencia_Integracion), connection);
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

        private string Configura_cadena_comando_en_base_de_datos_modificar_secuencia_integracion(Secuencia_integracion secuencia_Integracion)
        {

            return "UPDATE secuencia_integracion set  empleado='" + secuencia_Integracion.Empleado +
                "',inicio_proceso='" + secuencia_Integracion.inicio_proceso +
                "',final_proceso='" + secuencia_Integracion.final_proceso +
                "',proceso='" + secuencia_Integracion.proceso +
                "',actividad='" + secuencia_Integracion.actividad +
                "',estado='" + secuencia_Integracion.estado +
                "' where codigo='" + secuencia_Integracion.Codigo + "';";

        }

        

        private string Configura_Cadena_Conexion_MySQL_secuencia_integracion()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server +
                ";Database=produccion;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }
    }

    public class Secuencia_integracion
    {
        public string Codigo = "";
        public string Empleado = "";
        public string inicio_proceso = "";
        public string final_proceso = "";
        public string proceso = "";
        public string actividad = "";
        public string estado = "";
        public string error = "";
    }
}
