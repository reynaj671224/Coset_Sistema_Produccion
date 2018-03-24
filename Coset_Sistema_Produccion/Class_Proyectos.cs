using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Proyectos
    {
        public List<Proyecto> Adquiere_proyectos_disponibles_en_base_datos()
        {
            List<Proyecto> cotizaciones_disponibles = new List<Proyecto>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_ingenieria_cotizaciones());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql(), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    cotizaciones_disponibles.Add(new Proyecto()
                    {
                        Codigo = mySqlDataReader["codigo_proyecto"].ToString(),
                        Nombre = mySqlDataReader["nombre_proyecto"].ToString(),
                        Modelo = mySqlDataReader["modelo_proyecto"].ToString(),
                        Serie = mySqlDataReader["serie_proyecto"].ToString(),
                        Codigo_cotizacion = mySqlDataReader["codigo_cotizacion"].ToString(),
                        Codigo_orden_compra = mySqlDataReader["codigo_orden_compra"].ToString(),
                        Fecha_inicio = mySqlDataReader["fecha_inicio"].ToString(),
                        Fecha_entrega = mySqlDataReader["fecha_entrega"].ToString(),
                        Codigo_cliente = mySqlDataReader["codigo_cliente"].ToString(),
                        Nombre_cliente = mySqlDataReader["nombre_cliente"].ToString(),
                        Ingeniero_coset = mySqlDataReader["ingeniero_coset_proyecto"].ToString(),
                        Ingeriero_cliente = mySqlDataReader["ingeniero_cliente_proyecto"].ToString(),
                        Ubliacion_dibujos = mySqlDataReader["ubicacion_dibujos"].ToString(),
                        SubProyecto = mySqlDataReader["sub_proyecto"].ToString()

                    });
                }
            }
            catch (Exception ex)
            {
                cotizaciones_disponibles.Add(new Proyecto()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return cotizaciones_disponibles;
        }
        private string Commando_leer_Mysql()
        {
            return "SELECT * FROM proyectos";
        }

        private string Configura_Cadena_Conexion_MySQL_ingenieria_cotizaciones()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=ingenieria;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }
    }
    public class Proyecto
    {
        public string Codigo = "";
        public string Nombre = "";
        public string Modelo = "";
        public string Serie = "";
        public string Codigo_cotizacion = "";
        public string Codigo_orden_compra = "";
        public string Fecha_inicio = "";
        public string Fecha_entrega = "";
        public string Codigo_cliente = "";
        public string Nombre_cliente = "";
        public string Ingeniero_coset = "";
        public string Ingeriero_cliente = "";
        public string Ubliacion_dibujos = "";
        public string SubProyecto = "";
        public string error = "";
    }
}
