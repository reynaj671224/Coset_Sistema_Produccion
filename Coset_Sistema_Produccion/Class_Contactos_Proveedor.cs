using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Contactos_Proveedor
    {
        public List<Contacto_proveedor> Adquiere_contactos_proveedores_disponibles_en_base_datos(string codigo_proveedor)
        {
            List<Contacto_proveedor> contactos_proveedor_disponibles = new List<Contacto_proveedor>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_sistema_contactos_proveedor());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql(codigo_proveedor), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    contactos_proveedor_disponibles.Add(new Contacto_proveedor()
                    {
                        codigo = (int)mySqlDataReader["codigo_contacto"],
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
                contactos_proveedor_disponibles.Add(new Contacto_proveedor()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return contactos_proveedor_disponibles;
        }

        public Contacto_proveedor Adquiere_contacto_proveedor_disponibles_en_base_datos(string nombre_contacto)
        {
            Contacto_proveedor contacto_proveedor_disponible = new Contacto_proveedor();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_sistema_contactos_proveedor());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_contacto_proveedor(nombre_contacto), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {

                    contacto_proveedor_disponible.codigo = (int)mySqlDataReader["codigo_contacto"];
                    contacto_proveedor_disponible.Nombre = mySqlDataReader["nombre_contacto"].ToString();
                    contacto_proveedor_disponible.Departamento = mySqlDataReader["departamento_contacto"].ToString();
                    contacto_proveedor_disponible.Telefono_Ofina = mySqlDataReader["telefono_oficina_contacto"].ToString();
                    contacto_proveedor_disponible.Extencion = mySqlDataReader["extencion_contacto"].ToString();
                    contacto_proveedor_disponible.Telefono_celular = mySqlDataReader["telefono_celular_contacto"].ToString();
                    contacto_proveedor_disponible.Correo_electronico = mySqlDataReader["correo_e_contacto"].ToString();

                }
            }
            catch (Exception ex)
            {

                contacto_proveedor_disponible.error = ex.Message.ToString();
            }
            connection.Close();
            return contacto_proveedor_disponible;
        }

        private string Commando_leer_Mysql_contacto_proveedor(string nombre_contacto)
        {
            return "SELECT * FROM contactos_proveedor WHERE nombre_contacto='" + nombre_contacto + "';";
        }

        private string Commando_leer_Mysql(string codigo_proveedor)
        {
            return "SELECT * FROM contactos_proveedor WHERE codigo_proveedor='" + codigo_proveedor + "';";
        }

        private string Configura_Cadena_Conexion_MySQL_sistema_contactos_proveedor()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=sistema;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }
    }

    public class Contacto_proveedor
    {
        public int codigo = 0;
        public string Nombre = "";
        public string Departamento = "";
        public string Telefono_Ofina = "";
        public string Extencion = "";
        public string Telefono_celular = "";
        public string Correo_electronico = "";
        public string Codigo_proveedor = "";
        public string error = "";
    }
}
