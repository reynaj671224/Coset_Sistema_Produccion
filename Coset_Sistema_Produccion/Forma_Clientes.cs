using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public partial class Forma_Clientes : Form
    {
        public List<Cliente> clientes_disponibles = new List<Cliente>();
        public Class_Clientes clase_clientes = new Class_Clientes();
        public List<Contacto_cliente> contactos_cliente_disponibles = new List<Contacto_cliente>();
        public Class_Contactos_Clientes clase_contactos_cliente = new Class_Contactos_Clientes();
        public Cliente Cliente_modificaciones = new Cliente();
        public Contacto_cliente Contacto_cliente_agregar = new Contacto_cliente();
        public Contacto_cliente Contact_cliente_modificar = new Contacto_cliente();
        public Class_Control_Folios class_folio_disponible = new Class_Control_Folios();
        public Control_folio folio_disponible = new Control_folio();
        string RenglonParaEliminar = "";
        public enum Campos_contactos
        {
            codigo, nombre, departamento, telefonoOficina, extencion,
            telefonoCelular, correElectronico
        };

        public string Operacio_clientes = "";

        public Forma_Clientes()
        {
            InitializeComponent();
        }

        private void Forma_Clientes_Load(object sender, EventArgs e)
        {
            Desactiva_columna_codigo_contactos_cliente();
            Habilita_combo_para_aceptar_buscar_elemento_escribiendo_en_ventana();
        }

        private void Habilita_combo_para_aceptar_buscar_elemento_escribiendo_en_ventana()
        {
            comboBoxNombreCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBoxNombreCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxNombreCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            clientes_disponibles = null;
            clase_clientes = null;
            contactos_cliente_disponibles = null;
            clase_contactos_cliente = null;
            Cliente_modificaciones = null;
            Contacto_cliente_agregar = null;
            Contact_cliente_modificar = null;
            class_folio_disponible = null;
            folio_disponible = null;
            this.Dispose();
            GC.Collect();
            this.Close();
        }

        private void buttonBuscarempleado_Click(object sender, EventArgs e)
        {
            Visualiza_cliente();
        }

        private void Visualiza_cliente()
        {
            Desactiva_botones_operacion();
            Desaparece_caja_nombre_cliente();
            Aparece_combo_nombre_cliente();
            Activa_combo_nombre_cliente();
            Obtener_datos_clientes_disponibles_base_datos();
            Rellena_combo_nombre_cliente();
            Aparece_boton_cancelar_operacio();
            No_aceptar_agregar_contactos_cliente();
            Activa_dataview_contacto_empleados();
            Operacio_clientes = "Visualizar";
        }

        private void Rellena_combo_nombre_cliente()
        {
            foreach (Cliente cliente in clientes_disponibles)
            {
                if (cliente.error == "")
                    comboBoxNombreCliente.Items.Add(cliente.Nombre);
                else
                {
                    MessageBox.Show(cliente.error);
                    break;
                }
            }
        }

        private void Activa_combo_nombre_cliente()
        {
            comboBoxNombreCliente.Enabled = true;
        }

        private void Aparece_combo_nombre_cliente()
        {
            comboBoxNombreCliente.Visible=true;
        }

        private void Desaparece_caja_nombre_cliente()
        {
            textBoxNombreCliente.Visible=false;
        }

        private void Activa_combo_codigo_cliente()
        {
            comboBoxCodigoCliente.Enabled = true;
        }

        private void Activa_dataview_contacto_empleados()
        {
            dataGridViewContactosClientes.Enabled = true;
        }

        private void limpia_contactos_clientes()
        {
            dataGridViewContactosClientes.Rows.Clear();
        }

        private void No_aceptar_agregar_contactos_cliente()
        {
            dataGridViewContactosClientes.AllowUserToAddRows = false;
        }

        private void Aparece_boton_cancelar_operacio()
        {
            buttonCancelar.Visible = true;
        }

        private void Rellena_combo_codigo_cliente()
        {
            foreach (Cliente cliente in clientes_disponibles)
            {
                if (cliente.error == "")
                    comboBoxCodigoCliente.Items.Add(cliente.Codigo);
                else
                {
                    MessageBox.Show(cliente.error);
                    break;
                }
            }
        }

        private void Obtener_datos_contactos_clientes_disponibles_base_datos(string codigo_cliente)
        {
            contactos_cliente_disponibles = clase_contactos_cliente.Adquiere_contactos_cliente_disponibles_en_base_datos(codigo_cliente);
        }

        private void Obtener_datos_clientes_disponibles_base_datos()
        {
            clientes_disponibles = clase_clientes.Adquiere_clientes_disponibles_en_base_datos();
        }

        private void Aparece_combo_codigo_cliente()
        {
            comboBoxCodigoCliente.Visible = true;
        }

        private void Desaparece_caja_captura_codigo_cliente()
        {
            textBoxCodigoCliente.Visible = false;
        }

        private void Desactiva_botones_operacion()
        {
            Desactiva_boton_agregar_cliente();
            Desactiva_boton_modificar_cliente();
            Desactiva_boton_eliminar_cliente();
            Desactiva_boton_visualizar_cliente();
            Desactiva_boton_contactos();
        }

        private void Desactiva_boton_contactos()
        {
            buttonContactos.Enabled = false;
        }

        private void Desactiva_boton_visualizar_cliente()
        {
            buttonBuscarCliente.Enabled = false;
        }

        private void Desactiva_boton_eliminar_cliente()
        {
            buttonEliminarCliente.Enabled = false;
        }

        private void Desactiva_boton_modificar_cliente()
        {
            buttonModificarCliente.Enabled = false;
        }

        private void Desactiva_boton_agregar_cliente()
        {
            buttonAgregarCliente.Enabled = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Limpia_combo_codigo_cliente();
            Limpia_combo_nombre_cliente();
            Limpia_cajas_captura_despues_de_agregar_cliente();
            Limpia_combo_codigo_cliente();
            Desactiva_cajas_captura_despues_de_agregar_cliente();
            Desaparece_boton_guardar_base_de_datos();
            Desaparece_boton_cancelar();
            Desaparece_combo_codigo_cliente();
            Desaparece_combo_nombre_cliente();
            Activa_botones_operacion();
            limpia_contactos_clientes();
            Desactiva_datagridview_contactos();
            Aparece_caja_codigo_empleado();
            Aparece_caja_nombre_cliente();
            Acepta_datagridview_agregar_renglones();
            Desaparece_botones_operacion_contactos();
            Elimina_informacion_cliente_disponibles();
        }

        private void Aparece_caja_nombre_cliente()
        {
            textBoxNombreCliente.Visible=true;
        }

        private void Desaparece_combo_nombre_cliente()
        {
            comboBoxNombreCliente.Visible = false;
        }

        private void Limpia_combo_nombre_cliente()
        {
            comboBoxNombreCliente.Items.Clear();
            comboBoxNombreCliente.Text = "";
        }

        private void Desaparece_botones_operacion_contactos()
        {
            Desaparece_boton_agrega_contacto();
            Desaparece_boton_eliminar_contacto();
        }

        private void Desaparece_boton_eliminar_contacto()
        {
            buttonEliminarContacto.Visible=false;
        }

        private void Desaparece_boton_agrega_contacto()
        {
            buttonAgregarContacto.Visible=false;
        }

        private void Aparece_caja_codigo_empleado()
        {
            textBoxCodigoCliente.Visible = true;
        }

        private void comboBoxCodigoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Operacio_clientes == "Modificar")
                configura_forma_modificar();
            else if (Operacio_clientes == "Eliminar")
                configura_forma_eliminar();
            else if (Operacio_clientes == "Visualizar")
                configura_forma_visualizar();
            else if (Operacio_clientes == "Operaciones Contactos")
                configura_forma_operaciones_contactos();
        }

        private void configura_forma_operaciones_contactos()
        {
            Desactiva_combo_nombre_cliente();
            limpia_contactos_clientes();
            Obtener_datos_clientes_disponibles_base_datos();
            Rellena_cajas_informacion_de_clientes();
            Obtener_datos_contactos_clientes_disponibles_base_datos(textBoxCodigoCliente.Text);
            Rellena_cajas_informacion_de_contactos_clientes();
            Aparecer_botones_operaciones_contactos();
            

        }

        private void Desactiva_combo_nombre_cliente()
        {
            comboBoxNombreCliente.Enabled=false;
        }

        private void Aparecer_botones_operaciones_contactos()
        {
            Aparece_boton_agregar_contactos();
            Aparece_boton_eliminar_contactos();
        }

        private void configura_forma_visualizar()
        {
            limpia_contactos_clientes();
            Rellena_cajas_informacion_de_clientes();
            Obtener_datos_contactos_clientes_disponibles_base_datos(textBoxCodigoCliente.Text);
            Rellena_cajas_informacion_de_contactos_clientes();

        }

        private void Rellena_cajas_informacion_de_contactos_clientes()
        {
            foreach (Contacto_cliente contacto in contactos_cliente_disponibles)
            {
                if (contacto.error == "")
                {
                    string[] contacto_infromacion = {contacto.codigo.ToString(), contacto.Nombre, contacto.Departamento, contacto.Telefono_Ofina,
                    contacto.Extencion,contacto.Telefono_celular,contacto.Correo_electronico};
                    dataGridViewContactosClientes.Rows.Add(contacto_infromacion);
                }
                else
                {
                    MessageBox.Show(contacto.error);
                    break;
                }

            }

        }

        private void Rellena_cajas_informacion_de_clientes()
        {
            Cliente_modificaciones = clientes_disponibles.Find(clientes => clientes.Nombre.Contains(comboBoxNombreCliente.SelectedItem.ToString()));

            textBoxCodigoCliente.Text = Cliente_modificaciones.Codigo;
            textBoxDireccionCliente.Text = Cliente_modificaciones.Direccion;
            textBoxRfcCliente.Text = Cliente_modificaciones.Rfc;
            textBoxTelefonoCliente.Text = Cliente_modificaciones.Telefono;
            textBoxRazonSocial.Text = Cliente_modificaciones.RazonSocial;
        }

        private void configura_forma_eliminar()
        {
            limpia_contactos_clientes();
            Rellena_cajas_informacion_de_clientes();
            Obtener_datos_contactos_clientes_disponibles_base_datos(textBoxCodigoCliente.Text);
            Rellena_cajas_informacion_de_contactos_clientes();
            Aparece_boton_eliminar_datos_en_base_de_datos();
        }

        private void Aparece_boton_eliminar_datos_en_base_de_datos()
        {
            buttonBorrarBasedeDatos.Visible = true;
        }

        private void configura_forma_modificar()
        {
            limpia_contactos_clientes();
            Rellena_cajas_informacion_de_clientes();
            Obtener_datos_contactos_clientes_disponibles_base_datos(textBoxCodigoCliente.Text);
            Rellena_cajas_informacion_de_contactos_clientes();
            Activa_cajas_informacion_clientes();
            Asigna_datos_en_cajas_a_variable();
            Aparce_boton_guardar_base_datos();
            //Inicia_timer_para_asegurar_informacion_en_todos_los_campos_modificar_clientes();
        }

        private void Aparce_boton_guardar_base_datos()
        {
            buttonGuardarBasedeDatos.Visible = true;
        }

        private void Asigna_datos_en_cajas_a_variable()
        {
            Cliente_modificaciones.Nombre = textBoxNombreCliente.Text;
            Cliente_modificaciones.Direccion = textBoxDireccionCliente.Text;
            Cliente_modificaciones.Rfc = textBoxRfcCliente.Text;
            Cliente_modificaciones.Telefono = textBoxTelefonoCliente.Text;
            Cliente_modificaciones.RazonSocial = textBoxRazonSocial.Text;

        }

        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos_modificar_clientes()
        {
            timerModificarClientes.Enabled = true;
        }

        private void Desactiva_combobox_codigo_clientes()
        {
            comboBoxCodigoCliente.Enabled = false;
        }

        private void buttonAgregarCliente_Click(object sender, EventArgs e)
        {
            Agrega_clientes();
        }

        private void Agrega_contactos_cliente()
        {
            throw new NotImplementedException();
        }

        private void Agrega_clientes()
        {
            Asigna_codigo_cliente_foilio_disponible();
            Asigna_nuevo_folio_clientes();
            Desactiva_botones_operacion();
            Activa_cajas_informacion_clientes();
            Acepta_datagridview_agregar_renglones();
            Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_clientes();
            Aparece_boton_cancelar_operacio();
            Activa_datagridview_contactos_clientes();
            Operacio_clientes = "Agregar";
        }

        private void Asigna_codigo_cliente_foilio_disponible()
        {
            folio_disponible = class_folio_disponible.Obtener_informacion_control_folio_base_datos();
            textBoxCodigoCliente.Text = folio_disponible.Folio_clientes;
        }

        private void Acepta_datagridview_agregar_renglones()
        {
            dataGridViewContactosClientes.AllowUserToAddRows = true;
        }

        private void Activa_datagridview_contactos_clientes()
        {
            dataGridViewContactosClientes.Enabled = true;
        }

        private void Desactiva_columna_codigo_contactos_cliente()
        {
            dataGridViewContactosClientes.Columns[0].Visible = false;
        }

        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_clientes()
        {
            timerAgregarCliente.Enabled = true;
        }

        private void Activa_cajas_informacion_clientes()
        {
            textBoxNombreCliente.Enabled = true;
            textBoxDireccionCliente.Enabled = true;
            textBoxRfcCliente.Enabled = true;
            textBoxTelefonoCliente.Enabled = true;
            textBoxRazonSocial.Enabled = true;
        }

        private void Modifica_contactos_cliente()
        {
            throw new NotImplementedException();
        }



        private void timerAgregarCliente_Tick(object sender, EventArgs e)
        {
            if (textBoxNombreCliente.Text != "" &&
            textBoxDireccionCliente.Text != "" &&
            textBoxRfcCliente.Text != "" &&
            textBoxTelefonoCliente.Text != "" &&
            textBoxRazonSocial.Text != "")
            {
                timerAgregarCliente.Enabled = false;
                buttonGuardarBasedeDatos.Visible = true;
            }
        }

        private void buttonGuardarBasedeDatos_Click(object sender, EventArgs e)
        {
            if (Operacio_clientes == "Agregar")
                Secuencia_agregar_cliente();
            else if (Operacio_clientes == "Modificar")
                Secuencia_modificar_cliente();
            else if (Operacio_clientes == "Agregar Contactos")
                Secuencia_agregar_contactos();
        }

        private void Secuencia_agregar_contactos()
        {
            if (Guarda_datos_contactos_clientes())
            {
                Desaparece_boton_guardar_base_de_datos();
                Activa_botones_operacion_contactos();
                limpia_contactos_clientes();
                Obtener_datos_contactos_clientes_disponibles_base_datos(textBoxCodigoCliente.Text);
                Rellena_cajas_informacion_de_contactos_clientes();
                Elimina_informacion_cliente_disponibles();
            }
        }

        private void Activa_botones_operacion_contactos()
        {
            Activa_boton_agregar_contactos();
            Activa_boton_eliminar_contactos();
        }

        private void Activa_boton_eliminar_contactos()
        {
            buttonEliminarContacto.Enabled = true;
        }

        private void Activa_boton_agregar_contactos()
        {
            buttonAgregarContacto.Enabled=true;
        }

        private void Secuencia_modificar_cliente()
        {
            if (Modificar_datos_contactos_cliente())
            {
                if (Modifica_datos_clientes())
                {
                    Limpia_cajas_captura_despues_de_agregar_cliente();
                    Limpia_combo_nombre_cliente();
                    Desactiva_cajas_captura_despues_de_agregar_cliente();
                    Desaparece_boton_guardar_base_de_datos();
                    Desaparece_boton_cancelar();
                    Desaparece_combo_nombre_cliente();
                    Aparce_caja_nombre_cliente();
                    Activa_botones_operacion();
                    limpia_contactos_clientes();
                    Desactiva_datagridview_contactos();
                    Elimina_informacion_cliente_disponibles();
                }
            }
        }

        private void Aparce_caja_nombre_cliente()
        {
            textBoxNombreCliente.Visible = true;
        }

        private void Aparce_caja_codigo_cliente()
        {
            textBoxCodigoCliente.Visible = true;
        }

        private bool Modifica_datos_clientes()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_sistema_clientes());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_modificar_en_base_de_datos_clientes(), connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        private string Configura_cadena_comando_modificar_en_base_de_datos_clientes()
        {
            return "UPDATE clientes set  nombre_cliente='" + comboBoxNombreCliente.Text +
               "',direccion_cliente='" + textBoxDireccionCliente.Text +
               "',rfc_cliente='" + textBoxRfcCliente.Text +
               "',telefono_cliente='" + textBoxTelefonoCliente.Text +
               "',razon_social='" +textBoxRazonSocial.Text +
               "' where codigo_cliente='" + textBoxCodigoCliente.Text + "';";
        }

        private bool Modificar_datos_contactos_cliente()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_sistema_clientes());
            try
            {
                connection.Open();
                for (int contactos = 0; contactos < dataGridViewContactosClientes.Rows.Count; contactos++)
                {
                    for (int campo = 0; campo < dataGridViewContactosClientes.Rows[contactos].Cells.Count; campo++)
                    {
                        if (dataGridViewContactosClientes.Rows[contactos].Cells[campo].Value != null)
                        {

                            if (campo == (int)Campos_contactos.nombre)
                                Contact_cliente_modificar.Nombre = dataGridViewContactosClientes.Rows[contactos].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_contactos.departamento)
                                Contact_cliente_modificar.Departamento = dataGridViewContactosClientes.Rows[contactos].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_contactos.telefonoOficina)
                                Contact_cliente_modificar.Telefono_Ofina = dataGridViewContactosClientes.Rows[contactos].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_contactos.extencion)
                                Contact_cliente_modificar.Extencion = dataGridViewContactosClientes.Rows[contactos].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_contactos.telefonoCelular)
                                Contact_cliente_modificar.Telefono_celular = dataGridViewContactosClientes.Rows[contactos].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_contactos.correElectronico)
                                Contact_cliente_modificar.Correo_electronico = dataGridViewContactosClientes.Rows[contactos].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_contactos.codigo)
                                Contact_cliente_modificar.codigo = Convert.ToInt32(dataGridViewContactosClientes.Rows[contactos].Cells[campo].Value.ToString());
                        }

                        else
                        {
                            MessageBox.Show("campo en blanco");
                            connection.Close();
                            return false;
                        }
                    }
                    MySqlCommand command = new MySqlCommand(Configura_cadena_comando_en_base_de_datos_modificar_contacto_clientes(Contact_cliente_modificar), connection);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return false;
            }

            connection.Close();
            return true;

        }

        private string Configura_cadena_comando_en_base_de_datos_modificar_contacto_clientes(Contacto_cliente contact_cliente_modificar)
        {
            return "UPDATE contactos_cliente set  nombre_contacto='" + contact_cliente_modificar.Nombre +
                "',departamento_contacto='" + contact_cliente_modificar.Departamento +
                "',telefono_oficina_contacto='" + contact_cliente_modificar.Telefono_Ofina +
                "',extencion_contacto='" + contact_cliente_modificar.Extencion +
                "',telefono_celular_contacto='" + contact_cliente_modificar.Telefono_celular +
                "',correo_e_contacto='" + contact_cliente_modificar.Correo_electronico +
                "' where codigo_contacto='" + contact_cliente_modificar.codigo + "';";
        }

        private void Secuencia_agregar_cliente()
        {
            if (verifica_datos_partidas())
            {
                if (Guarda_datos_contactos_clientes())
                {
                    if (Guarda_datos_clientes())
                    {
                        Limpia_cajas_captura_despues_de_agregar_cliente();
                        Limpia_combo_codigo_cliente();
                        Desactiva_cajas_captura_despues_de_agregar_cliente();
                        Desaparece_boton_guardar_base_de_datos();
                        Desaparece_boton_cancelar();
                        Desaparece_combo_codigo_cliente();
                        Activa_botones_operacion();
                        limpia_contactos_clientes();
                        Desactiva_datagridview_contactos();
                        Elimina_informacion_cliente_disponibles();
                    }
                }
            }

        }

        private bool verifica_datos_partidas()
        {
            for (int contactos = 0; contactos < dataGridViewContactosClientes.Rows.Count - 1; contactos++)
            {
                for (int campo = 1; campo < dataGridViewContactosClientes.Rows[contactos].Cells.Count; campo++)
                {
                    if (dataGridViewContactosClientes.Rows[contactos].Cells[campo].Value == null)
                    {
                        MessageBox.Show("campo en blanco");
                        return false;
                    }

                }

            }
            return true;
        }

        private void Asigna_nuevo_folio_clientes()
        {
            int numero_folio = Convert.ToInt32(folio_disponible.Folio_clientes.Substring(1, folio_disponible.Folio_clientes.Length - 1));
            numero_folio++;
            folio_disponible.Folio_clientes = folio_disponible.Folio_clientes.Substring(0, 1) +numero_folio.ToString("00000");
            string respuesta = class_folio_disponible.Actualiza_Control_folios_base_datos(folio_disponible);
            if (respuesta != "")
                MessageBox.Show(folio_disponible.error);
        }

        private void Desactiva_datagridview_contactos()
        {
            dataGridViewContactosClientes.Enabled = false;
        }

        private void Elimina_informacion_cliente_disponibles()
        {
            clientes_disponibles = null;
            contactos_cliente_disponibles = null;
            GC.Collect();
        }

        private void Activa_botones_operacion()
        {
            Activa_boton_agregar_cliente();
            Activa_boton_modificar_cliente();
            Activa_boton_eliminar_cliente();
            Activa_boton_visualizar_cliente();
            Activa_boton_contactos();
        }

        private void Activa_boton_contactos()
        {
            buttonContactos.Enabled = true;
        }

        private void Activa_boton_visualizar_cliente()
        {
            buttonBuscarCliente.Enabled = true;
        }

        private void Activa_boton_eliminar_cliente()
        {
            buttonEliminarCliente.Enabled = true;
        }

        private void Activa_boton_modificar_cliente()
        {
            buttonModificarCliente.Enabled = true;
        }

        private void Activa_boton_agregar_cliente()
        {
            buttonAgregarCliente.Enabled = true;
        }

        private void Desaparece_combo_codigo_cliente()
        {
            comboBoxCodigoCliente.Visible = false;
        }

        private void Desaparece_boton_cancelar()
        {
            buttonCancelar.Visible = false;
        }

        private void Desaparece_boton_guardar_base_de_datos()
        {
            buttonGuardarBasedeDatos.Visible = false;
        }

        private void Desactiva_cajas_captura_despues_de_agregar_cliente()
        {
            textBoxCodigoCliente.Enabled = false;
            textBoxNombreCliente.Enabled = false;
            textBoxDireccionCliente.Enabled = false;
            textBoxRfcCliente.Enabled = false;
            textBoxTelefonoCliente.Enabled = false;
            textBoxRazonSocial.Enabled = false;
        }

        private void Limpia_combo_codigo_cliente()
        {
            comboBoxCodigoCliente.Items.Clear();
            comboBoxCodigoCliente.Text = "";
        }

        private void Limpia_cajas_captura_despues_de_agregar_cliente()
        {
            textBoxCodigoCliente.Text = "";
            textBoxNombreCliente.Text = "";
            textBoxDireccionCliente.Text = "";
            textBoxRfcCliente.Text = "";
            textBoxTelefonoCliente.Text = "";
            textBoxRazonSocial.Text = "";
        }

        private bool Guarda_datos_contactos_clientes()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_sistema_clientes());
            try
            {
                connection.Open();
                for (int contactos = 0; contactos < dataGridViewContactosClientes.Rows.Count - 1; contactos++)
                {
                    for (int campo = 1; campo < dataGridViewContactosClientes.Rows[contactos].Cells.Count; campo++)
                    {
                        if (dataGridViewContactosClientes.Rows[contactos].Cells[campo].Value != null)
                        {
                            if (campo == (int)Campos_contactos.nombre)
                                Contacto_cliente_agregar.Nombre = dataGridViewContactosClientes.Rows[contactos].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_contactos.departamento)
                                Contacto_cliente_agregar.Departamento = dataGridViewContactosClientes.Rows[contactos].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_contactos.telefonoOficina)
                                Contacto_cliente_agregar.Telefono_Ofina = dataGridViewContactosClientes.Rows[contactos].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_contactos.extencion)
                                Contacto_cliente_agregar.Extencion = dataGridViewContactosClientes.Rows[contactos].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_contactos.telefonoCelular)
                                Contacto_cliente_agregar.Telefono_celular = dataGridViewContactosClientes.Rows[contactos].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_contactos.correElectronico)
                                Contacto_cliente_agregar.Correo_electronico = dataGridViewContactosClientes.Rows[contactos].Cells[campo].Value.ToString();
                        }

                        else
                        {
                            MessageBox.Show("campo en blanco");
                            connection.Close();
                            return false;
                        }
                    }
                    Asigna_codigo_empleado_para_tipo_de_operacio();
                    MySqlCommand command = new MySqlCommand(Configura_cadena_comando_insertar_en_base_de_datos_contacto_clientes(Contacto_cliente_agregar), connection);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        private void Asigna_codigo_empleado_para_tipo_de_operacio()
        {
            if (Operacio_clientes == "Agregar")
                Contacto_cliente_agregar.Codigo_cliente = textBoxCodigoCliente.Text;
            else if (Operacio_clientes == "Agregar Contactos")
                Contacto_cliente_agregar.Codigo_cliente = textBoxCodigoCliente.Text;
        }

        private string Configura_cadena_comando_insertar_en_base_de_datos_contacto_clientes(Contacto_cliente contacto_cliente)
        {
            return "INSERT INTO contactos_cliente(nombre_contacto, departamento_contacto,telefono_oficina_contacto," +
                "extencion_contacto,telefono_celular_contacto,correo_e_contacto,codigo_cliente) " +
                "VALUES('" + contacto_cliente.Nombre + "','" + contacto_cliente.Departamento + "'," +
                "'" + contacto_cliente.Telefono_Ofina + "','" + contacto_cliente.Extencion + "'" +
                ",'" + contacto_cliente.Telefono_celular + "','" + contacto_cliente.Correo_electronico + "'," +
                "'" + contacto_cliente.Codigo_cliente + "');";
        }

        private bool Guarda_datos_clientes()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_sistema_clientes());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_insertar_en_base_de_datos(), connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }


        private string Configura_cadena_comando_insertar_en_base_de_datos()
        {
            return "INSERT INTO clientes(codigo_cliente, nombre_cliente,direccion_cliente," +
                "rfc_cliente,telefono_cliente,razon_social) " +
                "VALUES('" + textBoxCodigoCliente.Text + "','" + textBoxNombreCliente.Text + "'," +
                "'" + textBoxDireccionCliente.Text + "','" + textBoxRfcCliente.Text + "'" +
                ",'" + textBoxTelefonoCliente.Text + "','" + textBoxRazonSocial.Text + "');";
        }

        private string Configura_cadena_conexion_MySQL_sistema_clientes()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=sistema;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }


        private void buttonModificarCliente_Click(object sender, EventArgs e)
        {
            Modifica_clientes();
        }

        private void Modifica_clientes()
        {
            Desactiva_botones_operacion();
            Desaparece_caja_nombre_cliente();
            Aparece_combo_nombre_cliente();
            Activa_combo_nombre_cliente();
            Obtener_datos_clientes_disponibles_base_datos();
            Rellena_combo_nombre_cliente();
            Aparece_boton_cancelar_operacio();
            No_aceptar_agregar_contactos_cliente();
            Activa_dataview_contacto_empleados();
            Activa_combo_codigo_cliente();
            Operacio_clientes = "Modificar";
        }

        private void buttonEliminarCliente_Click(object sender, EventArgs e)
        {
            Desactiva_botones_operacion();
            Desaparece_caja_nombre_cliente();
            Aparece_combo_nombre_cliente();
            Activa_combo_nombre_cliente();
            Obtener_datos_clientes_disponibles_base_datos();
            Rellena_combo_nombre_cliente();
            Aparece_boton_cancelar_operacio();
            Operacio_clientes = "Eliminar";
        }

        private bool Elimina_informacion_clienete_en_base_de_datos()
        {
            if (Elimina_datos_cliente() && Elinina_contactos_cliente())
                return true;
            else
                return false;
        }

        private bool Elinina_contactos_cliente()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_sistema_clientes());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_eliminar_en_base_de_datos_contactos_cliente(), connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        private string Configura_cadena_comando_eliminar_en_base_de_datos_contactos_cliente()
        {
            return "DELETE from contactos_cliente where codigo_cliente='" +
               textBoxCodigoCliente.Text + "';";
        }


        private bool Elimina_datos_cliente()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_sistema_clientes());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_eliminar_en_base_de_datos_clientes(), connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }
        private string Configura_cadena_comando_eliminar_en_base_de_datos_clientes()
        {
            return "DELETE from clientes where codigo_cliente='" +
               textBoxCodigoCliente.Text + "';";
        }

        private void timerModificarClientes_Tick(object sender, EventArgs e)
        {
            if (Cliente_modificaciones.Nombre != textBoxNombreCliente.Text ||
            Cliente_modificaciones.Direccion != textBoxDireccionCliente.Text ||
            Cliente_modificaciones.Rfc != textBoxRfcCliente.Text ||
            Cliente_modificaciones.Telefono != textBoxTelefonoCliente.Text ||
            Cliente_modificaciones.RazonSocial != textBoxRazonSocial.Text)
            {
                timerModificarClientes.Enabled = false;
                buttonGuardarBasedeDatos.Visible = true;
            }
        }

        private void buttonAgregaContactosCliente_Click(object sender, EventArgs e)
        {
            Agrega_contactos_clientes();
        }

        private void Agrega_contactos_clientes()
        {
            Desactiva_botones_operacion_contactos();
            limpia_contactos_clientes();
            Acepta_datagridview_agregar_renglones();
            Aparce_boton_guardar_base_datos();
            Operacio_clientes = "Agregar Contactos";

        }

        private void Desactiva_botones_operacion_contactos()
        {
            Desactiva_boton_agregar_contactos();
            Desactiva_boton_eliminar_contactos();
        }

        private void Desactiva_boton_eliminar_contactos()
        {
            buttonEliminarContacto.Enabled = false;
        }

        private void Desactiva_boton_agregar_contactos()
        {
            buttonAgregarContacto.Enabled = false;
        }

        private void buttonBorrarBasedeDatos_Click(object sender, EventArgs e)
        {

            if (Operacio_clientes == "Eliminar Contacto")
                Elimina_contacto_cliente();
            else if (Operacio_clientes == "Eliminar")
                Elimina_cliente();
        }

        private void Elimina_contacto_cliente()
        {
            if (MessageBox.Show("Esta Seguro de Eiliminar el contacto seleccionado?",
               "Eliminar Contacto Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Elimina_informacion_contacto_clienete_en_base_de_datos())
                {
                    Desaparece_boton_eliminar_base_de_datos();
                    Activa_botones_operacion_contactos();
                    limpia_contactos_clientes();
                    Obtener_datos_contactos_clientes_disponibles_base_datos(textBoxCodigoCliente.Text);
                    Rellena_cajas_informacion_de_contactos_clientes();
                    limpia_texto_eliminar_contacto();
                }
            }
            
        }

        private void limpia_texto_eliminar_contacto()
        {
            RenglonParaEliminar = "";
        }

        private bool Elimina_informacion_contacto_clienete_en_base_de_datos()
        {
            if (Elimina_contacto_cliente_seleccionado())
                return true;
            else
                return false;
        }

        private bool Elimina_contacto_cliente_seleccionado()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_sistema_clientes());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_eliminar_en_base_de_datos_contacto_cliente(), connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }


        

        private string Configura_cadena_comando_eliminar_en_base_de_datos_contacto_cliente()
        {
            return "DELETE from contactos_cliente where codigo_contacto='" +
                RenglonParaEliminar + "';";
        }

        private void Elimina_cliente()
        {
            if (MessageBox.Show("Esta Seguro de Eiliminar Este Cliente Incluyendo Todos sus Contactos?",
                "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Elimina_informacion_clienete_en_base_de_datos())
                {
                    Limpia_cajas_captura_despues_de_agregar_cliente();
                    Limpia_combo_nombre_cliente();
                    Desactiva_cajas_captura_despues_de_agregar_cliente();
                    Desaparece_boton_eliminar_base_de_datos();
                    Desaparece_boton_cancelar();
                    Desaparece_combo_nombre_cliente();
                    Activa_botones_operacion();
                    limpia_contactos_clientes();
                    Desactiva_datagridview_contactos();
                    Elimina_informacion_cliente_disponibles();
                    Aparce_caja_nombre_cliente();
                }
            }
        }

        private void Desaparece_boton_eliminar_base_de_datos()
        {
            buttonBorrarBasedeDatos.Visible = false;
        }

        private void buttonEliminarContacto_Click(object sender, EventArgs e)
        {
            Elimina_Contacto_cliente();
        }

        private void Elimina_Contacto_cliente()
        {
            Desactiva_botones_operacion_contactos();
            No_aceptar_agregar_contactos_cliente();
            Operacio_clientes = "Eliminar Contacto";
        }

        private void buttonAgregarContacto_Click(object sender, EventArgs e)
        {
            Agrega_contactos_clientes();
        }

        private void buttonContactos_Click(object sender, EventArgs e)
        {
            Contactos_operaciones();
        }

        private void Contactos_operaciones()
        {
            Desactiva_botones_operacion();
            Desaparece_caja_nombre_cliente();
            Aparece_combo_nombre_cliente();
            Activa_combo_nombre_cliente();
            Obtener_datos_clientes_disponibles_base_datos();
            Rellena_combo_nombre_cliente();
            Aparece_boton_cancelar_operacio();
            No_aceptar_agregar_contactos_cliente();
            Activa_dataview_contacto_empleados();
            Operacio_clientes = "Operaciones Contactos";
        }

        private void Aparece_boton_eliminar_contactos()
        {
            buttonEliminarContacto.Visible = true;
        }

        private void Aparece_boton_agregar_contactos()
        {
            buttonAgregarContacto.Visible = true;
        }

        private void dataGridViewContactosClientes_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewContactosClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Operacio_clientes == "Eliminar Contacto")
            {
                Aparece_boton_eliminar_datos_en_base_de_datos();
                RenglonParaEliminar=dataGridViewContactosClientes.Rows[e.RowIndex].Cells["Codigo_contacto"].Value.ToString();
            }
        }

        private void comboBoxNombreCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Operacio_clientes == "Modificar")
                configura_forma_modificar();
            else if (Operacio_clientes == "Eliminar")
                configura_forma_eliminar();
            else if (Operacio_clientes == "Visualizar")
                configura_forma_visualizar();
            else if (Operacio_clientes == "Operaciones Contactos")
                configura_forma_operaciones_contactos();
        }
    }
}
