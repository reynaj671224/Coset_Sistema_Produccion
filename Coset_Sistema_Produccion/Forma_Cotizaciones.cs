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
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;
using word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Diagnostics;
using System.Globalization;

namespace Coset_Sistema_Produccion
{
    public partial class Forma_Cotizaciones : Form
    {
        public List<Cotizacion> cotizaciones_disponibles = new List<Cotizacion>();
        public Class_Cotizaciones clase_cotizaciones = new Class_Cotizaciones();
        public List<Partida_cotizacion> partidas_cotizacion_disponibles = new List<Partida_cotizacion>();
        public Class_Partidas_Cotizaciones clase_partidas_cotizacion = new Class_Partidas_Cotizaciones();
        public Cotizacion cotizacion_modificaciones = new Cotizacion();
        public Cotizacion cotizacion_visualizar = new Cotizacion();
        public Partida_cotizacion partida_cotizacion_agregar = new Partida_cotizacion();
        public Partida_cotizacion Partidas_cotizacion_modificar = new Partida_cotizacion();
        public Class_Control_Folios class_folio_disponible = new Class_Control_Folios();
        public Control_folio folio_disponible = new Control_folio();
        public Datos_generales datos_generales = new Datos_generales();
        public Class_Datos_Generales Class_Datos_Generales = new Class_Datos_Generales();
        public List<Cliente> clientes_disponibles = new List<Cliente>();
        public Class_Clientes clase_clientes = new Class_Clientes();
        public List<Contacto_cliente> contactos_cliente_disponibles = new List<Contacto_cliente>();
        public Class_Contactos_Clientes clase_contactos_cliente = new Class_Contactos_Clientes();
        public Cliente Cliente_seleccionado = new Cliente();
        string RenglonParaEliminar = "";
        string appPath = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
        public CultureInfo cultureInfo = new CultureInfo("en-US");
        public string nombre_archivo_word = "";
        public word.Application application = null;
        public word.Document Documento = null;
        public enum Campos_partidas
        {
            codigo, numero, cantidad, parte, descripcion,
            precio, importe
        };

        public string Operacio_cotizaciones = "";

        public Forma_Cotizaciones()
        {
            InitializeComponent();
        }

        private void Forma_Clientes_Load(object sender, EventArgs e)
        {
            Desactiva_columna_codigo_partidas_cotizaciones();
            Habilita_combo_para_aceptar_buscar_elemento_escribiendo_en_ventana();
        }

        private void Habilita_combo_para_aceptar_buscar_elemento_escribiendo_en_ventana()
        {
            comboBoxCodigoCotizaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBoxCodigoCotizaciones.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCodigoCotizaciones.AutoCompleteSource = AutoCompleteSource.ListItems;


            comboBoxAtencion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBoxAtencion.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxAtencion.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxAtencionCopia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBoxAtencionCopia.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxAtencionCopia.AutoCompleteSource = AutoCompleteSource.ListItems;


            comboBoxNombreCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBoxNombreCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxNombreCliente.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            cotizaciones_disponibles = null;
            clase_cotizaciones = null;
            partidas_cotizacion_disponibles = null;
            clase_partidas_cotizacion = null;
            cotizacion_modificaciones = null;
            partida_cotizacion_agregar = null;
            Partidas_cotizacion_modificar = null;
            class_folio_disponible = null;
            folio_disponible = null;
            Cierra_documento_word();
            Terminar_applicacion_word();
            this.Dispose();
            GC.Collect();
            this.Close();
        }

        private void Terminar_applicacion_word()
        {
            Quitar_aplicacion();
            Final_release_aplicacion();
            
            
        }

        private void Final_release_aplicacion()
        {
            try
            {
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(application);
            }
            catch
            {
            }
        }

        private void Quitar_aplicacion()
        {
            try
            {
                application.Quit();
            }
            catch
            {
            }
        }

        private void Cierra_documento_word()
        {
            try
            {
                Documento.Close();
            }
            catch
            {
                
            }
           
        }

        private void buttonBuscarempleado_Click(object sender, EventArgs e)
        {
            Visualiza_cliente();
        }

        private void Visualiza_cliente()
        {
            Desactiva_botones_operacion();
            Desaparece_caja_captura_codigo_cotizacion();
            Aparece_combo_codigo_cotizacion();
            Activa_combo_codigo_cotizacion();
            Obtener_datos_cotizaciones_disponibles_base_datos();
            Rellena_combo_codigo_cotizacion();
            Aparece_boton_cancelar_operacio();
            No_aceptar_agregar_contactos_cotizacion();
            Activa_dataview_partidas_cotizacion();
            Operacio_cotizaciones = "Visualizar";
        }

        private void Aparece_grupo_previo_word()
        {
            groupBoxPrevio.Visible=true;
        }

        private void Activa_combo_codigo_cotizacion()
        {
            comboBoxCodigoCotizaciones.Enabled = true;
        }

        private void Activa_dataview_partidas_cotizacion()
        {
            dataGridViewPartidasCotizacion.Enabled = true;
        }

        private void limpia_partidas_cotizacion()
        {
            dataGridViewPartidasCotizacion.Rows.Clear();
        }

        private void No_aceptar_agregar_contactos_cotizacion()
        {
            dataGridViewPartidasCotizacion.AllowUserToAddRows = false;
        }

        private void Aparece_boton_cancelar_operacio()
        {
            buttonCancelar.Visible = true;
        }

        private void Rellena_combo_codigo_cotizacion()
        {
            foreach (Cotizacion cotizacion in cotizaciones_disponibles)
            {
                if (cotizacion.error == "")
                    comboBoxCodigoCotizaciones.Items.Add(cotizacion.Codigo);
                else
                {
                    MessageBox.Show(cotizacion.error);
                    break;
                }
            }
        }

        private void Obtener_datos_partidas_cotizacion_disponibles_base_datos(string codigo_cliente)
        {
            partidas_cotizacion_disponibles = clase_partidas_cotizacion.Adquiere_partidas_cotizacion_disponibles_en_base_datos(codigo_cliente);
        }

        private void Obtener_datos_cotizaciones_disponibles_base_datos()
        {
            cotizaciones_disponibles = clase_cotizaciones.Adquiere_cotizaciones_disponibles_en_base_datos();
        }

        private void Aparece_combo_codigo_cotizacion()
        {
            comboBoxCodigoCotizaciones.Visible = true;
        }

        private void Desaparece_caja_captura_codigo_cotizacion()
        {
            textBoxCodigoCotizaciones.Visible = false;
        }

        private void Desactiva_botones_operacion()
        {
            Desactiva_boton_agregar_cotizacion();
            Desactiva_boton_modificar_cotizacion();
            Desactiva_boton_eliminar_cotizacion();
            Desactiva_boton_visualizar_cotizacion();
            Desactiva_boton_copiar();
            Desactiva_boton_partidas();
        }

        private void Desactiva_boton_copiar()
        {
            buttonCopiarCotizacion.Enabled = false;
        }

        private void Desactiva_boton_partidas()
        {
            buttonPartidas.Enabled = false;
        }

        private void Desactiva_boton_visualizar_cotizacion()
        {
            buttonBuscarCotizacion.Enabled = false;
        }

        private void Desactiva_boton_eliminar_cotizacion()
        {
            buttonEliminarCotizacion.Enabled = false;
        }

        private void Desactiva_boton_modificar_cotizacion()
        {
            buttonModificarCotizacion.Enabled = false;
        }

