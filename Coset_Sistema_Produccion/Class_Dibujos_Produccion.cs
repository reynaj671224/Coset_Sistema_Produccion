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
                        Numero_unidad = mySqlDataReader["numero_unidad"].ToString(),
                        
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

        

        private string Configura_cadena_comando_insertar_en_base_de_datos_dibujo_produccion(Dibujo_produccion numero_dibujo)
        {

            return "INSERT INTO produccion_dibujos(numero_dibujo, proceso," +
                   "proyecto,calidad,numero_unidad) " +
                   "VALUES('" + numero_dibujo.Numero_dibujo + "','" + numero_dibujo.Proceso + "','" +
                   numero_dibujo.proyecto + "','" + numero_dibujo.Calidad + "','" + numero_dibujo.Numero_unidad+"'); ";

        }

        private string Commando_leer_Mysql_busqueda_dibujos_produccion(Dibujo_produccion numero_dibujo)
        {
            return "SELECT * FROM produccion_dibujos WHERE numero_dibujo='" + numero_dibujo.Numero_dibujo +
                "' and numero_unidad = '"+ numero_dibujo.Numero_unidad+ "';";
        }

        private string Configura_Cadena_Conexion_MySQL_dibujos_produccion()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + 
                ";Database=produccion;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
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
        public string Numero_unidad = "";
        public string error = "";
    }
}
