using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Ordenes_Compra
    {
        public List<Orden_compra> Adquiere_ordenes_compra_disponibles_en_base_datos()
        {
            List<Orden_compra> ordenes_compra_disponibles = new List<Orden_compra>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_compras_partidas_orden_compra());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql(), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    ordenes_compra_disponibles.Add(new Orden_compra()
                    {
                        Codigo = mySqlDataReader["codigo_orden_compra"].ToString(),
                        Proveedor = mySqlDataReader["provedor_compra"].ToString(),
                        Tipo_moneda = mySqlDataReader["tipo_moneda_compra"].ToString(),
                        Fecha = mySqlDataReader["fecha_orden"].ToString(),
                        Condicion_pago = mySqlDataReader["condicion_pago_compra"].ToString(),
                        Realizado = mySqlDataReader["realizado_compra"].ToString(),
                        Cotizado = mySqlDataReader["cotizado_compra"].ToString(),
                        Correo_electronico = mySqlDataReader["correo_contacto_compra"].ToString(),
                        Cotizacion = mySqlDataReader["cotizacion_compra"].ToString(),
                        Requisicion = mySqlDataReader["requisicion"].ToString(),
                        Estado = mySqlDataReader["estado"].ToString(),

                    });
                }
            }
            catch (Exception ex)
            {
                ordenes_compra_disponibles.Add(new Orden_compra()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return ordenes_compra_disponibles;

        }
        private string Commando_leer_Mysql()
        {
            return "SELECT * FROM ordenes_compra";
        }
        private string Configura_Cadena_Conexion_MySQL_compras_partidas_orden_compra()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=compras;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }
        public string Modifica_estado_orden_compra(Orden_compra Orden_compra,string Operacion)
        {
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_compras_partidas_orden_compra());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_modificar_estado_orden_compra(Orden_compra, Operacion), connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                connection.Close();
                return ex.Message;
            }

            connection.Close();
            return "No Errores";
        }

        private string Configura_cadena_comando_modificar_estado_orden_compra(Orden_compra orden_compra, string operacion)
        {
            if (operacion == "Cancelar")
            {
                return "UPDATE ordenes_compra set  estado='Cancelada'" +
                   "where codigo_orden_compra='" + orden_compra.Codigo + "';";
            }
            else if(operacion == "Parcial")
            {
                return "UPDATE ordenes_compra set  estado='Parcial'" +
                   "where codigo_orden_compra='" + orden_compra.Codigo + "';";
            }
            else if(operacion == "Cerrar")
            {
                return "UPDATE ordenes_compra set  estado='Cerrada'" +
                   "where codigo_orden_compra='" + orden_compra.Codigo + "';";
            }
            else
            {
                return "";
            }
        }
    }
    public class Orden_compra
    {
        public string Codigo = "";
        public string Proveedor = "";
        public string Tipo_moneda = "";
        public string Divisa = "";
        public string Fecha = "";
        public string Condicion_pago = "";
        public string Realizado = "";
        public string Cotizado = "";
        public string Correo_electronico = "";
        public string Cotizacion = "";
        public string Requisicion = "";
        public string Estado = "";
        public string error = "";
    }
}
