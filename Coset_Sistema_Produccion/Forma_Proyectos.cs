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
    public partial class Forma_Proyectos : Form
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
        public List<Usuario> ingenieros_disponibles = new List<Usuario>();
        public Class_Usuarios clase_usuarios = new Class_Usuarios();
        public Cliente Cliente_seleccionado = new Cliente();
        public Class_Dibujos_Proyecto clase_dibujos_proyecto = new Class_Dibujos_Proyecto();
        public Dibujos_proyecto dibujo_agregar = new Dibujos_proyecto();
        public List<Dibujos_proyecto> dibujos_proyecto_disponibles = new List<Dibujos_proyecto>();
        string RenglonParaEliminar = "";
        string appPath = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
        public CultureInfo cultureInfo = new CultureInfo("en-US");
        public string nombre_archivo_word = "";
        public word.Application application = null;
        public word.Document Documento = null;
        public List<Proyecto> proyectos_disponibles = new List<Proyecto>();
        public Proyecto proyecto_seleccion = new Proyecto();
        public Class_Proyectos Class_Proyectos = new Class_Proyectos();
        public Proyecto proyecto_visualizar = new Proyecto();
        public Dibujos_proyecto dibujos_proyecto_modificar = new Dibujos_proyecto();
        public Class_Procesos Class_Procesos = new Class_Procesos();
        public List<Proceso_electricos> procesos_disponibles = new List<Proceso_electricos>();
        public enum Campos_dibujos
        {
            codigo, cantidad, numero, descripcion, tipo_proceso,
            proceso, actividad_proceso_electrico,tiempo_estimado
        };

        public string Operacio_proyectos = "";

        public object Combo_tipo_proceso_index_select { get; private set; }

        public Forma_Proyectos()
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
            comboBoxCodigoProyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBoxCodigoProyecto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCodigoProyecto.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxCodigoCotizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBoxCodigoCotizacion.AutoCompleteMode = AutoCompleteMode.None;
            comboBoxCodigoCotizacion.AutoCompleteSource = AutoCompleteSource.ListItems;
          

            comboBoxNombreCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBoxNombreCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxNombreCliente.AutoCompleteSource = AutoCompleteSource.ListItems;


            comboBoxIngenieroCoset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBoxIngenieroCoset.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxIngenieroCoset.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxIngenieroCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBoxIngenieroCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxIngenieroCliente.AutoCompleteSource = AutoCompleteSource.ListItems;


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
            Visualiza_proyecto();
        }

        private void Visualiza_proyecto()
        {
            Operacio_proyectos = "Visualizar";
            Desactiva_botones_operacion();
            Desaparece_caja_captura_codigo_proyecto();
            Aparece_combo_codigo_proyecto();
            Aparece_combo_nombre_cliente();
            Activa_combo_nombre_cliente();
            Activa_combo_codigo_proyecto();
            Aparece_combo_nombre_proyecto();
            Activa_combo_nombre_proyecto();
            Limpia_combo_proyecto();
            Limpia_combo_nombre_proyecto();
            Limpia_combo_nombre_cliente();
            Obtener_datos_proyectos_disponibles_base_datos();
            Rellena_combo_codigo_proyecto();
            Aparece_boton_cancelar_operacio();
            No_aceptar_agregar_dibujos_proyecto();
            Activa_dataview_dibujos_proyecto();
           
        }

        private void Limpia_combo_nombre_proyecto()
        {
            comboBoxNombreProyecto.Items.Clear();
            comboBoxNombreProyecto.Text = "";
        }

        private void Activa_combo_nombre_proyecto()
        {
            comboBoxNombreProyecto.Enabled = true;

        }

        private void Desactiva_combo_nombre_proyecto()
        {
            comboBoxNombreProyecto.Enabled = false;

        }

        private void Aparece_combo_nombre_proyecto()
        {
            comboBoxNombreProyecto.Visible = true;
        }
        private void Desaparece_combo_nombre_proyecto()
        {
            comboBoxNombreProyecto.Visible = false;
        }

        private void Activa_combo_codigo_proyecto()
        {
            comboBoxCodigoProyecto.Enabled = true;
        }

        private void Obtener_datos_proyectos_disponibles_base_datos()
        {
            proyectos_disponibles = Class_Proyectos.Adquiere_proyectos_disponibles_en_base_datos();
        }

        private void Aparece_combo_codigo_proyecto()
        {
            comboBoxCodigoProyecto.Visible = true;
        }

        private void Activa_combo_codigo_cotizacion()
        {
            comboBoxCodigoCotizacion.Enabled = true;
        }

        private void Activa_dataview_dibujos_proyecto()
        {
            dataGridViewDibujosProyecto.Enabled = true;
        }

        private void limpia_dibujos_proyecto()
        {
            dataGridViewDibujosProyecto.Rows.Clear();
        }

        private void No_aceptar_agregar_dibujos_proyecto()
        {
            dataGridViewDibujosProyecto.AllowUserToAddRows = false;
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
                    comboBoxCodigoCotizacion.Items.Add(cotizacion.Codigo);
                else
                {
                    MessageBox.Show(cotizacion.error);
                    break;
                }
            }
        }

        private void Rellena_combo_codigo_proyecto()
        {
            if (Operacio_proyectos == "Visualizar")
            {
                foreach (Proyecto proyecto in proyectos_disponibles)
                {
                    if (proyecto.error == "")
                    {
                        comboBoxCodigoProyecto.Items.Add(proyecto.Codigo);
                        comboBoxNombreProyecto.Items.Add(proyecto.Nombre);
                        if (!comboBoxNombreCliente.Items.Contains(proyecto.Nombre_cliente))
                        {
                            comboBoxNombreCliente.Items.Add(proyecto.Nombre_cliente);
                        }

                    }
                    else
                    {
                        MessageBox.Show(proyecto.error);
                        break;
                    }
                }
            }
            else
            {
                foreach (Proyecto proyecto in proyectos_disponibles)
                {
                    if (proyecto.error == "")
                    {
                        comboBoxCodigoProyecto.Items.Add(proyecto.Codigo);
                    }
                    else
                    {
                        MessageBox.Show(proyecto.error);
                        break;
                    }
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
            comboBoxCodigoCotizacion.Visible = true;
        }

        private void Desaparece_caja_captura_codigo_proyecto()
        {
            textBoxCodigoProyecto.Visible = false;
        }

        private void Desactiva_botones_operacion()
        {
            Desactiva_boton_agregar_proyecto();
            Desactiva_boton_modificar_proyecto();
            Desactiva_boton_eliminar_proyecto();
            Desactiva_boton_visualizar_proyecto();
            Desactiva_boton_partidas();
        }

        private void Desactiva_boton_partidas()
        {
            buttonDibujos.Enabled = false;
        }

        private void Desactiva_boton_visualizar_proyecto()
        {
            buttonBuscarProyecto.Enabled = false;
        }

        private void Desactiva_boton_eliminar_proyecto()
        {
            buttonEliminarProyecto.Enabled = false;
        }

        private void Desactiva_boton_modificar_proyecto()
        {
            buttonModificarProyecto.Enabled = false;
        }

        private void Desactiva_boton_agregar_proyecto()
        {
            buttonAgregarProyecto.Enabled = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Operacio_proyectos = "Cancelar";
            Limpia_combo_codigo_cotizacion();
            Limpia_combo_proyecto();
            Limpia_combo_ingenieros_coset();
            Limpia_combo_ingeniero_cliente();
            Limpia_combo_nombre_cliente();
            Limpia_cajas_captura_despues_de_agregar_proyecto();
            Limpia_combo_codigo_cotizacion();
            Desactiva_cajas_captura_despues_de_agregar_proyecto();
            Desaparece_boton_guardar_base_de_datos();
            Desaparece_boton_cancelar();
            Desaparece_combo_codigo_proyecto();
            Desaparece_combo_cliente_nombre();
            Desaparece_combo_ingenieros_cliente();
            Desaparece_combo_ingenieros_coset();
            Desaparece_combo_codigo_cotizacion();
            
            Desaparece_textbox_subproyecto();
            Desactiva_textbox_subproyecto();

            Aparece_textbox_codigo_proyecto();
            Aparece_textbox_ingeniero_cliente();
            Aparece_textbox_ingeniero_coset();
            Aparece_textbox_nombre_cliente();
            Aparece_textbox_codigo_cotizacion();

            Activa_botones_operacion();
            limpia_dibujos_proyecto();
            Desactiva_datagridview_dibujos();
            Acepta_datagridview_agregar_renglones();
            Desaparece_botones_operacion_contactos();
            Desaparece_combo_nombre_proyecto();
            Desactiva_combo_nombre_proyecto();
            Elimina_informacion_proyectos_disponibles();
        }

        private void Desaparece_textbox_subproyecto()
        {
            textBoxSubProyecto.Visible = false;
        }

        private void Limpia_combo_proyecto()
        {
            comboBoxCodigoProyecto.Items.Clear();
            comboBoxCodigoProyecto.Text = "";
        }

        private void Aparece_textbox_codigo_proyecto()
        {
            textBoxCodigoProyecto.Visible = true;
        }

        private void Desaparece_combo_codigo_proyecto()
        {
            comboBoxCodigoProyecto.Visible = false;
        }

        private void Desaparece_botones_operacion_contactos()
        {
            Desaparece_boton_agrega_contacto();
            Desaparece_boton_eliminar_contacto();
        }

        private void Desaparece_boton_eliminar_contacto()
        {
            buttonEliminarDibujo.Visible=false;
        }

        private void Desaparece_boton_agrega_contacto()
        {
            buttonAgregarDibujo.Visible=false;
        }

        private void Aparece_caja_codigo_empleado()
        {
            textBoxCodigoProyecto.Visible = true;
        }

        private void comboBoxCodigoProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Operacio_proyectos == "Modificar")
                configura_forma_modificar();
            else if (Operacio_proyectos == "Eliminar")
                configura_forma_eliminar();
            else if (Operacio_proyectos == "Visualizar")
                configura_forma_visualizar_codigo_proyecto();
            else if (Operacio_proyectos == "Operaciones Dibujos")
                configura_forma_operaciones_dibujos();
            else if (Operacio_proyectos == "Agregar SubProyecto")
                configura_forma_subproyecto();
        }

        private void configura_forma_subproyecto()
        {
            proyecto_seleccion = proyectos_disponibles.Find(proyecto => proyecto.Codigo.Contains(comboBoxCodigoProyecto.Text));
            textBoxNombreProyecto.Text = proyecto_seleccion.Nombre;
            comboBoxNombreCliente.Text = proyecto_seleccion.Nombre_cliente;
            comboBoxCodigoCotizacion.Text = proyecto_seleccion.Codigo_cotizacion;
            comboBoxIngenieroCliente.Text = proyecto_seleccion.Ingeriero_cliente;
            textBoxCodigoOC.Text = proyecto_seleccion.Codigo_orden_compra;

        }

        private void configura_forma_copiar()
        {
            limpia_dibujos_proyecto();
            Rellena_cajas_informacion_de_codigo_proyectos();
            Obtener_datos_partidas_cotizacion_disponibles_base_datos(comboBoxCodigoProyecto.Text);
            Rellena_cajas_informacion_de_dibujos_proyecto();
            Aparce_boton_guardar_base_datos();
        }

        private void configura_forma_agregar()
        {
            Desactiva_combobox_codigo_proyecto();
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

        private void configura_forma_operaciones_dibujos()
        {
            Desactiva_combobox_codigo_proyecto();
            limpia_dibujos_proyecto();
            Obtener_datos_proyectos_disponibles_base_datos();
            Rellena_cajas_informacion_de_codigo_proyectos();
            Obtener_datos_dibujos_proyectos_disponibles_base_datos(comboBoxCodigoProyecto.Text);
            Rellena_cajas_informacion_de_dibujos_proyecto();
            Aparecer_botones_operaciones_dibujos();
            

        }

        private void Aparecer_botones_operaciones_dibujos()
        {
            Aparece_boton_agregar_dibujo();
            Aparece_boton_eliminar_dibujo();
        }

        private void configura_forma_visualizar_codigo_proyecto()
        {
            limpia_dibujos_proyecto();
            Desaparece_combo_cliente_nombre();
            Rellena_cajas_informacion_de_codigo_proyectos();
            Obtener_datos_dibujos_proyectos_disponibles_base_datos(comboBoxCodigoProyecto.Text);
            Rellena_cajas_informacion_de_dibujos_proyecto();
        }

        private void Obtener_datos_dibujos_proyectos_disponibles_base_datos(string codigo_proyecto)
        {
            dibujos_proyecto_disponibles = clase_dibujos_proyecto.Adquiere_dibujos_proyecto_disponibles_en_base_datos(comboBoxCodigoProyecto.Text);
        }

        private void Obtener_datos_dibujos_nombre_proyectos_disponibles_base_datos(string codigo_proyecto)
        {
            dibujos_proyecto_disponibles = clase_dibujos_proyecto.Adquiere_dibujos_proyecto_disponibles_en_base_datos(textBoxCodigoProyecto.Text);
        }

        private void Rellena_cajas_informacion_de_dibujos_proyecto()
        {

            foreach(Dibujos_proyecto dibujo in dibujos_proyecto_disponibles)
            { 

                try
                {
                    dataGridViewDibujosProyecto.Rows.Add(dibujo.Codigo.ToString(), dibujo.Cantidad,
                        dibujo.Numero, dibujo.Descripcion, dibujo.proceso, dibujo.tiempo_estimado_horas);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void Rellena_cajas_informacion_de_codigo_proyectos()
        {
            proyecto_visualizar = proyectos_disponibles.Find(proyecto => proyecto.Codigo.Contains(comboBoxCodigoProyecto.SelectedItem.ToString()));
            Desaparece_combo_nombre_proyecto();
            Desactiva_combo_nombre_proyecto();
            Limpia_combo_nombre_proyecto();
            Aparece_textbox_nombre_proyecto();

            textBoxNombreCliente.Text = proyecto_visualizar.Nombre_cliente;
            textBoxIngenieroCoset.Text = proyecto_visualizar.Ingeniero_coset;;
            textBoxIngenieroCliente.Text = proyecto_visualizar.Ingeriero_cliente;
            dateTimePickerFechaActual.Text = proyecto_visualizar.Fecha_inicio;
            dateTimePickerFechaEntrega.Text = proyecto_visualizar.Fecha_entrega;
            textBoxCodigoCliente.Text = proyecto_visualizar.Codigo_cliente;
            textBoxModelo.Text = proyecto_visualizar.Modelo;
            textBoxSerie.Text = proyecto_visualizar.Serie;
            textBoxCodigoOC.Text = proyecto_visualizar.Codigo_orden_compra;
            textBoxNombreProyecto.Text = proyecto_visualizar.Nombre;
            textBoxUbicacionDibujos.Text = proyecto_visualizar.Ubliacion_dibujos;
            textBoxCodigoCotizacion.Text = proyecto_visualizar.Codigo_cotizacion;
        }

        private void Aparece_textbox_nombre_proyecto()
        {
            textBoxNombreProyecto.Visible = true;
        }

        private void Activa_datetimepicker_fecha_actual()
        {
            dateTimePickerFechaActual.Enabled = true;
        }

        private void configura_forma_eliminar()
        {
            limpia_dibujos_proyecto();
            Rellena_cajas_informacion_de_codigo_proyectos();
            Obtener_datos_dibujos_proyectos_disponibles_base_datos(comboBoxCodigoProyecto.Text);
            Rellena_cajas_informacion_de_dibujos_proyecto();
            Aparece_boton_eliminar_datos_en_base_de_datos();
        }

        private void Aparece_boton_eliminar_datos_en_base_de_datos()
        {
            buttonBorrarBasedeDatos.Visible = true;
        }

        private void configura_forma_modificar()
        {
            limpia_dibujos_proyecto();
            
            Obtener_datos_dibujos_proyectos_disponibles_base_datos(comboBoxCodigoProyecto.Text);
            Rellena_cajas_informacion_de_dibujos_proyecto();
            Activa_cajas_informacion_proyecto();
            Desactiva_combobox_codigo_proyecto();
            Aparce_boton_guardar_base_datos();
            Rellena_cajas_informacion_de_proyectos_modificar();

            Desaparece_textbox_nombre_cliente();
            Aparece_combo_nombre_cliente();
            Activa_combo_nombre_cliente();
            Obtener_clientes_disponibles();
            Rellena_combo_clientes();

            Desaparece_textbox_codigo_cotizacion();
            Aparece_combo_codigo_cotizacion();
            Activa_combo_codigo_cotizacion();
            Obtener_datos_cotizaciones_disponibles_base_datos();
            Rellena_combo_codigo_cotizacion();

            Desaparece_textbox_ingeniero_cliente();
            Aparecer_combo_ingeniero_cliente();
            Activa_combo_ingeniro_cliente();
            Obtener_contactos_cliente_disponibles_modificar();
            Rellena_combo_contactos_clientes();

            Desaparece_textbox_ingeniero_coset();
            Aparece_combo_ingeniero_coset();
            Activa_Combo_ingeniero_coset();
            Obtener_ingenieros_coset_disponibles();
            Rellenar_combo_ingenieros_coset();

            


        }

        private void Obtener_contactos_cliente_disponibles_modificar()
        {
            Cliente_seleccionado = clientes_disponibles.Find(clientes => clientes.Nombre.Contains(comboBoxNombreCliente.Text));
            Obtener_datos_contactos_clientes_disponibles_base_datos(Cliente_seleccionado.Codigo);

        }

        private void Rellena_cajas_informacion_de_proyectos_modificar()
        {
            proyecto_visualizar = proyectos_disponibles.Find(proyecto => proyecto.Codigo.Contains(comboBoxCodigoProyecto.SelectedItem.ToString()));

            comboBoxNombreCliente.Text = proyecto_visualizar.Nombre_cliente;
            comboBoxIngenieroCoset.Text = proyecto_visualizar.Ingeniero_coset; ;
            comboBoxIngenieroCliente.Text = proyecto_visualizar.Ingeriero_cliente;
            dateTimePickerFechaActual.Text = proyecto_visualizar.Fecha_inicio;
            dateTimePickerFechaEntrega.Text = proyecto_visualizar.Fecha_entrega;
            textBoxCodigoCliente.Text = proyecto_visualizar.Codigo_cliente;
            textBoxModelo.Text = proyecto_visualizar.Modelo;
            textBoxSerie.Text = proyecto_visualizar.Serie;
            textBoxCodigoOC.Text = proyecto_visualizar.Codigo_orden_compra;
            textBoxNombreProyecto.Text = proyecto_visualizar.Nombre;
            textBoxUbicacionDibujos.Text = proyecto_visualizar.Ubliacion_dibujos;
            comboBoxCodigoCotizacion.Text = proyecto_visualizar.Codigo_cotizacion;
        }

        private void Aparce_boton_guardar_base_datos()
        {
            buttonGuardarBasedeDatos.Visible = true;
        }

        private void Asigna_datos_en_cajas_a_variable()
        {
            //cotizacion_modificaciones.Nombre = textBoxNombreCliente.Text;
            //cotizacion_modificaciones.Direccion = textBoxAtencion.Text;
            //cotizacion_modificaciones.Rfc = textBoxOrdenTrabajo.Text;
            //cotizacion_modificaciones.Telefono = textBoxProyecto.Text;

        }

        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos_modificar_clientes()
        {
            timerModificarClientes.Enabled = true;
        }

        private void Desactiva_combobox_codigo_proyecto()
        {
            comboBoxCodigoProyecto.Enabled = false;
        }

        private void buttonAgregarCotizacion_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult= MessageBox.Show("Se Agrega Sub-Proyecto?", "Agegar Proyecto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                Agrega_subproyecto();
            else
            {
                Agrega_proyecto();
            }

        }



        private void Agrega_subproyecto()
        {
            Operacio_proyectos = "Agregar SubProyecto";
            Desactiva_botones_operacion();
            Activa_cajas_informacion_proyecto();
            No_aceptar_agregar_dibujos_proyecto();
            Acepta_datagridview_agregar_renglones();
            Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_proyecto();
            Aparece_boton_cancelar_operacio();
            Activa_datagridview_dibujos_proyecto();

            Aparece_textbox_subproyecto();
            Activa_textbox_subproyecto();

            Desaparece_textbox_nombre_cliente();
            Aparece_combo_nombre_cliente();
            Activa_combo_nombre_cliente();
            Obtener_clientes_disponibles();
            Rellena_combo_clientes();

            Desaparece_textbox_codigo_cotizacion();
            Aparece_combo_codigo_cotizacion();
            Activa_combo_codigo_cotizacion();
            Obtener_datos_cotizaciones_disponibles_base_datos();
            Rellena_combo_codigo_cotizacion();

            Desapare_textbox_codigo_proyecto();
            Aparece_combo_codigo_proyecto();
            Activa_combo_codigo_proyecto();
            Obtener_datos_proyectos_disponibles_base_datos();
            Rellena_combo_codigo_proyectos_no_subproyectos();

            Activa_columna_numero_dibujo_datagrid();


        }

        private void Activa_textbox_subproyecto()
        {
            textBoxSubProyecto.Enabled=true;
        }

        private void Aparece_textbox_subproyecto()
        {
            textBoxSubProyecto.Visible = true;
        }

        private void Agrega_contactos_cliente()
        {
            MessageBox.Show("falta software");
        }

        private void Rellena_combo_codigo_proyectos_no_subproyectos()
        {
            foreach (Proyecto proyecto in proyectos_disponibles)
            {
                if (proyecto.error == "")
                {
                    if (proyecto.SubProyecto == "0")
                    {
                        comboBoxCodigoProyecto.Items.Add(proyecto.Codigo);
                    }
                }
                else
                {
                    MessageBox.Show(proyecto.error);
                    break;
                }
            }
        }

        private void Desapare_textbox_codigo_proyecto()
        {
            textBoxCodigoProyecto.Visible = false;
        }

        private void Agrega_proyecto()
        {
            Operacio_proyectos = "Agregar Proyecto";
            Asigna_codigo_proyecto_foilio_disponible();
            //Asigna_nuevo_folio_proyecto();
            Desactiva_botones_operacion();
            Activa_cajas_informacion_proyecto();
            No_aceptar_agregar_dibujos_proyecto();
            Acepta_datagridview_agregar_renglones();
            Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_proyecto();
            Aparece_boton_cancelar_operacio();
            Activa_datagridview_dibujos_proyecto();
            Activa_columna_numero_dibujo_datagrid();

            Desaparece_textbox_nombre_cliente();
            Aparece_combo_nombre_cliente();
            Activa_combo_nombre_cliente();
            Obtener_clientes_disponibles();
            Rellena_combo_clientes();

            Desaparece_textbox_codigo_cotizacion();
            Aparece_combo_codigo_cotizacion();
            Activa_combo_codigo_cotizacion();
            Obtener_datos_cotizaciones_disponibles_base_datos();
            Rellena_combo_codigo_cotizacion();

            limpia_combo_tipo_proceso_datagrid_dibujo_proyecto();
            Rellenar_combo_tipo_proceso_datagrid_dibujo_proyecto();
            
        }

        private void limpia_combo_tipo_proceso_datagrid_dibujo_proyecto()
        {
            Tipo_Proceso.Items.Clear();
        }

        private void Rellenar_combo_tipo_proceso_datagrid_dibujo_proyecto()
        {
            Tipo_Proceso.Items.Add("Mecanico");
            Tipo_Proceso.Items.Add("Electrico");
        }

        private void Asigna_codigo_OC_folio_disponible()
        {
            folio_disponible = class_folio_disponible.Obtener_informacion_control_folio_base_datos();
            textBoxCodigoOC.Text = folio_disponible.Folio_oc;
        }

        private void Desaparece_textbox_codigo_cotizacion()
        {
            textBoxCodigoCotizacion.Visible = false;
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

        private void Aparecer_combo_ingeniero_cliente()
        {
            comboBoxIngenieroCliente.Visible = true;
        }

        private void Activa_combo_ingeniro_cliente()
        {
            comboBoxIngenieroCliente.Enabled = true;
        }

        private void Desaparece_textbox_ingeniero_cliente()
        {
            textBoxIngenieroCliente.Visible = false;
        }

        private void Asigna_codigo_proyecto_foilio_disponible()
        {
            folio_disponible = class_folio_disponible.Obtener_informacion_control_folio_base_datos();
            textBoxCodigoProyecto.Text = folio_disponible.Folio_proyectos;
        }

        private void Acepta_datagridview_agregar_renglones()
        {
            dataGridViewDibujosProyecto.AllowUserToAddRows = true;
        }

        private void Activa_datagridview_dibujos_proyecto()
        {
            dataGridViewDibujosProyecto.Enabled = true;
        }

        private void Desactiva_columna_codigo_partidas_cotizaciones()
        {
            dataGridViewDibujosProyecto.Columns[0].Visible = false;
        }

        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_proyecto()
        {
            timerAgregarProyecto.Enabled = true;
        }

        private void Activa_cajas_informacion_proyecto()
        {
            textBoxNombreCliente.Enabled = true;
            textBoxNombreProyecto.Enabled = true;
            dateTimePickerFechaActual.Enabled = true;
            dateTimePickerFechaEntrega.Enabled = true;
            textBoxModelo.Enabled = true;
            textBoxSerie.Enabled = true;
            textBoxCodigoOC.Enabled = true;
        }

        private void Modifica_contactos_cliente()
        {
            throw new NotImplementedException();
        }



        private void timerAgregarCliente_Tick(object sender, EventArgs e)
        {
            if (Operacio_proyectos == "Agregar Proyecto")
            {
                //if (textBoxCodigoProyecto.Text != "" && comboBoxNombreCliente.Text != "" &&
                //comboBoxCodigoCotizacion.Text != "" && textBoxCodigoOC.Text != "" && 
                //comboBoxIngenieroCoset.Text != "" && comboBoxIngenieroCliente.Text != ""  &&
                //textBoxNombreProyecto.Text != "" && textBoxModelo.Text != "" &&
                //textBoxSerie.Text != "")
                if (textBoxCodigoProyecto.Text != "" && comboBoxNombreCliente.Text != "" &&
                comboBoxCodigoCotizacion.Text != ""  && comboBoxIngenieroCoset.Text != "" &&
                comboBoxIngenieroCliente.Text != "")
                {
                    timerAgregarProyecto.Enabled = false;
                    buttonGuardarBasedeDatos.Visible = true;
                }
            }
            else if(Operacio_proyectos == "Agregar SubProyecto")
            {
                if (comboBoxCodigoProyecto.Text != "" && comboBoxNombreCliente.Text != "" &&
                comboBoxCodigoCotizacion.Text != "" && textBoxCodigoOC.Text != "" &&
                comboBoxIngenieroCoset.Text != "" && comboBoxIngenieroCliente.Text != "" &&
                textBoxNombreProyecto.Text != "" && textBoxModelo.Text != "" &&
                textBoxSerie.Text != "" && textBoxSubProyecto.Text != "")
                {
                    timerAgregarProyecto.Enabled = false;
                    buttonGuardarBasedeDatos.Visible = true;
                }

            }
        }

        private void buttonGuardarBasedeDatos_Click(object sender, EventArgs e)
        {
            if (Operacio_proyectos == "Agregar Proyecto")
                Secuencia_agregar_proyecto();
            if (Operacio_proyectos == "Agregar SubProyecto")
                Secuencia_agregar_subproyecto();
            else if (Operacio_proyectos == "Modificar")
                Secuencia_modificar_proyecto();
            else if (Operacio_proyectos == "Agregar Dibujo")
                Secuencia_agregar_dibujos();

        }

        private void Secuencia_agregar_subproyecto()
        {
            if (verifica_datos_partidas())
            {
                if (Guarda_datos_dibujos_proyecto())
                {
                    if (Guarda_datos_proyecto())
                    {
                        if (Actulaiza_cotizacion_asigna_Orden_compra_y_subproyecto())
                        {
                            Limpia_cajas_captura_despues_de_agregar_proyecto();
                            Limpia_combo_codigo_cotizacion();
                            Limpia_combo_nombre_cliente();
                            Limpia_combo_ingenieros_coset();
                            Limpia_combo_ingeniero_cliente();
                            Desactiva_cajas_captura_despues_de_agregar_proyecto();
                            Desaparece_boton_guardar_base_de_datos();
                            Desaparece_boton_cancelar();
                            Desaparece_combo_codigo_cotizacion();
                            Desaparece_combo_cliente_nombre();
                            Desaparece_combo_ingenieros_coset();
                            Desaparece_combo_ingenieros_cliente();
                            Activa_botones_operacion();
                            Limpia_operaciones_proyectos();
                            limpia_dibujos_proyecto();
                            Desactiva_datagridview_dibujos();

                            Desactiva_combo_cliente_nombre();
                            Desactiva_combo_codigo_cotizacion();
                            Desactiva_combo_ingeniero_coset();
                            Desactiva_combo_ingenieros_cliente();

                            Aparece_textbox_nombre_cliente();
                            Aparece_textbox_codigo_cotizacion();
                            Aparece_textbox_ingeniero_coset();
                            Aparece_textbox_ingeniero_cliente();

                            Desaparece_textbox_subproyecto();
                            Desactiva_textbox_subproyecto();

                            Limpia_combo_proyecto();
                            Desaparece_combo_codigo_proyecto();
                            Desactiva_combobox_codigo_proyecto();

                            Elimina_informacion_proyectos_disponibles();
                        }
                    }
                }
            }
        }

        private bool Actulaiza_cotizacion_asigna_Orden_compra_y_subproyecto()
        {
            return Actualiza_cotizacion_datos_subproyecto();
        }

        private bool Actualiza_cotizacion_datos_subproyecto()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_ingenieria());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_a_en_basectualizar_de_datos_subproyecto(), connection);
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

        private string Configura_cadena_comando_a_en_basectualizar_de_datos_subproyecto()
        {
            return "UPDATE cotizaciones set  orden_compra='" + textBoxCodigoOC.Text +
                 "',proyecto='" + comboBoxCodigoProyecto.Text + "-" + textBoxSubProyecto.Text+
                "' where codigo_cotizacion='" + comboBoxCodigoCotizacion.Text + "';";
        }

        private void Desactiva_textbox_subproyecto()
        {
            textBoxSubProyecto.Enabled = false;
        }

        private void Desapare_textbox_subproyecto()
        {
            textBoxSubProyecto.Visible = false;
        }

        private void Secuencia_copiar_cotizacion()
        {
            if (Copia_datos_partidas_cotizacion())
            {
                if (Copia_datos_cotizaciones())
                {
                    Limpia_cajas_captura_despues_de_agregar_proyecto();
                    Limpia_combo_codigo_cotizacion();
                    Desactiva_cajas_captura_despues_de_agregar_proyecto();
                    Desaparece_boton_guardar_base_de_datos();
                    Desaparece_boton_cancelar();
                    Desaparece_combo_codigo_cotizacion();
                    Activa_botones_operacion();
                    limpia_dibujos_proyecto();
                    Desactiva_datagridview_dibujos();
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
                    Elimina_informacion_proyectos_disponibles();
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
                   "VALUES('" + comboBoxCodigoProyecto.Text + "','" + textBoxNombreCliente.Text + "'," +
                   "'" + dateTimePickerFechaActual.Text + "','" + dateTimePickerFechaEntrega.Text + "'," +
                   "'" + textBoxCodigoCotizacion.Text + "','" + textBoxIngenieroCoset.Text + "'" + ");";
        }

        private bool Copia_datos_partidas_cotizacion()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_ingenieria());
            try
            {
                connection.Open();
                for (int partidas = 0; partidas < dataGridViewDibujosProyecto.Rows.Count; partidas++)
                {
                    for (int campo = 1; campo < dataGridViewDibujosProyecto.Rows[partidas].Cells.Count; campo++)
                    {
                        if (dataGridViewDibujosProyecto.Rows[partidas].Cells[campo].Value != null)
                        {
                            if (campo == (int)Campos_dibujos.numero)
                                partida_cotizacion_agregar.Numero = dataGridViewDibujosProyecto.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_dibujos.cantidad)
                                partida_cotizacion_agregar.Cantidad = dataGridViewDibujosProyecto.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_dibujos.numero)
                                partida_cotizacion_agregar.Parte = dataGridViewDibujosProyecto.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_dibujos.descripcion)
                                partida_cotizacion_agregar.Descripcion = dataGridViewDibujosProyecto.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_dibujos.proceso)
                                partida_cotizacion_agregar.Precio = dataGridViewDibujosProyecto.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_dibujos.tiempo_estimado)
                                partida_cotizacion_agregar.Importe = dataGridViewDibujosProyecto.Rows[partidas].Cells[campo].Value.ToString();
                        }

                        else
                        {
                            MessageBox.Show("campo en blanco");
                            connection.Close();
                            return false;
                        }
                    }
                    Asigna_codigo_empleado_para_tipo_de_operacio();
                    //MySqlCommand command = new MySqlCommand(Configura_cadena_comando_insertar_en_base_de_datos_partidasdibujos_proyecto(partida_cotizacion_agregar), connection);
                    //command.ExecuteNonQuery();
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

        private void Secuencia_agregar_dibujos()
        {
            if (verifica_datos_partidas())
            {
                if (Guarda_datos_dibujos_proyecto())
                {
                    Desaparece_boton_guardar_base_de_datos();
                    Activa_botones_operacion_contactos();
                    limpia_dibujos_proyecto();
                    Limpia_operaciones_proyectos();
                    No_aceptar_agregar_dibujos_proyecto();
                    Obtener_datos_dibujos_proyectos_disponibles_base_datos(comboBoxCodigoProyecto.Text);
                    Rellena_cajas_informacion_de_dibujos_proyecto();
                    Elimina_informacion_proyectos_disponibles();
                }
            }
        }

        private void Activa_botones_operacion_contactos()
        {
            Activa_boton_agregar_dibujos();
            Activa_boton_eliminar_dibujos();
        }

        private void Activa_boton_eliminar_dibujos()
        {
            buttonEliminarDibujo.Enabled = true;
        }

        private void Activa_boton_agregar_dibujos()
        {
            buttonAgregarDibujo.Enabled=true;
        }

        private void Secuencia_modificar_proyecto()
        {
            if (verifica_datos_partidas())
            {
                if (Modificar_datos_dibujos_proyecto())
                {
                    if (Modifica_datos_proyecto())
                    {
                        Limpia_cajas_captura_despues_de_agregar_proyecto();

                        Limpia_combo_codigo_cotizacion();
                        Limpia_combo_nombre_cliente();
                        Limpia_combo_ingenieros_coset();
                        Limpia_combo_ingeniero_cliente();
                        Limpia_combo_proyecto();

                        Desactiva_cajas_captura_despues_de_agregar_proyecto();
                        Desaparece_boton_guardar_base_de_datos();
                        Desaparece_boton_cancelar();

                        Desaparece_combo_codigo_cotizacion();
                        Desaparece_combo_cliente_nombre();
                        Desaparece_combo_ingenieros_coset();
                        Desaparece_combo_ingenieros_cliente();
                        Desaparece_combo_codigo_proyecto();

                        Activa_botones_operacion();
                        Limpia_operaciones_proyectos();
                        limpia_dibujos_proyecto();
                        Desactiva_datagridview_dibujos();

                        Desactiva_combo_cliente_nombre();
                        Desactiva_combo_codigo_cotizacion();
                        Desactiva_combo_ingeniero_coset();
                        Desactiva_combo_ingenieros_cliente();
                        Desactiva_combobox_codigo_proyecto();

                        Aparece_textbox_nombre_cliente();
                        Aparece_textbox_codigo_cotizacion();
                        Aparece_textbox_ingeniero_coset();
                        Aparece_textbox_ingeniero_cliente();
                        Aparece_textbox_codigo_proyecto();
                        Activa_columna_numero_dibujo_datagrid();

                        Elimina_informacion_proyectos_disponibles();
                    }
                }
            }
        }

        private void Aparce_caja_codigo_cliente()
        {
            textBoxCodigoProyecto.Visible = true;
        }

        private bool Modifica_datos_proyecto()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_ingenieria());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_modificar_en_base_de_datos_proyecto(), connection);
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

        private string Configura_cadena_comando_modificar_en_base_de_datos_proyecto()
        {
            return "UPDATE proyectos set  nombre_proyecto='" + textBoxNombreProyecto.Text +
                "',modelo_proyecto='" + textBoxModelo.Text +
                "',serie_proyecto='" + textBoxSerie.Text +
                "',codigo_cotizacion='" + comboBoxCodigoCotizacion.Text +
                "',codigo_orden_compra='" + textBoxCodigoOC.Text +
               "',fecha_inicio='" + dateTimePickerFechaActual.Text +
               "',fecha_entrega='" + dateTimePickerFechaEntrega.Text +
               "',codigo_cliente='" + textBoxCodigoCliente.Text +
               "',nombre_cliente='" + comboBoxNombreCliente.Text +
               "',ingeniero_coset_proyecto='" + comboBoxIngenieroCoset.Text +
               "',ubicacion_dibujos='" + textBoxUbicacionDibujos.Text +
               "',ingeniero_cliente_proyecto='" + comboBoxIngenieroCliente.Text +
               "' where codigo_proyecto='" + comboBoxCodigoProyecto.Text + "';";
        }

        private bool Modificar_datos_dibujos_proyecto()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_ingenieria());
            try
            {
                connection.Open();
                for (int dibujos = 0; dibujos < dataGridViewDibujosProyecto.Rows.Count; dibujos++)
                {
                    for (int campo = 0; campo < dataGridViewDibujosProyecto.Rows[dibujos].Cells.Count; campo++)
                    {
                        if (dataGridViewDibujosProyecto.Rows[dibujos].Cells[campo].Value != null)
                        {
                            if (campo == (int)Campos_dibujos.codigo)
                                dibujos_proyecto_modificar.Codigo = Convert.ToInt32(dataGridViewDibujosProyecto.Rows[dibujos].Cells[campo].Value.ToString());
                            else if (campo == (int)Campos_dibujos.cantidad)
                                dibujos_proyecto_modificar.Cantidad = dataGridViewDibujosProyecto.Rows[dibujos].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_dibujos.numero)
                                dibujos_proyecto_modificar.Numero = dataGridViewDibujosProyecto.Rows[dibujos].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_dibujos.descripcion)
                                dibujos_proyecto_modificar.Descripcion = dataGridViewDibujosProyecto.Rows[dibujos].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_dibujos.proceso)
                                dibujos_proyecto_modificar.proceso = dataGridViewDibujosProyecto.Rows[dibujos].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_dibujos.tiempo_estimado)
                                dibujos_proyecto_modificar.tiempo_estimado_horas = dataGridViewDibujosProyecto.Rows[dibujos].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_dibujos.codigo)
                                dibujos_proyecto_modificar.Codigo = Convert.ToInt32(dataGridViewDibujosProyecto.Rows[dibujos].Cells[campo].Value.ToString());
                        }

                        else
                        {
                            MessageBox.Show("campo en blanco");
                            connection.Close();
                            return false;
                        }
                    }
                    MySqlCommand command = new MySqlCommand(Configura_cadena_comando_en_base_de_datos_modificar_dibujos_proyecto(dibujos_proyecto_modificar), connection);
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

        private string Configura_cadena_comando_en_base_de_datos_modificar_dibujos_proyecto(Dibujos_proyecto partidas_proyecto)
        {
            return "UPDATE dibujos_proyecto set  cantidad_dibujos='" + partidas_proyecto.Cantidad +
                "',numero_dibujo='" + partidas_proyecto.Numero +
                "',descripcion_dibujo='" + partidas_proyecto.Descripcion +
                "',proceso='" + partidas_proyecto.proceso +
                "',tiempo_estimado_horas='" + partidas_proyecto.tiempo_estimado_horas +
                "' where codigo_dibujo='" + partidas_proyecto.Codigo + "';";
        }

        private void Secuencia_agregar_proyecto()
        {
            if (verifica_datos_partidas())
            {
                if (Guarda_datos_dibujos_proyecto())
                {
                    if (Guarda_datos_proyecto())
                    {
                        if (Actulaiza_cotizacion_asigna_Orden_compra_y_proyecto())
                        {
                            Limpia_cajas_captura_despues_de_agregar_proyecto();
                            Limpia_combo_codigo_cotizacion();
                            Limpia_combo_nombre_cliente();
                            Limpia_combo_ingenieros_coset();
                            Limpia_combo_ingeniero_cliente();
                            Desactiva_cajas_captura_despues_de_agregar_proyecto();
                            Desaparece_boton_guardar_base_de_datos();
                            Desaparece_boton_cancelar();
                            Desaparece_combo_codigo_cotizacion();
                            Desaparece_combo_cliente_nombre();
                            Desaparece_combo_ingenieros_coset();
                            Desaparece_combo_ingenieros_cliente();
                            Activa_botones_operacion();
                            Limpia_operaciones_proyectos();
                            limpia_dibujos_proyecto();
                            Desactiva_datagridview_dibujos();

                            Desactiva_combo_cliente_nombre();
                            Desactiva_combo_codigo_cotizacion();
                            Desactiva_combo_ingeniero_coset();
                            Desactiva_combo_ingenieros_cliente();

                            Aparece_textbox_nombre_cliente();
                            Aparece_textbox_codigo_cotizacion();
                            Aparece_textbox_ingeniero_coset();
                            Aparece_textbox_ingeniero_cliente();

                            //Asigna_nuevo_folio_OC();
                            Asigna_nuevo_folio_proyecto();

                            Elimina_informacion_proyectos_disponibles();
                        }
                    }
                   
                }
            }

        }

        private bool Verifica_existe_numero_dibujo()
        {

            for (int partidas = 0; partidas < dataGridViewDibujosProyecto.Rows.Count - 1; partidas++)
            {
                for (int campo = 1; campo < dataGridViewDibujosProyecto.Rows[partidas].Cells.Count; campo++)
                {
                    dibujos_proyecto_disponibles = clase_dibujos_proyecto.Adquiere_dibujos_proyecto_disponibles_en_base_datos(
                        dataGridViewDibujosProyecto.Rows[partidas].Cells[campo].Value.ToString());
                    if(dibujos_proyecto_disponibles.Count!=0)
                    {
                        MessageBox.Show("Numero de Dibujo existe en proyecto","Agregar Dibujo",
                            MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        dataGridViewDibujosProyecto.Rows[partidas].Cells[campo].Value = "";
                        return false;
                    }
                      
                }

                
            }
            return true;
        }

        private void Limpia_operaciones_proyectos()
        {
            Operacio_proyectos = "";
        }

        private bool verifica_datos_partidas()
        {
            for (int partidas = 0; partidas < dataGridViewDibujosProyecto.Rows.Count - 1; partidas++)
            {
                for (int campo = 1; campo < dataGridViewDibujosProyecto.Rows[partidas].Cells.Count; campo++)
                {
                    if (dataGridViewDibujosProyecto.Rows[partidas].Cells[campo].Value == null)
                    {
                        MessageBox.Show("campo en blanco");
                        return false;
                    }

                }

            }
            return true;
        }

        private bool Actulaiza_cotizacion_asigna_Orden_compra_y_proyecto()
        {
            return Actualiza_cotizacion_datos();
        }

        private bool Actualiza_cotizacion_datos()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_ingenieria());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_actualizar_en_base_de_datos_proyecto(), connection);
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

        private string Configura_cadena_comando_actualizar_en_base_de_datos_proyecto()
        {
            return "UPDATE cotizaciones set  orden_compra='" + textBoxCodigoOC.Text +
                "',proyecto='" + textBoxCodigoProyecto.Text +
               "' where codigo_cotizacion='" + comboBoxCodigoCotizacion.Text + "';";
        }

        private void Asigna_nuevo_folio_OC()
        {
            int numero_folio = Convert.ToInt32(folio_disponible.Folio_oc.Substring(2, folio_disponible.Folio_oc.Length - 2));
            numero_folio++;
            folio_disponible.Folio_oc = folio_disponible.Folio_oc.Substring(0, 2) + numero_folio.ToString();
            string respuesta = class_folio_disponible.Actualiza_Control_folios_base_datos(folio_disponible);

            if (respuesta != "")
                MessageBox.Show(folio_disponible.error);
        }

        private void Aparece_textbox_ingeniero_cliente()
        {
            textBoxIngenieroCliente.Visible = true;
        }

        private void Aparece_textbox_ingeniero_coset()
        {
            textBoxIngenieroCoset.Visible = true;
        }

        private void Aparece_textbox_codigo_cotizacion()
        {
            textBoxCodigoCotizacion.Visible = true;
        }

        private void Desactiva_combo_ingenieros_cliente()
        {
            comboBoxIngenieroCliente.Enabled = false;
        }

        private void Desactiva_combo_ingeniero_coset()
        {
            comboBoxIngenieroCoset.Enabled = false;
        }

        private void Desactiva_combo_codigo_cotizacion()
        {
            comboBoxCodigoCotizacion.Enabled = false;
        }

        private void Desaparece_combo_ingenieros_cliente()
        {
            comboBoxIngenieroCliente.Visible = false;
        }

        private void Desaparece_combo_ingenieros_coset()
        {
            comboBoxIngenieroCoset.Visible = false;
        }

        private void Limpia_combo_ingeniero_cliente()
        {
            comboBoxIngenieroCliente.Items.Clear();
            comboBoxIngenieroCliente.Text = "";
        }

        private void Limpia_combo_ingenieros_coset()
        {
            comboBoxIngenieroCoset.Items.Clear();
            comboBoxIngenieroCoset.Text = "";
        }

        private void Limpia_combo_nombre_cliente()
        {
            comboBoxNombreCliente.Items.Clear();
            comboBoxNombreCliente.Text = "";
        }

        private void Aparece_textbox_atencion_copia()
        {
            textBoxIngenieroCoset.Visible = true;
        }

        private void Aparece_textbox_atencion()
        {
            textBoxCodigoCotizacion.Visible = true;
        }

        private void Aparece_textbox_nombre_cliente()
        {
            textBoxNombreCliente.Visible = true;
        }

        private void Desactiva_combo_copia_atencion()
        {
            comboBoxIngenieroCoset.Enabled = false;
        }

        private void Desaparece_combo_copia_atencion()
        {
            comboBoxIngenieroCoset.Visible = false;
        }

        private void Desactiva_combo_atencion()
        {
            comboBoxCodigoCotizacion.Enabled = false;
        }

        private void Desaparece_combo_atencion()
        {
            comboBoxCodigoCotizacion.Visible = false;
        }

        private void Desactiva_combo_cliente_nombre()
        {
            comboBoxNombreCliente.Enabled = false;
        }

        private void Desaparece_combo_cliente_nombre()
        {
            comboBoxNombreCliente.Visible = false;
        }

        private void Asigna_nuevo_folio_proyecto()
        {
            int numero_folio = Convert.ToInt32(folio_disponible.Folio_proyectos.Substring(2, folio_disponible.Folio_proyectos.Length - 2));
            numero_folio++;
            folio_disponible.Folio_proyectos = folio_disponible.Folio_proyectos.Substring(0, 2) + numero_folio.ToString("00000");
            string respuesta = class_folio_disponible.Actualiza_Control_folios_base_datos(folio_disponible);

            if (respuesta != "")
                MessageBox.Show(folio_disponible.error);
        }

        private void Desactiva_datagridview_dibujos()
        {
            dataGridViewDibujosProyecto.Enabled = false;
        }

        private void Elimina_informacion_proyectos_disponibles()
        {
            cotizaciones_disponibles = null;
            partidas_cotizacion_disponibles = null;
            clientes_disponibles = null;
            contactos_cliente_disponibles = null;
            proyectos_disponibles = null;
            dibujos_proyecto_disponibles = null;
            GC.Collect();
        }

        private void Activa_botones_operacion()
        {
            Activa_boton_agregar_ccotizacion();
            Activa_boton_modificar_cotizacion();
            Activa_boton_eliminar_cotizacion();
            Activa_boton_visualizar_cotizacion();
            Activa_boton_contactos();
        }

        private void Activa_boton_contactos()
        {
            buttonDibujos.Enabled = true;
        }

        private void Activa_boton_visualizar_cotizacion()
        {
            buttonBuscarProyecto.Enabled = true;
        }

        private void Activa_boton_eliminar_cotizacion()
        {
            buttonEliminarProyecto.Enabled = true;
        }

        private void Activa_boton_modificar_cotizacion()
        {
            buttonModificarProyecto.Enabled = true;
        }

        private void Activa_boton_agregar_ccotizacion()
        {
            buttonAgregarProyecto.Enabled = true;
        }

        private void Desaparece_combo_codigo_cotizacion()
        {
            comboBoxCodigoCotizacion.Visible = false;
        }

        private void Desaparece_boton_cancelar()
        {
            buttonCancelar.Visible = false;
        }

        private void Desaparece_boton_guardar_base_de_datos()
        {
            buttonGuardarBasedeDatos.Visible = false;
        }

        private void Desactiva_cajas_captura_despues_de_agregar_proyecto()
        {
            textBoxCodigoProyecto.Enabled = false;
            textBoxNombreProyecto.Enabled = false;
            textBoxModelo.Enabled = false;
            textBoxSerie.Enabled = false;
            dateTimePickerFechaActual.Enabled = false;
            dateTimePickerFechaEntrega.Enabled = false;
            textBoxUbicacionDibujos.Enabled = false;
            textBoxNombreCliente.Enabled = false;
            textBoxCodigoOC.Enabled = false;
            textBoxSubProyecto.Enabled = false;
        }

        private void Limpia_combo_codigo_cotizacion()
        {
            comboBoxCodigoCotizacion.Items.Clear();
            comboBoxCodigoCotizacion.Text = "";
        }

        private void Limpia_cajas_captura_despues_de_agregar_proyecto()
        {
            textBoxCodigoProyecto.Text = "";
            textBoxNombreProyecto.Text = "";
            textBoxModelo.Text = "";
            textBoxSerie.Text = "";
            textBoxCodigoCliente.Text = "";
            textBoxCodigoOC.Text = "";
            dateTimePickerFechaActual.Text = DateTime.Today.ToString();
            dateTimePickerFechaEntrega.Text = DateTime.Today.ToString();
            textBoxUbicacionDibujos.Text = "";
            textBoxNombreCliente.Text = "";
            textBoxIngenieroCliente.Text = "";
            textBoxIngenieroCoset.Text = "";
            textBoxCodigoCotizacion.Text = "";
            textBoxSubProyecto.Text = "";

        }

        private bool Guarda_datos_dibujos_proyecto()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_ingenieria());
            try
            {
                connection.Open();
                for (int partidas = 0; partidas < dataGridViewDibujosProyecto.Rows.Count - 1; partidas++)
                {
                    for (int campo = 1; campo < dataGridViewDibujosProyecto.Rows[partidas].Cells.Count; campo++)
                    {
                        if (dataGridViewDibujosProyecto.Rows[partidas].Cells[campo].Value != null)
                        {
                            if (campo == (int)Campos_dibujos.cantidad)
                                dibujo_agregar.Cantidad = dataGridViewDibujosProyecto.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_dibujos.numero)
                                dibujo_agregar.Numero = dataGridViewDibujosProyecto.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_dibujos.descripcion)
                                dibujo_agregar.Descripcion = dataGridViewDibujosProyecto.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_dibujos.proceso)
                                dibujo_agregar.proceso = dataGridViewDibujosProyecto.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_dibujos.tiempo_estimado)
                                dibujo_agregar.tiempo_estimado_horas = dataGridViewDibujosProyecto.Rows[partidas].Cells[campo].Value.ToString();
                            if (campo == (int)Campos_dibujos.numero)
                            {
                                dibujos_proyecto_disponibles = clase_dibujos_proyecto.Adquiere_dibujos_disponibles_en_base_datos(
                            dataGridViewDibujosProyecto.Rows[partidas].Cells[campo].Value.ToString());
                                if (dibujos_proyecto_disponibles.Count != 0)
                                {
                                    MessageBox.Show("Numero de Dibujo existe en proyecto", "Agregar Dibujo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    dataGridViewDibujosProyecto.Rows[partidas].Cells[campo].Value = "";
                                    connection.Close();
                                    return false;
                                }
                            }
                        }

                        else
                        {
                            MessageBox.Show("campo en blanco");
                            connection.Close();
                            return false;
                        }
                    }
                    Asigna_codigo_empleado_para_tipo_de_operacio();
                    MySqlCommand command = new MySqlCommand(Configura_cadena_comando_insertar_en_base_de_datos_dibujos_proyecto(dibujo_agregar), connection);
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
            if (Operacio_proyectos == "Agregar Proyecto")
                dibujo_agregar.Codigo_proyecto = textBoxCodigoProyecto.Text;
            else if (Operacio_proyectos == "Agregar Dibujo")
                dibujo_agregar.Codigo_proyecto = comboBoxCodigoProyecto.Text;
            else if(Operacio_proyectos == "Agregar SubProyecto")
                dibujo_agregar.Codigo_proyecto = comboBoxCodigoProyecto.Text + "-"+ textBoxSubProyecto.Text;
        }

        private string Configura_cadena_comando_insertar_en_base_de_datos_dibujos_proyecto(Dibujos_proyecto partida_cotizacion)
        {
            return "INSERT INTO dibujos_proyecto(cantidad_dibujos, numero_dibujo,descripcion_dibujo," +
                "proceso,tiempo_estimado_horas,codigo_proyecto) " +
                "VALUES('" + partida_cotizacion.Cantidad + "','" + partida_cotizacion.Numero + "'," +
                "'" + partida_cotizacion.Descripcion + "','" + partida_cotizacion.proceso + "'" +
                ",'" + partida_cotizacion.tiempo_estimado_horas + "','" + partida_cotizacion.Codigo_proyecto +"');";
        }

        private bool Guarda_datos_proyecto()
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
        {  if (Operacio_proyectos == "Agregar Proyecto")
            {
                return "INSERT INTO proyectos(codigo_proyecto, nombre_proyecto,modelo_proyecto," +
                    "serie_proyecto,codigo_cotizacion,codigo_orden_compra,fecha_inicio,fecha_entrega," +
                    "codigo_cliente,nombre_cliente,ingeniero_coset_proyecto,ubicacion_dibujos," +
                    "ingeniero_cliente_proyecto,sub_proyecto) " +
                    "VALUES('" + textBoxCodigoProyecto.Text + "','" + textBoxNombreProyecto.Text + "'," +
                    "'" + textBoxModelo.Text + "','" + textBoxSerie.Text + "'," +
                    "'" + comboBoxCodigoCotizacion.Text + "','" + textBoxCodigoOC.Text + "'," +
                    "'" + dateTimePickerFechaActual.Text + "','" + dateTimePickerFechaEntrega.Text + "'," +
                    "'" + textBoxCodigoCliente.Text + "','" + comboBoxNombreCliente.Text + "'," +
                    "'" + comboBoxIngenieroCoset.Text + "','" + textBoxUbicacionDibujos.Text + "'," +
                    "'" + comboBoxIngenieroCliente.Text + "','0');";
            }
            else if (Operacio_proyectos == "Agregar SubProyecto")
            {
                return "INSERT INTO proyectos(codigo_proyecto, nombre_proyecto,modelo_proyecto," +
                    "serie_proyecto,codigo_cotizacion,codigo_orden_compra,fecha_inicio,fecha_entrega," +
                    "codigo_cliente,nombre_cliente,ingeniero_coset_proyecto,ubicacion_dibujos," +
                    "ingeniero_cliente_proyecto,sub_proyecto) " +
                    "VALUES('" + comboBoxCodigoProyecto.Text +"-"+ textBoxSubProyecto.Text+"','" 
                    + textBoxNombreProyecto.Text + "'," +
                    "'" + textBoxModelo.Text + "','" + textBoxSerie.Text + "'," +
                    "'" + comboBoxCodigoCotizacion.Text + "','" + textBoxCodigoOC.Text + "'," +
                    "'" + dateTimePickerFechaActual.Text + "','" + dateTimePickerFechaEntrega.Text + "'," +
                    "'" + textBoxCodigoCliente.Text + "','" + comboBoxNombreCliente.Text + "'," +
                    "'" + comboBoxIngenieroCoset.Text + "','" + textBoxUbicacionDibujos.Text + "'," +
                    "'" + comboBoxIngenieroCliente.Text + "','1');";
            }
            else
                return "";
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
            Operacio_proyectos = "Modificar";
            Desactiva_botones_operacion();
            Desaparece_caja_captura_codigo_proyecto();
            Aparece_combo_codigo_proyecto();
            Activa_combo_codigo_proyecto();
            Obtener_datos_proyectos_disponibles_base_datos();
            Rellena_combo_codigo_proyecto();
            Aparece_boton_cancelar_operacio();
            No_aceptar_agregar_dibujos_proyecto();
            Activa_dataview_dibujos_proyecto();
            Desactiva_columna_numero_dibujo_datagrid();
            

        }

        private void Desactiva_columna_numero_dibujo_datagrid()
        {
           dataGridViewDibujosProyecto.Columns[(int)Campos_dibujos.numero].ReadOnly = true;
        }

        private void Activa_columna_numero_dibujo_datagrid()
        {
            dataGridViewDibujosProyecto.Columns[(int)Campos_dibujos.numero].ReadOnly = false;
        }

        private void buttonEliminarCliente_Click(object sender, EventArgs e)
        {
            Operacio_proyectos = "Eliminar";
            Desactiva_botones_operacion();
            Desaparece_caja_captura_codigo_proyecto();
            Aparece_combo_codigo_proyecto();
            Obtener_datos_proyectos_disponibles_base_datos();
            Rellena_combo_codigo_proyecto();
            Aparece_boton_cancelar_operacio();
            
        }

        private bool Elimina_informacion_proyecto_en_base_de_datos()
        {
            if (Elimina_datos_proyecto() && Elinina_dibujos_proyecto())
                return true;
            else
                return false;
        }

        private bool Elinina_dibujos_proyecto()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_ingenieria());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_eliminar_en_base_de_datos_dibujos_proyecto(), connection);
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

        private string Configura_cadena_comando_eliminar_en_base_de_datos_dibujos_proyecto()
        {
            return "DELETE from dibujos_proyecto where codigo_proyecto='" +
               comboBoxCodigoProyecto.Text + "';";
        }


        private bool Elimina_datos_proyecto()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_ingenieria());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_eliminar_en_base_de_datos_proyecto(), connection);
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
        private string Configura_cadena_comando_eliminar_en_base_de_datos_proyecto()
        {
            return "DELETE from proyectos where codigo_proyecto='" +
               comboBoxCodigoProyecto.Text + "';";
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
            Agrega_dibujo_proyecto();
        }

        private void Agrega_dibujo_proyecto()
        {
            Operacio_proyectos = "Agregar Dibujo";
            Desactiva_botones_operacion_contactos();
            limpia_dibujos_proyecto();
            Acepta_datagridview_agregar_renglones();
            Aparce_boton_guardar_base_datos();
            

        }

        private void Desactiva_botones_operacion_contactos()
        {
            Desactiva_boton_agregar_contactos();
            Desactiva_boton_eliminar_contactos();
        }

        private void Desactiva_boton_eliminar_contactos()
        {
            buttonEliminarDibujo.Enabled = false;
        }

        private void Desactiva_boton_agregar_contactos()
        {
            buttonAgregarDibujo.Enabled = false;
        }

        private void buttonBorrarBasedeDatos_Click(object sender, EventArgs e)
        {

            if (Operacio_proyectos == "Eliminar Dibujo")
                Elimina_dibujo_proyectos();
            else if (Operacio_proyectos == "Eliminar")
                Elimina_proyecto();
        }

        private void Elimina_dibujo_proyectos()
        {
            if (MessageBox.Show("Esta Seguro de Eiliminar el dibujo seleccionado?",
                "Eliminar dibujo proyecto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Elimina_informacion_dibujo_proyecto_en_base_de_datos())
                {
                    Desaparece_boton_eliminar_base_de_datos();
                    Activa_botones_operacion_contactos();
                    limpia_dibujos_proyecto();
                    Obtener_datos_dibujos_proyectos_disponibles_base_datos(comboBoxCodigoProyecto.Text);
                    Rellena_cajas_informacion_de_dibujos_proyecto();
                    limpia_texto_eliminar_contacto();
                }
            }
            
        }

        private void limpia_texto_eliminar_contacto()
        {
            RenglonParaEliminar = "";
        }

        private bool Elimina_informacion_dibujo_proyecto_en_base_de_datos()
        {
            if (Elimina_dibujo_proyecto_seleccionado())
                return true;
            else
                return false;
        }

        private bool Elimina_dibujo_proyecto_seleccionado()
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
            return "DELETE from dibujos_proyecto where codigo_dibujo='" +
                RenglonParaEliminar + "';";
        }

        private void Elimina_proyecto()
        {
            if (MessageBox.Show("Esta Seguro de Eiliminar Este Proyecto Incluyendo Todos sus Dibujos?",
                "Eliminar Proyecto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Elimina_informacion_proyecto_en_base_de_datos())
                {
                    Limpia_cajas_captura_despues_de_agregar_proyecto();
                    Limpia_combo_codigo_cotizacion();
                    Desactiva_cajas_captura_despues_de_agregar_proyecto();
                    Desaparece_boton_eliminar_base_de_datos();
                    Desaparece_boton_cancelar();
                    Desaparece_combo_codigo_cotizacion();
                    Activa_botones_operacion();
                    limpia_dibujos_proyecto();
                    Desactiva_datagridview_dibujos();
                    Elimina_informacion_proyectos_disponibles();
                    Aparce_caja_codigo_cliente(); Limpia_cajas_captura_despues_de_agregar_proyecto();

                    Limpia_combo_codigo_cotizacion();
                    Limpia_combo_nombre_cliente();
                    Limpia_combo_ingenieros_coset();
                    Limpia_combo_ingeniero_cliente();
                    Limpia_combo_proyecto();

                    Desactiva_cajas_captura_despues_de_agregar_proyecto();
                    Desaparece_boton_guardar_base_de_datos();
                    Desaparece_boton_cancelar();

                    Desaparece_combo_codigo_cotizacion();
                    Desaparece_combo_cliente_nombre();
                    Desaparece_combo_ingenieros_coset();
                    Desaparece_combo_ingenieros_cliente();
                    Desaparece_combo_codigo_proyecto();

                    Activa_botones_operacion();
                    limpia_dibujos_proyecto();
                    Desactiva_datagridview_dibujos();

                    Desactiva_combo_cliente_nombre();
                    Desactiva_combo_codigo_cotizacion();
                    Desactiva_combo_ingeniero_coset();
                    Desactiva_combo_ingenieros_cliente();
                    Desactiva_combobox_codigo_proyecto();

                    Aparece_textbox_nombre_cliente();
                    Aparece_textbox_codigo_cotizacion();
                    Aparece_textbox_ingeniero_coset();
                    Aparece_textbox_ingeniero_cliente();
                    Aparece_textbox_codigo_proyecto();

                    Elimina_informacion_proyectos_disponibles();
                }
            }
        }

        private void Desaparece_boton_eliminar_base_de_datos()
        {
            buttonBorrarBasedeDatos.Visible = false;
        }

        private void buttonEliminarContacto_Click(object sender, EventArgs e)
        {
            Elimina_dibujo_proyecto();
        }

        private void Elimina_dibujo_proyecto()
        {
            Desactiva_botones_operacion_contactos();
            No_aceptar_agregar_dibujos_proyecto();
            Operacio_proyectos = "Eliminar Dibujo";
        }

        private void buttonAgregarContacto_Click(object sender, EventArgs e)
        {
            Agrega_dibujo_proyecto();
        }

        private void buttonContactos_Click(object sender, EventArgs e)
        {
            Dibujos_operaciones();
        }

        private void Dibujos_operaciones()
        {
            Operacio_proyectos = "Operaciones Dibujos";
            Desactiva_botones_operacion();
            Desaparece_caja_captura_codigo_proyecto();
            Aparece_combo_codigo_proyecto();
            Activa_combo_codigo_proyecto();
            Obtener_datos_proyectos_disponibles_base_datos();
            Rellena_combo_codigo_proyecto();
            Aparece_boton_cancelar_operacio();
            No_aceptar_agregar_dibujos_proyecto();
            Activa_dataview_dibujos_proyecto();
            Activa_columna_numero_dibujo_datagrid();
            Activa_botones_operacion_contactos();

        }

        private void Aparece_boton_eliminar_dibujo()
        {
            buttonEliminarDibujo.Visible = true;
        }

        private void Aparece_boton_agregar_dibujo()
        {
            buttonAgregarDibujo.Visible = true;
        }


        private void dataGridViewDibujosProyecto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Operacio_proyectos == "Eliminar Dibujo")
            {
                Aparece_boton_eliminar_datos_en_base_de_datos();
                RenglonParaEliminar=dataGridViewDibujosProyecto.Rows[e.RowIndex].Cells["Codigo_proyecto"].Value.ToString();
            }
           
        }

        private void dataGridViewDibujosProyecto_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Operacio_proyectos == "Agregar Proyecto" || Operacio_proyectos == "Modificar" ||
                Operacio_proyectos == "Agregar Dibujo" || Operacio_proyectos == "Agregar SubProyecto")/*verifica si esta agregando Partidas*/
            {
                if (dataGridViewDibujosProyecto.CurrentCell.ColumnIndex == (int)Campos_dibujos.tiempo_estimado) /*verifica si esta modificando el precio*/
                {
                    try
                    {
                        /*Valida Numeros en la caja de horas estimadas*/
                        Convert.ToSingle(dataGridViewDibujosProyecto[e.ColumnIndex, e.RowIndex].Value.ToString());
                        dataGridViewDibujosProyecto[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;


                    }
                    catch
                    {
                        /* en caso de error limpia la caja de precio*/
                        dataGridViewDibujosProyecto[(int)Campos_dibujos.tiempo_estimado, e.RowIndex].Value = "";
                    }

                }
                else if (dataGridViewDibujosProyecto.CurrentCell.ColumnIndex == (int)Campos_dibujos.cantidad)
                {
                    try
                    {
                        /*Valida Numeros en la caja cantidad*/
                        Convert.ToSingle(dataGridViewDibujosProyecto[e.ColumnIndex, e.RowIndex].Value.ToString());
                        dataGridViewDibujosProyecto[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                    }
                    catch
                    {
                        /* en caso de error limpia la cantidad*/
                        dataGridViewDibujosProyecto[(int)Campos_dibujos.cantidad, e.RowIndex].Value = "";
                    }

                }
                else if (dataGridViewDibujosProyecto.CurrentCell.ColumnIndex == (int)Campos_dibujos.numero)
                {
                    if (dataGridViewDibujosProyecto[e.ColumnIndex, e.RowIndex].Value != null)
                    {
                        if (dataGridViewDibujosProyecto[e.ColumnIndex, e.RowIndex].Value.ToString() != "")
                        {
                            dataGridViewDibujosProyecto[e.ColumnIndex, e.RowIndex]
                            .Style.BackColor = Color.White;
                        }
                    }
                }
                else if (dataGridViewDibujosProyecto.CurrentCell.ColumnIndex == (int)Campos_dibujos.descripcion)
                {
                    if (dataGridViewDibujosProyecto[e.ColumnIndex, e.RowIndex].Value != null)
                    {
                        if (dataGridViewDibujosProyecto[e.ColumnIndex, e.RowIndex].Value.ToString() != "")
                        {
                            dataGridViewDibujosProyecto[e.ColumnIndex, e.RowIndex]
                            .Style.BackColor = Color.White;
                        }
                    }
                }
            }
        }

        private void comboBoxNombreCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Operacio_proyectos == "Modificar")
            {
                Limpia_combo_ingeniero_cliente();
            }
            else if (Operacio_proyectos.Contains("Agregar"))
            {
                Limpia_combo_ingenieros_coset();
                Limpia_combo_ingeniero_cliente();
            }
            else if(Operacio_proyectos == "Visualizar")
            {
                Rellena_combo_codigo_nombre_proyecto_por_cliente();
            }

            if (Operacio_proyectos == "Modificar" || Operacio_proyectos.Contains("Agregar"))
            {
                Asigna_textbox_codigo_cliente();
                Desaparece_textbox_ingeniero_cliente();
                Aparecer_combo_ingeniero_cliente();
                Activa_combo_ingeniro_cliente();
                Obtener_contactos_cliente_disponibles();
                Rellena_combo_contactos_clientes();

                Desaparece_textbox_ingeniero_coset();
                Aparece_combo_ingeniero_coset();
                Activa_Combo_ingeniero_coset();
                Obtener_ingenieros_coset_disponibles();
                Rellenar_combo_ingenieros_coset();
            }

        }

        private void Rellena_combo_codigo_nombre_proyecto_por_cliente()
        {
            Limpia_combo_nombre_proyecto();
            Limpia_combo_proyecto();
            textBoxNombreCliente.Text = comboBoxNombreCliente.Text;
            Desaparece_combo_cliente_nombre();
            foreach (Proyecto proyecto in proyectos_disponibles)
            {
                if (proyecto.error == "")
                {

                    if (proyecto.Nombre_cliente == comboBoxNombreCliente.Text)
                    {
                        comboBoxNombreProyecto.Items.Add(proyecto.Nombre);
                        comboBoxCodigoProyecto.Items.Add(proyecto.Codigo);

                    }
                }
                else
                {
                    MessageBox.Show(proyecto.error);
                    break;
                }
            }
        }

        private void Asigna_textbox_codigo_cliente()
        {
            Cliente_seleccionado = clientes_disponibles.Find(clientes =>
             clientes.Nombre.Contains(comboBoxNombreCliente.SelectedItem.ToString()));
            textBoxCodigoCliente.Text = Cliente_seleccionado.Codigo;
        }

        private void Rellenar_combo_ingenieros_coset()
        {
            foreach (Usuario contacto in ingenieros_disponibles)
            {
                if (contacto.error == "")
                {
                    comboBoxIngenieroCoset.Items.Add(contacto.nombre_empleado);
                }
                else
                {
                    MessageBox.Show(contacto.error);
                    break;
                }

            }
        }

        private void Obtener_ingenieros_coset_disponibles()
        {
            ingenieros_disponibles = clase_usuarios.Adquiere_ingenieros_disponibles_en_base_datos();
        }

        private void Activa_Combo_ingeniero_coset()
        {
            comboBoxIngenieroCoset.Enabled = true;
        }

        private void Aparece_combo_ingeniero_coset()
        {
            comboBoxIngenieroCoset.Visible = true;
        }

        private void Desaparece_textbox_ingeniero_coset()
        {
            textBoxIngenieroCoset.Visible = false;
        }

        private void Rellena_combo_contactos_clientes()
        {
            foreach (Contacto_cliente contacto in contactos_cliente_disponibles)
            {
                if (contacto.error == "")
                {
                    comboBoxIngenieroCliente.Items.Add(contacto.Nombre);
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
            Desaparece_caja_captura_codigo_proyecto();
            Aparece_combo_codigo_cotizacion();
            Activa_combo_codigo_cotizacion();
            Obtener_datos_cotizaciones_disponibles_base_datos();
            Rellena_combo_codigo_cotizacion();
            Aparece_boton_cancelar_operacio();
            No_aceptar_agregar_dibujos_proyecto();
            Activa_dataview_dibujos_proyecto();
            Operacio_proyectos = "Copiar";
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
            nombre_archivo_word = @appPath + "\\" + comboBoxCodigoProyecto.Text + ".docx";
        }

        

        private void Visible_instancia_word()
        {
            application.Visible = true;
           
        }

        private void Copiar_template_a_cotizacion_espanol()
        {
            try
            {
                File.Copy(@appPath + "\\Quote_Coset_Template_Espanol.docx", @appPath + "\\" + comboBoxCodigoProyecto.Text + ".docx", false);
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
            for (int partida = dataGridViewDibujosProyecto.Rows.Count +1; partida <= 5; partida++)
            {
                Remplaza_texto_en_Documento("<item" + partida + ">",
                    "");
                Remplaza_texto_en_Documento("<description" + partida + ">",
                    "");
                Remplaza_texto_en_Documento("<price" + partida + ">",
                 "");
                

            }
        }

        private void Rellena_partidas_cotizacion()
        {
            Single importe = 0;
            if (dataGridViewDibujosProyecto.Rows.Count <= 5)
            {
                for (int partida = 1; partida <= dataGridViewDibujosProyecto.Rows.Count; partida++)
                {
                    Remplaza_texto_en_Documento("<item" + partida + ">",
                        dataGridViewDibujosProyecto[(int)Campos_dibujos.cantidad, partida - 1].Value.ToString());
                    Remplaza_texto_en_Documento("<description" + partida + ">",
                        dataGridViewDibujosProyecto[(int)Campos_dibujos.descripcion, partida - 1].Value.ToString());
                    importe = Convert.ToSingle(dataGridViewDibujosProyecto[(int)Campos_dibujos.proceso, partida - 1].Value.ToString());
                    Remplaza_texto_en_Documento("<price" + partida + ">",
                     importe.ToString("C"));
                   
                }
            }
            else
            {
                MessageBox.Show("Esta Applicacion solo Puede desplegar Hasta 5 Partidas","Previo Cotizaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                File.Copy(@appPath + "\\Quote_Coset_Template_Ingles.docx", @appPath + "\\" + comboBoxCodigoProyecto.Text + ".docx", false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Rellena_combo_procesos_datagridview_dibujos()
        {
            procesos_disponibles = Class_Procesos.Adquiere_procesos_disponibles_en_base_datos();
            foreach(Proceso_electricos proceso in procesos_disponibles)
            {
                Proceso_dibujo.Items.Add(proceso.Nombre);
            }

        }

        private void dataGridViewDibujosProyecto_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (Operacio_proyectos == "Agregar Proyecto" || Operacio_proyectos == "Agregar Dibujo" ||
                Operacio_proyectos == "Agregar SubProyecto")
            {
                dataGridViewDibujosProyecto.Rows[e.RowIndex].
                           Cells["Cantidad_dibujos"].Style.BackColor = Color.Yellow;
                dataGridViewDibujosProyecto.Rows[e.RowIndex].
                          Cells["Dibujo_proyecto"].Style.BackColor = Color.Yellow;
                dataGridViewDibujosProyecto.Rows[e.RowIndex].
                          Cells["Descripcion_dibujo"].Style.BackColor = Color.Yellow;
                dataGridViewDibujosProyecto.Rows[e.RowIndex].
                          Cells["Descrpcion_partida"].Style.BackColor = Color.Yellow;

            }
        }

        private void comboBoxNombreProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Operacio_proyectos == "Visualizar")
            {
                configura_forma_visualizar_nombre_proyecto();
            }
        }

        private void configura_forma_visualizar_nombre_proyecto()
        {
            limpia_dibujos_proyecto();
            Desaparece_combo_cliente_nombre();
            Rellena_cajas_informacion_de_nombre_proyectos();
            Obtener_datos_dibujos_nombre_proyectos_disponibles_base_datos(textBoxCodigoProyecto.Text);
            Rellena_cajas_informacion_de_dibujos_proyecto();
        }

        private void Rellena_cajas_informacion_de_nombre_proyectos()
        {
            proyecto_visualizar = proyectos_disponibles.Find(proyecto => proyecto.Nombre.Contains(comboBoxNombreProyecto.SelectedItem.ToString()));
            Desaparece_combo_codigo_proyecto();
            Desactiva_combobox_codigo_proyecto();
            Limpia_combo_proyecto();
            Aparece_textbox_codigo_proyecto();
            textBoxCodigoProyecto.Text = proyecto_visualizar.Codigo;
            textBoxNombreCliente.Text = proyecto_visualizar.Nombre_cliente;
            textBoxIngenieroCoset.Text = proyecto_visualizar.Ingeniero_coset; ;
            textBoxIngenieroCliente.Text = proyecto_visualizar.Ingeriero_cliente;
            dateTimePickerFechaActual.Text = proyecto_visualizar.Fecha_inicio;
            dateTimePickerFechaEntrega.Text = proyecto_visualizar.Fecha_entrega;
            textBoxCodigoCliente.Text = proyecto_visualizar.Codigo_cliente;
            textBoxModelo.Text = proyecto_visualizar.Modelo;
            textBoxSerie.Text = proyecto_visualizar.Serie;
            textBoxCodigoOC.Text = proyecto_visualizar.Codigo_orden_compra;
            textBoxNombreProyecto.Text = proyecto_visualizar.Nombre;
            textBoxUbicacionDibujos.Text = proyecto_visualizar.Ubliacion_dibujos;
            textBoxCodigoCotizacion.Text = proyecto_visualizar.Codigo_cotizacion;
        }

        private void dataGridViewDibujosProyecto_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox combo = (ComboBox)e.Control;

                int valor = combo.SelectedIndex;
                combo.SelectedIndexChanged -= new EventHandler (combo_select_index_tipo_proceso);
                combo.SelectedIndexChanged += combo_select_index_tipo_proceso;
        }

    private void combo_select_index_tipo_proceso(object sender, EventArgs e)
    {
        object combo = new ComboBox();
        combo = ((ComboBox)sender).SelectedItem;
            int integer = dataGridViewDibujosProyecto.CurrentRow.Index;
        if (combo != null)
        {
            if (dataGridViewDibujosProyecto.CurrentCell.ColumnIndex == (int)Campos_dibujos.tipo_proceso)
            {

                    if (combo.ToString() == "Electrico")
                    {
                        limpia_combo_proceso_datagrid_dibujo_proyecto();
                    }
                    else if (combo.ToString() == "Mecanico")
                    {
                        
                        if (Proceso_dibujo.Items.Count != 0)
                        {
                            dataGridViewDibujosProyecto.Rows[dataGridViewDibujosProyecto.CurrentRow.Index]
                                .Cells["Proceso_dibujo"].Value = "";

                        }
                        limpia_combo_proceso_datagrid_dibujo_proyecto();
                        Rellena_combo_procesos_datagridview_dibujos();
                    }
            }
        }

    }

        private void limpia_combo_proceso_datagrid_dibujo_proyecto()
        {
            Proceso_dibujo.Items.Clear();
        }


        //private void comboBoxCodigoProyecto_TextChanged(object sender, EventArgs e)
        //{
        //    AutoCompleteStringCollection ListaDeValores = new AutoCompleteStringCollection();
        //    foreach(string item in  comboBoxCodigoProyecto.Items)
        //    {
        //        if (item.Contains(comboBoxCodigoProyecto.Text))
        //        {
        //            ListaDeValores.Add(item);
        //        }
        //    }

        //    comboBoxCodigoProyecto.AutoCompleteCustomSource = ListaDeValores;
        //}


    }
}
