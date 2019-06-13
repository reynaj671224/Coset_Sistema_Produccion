using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Secuencia_Calidad
    {
        public List<Secuencia_calidad> Adquiere_secuencia_calidad_busqueda_en_base_datos(Secuencia_calidad numero_dibujo)
        {
            List<Secuencia_calidad> secuencia_existente_disponibles_produccion = new List<Secuencia_calidad>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_secuencia_calidad());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_busqueda_secuencia_calidad(numero_dibujo), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    secuencia_existente_disponibles_produccion.Add(new Secuencia_calidad()
                    {
                        Codigo = mySqlDataReader["codigo"].ToString(),
                        Numero_Dibujo = mySqlDataReader["numero_dibujo"].ToString(),
                        Empleado = mySqlDataReader["empleado"].ToString(),
                        Fecha = mySqlDataReader["fecha"].ToString(),
                        Proceso = mySqlDataReader["proceso"].ToString(),
                        Motivo_rechazo = mySqlDataReader["motivo_rechazo"].ToString(),
                        Accion_correctiva = mySqlDataReader["accion_correctiva"].ToString(),
                        calidad = mySqlDataReader["calidad"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                secuencia_existente_disponibles_produccion.Add(new Secuencia_calidad()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return secuencia_existente_disponibles_produccion;
        }

        public List<Secuencia_calidad> Adquiere_secuencia_calidad_busqueda_en_base_datos_empleados(Secuencia_calidad numero_dibujo)
        {
            List<Secuencia_calidad> secuencia_existente_disponibles_produccion = new List<Secuencia_calidad>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_secuencia_calidad());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_busqueda_secuencia_calidad_empleado(numero_dibujo), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    secuencia_existente_disponibles_produccion.Add(new Secuencia_calidad()
                    {
                        Codigo = mySqlDataReader["codigo"].ToString(),
                        Numero_Dibujo = mySqlDataReader["numero_dibujo"].ToString(),
                        Empleado = mySqlDataReader["empleado"].ToString(),
                        Fecha = mySqlDataReader["fecha"].ToString(),
                        Proceso = mySqlDataReader["proceso"].ToString(),
                        Motivo_rechazo = mySqlDataReader["motivo_rechazo"].ToString(),
                        Accion_correctiva = mySqlDataReader["accion_correctiva"].ToString(),
                        calidad = mySqlDataReader["calidad"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                secuencia_existente_disponibles_produccion.Add(new Secuencia_calidad()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return secuencia_existente_disponibles_produccion;
        }

        private string Commando_leer_Mysql_busqueda_secuencia_calidad_empleado(Secuencia_calidad numero_dibujo)
        {
            return "SELECT * FROM secuencia_calidad WHERE empleado='" + numero_dibujo.Empleado + "';";
        }

        public string Inserta_nuevo_secuencia_calidad_base_datos(Secuencia_calidad numero_dibujo)
        {
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_secuencia_calidad());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_insertar_en_base_de_datos_secuencia_calidad(numero_dibujo), connection);
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

        private string Configura_cadena_comando_insertar_en_base_de_datos_secuencia_calidad(Secuencia_calidad numero_dibujo)
        {
            return "INSERT INTO secuencia_calidad(numero_dibujo,empleado," +
                   "fecha,proceso,motivo_rechazo,calidad,accion_correctiva) " +
                   "VALUES('" + numero_dibujo.Numero_Dibujo + "','" + numero_dibujo.Empleado + "','" +
                   numero_dibujo.Fecha + "','" + numero_dibujo.Proceso + "','" + numero_dibujo.Motivo_rechazo + "','" +
                   numero_dibujo.calidad + "','" + numero_dibujo.Accion_correctiva + "'); ";
        }

        private string Commando_leer_Mysql_busqueda_secuencia_calidad(Secuencia_calidad numero_dibujo)
        {
            return "SELECT * FROM secuencia_calidad WHERE numero_dibujo='" + numero_dibujo.Numero_Dibujo + "';";
        }

        private string Configura_Cadena_Conexion_MySQL_secuencia_calidad()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server +
                ";Database=produccion;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }
    }
    public class Secuencia_calidad
    {
        public string Codigo = "";
        public string Numero_Dibujo = "";
        public string Empleado = "";
        public string Proceso = "";
        public string Fecha = "";
        public string Motivo_rechazo = "";
        public string Accion_correctiva = "";
        public string calidad = "";
        public string error = "";
    }

}
