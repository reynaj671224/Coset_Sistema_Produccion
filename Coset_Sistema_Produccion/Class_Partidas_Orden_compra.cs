using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Partidas_Orden_compra
    {
        public List<Partida_orden_compra> Adquiere_partidas_ordenes_compra_disponibles_en_base_datos(string codigo_orden_compra)
        {
            List<Partida_orden_compra> ordenes_compra_disponibles = new List<Partida_orden_compra>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_compras_partidas_orden_compra());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql(codigo_orden_compra), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    ordenes_compra_disponibles.Add(new Partida_orden_compra()
                    {
                        Codigo = (int)mySqlDataReader["codigo_partida"],
                        Codigo_orden = mySqlDataReader["codigo_orden_compra"].ToString(),
                        Partida = mySqlDataReader["partida_compra"].ToString(),
                        Material = mySqlDataReader["material_compra"].ToString(),
                        Cantidad = mySqlDataReader["cantidad_compra"].ToString(),
                        Parte = mySqlDataReader["parte_compra"].ToString(),
                        Descripcion = mySqlDataReader["descripcion_compra"].ToString(),
                        Unidad_medida = mySqlDataReader["unidad_medida"].ToString(),
                        Proyecto = mySqlDataReader["proyecto_compra"].ToString(),
                        precio_unitario = mySqlDataReader["precio_unitario"].ToString(),
                        Total = mySqlDataReader["total_compra"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                ordenes_compra_disponibles.Add(new Partida_orden_compra()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return ordenes_compra_disponibles;
        }

        private string Commando_leer_Mysql(string Codigo_orden_compra)
        {
            return "SELECT * FROM partidas_oredenes_compra WHERE codigo_orden_compra='" + Codigo_orden_compra + "';";
        }

        private string Configura_Cadena_Conexion_MySQL_compras_partidas_orden_compra()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=compras;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }
    }

    public class Partida_orden_compra
    {
        public int Codigo = 0;
        public string Codigo_orden = "";
        public string Partida = "";
        public string Material = "";
        public string Cantidad = "";
        public string Parte = "";
        public string Descripcion = "";
        public string Unidad_medida = "";
        public string Proyecto = "";
        public string precio_unitario = "";
        public string Total = "";
        public string error = "";
    }
}
