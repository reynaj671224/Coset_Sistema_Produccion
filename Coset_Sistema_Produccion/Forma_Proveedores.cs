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
    public partial class Forma_Proveedores : Form
    {
        public List<Proveedor> proveedores_disponibles = new List<Proveedor>();
        public Class_Proveedores clase_proveedore = new Class_Proveedores();
        public List<Contacto_proveedor> contactos_proveedores_disponibles = new List<Contacto_proveedor>();
        public Class_Contactos_Proveedor clase_contactos_proveedor = new Class_Contactos_Proveedor();
        public Proveedor Proveedor_modificaciones = new Proveedor();
        public Contacto_proveedor Contacto_proveedor_agregar = new Contacto_proveedor();
        public Contacto_proveedor Contact_proveedor_modificar = new Contacto_proveedor();
        public Class_Control_Folios class_folio_disponible = new Class_Control_Folios();
        public Control_folio folio_disponible = new Control_folio();
        string RenglonParaEliminar = "";
        public enum Campos_contactos
        {
            codigo, nombre, departamento, telefonoOficina, extencion,
            telefonoCelular, correElectronico
        };

        public string Operacio_proveedores = "";

        public Forma_Proveedores()
        {
            InitializeComponent();
        }

        private void Forma_Proveedores_Load(object sender, EventArgs e)
        {
            Desactiva_columna_codigo_contactos_cliente();
            Habilita_combo_para_aceptar_buscar_elemento_escribiendo_en_ventana();

        }

        private void Habilita_combo_para_aceptar_buscar_elemento_escribiendo_en_ventana()
        {
            comboBoxNombreProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBoxNombreProveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxNombreProveedor.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            proveedores_disponibles = null;
            clase_proveedore = null;
            contactos_proveedores_disponibles = null;
            clase_contactos_proveedor = null;
            Proveedor_modificaciones = null;
            Contacto_proveedor_agregar = null;
            Contact_proveedor_modificar = null;
            class_folio_disponible = null;
            folio_disponible = null;
            this.Dispose();
            GC.Collect();
            this.Close();
        }

        private void buttonBuscarProveedor_Click(object sender, EventArgs e)
        {
            Visualiza_provedor();
        }

        private void Visualiza_provedor()
        {
            Desactiva_botones_operacion();
            Desaparece_caja_nombre_proveedor();
            Aparece_combo_nombre_proveedor();
            Activa_combo_nombre_proveedor();
            Obtener_datos_proveedores_disponibles_base_datos();
            Rellena_combo_nombre_proveedores();
            Aparece_boton_cancelar_operacio();
            No_aceptar_agregar_contactos_proveedor();
            Activa_dataview_contacto_proveedores();
            Operacio_proveedores = "Visualizar";
        }

        private void Rellena_combo_nombre_proveedores()
        {
            foreach (Proveedor proveedor in proveedores_disponibles)
            {
                if (proveedor.error == "")
                    comboBoxNombreProveedor.Items.Add(proveedor.Nombre);
                else
                {
                    MessageBox.Show(proveedor.error);
                    break;
                }
            }
        }

        private void Aparece_combo_nombre_proveedor()
        {
            comboBoxNombreProveedor.Visible = true;
        }

        private void Desaparece_caja_nombre_proveedor()
        {
            textBoxNombreProveedor.Visible = false;
        }

        private void Activa_combo_codigo_proveedor()
        {
            comboBoxCodigoProveedor.Enabled = true;
        }

        private void Activa_dataview_contacto_proveedores()
        {
            dataGridViewContactosProveedor.Enabled = true;
        }

        private void limpia_contactos_proveedor()
        {
            dataGridViewContactosProveedor.Rows.Clear();
        }

        private void No_aceptar_agregar_contactos_proveedor()
        {
            dataGridViewContactosProveedor.AllowUserToAddRows = false;
        }

        private void Aparece_boton_cancelar_operacio()
        {
            buttonCancelar.Visible = true;
        }

        private void Rellena_combo_codigo_proveedor()
        {
            foreach (Proveedor proveedor in proveedores_disponibles)
            {
                if (proveedor.error == "")
                    comboBoxCodigoProveedor.Items.Add(proveedor.Codigo);
                else
                {
                    MessageBox.Show(proveedor.error);
                    break;
                }
            }
        }

        private void Obtener_datos_contactos_proveedores_disponibles_base_datos(string codigo_proveedor)
        {
            contactos_proveedores_disponibles = clase_contactos_proveedor.Adquiere_contactos_proveedores_disponibles_en_base_datos(codigo_proveedor);
        }

        private void Obtener_datos_proveedores_disponibles_base_datos()
        {
            proveedores_disponibles = clase_proveedore.Adquiere_proveedores_disponibles_en_base_datos();
        }

        private void Aparece_combo_codigo_proveedor()
        {
            comboBoxCodigoProveedor.Visible = true;
        }

        private void Desaparece_caja_captura_codigo_proveedor()
        {
            textBoxCodigoProveedor.Visible = false;
        }

        private void Desactiva_botones_operacion()
        {
            Desactiva_boton_agregar_proveedor();
            Desactiva_boton_modificar_proveedor();
            Desactiva_boton_eliminar_proveedor();
            Desactiva_boton_visualizar_proveedor();
            Desactiva_boton_contactos();
        }

        private void Desactiva_boton_contactos()
        {
           buttonContactos.Enabled=false;
        }

        private void Desactiva_boton_visualizar_proveedor()
        {
            buttonBuscarProveedor.Enabled = false;
        }

        private void Desactiva_boton_eliminar_proveedor()
        {
            buttonEliminarProveedor.Enabled = false;
        }

        private void Desactiva_boton_modificar_proveedor()
        {
            buttonModificarProveedor.Enabled = false;
        }

        private void Desactiva_boton_agregar_proveedor()
        {
            buttonAgregarProveedor.Enabled = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Limpia_cajas_captura_despues_de_agregar_proveedor();
            Limpia_combo_nombre_proveedores();
            Limpia_combo_codigo_proveedor();
            Desactiva_cajas_captura_despues_de_agregar_proveedor();
            Desaparece_boton_guardar_base_de_datos();
            Desaparece_boton_cancelar();
            Desaparece_combo_codigo_proveedor();
            Desaparece_combo_nombre_proveedor();
            Activa_botones_operacion();
            limpia_contactos_proveedor();
            Desactiva_datagridview_contactos();
            Aparece_caja_codigo_proveedor();
            Aparece_caja_nombre_proveedor();
            Acepta_datagridview_agregar_renglones();
            Desaparece_botonoes_operacion_contactos();
            Desaparece_boton_eliminar_base_de_datos();
            Elimina_informacion_proveedores_disponibles();
        }

        private void Desaparece_combo_nombre_proveedor()
        {
            comboBoxNombreProveedor.Visible = false;
        }

        private void Aparece_caja_nombre_proveedor()
        {
            textBoxNombreProveedor.Visible = true;
        }

        private void Limpia_combo_nombre_proveedores()
        {
            comboBoxNombreProveedor.Items.Clear();
            comboBoxNombreProveedor.Text = "";
        }

        private void Aparece_caja_codigo_proveedor()
        {
            textBoxCodigoProveedor.Visible = true;
        }

        private void comboBoxCodigoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Operacio_proveedores == "Modificar")
                configura_forma_modificar();
            else if (Operacio_proveedores == "Eliminar")
                configura_forma_eliminar();
            else if (Operacio_proveedores == "Visualizar")
                configura_forma_visualizar();
            else if (Operacio_proveedores == "Operaciones Contactos")
                configura_forma_operaciones_contactos();

        }

        private void configura_forma_operaciones_contactos()
        {
            Desactiva_combo_nombre_proveedores();
            limpia_contactos_proveedor();
            Obtener_datos_proveedores_disponibles_base_datos();
            Rellena_cajas_informacion_de_proveedor();
            Obtener_datos_contactos_proveedores_disponibles_base_datos(textBoxCodigoProveedor.Text);
            Rellena_cajas_informacion_de_contactos_proveedores();
            Aparecer_botones_operaciones_contactos();
        }

        private void Desactiva_combo_nombre_proveedores()
        {
            comboBoxNombreProveedor.Enabled = false;
        }

        private void Aparecer_botones_operaciones_contactos()
        {
            
           Aparece_boton_agregar_contactos();
           Aparece_boton_eliminar_contactos();

        }

        private void Aparece_boton_eliminar_contactos()
        {
            buttonEliminarContacto.Visible = true;
        }

        private void Aparece_boton_agregar_contactos()
        {
            buttonAgregarContacto.Visible = true;
        }

        private void configura_forma_visualizar()
        {
            limpia_contactos_proveedor();
            Rellena_cajas_informacion_de_proveedor();
            Obtener_datos_contactos_proveedores_disponibles_base_datos(textBoxCodigoProveedor.Text);
            Rellena_cajas_informacion_de_contactos_proveedores();

        }

        private void Rellena_cajas_informacion_de_contactos_proveedores()
        {
            foreach (Contacto_proveedor contacto in contactos_proveedores_disponibles)
            {
                if (contacto.error == "")
                {
                    string[] contacto_infromacion = {contacto.codigo.ToString(), contacto.Nombre, contacto.Departamento, contacto.Telefono_Ofina,
                    contacto.Extencion,contacto.Telefono_celular,contacto.Correo_electronico};
                    dataGridViewContactosProveedor.Rows.Add(contacto_infromacion);
                }
                else
                {
                    MessageBox.Show(contacto.error);
                    break;
                }

            }

        }

        private void Rellena_cajas_informacion_de_proveedor()
        {
            Proveedor_modificaciones = proveedores_disponibles.Find(proveedor => proveedor.Nombre.Contains(comboBoxNombreProveedor.SelectedItem.ToString()));

            textBoxCodigoProveedor.Text = Proveedor_modificaciones.Codigo;
            textBoxDireccionProveedor.Text = Proveedor_modificaciones.Direccion;
            textBoxRfcProveedor.Text = Proveedor_modificaciones.Rfc;
            textBoxTelefonoProveedor.Text = Proveedor_modificaciones.Telefono;
            textBoxGiroProveedor.Text = Proveedor_modificaciones.Giro;
            textBoxCorreoeProveedor.Text = Proveedor_modificaciones.Correo;
            textBoxRazonSocial.Text = Proveedor_modificaciones.RazonSocial;
        }

        private void configura_forma_eliminar()
        {
            limpia_contactos_proveedor();
            Rellena_cajas_informacion_de_proveedor();
            Obtener_datos_contactos_proveedores_disponibles_base_datos(textBoxCodigoProveedor.Text);
            Rellena_cajas_informacion_de_contactos_proveedores();
            Aparece_boton_eliminar_datos_en_base_de_datos();
        }

        private void Aparece_boton_eliminar_datos_en_base_de_datos()
        {
            buttonBorrarBasedeDatos.Visible = true;
        }

        private void configura_forma_modificar()
        {
            limpia_contactos_proveedor();
            Rellena_cajas_informacion_de_proveedor();
            Obtener_datos_contactos_proveedores_disponibles_base_datos(textBoxCodigoProveedor.Text);
            Rellena_cajas_informacion_de_contactos_proveedores();
            Activa_cajas_informacion_proveedor();
            Desactiva_combobox_codigo_proveedores();
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
            Proveedor_modificaciones.Nombre = textBoxNombreProveedor.Text;
            Proveedor_modificaciones.Direccion = textBoxDireccionProveedor.Text;
            Proveedor_modificaciones.Rfc = textBoxRfcProveedor.Text;
            Proveedor_modificaciones.Telefono = textBoxTelefonoProveedor.Text;
            Proveedor_modificaciones.RazonSocial = textBoxRazonSocial.Text;

        }

        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos_modificar_clientes()
        {
            timerModificarProveedor.Enabled = true;
        }

        private void Desactiva_combobox_codigo_proveedores()
        {
            comboBoxCodigoProveedor.Enabled = false;
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
            Asigna_codigo_proveedor_foilio_disponible();
            Asigna_nuevo_folio();
            Desactiva_botones_operacion();
            Activa_cajas_informacion_proveedor();
            Acepta_datagridview_agregar_renglones();
            Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_proveedor();
            Aparece_boton_cancelar_operacio();
            Activa_datagridview_contactos_proveedores();
            Operacio_proveedores = "Agregar";
        }

        private void Asigna_codigo_proveedor_foilio_disponible()
        {
            folio_disponible = class_folio_disponible.Obtener_informacion_control_folio_base_datos();
            textBoxCodigoProveedor.Text = folio_disponible.Folio_proveedores;
        }

        private void Acepta_datagridview_agregar_renglones()
        {
            dataGridViewContactosProveedor.AllowUserToAddRows = true;
        }

        private void Activa_datagridview_contactos_proveedores()
        {
            dataGridViewContactosProveedor.Enabled = true;
        }

        private void Desactiva_columna_codigo_contactos_cliente()
        {
            dataGridViewContactosProveedor.Columns[0].Visible = false;
        }

        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_proveedor()
        {
            timerAgregarProveedor.Enabled = true;
        }

        private void Activa_cajas_informacion_proveedor()
        {
            textBoxNombreProveedor.Enabled = true;
            textBoxDireccionProveedor.Enabled = true;
            textBoxRfcProveedor.Enabled = true;
            textBoxTelefonoProveedor.Enabled = true;
            textBoxGiroProveedor.Enabled = true;
            textBoxCorreoeProveedor.Enabled = true;
            textBoxRazonSocial.Enabled = true;
        }

        private void Modifica_contactos_cliente()
        {
            throw new NotImplementedException();
        }



        private void timerAgregarProveedor_Tick(object sender, EventArgs e)
        {
            if (textBoxNombreProveedor.Text != "" &&
            textBoxDireccionProveedor.Text != "" &&
            textBoxRfcProveedor.Text != "" &&
            textBoxTelefonoProveedor.Text != "" &&
            textBoxGiroProveedor.Text!="" &&
            textBoxCorreoeProveedor.Text != "" &&
            textBoxRazonSocial.Text != "")
            {
                timerAgregarProveedor.Enabled = false;
                buttonGuardarBasedeDatos.Visible = true;
            }
        }

        private void buttonGuardarBasedeDatos_Click(object sender, EventArgs e)
        {
            if (Operacio_proveedores == "Agregar")
                Secuencia_agregar_proveedor();
            else if (Operacio_proveedores == "Modificar")
                Secuencia_modificar_proveedor();
            else if (Operacio_proveedores == "Agregar Contactos")
                Secuencia_agregar_contactos();
        }

        private void Secuencia_agregar_contactos()
        {
            if (verifica_datos_partidas())
            {
                if (Guarda_datos_contactos_proveedor())
                {
                    Desaparece_boton_guardar_base_de_datos();
                    Activa_botones_operacion_contactos();
                    limpia_contactos_proveedor();
                    Obtener_datos_contactos_proveedores_disponibles_base_datos(textBoxCodigoProveedor.Text);
                    Rellena_cajas_informacion_de_contactos_proveedores();
                    Elimina_informacion_proveedores_disponibles();
                }
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
            buttonAgregarContacto.Enabled = true;
        }

        private void Secuencia_modificar_proveedor()
        {
            if (verifica_datos_partidas())
            {
                if (Modificar_datos_contactos_cliente())
                {
                    if (Modifica_datos_clientes())
                    {
                        Limpia_cajas_captura_despues_de_agregar_proveedor();
                        Limpia_combo_nombre_proveedores();
                        Desactiva_cajas_captura_despues_de_agregar_proveedor();
                        Desaparece_boton_guardar_base_de_datos();
                        Desaparece_boton_cancelar();
                        Desaparece_combo_codigo_proveedor();
                        Aparce_caja_codigo_cliente();
                        Activa_botones_operacion();
                        limpia_contactos_proveedor();
                        Desactiva_datagridview_contactos();
                        Desaparece_combo_nombre_proveedor();
                        Aparece_caja_nombre_proveedor();
                        Elimina_informacion_proveedores_disponibles();
                    }
                }
            }
        }

        private void Aparce_caja_codigo_cliente()
        {
            textBoxCodigoProveedor.Visible = true;
        }

        private bool Modifica_datos_clientes()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_sistema_proveedor());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_modificar_en_base_de_datos_proveedor(), connection);
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

        private string Configura_cadena_comando_modificar_en_base_de_datos_proveedor()
        {
            return "UPDATE proveedores set  nombre_proveedor='" + comboBoxNombreProveedor.Text +
               "',razon_social='" + textBoxRazonSocial.Text +
               "',direccion_proveedor='" + textBoxDireccionProveedor.Text +
               "',rfc_proveedor='" + textBoxRfcProveedor.Text +
               "',telefono_proveedor='" + textBoxTelefonoProveedor.Text +
               "',giro_proveedor='" + textBoxGiroProveedor.Text +
               "',correoe_proveedor='" + textBoxCorreoeProveedor.Text +
               "' where codigo_proveedor='" + textBoxCodigoProveedor.Text + "';";
        }

        private bool Modificar_datos_contactos_cliente()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_sistema_proveedor());
            try
            {
                connection.Open();
                for (int contactos = 0; contactos < dataGridViewContactosProveedor.Rows.Count; contactos++)
                {
                    for (int campo = 0; campo < dataGridViewContactosProveedor.Rows[contactos].Cells.Count; campo++)
                    {
                        if (dataGridViewContactosProveedor.Rows[contactos].Cells[campo].Value != null)
                        {

                            if (campo == (int)Campos_contactos.nombre)
                                Contact_proveedor_modificar.Nombre = dataGridViewContactosProveedor.Rows[contactos].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_contactos.departamento)
                                Contact_proveedor_modificar.Departamento = dataGridViewContactosProveedor.Rows[contactos].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_contactos.telefonoOficina)
                                Contact_proveedor_modificar.Telefono_Ofina = dataGridViewContactosProveedor.Rows[contactos].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_contactos.extencion)
                                Contact_proveedor_modificar.Extencion = dataGridViewContactosProveedor.Rows[contactos].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_contactos.telefonoCelular)
                                Contact_proveedor_modificar.Telefono_celular = dataGridViewContactosProveedor.Rows[contactos].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_contactos.correElectronico)
                                Contact_proveedor_modificar.Correo_electronico = dataGridViewContactosProveedor.Rows[contactos].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_contactos.codigo)
                                Contact_proveedor_modificar.codigo = Convert.ToInt32(dataGridViewContactosProveedor.Rows[contactos].Cells[campo].Value.ToString());
                        }

                        else
                        {
                            MessageBox.Show("campo en blanco");
                            connection.Close();
                            return false;
                        }
                    }
                    MySqlCommand command = new MySqlCommand(Configura_cadena_comando_en_base_de_datos_modificar_contacto_proveedor(Contact_proveedor_modificar), connection);
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

        private string Configura_cadena_comando_en_base_de_datos_modificar_contacto_proveedor(Contacto_proveedor contact_cliente_modificar)
        {
            return "UPDATE contactos_proveedor set  nombre_contacto='" + contact_cliente_modificar.Nombre +
                "',departamento_contacto='" + contact_cliente_modificar.Departamento +
                "',telefono_oficina_contacto='" + contact_cliente_modificar.Telefono_Ofina +
                "',extencion_contacto='" + contact_cliente_modificar.Extencion +
                "',telefono_celular_contacto='" + contact_cliente_modificar.Telefono_celular +
                "',correo_e_contacto='" + contact_cliente_modificar.Correo_electronico +
                "' where codigo_contacto='" + contact_cliente_modificar.codigo + "';";
        }

        private void Secuencia_agregar_proveedor()
        {
            if (verifica_datos_partidas())
            {
                if (Guarda_datos_contactos_proveedor())
                {
                    if (Guarda_datos_proveedores())
                    {
                        Limpia_cajas_captura_despues_de_agregar_proveedor();
                        Limpia_combo_codigo_proveedor();
                        Desactiva_cajas_captura_despues_de_agregar_proveedor();
                        Desaparece_boton_guardar_base_de_datos();
                        Desaparece_boton_cancelar();
                        Desaparece_combo_codigo_proveedor();
                        Activa_botones_operacion();
                        limpia_contactos_proveedor();
                        Desactiva_datagridview_contactos();
                        Elimina_informacion_proveedores_disponibles();
                    }
                }
            }

        }

        private bool verifica_datos_partidas()
        {
            for (int contactos = 0; contactos < dataGridViewContactosProveedor.Rows.Count - 1; contactos++)
            {
                for (int campo = 1; campo < dataGridViewContactosProveedor.Rows[contactos].Cells.Count; campo++)
                {
                    if (dataGridViewContactosProveedor.Rows[contactos].Cells[campo].Value == null)
                    {
                        MessageBox.Show("campo en blanco");
                        return false;
                    }

                }
            }
            return true;
        }

        private void Asigna_nuevo_folio()
        {
            int numero_folio = Convert.ToInt32(folio_disponible.Folio_proveedores.Substring(1, folio_disponible.Folio_proveedores.Length - 1));
            numero_folio++;
            folio_disponible.Folio_proveedores = folio_disponible.Folio_proveedores.Substring(0, 1) + numero_folio.ToString("00000");
            string respuesta = class_folio_disponible.Actualiza_Control_folios_base_datos(folio_disponible);
            if (respuesta != "")
                MessageBox.Show(folio_disponible.error);
        }

        private void Desactiva_datagridview_contactos()
        {
            dataGridViewContactosProveedor.Enabled = false;
        }

        private void Limpia_informacion_datagridview_clientes()
        {
            throw new NotImplementedException();
        }

        private void Elimina_informacion_proveedores_disponibles()
        {
            proveedores_disponibles = null;
            contactos_proveedores_disponibles = null;
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
            buttonBuscarProveedor.Enabled = true;
        }

        private void Activa_boton_eliminar_cliente()
        {
            buttonEliminarProveedor.Enabled = true;
        }

        private void Activa_boton_modificar_cliente()
        {
            buttonModificarProveedor.Enabled = true;
        }

        private void Activa_boton_agregar_cliente()
        {
            buttonAgregarProveedor.Enabled = true;
        }

        private void Desaparece_combo_codigo_proveedor()
        {
            comboBoxCodigoProveedor.Visible = false;
        }

        private void Desaparece_boton_cancelar()
        {
            buttonCancelar.Visible = false;
        }

        private void Desaparece_boton_guardar_base_de_datos()
        {
            buttonGuardarBasedeDatos.Visible = false;
        }

        private void Desactiva_cajas_captura_despues_de_agregar_proveedor()
        {
            textBoxCodigoProveedor.Enabled = false;
            textBoxNombreProveedor.Enabled = false;
            textBoxDireccionProveedor.Enabled = false;
            textBoxRfcProveedor.Enabled = false;
            textBoxTelefonoProveedor.Enabled = false;
            textBoxGiroProveedor.Enabled = false;
            textBoxCorreoeProveedor.Enabled = false;
            textBoxRazonSocial.Enabled = false;
        }

        private void Limpia_combo_codigo_proveedor()
        {
            comboBoxCodigoProveedor.Items.Clear();
            comboBoxCodigoProveedor.Text = "";
        }

        private void Limpia_cajas_captura_despues_de_agregar_proveedor()
        {
            textBoxCodigoProveedor.Text = "";
            textBoxNombreProveedor.Text = "";
            textBoxDireccionProveedor.Text = "";
            textBoxRfcProveedor.Text = "";
            textBoxTelefonoProveedor.Text = "";
            textBoxGiroProveedor.Text = "";
            textBoxCorreoeProveedor.Text = "";
            textBoxRazonSocial.Text = "";
        }

        private bool Guarda_datos_contactos_proveedor()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_sistema_proveedor());
            try
            {
                connection.Open();
                for (int contactos = 0; contactos < dataGridViewContactosProveedor.Rows.Count - 1; contactos++)
                {
                    for (int campo = 1; campo < dataGridViewContactosProveedor.Rows[contactos].Cells.Count; campo++)
                    {
                        if (dataGridViewContactosProveedor.Rows[contactos].Cells[campo].Value != null)
                        {
                            if (campo == (int)Campos_contactos.nombre)
                                Contacto_proveedor_agregar.Nombre = dataGridViewContactosProveedor.Rows[contactos].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_contactos.departamento)
                                Contacto_proveedor_agregar.Departamento = dataGridViewContactosProveedor.Rows[contactos].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_contactos.telefonoOficina)
                                Contacto_proveedor_agregar.Telefono_Ofina = dataGridViewContactosProveedor.Rows[contactos].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_contactos.extencion)
                                Contacto_proveedor_agregar.Extencion = dataGridViewContactosProveedor.Rows[contactos].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_contactos.telefonoCelular)
                                Contacto_proveedor_agregar.Telefono_celular = dataGridViewContactosProveedor.Rows[contactos].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_contactos.correElectronico)
                                Contacto_proveedor_agregar.Correo_electronico = dataGridViewContactosProveedor.Rows[contactos].Cells[campo].Value.ToString();
                        }

                        else
                        {
                            MessageBox.Show("campo en blanco");
                            connection.Close();
                            return false;
                        }
                    }
                    Asigna_codigo_empleado_para_tipo_de_operacio();
                    MySqlCommand command = new MySqlCommand(Configura_cadena_comando_insertar_en_base_de_datos_contacto_proveedor(Contacto_proveedor_agregar), connection);
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
            if (Operacio_proveedores == "Agregar")
                Contacto_proveedor_agregar.Codigo_proveedor = textBoxCodigoProveedor.Text;
            else if (Operacio_proveedores == "Agregar Contactos")
                Contacto_proveedor_agregar.Codigo_proveedor = textBoxCodigoProveedor.Text;
        }

        private string Configura_cadena_comando_insertar_en_base_de_datos_contacto_proveedor(Contacto_proveedor contacto_proveedor)
        {
            return "INSERT INTO contactos_proveedor(nombre_contacto, departamento_contacto,telefono_oficina_contacto," +
                "extencion_contacto,telefono_celular_contacto,correo_e_contacto,codigo_proveedor) " +
                "VALUES('" + contacto_proveedor.Nombre + "','" + contacto_proveedor.Departamento + "'," +
                "'" + contacto_proveedor.Telefono_Ofina + "','" + contacto_proveedor.Extencion + "'" +
                ",'" + contacto_proveedor.Telefono_celular + "','" + contacto_proveedor.Correo_electronico + "'," +
                "'" + contacto_proveedor.Codigo_proveedor + "');";
        }

        private bool Guarda_datos_proveedores()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_sistema_proveedor());
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
            return "INSERT INTO proveedores(codigo_proveedor, nombre_proveedor,direccion_proveedor," +
                "rfc_proveedor,telefono_proveedor,giro_proveedor,correoe_proveedor,razon_social) " +
                "VALUES('" + textBoxCodigoProveedor.Text + "','" + textBoxNombreProveedor.Text + "'," +
                "'" + textBoxDireccionProveedor.Text + "','" + textBoxRfcProveedor.Text + "'" +
                ",'" + textBoxTelefonoProveedor.Text + "','" + textBoxGiroProveedor.Text +
                "','" + textBoxCorreoeProveedor.Text + "','" + textBoxRazonSocial.Text + "');";
        }

        private string Configura_cadena_conexion_MySQL_sistema_proveedor()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=sistema;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }


        private void buttonModificarCliente_Click(object sender, EventArgs e)
        {
            Modifica_proveedor();
        }

        private void Modifica_proveedor()
        {
            Desactiva_botones_operacion();
            Desaparece_caja_nombre_proveedor();
            Aparece_combo_nombre_proveedor();
            Obtener_datos_proveedores_disponibles_base_datos();
            Rellena_combo_nombre_proveedores();
            Aparece_boton_cancelar_operacio();
            No_aceptar_agregar_contactos_proveedor();
            Activa_dataview_contacto_proveedores();
            Activa_combo_nombre_proveedor();
            Operacio_proveedores = "Modificar";
        }

        private void Activa_combo_nombre_proveedor()
        {
            comboBoxNombreProveedor.Enabled = true;
        }

        private void buttonEliminarCliente_Click(object sender, EventArgs e)
        {
            Desactiva_botones_operacion();
            Desaparece_caja_nombre_proveedor();
            Aparece_combo_nombre_proveedor();
            Activa_combo_nombre_proveedor();
            Obtener_datos_proveedores_disponibles_base_datos();
            Rellena_combo_nombre_proveedores();
            Aparece_boton_cancelar_operacio();
            Operacio_proveedores = "Eliminar";
        }

        private bool Elimina_informacion_proveedor_en_base_de_datos()
        {
            if (Elimina_datos_proveedor() && Elinina_contactos_proveedor())
                return true;
            else
                return false;
             
        }

        private bool Elinina_contactos_proveedor()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_sistema_proveedor());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_eliminar_en_base_de_datos_contactos_proveedor(), connection);
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

        private string Configura_cadena_comando_eliminar_en_base_de_datos_contactos_proveedor()
        {
            return "DELETE from contactos_proveedor where codigo_proveedor='" +
               textBoxCodigoProveedor.Text + "';";
        }

        private bool Elimina_datos_proveedor()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_sistema_proveedor());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_eliminar_en_base_de_datos_proveedor(), connection);
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
        private string Configura_cadena_comando_eliminar_en_base_de_datos_proveedor()
        {
            return "DELETE from proveedores where codigo_proveedor='" +
               textBoxCodigoProveedor.Text + "';";
        }

        private void timerModificarProveedor_Tick(object sender, EventArgs e)
        {
            if (Proveedor_modificaciones.Nombre != textBoxNombreProveedor.Text ||
            Proveedor_modificaciones.Direccion != textBoxDireccionProveedor.Text ||
            Proveedor_modificaciones.Rfc != textBoxRfcProveedor.Text ||
            Proveedor_modificaciones.Telefono != textBoxTelefonoProveedor.Text)
            {
                timerModificarProveedor.Enabled = false;
                buttonGuardarBasedeDatos.Visible = true;
            }
        }

        private void buttonBorrarBasedeDatos_Click(object sender, EventArgs e)
        {
            if (Operacio_proveedores == "Eliminar Contacto")
                Elimina_contacto_proveedor();
            else if (Operacio_proveedores == "Eliminar")
                Elimina_proveedor();
        }

        private void Elimina_contacto_proveedor()
        {
            if (MessageBox.Show("Esta Seguro de Eiliminar el contacto seleccionado?",
                "Eliminar Contacto Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Elimina_informacion_contacto_proveedor_en_base_de_datos())
                {
                    Desaparece_boton_eliminar_base_de_datos();
                    Activa_botones_operacion_contactos();
                    limpia_contactos_proveedor();
                    Obtener_datos_contactos_proveedores_disponibles_base_datos(textBoxCodigoProveedor.Text);
                    Rellena_cajas_informacion_de_contactos_proveedores();
                    limpia_texto_eliminar_contacto();
                }
            }
        }

        private void Desaparece_botonoes_operacion_contactos()
        {
            Desaparece_boton_agregar_contacto();
            Desaparece_boton_eliminar_contacto();

        }

        private void Desaparece_boton_eliminar_contacto()
        {
            buttonEliminarContacto.Visible = false;
        }

        private void Desaparece_boton_agregar_contacto()
        {
            buttonAgregarContacto.Visible = false;
        }

        private bool Elimina_informacion_contacto_proveedor_en_base_de_datos()
        {
            if (Elimina_contacto_proveedor_seleccionado())
                return true;
            else
                return false;
        }

        private bool Elimina_contacto_proveedor_seleccionado()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_sistema_proveedor());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_eliminar_en_base_de_datos_contacto_proveedor(), connection);
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

        private string Configura_cadena_comando_eliminar_en_base_de_datos_contacto_proveedor()
        {
            return "DELETE from contactos_proveedor where codigo_contacto='" +
                RenglonParaEliminar + "';";
        }


        private void Elimina_proveedor()
        {
            if (MessageBox.Show("Esta Seguro de Eiliminar Este Proveedor Incluyendo Todos sus Contactos?",
                "Eliminar Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Elimina_informacion_proveedor_en_base_de_datos())
                {
                    Limpia_cajas_captura_despues_de_agregar_proveedor();
                    Limpia_combo_nombre_proveedores();
                    Desactiva_cajas_captura_despues_de_agregar_proveedor();
                    Desaparece_boton_eliminar_base_de_datos();
                    Desaparece_boton_cancelar();
                    Desaparece_combo_codigo_proveedor();
                    Desaparece_combo_nombre_proveedor();
                    Activa_botones_operacion();
                    limpia_contactos_proveedor();
                    Desactiva_datagridview_contactos();
                    Elimina_informacion_proveedores_disponibles();
                    Aparece_caja_nombre_proveedor();
                }
            }
        }

        private void limpia_texto_eliminar_contacto()
        {
            RenglonParaEliminar = "";
        }

        private void Desaparece_boton_eliminar_base_de_datos()
        {
            buttonBorrarBasedeDatos.Visible = false;
        }

        private void buttonContactos_Click(object sender, EventArgs e)
        {
            Contactos_operaciones();
        }
        private void Contactos_operaciones()
        {
            Desactiva_botones_operacion();
            Desaparece_caja_nombre_proveedor();
            Aparece_combo_nombre_proveedor();
            Activa_combo_nombre_proveedor();
            Obtener_datos_proveedores_disponibles_base_datos();
            Rellena_combo_nombre_proveedores();
            Aparece_boton_cancelar_operacio();
            No_aceptar_agregar_contactos_proveedor();
            Activa_dataview_contacto_proveedores();
            Operacio_proveedores = "Operaciones Contactos";
        }

        private void buttonAgregarContacto_Click(object sender, EventArgs e)
        {
            Agrega_contactos_clientes();
        }

        private void Agrega_contactos_clientes()
        {
            Desactiva_botones_operacion_contactos();
            limpia_contactos_proveedor();
            Acepta_datagridview_agregar_renglones();
            Aparce_boton_guardar_base_datos();
            Operacio_proveedores = "Agregar Contactos";
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

        private void buttonEliminarContacto_Click(object sender, EventArgs e)
        {

            Elimina_Contacto_cliente();
           
        }

        private void Elimina_Contacto_cliente()
        {
            Desactiva_botones_operacion_contactos();
            No_aceptar_agregar_contactos_proveedor();
            Operacio_proveedores = "Eliminar Contacto";
        }

        private void dataGridViewContactosProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Operacio_proveedores == "Eliminar Contacto")
            {
                Aparece_boton_eliminar_datos_en_base_de_datos();
                RenglonParaEliminar = dataGridViewContactosProveedor.Rows[e.RowIndex].Cells["Codigo_contacto"].Value.ToString();
            }
        }

        private void comboBoxNombreProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Operacio_proveedores == "Modificar")
                configura_forma_modificar();
            else if (Operacio_proveedores == "Eliminar")
                configura_forma_eliminar();
            else if (Operacio_proveedores == "Visualizar")
                configura_forma_visualizar();
            else if (Operacio_proveedores == "Operaciones Contactos")
                configura_forma_operaciones_contactos();
        }
    }
}
