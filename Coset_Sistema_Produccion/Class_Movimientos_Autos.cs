using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Movimientos_Autos
    {
        public List<Movimiento_auto> Adquiere_movimientos_autos_busqueda_en_base_datos(string descripcion_auto)
        {
            List<Movimiento_auto> Movimientos_autos_disponibles = new List<Movimiento_auto>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_autos());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_busqueda_movimiento_autos(descripcion_auto), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    Movimientos_autos_disponibles.Add(new Movimiento_auto()
                    {
                        Codigo = mySqlDataReader["codigo_movimiento"].ToString(),
                        Hora_salida = mySqlDataReader["salida_hora"].ToString(),
                        Fecha_salida = mySqlDataReader["salida_fecha"].ToString(),
                        Hora_entrada = mySqlDataReader["entrada_hora"].ToString(),
                        Fecha_entrada = mySqlDataReader["entrada_fecha"].ToString(),
                        Auto_descripcion = mySqlDataReader["auto_descripcion"].ToString(),
                        Nombre_visita = mySqlDataReader["nombre_visita"].ToString(),
                        Nombre_contacto = mySqlDataReader["nombre_contacto"].ToString(),
                        Empleados = mySqlDataReader["empleados"].ToString(),
                        Status = mySqlDataReader["status"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                Movimientos_autos_disponibles.Add(new Movimiento_auto()
                { Error = ex.Message.ToString() });
            }
            connection.Close();
            return Movimientos_autos_disponibles;
        }

        public List<Movimiento_auto> Adquiere_movimientos_autos_en_uso_busqueda_en_base_datos(string descripcion_auto)
        {
            List<Movimiento_auto> Movimientos_autos_disponibles = new List<Movimiento_auto>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_autos());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_busqueda_movimiento_autos_en_uso(descripcion_auto), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    Movimientos_autos_disponibles.Add(new Movimiento_auto()
                    {
                        Codigo = mySqlDataReader["codigo_movimiento"].ToString(),
                        Hora_salida = mySqlDataReader["salida_hora"].ToString(),
                        Fecha_salida = mySqlDataReader["salida_fecha"].ToString(),
                        Hora_entrada = mySqlDataReader["entrada_hora"].ToString(),
                        Fecha_entrada = mySqlDataReader["entrada_fecha"].ToString(),
                        Auto_descripcion = mySqlDataReader["auto_descripcion"].ToString(),
                        Nombre_visita = mySqlDataReader["nombre_visita"].ToString(),
                        Nombre_contacto = mySqlDataReader["nombre_contacto"].ToString(),
                        Empleados = mySqlDataReader["empleados"].ToString(),
                        Status = mySqlDataReader["status"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                Movimientos_autos_disponibles.Add(new Movimiento_auto()
                { Error = ex.Message.ToString() });
            }
            connection.Close();
            return Movimientos_autos_disponibles;
        }

        private string Commando_leer_Mysql_busqueda_movimiento_autos_en_uso(string descripcion_auto)
        {
            return "SELECT * FROM movimientos_autos where auto_descripcion='"+ descripcion_auto + "'" +
                " and status='Usando';";
        }

        private string Commando_leer_Mysql_busqueda_movimiento_autos(string descripcion_auto)
        {
            return "SELECT * FROM movimientos_autos where auto_descripcion ='" + descripcion_auto +"'";
        }

        public string Inserta_nuevo_movimiento_auto_base_datos(Movimiento_auto autos_movimiento)
        {
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_autos());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_insertar_en_base_de_datos_movimiento_auto(autos_movimiento), connection);
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

        private string Configura_cadena_comando_insertar_en_base_de_datos_movimiento_auto(Movimiento_auto autos_movimiento)
        {
            return "INSERT INTO movimientos_autos(salida_hora, salida_fecha,entrada_hora," +
                   "entrada_fecha,auto_descripcion,nombre_visita,nombre_contacto,empleados,status) " +
                   "VALUES('" + autos_movimiento.Hora_salida + "','" + autos_movimiento.Fecha_salida + "','" +
                   autos_movimiento.Hora_entrada + "','" + autos_movimiento.Fecha_entrada + "','" + autos_movimiento.Auto_descripcion + "','" +
                   autos_movimiento.Nombre_visita + "','" + autos_movimiento.Nombre_contacto + "','" + autos_movimiento.Empleados + "','" + autos_movimiento.Status +  "');";
        }

        public string Actualiza_base_datos_movimiento_auto(Movimiento_auto autos_movimiento)
        {
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_autos());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_modificar_en_base_de_datos_movimiento_auto(autos_movimiento), connection);
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

        private string Configura_cadena_comando_modificar_en_base_de_datos_movimiento_auto(Movimiento_auto autos_movimiento)
        {
            return "UPDATE movimientos_autos set " +
              "salida_hora='" + autos_movimiento.Hora_salida +
              "',salida_fecha='" + autos_movimiento.Fecha_salida +
              "',entrada_hora='" + autos_movimiento.Hora_entrada +
              "',entrada_fecha='" + autos_movimiento.Fecha_entrada +
              "',auto_descripcion='" + autos_movimiento.Auto_descripcion +
              "',nombre_visita='" + autos_movimiento.Nombre_visita +
              "',nombre_contacto='" + autos_movimiento.Nombre_contacto +
              "',empleados='" + autos_movimiento.Empleados +
              "',status='" + autos_movimiento.Status +
              "' where codigo_movimiento='" + autos_movimiento.Codigo + "';";
        }

        private string Configura_Cadena_Conexion_MySQL_almacen_autos()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=almacen;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }
    }

    public class Movimiento_auto
    {
        public string Codigo = "";
        public string Hora_salida = "";
        public string Fecha_salida = "";
        public string Hora_entrada = "";
        public string Fecha_entrada = "";
        public string Auto_descripcion = "";
        public string Nombre_visita = "";
        public string Nombre_contacto = "";
        public string Empleados = "";
        public string Status = "";
        public string Error = "";
    }
}
