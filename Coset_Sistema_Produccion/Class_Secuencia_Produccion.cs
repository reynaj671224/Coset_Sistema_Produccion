using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Secuencia_Produccion
    {
        public List<Secuencia_produccion> Adquiere_secuencia_produccion_busqueda_en_base_datos(Secuencia_produccion numero_dibujo)
        {
            List<Secuencia_produccion> secuencia_existente_disponibles_produccion = new List<Secuencia_produccion>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_secuencia_produccion());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_busqueda_secuencia_produccion(numero_dibujo), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    secuencia_existente_disponibles_produccion.Add(new Secuencia_produccion()
                    {
                        Codigo = mySqlDataReader["codigo"].ToString(),
                        Numero_Dibujo = mySqlDataReader["numero_dibujo"].ToString(),
                        Empleado = mySqlDataReader["empleado"].ToString(),
                        inicio_proceso = mySqlDataReader["inicio_proceso"].ToString(),
                        final_proceso = mySqlDataReader["final_proceso"].ToString(),
                        proceso = mySqlDataReader["proceso"].ToString(),
                        estado = mySqlDataReader["estado"].ToString(),
                        calidad = mySqlDataReader["calidad"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                secuencia_existente_disponibles_produccion.Add(new Secuencia_produccion()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return secuencia_existente_disponibles_produccion;
        }

        public List<Secuencia_produccion> Adquiere_secuencia_produccion_filtro_fecha_en_base_datos(Secuencia_produccion numero_dibujo)
        {
            List<Secuencia_produccion> secuencia_existente_disponibles_produccion = new List<Secuencia_produccion>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_secuencia_produccion());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_filtrpo_fecha_secuencia_produccion(numero_dibujo), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    secuencia_existente_disponibles_produccion.Add(new Secuencia_produccion()
                    {
                        Codigo = mySqlDataReader["codigo"].ToString(),
                        Numero_Dibujo = mySqlDataReader["numero_dibujo"].ToString(),
                        Empleado = mySqlDataReader["empleado"].ToString(),
                        inicio_proceso = mySqlDataReader["inicio_proceso"].ToString(),
                        final_proceso = mySqlDataReader["final_proceso"].ToString(),
                        proceso = mySqlDataReader["proceso"].ToString(),
                        estado = mySqlDataReader["estado"].ToString(),
                        calidad = mySqlDataReader["calidad"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                secuencia_existente_disponibles_produccion.Add(new Secuencia_produccion()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return secuencia_existente_disponibles_produccion;
        }

        private string Commando_leer_Mysql_filtrpo_fecha_secuencia_produccion(Secuencia_produccion numero_dibujo)
        {
            return "SELECT * FROM secuencia_produccion WHERE numero_dibujo='" + numero_dibujo.Numero_Dibujo +
                "' and proceso='" + numero_dibujo.proceso + "' and estado='Terminado';";
        }

        public List<Secuencia_produccion> Adquiere_secuencia_produccion_busqueda_dibujos_pendientes_empleados(string empleado)
        {
            List<Secuencia_produccion> secuencia_existente_disponibles_produccion = new List<Secuencia_produccion>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_secuencia_produccion());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_busqueda_secuencia_produccion_dibujos_pendientes(empleado), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    secuencia_existente_disponibles_produccion.Add(new Secuencia_produccion()
                    {
                        Codigo = mySqlDataReader["codigo"].ToString(),
                        Numero_Dibujo = mySqlDataReader["numero_dibujo"].ToString(),
                        Empleado = mySqlDataReader["empleado"].ToString(),
                        inicio_proceso = mySqlDataReader["inicio_proceso"].ToString(),
                        final_proceso = mySqlDataReader["final_proceso"].ToString(),
                        proceso = mySqlDataReader["proceso"].ToString(),
                        estado = mySqlDataReader["estado"].ToString(),
                        calidad = mySqlDataReader["calidad"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                secuencia_existente_disponibles_produccion.Add(new Secuencia_produccion()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return secuencia_existente_disponibles_produccion;
        }

        public List<Secuencia_produccion> Adquiere_secuencia_produccion_reporte_fecha_inicio(string fecha_inicio, string fecha_final)
        {
            List<Secuencia_produccion> secuencia_existente_disponibles_produccion = new List<Secuencia_produccion>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_secuencia_produccion());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_busqueda_secuencia_produccion_reporte_fecha_inicio(fecha_inicio, fecha_final), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    secuencia_existente_disponibles_produccion.Add(new Secuencia_produccion()
                    {
                        Codigo = mySqlDataReader["codigo"].ToString(),
                        Numero_Dibujo = mySqlDataReader["numero_dibujo"].ToString(),
                        Empleado = mySqlDataReader["empleado"].ToString(),
                        inicio_proceso = mySqlDataReader["inicio_proceso"].ToString(),
                        final_proceso = mySqlDataReader["final_proceso"].ToString(),
                        proceso = mySqlDataReader["proceso"].ToString(),
                        estado = mySqlDataReader["estado"].ToString(),
                        calidad = mySqlDataReader["calidad"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                secuencia_existente_disponibles_produccion.Add(new Secuencia_produccion()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return secuencia_existente_disponibles_produccion;
        }

        public List<Secuencia_produccion> Adquiere_secuencia_produccion_reporte_fecha_termino(string fecha_inicio, string fecha_final)
        {
            List<Secuencia_produccion> secuencia_existente_disponibles_produccion = new List<Secuencia_produccion>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_secuencia_produccion());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_busqueda_secuencia_produccion_reporte_fecha_termino(fecha_inicio, fecha_final), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    secuencia_existente_disponibles_produccion.Add(new Secuencia_produccion()
                    {
                        Codigo = mySqlDataReader["codigo"].ToString(),
                        Numero_Dibujo = mySqlDataReader["numero_dibujo"].ToString(),
                        Empleado = mySqlDataReader["empleado"].ToString(),
                        inicio_proceso = mySqlDataReader["inicio_proceso"].ToString(),
                        final_proceso = mySqlDataReader["final_proceso"].ToString(),
                        proceso = mySqlDataReader["proceso"].ToString(),
                        estado = mySqlDataReader["estado"].ToString(),
                        calidad = mySqlDataReader["calidad"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                secuencia_existente_disponibles_produccion.Add(new Secuencia_produccion()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return secuencia_existente_disponibles_produccion;
        }

        private string Commando_leer_Mysql_busqueda_secuencia_produccion_reporte_fecha_termino(string fecha_inicio, string fecha_final)
        {
            return "SELECT* FROM produccion.secuencia_produccion " +

             "where " +

             "cast( " +
             "concat( " +
             "substring(produccion.secuencia_produccion.final_proceso," +
             "instr(produccion.secuencia_produccion.final_proceso, ' ') - 4, 4)" +
             ",'/'," +
             "substring(produccion.secuencia_produccion.final_proceso,1," +
             "length(produccion.secuencia_produccion.final_proceso)" +
             "- length(right(produccion.secuencia_produccion.final_proceso," +
             "length(produccion.secuencia_produccion.final_proceso) -" +
             "(instr(produccion.secuencia_produccion.final_proceso, ' ') - 6))))) " +
             "as date) >= '" + fecha_inicio + "' and " +

             "cast( " +
             "concat( " +
             "substring(produccion.secuencia_produccion.final_proceso," +
             "instr(produccion.secuencia_produccion.final_proceso, ' ') - 4, 4)" +
             ",'/'," +
             "substring(produccion.secuencia_produccion.final_proceso,1," +
             "length(produccion.secuencia_produccion.final_proceso)" +
             "- length(right(produccion.secuencia_produccion.final_proceso," +
             "length(produccion.secuencia_produccion.final_proceso) -" +
             "(instr(produccion.secuencia_produccion.final_proceso, ' ') - 6))))) " +
             "as date) <= '" + fecha_final +
             "' and estado='Terminado';";
        }

        private string Commando_leer_Mysql_busqueda_secuencia_produccion_reporte_fecha_inicio(string fecha_inicio, string fecha_final)
        {
            return "SELECT* FROM produccion.secuencia_produccion " +

             "where " +

             "cast( " +
             "concat( " +
             "substring(produccion.secuencia_produccion.inicio_proceso," +
             "instr(produccion.secuencia_produccion.inicio_proceso, ' ') - 4, 4)" +
             ",'/'," +
             "substring(produccion.secuencia_produccion.inicio_proceso,1," +
             "length(produccion.secuencia_produccion.inicio_proceso)" +
             "- length(right(produccion.secuencia_produccion.inicio_proceso," +
             "length(produccion.secuencia_produccion.inicio_proceso) -" +
             "(instr(produccion.secuencia_produccion.inicio_proceso, ' ') - 6))))) " +
             "as date) >= '" + fecha_inicio + "' and "+

             "cast( " +
             "concat( " +
             "substring(produccion.secuencia_produccion.inicio_proceso," +
             "instr(produccion.secuencia_produccion.inicio_proceso, ' ') - 4, 4)" +
             ",'/'," +
             "substring(produccion.secuencia_produccion.inicio_proceso,1," +
             "length(produccion.secuencia_produccion.inicio_proceso)" +
             "- length(right(produccion.secuencia_produccion.inicio_proceso," +
             "length(produccion.secuencia_produccion.inicio_proceso) -" +
             "(instr(produccion.secuencia_produccion.inicio_proceso, ' ') - 6))))) " +
             "as date) <= '" + fecha_final +
             "' and estado='Terminado';";
        }

        private string Commando_leer_Mysql_busqueda_secuencia_produccion_dibujos_pendientes(string empleado)
        {
            return "SELECT * FROM secuencia_produccion WHERE empleado='" + empleado +
                "' and estado='pausado' or estado='Iniciado' and empleado='" + empleado + "';";
        }

        public string Actualiza_base_datos_secuencia_produccion(Secuencia_produccion numero_dibujo)
        {
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_secuencia_produccion());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_en_base_de_datos_modificar_secuencia_produccion(numero_dibujo), connection);
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
        public string Inserta_nuevo_secuencia_produccion_base_datos(Secuencia_produccion numero_dibujo)
        {
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_secuencia_produccion());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_insertar_en_base_de_datos_secuencia_produccion(numero_dibujo), connection);
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

        private string Configura_cadena_comando_insertar_en_base_de_datos_secuencia_produccion(Secuencia_produccion numero_dibujo)
        {
            return "INSERT INTO secuencia_produccion(numero_dibujo, empleado," +
                   "inicio_proceso,final_proceso,proceso,estado,calidad) " +
                   "VALUES('" + numero_dibujo.Numero_Dibujo + "','" + numero_dibujo.Empleado + "','" +
                   numero_dibujo.inicio_proceso + "','" + numero_dibujo.final_proceso + "','" + numero_dibujo.proceso + "','" +
                   numero_dibujo.estado + "','" + numero_dibujo.calidad + "'); ";

        }

        private string Configura_cadena_comando_en_base_de_datos_modificar_secuencia_produccion(Secuencia_produccion numero_dibujo)
        {

            return "UPDATE secuencia_produccion set  numero_dibujo='" + numero_dibujo.Numero_Dibujo +
                "',empleado='" + numero_dibujo.Empleado +
                "',inicio_proceso='" + numero_dibujo.inicio_proceso +
                "',final_proceso='" + numero_dibujo.final_proceso +
                "',proceso='" + numero_dibujo.proceso +
                "',estado='" + numero_dibujo.estado +
                "',calidad='" + numero_dibujo.calidad +
                "' where codigo='" + numero_dibujo.Codigo + "';";

        }

        private string Commando_leer_Mysql_busqueda_secuencia_produccion(Secuencia_produccion numero_dibujo)
        {
            return "SELECT * FROM secuencia_produccion WHERE numero_dibujo='" + numero_dibujo.Numero_Dibujo +
                "' and proceso='"+ numero_dibujo.proceso+"' ;";
        }

        private string Configura_Cadena_Conexion_MySQL_secuencia_produccion()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server +
                ";Database=produccion;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }
    }
    public class Secuencia_produccion
    {
        public string Codigo = "";
        public string Numero_Dibujo = "";
        public string Empleado = "";
        public string inicio_proceso = "";
        public string final_proceso = "";
        public string proceso = "";
        public string estado = "";
        public string calidad = "";
        public string error = "";
    }
}
