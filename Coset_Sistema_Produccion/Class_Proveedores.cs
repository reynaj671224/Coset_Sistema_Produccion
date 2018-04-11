using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Proveedores
    {
        public List<Proveedor> Adquiere_proveedores_disponibles_en_base_datos()
        {
            List<Proveedor> proveedores_disponibles = new List<Proveedor>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_sistema_clientes());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql(), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    proveedores_disponibles.Add(new Proveedor()
                    {
                        Codigo = mySqlDataReader["codigo_proveedor"].ToString(),
                        Nombre = mySqlDataReader["nombre_proveedor"].ToString(),
                        Direccion = mySqlDataReader["direccion_proveedor"].ToString(),
                        Rfc = mySqlDataReader["rfc_proveedor"].ToString(),
                        Telefono = mySqlDataReader["telefono_proveedor"].ToString(),
                        Giro = mySqlDataReader["giro_proveedor"].ToString(),
                        Correo = mySqlDataReader["correoe_proveedor"].ToString(),
                        RazonSocial = mySqlDataReader["razon_social"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                proveedores_disponibles.Add(new Proveedor()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return proveedores_disponibles;
        }
        public Proveedor Adquiere_proveedor_disponibles_en_base_datos(string nombre_proveedor)
        {
            Proveedor proveedor_disponibles = new Proveedor();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_sistema_clientes());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_proveedor_nombre(nombre_proveedor), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    proveedor_disponibles.Codigo = mySqlDataReader["codigo_proveedor"].ToString();
                    proveedor_disponibles.Nombre = mySqlDataReader["nombre_proveedor"].ToString();
                    proveedor_disponibles.Direccion = mySqlDataReader["direccion_proveedor"].ToString();
                    proveedor_disponibles.Rfc = mySqlDataReader["rfc_proveedor"].ToString();
                    proveedor_disponibles.Telefono = mySqlDataReader["telefono_proveedor"].ToString();
                    proveedor_disponibles.Giro = mySqlDataReader["giro_proveedor"].ToString();
                    proveedor_disponibles.Correo = mySqlDataReader["correoe_proveedor"].ToString();
                    proveedor_disponibles.RazonSocial = mySqlDataReader["razon_social"].ToString();
                }
            }
            catch (Exception ex)
            {

                proveedor_disponibles.error = ex.Message.ToString();
            }
            connection.Close();
            return proveedor_disponibles;
        }

        private string Commando_leer_Mysql_proveedor_nombre(string nombre_proveedor)
        {
            return "SELECT * FROM proveedores where nombre_proveedor='" + nombre_proveedor+"'";
        }

        private string Commando_leer_Mysql()
        {
            return "SELECT * FROM proveedores ORDER BY ABS(codigo_proveedor)";
        }

        private string Configura_Cadena_Conexion_MySQL_sistema_clientes()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=sistema;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }
    }
    public class Proveedor
    {
        public string Codigo = "";
        public string Nombre = "";
        public string RazonSocial = "";
        public string Direccion = "";
        public string Rfc = "";
        public string Telefono;
        public string Giro = "";
        public string Correo = "";
        public string error = "";
    }
}
