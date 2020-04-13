using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Dibujos_Produccion
    {
        public List<Dibujo_produccion> Adquiere_dibujos_produccion_busqueda_en_base_datos(Dibujo_produccion numero_dibujo)
        {
            List<Dibujo_produccion> Material_existente_disponibles_dibujos = new List<Dibujo_produccion>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_dibujos_produccion());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_busqueda_dibujos_produccion(numero_dibujo), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    Material_existente_disponibles_dibujos.Add(new Dibujo_produccion()
                    {
                        Numero_dibujo = mySqlDataReader["numero_dibujo"].ToString(),
                        Proceso = mySqlDataReader["proceso"].ToString(),
                        Estado = mySqlDataReader["estado"].ToString(),
                        Calidad = mySqlDataReader["calidad"].ToString(),
                        Secuencia = mySqlDataReader["secuencia"].ToString(),
                        Horas_produccion = mySqlDataReader["horas_produccion"].ToString(),
                        Horas_retrabajo = mySqlDataReader["horas_retrabajo"].ToString(),
                        proyecto = mySqlDataReader["proyecto"].ToString(),
                        Empleado = mySqlDataReader["empleado"].ToString(),

                    });
                }
            }
            catch (Exception ex)
            {
                Material_existente_disponibles_dibujos.Add(new Dibujo_produccion()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return Material_existente_disponibles_dibujos;
        }

        public List<Dibujo_produccion> Adquiere_dibujos_producion_reporte_proyecto_disponibles_en_base_datos(string proyecto)
        {
            List<Dibujo_produccion> Material_existente_disponibles_dibujos = new List<Dibujo_produccion>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_dibujos_produccion());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_busqueda_dibujos_produccion_reporte_proyectos(proyecto), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    Material_existente_disponibles_dibujos.Add(new Dibujo_produccion()
                    {
                        Numero_dibujo = mySqlDataReader["numero_dibujo"].ToString(),
                        Proceso = mySqlDataReader["proceso"].ToString(),
                        Estado = mySqlDataReader["estado"].ToString(),
                        Calidad = mySqlDataReader["calidad"].ToString(),
                        Secuencia = mySqlDataReader["secuencia"].ToString(),
                        Horas_produccion = mySqlDataReader["horas_produccion"].ToString(),
                        Horas_retrabajo = mySqlDataReader["horas_retrabajo"].ToString(),
                        proyecto = mySqlDataReader["proyecto"].ToString(),
                        Empleado = mySqlDataReader["empleado"].ToString(),

                    });
                }
            }
            catch (Exception ex)
            {
                Material_existente_disponibles_dibujos.Add(new Dibujo_produccion()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return Material_existente_disponibles_dibujos;
        }

        private string Commando_leer_Mysql_busqueda_dibujos_produccion_reporte_proyectos(string proyecto)
        {
            return "SELECT * FROM produccion_dibujos WHERE proyecto='" + proyecto +
                "' and calidad='Aceptado'; ";
        }

        public List<Dibujo_produccion> Adquiere_dibujos_produccion_busqueda_en_base_datos_en_calidad()
        {
            List<Dibujo_produccion> Material_existente_disponibles_dibujos = new List<Dibujo_produccion>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_dibujos_produccion());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_busqueda_dibujos_produccion_en_calidad(), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    Material_existente_disponibles_dibujos.Add(new Dibujo_produccion()
                    {
                        Numero_dibujo = mySqlDataReader["numero_dibujo"].ToString(),
                        Proceso = mySqlDataReader["proceso"].ToString(),
                        Estado = mySqlDataReader["estado"].ToString(),
                        Calidad = mySqlDataReader["calidad"].ToString(),
                        Secuencia = mySqlDataReader["secuencia"].ToString(),
                        Horas_produccion = mySqlDataReader["horas_produccion"].ToString(),
                        Horas_retrabajo = mySqlDataReader["horas_retrabajo"].ToString(),
                        proyecto = mySqlDataReader["proyecto"].ToString(),
                        Empleado = mySqlDataReader["empleado"].ToString(),

                    });
                }
            }
            catch (Exception ex)
            {
                Material_existente_disponibles_dibujos.Add(new Dibujo_produccion()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return Material_existente_disponibles_dibujos;
        }

        private string Commando_leer_Mysql_busqueda_dibujos_produccion_en_calidad()
        {
            return "SELECT * FROM produccion_dibujos WHERE secuencia='Calidad';";
        }

        public List<Dibujo_produccion> Adquiere_dibujos_produccion_por_empleado_busqueda_en_base_datos(Dibujo_produccion numero_dibujo)
        {
            List<Dibujo_produccion> Material_existente_disponibles_dibujos = new List<Dibujo_produccion>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_dibujos_produccion());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_busqueda_dibujos_por_empleado_produccion(numero_dibujo), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    Material_existente_disponibles_dibujos.Add(new Dibujo_produccion()
                    {
                        Numero_dibujo = mySqlDataReader["numero_dibujo"].ToString(),
                        Proceso = mySqlDataReader["proceso"].ToString(),
                        Estado = mySqlDataReader["estado"].ToString(),
                        Calidad = mySqlDataReader["calidad"].ToString(),
                        Secuencia = mySqlDataReader["secuencia"].ToString(),
                        Horas_produccion = mySqlDataReader["horas_produccion"].ToString(),
                        Horas_retrabajo = mySqlDataReader["horas_retrabajo"].ToString(),
                        proyecto = mySqlDataReader["proyecto"].ToString(),
                        Empleado = mySqlDataReader["empleado"].ToString(),

                    });
                }
            }
            catch (Exception ex)
            {
                Material_existente_disponibles_dibujos.Add(new Dibujo_produccion()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return Material_existente_disponibles_dibujos;
        }

        private string Commando_leer_Mysql_busqueda_dibujos_por_empleado_produccion(Dibujo_produccion numero_dibujo)
        {
            return "SELECT * FROM produccion_dibujos WHERE empleado='" + numero_dibujo.Empleado + "';";
        }

        public string Inserta_nuevo_dibujo_produccion_base_datos(Dibujo_produccion numero_dibujo)
        {
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_dibujos_produccion());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_insertar_en_base_de_datos_dibujo_produccion(numero_dibujo), connection);
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

        public string Actualiza_base_datos_dibujo_produccion(Dibujo_produccion numero_dibujo)
        {
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_dibujos_produccion());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_en_base_de_datos_modificar_dibujos_produccion(numero_dibujo), connection);
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



        private string Configura_cadena_comando_insertar_en_base_de_datos_dibujo_produccion(Dibujo_produccion numero_dibujo)
        {

            return "INSERT INTO produccion_dibujos(numero_dibujo, proceso," +
                   "proyecto,calidad,empleado) " +
                   "VALUES('" + numero_dibujo.Numero_dibujo + "','" + numero_dibujo.Proceso + "','" +
                   numero_dibujo.proyecto + "','" + numero_dibujo.Calidad + "','" + numero_dibujo.Empleado + "'); ";

        }

        private string Commando_leer_Mysql_busqueda_dibujos_produccion(Dibujo_produccion numero_dibujo)
        {
            return "SELECT * FROM produccion_dibujos WHERE numero_dibujo='" + numero_dibujo.Numero_dibujo +
                "' and proceso='" + numero_dibujo.Proceso + "'; ";
        }

        private string Configura_Cadena_Conexion_MySQL_dibujos_produccion()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + 
                ";Database=produccion;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }

        private string Configura_cadena_comando_en_base_de_datos_modificar_dibujos_produccion(Dibujo_produccion numero_dibujo)
        {
            return "UPDATE produccion_dibujos set  estado='" + numero_dibujo.Estado +
                "',calidad='" + numero_dibujo.Calidad +
                "',secuencia='" + numero_dibujo.Secuencia +
                "',horas_produccion='" + numero_dibujo.Horas_produccion +
                "',horas_retrabajo='" + numero_dibujo.Horas_retrabajo +
                "',proyecto='" + numero_dibujo.proyecto +
                "',empleado='" + numero_dibujo.Empleado +
                "' where numero_dibujo='" + numero_dibujo.Numero_dibujo +
                "' and proceso='" + numero_dibujo.Proceso + "';";
        }


    }
    public class Dibujo_produccion
    {
        public string Numero_dibujo = "";
        public string Proceso = "";
        public string Estado = "";
        public string Calidad = "";
        public string Secuencia = "";
        public string Horas_produccion = "";
        public string Horas_retrabajo = "";
        public string proyecto = "";
        public string Empleado = "";
        public string error = "";
    }
}
