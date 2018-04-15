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
    public partial class Forma_Entrada_Materiales : Form
    {

        public Class_Control_Folios class_folio_disponible = new Class_Control_Folios();
        public Control_folio folio_disponible = new Control_folio();
        public Datos_generales datos_generales = new Datos_generales();
        public Class_Datos_Generales Class_Datos_Generales = new Class_Datos_Generales();
        public List<Partida_requisicion> Partidas_requisiciones_disponibles_ordenes_compra_no_asignadas 
            = new List<Partida_requisicion>();
        public Class_Partidas_Requisiciones Class_partidas_requisiciones = new Class_Partidas_Requisiciones();
        public List<Proveedor> Proveedores_disponibles = new List<Proveedor>();
        public Class_Proveedores Class_proveedores = new Class_Proveedores();
        public Proveedor Proveedor_seleccionado = new Proveedor();
        public List<Contacto_proveedor> Contactos_proveedor_disponibles = new List<Contacto_proveedor>();
        public Class_Contactos_Proveedor Class_contactos_Proveedor = new Class_Contactos_Proveedor();
        public Contacto_proveedor Contacto_proveedor_seleccionado = new Contacto_proveedor();
        public Class_Usuarios class_Usuarios = new Class_Usuarios();
        public Usuario Usuario_requisitores = new Usuario();
        public List<Usuario> Usuarios_administrativos = new List<Usuario>();
        public Partida_orden_compra Partida_orden_compra_agregar = new Partida_orden_compra();
        public Partida_orden_compra Partida_orden_compra_modificar = new Partida_orden_compra();
        public Class_Datos_Generales Class_datos_generales = new Class_Datos_Generales();
        public Datos_generales datos_Generales = new Datos_generales();
        public List<Orden_compra> ordenes_compra_disponibles = new List<Orden_compra>();
        public Class_Ordenes_Compra Class_ordenes_compra = new Class_Ordenes_Compra();
        public Orden_compra orden_compra_visualizar = new Orden_compra();
        public Orden_compra orden_compra_modificar = new Orden_compra();
        public List<Partida_orden_compra> partidas_ordenes_compra_disponibles = 
            new List<Partida_orden_compra>();
        public Class_Partidas_Orden_compra class_partidas_Orden_compra = new Class_Partidas_Orden_compra();
        public Proveedor Proveedor_modificaciones = new Proveedor();
        public List<Partida_requisicion> Partidas_requisiciones_disponibles_numero_parte
            = new List<Partida_requisicion>();
        string RenglonParaEliminar = "";
        string Requisicion_eliminar = "";
        string Descripcion_eleiminar = "";
        string appPath = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
        public CultureInfo cultureInfo = new CultureInfo("en-US");
        public string nombre_archivo_word = "";
        public word.Application application = null;
        public word.Document Documento = null;
        public enum Campos_orden_compra
        {
            codigo, partida, requisicion, cantidad, parte,descrpcion,unidad_medida,
            proyecto,precio, total
        };

        public string Operacio_orden_compra = "";

        public Forma_Entrada_Materiales()
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
            comboBoxDescripcionMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBoxDescripcionMaterial.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxDescripcionMaterial.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        
        private void buttonHome_Click(object sender, EventArgs e)
        {
 
            class_folio_disponible = null;
            folio_disponible = null;
            Usuarios_administrativos = null;
            Contactos_proveedor_disponibles = null;
            Partidas_requisiciones_disponibles_ordenes_compra_no_asignadas = null;
            Proveedores_disponibles = null;
            Contactos_proveedor_disponibles = null;
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

        
        private void Visualiza_orden_compra()
        {
            Desactiva_botones_operacion();
            Desaparece_caja_captura_codigo_orden_compra();
            Aparece_boton_cancelar_operacio();
            No_aceptar_agregar_partidas_ordenes_compra();
            Activa_dataview_partidas_ordenes_compra();
            limpia_combo_ordenes_compra();
            Aparece_combo_orden_compra();
            Activa_combo_orden_compra();
            obtener_ordenes_compra_disponibles();
            Rellenar_combo_ordenes_compra();
            Operacio_orden_compra = "Visualizar";
        }

        private void Rellenar_combo_ordenes_compra()
        {
            foreach (Orden_compra orden in ordenes_compra_disponibles)
            {
                if (orden.error == "")
                {
                    comboBoxCodigoOrdenCompra.Items.Add(orden.Codigo);
                }
                else
                {
                    MessageBox.Show(orden.error);
                    break;
                }
            }
        }

        private void obtener_ordenes_compra_disponibles()
        {
            ordenes_compra_disponibles = Class_ordenes_compra.Adquiere_ordenes_compra_disponibles_en_base_datos();
        }

        private void Activa_combo_orden_compra()
        {
            comboBoxCodigoOrdenCompra.Enabled = true;
        }

        private void Aparece_combo_orden_compra()
        {
            comboBoxCodigoOrdenCompra.Visible = true;
        }

        private void limpia_combo_ordenes_compra()
        {
            comboBoxCodigoOrdenCompra.Items.Clear();
            comboBoxCodigoOrdenCompra.Text = "";
        }

        private void Activa_dataview_partidas_ordenes_compra()
        {
            dataGridViewPartidasOrdenCompra.Enabled = true;
        }

        private void limpia_partidas_ordenes_compra()
        {
            dataGridViewPartidasOrdenCompra.Rows.Clear();
        }

        private void No_aceptar_agregar_partidas_ordenes_compra()
        {
            dataGridViewPartidasOrdenCompra.AllowUserToAddRows = false;
        }

        private void Aparece_boton_cancelar_operacio()
        {
            buttonCancelar.Visible = true;
        }

        private void Obtener_datos_partidas_ordenes_compra_disponibles_base_datos(string codigo_orden_compra)
        {
            partidas_ordenes_compra_disponibles = class_partidas_Orden_compra.Adquiere_partidas_ordenes_compra_disponibles_en_base_datos(codigo_orden_compra);
        }

        private void Desaparece_caja_captura_codigo_orden_compra()
        {
            textBoxCodigoOrdenCompra.Visible = false;
        }

        private void Desactiva_botones_operacion()
        {
            Desactiva_boton_agregar_cotizacion();
            Desactiva_boton_visualizar_cotizacion();

        }




        private void Desactiva_boton_visualizar_cotizacion()
        {
            buttonBuscarOrdenCompra.Enabled = false;
        }





        private void Desactiva_boton_agregar_cotizacion()
        {
            buttonAgregarCotizacion.Enabled = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Termina_secuencia_operaciones_ordenes_compra();
        }




        private void Limpia_textbox_divisa()
        {
            textBoxTotalUnidades.Text = "";
        }


        private void Limpia_combo_atencion()
        {
            comboBoxDescripcionMaterial.Items.Clear();
            comboBoxDescripcionMaterial.Text = "";
        }

        private void Limpia_combo_nombre_cliente()
        {
            comboBoxEmpleado.Items.Clear();
            comboBoxEmpleado.Text = "";
        }

        private void Aparece_caja_codigo_empleado()
        {
            textBoxCodigoOrdenCompra.Visible = true;
        }

        private void configura_forma_copiar()
        {
            limpia_partidas_ordenes_compra();
            Rellena_cajas_informacion_de_orden_compra();
            Obtener_datos_partidas_ordenes_compra_disponibles_base_datos(comboBoxCodigoOrdenCompra.Text);
            Rellena_cajas_informacion_de_partidas_orden_compra();
            Aparce_boton_guardar_base_datos();
        }

        private void configura_forma_agregar()
        {
            Aparecer_combo_descripcion_materiales();
            Activa_combo_descripcion_materiales();
            Desaparece_textbox_descripcion_materiales();
            Obtener_materiales_ordenes_compra();
            Rellena_combo_descripcion_materiales();
            //Desactiva_combobox_codigo_orden_compra();
            //Desaparece_textbox_requisitor();
            //Aparece_combo_empleado();
            //Activa_combo_empleado();
        }

        private void Obtener_materiales_ordenes_compra()
        {
            partidas_ordenes_compra_disponibles= class_partidas_Orden_compra.
                Adquiere_partidas_ordenes_compra_disponibles_en_base_datos(comboBoxCodigoOrdenCompra.Text);
        }

        private void Rellena_combo_descripcion_materiales()
        {
            foreach ( Partida_orden_compra  partida in partidas_ordenes_compra_disponibles)
            {
                if (partida.error == "")
                    comboBoxDescripcionMaterial.Items.Add(partida.Descripcion);
                else
                {
                    MessageBox.Show(partida.error);
                    break;
                }
            }
        }

        private void Activa_combo_empleado()
        {
            comboBoxEmpleado.Enabled = true;
        }

        private void Aparece_combo_empleado()
        {
            comboBoxEmpleado.Visible = true;
        }

        private void Desaparece_textbox_requisitor()
        {
            textBoxEmpleado.Visible = false;
        }

        private void configura_forma_operaciones_partidas()
        {
            Desactiva_combobox_codigo_orden_compra();
            limpia_partidas_ordenes_compra();
            Rellena_cajas_informacion_de_orden_compra();
            Obtener_datos_partidas_ordenes_compra_disponibles_base_datos(comboBoxCodigoOrdenCompra.Text);
            Rellena_cajas_informacion_de_partidas_orden_compra();
         }

        private void configura_forma_visualizar()
        {
            limpia_partidas_ordenes_compra();
            Rellena_cajas_informacion_de_orden_compra();
            Obtener_datos_partidas_ordenes_compra_disponibles_base_datos(comboBoxCodigoOrdenCompra.Text);
            Rellena_cajas_informacion_de_partidas_orden_compra();

        }


        private void Rellena_cajas_informacion_de_partidas_orden_compra()
        {
            for(int partidas=0; partidas< partidas_ordenes_compra_disponibles.Count;partidas++)
            {
                
                if (partidas_ordenes_compra_disponibles[partidas].error == "")
                {
                    try
                    {
                        dataGridViewPartidasOrdenCompra.Rows.Add(
                            partidas_ordenes_compra_disponibles[partidas].Codigo.ToString(), 
                            partidas_ordenes_compra_disponibles[partidas].Partida,"", 
                            partidas_ordenes_compra_disponibles[partidas].Cantidad,  
                            partidas_ordenes_compra_disponibles[partidas].Parte, "",
                            partidas_ordenes_compra_disponibles[partidas].Unidad_medida, 
                            partidas_ordenes_compra_disponibles[partidas].Proyecto, 
                            partidas_ordenes_compra_disponibles[partidas].precio_unitario, 
                            partidas_ordenes_compra_disponibles[partidas].Total);
                        /*Rellena combo requisiciones partidas ordenes compra*/
                        DataGridViewComboBoxCell combo_codigo_requisicion = 
                            (DataGridViewComboBoxCell)dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[(int)Campos_orden_compra.requisicion];
                        combo_codigo_requisicion.Items.Clear();
                        combo_codigo_requisicion.Items.Add(partidas_ordenes_compra_disponibles[partidas].Requisicion);
                        combo_codigo_requisicion.Value = partidas_ordenes_compra_disponibles[partidas].Requisicion;
                        /* rellena combo numero de parte partidas ordenes compra*/
                        DataGridViewComboBoxCell combo_descrpcion =
                           (DataGridViewComboBoxCell)dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[(int)Campos_orden_compra.descrpcion];
                        combo_descrpcion.Items.Clear();
                        combo_descrpcion.Items.Add(partidas_ordenes_compra_disponibles[partidas].Descripcion);
                        combo_descrpcion.Value = partidas_ordenes_compra_disponibles[partidas].Descripcion;
                    }
                    catch
                    {

                    }
                    
                }
                else
                {
                    MessageBox.Show(partidas_ordenes_compra_disponibles[partidas].error);
                    break;
                }

            }

        }

        private void Rellena_cajas_informacion_de_partidas_orden_compra_modificaciones()
        {
            for (int partidas = 0; partidas < partidas_ordenes_compra_disponibles.Count; partidas++)
            {

                if (partidas_ordenes_compra_disponibles[partidas].error == "")
                {
                    try
                    {
                        dataGridViewPartidasOrdenCompra.Rows.Add(
                            partidas_ordenes_compra_disponibles[partidas].Codigo.ToString(),
                            partidas_ordenes_compra_disponibles[partidas].Partida, "",
                            partidas_ordenes_compra_disponibles[partidas].Cantidad,
                            partidas_ordenes_compra_disponibles[partidas].Parte, "",
                            partidas_ordenes_compra_disponibles[partidas].Unidad_medida,
                            partidas_ordenes_compra_disponibles[partidas].Proyecto,
                            partidas_ordenes_compra_disponibles[partidas].precio_unitario,
                            partidas_ordenes_compra_disponibles[partidas].Total);
                        /*Rellena combo requisiciones partidas ordenes compra*/
                        DataGridViewComboBoxCell combo_codigo_requisicion =
                            (DataGridViewComboBoxCell)dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[(int)Campos_orden_compra.requisicion];
                        combo_codigo_requisicion.Items.Clear();
                        combo_codigo_requisicion.Items.Add(partidas_ordenes_compra_disponibles[partidas].Requisicion);
                        combo_codigo_requisicion.Value = partidas_ordenes_compra_disponibles[partidas].Requisicion;
                        /* rellena combo descripcion partidas ordenes compra*/
                        Partidas_requisiciones_disponibles_numero_parte = Class_partidas_requisiciones.
                            Adquiere_partidas_requisiciones_disponibles_numero_parte_en_base_datos(textBoxDescripcionMaterial.Text);

                        DataGridViewComboBoxCell combo_descripcion =
                           (DataGridViewComboBoxCell)dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[(int)Campos_orden_compra.descrpcion];
                        combo_descripcion.Items.Clear();
                        foreach(Partida_requisicion partida in Partidas_requisiciones_disponibles_numero_parte)
                        {
                            if (partidas_ordenes_compra_disponibles[partidas].Requisicion == partida.Codigo_requisicion)
                            {
                                combo_descripcion.Items.Add(partida.Descripcion);
                            }
                        }

                        combo_descripcion.Value = partidas_ordenes_compra_disponibles[partidas].Descripcion;
                    }
                    catch
                    {

                    }

                }
                else
                {
                    MessageBox.Show(partidas_ordenes_compra_disponibles[partidas].error);
                    break;
                }

            }

        }

        private void Rellena_cajas_informacion_de_orden_compra()
        {
            orden_compra_visualizar = ordenes_compra_disponibles.Find(orden_compra => orden_compra.Codigo.Contains(comboBoxCodigoOrdenCompra.SelectedItem.ToString()));

            textBoxCodigoProveedor.Text = orden_compra_visualizar.Cotizacion;
            dateTimePickerFechaActual.Text = orden_compra_visualizar.Fecha;
            textBoxDescripcionMaterial.Text = orden_compra_visualizar.Proveedor;
            Proveedor_seleccionado = Class_proveedores.Adquiere_proveedor_disponibles_en_base_datos(textBoxDescripcionMaterial.Text);
            textBoxEmpleado.Text = orden_compra_visualizar.Realizado;
           
            if (orden_compra_visualizar.Tipo_moneda == "Dolares")
            {
                textBoxTotalUnidades.Text = orden_compra_visualizar.Divisa;
                Desactiva_textbox_divisa();
            }
            else
            {
                textBoxTotalUnidades.Text = "";
            }

        }

        private void configura_forma_eliminar()
        {
            limpia_partidas_ordenes_compra();
            Rellena_cajas_informacion_de_orden_compra();
            Obtener_datos_partidas_ordenes_compra_disponibles_base_datos(comboBoxCodigoOrdenCompra.Text);
            Rellena_cajas_informacion_de_partidas_orden_compra();
            Aparece_boton_eliminar_datos_en_base_de_datos();
        }

        private void Aparece_boton_eliminar_datos_en_base_de_datos()
        {
            buttonBorrarBasedeDatos.Visible = true;
        }

        private void configura_forma_modificar()
        {

            limpia_partidas_ordenes_compra();
            Desaparece_textbox_realizado();
            Limpia_combo_empleado();
            Rellena_cajas_informacion_de_orden_compra_modificaciones();
            Obtener_contactos_proveedor_modificaciones();
            Desaparece_textbox_realizado();
            Aparece_combo_empleado();
            Activa_combo_empleado();
            obtener_usuarios_administrativos_compras_disponibles();
            Rellena_combo_empleado();
            Activa_seleccion_fecha_actual();
            Activa_textbox_codigo_proveedor();
            Activa_textbox_divisa();
            Obtener_datos_partidas_ordenes_compra_disponibles_base_datos(comboBoxCodigoOrdenCompra.Text);
            Rellena_cajas_informacion_de_partidas_orden_compra_modificaciones();
            Aparce_boton_guardar_base_datos();
        }



        private void Rellena_cajas_informacion_de_orden_compra_modificaciones()
        {
            orden_compra_modificar = ordenes_compra_disponibles.Find(orden_compra => orden_compra.Codigo.Contains(comboBoxCodigoOrdenCompra.SelectedItem.ToString()));

            textBoxCodigoProveedor.Text = orden_compra_modificar.Cotizacion;
            dateTimePickerFechaActual.Text = orden_compra_modificar.Fecha;
            textBoxDescripcionMaterial.Text = orden_compra_modificar.Proveedor;
            Proveedor_seleccionado = Class_proveedores.Adquiere_proveedor_disponibles_en_base_datos(textBoxDescripcionMaterial.Text);
            comboBoxEmpleado.Text = orden_compra_modificar.Realizado;
            if (orden_compra_modificar.Tipo_moneda == "Dolares")
            {
                textBoxTotalUnidades.Text = orden_compra_modificar.Divisa;
                Desactiva_textbox_divisa();
            }
            else
            {
                textBoxTotalUnidades.Text = "";
            }
        }

        private void Obtener_contactos_proveedor_modificaciones()
        {
            Proveedor_modificaciones = Class_proveedores.Adquiere_proveedor_disponibles_en_base_datos(textBoxDescripcionMaterial.Text);
            Contactos_proveedor_disponibles = Class_contactos_Proveedor.Adquiere_contactos_proveedores_disponibles_en_base_datos(Proveedor_modificaciones.Codigo);
        }


        private void Desaparece_textbox_realizado()
        {
            comboBoxEmpleado.Visible = false;
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

        private void Desactiva_combobox_codigo_orden_compra()
        {
            comboBoxCodigoOrdenCompra.Enabled = false;
        }

        private void buttonAgregarCotizacion_Click(object sender, EventArgs e)
        {
            Agrega_orden_compra();
        }

        private void Agrega_contactos_cliente()
        {
            throw new NotImplementedException();
        }

        private void Agrega_orden_compra()
        {
            
            Desactiva_botones_operacion();
            Acepta_datagridview_agregar_renglones();
            Aparece_boton_cancelar_operacio();
            Activa_datagridview_partidas_orden_compra();
            Activa_textbox_codigo_proveedor();
            limpia_combo_ordenes_compra();
            Aparece_combo_orden_compra();
            Activa_combo_orden_compra();
            obtener_ordenes_compra_disponibles();
            Rellenar_combo_ordenes_compra();
            Limpia_combo_empleado();
            Aparece_combo_empleado();
            Activa_combo_empleado();
            obtener_usuarios_administrativos_compras_disponibles();
            Rellena_combo_empleado();
            Activa_seleccion_fecha_actual();
            Operacio_orden_compra = "Agregar";
        }


        private void Obtener_datos_generales()
        {
            datos_Generales = Class_datos_generales.Obtener_informacion_datos_generales_base_datos();
        }

        private void Activa_seleccion_fecha_actual()
        {
            dateTimePickerFechaActual.Enabled = true;
        }

        private void Rellena_combo_empleado()
        {
            foreach (Usuario usuario in Usuarios_administrativos)
            {
                if (usuario.error == "")
                    comboBoxEmpleado.Items.Add(usuario.nombre_empleado);
                else
                {
                    MessageBox.Show(usuario.error);
                    break;
                }
            }
        }

        private void obtener_usuarios_administrativos_compras_disponibles()
        {
            Usuarios_administrativos = class_Usuarios.Adquiere_usuarios_disponibles_en_base_datos();
        }

        private void Limpia_combo_empleado()
        {
            comboBoxEmpleado.Items.Clear();
            comboBoxEmpleado.Text = "";
        }

        private void Activa_textbox_codigo_proveedor()
        {
            textBoxCodigoProveedor.Enabled = true;
        }

        private void Obtener_proveedores_disponibles()
        {
            Proveedores_disponibles = Class_proveedores.Adquiere_proveedores_disponibles_en_base_datos();
        }


        private void Aparecer_combo_descripcion_materiales()
        {
            comboBoxDescripcionMaterial.Visible = true;
        }

        private void Activa_combo_descripcion_materiales()
        {
            comboBoxDescripcionMaterial.Enabled = true;
        }

        private void Desaparece_textbox_descripcion_materiales()
        {
            textBoxDescripcionMaterial.Visible = false;
        }

        private void Asigna_codigo_orden_compra_foilio_disponible()
        {
            folio_disponible = class_folio_disponible.Obtener_informacion_control_folio_base_datos();
            textBoxCodigoOrdenCompra.Text = folio_disponible.Folio_oc;
        }

        private void Acepta_datagridview_agregar_renglones()
        {
            dataGridViewPartidasOrdenCompra.AllowUserToAddRows = true;
        }

        private void Activa_datagridview_partidas_orden_compra()
        {
            dataGridViewPartidasOrdenCompra.Enabled = true;
        }

        private void Desactiva_columna_codigo_partidas_cotizaciones()
        {
            dataGridViewPartidasOrdenCompra.Columns[0].Visible = false;
        }

        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_orden_compra()
        {
            timerAgregarOrdenCompra.Enabled = true;
        }

        private void Activa_cajas_informacion_cotizaciones()
        {
            textBoxEmpleado.Enabled = true;
            dateTimePickerFechaActual.Enabled = true;
            textBoxDescripcionMaterial.Enabled = true;
        }

        private void Modifica_contactos_cliente()
        {
            throw new NotImplementedException();
        }


        private void buttonGuardarBasedeDatos_Click(object sender, EventArgs e)
        {
            if (Operacio_orden_compra == "Agregar")
                Secuencia_agregar_orden_compra();
            else if (Operacio_orden_compra == "Modificar")
                Secuencia_modificar_orden_compra();
            else if (Operacio_orden_compra == "Agregar Partidas")
                Secuencia_agregar_partidas();
        }

        private bool Copia_datos_partidas_cotizacion()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_compras());
            try
            {
                connection.Open();
                for (int partidas = 0; partidas < dataGridViewPartidasOrdenCompra.Rows.Count; partidas++)
                {
                    for (int campo = 1; campo < dataGridViewPartidasOrdenCompra.Rows[partidas].Cells.Count; campo++)
                    {
                        if (dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value != null)
                        {
                            if (campo == (int)Campos_orden_compra.partida)
                                Partida_orden_compra_agregar.Partida = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_orden_compra.requisicion)
                                Partida_orden_compra_agregar.Requisicion = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_orden_compra.cantidad)
                                Partida_orden_compra_agregar.Cantidad = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_orden_compra.parte)
                                Partida_orden_compra_agregar.Parte = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_orden_compra.descrpcion)
                                Partida_orden_compra_agregar.Descripcion = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_orden_compra.unidad_medida)
                                Partida_orden_compra_agregar.Unidad_medida = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_orden_compra.proyecto)
                                Partida_orden_compra_agregar.Proyecto = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_orden_compra.precio)
                                Partida_orden_compra_agregar.precio_unitario = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_orden_compra.total)
                                Partida_orden_compra_agregar.Total = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString();
                        }

                        else
                        {
                            MessageBox.Show("campo en blanco");
                            connection.Close();
                            return false;
                        }
                    }
                    Asigna_codigo_orden_compra_para_tipo_de_operacio();
                    MySqlCommand command = new MySqlCommand(Configura_cadena_comando_insertar_en_base_de_datos_partidas_orden_compra(Partida_orden_compra_agregar), connection);
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
                if (Guarda_datos_partidas_orden_compra())
                {
                    Desaparece_boton_guardar_base_de_datos();
                     limpia_partidas_ordenes_compra();
                    Obtener_datos_partidas_ordenes_compra_disponibles_base_datos(comboBoxCodigoOrdenCompra.Text);
                    Rellena_cajas_informacion_de_partidas_orden_compra();
                    Elimina_informacion_orden_compra_disponibles();
                }
            }
        }



        private void Secuencia_modificar_orden_compra()
        {
            if (verifica_datos_partidas())
            {
                if (Modificar_datos_partidas_orden_compra())
                {
                    if (Modifica_datos_orden_compra())
                    {
                        Limpia_cajas_captura_despues_de_agregar_orden_compra();
                        Limpia_combo_nombre_cliente();
                        Limpia_combo_atencion();
                        Desactiva_cajas_captura_despues_de_agregar_orden_compra();
                        Desaparece_boton_guardar_base_de_datos();
                        Desaparece_boton_cancelar();
                        Desaparece_combo_codigo_cotizacion();
                        Aparce_caja_codigo_cliente();
                        Activa_botones_operacion();
                        limpia_partidas_ordenes_compra();
                        Desactiva_datagridview_partidas();
                        Desaparece_combo_cliente_nombre();
                        Desactiva_combo_cliente_nombre();
                        Desaparece_combo_atencion();
                        Desactiva_combo_atencion();
                        Aparece_textbox_nombre_cliente();
                        Aparece_textbox_nombre_cliente();
                        Aparece_textbox_atencion();
                        Elimina_informacion_orden_compra_disponibles();
                    }
                }
            }
        }


        private void Aparce_caja_codigo_cliente()
        {
            textBoxCodigoOrdenCompra.Visible = true;
        }

        private bool Modifica_datos_orden_compra()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_compras());
            try
            {
                connection.Open();
               // MySqlCommand command = new MySqlCommand(Configura_cadena_comando_modificar_en_base_de_datos_orden_compra(), connection);
                //command.ExecuteNonQuery();
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

       

        private bool Modificar_datos_partidas_orden_compra()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_compras());
            try
            {
                connection.Open();
                for (int partidas = 0; partidas < dataGridViewPartidasOrdenCompra.Rows.Count; partidas++)
                {
                    for (int campo = 0; campo < dataGridViewPartidasOrdenCompra.Rows[partidas].Cells.Count; campo++)
                    {
                        if (dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value != null)
                        {
                            if (campo == (int)Campos_orden_compra.codigo)
                                Partida_orden_compra_modificar.Codigo = Convert.ToInt32(dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString());
                            else if (campo == (int)Campos_orden_compra.partida)
                                Partida_orden_compra_modificar.Partida = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_orden_compra.requisicion)
                                Partida_orden_compra_modificar.Requisicion = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_orden_compra.cantidad)
                                Partida_orden_compra_modificar.Cantidad = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_orden_compra.parte)
                                Partida_orden_compra_modificar.Parte = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_orden_compra.descrpcion)
                                Partida_orden_compra_modificar.Descripcion = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_orden_compra.unidad_medida)
                                Partida_orden_compra_modificar.Unidad_medida = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_orden_compra.proyecto)
                                Partida_orden_compra_modificar.Proyecto = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_orden_compra.precio)
                                Partida_orden_compra_modificar.precio_unitario = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_orden_compra.total)
                                Partida_orden_compra_modificar.Total = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString();
                        }

                        else
                        {
                            MessageBox.Show("campo en blanco");
                            connection.Close();
                            return false;
                        }
                    }
                    MySqlCommand command = new MySqlCommand(Configura_cadena_comando_en_base_de_datos_modificar_partidas_orden_compra(Partida_orden_compra_modificar), connection);
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

        private string Configura_cadena_comando_en_base_de_datos_modificar_partidas_orden_compra(Partida_orden_compra partidas_orden_compra)
        {
            return "UPDATE partidas_oredenes_compra set  codigo_orden_compra='" + comboBoxCodigoOrdenCompra.Text +
                "',partida_compra='" + partidas_orden_compra.Partida +
                "',requisicion_compra='" + partidas_orden_compra.Requisicion +
                "',cantidad_compra='" + partidas_orden_compra.Cantidad +
                "',parte_compra='" + partidas_orden_compra.Parte +
                "',descripcion_compra='" + partidas_orden_compra.Descripcion +
                "',unidad_medida='" + partidas_orden_compra.Unidad_medida +
                "',proyecto_compra='" + partidas_orden_compra.Proyecto +
                "',precio_unitario='" + partidas_orden_compra.precio_unitario +
                "',total_compra='" + partidas_orden_compra.Total +
                "' where codigo_partida='" + partidas_orden_compra.Codigo + "';";
        }

        private void Secuencia_agregar_orden_compra()
        {
            if (verifica_datos_partidas())
            {
                
                    if (Guarda_datos_partidas_orden_compra())
                    {
                        if (Guarda_datos_orden_compra())
                        {
                            Limpia_cajas_captura_despues_de_agregar_orden_compra();
                            Limpia_combo_nombre_cliente();
                            Limpia_combo_atencion();
                            Desactiva_cajas_captura_despues_de_agregar_orden_compra();
                            Desaparece_boton_guardar_base_de_datos();
                            Desaparece_boton_cancelar();
                            Desaparece_combo_codigo_cotizacion();
                            Activa_botones_operacion();
                            limpia_partidas_ordenes_compra();
                            Desactiva_datagridview_partidas();
                            Desaparece_combo_cliente_nombre();
                            Desactiva_combo_cliente_nombre();
                            Desaparece_combo_atencion();
                            Desactiva_combo_atencion();
                            Aparece_textbox_nombre_cliente();
                            Aparece_textbox_nombre_cliente();
                            Aparece_textbox_atencion();
                            Asigna_nuevo_folio_orden_compra();
                            Elimina_informacion_orden_compra_disponibles();
                        }
                    }
            }

        }

        private bool verifica_datos_partidas()
        {
            for (int partidas = 0; partidas < dataGridViewPartidasOrdenCompra.Rows.Count - 1; partidas++)
            {
                for (int campo = 1; campo < dataGridViewPartidasOrdenCompra.Rows[partidas].Cells.Count; campo++)
                {
                    if (dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value == null)
                    {
                        MessageBox.Show("campo en blanco");
                        return false;
                    }

                }
            }
            return true;
        }

        private void Aparece_textbox_atencion()
        {
            textBoxDescripcionMaterial.Visible = true;
        }

        private void Aparece_textbox_nombre_cliente()
        {
            textBoxEmpleado.Visible = true;
        }

        private void Desactiva_combo_atencion()
        {
            comboBoxDescripcionMaterial.Enabled = false;
        }

        private void Desaparece_combo_atencion()
        {
            comboBoxDescripcionMaterial.Visible = false;
        }

        private void Desactiva_combo_cliente_nombre()
        {
            comboBoxEmpleado.Enabled = false;
        }

        private void Desaparece_combo_cliente_nombre()
        {
            comboBoxEmpleado.Visible = false;
        }

        private void Asigna_nuevo_folio_orden_compra()
        {
            int numero_folio = Convert.ToInt32(folio_disponible.Folio_oc.Substring(2, folio_disponible.Folio_oc.Length - 2));
            numero_folio++;
            folio_disponible.Folio_oc = folio_disponible.Folio_oc.Substring(0, 2) +numero_folio.ToString();
            string respuesta = class_folio_disponible.Actualiza_Control_folios_base_datos(folio_disponible);
            if (respuesta != "")
                MessageBox.Show(folio_disponible.error);
        }

        private void Desactiva_datagridview_partidas()
        {
            dataGridViewPartidasOrdenCompra.Enabled = false;
        }

        private void Elimina_informacion_orden_compra_disponibles()
        {
            Usuarios_administrativos = null;
            Contactos_proveedor_disponibles = null;
            Partidas_requisiciones_disponibles_ordenes_compra_no_asignadas = null;
            Proveedores_disponibles = null;
            Contactos_proveedor_disponibles = null;
            ordenes_compra_disponibles = null;
            partidas_ordenes_compra_disponibles = null;
            Partidas_requisiciones_disponibles_numero_parte = null;
            GC.Collect();
        }

        private void Activa_botones_operacion()
        {
            Activa_boton_agregar_ccotizacion();
            Activa_boton_visualizar_cotizacion();
        }


        private void Activa_boton_visualizar_cotizacion()
        {
            buttonBuscarOrdenCompra.Enabled = true;
        }

        private void Activa_boton_agregar_ccotizacion()
        {
            buttonAgregarCotizacion.Enabled = true;
        }

        private void Desaparece_combo_codigo_cotizacion()
        {
            comboBoxCodigoOrdenCompra.Visible = false;
        }

        private void Desaparece_boton_cancelar()
        {
            buttonCancelar.Visible = false;
        }

        private void Desaparece_boton_guardar_base_de_datos()
        {
            buttonGuardarBasedeDatos.Visible = false;
        }

        private void Desactiva_cajas_captura_despues_de_agregar_orden_compra()
        {
            textBoxEmpleado.Enabled = false;
            dateTimePickerFechaActual.Enabled = false;
            textBoxDescripcionMaterial.Enabled = false;
            textBoxCodigoProveedor.Enabled = false;

        }


        private void Limpia_cajas_captura_despues_de_agregar_orden_compra()
        {
            textBoxEmpleado.Text = "";
            textBoxCodigoOrdenCompra.Text = "";
            dateTimePickerFechaActual.Text = DateTime.Today.ToString();
            textBoxDescripcionMaterial.Text = "";
            textBoxCodigoProveedor.Text = "";

            textBoxTotalUnidades.Text = "";

        }

        private bool Guarda_datos_partidas_orden_compra()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_compras());
            try
            {
                connection.Open();
                for (int partidas = 0; partidas < dataGridViewPartidasOrdenCompra.Rows.Count - 1; partidas++)
                {
                    for (int campo = 1; campo < dataGridViewPartidasOrdenCompra.Rows[partidas].Cells.Count; campo++)
                    {
                        if (dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value != null)
                        {
                            if (campo == (int)Campos_orden_compra.partida)
                                Partida_orden_compra_agregar.Partida = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_orden_compra.requisicion)
                                Partida_orden_compra_agregar.Requisicion = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_orden_compra.cantidad)
                                Partida_orden_compra_agregar.Cantidad = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_orden_compra.parte)
                                Partida_orden_compra_agregar.Parte = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_orden_compra.descrpcion)
                                Partida_orden_compra_agregar.Descripcion = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_orden_compra.unidad_medida)
                                Partida_orden_compra_agregar.Unidad_medida = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_orden_compra.proyecto)
                                Partida_orden_compra_agregar.Proyecto = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_orden_compra.precio)
                                Partida_orden_compra_agregar.precio_unitario = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString();
                            else if (campo == (int)Campos_orden_compra.total)
                                Partida_orden_compra_agregar.Total = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells[campo].Value.ToString();
                        }

                        else
                        {
                            MessageBox.Show("campo en blanco");
                            connection.Close();
                            return false;
                        }
                    }
                    Asigna_codigo_orden_compra_para_tipo_de_operacio();
                    MySqlCommand command = new MySqlCommand(Configura_cadena_comando_insertar_en_base_de_datos_partidas_orden_compra(Partida_orden_compra_agregar), connection);
                    command.ExecuteNonQuery();
                    MySqlCommand command_requisiciones_orden_compra = new MySqlCommand(Configura_cadena_comando_actualizar_en_base_de_datos_partidas_requisiciones(Partida_orden_compra_agregar), connection);
                    command_requisiciones_orden_compra.ExecuteNonQuery();
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

        private string Configura_cadena_comando_actualizar_en_base_de_datos_partidas_requisiciones(Partida_orden_compra partida_orden_compra_agregar)
        {
            return "UPDATE partidas_requisiciones set  orden_compra_asignada='" + partida_orden_compra_agregar.Codigo_orden+
                "' where codigo_requisicion='" + partida_orden_compra_agregar.Requisicion + "' and numero_parte='" +
                partida_orden_compra_agregar.Parte+"' ;";
        }

        private void Asigna_codigo_orden_compra_para_tipo_de_operacio()
        {
            if (Operacio_orden_compra == "Agregar")
                Partida_orden_compra_agregar.Codigo_orden = textBoxCodigoOrdenCompra.Text;
            else if (Operacio_orden_compra == "Agregar Partidas" || Operacio_orden_compra == "Copiar")
                Partida_orden_compra_agregar.Codigo_orden = comboBoxCodigoOrdenCompra.Text;
        }

        private string Configura_cadena_comando_insertar_en_base_de_datos_partidas_orden_compra(Partida_orden_compra partida_orden_compra)
        {
            return "INSERT INTO partidas_oredenes_compra(codigo_orden_compra,partida_compra, requisicion_compra," +
                "cantidad_compra,parte_compra,descripcion_compra,unidad_medida,proyecto_compra,precio_unitario,total_compra) " +
                "VALUES('" + partida_orden_compra.Codigo_orden + "','" + partida_orden_compra.Partida + "','" +
                partida_orden_compra.Requisicion + "','" + partida_orden_compra.Cantidad + "','" + partida_orden_compra.Parte + "','" +
                partida_orden_compra.Descripcion + "','" + partida_orden_compra.Unidad_medida + "','" + partida_orden_compra.Proyecto + "','" +
                partida_orden_compra.precio_unitario + "','"+ partida_orden_compra.Total + "');";
        }

        private bool Guarda_datos_orden_compra()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_compras());
            try
            {
                connection.Open();
                //MySqlCommand command = new MySqlCommand(Configura_cadena_comando_insertar_en_base_de_datos_orden_compra(), connection);
                //command.ExecuteNonQuery();
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


        private string Configura_cadena_conexion_MySQL_compras()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=compras;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }





        private void Modifica_orden_compra()
        {
            Desactiva_botones_operacion();
            limpia_combo_ordenes_compra();
            Desaparece_caja_captura_codigo_orden_compra();
            obtener_ordenes_compra_disponibles();
            Aparece_boton_cancelar_operacio();
            Activa_dataview_partidas_ordenes_compra();
            No_aceptar_agregar_partidas_ordenes_compra();
            Aparece_combo_orden_compra();
            Activa_combo_orden_compra();
            obtener_ordenes_compra_disponibles();
            Rellenar_combo_ordenes_compra();
            Activa_dataview_partidas_ordenes_compra();
            Operacio_orden_compra = "Modificar";
        }

        private bool Elimina_informacion_orden_compra_en_base_de_datos()
        {
            return (Elimina_datos_orden_compra() && Elinina_partidas_orden_compra());
        }

        private bool Elinina_partidas_orden_compra()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_compras());
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
            return "DELETE from partidas_oredenes_compra where codigo_orden_compra='" +
               comboBoxCodigoOrdenCompra.Text + "';";
        }


        private bool Elimina_datos_orden_compra()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_compras());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_eliminar_en_base_de_datos_orden_compra(), connection);
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
        private string Configura_cadena_comando_eliminar_en_base_de_datos_orden_compra()
        {
            return "DELETE from ordenes_compra where codigo_orden_compra='" +
               comboBoxCodigoOrdenCompra.Text + "';";
        }

        private void timerModificarClientes_Tick(object sender, EventArgs e)
        {
            
        }


        
        private void Agrega_partida_orden_compra()
        {
            Operacio_orden_compra = "Agregar Partidas";
            limpia_partidas_ordenes_compra();
            Obtener_requisiciones_sin_orden_compra_asiganda_por_proveedor();
            Limpia_datagridview_ordenes_compra();
            Acepta_datagridview_agregar_renglones();
            Aparce_boton_guardar_base_datos();
        }


        private void buttonBorrarBasedeDatos_Click(object sender, EventArgs e)
        {

            if (Operacio_orden_compra == "Eliminar partida")
                Elimina_partida_orden_compra();
            else if (Operacio_orden_compra == "Eliminar")
                Elimina_orden_compra();
        }

        private void Elimina_partida_orden_compra()
        {
            if (MessageBox.Show("Esta Seguro de Eiliminar la partida orden de compra seleccionada?",
                "Eliminar partida orden de compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Actualiza_requisicion_orden_compra_asignada())
                {
                    if (Elimina_informacion_partida_orden_compra_en_base_de_datos())
                    {
                        if (Actualiza_requisicion_orden_compra_asignada())
                        {
                            Desaparece_boton_eliminar_base_de_datos();
                            limpia_partidas_ordenes_compra();
                            Obtener_datos_partidas_ordenes_compra_disponibles_base_datos(comboBoxCodigoOrdenCompra.Text);
                            Rellena_cajas_informacion_de_partidas_orden_compra();
                            limpia_texto_eliminar_pertida_orden_compra();
                            Desaparece_boton_eliminar_base_de_datos();
                        }
                    }
                }
            }
            
        }

        private bool Actualiza_requisicion_orden_compra_asignada()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_compras());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_modificar_en_base_de_datos_partida_cotizacion(), connection);
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

        private string Configura_cadena_comando_modificar_en_base_de_datos_partida_cotizacion()
        {
            return "UPDATE partidas_requisiciones set  orden_compra_asignada='No_Asignada'" +
               "where codigo_requisicion='" + Requisicion_eliminar + "' and "+
               "descripcion_requisicion= '" + Descripcion_eleiminar + "';";
        }

        private void limpia_texto_eliminar_pertida_orden_compra()
        {
            RenglonParaEliminar = "";
        }

        private bool Elimina_informacion_partida_orden_compra_en_base_de_datos()
        {
            return Elimina_partida_orden_compra_seleccionada();
        }

        private bool Elimina_partida_orden_compra_seleccionada()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_compras());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_eliminar_en_base_de_datos_partida_orden_compra(), connection);
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

        private string Configura_cadena_comando_eliminar_en_base_de_datos_partida_orden_compra()
        {
            return "DELETE from partidas_oredenes_compra where codigo_partida='" +
                RenglonParaEliminar + "';";
        }

        private string Configura_cadena_comando_eliminar_en_base_de_datos_partida_cotizacion()
        {
            return "DELETE from partidas_cotizaciones where codigo_partida='" +
                RenglonParaEliminar + "';";
        }

        private void Elimina_orden_compra()
        {
            if (MessageBox.Show("Esta Seguro de Eiliminar Esta Orden de Compra Incluyendo Todos sus partidas?",
                "Eliminar Orden de Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Modifica_requisiciones_orden_compra_asignada())
                {
                    if (Elimina_informacion_orden_compra_en_base_de_datos())
                    {
                        Limpia_cajas_captura_despues_de_agregar_orden_compra();
                        Desactiva_cajas_captura_despues_de_agregar_orden_compra();
                        Desaparece_boton_eliminar_base_de_datos();
                        Desaparece_boton_cancelar();
                        Desaparece_combo_codigo_cotizacion();
                        Activa_botones_operacion();
                        limpia_partidas_ordenes_compra();
                        Desactiva_datagridview_partidas();
                        Elimina_informacion_orden_compra_disponibles();
                        Aparce_caja_codigo_cliente();
                    }
                }
            }
        }

        private bool Modifica_requisiciones_orden_compra_asignada()
        {

            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_compras());
            try
            {
                connection.Open();
                for (int partidas = 0; partidas < dataGridViewPartidasOrdenCompra.Rows.Count; partidas++)
                {
                        if (dataGridViewPartidasOrdenCompra.Rows[partidas].Cells["Requisicion_compra"].Value != null &&
                            dataGridViewPartidasOrdenCompra.Rows[partidas].Cells["Descrpcion_partida"].Value != null)
                        {
                            Requisicion_eliminar = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells["Requisicion_compra"].Value.ToString();
                            Descripcion_eleiminar = dataGridViewPartidasOrdenCompra.Rows[partidas].Cells["Descrpcion_partida"].Value.ToString();
                            
                        }

                        else
                        {
                            MessageBox.Show("campo en blanco");
                            connection.Close();
                            return false;
                        }

                        MySqlCommand command = new MySqlCommand(Configura_cadena_comando_modificar_en_base_de_datos_partida_cotizacion(), connection);
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
            Operacio_orden_compra = "Eliminar partida";
            No_aceptar_agregar_partidas_ordenes_compra();
            
        }


        private void buttonContactos_Click(object sender, EventArgs e)
        {
            Partidas_operaciones();
        }

        private void Partidas_operaciones()
        {
            Desactiva_botones_operacion();
            Desaparece_caja_captura_codigo_orden_compra();
            Aparece_boton_cancelar_operacio();
            No_aceptar_agregar_partidas_ordenes_compra();
            Activa_dataview_partidas_ordenes_compra();
            limpia_combo_ordenes_compra();
            Aparece_combo_orden_compra();
            Activa_combo_orden_compra();
            obtener_ordenes_compra_disponibles();
            Rellenar_combo_ordenes_compra();
            Operacio_orden_compra = "Operaciones Patidas";
        }



        private void dataGridViewContactosClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Operacio_orden_compra == "Eliminar partida")
            {
                Aparece_boton_eliminar_datos_en_base_de_datos();
                RenglonParaEliminar=dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells["Codigo_partida"].Value.ToString();
            }
           
        }

        private void Rellena_combo_nombre_proveedor()
        {
            foreach (Proveedor proveedor in Proveedores_disponibles)
            {
                if (proveedor.error == "")
                {
                    comboBoxDescripcionMaterial.Items.Add(proveedor.Nombre);
                }
                else
                {
                    MessageBox.Show(proveedor.error);
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
            Desaparece_caja_captura_codigo_orden_compra();
            Aparece_boton_cancelar_operacio();
            No_aceptar_agregar_partidas_ordenes_compra();
            Activa_dataview_partidas_ordenes_compra();
            Operacio_orden_compra = "Copiar";
        }

        private void buttonWordPrevio_Click(object sender, EventArgs e)
        {
            if (Inicia_variables_word())
            {
                Asigna_nombre_archivo_para_analizar();
                Elimina_archivo();
                Copiar_template_a_orden_compra();
                Abrir_documento_word();
                Rellenar_campos_orden_compra();
                Visible_instancia_word();
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
            nombre_archivo_word = @appPath + "\\" + comboBoxCodigoOrdenCompra.Text + ".docx";
        }



        private void Visible_instancia_word()
        {
            application.Visible = true;
           
        }

        private void Copiar_template_a_orden_compra()
        {
            try
            {
                File.Copy(@appPath + "\\Orden_compra_Coset_template.docx", @appPath + "\\" + comboBoxCodigoOrdenCompra.Text + ".docx", false);
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

        private void Rellenar_campos_orden_compra()
        {
           Rellena_informacion_partidas_orden_compra_previo_word();
           Limpia_partidas_sin_informacion();
           Guardar_archivo_word();
        }


        private void Guardar_archivo_word()
        {
            Documento.Save();
        }

        private void Limpia_partidas_sin_informacion()
        {
            for (int partida = dataGridViewPartidasOrdenCompra.Rows.Count + 1; partida <= 16; partida++)
            {
                Remplaza_texto_en_Documento("<n" + partida + ">",
                        "");
                Remplaza_texto_en_Documento("<c" + partida + ">",
                    "");
                Remplaza_texto_en_Documento("<np" + partida + ">",
                   "");
                Remplaza_texto_en_Documento("<d" + partida + ">",
                    "");
                Remplaza_texto_en_Documento("<p" + partida + ">",
                 "");
                Remplaza_texto_en_Documento("<t" + partida + ">",
                 "");
                Remplaza_texto_en_Documento("<m" + partida + ">",
                "");

            }
        }

        private void Rellena_informacion_partidas_orden_compra_previo_word()
        {
            double importe = 0;
            double total = 0;
            double Total_partidas = 0;
            double iva_total = 0;
            if (dataGridViewPartidasOrdenCompra.Rows.Count <= 16)
            {
                for (int partida = 1; partida <= dataGridViewPartidasOrdenCompra.Rows.Count; partida++)
                {
                    Remplaza_texto_en_Documento("<n" + partida + ">",
                        dataGridViewPartidasOrdenCompra[(int)Campos_orden_compra.partida, partida - 1].Value.ToString());
                    Remplaza_texto_en_Documento("<c" + partida + ">",
                        dataGridViewPartidasOrdenCompra[(int)Campos_orden_compra.cantidad, partida - 1].Value.ToString());
                    Remplaza_texto_en_Documento("<np" + partida + ">",
                        dataGridViewPartidasOrdenCompra[(int)Campos_orden_compra.parte, partida - 1].Value.ToString());
                    Remplaza_texto_en_Documento("<d" + partida + ">",
                        dataGridViewPartidasOrdenCompra[(int)Campos_orden_compra.descrpcion, partida - 1].Value.ToString());
                    Remplaza_texto_en_Documento("<m" + partida + ">",
                       dataGridViewPartidasOrdenCompra[(int)Campos_orden_compra.unidad_medida, partida - 1].Value.ToString());
                    importe = Convert.ToDouble(dataGridViewPartidasOrdenCompra[(int)Campos_orden_compra.precio, partida - 1].Value.ToString());
                    Remplaza_texto_en_Documento("<p" + partida + ">",
                     importe.ToString("C"));
                    total = Convert.ToDouble(dataGridViewPartidasOrdenCompra[(int)Campos_orden_compra.total, partida - 1].Value.ToString());
                    Remplaza_texto_en_Documento("<t" + partida + ">",
                     total.ToString("C"));
                    Total_partidas += total;
                }
                datos_generales = Class_datos_generales.Obtener_informacion_datos_generales_base_datos();
                Remplaza_texto_en_Documento("<importe>",
                    Total_partidas.ToString("C"));
                Remplaza_texto_en_Documento("<iva>",
                    datos_generales.Iva);
                iva_total = (Convert.ToSingle(datos_generales.Iva)/100.0) * Total_partidas;
                Remplaza_texto_en_Documento("<iva_total>",
                    iva_total.ToString("C"));
                total = Total_partidas + iva_total;
                Remplaza_texto_en_Documento("<total>",
                   total.ToString("C"));

            }
            else
            {
                MessageBox.Show("Esta Applicacion solo Puede desplegar Hasta 16 Partidas", "Previo Ordenes Compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                File.Copy(@appPath + "\\Quote_Coset_Template_Ingles.docx", @appPath + "\\" + comboBoxCodigoOrdenCompra.Text + ".docx", false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void comboBoxNombreProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void Obtener_contactos_disponibles_proveedor()
        {
            Proveedor_seleccionado = Proveedores_disponibles.Find(proveedores => proveedores.Nombre.Contains(comboBoxDescripcionMaterial.SelectedItem.ToString()));

            Contactos_proveedor_disponibles = Class_contactos_Proveedor.Adquiere_contactos_proveedores_disponibles_en_base_datos(Proveedor_seleccionado.Codigo);
        }


        private void Limpia_datagridview_ordenes_compra()
        {
            dataGridViewPartidasOrdenCompra.Rows.Clear();
        }


        private void Obtener_requisiciones_sin_orden_compra_asiganda_por_proveedor()
        {
            if (Operacio_orden_compra == "Agregar" )
            {
                Partidas_requisiciones_disponibles_ordenes_compra_no_asignadas = Class_partidas_requisiciones.
                    Adquiere_partidas_requisiciones_disponibles_en_base_datos_orden_compra_no_asignadas(comboBoxDescripcionMaterial.Text);
            }
            else if (Operacio_orden_compra == "Operaciones Patidas" || Operacio_orden_compra == "Agregar Partidas")
            {
                Partidas_requisiciones_disponibles_ordenes_compra_no_asignadas = Class_partidas_requisiciones.
                    Adquiere_partidas_requisiciones_disponibles_en_base_datos_orden_compra_no_asignadas(textBoxDescripcionMaterial.Text);
            }
        }


        private void dataGridViewPartidasOrdenCompra_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == (int)Campos_orden_compra.requisicion && e.RowIndex >= 0) //check if combobox column
                {
                    if (dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        string selectedValue = dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        /*rellena combo numero de parte disponible para requisicio*/

                        DataGridViewComboBoxCell combo_descripcion = (DataGridViewComboBoxCell)dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[(int)Campos_orden_compra.descrpcion];
                        combo_descripcion.Items.Clear();
                        combo_descripcion.Value = "";
                        foreach (Partida_requisicion partida_requisicion in Partidas_requisiciones_disponibles_ordenes_compra_no_asignadas)
                        {
                            if (partida_requisicion.Codigo_requisicion == selectedValue)
                            {
                                combo_descripcion.Items.Add(partida_requisicion.Descripcion);
                            }

                        }
                    }
                }
                else if (e.ColumnIndex == (int)Campos_orden_compra.descrpcion && e.RowIndex >= 0) //check if combobox column
                {
                    if (Operacio_orden_compra == "Agregar" || Operacio_orden_compra == "Agregar Partidas")
                    {
                        if (dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                        {
                            string selectedValue = dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                            foreach (Partida_requisicion partida_requisicion in Partidas_requisiciones_disponibles_ordenes_compra_no_asignadas)
                            {
                                if (partida_requisicion.Descripcion == selectedValue)
                                {
                                    dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells["Cantidad_partida"].Value = partida_requisicion.Cantidad;
                                    dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells["Parte_partida"].Value = partida_requisicion.Numero;
                                    dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells["UnidadMedida_compra"].Value = partida_requisicion.Unidad_medida;
                                    dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells["Proyecto_compra"].Value = partida_requisicion.Proyecto;

                                }

                            }
                        }
                    }else if(Operacio_orden_compra == "Modificar")
                    {
                        if (dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                        {
                            string selectedValue = dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                            foreach (Partida_requisicion partida_requisicion in Partidas_requisiciones_disponibles_numero_parte)
                            {
                                if (partida_requisicion.Descripcion == selectedValue)
                                {
                                    dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells["Cantidad_partida"].Value = partida_requisicion.Cantidad;
                                    dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells["Parte_partida"].Value = partida_requisicion.Numero;
                                    dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells["UnidadMedida_compra"].Value = partida_requisicion.Unidad_medida;
                                    dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells["Proyecto_compra"].Value = partida_requisicion.Proyecto;

                                }

                            }
                        }
                    }
                }
                else if (e.ColumnIndex == (int)Campos_orden_compra.cantidad && e.RowIndex >= 0)
                {
                    if (dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        try
                        {
                            Convert.ToSingle(dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                        }
                        catch
                        {
                            dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                        }
                    }
                }
                else if (e.ColumnIndex == (int)Campos_orden_compra.partida && e.RowIndex >= 0)
                {
                    if (dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        try
                        {
                            Convert.ToSingle(dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                        }
                        catch
                        {
                            dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                        }
                    }

                }
                else if (e.ColumnIndex == (int)Campos_orden_compra.precio && e.RowIndex >= 0)
                {
                    if (dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        try
                        {
                            dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[(int)Campos_orden_compra.total].Value =
                                (Convert.ToSingle(dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) *
                                Convert.ToSingle(dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[(int)Campos_orden_compra.cantidad].Value)).ToString("####.##");

                        }
                        catch
                        {
                            dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                        }
                    }
                }
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }


        private void radioButtonDolares_CheckedChanged(object sender, EventArgs e)
        {
            Aparece_etiqueta_divisa();
            Aparece_textbox_divisa();
            Activa_textbox_divisa();
        }

        private void Activa_textbox_divisa()
        {
            textBoxTotalUnidades.Enabled = true;
        }

        private void Aparece_textbox_divisa()
        {
            textBoxTotalUnidades.Visible = true;
        }

        private void Aparece_etiqueta_divisa()
        {
            labeldivisa.Visible = true;
        }

        private void radioButtonPesos_CheckedChanged(object sender, EventArgs e)
        {
            Desaparece_etiqueta_divisa();
            Desaparece_textbox_divisa();
            Desactiva_textbox_divisa();

        }

        private void Desactiva_textbox_divisa()
        {
            textBoxTotalUnidades.Enabled = false;
        }

        private void Desaparece_textbox_divisa()
        {
            textBoxTotalUnidades.Visible = false;
        }

        private void Desaparece_etiqueta_divisa()
        {
            labeldivisa.Visible = false;
        }

        private void buttonBuscarOrdenCompra_Click(object sender, EventArgs e)
        {
            Visualiza_orden_compra();
        }

        private void comboBoxCodigoOrdenCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Operacio_orden_compra == "Agregar")
                configura_forma_agregar();
            else if (Operacio_orden_compra == "Visualizar")
                configura_forma_visualizar();

        }

        private void buttonAgregarPartida_Click(object sender, EventArgs e)
        {
            Agrega_partida_orden_compra();
        }

        private void dataGridViewPartidasOrdenCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Operacio_orden_compra == "Eliminar partida")
            {
                Aparece_boton_eliminar_datos_en_base_de_datos();
                RenglonParaEliminar = dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells["Codigo_partida"].Value.ToString();
                Requisicion_eliminar = dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells["Requisicion_compra"].Value.ToString();
                Descripcion_eleiminar = dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells["Descrpcion_partida"].Value.ToString();
            }
        }

        private void buttonEliminarCotizacion_Click(object sender, EventArgs e)
        {
            Desactiva_botones_operacion();
            Desaparece_caja_captura_codigo_orden_compra();
            Aparece_boton_cancelar_operacio();
            No_aceptar_agregar_partidas_ordenes_compra();
            Activa_dataview_partidas_ordenes_compra();
            limpia_combo_ordenes_compra();
            Aparece_combo_orden_compra();
            Activa_combo_orden_compra();
            obtener_ordenes_compra_disponibles();
            Rellenar_combo_ordenes_compra();
            Operacio_orden_compra = "Eliminar";
        }

        private void buttonModificarCotizacion_Click(object sender, EventArgs e)
        {
            Modifica_orden_compra();
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            if (Inicia_variables_word())
            {
                Asigna_nombre_archivo_para_analizar();
                Elimina_archivo();
                Copiar_template_a_orden_compra();
                Abrir_documento_word();
                Rellenar_campos_orden_compra();
                Guardar_archivo_word_en_ruta_en_datos_generales();
                Cierra_documento_word();
                Termina_secuencia_save_file();
            }
        }

        private void Termina_secuencia_operaciones_ordenes_compra()
        {
            Limpia_combo_nombre_cliente();
            Limpia_combo_atencion();
            Limpia_cajas_captura_despues_de_agregar_orden_compra();
            Desactiva_cajas_captura_despues_de_agregar_orden_compra();
            Desaparece_boton_guardar_base_de_datos();
            Desaparece_boton_cancelar();
            Desaparece_combo_codigo_cotizacion();
            Desaparece_combo_atencion();
            Desaparece_combo_codigo_cotizacion();
            Desaparece_combo_cliente_nombre();
            Activa_botones_operacion();
            limpia_partidas_ordenes_compra();
            Desactiva_datagridview_partidas();
            Aparece_caja_codigo_empleado();
            Aparece_textbox_atencion();
            Aparece_textbox_nombre_cliente();
            Acepta_datagridview_agregar_renglones();
            Cierra_documento_word();
            Elimina_archivo();
            Elimina_informacion_orden_compra_disponibles();

        }
        private void Termina_secuencia_save_file()
        {
            Termina_secuencia_operaciones_ordenes_compra();
        }

        private void Guardar_archivo_word_en_ruta_en_datos_generales()
        {
            string nombre_archivo = "";
            string nombre_folder = "";
            datos_generales = Class_Datos_Generales.Obtener_informacion_datos_generales_base_datos();
            nombre_archivo = datos_generales.folder_ordenes_compra.Replace("/", @"\") + @"\" + comboBoxCodigoOrdenCompra.Text + ".docx";
            nombre_folder = datos_generales.folder_ordenes_compra.Replace("/", @"\");
            if (Directory.Exists(nombre_folder))
            {
                if (!File.Exists(nombre_archivo))
                {
                    File.Copy(nombre_archivo_word, nombre_archivo, false);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Archivo ya existe, Quieres Reemplazarlo?,", "Copiar Orden de Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        File.Copy(nombre_archivo_word, nombre_archivo, true);
                    }
                }

            }
            else
            {
                MessageBox.Show("Folder No existe", "Copiar Orden de Compra", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
