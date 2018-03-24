using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Clientes
    {
        public List<Cliente> Adquiere_clientes_disponibles_en_base_datos()
        {
            List<Cliente> clientes_disponibles = new List<Cliente>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_sistema_clientes());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql(), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    clientes_disponibles.Add(new Cliente()
                    {
                        Codigo = mySqlDataReader["codigo_cliente"].ToString(),
                        Nombre = mySqlDataReader["nombre_cliente"].ToString(),
                        Direccion = mySqlDataReader["direccion_cliente"].ToString(),
                        Rfc = mySqlDataReader["rfc_cliente"].ToString(),
                        Telefono = mySqlDataReader["telefono_cliente"].ToString(),
                        RazonSocial = mySqlDataReader["razon_social"].ToString()

                    });
                }
            }
            catch (Exception ex)
            {
                clientes_disponibles.Add(new Cliente()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return clientes_disponibles;
        }

        private string Commando_leer_Mysql()
        {
            return "SELECT * FROM sistema.clientes";
        }

        private string Configura_Cadena_Conexion_MySQL_sistema_clientes()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=sistema;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }
    }

    public class Cliente
    {
        public string Codigo = "";
        public string Nombre = "";
        public string RazonSocial = "";
        public string Direccion = "";
        public string Rfc = "";
        public string Telefono;
        public string error = "";
    }

}