        private void Desactiva_boton_agregar_cotizacion()
        {
            buttonAgregarCotizacion.Enabled = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Limpia_combo_codigo_cotizacion();
            Limpia_combo_nombre_cliente();
            Limpia_combo_atencion();
            Limpia_combo_atencio_copia();
            Limpia_cajas_captura_despues_de_agregar_cotizacion();
            Limpia_combo_codigo_cotizacion();
            Desactiva_cajas_captura_despues_de_agregar_cotizacion();
            Desaparece_boton_guardar_base_de_datos();
            Desaparece_boton_cancelar();
            Desaparece_combo_codigo_cotizacion();
            Desaparece_combo_atencion();
            Desaparece_combo_copia_atencion();
            Desaparece_combo_codigo_cotizacion();
            Desaparece_combo_cliente_nombre();
            Activa_botones_operacion();
            limpia_partidas_cotizacion();
            Desactiva_datagridview_partidas();
            Aparece_caja_codigo_empleado();
            Aparece_textbox_atencion();
            Aparece_textbox_atencion_copia();
            Aparece_textbox_nombre_cliente();
            Acepta_datagridview_agregar_renglones();
            Desaparece_botones_operacion_contactos();
            Desaparce_previo_word();
            Cierra_documento_word();
            Activa_boton_cotizacion_previo();
            Limpia_estado_radio_botones();
            Desabilita_boton_word_previo();
            Elimina_archivo();
            Elimina_informacion_cotizaciones_disponibles();
        }

        private void Limpia_combo_atencio_copia()
        {
            comboBoxAtencionCopia.Items.Clear();
            comboBoxAtencionCopia.Text = "";
        }

        private void Limpia_combo_atencion()
        {
            comboBoxAtencion.Items.Clear();
            comboBoxAtencion.Text = "";
        }

        private void Limpia_combo_nombre_cliente()
        {
            comboBoxNombreCliente.Items.Clear();
            comboBoxNombreCliente.Text = "";
        }

        private void Desabilita_boton_word_previo()
        {
            buttonWordPrevio.Enabled = false;
        }

        private void Activa_boton_cotizacion_previo()
        {
            buttonWordPrevio.Enabled = true;
        }

        private void Desaparce_previo_word()
        {
            groupBoxPrevio.Visible = false;
        }

        private void Desaparece_botones_operacion_contactos()
        {
            Desaparece_boton_agrega_contacto();
            Desaparece_boton_eliminar_contacto();
        }

        private void Desaparece_boton_eliminar_contacto()
        {
            buttonEliminarPartida.Visible=false;
        }

        private void Desaparece_boton_agrega_contacto()
        {
            buttonAgregarPartida.Visible=false;
        }

        private void Aparece_caja_codigo_empleado()
        {
            textBoxCodigoCotizaciones.Visible = true;
        }

