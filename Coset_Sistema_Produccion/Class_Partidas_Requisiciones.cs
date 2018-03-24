using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Partidas_Requisiciones
    {
        public List<Partida_requisicion> Adquiere_partidas_requisiciones_disponibles_en_base_datos(string codigo_requisicion)
        {
            List<Partida_requisicion> cotizaciones_disponibles = new List<Partida_requisicion>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_compras_requisiciones());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql(codigo_requisicion), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    cotizaciones_disponibles.Add(new Partida_requisicion()
                    {
                        Codigo = (int)mySqlDataReader["codigo_partida"],
                        Codigo_requisicion= mySqlDataReader["codigo_requisicion"].ToString(),
                        Partida = mySqlDataReader["partida_requisicion"].ToString(),
                        Cantidad = mySqlDataReader["cantidad_requisicion"].ToString(),
                        Descripcion = mySqlDataReader["descripcion_requisicion"].ToString(),
                        Unidad_medida = mySqlDataReader["unidad_medida"].ToString(),
                        Proyecto = mySqlDataReader["proyecto_requisicion"].ToString(),
                        Proveedor = mySqlDataReader["proveedor_requisicion"].ToString(),
                        Numero = mySqlDataReader["numero_parte"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                cotizaciones_disponibles.Add(new Partida_requisicion()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return cotizaciones_disponibles;
        }

        public List<Partida_requisicion> Adquiere_partidas_requisiciones_disponibles_en_base_datos_orden_compra_no_asignadas(string nombre_proveedor)
        {
            List<Partida_requisicion> cotizaciones_disponibles = new List<Partida_requisicion>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_compras_requisiciones());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_ordenes_compra_no_asignadas(nombre_proveedor), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    cotizaciones_disponibles.Add(new Partida_requisicion()
                    {
                        Codigo = (int)mySqlDataReader["codigo_partida"],
                        Codigo_requisicion = mySqlDataReader["codigo_requisicion"].ToString(),
                        Partida = mySqlDataReader["partida_requisicion"].ToString(),
                        Cantidad = mySqlDataReader["cantidad_requisicion"].ToString(),
                        Descripcion = mySqlDataReader["descripcion_requisicion"].ToString(),
                        Unidad_medida = mySqlDataReader["unidad_medida"].ToString(),
                        Proyecto = mySqlDataReader["proyecto_requisicion"].ToString(),
                        Proveedor = mySqlDataReader["proveedor_requisicion"].ToString(),
                        Numero = mySqlDataReader["numero_parte"].ToString(),
                        orden_compra = mySqlDataReader["orden_compra_asignada"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                cotizaciones_disponibles.Add(new Partida_requisicion()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return cotizaciones_disponibles;
        }

        public List<Partida_requisicion> Adquiere_partidas_requisiciones_disponibles_numero_parte_en_base_datos(string nombre_proveedor)
        {
            List<Partida_requisicion> cotizaciones_disponibles = new List<Partida_requisicion>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_compras_requisiciones());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_requsisiciones_numero_parte(nombre_proveedor), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    cotizaciones_disponibles.Add(new Partida_requisicion()
                    {
                        Codigo = (int)mySqlDataReader["codigo_partida"],
                        Codigo_requisicion = mySqlDataReader["codigo_requisicion"].ToString(),
                        Partida = mySqlDataReader["partida_requisicion"].ToString(),
                        Cantidad = mySqlDataReader["cantidad_requisicion"].ToString(),
                        Descripcion = mySqlDataReader["descripcion_requisicion"].ToString(),
                        Unidad_medida = mySqlDataReader["unidad_medida"].ToString(),
                        Proyecto = mySqlDataReader["proyecto_requisicion"].ToString(),
                        Proveedor = mySqlDataReader["proveedor_requisicion"].ToString(),
                        Numero = mySqlDataReader["numero_parte"].ToString(),
                        orden_compra = mySqlDataReader["orden_compra_asignada"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                cotizaciones_disponibles.Add(new Partida_requisicion()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return cotizaciones_disponibles;
        }

        private string Commando_leer_Mysql_requsisiciones_numero_parte( string nombre_proveedor)
        {
            return "SELECT * FROM partidas_requisiciones WHERE proveedor_requisicion='" + nombre_proveedor + "';";
        }

        private string Commando_leer_Mysql_ordenes_compra_no_asignadas(string nombre_proveedor)
        {
            return "SELECT * FROM partidas_requisiciones WHERE proveedor_requisicion='" + nombre_proveedor + "'" +
                "and orden_compra_asignada = 'No_Asignada';";
        }

        private string Commando_leer_Mysql(string codigo_requisicion)
        {
            return "SELECT * FROM partidas_requisiciones WHERE codigo_requisicion='" + codigo_requisicion + "';";
        }

        private string Configura_Cadena_Conexion_MySQL_compras_requisiciones()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=compras;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }
    }
    public class Partida_requisicion
    {
        public int Codigo = 0;
        public string Codigo_requisicion = "";
        public string Partida = "";
        public string Cantidad = "";
        public string Descripcion = "";
        public string Unidad_medida = "";
        public string Proyecto = "";
        public string Proveedor = "";
        public string Numero = "";
        public string orden_compra = "";
        public string error = "";

    }


}
