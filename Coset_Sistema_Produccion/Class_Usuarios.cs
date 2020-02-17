using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Usuarios
    {
        public List<Usuario> Adquiere_usuarios_disponibles_en_base_datos()
        {
            List<Usuario> usuarios_disponibles = new List<Usuario>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_sistema_empleados());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql(), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    usuarios_disponibles.Add(new Usuario()
                    {
                        nombre_usuario = mySqlDataReader["nombre_usuario_empleado"].ToString(),
                        clave_usuario = mySqlDataReader["clave_usuario_empleado"].ToString(),
                        fecha_ingreso_empleado = mySqlDataReader["fecha_ingreso_empleado"].ToString(),
                        puesto_empleado = mySqlDataReader["puesto"].ToString(),
                        costo_semana_empleado = mySqlDataReader["costo_semana_empleado"].ToString(),
                        costo_hora_empleado = mySqlDataReader["costo_hora_empleado"].ToString(),
                        tipo_empleado = mySqlDataReader["tipo_empleado"].ToString(),
                        codigo_empleado = mySqlDataReader["codigo_empleado"].ToString(),
                        nombre_empleado = mySqlDataReader["nombre_empleado"].ToString(),
                        Correo_electronico = mySqlDataReader["correo_electonico"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                usuarios_disponibles.Add(new Usuario()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return usuarios_disponibles;
        }

        public List<Usuario> Adquiere_usuarios_produccion_disponibles_en_base_datos()
        {
            List<Usuario> usuarios_disponibles = new List<Usuario>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_sistema_empleados());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_Mysql_usuarios_producion(), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    usuarios_disponibles.Add(new Usuario()
                    {
                        nombre_usuario = mySqlDataReader["nombre_usuario_empleado"].ToString(),
                        clave_usuario = mySqlDataReader["clave_usuario_empleado"].ToString(),
                        fecha_ingreso_empleado = mySqlDataReader["fecha_ingreso_empleado"].ToString(),
                        puesto_empleado = mySqlDataReader["puesto"].ToString(),
                        costo_semana_empleado = mySqlDataReader["costo_semana_empleado"].ToString(),
                        costo_hora_empleado = mySqlDataReader["costo_hora_empleado"].ToString(),
                        tipo_empleado = mySqlDataReader["tipo_empleado"].ToString(),
                        codigo_empleado = mySqlDataReader["codigo_empleado"].ToString(),
                        nombre_empleado = mySqlDataReader["nombre_empleado"].ToString(),
                        Correo_electronico = mySqlDataReader["correo_electonico"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                usuarios_disponibles.Add(new Usuario()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return usuarios_disponibles;
        }

        private string Commando_leer_Mysql_usuarios_producion()
        {
            return "SELECT * FROM empleados where tipo_empleado='Produccion' or tipo_empleado='Ingenieria'";
        }

        public List<Usuario> Adquiere_usuarios_administrativos_compras_disponibles_en_base_datos()
        {
            List<Usuario> usuarios_disponibles = new List<Usuario>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_sistema_empleados());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_administrativos_compras_Mysql(), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    usuarios_disponibles.Add(new Usuario()
                    {
                        nombre_usuario = mySqlDataReader["nombre_usuario_empleado"].ToString(),
                        clave_usuario = mySqlDataReader["clave_usuario_empleado"].ToString(),
                        fecha_ingreso_empleado = mySqlDataReader["fecha_ingreso_empleado"].ToString(),
                        puesto_empleado = mySqlDataReader["puesto"].ToString(),
                        costo_semana_empleado = mySqlDataReader["costo_semana_empleado"].ToString(),
                        costo_hora_empleado = mySqlDataReader["costo_hora_empleado"].ToString(),
                        tipo_empleado = mySqlDataReader["tipo_empleado"].ToString(),
                        codigo_empleado = mySqlDataReader["codigo_empleado"].ToString(),
                        nombre_empleado = mySqlDataReader["nombre_empleado"].ToString(),
                        Correo_electronico = mySqlDataReader["correo_electonico"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                usuarios_disponibles.Add(new Usuario()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return usuarios_disponibles;
        }

        public List<Usuario> Adquiere_usuarios_requsitores_disponibles_en_base_datos()
        {
            List<Usuario> usuarios_disponibles = new List<Usuario>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_sistema_empleados());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_requisitores_Mysql(), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    usuarios_disponibles.Add(new Usuario()
                    {
                        nombre_usuario = mySqlDataReader["nombre_usuario_empleado"].ToString(),
                        clave_usuario = mySqlDataReader["clave_usuario_empleado"].ToString(),
                        fecha_ingreso_empleado = mySqlDataReader["fecha_ingreso_empleado"].ToString(),
                        puesto_empleado = mySqlDataReader["puesto"].ToString(),
                        costo_semana_empleado = mySqlDataReader["costo_semana_empleado"].ToString(),
                        costo_hora_empleado = mySqlDataReader["costo_hora_empleado"].ToString(),
                        tipo_empleado = mySqlDataReader["tipo_empleado"].ToString(),
                        codigo_empleado = mySqlDataReader["codigo_empleado"].ToString(),
                        nombre_empleado = mySqlDataReader["nombre_empleado"].ToString(),
                        Correo_electronico = mySqlDataReader["correo_electonico"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                usuarios_disponibles.Add(new Usuario()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return usuarios_disponibles;
        }

        public List<Usuario> Adquiere_todos_usuarios_requsitores_disponibles_en_base_datos()
        {
            List<Usuario> usuarios_disponibles = new List<Usuario>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_sistema_empleados());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_todos_empleados_Mysql(), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    usuarios_disponibles.Add(new Usuario()
                    {
                        nombre_usuario = mySqlDataReader["nombre_usuario_empleado"].ToString(),
                        clave_usuario = mySqlDataReader["clave_usuario_empleado"].ToString(),
                        fecha_ingreso_empleado = mySqlDataReader["fecha_ingreso_empleado"].ToString(),
                        puesto_empleado = mySqlDataReader["puesto"].ToString(),
                        costo_semana_empleado = mySqlDataReader["costo_semana_empleado"].ToString(),
                        costo_hora_empleado = mySqlDataReader["costo_hora_empleado"].ToString(),
                        tipo_empleado = mySqlDataReader["tipo_empleado"].ToString(),
                        codigo_empleado = mySqlDataReader["codigo_empleado"].ToString(),
                        nombre_empleado = mySqlDataReader["nombre_empleado"].ToString(),
                        Correo_electronico = mySqlDataReader["correo_electonico"].ToString(),
                        Numero_licencia = mySqlDataReader["numero_licencia"].ToString(),
                        Fecha_vencimiento_licencia = mySqlDataReader["fecha_vencimiento_licencia"].ToString(),

                    });
                }
            }
            catch (Exception ex)
            {
                usuarios_disponibles.Add(new Usuario()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return usuarios_disponibles;
        }

        private string Commando_leer_todos_empleados_Mysql()
        {
            return "SELECT * FROM empleados";
        }

        private string Commando_leer_requisitores_Mysql()
        {
            return "SELECT * FROM empleados where tipo_empleado='Ingenieria' or tipo_empleado='Almacen'" +
                "or tipo_empleado='Administrativo' or tipo_empleado='Produccion'or tipo_empleado='Admin-Compras' " +
                "or tipo_empleado='Almacen-Compras'";
        }

        private string Commando_leer_Mysql()
        {
            return "SELECT * FROM sistema.empleados where tipo_empleado='Admin-Compras' or " +
                "tipo_empleado='Administrativo' or tipo_empleado='Ingenieria' " +
                "or tipo_empleado='Almacen' or tipo_empleado='Almacen-Compras' or tipo_empleado='Usuario-Produccion'" +
                "or tipo_empleado = 'Calidad-Dibujos'";

        }

        private string Commando_leer_administrativos_compras_Mysql()
        {
            return "SELECT * FROM empleados where tipo_empleado='Admin-Compras'";
        }

        private string Configura_Cadena_Conexion_MySQL_sistema_empleados()
        {
            return "Server="+ Coset_Sistema_Produccion.ip_addres_server+";Database=sistema;Uid=root;Pwd="+ Coset_Sistema_Produccion.password_server + ";";
        }

        public List<Usuario> Adquiere_ingenieros_disponibles_en_base_datos()
        {
            List<Usuario> usuarios_disponibles = new List<Usuario>();
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_sistema_empleados());
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(Commando_leer_ingerieros_Mysql(), connection);
                connection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    usuarios_disponibles.Add(new Usuario()
                    {
                        nombre_usuario = mySqlDataReader["nombre_usuario_empleado"].ToString(),
                        clave_usuario = mySqlDataReader["clave_usuario_empleado"].ToString(),
                        fecha_ingreso_empleado = mySqlDataReader["fecha_ingreso_empleado"].ToString(),
                        puesto_empleado = mySqlDataReader["puesto"].ToString(),
                        costo_semana_empleado = mySqlDataReader["costo_semana_empleado"].ToString(),
                        costo_hora_empleado = mySqlDataReader["costo_hora_empleado"].ToString(),
                        tipo_empleado = mySqlDataReader["tipo_empleado"].ToString(),
                        codigo_empleado = mySqlDataReader["codigo_empleado"].ToString(),
                        nombre_empleado = mySqlDataReader["nombre_empleado"].ToString(),
                        Correo_electronico = mySqlDataReader["correo_electonico"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                usuarios_disponibles.Add(new Usuario()
                { error = ex.Message.ToString() });
            }
            connection.Close();
            return usuarios_disponibles;
        }

        private string Commando_leer_ingerieros_Mysql()
        {
            return "SELECT * FROM empleados WHERE tipo_empleado='Ingenieria' OR tipo_empleado='Administrativo'";
        }
    }

      
    public class Usuario
    {
        public string nombre_usuario = "";
        public string clave_usuario = "";
        public string fecha_ingreso_empleado = "";
        public string puesto_empleado = "";
        public string costo_semana_empleado = "";
        public string costo_hora_empleado = "";
        public string tipo_empleado = "";
        public string codigo_empleado = "";
        public string nombre_empleado = "";
        public string Correo_electronico = "";
        public string Numero_licencia = "";
        public string Fecha_vencimiento_licencia = "";
        public string error = "";
    }
}