        private void comboBoxCodigoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Operacio_cotizaciones == "Modificar")
                configura_forma_modificar();
            else if (Operacio_cotizaciones == "Eliminar")
                configura_forma_eliminar();
            else if (Operacio_cotizaciones == "Visualizar")
                configura_forma_visualizar();
            else if (Operacio_cotizaciones == "Operaciones Patidas")
                configura_forma_operaciones_contactos();
            else if (Operacio_cotizaciones == "Copiar")
                configura_forma_copiar();

        }

        private void configura_forma_copiar()
        {
            limpia_partidas_cotizacion();
            Rellena_cajas_informacion_de_cotizacion();
            Obtener_datos_partidas_cotizacion_disponibles_base_datos(comboBoxCodigoCotizaciones.Text);
            Rellena_cajas_informacion_de_partidas_cotizacion();
            Aparce_boton_guardar_base_datos();
        }

        private void configura_forma_agregar()
        {
            Desactiva_combobox_codigo_cotizaciones();
            Desaparece_textbox_nombre_cliente();
            Aparece_combo_nombre_cliente();
            Activa_combo_nombre_cliente();
            Obtener_clientes_disponibles();
            Rellena_combo_clientes();
        }

        private void Rellena_combo_clientes()
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

        private void Obtener_clientes_disponibles()
        {
            clientes_disponibles = clase_clientes.Adquiere_clientes_disponibles_en_base_datos();
        }

        private void Activa_combo_nombre_cliente()
        {
            comboBoxNombreCliente.Enabled = true;
        }

        private void Aparece_combo_nombre_cliente()
        {
            comboBoxNombreCliente.Visible = true;
        }

        private void Desaparece_textbox_nombre_cliente()
        {
            textBoxNombreCliente.Visible = false;
        }

        private void configura_forma_operaciones_contactos()
        {
            Desactiva_combobox_codigo_cotizaciones();
            limpia_partidas_cotizacion();
            Obtener_datos_cotizaciones_disponibles_base_datos();
            Rellena_cajas_informacion_de_cotizacion();
            Obtener_datos_partidas_cotizacion_disponibles_base_datos(comboBoxCodigoCotizaciones.Text);
            Rellena_cajas_informacion_de_partidas_cotizacion();
            Aparecer_botones_operaciones_partidas();
            

        }

        private void Aparecer_botones_operaciones_partidas()
        {
            Aparece_boton_agregar_partidas();
            Aparece_boton_eliminar_partidas();
        }

        private void configura_forma_visualizar()
        {
            limpia_partidas_cotizacion();
            Rellena_cajas_informacion_de_cotizacion();
            Obtener_datos_partidas_cotizacion_disponibles_base_datos(comboBoxCodigoCotizaciones.Text);
            Rellena_cajas_informacion_de_partidas_cotizacion();
            Aparece_grupo_previo_word();
            Limpia_estado_radio_botones();

        }

        private void Limpia_estado_radio_botones()
        {
            radioButtonPrevioEspanol.Checked = false;
            radioButtonPrevioIngles.Checked = false;
        }

        private void Rellena_cajas_informacion_de_partidas_cotizacion()
        {
            foreach (Partida_cotizacion partidas in partidas_cotizacion_disponibles)
            {
                if (partidas.error == "")
                {
                    string[] partida_infromacion = {partidas.Codigo.ToString(), partidas.Numero,
                        partidas.Cantidad, partidas.Parte, partidas.Descripcion,partidas.Precio,
                        partidas.Importe};
                    dataGridViewPartidasCotizacion.Rows.Add(partida_infromacion);
                }
                else
                {
                    MessageBox.Show(partidas.error);
                    break;
                }

            }

        }

        private void Rellena_cajas_informacion_de_cotizacion()
        {
            cotizacion_visualizar = cotizaciones_disponibles.Find(cotizaciones => cotizaciones.Codigo.Contains(comboBoxCodigoCotizaciones.SelectedItem.ToString()));

            textBoxNombreCliente.Text = cotizacion_visualizar.Nombre;
            dateTimePickerFechaActual.Text = cotizacion_visualizar.Fecha_cotizacion;
            dateTimePickerFechaEntrega.Text = cotizacion_visualizar.Fecha_entrega;
            textBoxAtencion.Text = cotizacion_visualizar.Atencion;
            textBoxAtencionCopia.Text = cotizacion_visualizar.Atencion_copia;
            textBoxOrdenTrabajo.Text = cotizacion_visualizar.Orden_compra;
            textBoxProyecto.Text = cotizacion_visualizar.Proyecto;
        }

        private void configura_forma_eliminar()
        {
            limpia_partidas_cotizacion();
            Rellena_cajas_informacion_de_cotizacion();
            Obtener_datos_partidas_cotizacion_disponibles_base_datos(comboBoxCodigoCotizaciones.Text);
            Rellena_cajas_informacion_de_partidas_cotizacion();
            Aparece_boton_eliminar_datos_en_base_de_datos();
        }

        private void Aparece_boton_eliminar_datos_en_base_de_datos()
        {
            buttonBorrarBasedeDatos.Visible = true;
        }

        private void configura_forma_modificar()
        {
            limpia_partidas_cotizacion();
            Rellena_cajas_informacion_de_cotizacion_modificar();
            Rellena_cajas_informacion_de_cotizacion();
            Obtener_datos_partidas_cotizacion_disponibles_base_datos(comboBoxCodigoCotizaciones.Text);
            Rellena_cajas_informacion_de_partidas_cotizacion();
            Activa_cajas_informacion_cotizaciones();
            Desactiva_combobox_codigo_cotizaciones();
            Asigna_datos_en_cajas_a_variable();
            Aparce_boton_guardar_base_datos();
            Desaparece_textbox_nombre_cliente();
            Aparece_combo_nombre_cliente();
            Activa_combo_nombre_cliente();
            Obtener_clientes_disponibles();
            Rellena_combo_clientes();

            Desaparece_textbox_atencion();
            Aparecer_combo_atencion();
            Activa_combo_atencion();
            Desaparece_textbox_atencio_copia();
            Aparece_combo_copia_atencio();
            Activa_Combo_copia_atencio();
            Obtener_contactos_cliente_disponibles_modificar();
            Rellena_combo_contactos_clientes();

        }

        private void Rellena_cajas_informacion_de_cotizacion_modificar()
        {
            cotizacion_visualizar = cotizaciones_disponibles.Find(cotizaciones => cotizaciones.Codigo.Contains(comboBoxCodigoCotizaciones.SelectedItem.ToString()));

            comboBoxAtencion.Text = cotizacion_visualizar.Atencion;
            comboBoxAtencionCopia.Text = cotizacion_visualizar.Atencion_copia;
            comboBoxNombreCliente.Text = cotizacion_visualizar.Nombre;
            dateTimePickerFechaActual.Text = cotizacion_visualizar.Fecha_cotizacion;
            dateTimePickerFechaEntrega.Text = cotizacion_visualizar.Fecha_entrega;
            textBoxAtencion.Text = cotizacion_visualizar.Atencion;
            textBoxAtencionCopia.Text = cotizacion_visualizar.Atencion_copia;
            textBoxOrdenTrabajo.Text = cotizacion_visualizar.Orden_compra;
            textBoxProyecto.Text = cotizacion_visualizar.Proyecto;
        }

        private void Aparce_boton_guardar_base_datos()
        {
            buttonGuardarBasedeDatos.Visible = true;
        }

        private void Asigna_datos_en_cajas_a_variable()
        {

        }

        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos_modificar_clientes()
        {
            timerModificarClientes.Enabled = true;
        }

        private void Desactiva_combobox_codigo_cotizaciones()
        {
            comboBoxCodigoCotizaciones.Enabled = false;
        }

        private void buttonAgregarCotizacion_Click(object sender, EventArgs e)
        {
            Agrega_cotizacion();
        }

        private void Agrega_contactos_cliente()
        {
            throw new NotImplementedException();
        }

        private void Agrega_cotizacion()
        {
            Asigna_codigo_cliente_foilio_disponible();
            Asigna_nuevo_folio_cotizaciones();
            Desactiva_botones_operacion();
            Activa_cajas_informacion_cotizaciones();
            Acepta_datagridview_agregar_renglones();
            Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_cotizacion();
            Aparece_boton_cancelar_operacio();
            Activa_datagridview_contactos_clientes();
            Desactiva_combobox_codigo_cotizaciones();
            Desaparece_textbox_nombre_cliente();
            Aparece_combo_nombre_cliente();
            Activa_combo_nombre_cliente();
            Obtener_clientes_disponibles();
            Rellena_combo_clientes();
            Operacio_cotizaciones = "Agregar";
        }

        private void Obtener_contactos_cliente_disponibles()
        {
            Cliente_seleccionado = clientes_disponibles.Find(clientes => clientes.Nombre.Contains(comboBoxNombreCliente.SelectedItem.ToString()));
            Obtener_datos_contactos_clientes_disponibles_base_datos(Cliente_seleccionado.Codigo);
        }

        private void Obtener_datos_contactos_clientes_disponibles_base_datos(string codigo_cliente)
        {
            contactos_cliente_disponibles = clase_contactos_cliente.Adquiere_contactos_cliente_disponibles_en_base_datos(codigo_cliente);
        }

        private void Aparecer_combo_atencion()
        {
            comboBoxAtencion.Visible = true;
        }

        private void Activa_combo_atencion()
        {
            comboBoxAtencion.Enabled = true;
        }

        private void Desaparece_textbox_atencion()
        {
            textBoxAtencion.Visible = false;
        }

        private void Asigna_codigo_cliente_foilio_disponible()
        {
            folio_disponible = class_folio_disponible.Obtener_informacion_control_folio_base_datos();
            textBoxCodigoCotizaciones.Text = folio_disponible.Folio_cotizaciones;
        }

        private void Acepta_datagridview_agregar_renglones()
        {
            dataGridViewPartidasCotizacion.AllowUserToAddRows = true;
        }

        private void Activa_datagridview_contactos_clientes()
        {
            dataGridViewPartidasCotizacion.Enabled = true;
        }

        private void Desactiva_columna_codigo_partidas_cotizaciones()
        {
            dataGridViewPartidasCotizacion.Columns[0].Visible = false;
        }

        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_cotizacion()
        {
            timerAgregarCotizacion.Enabled = true;
        }

        private void Activa_cajas_informacion_cotizaciones()
        {
            textBoxNombreCliente.Enabled = true;
            dateTimePickerFechaActual.Enabled = true;
            dateTimePickerFechaEntrega.Enabled = true;
            textBoxAtencion.Enabled = true;
            textBoxAtencionCopia.Enabled = true;
        }

        private void Modifica_contactos_cliente()
        {
            throw new NotImplementedException();
        }



        private void timerAgregarCliente_Tick(object sender, EventArgs e)
        {
            if (comboBoxNombreCliente.Text != "" &&
            comboBoxAtencion.Text != "")
            {
                timerAgregarCotizacion.Enabled = false;
                buttonGuardarBasedeDatos.Visible = true;
            }
        }

        private void buttonGuardarBasedeDatos_Click(object sender, EventArgs e)
        {
            if (Operacio_cotizaciones == "Agregar")
                Secuencia_agregar_cotizacion();
            else if (Operacio_cotizaciones == "Modificar")
                Secuencia_modificar_cotizacion();
            else if (Operacio_cotizaciones == "Agregar Partidas")
                Secuencia_agregar_partidas();
            else if(Operacio_cotizaciones == "Copiar")
                Secuencia_copiar_cotizacion();
        }

        private void Secuencia_copiar_cotizacion()
        {
            if (verifica_datos_partidas())
            {
                if (Copia_datos_partidas_cotizacion())
                {
                    if (Copia_datos_cotizaciones())
                    {
                        Limpia_cajas_captura_despues_de_agregar_cotizacion();
                        Limpia_combo_codigo_cotizacion();
                        Limpia_combo_nombre_cliente();
                        Limpia_combo_atencion();
                        Limpia_combo_atencio_copia();
                        Desactiva_cajas_captura_despues_de_agregar_cotizacion();
                        Desaparece_boton_guardar_base_de_datos();
                        Desaparece_boton_cancelar();
                        Desaparece_combo_codigo_cotizacion();
                        Activa_botones_operacion();
                        limpia_partidas_cotizacion();
                        Desactiva_datagridview_partidas();
                        Desaparece_combo_cliente_nombre();
                        Desactiva_combo_cliente_nombre();
                        Desaparece_combo_atencion();
                        Desactiva_combo_atencion();
                        Desaparece_combo_copia_atencion();
                        Desactiva_combo_copia_atencion();
                        Aparece_textbox_nombre_cliente();
                        Aparece_textbox_nombre_cliente();
                        Aparece_textbox_atencion();
                        Aparece_textbox_atencion_copia();
                        Elimina_informacion_cotizaciones_disponibles();
                    }
                }
            }
        }

        private bool Copia_datos_cotizaciones()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_ingenieria());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_copiar_en_base_de_datos(), connection);
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

        private string Configura_cadena_comando_copiar_en_base_de_datos()
        {
            return "INSERT INTO cotizaciones(codigo_cotizacion, cliente_nombre,fecha_cotizacion," +
                   "fecha_entrega,atencion_cotizacion,atencion_copia) " +
                   "VALUES('" + comboBoxCodigoCotizaciones.Text + "','" + textBoxNombreCliente.Text + "'," +
                   "'" + dateTimePickerFechaActual.Text + "','" + dateTimePickerFechaEntrega.Text + "'," +
                   "'" + textBoxAtencion.Text + "','" + textBoxAtencionCopia.Text + "'" + ");";
        }

        private bool Copia_datos_partidas_cotizacion()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_ingenieria());
            try
            {
                connection.Open();
                for (int partidas = 0; partidas < dataGridViewPartidasCotizacion.Rows.Count; partidas++)
                {
                    for (int campo = 1; campo < dataGridViewPartidasCotizacion.Rows[partidas].Cells.Count; campo++)
                    {
                        if (dataGridViewPartidasCotizacion.Rows[partidas].Cells[campo].Value != null)
                        {
                            if (campo == (int)Campos_partidas.numero)
                                partida_cotizacion_agregar.Numero = dataGridViewPartidasCotizacion.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_partidas.cantidad)
                                partida_cotizacion_agregar.Cantidad = dataGridViewPartidasCotizacion.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_partidas.parte)
                                partida_cotizacion_agregar.Parte = dataGridViewPartidasCotizacion.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_partidas.descripcion)
                                partida_cotizacion_agregar.Descripcion = dataGridViewPartidasCotizacion.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_partidas.precio)
                                partida_cotizacion_agregar.Precio = dataGridViewPartidasCotizacion.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_partidas.importe)
                                partida_cotizacion_agregar.Importe = dataGridViewPartidasCotizacion.Rows[partidas].Cells[campo].Value.ToString();
                        }

                        else
                        {
                            MessageBox.Show("campo en blanco");
                            connection.Close();
                            return false;
                        }
                    }
                    Asigna_codigo_empleado_para_tipo_de_operacio();
                    MySqlCommand command = new MySqlCommand(Configura_cadena_comando_insertar_en_base_de_datos_partidas_cotizacion(partida_cotizacion_agregar), connection);
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

        private void Secuencia_agregar_partidas()
        {
            if (verifica_datos_partidas())
            {
                if (Guarda_datos_partidas_cotizacion())
                {
                    Desaparece_boton_guardar_base_de_datos();
                    Activa_botones_operacion_contactos();
                    limpia_partidas_cotizacion();
                    Obtener_datos_partidas_cotizacion_disponibles_base_datos(comboBoxCodigoCotizaciones.Text);
                    Rellena_cajas_informacion_de_partidas_cotizacion();
                    Elimina_informacion_cotizaciones_disponibles();
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
            buttonEliminarPartida.Enabled = true;
        }

        private void Activa_boton_agregar_contactos()
        {
            buttonAgregarPartida.Enabled=true;
        }

        private void Secuencia_modificar_cotizacion()
        {
            if (verifica_datos_partidas())
            {
                if (Modificar_datos_partidas_cotizacion())
                {
                    if (Modifica_datos_cotizacion())
                    {
                        Limpia_cajas_captura_despues_de_agregar_cotizacion();
                        Limpia_combo_codigo_cotizacion();
                        Limpia_combo_nombre_cliente();
                        Limpia_combo_atencion();
                        Limpia_combo_atencio_copia();
                        Desactiva_cajas_captura_despues_de_agregar_cotizacion();
                        Desaparece_boton_guardar_base_de_datos();
                        Desaparece_boton_cancelar();
                        Desaparece_combo_codigo_cotizacion();
                        Aparce_caja_codigo_cliente();
                        Activa_botones_operacion();
                        limpia_partidas_cotizacion();
                        Desactiva_datagridview_partidas();
                        Desaparece_combo_cliente_nombre();
                        Desactiva_combo_cliente_nombre();
                        Desaparece_combo_atencion();
                        Desactiva_combo_atencion();
                        Desaparece_combo_copia_atencion();
                        Desactiva_combo_copia_atencion();
                        Aparece_textbox_nombre_cliente();
                        Aparece_textbox_nombre_cliente();
                        Aparece_textbox_atencion();
                        Aparece_textbox_atencion_copia();
                        Elimina_informacion_cotizaciones_disponibles();
                    }
                }
            }
        }

        private void Aparce_caja_codigo_cliente()
        {
            textBoxCodigoCotizaciones.Visible = true;
        }

        private bool Modifica_datos_cotizacion()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_ingenieria());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_modificar_en_base_de_datos_cotizaciones(), connection);
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

        private string Configura_cadena_comando_modificar_en_base_de_datos_cotizaciones()
        {
            return "UPDATE cotizaciones set  cliente_nombre='" + comboBoxNombreCliente.Text +
               "',fecha_cotizacion='" + dateTimePickerFechaActual.Text +
               "',fecha_entrega='" + dateTimePickerFechaEntrega.Text +
               "',atencion_cotizacion='" + comboBoxAtencion.Text +
               "',atencion_copia='" + comboBoxAtencionCopia.Text +
               "' where codigo_cotizacion='" + comboBoxCodigoCotizaciones.Text + "';";
        }

        private bool Modificar_datos_partidas_cotizacion()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_ingenieria());
            try
            {
                connection.Open();
                for (int partidas = 0; partidas < dataGridViewPartidasCotizacion.Rows.Count; partidas++)
                {
                    for (int campo = 0; campo < dataGridViewPartidasCotizacion.Rows[partidas].Cells.Count; campo++)
                    {
                        if (dataGridViewPartidasCotizacion.Rows[partidas].Cells[campo].Value != null)
                        {
                            if (campo == (int)Campos_partidas.codigo)
                                Partidas_cotizacion_modificar.Codigo = Convert.ToInt32(dataGridViewPartidasCotizacion.Rows[partidas].Cells[campo].Value.ToString());
                            else if (campo == (int)Campos_partidas.numero)
                                Partidas_cotizacion_modificar.Numero = dataGridViewPartidasCotizacion.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_partidas.cantidad)
                                Partidas_cotizacion_modificar.Cantidad = dataGridViewPartidasCotizacion.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_partidas.parte)
                                Partidas_cotizacion_modificar.Parte = dataGridViewPartidasCotizacion.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_partidas.descripcion)
                                Partidas_cotizacion_modificar.Descripcion = dataGridViewPartidasCotizacion.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_partidas.precio)
                                Partidas_cotizacion_modificar.Precio = dataGridViewPartidasCotizacion.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_partidas.importe)
                                Partidas_cotizacion_modificar.Importe = dataGridViewPartidasCotizacion.Rows[partidas].Cells[campo].Value.ToString();
                        }

                        else
                        {
                            MessageBox.Show("campo en blanco");
                            connection.Close();
                            return false;
                        }
                    }
                    MySqlCommand command = new MySqlCommand(Configura_cadena_comando_en_base_de_datos_modificar_contacto_clientes(Partidas_cotizacion_modificar), connection);
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

        private string Configura_cadena_comando_en_base_de_datos_modificar_contacto_clientes(Partida_cotizacion partidas_cotizacion)
        {
            return "UPDATE partidas_cotizaciones set  numero_partida='" + partidas_cotizacion.Numero +
                "',cantidad_partida='" + partidas_cotizacion.Cantidad +
                "',parte_partida='" + partidas_cotizacion.Parte +
                "',descripcion_partida='" + partidas_cotizacion.Descripcion +
                "',precio_partida='" + partidas_cotizacion.Precio +
                "',importe_partida='" + partidas_cotizacion.Importe +
                "' where codigo_partida='" + partidas_cotizacion.Codigo + "';";
        }

        private void Secuencia_agregar_cotizacion()
        {
            if (verifica_datos_partidas())
            {
                if (Guarda_datos_partidas_cotizacion())
                {
                    if (Guarda_datos_cotizaciones())
                    {
                        Limpia_cajas_captura_despues_de_agregar_cotizacion();
                        Limpia_combo_codigo_cotizacion();
                        Limpia_combo_nombre_cliente();
                        Limpia_combo_atencion();
                        Limpia_combo_atencio_copia();
                        Desactiva_cajas_captura_despues_de_agregar_cotizacion();
                        Desaparece_boton_guardar_base_de_datos();
                        Desaparece_boton_cancelar();
                        Desaparece_combo_codigo_cotizacion();
                        Activa_botones_operacion();
                        limpia_partidas_cotizacion();
                        Desactiva_datagridview_partidas();
                        Desaparece_combo_cliente_nombre();
                        Desactiva_combo_cliente_nombre();
                        Desaparece_combo_atencion();
                        Desactiva_combo_atencion();
                        Desaparece_combo_copia_atencion();
                        Desactiva_combo_copia_atencion();
                        Aparece_textbox_nombre_cliente();
                        Aparece_textbox_nombre_cliente();
                        Aparece_textbox_atencion();
                        Aparece_textbox_atencion_copia();
                        Elimina_informacion_cotizaciones_disponibles();
                    }
                }
            }

        }

        private bool verifica_datos_partidas()
        {
            for (int partidas = 0; partidas < dataGridViewPartidasCotizacion.Rows.Count - 1; partidas++)
            {
                for (int campo = 1; campo < dataGridViewPartidasCotizacion.Rows[partidas].Cells.Count; campo++)
                {
                    if (dataGridViewPartidasCotizacion.Rows[partidas].Cells[campo].Value == null)
                    {
                        MessageBox.Show("campo en blanco");
                        return false;
                    }

                }

            }
            return true;

        }

        private void Aparece_textbox_atencion_copia()
        {
            textBoxAtencionCopia.Visible = true;
        }

        private void Aparece_textbox_atencion()
        {
            textBoxAtencion.Visible = true;
        }

        private void Aparece_textbox_nombre_cliente()
        {
            textBoxNombreCliente.Visible = true;
        }

        private void Desactiva_combo_copia_atencion()
        {
            comboBoxAtencionCopia.Enabled = false;
        }

        private void Desaparece_combo_copia_atencion()
        {
            comboBoxAtencionCopia.Visible = false;
        }

        private void Desactiva_combo_atencion()
        {
            comboBoxAtencion.Enabled = false;
        }

        private void Desaparece_combo_atencion()
        {
            comboBoxAtencion.Visible = false;
        }

        private void Desactiva_combo_cliente_nombre()
        {
            comboBoxNombreCliente.Enabled = false;
        }

        private void Desaparece_combo_cliente_nombre()
        {
            comboBoxNombreCliente.Visible = false;
        }

        private void Asigna_nuevo_folio_cotizaciones()
        {
            int numero_folio = Convert.ToInt32(folio_disponible.Folio_cotizaciones.Substring(2, folio_disponible.Folio_cotizaciones.Length - 2));
            numero_folio++;
            folio_disponible.Folio_cotizaciones = folio_disponible.Folio_cotizaciones.Substring(0, 2) +numero_folio.ToString("00000");
            string respuesta = class_folio_disponible.Actualiza_Control_folios_base_datos(folio_disponible);
            if (respuesta != "")
                MessageBox.Show(folio_disponible.error);
        }

        private void Desactiva_datagridview_partidas()
        {
            dataGridViewPartidasCotizacion.Enabled = false;
        }

        private void Elimina_informacion_cotizaciones_disponibles()
        {
            cotizaciones_disponibles = null;
            partidas_cotizacion_disponibles = null;
            clientes_disponibles = null;
            contactos_cliente_disponibles = null;
            GC.Collect();
        }

        private void Activa_botones_operacion()
        {
            Activa_boton_agregar_ccotizacion();
            Activa_boton_modificar_cotizacion();
            Activa_boton_eliminar_cotizacion();
            Activa_boton_visualizar_cotizacion();
            Activa_boton_copiar_cotizacion();
            Activa_boton_contactos();
        }

        private void Activa_boton_copiar_cotizacion()
        {
            buttonCopiarCotizacion.Enabled = true;
        }

        private void Activa_boton_contactos()
        {
            buttonPartidas.Enabled = true;
        }

        private void Activa_boton_visualizar_cotizacion()
        {
            buttonBuscarCotizacion.Enabled = true;
        }

        private void Activa_boton_eliminar_cotizacion()
        {
            buttonEliminarCotizacion.Enabled = true;
        }

        private void Activa_boton_modificar_cotizacion()
        {
            buttonModificarCotizacion.Enabled = true;
        }

        private void Activa_boton_agregar_ccotizacion()
        {
            buttonAgregarCotizacion.Enabled = true;
        }

        private void Desaparece_combo_codigo_cotizacion()
        {
            comboBoxCodigoCotizaciones.Visible = false;
        }

        private void Desaparece_boton_cancelar()
        {
            buttonCancelar.Visible = false;
        }

        private void Desaparece_boton_guardar_base_de_datos()
        {
            buttonGuardarBasedeDatos.Visible = false;
        }

        private void Desactiva_cajas_captura_despues_de_agregar_cotizacion()
        {
            textBoxNombreCliente.Enabled = false;
            dateTimePickerFechaActual.Enabled = false;
            dateTimePickerFechaEntrega.Enabled = false;
            textBoxAtencion.Enabled = false;
            textBoxAtencionCopia.Enabled = false;
        }

        private void Limpia_combo_codigo_cotizacion()
        {
            comboBoxCodigoCotizaciones.Items.Clear();
            comboBoxCodigoCotizaciones.Text = "";
        }

        private void Limpia_cajas_captura_despues_de_agregar_cotizacion()
        {
            textBoxNombreCliente.Text = "";
            textBoxCodigoCotizaciones.Text = "";
            dateTimePickerFechaActual.Text = DateTime.Today.ToString();
            dateTimePickerFechaEntrega.Text = DateTime.Today.ToString();
            textBoxAtencion.Text = "";
            textBoxAtencionCopia.Text = "";
            textBoxOrdenTrabajo.Text = "";
            textBoxProyecto.Text = "";
        }

        private bool Guarda_datos_partidas_cotizacion()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_ingenieria());
            try
            {
                connection.Open();
                for (int partidas = 0; partidas < dataGridViewPartidasCotizacion.Rows.Count - 1; partidas++)
                {
                    for (int campo = 1; campo < dataGridViewPartidasCotizacion.Rows[partidas].Cells.Count; campo++)
                    {
                        if (dataGridViewPartidasCotizacion.Rows[partidas].Cells[campo].Value != null)
                        {
                            if (campo == (int)Campos_partidas.numero)
                                partida_cotizacion_agregar.Numero = dataGridViewPartidasCotizacion.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_partidas.cantidad)
                                partida_cotizacion_agregar.Cantidad = dataGridViewPartidasCotizacion.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_partidas.parte)
                                partida_cotizacion_agregar.Parte = dataGridViewPartidasCotizacion.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_partidas.descripcion)
                                partida_cotizacion_agregar.Descripcion = dataGridViewPartidasCotizacion.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_partidas.precio)
                                partida_cotizacion_agregar.Precio = dataGridViewPartidasCotizacion.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_partidas.importe)
                                partida_cotizacion_agregar.Importe = dataGridViewPartidasCotizacion.Rows[partidas].Cells[campo].Value.ToString();
                        }

                        else
                        {
                            MessageBox.Show("campo en blanco");
                            connection.Close();
                            return false;
                        }
                    }
                    Asigna_codigo_empleado_para_tipo_de_operacio();
                    MySqlCommand command = new MySqlCommand(Configura_cadena_comando_insertar_en_base_de_datos_partidas_cotizacion(partida_cotizacion_agregar), connection);
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
            if (Operacio_cotizaciones == "Agregar")
                partida_cotizacion_agregar.Codigo_cotizacion = textBoxCodigoCotizaciones.Text;
            else if (Operacio_cotizaciones == "Agregar Partidas" || Operacio_cotizaciones == "Copiar")
                partida_cotizacion_agregar.Codigo_cotizacion = comboBoxCodigoCotizaciones.Text;
        }

        private string Configura_cadena_comando_insertar_en_base_de_datos_partidas_cotizacion(Partida_cotizacion partida_cotizacion)
        {
            return "INSERT INTO partidas_cotizaciones(numero_partida, cantidad_partida,parte_partida," +
                "descripcion_partida,precio_partida,importe_partida,codigo_cotizacion) " +
                "VALUES('" + partida_cotizacion.Numero + "','" + partida_cotizacion.Cantidad + "'," +
                "'" + partida_cotizacion.Parte + "','" + partida_cotizacion.Descripcion + "'" +
                ",'" + partida_cotizacion.Precio + "','" + partida_cotizacion.Importe + "'," +
                "'" + partida_cotizacion.Codigo_cotizacion + "');";
        }

        private bool Guarda_datos_cotizaciones()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_ingenieria());
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
                return "INSERT INTO cotizaciones(codigo_cotizacion, cliente_nombre,fecha_cotizacion," +
                    "fecha_entrega,atencion_cotizacion,atencion_copia) " +
                    "VALUES('" + textBoxCodigoCotizaciones.Text + "','" + comboBoxNombreCliente.Text + "'," +
                    "'" + dateTimePickerFechaActual.Text + "','" + dateTimePickerFechaEntrega.Text + "'," +
                    "'" + comboBoxAtencion.Text + "','" + comboBoxAtencionCopia.Text + "'" + ");";
        }

        private string Configura_cadena_conexion_MySQL_ingenieria()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=ingenieria;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }


        private void buttonModificarCliente_Click(object sender, EventArgs e)
        {
            Modifica_clientes();
        }

        private void Modifica_clientes()
        {
            Desactiva_botones_operacion();
            Limpia_combo_nombre_cliente();
            Desaparece_caja_captura_codigo_cotizacion();
            Aparece_combo_codigo_cotizacion();
            Obtener_datos_cotizaciones_disponibles_base_datos();
            Rellena_combo_codigo_cotizacion();
            Aparece_boton_cancelar_operacio();
            No_aceptar_agregar_contactos_cotizacion();
            Activa_dataview_partidas_cotizacion();
            Activa_combo_codigo_cotizacion();

            Operacio_cotizaciones = "Modificar";
        }

        private void Obtener_contactos_cliente_disponibles_modificar()
        {
            Cliente_seleccionado = clientes_disponibles.Find(clientes => clientes.Nombre.Contains(comboBoxNombreCliente.Text));
            Obtener_datos_contactos_clientes_disponibles_base_datos(Cliente_seleccionado.Codigo);
        }

        private void buttonEliminarCliente_Click(object sender, EventArgs e)
        {
            Desactiva_botones_operacion();
            Desaparece_caja_captura_codigo_cotizacion();
            Aparece_combo_codigo_cotizacion();
            Obtener_datos_cotizaciones_disponibles_base_datos();
            Rellena_combo_codigo_cotizacion();
            Aparece_boton_cancelar_operacio();
            Operacio_cotizaciones = "Eliminar";
        }

        private bool Elimina_informacion_clienete_en_base_de_datos()
        {
            return (Elimina_datos_cotizacion() && Elinina_partidas_cotizacion());
        }

        private bool Elinina_partidas_cotizacion()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_ingenieria());
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
            return "DELETE from partidas_cotizaciones where codigo_cotizacion='" +
               comboBoxCodigoCotizaciones.Text + "';";
        }


        private bool Elimina_datos_cotizacion()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_ingenieria());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_eliminar_en_base_de_datos_cotizacion(), connection);
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
        private string Configura_cadena_comando_eliminar_en_base_de_datos_cotizacion()
        {
            return "DELETE from cotizaciones where codigo_cotizacion='" +
               comboBoxCodigoCotizaciones.Text + "';";
        }

        private void timerModificarClientes_Tick(object sender, EventArgs e)
        {
            //if (cotizacion_modificaciones.Nombre != textBoxNombreCliente.Text ||
            //cotizacion_modificaciones.Direccion != textBoxAtencion.Text ||
            //cotizacion_modificaciones.Rfc != textBoxOrdenTrabajo.Text ||
            //cotizacion_modificaciones.Telefono != textBoxProyecto.Text)
            //{
            //    timerModificarClientes.Enabled = false;
            //    buttonGuardarBasedeDatos.Visible = true;
            //}
        }

        private void buttonAgregaContactosCliente_Click(object sender, EventArgs e)
        {
            Agrega_contactos_clientes();
        }

        private void Agrega_contactos_clientes()
        {
            Desactiva_botones_operacion_contactos();
            limpia_partidas_cotizacion();
            Acepta_datagridview_agregar_renglones();
            Aparce_boton_guardar_base_datos();
            Operacio_cotizaciones = "Agregar Partidas";

        }

        private void Desactiva_botones_operacion_contactos()
        {
            Desactiva_boton_agregar_contactos();
            Desactiva_boton_eliminar_contactos();
        }

        private void Desactiva_boton_eliminar_contactos()
        {
            buttonEliminarPartida.Enabled = false;
        }

        private void Desactiva_boton_agregar_contactos()
        {
            buttonAgregarPartida.Enabled = false;
        }

        private void buttonBorrarBasedeDatos_Click(object sender, EventArgs e)
        {

            if (Operacio_cotizaciones == "Eliminar partida")
                Elimina_partida_cotizacion();
            else if (Operacio_cotizaciones == "Eliminar")
                Elimina_cotizacion();
        }

        private void Elimina_partida_cotizacion()
        {
            if (MessageBox.Show("Esta Seguro de Eiliminar el contacto seleccionado?",
                "Eliminar Contacto Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Elimina_informacion_partida_cotizacion_en_base_de_datos())
                {
                    Desaparece_boton_eliminar_base_de_datos();
                    Activa_botones_operacion_contactos();
                    limpia_partidas_cotizacion();
                    Obtener_datos_partidas_cotizacion_disponibles_base_datos(comboBoxCodigoCotizaciones.Text);
                    Rellena_cajas_informacion_de_partidas_cotizacion();
                    limpia_texto_eliminar_contacto();
                }
            }
            
        }

        private void limpia_texto_eliminar_contacto()
        {
            RenglonParaEliminar = "";
        }

        private bool Elimina_informacion_partida_cotizacion_en_base_de_datos()
        {
            return Elimina_partida_cotizacion_seleccionada();
        }

        private bool Elimina_partida_cotizacion_seleccionada()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_ingenieria());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_eliminar_en_base_de_datos_partida_cotizacion(), connection);
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


        

        private string Configura_cadena_comando_eliminar_en_base_de_datos_partida_cotizacion()
        {
            return "DELETE from partidas_cotizaciones where codigo_partida='" +
                RenglonParaEliminar + "';";
        }

        private void Elimina_cotizacion()
        {
            if (MessageBox.Show("Esta Seguro de Eiliminar Esta Cotizacion Incluyendo Todos sus partidas?",
                "Eliminar Cotizacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Elimina_informacion_clienete_en_base_de_datos())
                {
                    Limpia_cajas_captura_despues_de_agregar_cotizacion();
                    Limpia_combo_codigo_cotizacion();
                    Desactiva_cajas_captura_despues_de_agregar_cotizacion();
                    Desaparece_boton_eliminar_base_de_datos();
                    Desaparece_boton_cancelar();
                    Desaparece_combo_codigo_cotizacion();
                    Activa_botones_operacion();
                    limpia_partidas_cotizacion();
                    Desactiva_datagridview_partidas();
                    Elimina_informacion_cotizaciones_disponibles();
                    Aparce_caja_codigo_cliente();
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
            No_aceptar_agregar_contactos_cotizacion();
            Operacio_cotizaciones = "Eliminar partida";
        }

        private void buttonAgregarContacto_Click(object sender, EventArgs e)
        {
            Agrega_contactos_clientes();
        }

        private void buttonContactos_Click(object sender, EventArgs e)
        {
            Prtidas_operaciones();
        }

        private void Prtidas_operaciones()
        {
            Desactiva_botones_operacion();
            Desaparece_caja_captura_codigo_cotizacion();
            Aparece_combo_codigo_cotizacion();
            Activa_combo_codigo_cotizacion();
            Obtener_datos_cotizaciones_disponibles_base_datos();
            Rellena_combo_codigo_cotizacion();
            Aparece_boton_cancelar_operacio();
            No_aceptar_agregar_contactos_cotizacion();
            Activa_dataview_partidas_cotizacion();
            Operacio_cotizaciones = "Operaciones Patidas";
        }

        private void Aparece_boton_eliminar_partidas()
        {
            buttonEliminarPartida.Visible = true;
        }

        private void Aparece_boton_agregar_partidas()
        {
            buttonAgregarPartida.Visible = true;
        }


        private void dataGridViewContactosClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Operacio_cotizaciones == "Eliminar partida")
            {
                Aparece_boton_eliminar_datos_en_base_de_datos();
                RenglonParaEliminar=dataGridViewPartidasCotizacion.Rows[e.RowIndex].Cells["Codigo_partida"].Value.ToString();
            }
           
        }

        private void dataGridViewPartidasCotizacion_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Operacio_cotizaciones == "Agregar" || Operacio_cotizaciones == "Modificar" ||
                Operacio_cotizaciones == "Agregar Partidas" || Operacio_cotizaciones == "Copiar")/*verifica si esta agregando Partidas*/
            {
                if (dataGridViewPartidasCotizacion.CurrentCell.ColumnIndex == (int)Campos_partidas.precio) /*verifica si esta modificando el precio*/
                {
                    try
                    {
                        /* Calcula el importe Importe = precio + IVA*/
                        datos_generales = Class_Datos_Generales.Obtener_informacion_datos_generales_base_datos();
                        dataGridViewPartidasCotizacion[e.ColumnIndex + 1, e.RowIndex].Value =
                            (Convert.ToSingle(dataGridViewPartidasCotizacion[e.ColumnIndex, e.RowIndex].Value.ToString()) *
                            ((Convert.ToSingle(datos_generales.Iva) / 100.0) + 1)).ToString("###.##");
                    }
                    catch
                    {
                        /* en caso de error limpia la caja de precio*/
                        dataGridViewPartidasCotizacion[e.ColumnIndex, e.RowIndex].Value = "";
                        dataGridViewPartidasCotizacion[(int)Campos_partidas.importe, e.RowIndex].Value = "";
                    }

                }
              
            }
        }

        private void comboBoxNombreCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Desaparece_textbox_atencion();
            Limpia_combo_atencion();
            Limpia_combo_atencio_copia();
            Aparecer_combo_atencion();
            Activa_combo_atencion();
            Desaparece_textbox_atencio_copia();
            Aparece_combo_copia_atencio();
            Activa_Combo_copia_atencio();
            Obtener_contactos_cliente_disponibles();
            Rellena_combo_contactos_clientes();
        }

        private void Activa_Combo_copia_atencio()
        {
            comboBoxAtencionCopia.Enabled = true;
        }

        private void Aparece_combo_copia_atencio()
        {
            comboBoxAtencionCopia.Visible = true;
        }

        private void Desaparece_textbox_atencio_copia()
        {
            textBoxAtencionCopia.Visible = false;
        }

        private void Rellena_combo_contactos_clientes()
        {
            foreach (Contacto_cliente contacto in contactos_cliente_disponibles)
            {
                if (contacto.error == "")
                {
                    comboBoxAtencion.Items.Add(contacto.Nombre);
                    comboBoxAtencionCopia.Items.Add(contacto.Nombre);
                }
                else
                {
                    MessageBox.Show(contacto.error);
                    break;
                }

            }
        }

        private void buttonCopiarCotizacion_Click(object sender, EventArgs e)
        {
            Copiar_cotizacion();
        }

        private void Copiar_cotizacion()
        {
            Desactiva_botones_operacion();
            Desaparece_caja_captura_codigo_cotizacion();
            Aparece_combo_codigo_cotizacion();
            Activa_combo_codigo_cotizacion();
            Obtener_datos_cotizaciones_disponibles_base_datos();
            Rellena_combo_codigo_cotizacion();
            Aparece_boton_cancelar_operacio();
            No_aceptar_agregar_contactos_cotizacion();
            Activa_dataview_partidas_cotizacion();
            Operacio_cotizaciones = "Copiar";
        }

        private void buttonWordPrevio_Click(object sender, EventArgs e)
        {
            if (Inicia_variables_word())
            {
                Desactiva_boton_cotizaciones_previo();
                Asigna_nombre_archivo_para_analizar();
                Elimina_archivo();
                if (radioButtonPrevioEspanol.Checked)
                {
                    Copiar_template_a_cotizacion_espanol();
                }
                else if (radioButtonPrevioIngles.Checked)
                {
                    Copiar_template_a_cotizacion_ingles();
                }
                Visible_instancia_word();
                Abrir_documento_word();
                Rellenar_campos_cotizacion();
            }
            
        }

        private bool Inicia_variables_word()
        {
            try
            {
                application = new word.Application();
                Documento = new word.Document();
                return true;

            }
            catch
            {
                MessageBox.Show("NO Word Instalado", "Inicio EWord", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Abrir_documento_word()
        {
            Documento = application.Documents.Open(nombre_archivo_word);
            Documento.Activate();
        }

        private void Asigna_nombre_archivo_para_analizar()
        {
            nombre_archivo_word = @appPath + "\\" + comboBoxCodigoCotizaciones.Text + ".docx";
        }

        private void Desactiva_boton_cotizaciones_previo()
        {
            buttonWordPrevio.Enabled = false;
        }

        private void Visible_instancia_word()
        {
            application.Visible = true;
           
        }

        private void Copiar_template_a_cotizacion_espanol()
        {
            try
            {
                File.Copy(@appPath + "\\Quote_Coset_Template_Espanol.docx", @appPath + "\\" + comboBoxCodigoCotizaciones.Text + ".docx", false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Elimina_archivo()
        {
            try
            {
                File.Delete(nombre_archivo_word);
            }
            catch
            {
               
            }
        }

        private void Rellenar_campos_cotizacion()
        {
           Rellena_datos_cliente();
           Rellena_partidas_cotizacion();
           Rellena_empleado_informacion();
           Limpia_partidas_sin_informacion();
           Guardar_archivo_word();
        }

        private void Rellena_empleado_informacion()
        {
            Remplaza_texto_en_Documento("<empleado>",
                    Forma_Inicio_Usuario.Usuario_global.nombre_empleado);
            Remplaza_texto_en_Documento("<correo_electronico>",
                    Forma_Inicio_Usuario.Usuario_global.Correo_electronico);
        }

        private void Guardar_archivo_word()
        {
            Documento.Save();
        }

        private void Limpia_partidas_sin_informacion()
        {
            for (int partida = dataGridViewPartidasCotizacion.Rows.Count +1; partida <= 5; partida++)
            {
                Remplaza_texto_en_Documento("<item" + partida + ">",
                    "");
                Remplaza_texto_en_Documento("<description" + partida + ">",
                    "");
                Remplaza_texto_en_Documento("<price" + partida + ">",
                 "");
                if(radioButtonPrevioEspanol.Checked)
                    Remplaza_texto_en_Documento("<PESOS" + partida + ">",
                    "");
                else if(radioButtonPrevioIngles.Checked)
                    Remplaza_texto_en_Documento("<DLLS" + partida + ">",
                    "");

            }
        }

        private void Rellena_partidas_cotizacion()
        {
            Single importe = 0;
            if (dataGridViewPartidasCotizacion.Rows.Count <= 5)
            {
                for (int partida = 1; partida <= dataGridViewPartidasCotizacion.Rows.Count; partida++)
                {
                    Remplaza_texto_en_Documento("<item" + partida + ">",
                        dataGridViewPartidasCotizacion[(int)Campos_partidas.cantidad, partida - 1].Value.ToString());
                    Remplaza_texto_en_Documento("<description" + partida + ">",
                        dataGridViewPartidasCotizacion[(int)Campos_partidas.descripcion, partida - 1].Value.ToString());
                    importe = Convert.ToSingle(dataGridViewPartidasCotizacion[(int)Campos_partidas.precio, partida - 1].Value.ToString());
                    Remplaza_texto_en_Documento("<price" + partida + ">",
                     importe.ToString("C"));
                    if (radioButtonPrevioEspanol.Checked)
                        Remplaza_texto_en_Documento("<PESOS" + partida + ">",
                            "PESOS.");
                    else if (radioButtonPrevioIngles.Checked)
                        Remplaza_texto_en_Documento("<DLLS" + partida + ">",
                            "DLLS.");
                }
            }
            else
            {
                MessageBox.Show("Esta Applicacion solo Puede desplegar Hasta 5 Partidas","Previo Cotizaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Rellena_datos_cliente()
        {
            
            Remplaza_texto_en_Documento("<cliente>", textBoxNombreCliente.Text);
            Remplaza_texto_en_Documento("<quote_code>",comboBoxCodigoCotizaciones.Text);
            Remplaza_texto_en_Documento("<Attention>", textBoxAtencion.Text);
            Remplaza_texto_en_Documento("<Attention Copy>", textBoxAtencionCopia.Text);
            Remplaza_texto_en_Documento("<Actual date>", dateTimePickerFechaActual.Text);
           
            Remplaza_texto_en_Documento("<Delivery Date>", Calcula_tiempo_de_entrega());
        }

        private string Calcula_tiempo_de_entrega()
        {
            int semanas = 0;
            DateTime fecha_inicial = Convert.ToDateTime(dateTimePickerFechaActual.Text);
            DateTime fecha_final = Convert.ToDateTime(dateTimePickerFechaEntrega.Text);
            TimeSpan dias_entrega = fecha_final - fecha_inicial;
            semanas = (int)(dias_entrega.TotalDays / 7);


            if (semanas < 1)
            {
                if (radioButtonPrevioEspanol.Checked)
                {
                    if (dias_entrega.TotalDays > 1)
                        return dias_entrega.TotalDays.ToString() + " DIAS";
                    else
                        return dias_entrega.TotalDays.ToString() + " DIA";
                }
                else if (radioButtonPrevioIngles.Checked)
                {
                    if (dias_entrega.TotalDays > 1)
                        return dias_entrega.TotalDays.ToString() + " DAYS";
                    else
                        return dias_entrega.TotalDays.ToString() + " DAY";
                }
                else
                    return "";
            }
            else if (semanas >= 1)
            {
                if (radioButtonPrevioEspanol.Checked)
                {
                    if (semanas > 1)
                        return semanas.ToString() + " SEMANAS";
                    else
                        return semanas.ToString() + " SEMANA";
                }
                else if (radioButtonPrevioIngles.Checked)
                {
                    if (semanas > 1)
                        return semanas.ToString() + " WEEKS";
                    else
                        return semanas.ToString() + " WEEK";
                }
                    return "";
            }
            else
                return "";
        }

        private bool menor_de_una_semana(int semanas)
        {
            if (semanas < 1)
                return true;
            else
                return false;
        }

        private void Remplaza_texto_en_Documento(string original, string cambio)
        {
            word.Selection seleccion = application.Selection;
            seleccion.Find.Text = original;
            seleccion.Find.Replacement.Text = cambio;
            seleccion.Find.Wrap = WdFindWrap.wdFindContinue;
            seleccion.Find.Forward = true;
            seleccion.Find.Format = false;
            seleccion.Find.MatchCase = false;
            seleccion.Find.MatchWholeWord = false;
            seleccion.Find.Execute(Replace: WdReplace.wdReplaceAll);
        }

        private void Copiar_template_a_cotizacion_ingles()
        {
            try
            {
                File.Copy(@appPath + "\\Quote_Coset_Template_Ingles.docx", @appPath + "\\" + comboBoxCodigoCotizaciones.Text + ".docx", false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonPrevioEspanol_CheckedChanged(object sender, EventArgs e)
        {
            buttonWordPrevio.Enabled = true;
        }

        private void radioButtonPrevioIngles_CheckedChanged(object sender, EventArgs e)
        {
            buttonWordPrevio.Enabled = true;
        }

        private void dataGridViewPartidasCotizacion_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int numero_partida = 1;
            for(int renglones = 0; renglones<dataGridViewPartidasCotizacion.RowCount-1; renglones++)
            {
                dataGridViewPartidasCotizacion["Numero_partida", renglones].Value = numero_partida.ToString();
                numero_partida++;
            }
        }

        private void dataGridViewPartidasCotizacion_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            int numero_partida = 1;
            for (int renglones = 0; renglones < dataGridViewPartidasCotizacion.RowCount - 1; renglones++)
            {
                dataGridViewPartidasCotizacion["Numero_partida", renglones].Value = numero_partida.ToString();
                numero_partida++;
            }
        }
    }
}
