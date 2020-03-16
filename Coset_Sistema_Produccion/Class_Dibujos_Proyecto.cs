using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Dibujos_Proyecto
    {
        public List<Dibujos_proyecto> Adquiere_dibujos_proyecto_disponibles_en_base_datos(string Codigo_proyecto)
        {
            List<Dibujos_proyecto> clientes_disponibles = new List<Dibujos_proyecto>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_ingenieria_dibujos_proyecto());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql(Codigo_proyecto), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    clientes_disponibles.Add(new Dibujos_proyecto()
                    {
                        Codigo = (int)mySqlDataReader["codigo_dibujo"],
                        Numero = mySqlDataReader["numero_dibujo"].ToString(),
                        Cantidad = mySqlDataReader["cantidad_dibujos"].ToString(),
                        Descripcion = mySqlDataReader["descripcion_dibujo"].ToString(),
                        proceso = mySqlDataReader["proceso"].ToString(),
                        tiempo_estimado_horas = mySqlDataReader["tiempo_estimado_horas"].ToString(),
                        Tipo_proceso = mySqlDataReader["tipo_proceso"].ToString(),
                        Actividades_proceso_electrico = mySqlDataReader["actividades_proceso_electrico"].ToString(),
                        Codigo_proyecto = mySqlDataReader["codigo_proyecto"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                clientes_disponibles.Add(new Dibujos_proyecto()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return clientes_disponibles;

        }

        public List<Dibujos_proyecto> adquiere_dibujos_proyecto_duplicados(string codigo_proyecto,string numero_dibujo)
        {
            List<Dibujos_proyecto> clientes_disponibles = new List<Dibujos_proyecto>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_ingenieria_dibujos_proyecto());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_dibujos_duplicados(codigo_proyecto, numero_dibujo), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    clientes_disponibles.Add(new Dibujos_proyecto()
                    {
                        Codigo = (int)mySqlDataReader["codigo_dibujo"],
                        Numero = mySqlDataReader["numero_dibujo"].ToString(),
                        Cantidad = mySqlDataReader["cantidad_dibujos"].ToString(),
                        Descripcion = mySqlDataReader["descripcion_dibujo"].ToString(),
                        proceso = mySqlDataReader["proceso"].ToString(),
                        tiempo_estimado_horas = mySqlDataReader["tiempo_estimado_horas"].ToString(),
                        Tipo_proceso = mySqlDataReader["tipo_proceso"].ToString(),
                        Actividades_proceso_electrico = mySqlDataReader["actividades_proceso_electrico"].ToString(),
                        Codigo_proyecto = mySqlDataReader["codigo_proyecto"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                clientes_disponibles.Add(new Dibujos_proyecto()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return clientes_disponibles;

        }

        private string Commando_leer_Mysql_dibujos_duplicados(string codigo_proyecto, string numero_dibujo)
        {
            return "SELECT * FROM dibujos_proyecto WHERE codigo_proyecto='" + codigo_proyecto + "'" +
                "and numero_dibujo='"+ numero_dibujo + "';";
        }

        public List<Dibujos_proyecto> Adquiere_dibujos_proyecto_disponibles_procesos(string proceso)
        {
            List<Dibujos_proyecto> clientes_disponibles = new List<Dibujos_proyecto>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_ingenieria_dibujos_proyecto());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_dibujos_proyecto_proceso(proceso), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    clientes_disponibles.Add(new Dibujos_proyecto()
                    {
                        Codigo = (int)mySqlDataReader["codigo_dibujo"],
                        Numero = mySqlDataReader["numero_dibujo"].ToString(),
                        Cantidad = mySqlDataReader["cantidad_dibujos"].ToString(),
                        Descripcion = mySqlDataReader["descripcion_dibujo"].ToString(),
                        proceso = mySqlDataReader["proceso"].ToString(),
                        tiempo_estimado_horas = mySqlDataReader["tiempo_estimado_horas"].ToString(),
                        Tipo_proceso = mySqlDataReader["tipo_proceso"].ToString(),
                        Actividades_proceso_electrico = mySqlDataReader["actividades_proceso_electrico"].ToString(),
                        Codigo_proyecto = mySqlDataReader["codigo_proyecto"].ToString()

                    });
                }
            }
            catch (Exception ex)
            {
                clientes_disponibles.Add(new Dibujos_proyecto()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return clientes_disponibles;

        }

        private string Commando_leer_dibujos_proyecto_proceso(string proceso)
        {
            return "SELECT * FROM dibujos_proyecto WHERE proceso='" + proceso + "';";
        }

        public List<Dibujos_proyecto> Adquiere_dibujos_proyecto_disponibles_actividades_procesos_electricos(string Actividad)
        {
            List<Dibujos_proyecto> clientes_disponibles = new List<Dibujos_proyecto>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_ingenieria_dibujos_proyecto());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_dibujos_proyecto_actividad_proceso_electrico(Actividad), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    clientes_disponibles.Add(new Dibujos_proyecto()
                    {
                        Codigo = (int)mySqlDataReader["codigo_dibujo"],
                        Numero = mySqlDataReader["numero_dibujo"].ToString(),
                        Cantidad = mySqlDataReader["cantidad_dibujos"].ToString(),
                        Descripcion = mySqlDataReader["descripcion_dibujo"].ToString(),
                        proceso = mySqlDataReader["proceso"].ToString(),
                        tiempo_estimado_horas = mySqlDataReader["tiempo_estimado_horas"].ToString(),
                        Tipo_proceso = mySqlDataReader["tipo_proceso"].ToString(),
                        Actividades_proceso_electrico = mySqlDataReader["actividades_proceso_electrico"].ToString(),
                        Codigo_proyecto = mySqlDataReader["codigo_proyecto"].ToString()

                    });
                }
            }
            catch (Exception ex)
            {
                clientes_disponibles.Add(new Dibujos_proyecto()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return clientes_disponibles;

        }

        private string Commando_leer_dibujos_proyecto_actividad_proceso_electrico(string actividad)
        {
            return "SELECT * FROM dibujos_proyecto WHERE actividades_proceso_electrico='" + actividad + "';";
        }

        public List<Dibujos_proyecto> Adquiere_dibujos_disponibles_en_base_datos(string numero_dibujo)
        {
            List<Dibujos_proyecto> clientes_disponibles = new List<Dibujos_proyecto>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_ingenieria_dibujos_proyecto());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_numero_dibujo(numero_dibujo), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    clientes_disponibles.Add(new Dibujos_proyecto()
                    {
                        Codigo = (int)mySqlDataReader["codigo_dibujo"],
                        Numero = mySqlDataReader["numero_dibujo"].ToString(),
                        Cantidad = mySqlDataReader["cantidad_dibujos"].ToString(),
                        Descripcion = mySqlDataReader["descripcion_dibujo"].ToString(),
                        proceso = mySqlDataReader["proceso"].ToString(),
                        tiempo_estimado_horas = mySqlDataReader["tiempo_estimado_horas"].ToString(),
                        Tipo_proceso = mySqlDataReader["tipo_proceso"].ToString(),
                        Actividades_proceso_electrico = mySqlDataReader["actividades_proceso_electrico"].ToString(),
                        Codigo_proyecto = mySqlDataReader["codigo_proyecto"].ToString(),
                        
                    });
                }
            }
            catch (Exception ex)
            {
                clientes_disponibles.Add(new Dibujos_proyecto()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return clientes_disponibles;

        }

        public List<Dibujos_proyecto> Adquiere_dibujos_proceso_proyecto_disponibles_en_base_datos(Dibujos_proyecto dibujo)
        {
            List<Dibujos_proyecto> clientes_disponibles = new List<Dibujos_proyecto>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_ingenieria_dibujos_proyecto());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_numero_dibujo_proceso_proyecto(dibujo), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    clientes_disponibles.Add(new Dibujos_proyecto()
                    {
                        Codigo = (int)mySqlDataReader["codigo_dibujo"],
                        Numero = mySqlDataReader["numero_dibujo"].ToString(),
                        Cantidad = mySqlDataReader["cantidad_dibujos"].ToString(),
                        Descripcion = mySqlDataReader["descripcion_dibujo"].ToString(),
                        proceso = mySqlDataReader["proceso"].ToString(),
                        tiempo_estimado_horas = mySqlDataReader["tiempo_estimado_horas"].ToString(),
                        Tipo_proceso = mySqlDataReader["tipo_proceso"].ToString(),
                        Actividades_proceso_electrico = mySqlDataReader["actividades_proceso_electrico"].ToString(),
                        Codigo_proyecto = mySqlDataReader["codigo_proyecto"].ToString(),

                    });
                }
            }
            catch (Exception ex)
            {
                clientes_disponibles.Add(new Dibujos_proyecto()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return clientes_disponibles;

        }

        private string Commando_leer_Mysql_numero_dibujo_proceso_proyecto(Dibujos_proyecto dibujo)
        {
            return "SELECT * FROM dibujos_proyecto WHERE numero_dibujo='" + dibujo.Numero +
                "' and proceso='"+ dibujo.proceso + "';";
        }

        public string Actualiza_base_datos_dibujo_proyecto(Dibujos_proyecto numero_dibujo)
        {
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_ingenieria_dibujos_proyecto());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_en_base_de_datos_modificar_dibujos_proyecto(numero_dibujo), connection);
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

        private string Commando_leer_Mysql_numero_dibujo(object numero_dibujo)
        {
            return "SELECT * FROM dibujos_proyecto WHERE numero_dibujo='" + numero_dibujo + "';";
        }

        private string Commando_leer_Mysql(string Codigo_proyecto)
        {
            return "SELECT * FROM dibujos_proyecto WHERE codigo_proyecto='" + Codigo_proyecto + "';";
        }

        private string Configura_Cadena_Conexion_MySQL_ingenieria_dibujos_proyecto()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=ingenieria;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }

        private string Configura_cadena_comando_en_base_de_datos_modificar_dibujos_proyecto(Dibujos_proyecto partidas_proyecto)
        {
            return "UPDATE dibujos_proyecto set  cantidad_dibujos='" + partidas_proyecto.Cantidad +
                "',numero_dibujo='" + partidas_proyecto.Numero +
                "',descripcion_dibujo='" + partidas_proyecto.Descripcion +
                "',proceso='" + partidas_proyecto.proceso +
                "',tiempo_estimado_horas='" + partidas_proyecto.tiempo_estimado_horas +
                "',tipo_proceso='" + partidas_proyecto.Tipo_proceso +
                "',actividades_proceso_electrico='" + partidas_proyecto.Tipo_proceso +
                "' where codigo_dibujo='" + partidas_proyecto.Codigo + "';";
        }


    }
    public class Dibujos_proyecto
    {
        public int Codigo = 0;
        public string Cantidad = "";
        public string Numero = "";
        public string Descripcion = "";
        public string proceso = "";
        public string tiempo_estimado_horas = "";
        public string Codigo_proyecto = "";
        public string Tipo_proceso = "";
        public string Actividades_proceso_electrico = "";
        public string error = "";

    }
}
