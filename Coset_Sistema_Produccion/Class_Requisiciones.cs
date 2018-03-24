using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Requisiciones
    {
        public List<Requisicion> Adquiere_requisiciones_disponibles_en_base_datos()
        {
            List<Requisicion> cotizaciones_disponibles = new List<Requisicion>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_compras_requisiciones());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql(), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    cotizaciones_disponibles.Add(new Requisicion()
                    {
                        Codigo = mySqlDataReader["codigo_requisicion"].ToString(),
                        Requisitor = mySqlDataReader["requisitor_requisicion"].ToString(),
                        Dirigido = mySqlDataReader["diriguido_requisicion"].ToString(),
                        Fecha = mySqlDataReader["fecha_requisicion"].ToString(),
                        Proveedor_asignado = mySqlDataReader["proveedor_asignado"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                cotizaciones_disponibles.Add(new Requisicion()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return cotizaciones_disponibles;
        }

        public List<Requisicion> Adquiere_requisiciones_abiertas_disponibles_en_base_datos(string usuario_administrativo)
        {
            List<Requisicion> cotizaciones_disponibles = new List<Requisicion>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_compras_requisiciones());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_requisiciones_abiertas(usuario_administrativo), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    cotizaciones_disponibles.Add(new Requisicion()
                    {
                        Codigo = mySqlDataReader["codigo_requisicion"].ToString(),
                        Requisitor = mySqlDataReader["requisitor_requisicion"].ToString(),
                        Dirigido = mySqlDataReader["diriguido_requisicion"].ToString(),
                        Fecha = mySqlDataReader["fecha_requisicion"].ToString(),
                        Proveedor_asignado = mySqlDataReader["proveedor_asignado"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                cotizaciones_disponibles.Add(new Requisicion()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return cotizaciones_disponibles;
        }

        private string Commando_leer_Mysql_requisiciones_abiertas(string usuario_administrativo)
        {
            return "SELECT * FROM requisiciones where diriguido_requisicion='" + usuario_administrativo + "' and " +
                "proveedor_asignado='No_asignado';";
        }

        private string Commando_leer_Mysql()
        {
            return "SELECT * FROM requisiciones";
        }

        private string Configura_Cadena_Conexion_MySQL_compras_requisiciones()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=compras;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }


    }
    public class Requisicion
    {
            public string Codigo = "";
            public string Requisitor = "";
            public string Dirigido = "";
            public string Fecha = "";
            public string Proveedor_asignado = "";
            public string error = "";
    }
}
