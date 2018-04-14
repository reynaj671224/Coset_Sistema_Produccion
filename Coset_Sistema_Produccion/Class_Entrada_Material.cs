using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public class Class_Entrada_Material
    {
        public string Inserta_nuevo_entrada_material_base_datos(Entrada_Material material)
        {
            MySqlConnection connection = new MySqlConnection(Configura_Cadena_Conexion_MySQL_almacen_materiales());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_insertar_en_base_de_datos_entrada_material(material), connection);
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

        private string Configura_cadena_comando_insertar_en_base_de_datos_entrada_material(Entrada_Material entrada_Material)
        {
            return "INSERT INTO entrada_material(orden_compra, fecha,codigo_material," +
                   "cantidad_material,codigo_proveedor_material,nombre_empleado,descripcion_material,precio) " +
                   "VALUES('" + entrada_Material.Orden_compra + "','" + entrada_Material.Fecha + "','" +
                   entrada_Material.Codigo_material + "','" + entrada_Material.Cantidad + "','" + entrada_Material.Codigo_proveedor + "','" +
                   entrada_Material.Nombre_empleado + "','" + entrada_Material.Descripcion_material + "','" + entrada_Material.Precio + "');";
        }

        private string Configura_Cadena_Conexion_MySQL_almacen_materiales()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=almacen;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }
    }
    public class Entrada_Material
    {
        public string Orden_compra = "";
        public string Fecha = "";
        public string Codigo_material = "";
        public string Cantidad = "";
        public string Codigo_proveedor = "";
        public string Nombre_empleado = "";
        public string Descripcion_material = "";
        public string Precio = "";
        public string error = "";

    }
}
