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
        public List<Secuencia_produccion> Adquiere_dibujos_produccion_busqueda_en_base_datos(Secuencia_produccion numero_dibujo)
        {
            List<Secuencia_produccion> secuancia_existente_disponibles_produccion = new List<Secuencia_produccion>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_secuencia_produccion());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_busqueda_secuencia_produccion(numero_dibujo), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    secuancia_existente_disponibles_produccion.Add(new Secuencia_produccion()
                    {
                        Codigo = mySqlDataReader["codigo"].ToString(),
                        Dibujo = mySqlDataReader["dibujo"].ToString(),
                        Empleado = mySqlDataReader["empleado"].ToString(),
                        inicio_proceso = mySqlDataReader["inicio_proceso"].ToString(),
                        final_proceso = mySqlDataReader["final_proceso"].ToString(),
                        proceso = mySqlDataReader["proceso"].ToString(),
                        estado = mySqlDataReader["estado"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                secuancia_existente_disponibles_produccion.Add(new Secuencia_produccion()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return secuancia_existente_disponibles_produccion;
        }

        private string Commando_leer_Mysql_busqueda_secuencia_produccion(Dibujo_produccion numero_dibujo)
        {
            return "SELECT * FROM secuencia_produccion WHERE dibujo='" + numero_dibujo.Numero_dibujo +
                "and empleado ='" + numero_dibujo.Empleado +  "';";
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
        public string Dibujo = "";
        public string Empleado = "";
        public string inicio_proceso = "";
        public string final_proceso = "";
        public string proceso = "";
        public string estado = "";
        public string error = "";
    }
}
