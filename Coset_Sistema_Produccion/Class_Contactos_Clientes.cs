using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Contactos_Clientes
    {
        public List<Contacto_cliente> Adquiere_contactos_cliente_disponibles_en_base_datos(string codigo_cliente)
        {
            List<Contacto_cliente> contactos_cliente_disponibles = new List<Contacto_cliente>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_sistema_contactos_cliente());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql(codigo_cliente), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    contactos_cliente_disponibles.Add(new Contacto_cliente()
                    {
                        codigo = (int) mySqlDataReader["codigo_contacto"],
                        Nombre = mySqlDataReader["nombre_contacto"].ToString(),
                        Departamento = mySqlDataReader["departamento_contacto"].ToString(),
                        Telefono_Ofina = mySqlDataReader["telefono_oficina_contacto"].ToString(),
                        Extencion = mySqlDataReader["extencion_contacto"].ToString(),
                        Telefono_celular = mySqlDataReader["telefono_celular_contacto"].ToString(),
                        Correo_electronico = mySqlDataReader["correo_e_contacto"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                contactos_cliente_disponibles.Add(new Contacto_cliente()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return contactos_cliente_disponibles;
        }

        private string Commando_leer_Mysql(string codigo_cliente)
        {
            return "SELECT * FROM sistema.contactos_cliente WHERE codigo_cliente='"+codigo_cliente+"';";
        }

        private string Configura_Cadena_Conexion_MySQL_sistema_contactos_cliente()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=sistema;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }
    }
    public class Contacto_cliente
    {
        public int codigo = 0;
        public string Nombre ="";
        public string Departamento = "";
        public string Telefono_Ofina = "";
        public string Extencion = "";
        public string Telefono_celular = "";
        public string Correo_electronico = "";
        public string Codigo_cliente = "";
        public string error = "";

    }
}
