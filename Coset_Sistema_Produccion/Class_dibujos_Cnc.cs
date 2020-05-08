using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_dibujos_Cnc
    {
        public List<Dibujos_cnc> Adquiere_dibujos_cnc_en_base_datos(Dibujos_cnc numero_dibujo)
        {
            List<Dibujos_cnc> secuencia_existente_disponibles_produccion = new List<Dibujos_cnc>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_dibujos_cnc());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_busqueda_dibujos_cnc(numero_dibujo), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    secuencia_existente_disponibles_produccion.Add(new Dibujos_cnc()
                    {
                        Numero_Dibujo = mySqlDataReader["numero_dibujo"].ToString(),
                        Empleado = mySqlDataReader["nombre_empleado"].ToString(),
                        fecha_inicio = mySqlDataReader["fecha_inicio"].ToString(),
                        fecha_final = mySqlDataReader["fecha_final"].ToString(),
                        proceso = mySqlDataReader["proceso"].ToString(),
                        estado = mySqlDataReader["estado"].ToString(),
                        codigo_proyecto = mySqlDataReader["codigo_proyecto"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                secuencia_existente_disponibles_produccion.Add(new Dibujos_cnc()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return secuencia_existente_disponibles_produccion;
        }

        private string Commando_leer_Mysql_busqueda_dibujos_cnc(Dibujos_cnc numero_dibujo)
        {
            return "SELECT * FROM dibujos_cnc WHERE numero_dibujo='" + numero_dibujo.Numero_Dibujo +
            "' and proceso='CNC';";
        }

        public string Inserta_nuevo_dibujo_cnc_base_datos(Dibujos_cnc numero_dibujo)
        {
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_dibujos_cnc());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_insertar_en_base_de_datos_dibujos_cnc(numero_dibujo), connection);
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

        private string Configura_cadena_comando_insertar_en_base_de_datos_dibujos_cnc(Dibujos_cnc numero_dibujo)
        {
            return "INSERT INTO dibujos_cnc(numero_dibujo, nombre_empleado," +
              "fecha_inicio,fecha_final,proceso,estado, codigo_proyecto) " +
              "VALUES('" + numero_dibujo.Numero_Dibujo + "','" + numero_dibujo.Empleado + "','" +
              numero_dibujo.fecha_inicio + "','" + numero_dibujo.fecha_final + "','" + numero_dibujo.proceso + "','" +
              numero_dibujo.estado + "','" + numero_dibujo.codigo_proyecto + "'); ";
        }

        public string Actualiza_base_datos_dibujo_cnc(Dibujos_cnc numero_dibujo)
        {
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_dibujos_cnc());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_en_base_de_datos_modificar_dibujos_cnc(numero_dibujo), connection);
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

        private string Configura_cadena_comando_en_base_de_datos_modificar_dibujos_cnc(Dibujos_cnc numero_dibujo)
        {
            return "UPDATE dibujos_cnc set  fecha_final='" + numero_dibujo.fecha_final +
                 "',estado='" + numero_dibujo.estado +
                "' where numero_dibujo='" + numero_dibujo.Numero_Dibujo + "';";
        }
        private string Configura_Cadena_Conexion_MySQL_dibujos_cnc()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server +
           ";Database=produccion;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }
    }

    public class Dibujos_cnc
    {
        public string Numero_Dibujo = "";
        public string Empleado = "";
        public string fecha_inicio = "";
        public string fecha_final = "";
        public string proceso = "";
        public string estado = "";
        public string error = "";
        public string codigo_proyecto = "";
    }
}
