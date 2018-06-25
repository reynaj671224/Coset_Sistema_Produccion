using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Control_Folios
    {
        public Control_folio Obtener_informacion_control_folio_base_datos()
        {
            Control_folio control_Folio = new Control_folio();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_sistema_datos_generales());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_control_folios(), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                mySqlDataReader.Read();
                control_Folio.Folio_clientes = mySqlDataReader["foilio_clientes"].ToString();
                control_Folio.Folio_proveedores = mySqlDataReader["folio_proveedores"].ToString();
                control_Folio.Folio_ot = mySqlDataReader["folio_ot"].ToString();
                control_Folio.Folio_cotizaciones = mySqlDataReader["folio_cotizaciones"].ToString();
                control_Folio.Folio_oc = mySqlDataReader["foilio_oc"].ToString();
                control_Folio.Folio_proyectos = mySqlDataReader["folio_proyectos"].ToString();
                control_Folio.Folio_materiales = mySqlDataReader["folio_materiales"].ToString();
                control_Folio.Folio_control = mySqlDataReader["control_folio"].ToString();
                control_Folio.Folio_procesos = mySqlDataReader["folio_procesos"].ToString();
                control_Folio.Folio_requisiciones = mySqlDataReader["folio_requisiciones"].ToString();
            }
            catch (Exception ex)
            {
                control_Folio.error=ex.Message;
            }
            connection.Close();
            return control_Folio;
        }

        private string Commando_leer_Mysql_control_folios()
        {
            return "SELECT * FROM sistema.control_folio";
        }
        private string Configura_Cadena_Conexion_MySQL_sistema_datos_generales()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=sistema;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }

        public string Actualiza_Control_folios_base_datos(Control_folio control_folio_modificacion)
        {
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_sistema_datos_generales());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_modificar_en_base_de_datos_control_folios(control_folio_modificacion), connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                connection.Close();
                return ex.Message;
            }

            connection.Close();
            return "";
        }

        private string Configura_cadena_comando_modificar_en_base_de_datos_control_folios(Control_folio control_folio)
        {
            return "UPDATE control_folio set  foilio_clientes='" + control_folio.Folio_clientes +
               "',folio_proveedores='" + control_folio.Folio_proveedores +
               "',folio_ot='" + control_folio.Folio_ot +
               "',folio_cotizaciones='" + control_folio.Folio_cotizaciones +
               "',foilio_oc='" + control_folio.Folio_oc +
               "',folio_proyectos='" + control_folio.Folio_proyectos +
               "',folio_materiales='" + control_folio.Folio_materiales +
               "',folio_procesos='" + control_folio.Folio_procesos +
               "',folio_requisiciones='" + control_folio.Folio_requisiciones +
               "' where control_folio = '1';";
        }
    }
    public class Control_folio
    {
        public string Folio_clientes = "";
        public string Folio_proveedores = "";
        public string Folio_ot = "";
        public string Folio_cotizaciones = "";
        public string Folio_oc = "";
        public string Folio_proyectos = "";
        public string Folio_materiales = "";
        public string Folio_control = "";
        public string Folio_procesos = "";
        public string Folio_requisiciones = "";
        public string error = "";
    }
}
