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
using word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Diagnostics;
using System.Globalization;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace Coset_Sistema_Produccion
{
    public partial class Forma_Reporte_Dibujos_Proyecto : Form
    {
        public Class_Control_Folios class_folio_disponible = new Class_Control_Folios();
        public Control_folio folio_disponible = new Control_folio();
        public Datos_generales datos_generales = new Datos_generales();
        public Class_Datos_Generales Class_Datos_Generales = new Class_Datos_Generales();
        public List<Cliente> clientes_disponibles = new List<Cliente>();
        public Class_Clientes clase_clientes = new Class_Clientes();
        public List<Contacto_cliente> contactos_cliente_disponibles = new List<Contacto_cliente>();
        public Class_Contactos_Clientes clase_contactos_cliente = new Class_Contactos_Clientes();
        public List<Usuario> Ingenieros_disponibles = new List<Usuario>();
        public List<Usuario> Usuarios_disponibles = new List<Usuario>();
        public Class_Usuarios clase_usuarios = new Class_Usuarios();
        public Cliente Cliente_seleccionado = new Cliente();
        string appPath = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
        public CultureInfo cultureInfo = new CultureInfo("en-US");
        public string nombre_archivo_word = "";
        public word.Application application = null;
        public word.Document Documento = null;
        public Class_Proyectos Class_Proyectos = new Class_Proyectos();
        public List<Proyecto> proyectos_disponibles = new List<Proyecto>();
        public Proyecto proyecto_visualizar = new Proyecto();
        public Class_Salida_Material Class_salida_material = new Class_Salida_Material();
        public List<Salida_Material> Salida_materiales_disponibles = new List<Salida_Material>();
        public Salida_Material Busqueda_salida_material = new Salida_Material();
        public Class_Materiales Class_Materiales = new Class_Materiales();
        public Material Material_busqueda = new Material();
        public Material Material_seleccion = new Material();
        public Material Visualizar_material = new Material();
        public List<Material> Materiales_disponibles = new List<Material>();
        public Class_Ordenes_Compra Class_Ordenes_Compra = new Class_Ordenes_Compra();
        public List<Orden_compra> Ordenes_compra_disponibles = new List<Orden_compra>();
        public Orden_compra Orden_compra_seleccion = new Orden_compra();
        public Class_Partidas_Orden_compra class_Partidas_Orden_Compra = new Class_Partidas_Orden_compra();
        public List<Partida_orden_compra> Partidas_ordenes_compra_disponibles = new List<Partida_orden_compra>();
        public Partida_orden_compra Partida_orden_compra_seleccion = new Partida_orden_compra();
        public Partida_orden_compra Partida_orden_compra_busqueda = new Partida_orden_compra();
        public Class_Devolucion_Material Class_Devolucion_Material = new Class_Devolucion_Material();
        public List<Devolucion_Material> Material_devolucion_disponibles = new List<Devolucion_Material>();
        public Devolucion_Material Devolucion_Material_seleccion = new Devolucion_Material();
        public Devolucion_Material Devolucion_Material_busqueda = new Devolucion_Material();
        public List<Material> Materiales_disponibles_busqueda = new List<Material>();
        public Class_Dibujos_Proyecto Class_Dibujos_Proyecto = new Class_Dibujos_Proyecto();
        public List<Dibujos_proyecto> dibujos_Proyectos_disponibles = new List<Dibujos_proyecto>();
        public Dibujos_proyecto dibujos_Proyecto_busqueda = new Dibujos_proyecto();
        public Dibujos_proyecto dibujos_Proyecto_seleccion = new Dibujos_proyecto();
        public Class_Dibujos_Produccion Class_Dibujos_Produccion = new Class_Dibujos_Produccion();
        public List<Dibujo_produccion> dibujo_Produccions_disponibles = new List<Dibujo_produccion>();
        public List<Dibujo_produccion> dibujo_Produccions_filtros = new List<Dibujo_produccion>();
        public Dibujo_produccion dibujo_Produccion_busqueda = new Dibujo_produccion();
        public Dibujo_produccion dibujo_Produccion_seleccion = new Dibujo_produccion();
        public Class_Secuencia_Produccion Class_Secuencia_Produccion = new Class_Secuencia_Produccion();
        public List<Secuencia_produccion> secuencia_produccion_disponibles = new List<Secuencia_produccion>();
        public List<Secuencia_produccion> secuencia_produccion_filtros = new List<Secuencia_produccion>();


        public Excel.Application oXL = null;
        public Excel.Worksheet oSheet = null;
        public Excel.Workbook oWB = null;
        public string Archivo_Excel_nombre = "";

        public enum Campos_dibujos
        {
            codigo, cantidad, numero, descripcion,
            proceso, tiempo_estimado
        };

        public string Operacio_reporte_proyectos = "";

        public Forma_Reporte_Dibujos_Proyecto()
        {
            InitializeComponent();
        }

        private void Forma_Clientes_Load(object sender, EventArgs e)
        {

            Datos_gerenrales();
            Habilita_combo_para_aceptar_buscar_elemento_escribiendo_en_ventana();

        }

        private void Datos_gerenrales()
        {
            datos_generales = Class_Datos_Generales.Obtener_informacion_datos_generales_base_datos();
        }

        private void Habilita_combo_para_aceptar_buscar_elemento_escribiendo_en_ventana()
        {
            comboBoxCodigoProyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBoxCodigoProyecto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCodigoProyecto.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            class_folio_disponible = null;
            clientes_disponibles = null;
            contactos_cliente_disponibles = null;
            Ingenieros_disponibles = null;
            Usuarios_disponibles = null;
            proyectos_disponibles = null;
            folio_disponible = null;
            Salida_materiales_disponibles = null;
            Materiales_disponibles = null;
            Ordenes_compra_disponibles = null;
            Partidas_ordenes_compra_disponibles = null;
            Material_devolucion_disponibles = null;
            Materiales_disponibles_busqueda = null;
            dibujos_Proyectos_disponibles = null;
            dibujo_Produccions_disponibles = null;
            Cierra_archivo_Excel();
            Close_Excel();
            Termina_applicacion();
            Elimina_archivo_excel();
            oXL = null;
            oSheet = null;
            oWB = null;
            Archivo_Excel_nombre = "";
            this.Dispose();
            GC.Collect();
            this.Close();
        }


        private void Close_Excel()
        {
            try
            {
                oXL.Quit();
            }
            catch
            {

            }
        }
        private void Termina_applicacion()
        {
            try
            {
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(oXL);
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
            Desaparece_caja_captura_codigo_proyecto();
            Aparece_combo_codigo_proyecto();
            Activa_combo_codigo_proyecto();
            Obtener_datos_proyectos_disponibles_base_datos();
            Rellena_combo_codigo_proyecto();
            Aparece_boton_cancelar_operacio();
            No_aceptar_agregar_dibujos_proyecto();
            Activa_dataview_dibujos_proyecto();
            Operacio_reporte_proyectos = "Visualizar";
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

        }

        private void Activa_dataview_dibujos_proyecto()
        {
            dataGridViewReporteDibujosProyecto.Enabled = true;
        }

        private void limpia_datagrid_reporte_dibujos_proyecto()
        {
            dataGridViewReporteDibujosProyecto.Rows.Clear();
        }

        private void No_aceptar_agregar_dibujos_proyecto()
        {
            dataGridViewReporteDibujosProyecto.AllowUserToAddRows = false;
        }

        private void Aparece_boton_cancelar_operacio()
        {
            buttonCancelar.Visible = true;
        }


        private void Rellena_combo_codigo_proyecto()
        {
            foreach (Proyecto proyecto in proyectos_disponibles)
            {
                if (proyecto.error == "")
                {
                    comboBoxCodigoProyecto.Items.Add(proyecto.Codigo);
                    comboBoxNombreProyecto.Items.Add(proyecto.Nombre);
                }

                else
                {
                    MessageBox.Show(proyecto.error);
                    break;
                }
            }
        }


        private void Desaparece_caja_captura_codigo_proyecto()
        {
            textBoxCodigoProyecto.Visible = false;
        }

        private void Aparece_caja_captura_codigo_proyecto()
        {
            textBoxCodigoProyecto.Visible = true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Operacio_reporte_proyectos = "Cancelar";
            Desaparce_boton_cancelar();
            Limpia_cajas_captura_despues_de_agregar_proyecto();
            Limpia_combo_nombre_empleados();
            limpia_datagrid_reporte_dibujos_proyecto();
            Desactiva_datagridview_dibujos();
            Acepta_datagridview_agregar_renglones();
            Desaparece_cajas_etiquetas_reporte_proyectos();
            Deaparece_combo_label_empleado();
            Desaparece_elementos_reporte_materiales();
            Desactiva_timer_busqueda();
            Desaparece_boton_busqueda();
            Activa_botones_operacion();
            Cierra_archivo_Excel();
            Elimina_archivo_excel();
            Activa_boton_excel();
            Desaparece_boton_Excel();
            Desapare_combo_nombre_proyecto();
            Desaparece_textbox_codigo_proyecto();
            Desaparece_combos_label_fecha();
            limpia_combo_fecha_filtro();
            limpia_fechas_filtros();
            Termina_timer_fecha_filtros();
            Deaparece_boton_filtros();

            //Elimina_informacion_proyectos_disponibles();

        }

        private void limpia_fechas_filtros()
        {
            dateTimePickerFechaFinal.Value = DateTime.Now;
            dateTimePickerFechaInicio.Value = DateTime.Now;
        }

        private void limpia_combo_fecha_filtro()
        {
            comboBoxFechaFiltro.Text = "";
        }

        private void Desaparece_boton_busqueda()
        {
            buttonBusquedaBaseDatos.Visible = false;
        }

        private void Desactiva_timer_busqueda()
        {
            if (timerBusquedaFecha.Enabled)
                timerBusquedaFecha.Enabled = false;

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

        private void Desaparece_textbox_codigo_proyecto()
        {
            textBoxCodigoProyecto.Visible = false;
        }

        private void Desaparece_combo_codigo_proyecto()
        {
            comboBoxCodigoProyecto.Visible = false;
        }

        private void Aparece_caja_codigo_empleado()
        {
            textBoxCodigoProyecto.Visible = true;
        }


        private void Obtener_clientes_disponibles()
        {
            clientes_disponibles = clase_clientes.Adquiere_clientes_disponibles_en_base_datos();
        }

        private void Desaparece_textbox_nombre_cliente()
        {
            textBoxNombreCliente.Visible = false;
        }


        private void Rellena_cajas_informacion_de_proyectos_codigo()
        {
            proyecto_visualizar = proyectos_disponibles.Find(proyecto => proyecto.Codigo.Contains(comboBoxCodigoProyecto.SelectedItem.ToString()));
            textBoxNombreCliente.Text = proyecto_visualizar.Nombre_cliente;
            textBoxIngenieroCoset.Text = proyecto_visualizar.Ingeniero_coset; ;
            textBoxIngenieroCliente.Text = proyecto_visualizar.Ingeriero_cliente;
            textBoxCodigoCliente.Text = proyecto_visualizar.Codigo_cliente;
            textBoxNombreProyecto.Text = proyecto_visualizar.Nombre;

        }

        private void Aparece_boton_eliminar_datos_en_base_de_datos()
        {
            buttonBorrarBasedeDatos.Visible = true;
        }



        private void Aparce_boton_guardar_base_datos()
        {
            buttonGuardarBasedeDatos.Visible = true;
        }


        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos_modificar_clientes()
        {
            timerModificarClientes.Enabled = true;
        }

        private void Desactiva_combobox_codigo_proyecto()
        {
            comboBoxCodigoProyecto.Enabled = false;
        }


        private void Desapare_textbox_codigo_proyecto()
        {
            textBoxCodigoProyecto.Visible = false;
        }


        private void Obtener_contactos_cliente_disponibles()
        {
            Cliente_seleccionado = clientes_disponibles.Find(clientes => clientes.Nombre.Contains(textBoxCodigoCliente.Text));
            Obtener_datos_contactos_clientes_disponibles_base_datos(Cliente_seleccionado.Codigo);
        }

        private void Obtener_datos_contactos_clientes_disponibles_base_datos(string codigo_cliente)
        {
            contactos_cliente_disponibles = clase_contactos_cliente.Adquiere_contactos_cliente_disponibles_en_base_datos(codigo_cliente);
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
            dataGridViewReporteDibujosProyecto.AllowUserToAddRows = true;
        }

        private void Activa_datagridview_dibujos_proyecto()
        {
            dataGridViewReporteDibujosProyecto.Enabled = true;
        }

        private void Desactiva_columna_codigo_partidas_cotizaciones()
        {
            dataGridViewReporteDibujosProyecto.Columns[0].Visible = false;
        }

        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_proyecto()
        {
            timerAgregarProyecto.Enabled = true;
        }

        private void Activa_cajas_informacion_proyecto()
        {
            textBoxNombreCliente.Enabled = true;
            textBoxNombreProyecto.Enabled = true;

        }




        private void timerAgregarCliente_Tick(object sender, EventArgs e)
        {

        }


        private void Aparce_caja_codigo_cliente()
        {
            textBoxCodigoProyecto.Visible = true;
        }


        private void Limpia_operaciones_proyectos()
        {
            Operacio_reporte_proyectos = "";
        }



        private void Aparece_textbox_ingeniero_cliente()
        {
            //textBoxIngenieroCliente.Visible = true;
        }

        private void Aparece_textbox_ingeniero_coset()
        {
            //textBoxIngenieroCoset.Visible = true;
        }



        private void Aparece_textbox_atencion_copia()
        {
            //textBoxIngenieroCoset.Visible = true;
        }


        private void Aparece_textbox_nombre_cliente()
        {
            //textBoxNombreCliente.Visible = true;
        }



        private void Desactiva_datagridview_dibujos()
        {
            dataGridViewReporteDibujosProyecto.Enabled = false;
        }

        private void Elimina_informacion_proyectos_disponibles()
        {
            clientes_disponibles = null;
            contactos_cliente_disponibles = null;
            proyectos_disponibles = null;
            GC.Collect();
        }

        private void Desaparece_boton_cancelar()
        {
            buttonCancelar.Visible = false;
        }

        private void Desaparece_boton_guardar_base_de_datos()
        {
            buttonGuardarBasedeDatos.Visible = false;
        }


        private void Limpia_cajas_captura_despues_de_agregar_proyecto()
        {
            textBoxCodigoProyecto.Text = "";
            textBoxNombreProyecto.Text = "";

            textBoxCodigoCliente.Text = "";

            textBoxNombreCliente.Text = "";
            textBoxIngenieroCliente.Text = "";
            textBoxIngenieroCoset.Text = "";

            textBoxTotalDibujos.Text = "";

            comboBoxCodigoProyecto.Text = "";

            textBoxDescripcionMaterial.Text = "";
            textCodigoMaterial.Text = "";
            textBoxCodigoProveedor.Text = "";

        }

        private void Desaparece_boton_eliminar_base_de_datos()
        {
            buttonBorrarBasedeDatos.Visible = false;
        }

        private void Obtener_ingenieros_coset_disponibles()
        {
            Ingenieros_disponibles = clase_usuarios.Adquiere_ingenieros_disponibles_en_base_datos();
        }


        private void Desaparece_textbox_ingeniero_coset()
        {
            //textBoxIngenieroCoset.Visible = false;
        }


        private void dataGridViewDibujosProyecto_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void comboBoxCodigoProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Operacio_reporte_proyectos == "Filtro_Fechas")
            {
                limpia_datagrid_reporte_dibujos_proyecto();
                Activa_datagrid_reporte_dibujos_proyectos();
                obtener_proyectos_empleados_filtrados();
                rellena_datagridview_proyectos_filtrados();
            }
            else if (Operacio_reporte_proyectos == "Reporte_proyectos_codigo")
            {
                limpia_datagrid_reporte_dibujos_proyecto();
                Desapare_combo_nombre_proyecto();
                Rellena_cajas_informacion_de_proyectos_codigo();
                Obtener_dibujos_proyectos();
                Activa_datagrid_reporte_dibujos_proyectos();
                Verifica_datos_en_datagridview();
            }
            
        }

        private void obtener_proyectos_empleados_filtrados()
        {
            dibujo_Produccions_disponibles.Clear();
            secuencia_produccion_filtros.Clear();
            foreach (Secuencia_produccion secuencia in secuencia_produccion_disponibles)
            {
                dibujo_Produccion_busqueda.Numero_dibujo = secuencia.Numero_Dibujo;
                dibujo_Produccion_busqueda.Proceso = secuencia.proceso;

                dibujo_Produccions_disponibles = Class_Dibujos_Produccion.
                    Adquiere_dibujos_produccion_busqueda_en_base_datos(dibujo_Produccion_busqueda);

                if(comboBoxNombreEmpleado.Text != "" && comboBoxCodigoProyecto.Text!="")
                {
                    if (comboBoxNombreEmpleado.Text == secuencia.Empleado &&
                        comboBoxCodigoProyecto.Text == dibujo_Produccions_disponibles[0].proyecto)
                    {
                        secuencia_produccion_filtros.Add(secuencia);
                    }
                }
                else if( comboBoxNombreEmpleado.Text == "" && comboBoxCodigoProyecto.Text != "")
                {
                    if (comboBoxCodigoProyecto.Text == dibujo_Produccions_disponibles[0].proyecto)
                    {
                        secuencia_produccion_filtros.Add(secuencia);
                    }
                }
                else if(comboBoxNombreEmpleado.Text != "" && comboBoxCodigoProyecto.Text == "")
                {

                    if (comboBoxNombreEmpleado.Text == secuencia.Empleado)
                    {
                        secuencia_produccion_filtros.Add(secuencia);
                    }
                }
                

            }
        }

        private void rellena_datagridview_proyectos_filtrados()
        {
            dibujos_Proyectos_disponibles.Clear();
            dibujo_Produccions_disponibles.Clear();
            foreach (Secuencia_produccion secuencia in secuencia_produccion_filtros)
            {
                dibujo_Produccion_busqueda.Numero_dibujo = secuencia.Numero_Dibujo;
                dibujo_Produccion_busqueda.Proceso = secuencia.proceso;

                dibujo_Produccions_disponibles = Class_Dibujos_Produccion.
                    Adquiere_dibujos_produccion_busqueda_en_base_datos(dibujo_Produccion_busqueda);


                dibujos_Proyecto_busqueda.Numero = secuencia.Numero_Dibujo;
                dibujos_Proyecto_busqueda.proceso = secuencia.proceso;

                dibujos_Proyectos_disponibles = Class_Dibujos_Proyecto.
                    Adquiere_dibujos_proceso_proyecto_disponibles_en_base_datos(dibujos_Proyecto_busqueda);

                dataGridViewReporteDibujosProyecto.Rows.Add(secuencia.Numero_Dibujo, dibujos_Proyectos_disponibles[0].Cantidad,
                   secuencia.proceso, secuencia.estado, secuencia.Empleado, dibujo_Produccions_disponibles[0].Horas_produccion,
                   dibujo_Produccions_disponibles[0].Horas_retrabajo);

            }

        }

        private void Obtener_dibujos_proyectos()
        {
            Obtener_dibujos_proyecto_disponibles();
            Rellena_partidas_dibujos_proyecto();
        }

        private void Rellena_partidas_dibujos_proyecto()
        {
            //int Total_dibujos = 0;
            //int Total_completos = 0;
            //double Porcentaje_completo = 0;
            foreach(Dibujo_produccion dibujo in dibujo_Produccions_disponibles)
            {
                dibujos_Proyecto_busqueda.Numero = dibujo.Numero_dibujo;
                dibujos_Proyecto_busqueda.proceso = dibujo.Proceso;
                dibujos_Proyectos_disponibles = Class_Dibujos_Proyecto.
                    Adquiere_dibujos_proceso_proyecto_disponibles_en_base_datos(dibujos_Proyecto_busqueda);

                dataGridViewReporteDibujosProyecto.Rows.Add(dibujo.Numero_dibujo, dibujos_Proyectos_disponibles[0].Cantidad,
                   dibujo.Proceso, dibujo.Estado, dibujo.Empleado, dibujo.Horas_produccion,
                   dibujo.Horas_retrabajo);
  
            }
            //Porcentaje_completo = (Convert.ToSingle(Total_completos) / Convert.ToSingle(Total_dibujos)) * 100;
            //textBoxTotalDibujos.Text = Total_dibujos.ToString();
            //textBoxTotalDibujoCompletos.Text = Total_completos.ToString();
            //textBoxPorcentajeProyecto.Text = Porcentaje_completo.ToString();
        }

        private void Obtener_dibujos_proyecto_disponibles()
        {
            if (Operacio_reporte_proyectos == "Reporte_proyectos_codigo")
            {
                dibujo_Produccions_disponibles = Class_Dibujos_Produccion.
                Adquiere_dibujos_producion_reporte_proyecto_disponibles_en_base_datos(comboBoxCodigoProyecto.Text);
                    
            }
            else if(Operacio_reporte_proyectos == "Reporte_proyectos_nombre")
            {
                dibujo_Produccions_disponibles = Class_Dibujos_Produccion.
                Adquiere_dibujos_producion_reporte_proyecto_disponibles_en_base_datos(textBoxCodigoProyecto.Text);
            }
        }

        private void Desapare_combo_nombre_proyecto()
        {
            comboBoxNombreProyecto.Visible = false;
        }

        private void Aparce_boton_cancelar()
        {
            buttonCancelar.Visible = true;
        }

        private void Desaparce_boton_cancelar()
        {
            buttonCancelar.Visible = false;
        }
        private void Activa_datagrid_reporte_dibujos_proyectos()
        {
            dataGridViewReporteDibujosProyecto.Enabled = true;
        }

        private void Desactiva_datagrid_reporte_dibujos_proyectos()
        {
            dataGridViewReporteDibujosProyecto.Enabled = true;
        }

        private void Obtener_materiales_asignados_proyecto(string text)
        {
            Asigna_campos_salida_materiales();
            Salida_materiales_disponibles = Class_salida_material.Adquiere_salida_materiales_proyecto_busqueda_en_base_datos(Busqueda_salida_material);
            Rellena_partida_materiales_salida_proyecto();
            Devolucion_Material_busqueda.Proyecto = comboBoxCodigoProyecto.Text;
            Material_devolucion_disponibles = Class_Devolucion_Material
            .Adquiere_devolucion_materiales_proyecto_busqueda_en_base_datos(Devolucion_Material_busqueda);
            Rellena_partida_materiales_devolucion_proyecto();
            calcula_total_precio_proyecto();
        }

        private void calcula_total_precio_proyecto()
        {
            try
            {
                if (textBoxTotalDibujos.Text != "" && textBoxTotalDibujoCompletos.Text != "")
                {
                    textBoxPorcentajeProyecto.Text = (Convert.ToDouble(textBoxTotalDibujos.Text) -
                        Convert.ToDouble(textBoxTotalDibujoCompletos.Text)).ToString("0.00");
                }
                else
                {
                    MessageBox.Show("Valores en Blanco", "Reportes Proyecto"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Valores NO Numericos", "Reportes Proyecto"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Rellena_partida_materiales_devolucion_proyecto()
        {
            double Total_precio_proyecto_devolucion = 0.0;
            double Total_precio = 0.0;
            double Precio_unitario = 0.0;

            foreach (Devolucion_Material material in Material_devolucion_disponibles)
            {
                Precio_unitario = 0.0;
                Total_precio = 0.0;
                try
                {
                    Material_busqueda.Codigo = material.Codigo_material;
                    Materiales_disponibles = Class_Materiales.
                        Adquiere_materiales_codigo_material_en_base_datos(Material_busqueda);
                    Material_seleccion = Materiales_disponibles.
                            Find(material_combo => material_combo.Codigo.Contains(material.Codigo_material));
                    if (Material_seleccion.divisa == "Pesos")
                    {
                        Precio_unitario = Convert.ToDouble(Material_seleccion.precio);
                        Total_precio = Convert.ToDouble(material.Cantidad) * Precio_unitario;
                    }
                    else if (Material_seleccion.divisa == "Dolares")
                    {
                        Precio_unitario = Convert.ToDouble(Material_seleccion.precio) * Convert.ToDouble(datos_generales.Tc);
                        Total_precio = Convert.ToDouble(material.Cantidad) * Precio_unitario;

                    }
                    Total_precio_proyecto_devolucion += Total_precio;
                    dataGridViewReporteDibujosProyecto.Rows.Add(Material_seleccion.Codigo,
                           Material_seleccion.Codigo_proveedor,
                            Material_seleccion.Descripcion, Material_seleccion.Marca,
                            material.Cantidad, material.Nombre_empleado, material.Fecha,
                            Precio_unitario.ToString("0.00"), Total_precio.ToString("0.00"),
                            material.Proyecto,
                            "",
                            "",
                            "",
                            "Devolucion", material.Motivo_devolucion);

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            textBoxTotalDibujoCompletos.Text = Total_precio_proyecto_devolucion.ToString("0.00");
        }

        private void Rellena_partida_materiales_salida_proyecto()
        {
            double Total_precio_proyecto_salidas = 0.0;
            double Total_precio = 0.0;
            double Precio_unitario = 0.0;
            Ordenes_compra_disponibles = Class_Ordenes_Compra.
                Adquiere_ordenes_compra_disponibles_en_base_datos();
            foreach (Salida_Material material in Salida_materiales_disponibles)
            {
                Precio_unitario = 0.0;
                Total_precio = 0.0;
                try
                {
                    if (material.Orden_compra != "NA")
                    {
                        Orden_compra_seleccion = Ordenes_compra_disponibles.
                            Find(orden_compra => orden_compra.Codigo.Contains(material.Orden_compra));
                        Partida_orden_compra_busqueda.Material = material.Codigo_material;
                        Partida_orden_compra_busqueda.Codigo_orden = Orden_compra_seleccion.Codigo;
                        Partidas_ordenes_compra_disponibles = class_Partidas_Orden_Compra.
                            Adquiere_partidas_ordenes_compra_disponibles_material_orden_compra(Partida_orden_compra_busqueda);

                        Partida_orden_compra_seleccion = Partidas_ordenes_compra_disponibles.
                            Find(partida_orden_compra => partida_orden_compra.Codigo_orden.Contains(material.Orden_compra));
                        Material_busqueda.Codigo = material.Codigo_material;
                        Materiales_disponibles = Class_Materiales.Adquiere_materiales_codigo_material_en_base_datos(Material_busqueda);
                        Material_seleccion = Materiales_disponibles.
                            Find(material_combo => material_combo.Codigo.Contains(material.Codigo_material));
                        if (Material_seleccion.divisa == "Pesos")
                        {
                            Precio_unitario = Convert.ToDouble(Material_seleccion.precio);
                            Total_precio = Convert.ToDouble(material.Cantidad) * Precio_unitario;
                        }
                        else if (Material_seleccion.divisa == "Dolares")
                        {
                            Precio_unitario = Convert.ToDouble(Material_seleccion.precio) * Convert.ToDouble(datos_generales.Tc);
                            Total_precio = Convert.ToDouble(material.Cantidad) * Precio_unitario;

                        }
                        Total_precio_proyecto_salidas += Total_precio;
                        if(Material_seleccion.Generico=="1")
                        {
                            dataGridViewReporteDibujosProyecto.Rows.Add(Material_seleccion.Codigo,
                           Material_seleccion.Codigo_proveedor,
                           Material_seleccion.Descripcion, Material_seleccion.Marca,
                           material.Cantidad, material.Nombre_empleado, material.Fecha,
                           Precio_unitario.ToString("0.00"), Total_precio.ToString("0.00"),
                           material.Proyecto,
                           Partida_orden_compra_seleccion.Proyecto,
                           Partida_orden_compra_seleccion.Cantidad,
                           Partida_orden_compra_seleccion.Codigo_orden,
                           "Salida", "");
                        }
                        else
                        {
                            dataGridViewReporteDibujosProyecto.Rows.Add(Material_seleccion.Codigo,
                          Material_seleccion.Codigo_proveedor,
                           Material_seleccion.Descripcion, Material_seleccion.Marca,
                           material.Cantidad, material.Nombre_empleado, material.Fecha,
                           Precio_unitario.ToString("0.00"), Total_precio.ToString("0.00"),
                           material.Proyecto,
                           Partida_orden_compra_seleccion.Proyecto,
                           Partida_orden_compra_seleccion.Cantidad,
                           Partida_orden_compra_seleccion.Codigo_orden,
                           "Salida", "");
                        }
                        dataGridViewReporteDibujosProyecto.Rows.Add(Material_seleccion.Codigo,
                          Material_seleccion.Codigo_proveedor,
                           Material_seleccion.Descripcion, Material_seleccion.Marca,
                           material.Cantidad, material.Nombre_empleado, material.Fecha,
                           Precio_unitario.ToString("0.00"), Total_precio.ToString("0.00"),
                           material.Proyecto,
                           Partida_orden_compra_seleccion.Proyecto,
                           Partida_orden_compra_seleccion.Cantidad,
                           Partida_orden_compra_seleccion.Codigo_orden,
                           "Salida", "");
                    }
                    else if (material.Orden_compra == "NA")
                    {

                        Material_busqueda.Codigo = material.Codigo_material;
                        Materiales_disponibles = Class_Materiales.Adquiere_materiales_codigo_material_en_base_datos(Material_busqueda);
                        Material_seleccion = Materiales_disponibles.
                            Find(material_combo => material_combo.Codigo.Contains(material.Codigo_material));
                        if (Material_seleccion.divisa == "Pesos")
                        {
                            Precio_unitario = Convert.ToDouble(Material_seleccion.precio);
                            Total_precio = Convert.ToDouble(material.Cantidad) * Precio_unitario;
                        }
                        else if (Material_seleccion.divisa == "Dolares")
                        {
                            Precio_unitario = Convert.ToDouble(Material_seleccion.precio) * Convert.ToDouble(datos_generales.Tc);
                            Total_precio = Convert.ToDouble(material.Cantidad) * Precio_unitario;

                        }
                        dataGridViewReporteDibujosProyecto.Rows.Add(Material_seleccion.Codigo,
                            Material_seleccion.Codigo_proveedor,
                            Material_seleccion.Descripcion, Materiales_disponibles[0].Marca,
                            material.Cantidad, material.Nombre_empleado, material.Fecha,
                            Precio_unitario.ToString("0.00"), Total_precio.ToString("0.00"),
                            material.Proyecto,
                            "",
                            "",
                            "",
                            "Salida", "");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            textBoxTotalDibujos.Text = Total_precio_proyecto_salidas.ToString("0.00");
        }

        private void Asigna_campos_salida_materiales()
        {
            Busqueda_salida_material.Proyecto = comboBoxCodigoProyecto.Text;
        }

        private void buttonReporteProyectos_Click(object sender, EventArgs e)
        {
            Operacio_reporte_proyectos = "Reporte_proyectos_codigo";
            Limpia_combo_proyecto();
            Limpia_combo_nombre_proyecto();
            Desactica_botones_operacion();
            Aparce_boton_cancelar();
            Aparece_cajas_etiquetas_reporte_proyectos();
            Obtener_datos_proyectos_disponibles_base_datos();
            Rellena_combo_codigo_proyecto();

        }

        private void Limpia_combo_nombre_proyecto()
        {
            comboBoxNombreProyecto.Items.Clear();
            comboBoxNombreProyecto.Text = "";
        }

        private void Aparece_boton_Excel()
        {
            buttonExcel.Visible = true;
        }

        private void Desaparece_boton_Excel()
        {
            buttonExcel.Visible = false;
        }
        private void Desactica_botones_operacion()
        {
            buttonReporteProyectos.Enabled = false;
            buttonReporteUsuarios.Enabled = false;
            buttonReoprteMateriales.Enabled = false;
            buttonFecha.Enabled = false;
        }

        private void Activa_botones_operacion()
        {
            buttonReporteProyectos.Enabled = true;
            buttonReporteUsuarios.Enabled = true;
            buttonReoprteMateriales.Enabled = true;
            buttonFecha.Enabled = true;
        }

        private void Aparece_cajas_etiquetas_reporte_proyectos()
        {
            labelCodigoProyecto.Visible = true;
            comboBoxCodigoProyecto.Visible = true;
            comboBoxNombreProyecto.Visible = true;
            textBoxNombreProyecto.Visible = true;
            labelNombreProyecto.Visible = true;
            textBoxCodigoCliente.Visible = true;
            labelCodigoCliente.Visible = true;
            textBoxNombreCliente.Visible = true;
            labelNombreCliente.Visible = true;
            textBoxIngenieroCoset.Visible = true;
            labelIngenieroCoset.Visible = true;
            textBoxIngenieroCliente.Visible = true;
            labelIngenieroCliente.Visible = true;
            //labelTotalDibujos.Visible = true;
            //textBoxTotalDibujos.Visible = true;
            //labelTotalDibujosCompletos.Visible = true;
            //textBoxTotalDibujoCompletos.Visible = true;
            //labelTotalPorcentajeDibujos.Visible = true;
            //textBoxPorcentajeProyecto.Visible = true;
        }

        private void Desaparece_cajas_etiquetas_reporte_proyectos()
        {
            labelCodigoProyecto.Visible = false;
            comboBoxCodigoProyecto.Visible = false;
            textBoxNombreProyecto.Visible = false;
            labelNombreProyecto.Visible = false;
            textBoxCodigoCliente.Visible = false;
            labelCodigoCliente.Visible = false;
            textBoxNombreCliente.Visible = false;
            labelNombreCliente.Visible = false;
            textBoxIngenieroCoset.Visible = false;
            labelIngenieroCoset.Visible = false;
            textBoxIngenieroCliente.Visible = false;
            labelIngenieroCliente.Visible = false;
            labelTotalDibujos.Visible = false;
            textBoxTotalDibujos.Visible = false;
            labelTotalDibujosCompletos.Visible = false;
            textBoxTotalDibujoCompletos.Visible = false;
            labelTotalPorcentajeDibujos.Visible = false;
            textBoxPorcentajeProyecto.Visible = false;
        }

        private void buttonReporteUsuarios_Click(object sender, EventArgs e)
        {
            Operacio_reporte_proyectos = "Usuarios";
            Desactica_botones_operacion();
            Aparece_boton_cancelar_operacio();
            Aparece_combo_label_empleado();
            Obtener_empleados_disponibles();
            Limpia_combo_nombre_empleados();
            Rellena_combo_usuarios();
            Aparece_boton_Excel();

        }

        private void Limpia_combo_nombre_empleados()
        {
            comboBoxNombreEmpleado.Items.Clear();
            comboBoxNombreEmpleado.Text = "";
        }

        private void Rellena_combo_usuarios()
        {
            foreach (Usuario usuario in Usuarios_disponibles)
            {
                if (usuario.error == "")
                    comboBoxNombreEmpleado.Items.Add(usuario.nombre_empleado);
                else
                {
                    MessageBox.Show(usuario.error);
                    break;
                }
            }
        }

        private void Obtener_empleados_disponibles()
        {
            Usuarios_disponibles = clase_usuarios.
                Adquiere_todos_usuarios_requsitores_disponibles_en_base_datos();
        }

        private void Aparece_combo_label_empleado()
        {
            labelNombreEmpleado.Visible = true;
            comboBoxNombreEmpleado.Visible = true;
        }
        private void Deaparece_combo_label_empleado()
        {
            labelNombreEmpleado.Visible = false;
            comboBoxNombreEmpleado.Visible = false;
        }

        private void comboBoxNombreEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Operacio_reporte_proyectos == "Filtro_Fechas")
            {
                limpia_datagrid_reporte_dibujos_proyecto();
                Activa_datagridview_dibujos_proyecto();
                obtener_proyectos_empleados_filtrados();
                rellena_datagridview_proyectos_filtrados();
                Aparece_boton_Excel();
            }
            else if(Operacio_reporte_proyectos == "Filtro_proyectos_codigo")
            {
                limpia_datagrid_reporte_dibujos_proyecto();
                Activa_datagridview_dibujos_proyecto();
                obtener_proyectos_filtros_empleado();
                rellena_datagridview_proyectos_filtro_empleados();
                Aparece_boton_Excel();
            }
            else
            {
                limpia_datagrid_reporte_dibujos_proyecto();
                Activa_datagridview_dibujos_proyecto();
                Obtener_dibujos_proyecto_por_empleado();
                Rellenar_partidas_reporte_dibujos_proyecto();
                //obtener_salida_materiales_usuario();
                //Rellena_partida_materiales_salida_proyecto();
                //Obtener_devoluciones_materiales_usuarios();
                //Rellena_partida_materiales_devolucion_proyecto();
                Aparece_boton_Excel();
            }

        }

        private void rellena_datagridview_proyectos_filtro_empleados()
        {
            foreach (Dibujo_produccion dibujo in dibujo_Produccions_filtros)
            {

                dataGridViewReporteDibujosProyecto.Rows.Add(dibujo.Numero_dibujo, dibujos_Proyectos_disponibles[0].Cantidad,
                   dibujo.Proceso, dibujo.Estado, dibujo.Empleado, dibujo.Horas_produccion,
                   dibujo.Horas_retrabajo);
            }
        }

        private void obtener_proyectos_filtros_empleado()
        {
            dibujo_Produccions_filtros.Clear();
           foreach (Dibujo_produccion dibujo in dibujo_Produccions_disponibles)
            {


                if(comboBoxNombreEmpleado.Text!="" && comboBoxFechaFiltro.Text!="")
                {
                    

                } else if(comboBoxNombreEmpleado.Text == "" && comboBoxFechaFiltro.Text != "")
                {

                }else if(comboBoxNombreEmpleado.Text != "" && comboBoxFechaFiltro.Text == "")
                {
                    if(dibujo.Empleado == comboBoxNombreEmpleado.Text)
                    {
                        dibujo_Produccions_filtros.Add(dibujo);
                    }
                }
                

            }
        }

        private void obtener_empleados_filtrados()
        {
            secuencia_produccion_filtros.Clear();
            foreach (Secuencia_produccion secuencia in secuencia_produccion_disponibles)
            {
                
                if (comboBoxNombreEmpleado.Text == secuencia.Empleado)
                {
                    secuencia_produccion_filtros.Add(secuencia);
                }

            }
        }

        private void Rellenar_partidas_reporte_dibujos_proyecto()
        {
           foreach(Dibujo_produccion dibujo in dibujo_Produccions_disponibles)
            {
                dibujos_Proyectos_disponibles = Class_Dibujos_Proyecto.
                    Adquiere_dibujos_proyecto_disponibles_en_base_datos(dibujo.proyecto);

                dibujos_Proyecto_seleccion = dibujos_Proyectos_disponibles.
                       Find(dibujo_proyecto => dibujo_proyecto.Numero.Contains(dibujo.Numero_dibujo));

                dataGridViewReporteDibujosProyecto.Rows.Add(dibujo.Numero_dibujo, dibujo.proyecto,
                       dibujos_Proyecto_seleccion.Descripcion, dibujos_Proyecto_seleccion.Cantidad,
                       dibujos_Proyecto_seleccion.proceso, dibujo.Estado,dibujo.Secuencia, 
                       dibujo.Empleado,dibujo.Horas_produccion, dibujo.Horas_retrabajo);

            }
        }

        private void Obtener_dibujos_proyecto_por_empleado()
        {
            dibujo_Produccion_busqueda.Empleado = comboBoxNombreEmpleado.Text;
            dibujo_Produccions_disponibles = Class_Dibujos_Produccion.
                Adquiere_dibujos_produccion_por_empleado_busqueda_en_base_datos(dibujo_Produccion_busqueda);

        }

        private void Obtener_devoluciones_materiales_usuarios()
        {
            Devolucion_Material_busqueda.Nombre_empleado = comboBoxNombreEmpleado.Text;
            Material_devolucion_disponibles = Class_Devolucion_Material
                .Adquiere_devolucion_materiales_busqueda_usuario_en_base_datos(Devolucion_Material_busqueda);
        }

        private void obtener_salida_materiales_usuario()
        {
            Busqueda_salida_material.Nombre_empleado = comboBoxNombreEmpleado.Text;
            Salida_materiales_disponibles = Class_salida_material
                .Adquiere_salida_materiales_empleado_base_datos(Busqueda_salida_material);
        }

        private void buttonReoprteMateriales_Click(object sender, EventArgs e)
        {
            Operacio_reporte_proyectos = "Materiales";
            Aparece_elementos_reporte_materiales();
            Asigna_caracter_busqueda_material();
            Aparece_boton_cancelar_operacio();
            Inicia_timer_para_buscar_informacion_materiales_busqueda();
        }

        private void Inicia_timer_para_buscar_informacion_materiales_busqueda()
        {
            timerBusquedaFecha.Enabled = true;
        }

        private void Asigna_caracter_busqueda_material()
        {
            textBoxCodigoProveedor.BackColor = Color.Yellow;
            textCodigoMaterial.BackColor = Color.Yellow;
            textBoxDescripcionMaterial.BackColor = Color.Yellow;
        }

        private void Aparece_elementos_reporte_materiales()
        {
            labelCodigoMaterial.Visible = true;
            textCodigoMaterial.Visible = true;
            labelCodigoMaterialProveedor.Visible = true;
            textBoxCodigoProveedor.Visible = true;
            labelMaterialDescripcion.Visible = true;
            textBoxDescripcionMaterial.Visible = true;
        }

        private void Desaparece_elementos_reporte_materiales()
        {
            labelCodigoMaterial.Visible = false;
            textCodigoMaterial.Visible = false;
            labelCodigoMaterialProveedor.Visible = false;
            textBoxCodigoProveedor.Visible = false;
            labelMaterialDescripcion.Visible = false;
            textBoxDescripcionMaterial.Visible = false;
        }


        private void buttonBusquedaBaseDatos_Click(object sender, EventArgs e)
        {
            if (Operacio_reporte_proyectos == "Reporte_Fecha")
            {
                obtener_secuencia_produccion_disponibles();
                limpia_datagrid_reporte_dibujos_proyecto();
                rellena_datagridview_proyectos_fechas();
                Activa_datagrid_reporte_dibujos_proyectos();
                Verifica_datos_en_datagridview();
            }
            else if(Operacio_reporte_proyectos == "Reporte_proyectos_codigo")
            {

            }


            
        }

        private void Verifica_datos_en_datagridview()
        {
            if (dataGridViewReporteDibujosProyecto.Rows.Count > 1)
            {
                Aparece_boton_filtros();
                Aparece_boton_Excel();
            }
        }

        private void Aparece_boton_filtros()
        {
            buttonFiltros.Visible = true;
        }

        private void Deaparece_boton_filtros()
        {
            buttonFiltros.Visible = false;
        }

        private void rellena_datagridview_proyectos_fechas()
        {
            dibujos_Proyectos_disponibles.Clear();
            dibujo_Produccions_disponibles.Clear();
            foreach (Secuencia_produccion secuencia in secuencia_produccion_disponibles)
            {
                dibujo_Produccion_busqueda.Numero_dibujo = secuencia.Numero_Dibujo;
                dibujo_Produccion_busqueda.Proceso = secuencia.proceso;

                dibujo_Produccions_disponibles = Class_Dibujos_Produccion.
                    Adquiere_dibujos_produccion_busqueda_en_base_datos(dibujo_Produccion_busqueda);

                
                dibujos_Proyecto_busqueda.Numero = secuencia.Numero_Dibujo;
                dibujos_Proyecto_busqueda.proceso = secuencia.proceso;

                dibujos_Proyectos_disponibles = Class_Dibujos_Proyecto.
                    Adquiere_dibujos_proceso_proyecto_disponibles_en_base_datos(dibujos_Proyecto_busqueda);

                dataGridViewReporteDibujosProyecto.Rows.Add(secuencia.Numero_Dibujo, dibujos_Proyectos_disponibles[0].Cantidad,
                   secuencia.proceso, secuencia.estado, secuencia.Empleado, dibujo_Produccions_disponibles[0].Horas_produccion,
                   dibujo_Produccions_disponibles[0].Horas_retrabajo);

            }
        }

        private void obtener_secuencia_produccion_disponibles()
        {

            DateTime dateTime_inicio = dateTimePickerFechaInicio.Value;
            DateTime dateTime_final = dateTimePickerFechaFinal.Value;


            secuencia_produccion_disponibles.Clear();
            string fecha_inicio_analizar = dateTime_inicio.Year+"-"+ dateTime_inicio.Month +"-"+ dateTime_inicio.Day;
            string fecha_final_analizar = dateTime_final.Year + "-" + dateTime_final.Month + "-" + dateTime_final.Day;

            if (comboBoxFechaFiltro.Text == "Tiempo Inicio")
            {

                secuencia_produccion_disponibles = Class_Secuencia_Produccion.
                Adquiere_secuencia_produccion_reporte_fecha_inicio(fecha_inicio_analizar, fecha_final_analizar);
            }
            else if (comboBoxFechaFiltro.Text == "Tiempo Termino")
            {

                secuencia_produccion_disponibles = Class_Secuencia_Produccion.
                    Adquiere_secuencia_produccion_reporte_fecha_termino(fecha_inicio_analizar, fecha_final_analizar);
            }
            else
            {
                MessageBox.Show("No Fecha Inicio/Final seleccionado", "Reporte Proyectos por Fecha"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        

        private void Obtener_devoluciones_materiales(Material material)
        {
            Devolucion_Material_busqueda.Codigo_material = material.Codigo;
            Material_devolucion_disponibles = Class_Devolucion_Material
               .Adquiere_devolucion_materiales_busqueda_en_base_datos(Devolucion_Material_busqueda);
        }

        private void obtener_salida_materiales(Material material)
        {
            Busqueda_salida_material.Codigo_material = material.Codigo;
            Salida_materiales_disponibles = Class_salida_material
                .Adquiere_salida_materiales_busqueda_en_base_datos(Busqueda_salida_material);
        }


        private void Obtener_datos_materiales_busqueda()
        {
            Asigna_datos_visualizar_material();
            Materiales_disponibles_busqueda = Class_Materiales.Adquiere_materiales_busqueda_entrada_materiales_en_base_datos(Visualizar_material);
        }

        private void Asigna_datos_visualizar_material()
        {
            if (textCodigoMaterial.Text == "")
            {
                Visualizar_material.Codigo = "~";
            }
            else
            {
                Visualizar_material.Codigo = textCodigoMaterial.Text;
            }

            if (textBoxCodigoProveedor.Text == "")
            {
                Visualizar_material.Codigo_proveedor = "~";
            }
            else
            {
                Visualizar_material.Codigo_proveedor = textBoxCodigoProveedor.Text;
            }

            if (textBoxDescripcionMaterial.Text == "")
            {
                Visualizar_material.Descripcion = "~";
            }
            else
            {
                Visualizar_material.Descripcion = textBoxDescripcionMaterial.Text;
            }

        }

        private void Desactiva_boton_busqueda()
        {
            buttonBusquedaBaseDatos.Enabled = false;
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            Desactiva_boton_excel();
            Elimina_archivo_excel();
            
            if (Inicia_Excel())
            {
                oXL.Visible = true;
                Asigna_nombre_archivo_excel();
                Elimina_archivo_excel();
                if (Copiar_template_a_reportes())
                {
                    if (Abrir_Archivo_Excel())
                    {
                        oSheet = (Excel.Worksheet)oWB.Worksheets.get_Item(1);
                        Escribe_informacion_Proyecto();
                        Escribe_titulos_proyecto();
                        for (int Row = 0; Row < dataGridViewReporteDibujosProyecto.RowCount - 1; Row++)
                        {
                            for (int Column = 0; Column < dataGridViewReporteDibujosProyecto.ColumnCount; Column++)
                            {
                                oSheet.Cells[Row + 8, Column + 1] = dataGridViewReporteDibujosProyecto[Column, Row].Value.ToString();
                            }
                        }

                        oSheet.Cells.EntireColumn.AutoFit();
                        Guarda_archivo_excel();
                    }
                }
            }
        }

        private void Asigna_nombre_archivo_excel()
        {
            Archivo_Excel_nombre = "\\reportes-" +
                    Forma_Inicio_Usuario.Usuario_global.nombre_usuario + ".xlsx";
        }

        private void Escribe_titulos_proyecto()
        {
            oSheet.Cells[7, 1] = "Numero Dibujo";
            oSheet.Cells[7, 2] = "Proyecto";
            oSheet.Cells[7, 3] = "Dibujo Descripcion";
            oSheet.Cells[7, 4] = "Cantidad_Unidades";
            oSheet.Cells[7, 5] = "Proceso Dibujo";
            oSheet.Cells[7, 6] = "EStado Dibujo";
            oSheet.Cells[7, 7] = "Secuencia Dibujo";
            oSheet.Cells[7, 8] = "Empleado";
            oSheet.Cells[7, 9] = "Horas Produccion";
            oSheet.Cells[7, 10] = "Horas Re-trabajo";

        }

        private void Escribe_informacion_Proyecto()
        {
            if(Operacio_reporte_proyectos == "proyectos_codigo" || Operacio_reporte_proyectos == "proyectos_nombre")
            {
                oSheet.Cells[1, 1] = "Nombre Proyecto";
                oSheet.Cells[2, 1] = "Nombre Cliente";
                oSheet.Cells[3, 1] = "Codigo Clinete";
                oSheet.Cells[4, 1] = "Ingeniero Cliente";
                oSheet.Cells[5, 1] = "Ingeniero Coset";

                oSheet.Cells[1, 2] = textBoxNombreProyecto.Text;
                oSheet.Cells[2, 2] = textBoxNombreCliente.Text;
                oSheet.Cells[3, 2] = textBoxCodigoCliente.Text;
                oSheet.Cells[4, 2] = textBoxIngenieroCliente.Text;
                oSheet.Cells[5, 2] = textBoxIngenieroCoset.Text;

                oSheet.Cells[1, 4] = "Total Dibujos Proyecto";
                oSheet.Cells[2, 4] = "Total Dibujos Completos";
                oSheet.Cells[3, 4] = "Porcenataje Proyecto (%)";

                oSheet.Cells[1, 5] = textBoxTotalDibujos.Text;
                oSheet.Cells[2, 5] = textBoxTotalDibujoCompletos.Text;
                oSheet.Cells[3, 5] = textBoxPorcentajeProyecto.Text;
            }
        }

        private bool Abrir_Archivo_Excel()
        {
            try
            {
                oWB = oXL.Workbooks.Open(@appPath + Archivo_Excel_nombre);
                return true;
            }
            catch
            {
                MessageBox.Show(Archivo_Excel_nombre + " No existe en el Folder de aplicacion",
                    "Reportes Materiales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private bool Copiar_template_a_reportes()
        {
            
            try
            {
                File.Copy(@appPath + "\\Excel_template.xlsx", @appPath + Archivo_Excel_nombre, false);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool Inicia_Excel()
        {
            try
            {
                if (oXL == null)
                {
                    oXL = new Excel.Application();
                }

                return true;
            }
            catch
            {
                MessageBox.Show("No Excel Instalado", "Reporte Materiales",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void Elimina_archivo_excel()
        {
            try
            {
                File.Delete(@appPath + Archivo_Excel_nombre);
            }
            catch
            {

            }
        }

        private void Desactiva_boton_excel()
        {
            buttonExcel.Enabled = false;
        }

        private void Activa_boton_excel()
        {
            buttonExcel.Enabled = true;
        }

        private void Cierra_archivo_Excel()
        {
            try
            {
                oWB.Close();
            }
            catch
            {

            }
        }

        public void Guarda_archivo_excel()
        {
            try
            {
                oWB.Save();
            }
            catch
            {

            }
        }

        private void comboBoxNombreProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Operacio_reporte_proyectos = "Reporte_proyectos_nombre";
            limpia_datagrid_reporte_dibujos_proyecto();
            Desaparece_combo_codigo_proyecto();
            Aparece_textbox_codigo_proyecto();
            Rellena_cajas_informacion_de_proyectos_nombre();
            Obtener_dibujos_proyectos();
            Activa_datagrid_reporte_dibujos_proyectos();
            Aparece_boton_Excel();
        }

        private void Rellena_cajas_informacion_de_proyectos_nombre()
        {
            proyecto_visualizar = proyectos_disponibles.Find(proyecto => proyecto.Nombre.Contains(comboBoxNombreProyecto.Text));
            textBoxNombreCliente.Text = proyecto_visualizar.Nombre_cliente;
            textBoxIngenieroCoset.Text = proyecto_visualizar.Ingeniero_coset; ;
            textBoxIngenieroCliente.Text = proyecto_visualizar.Ingeriero_cliente;
            textBoxCodigoCliente.Text = proyecto_visualizar.Codigo_cliente;
            textBoxCodigoProyecto.Text = proyecto_visualizar.Codigo;
        }

        private void buttonFecha_Click(object sender, EventArgs e)
        {
            Operacio_reporte_proyectos = "Reporte_Fecha";
            Desactica_botones_operacion();
            Aparce_boton_cancelar();
            Aparece_combos_label_fecha();
            Inicia_timer_fecha_filtros();
        }

        private void Inicia_timer_fecha_filtros()
        {
            timerBusquedaFecha.Enabled = true;
        }

        private void Termina_timer_fecha_filtros()
        {
            timerBusquedaFecha.Enabled = false;
        }

        private void Aparece_combos_label_fecha()
        {
            labelFechaFiltro.Visible = true;
            labelFechaInicio.Visible = true;
            labelFechaFinal.Visible = true;
            comboBoxFechaFiltro.Visible = true;
            dateTimePickerFechaInicio.Visible = true;
            dateTimePickerFechaFinal.Visible = true;
        }

        private void Desaparece_combos_label_fecha()
        {
            labelFechaFiltro.Visible = false;
            labelFechaInicio.Visible = false;
            labelFechaFinal.Visible = false;
            comboBoxFechaFiltro.Visible = false;
            dateTimePickerFechaInicio.Visible = false;
            dateTimePickerFechaFinal.Visible = false;
        }

        

        private void timerBusquedaFecha_Tick(object sender, EventArgs e)
        {
            if(comboBoxFechaFiltro.Text != "")
            {
                aparce_boton_busqueda();
            }
        }

        private void aparce_boton_busqueda()
        {
            buttonBusquedaBaseDatos.Visible = true;
        }

        private void Desaparce_boton_busqueda()
        {
            buttonBusquedaBaseDatos.Visible = false;
        }

        private void buttonFiltros_Click(object sender, EventArgs e)
        {

            if (Operacio_reporte_proyectos == "Reporte_Fecha")
            {
                Operacio_reporte_proyectos = "Filtro_Fechas";
                Deaparece_boton_filtros();
                Desaparece_combos_label_fecha();
                Desaparece_boton_busqueda();
                Termina_timer_fecha_filtros();
                Limpia_combo_nombre_empleados();
                Limpia_combo_proyecto();
                Aparece_combo_codigo_proyecto();
                Aparece_label_proyecto();
                Aparece_combo_label_empleado();
                rellenar_combos_proyectos_empleados_filtros();
            }
            else if(Operacio_reporte_proyectos == "Reporte_proyectos_codigo")
            {
                Operacio_reporte_proyectos = "Filtro_proyectos_codigo";
                Deaparece_boton_filtros();
                Aparece_caja_captura_codigo_proyecto();
                textBoxCodigoProyecto.Text = comboBoxCodigoProyecto.Text;
                Desaparece_combo_codigo_proyecto();
                //Desaparece_cajas_etiquetas_reporte_proyectos();
                Aparece_combo_label_empleado();
                Aparece_combos_label_fecha();
                Limpia_combo_nombre_empleados();
                rellenar_combos_nombre_empleados_filtros();
                Inicia_timer_fecha_filtros();
            }
        }

        private void rellenar_combos_nombre_empleados_filtros()
        {
            
            foreach (Dibujo_produccion dibujo in dibujo_Produccions_disponibles)
            {

                if (!comboBoxNombreEmpleado.Items.Contains(dibujo.Empleado))
                {
                    comboBoxNombreEmpleado.Items.Add(dibujo.Empleado);
                }


            }
        }

        private void rellenar_combos_proyectos_empleados_filtros()
        {

            dibujo_Produccions_disponibles.Clear();
            foreach (Secuencia_produccion secuencia in secuencia_produccion_disponibles)
            {
                dibujo_Produccion_busqueda.Numero_dibujo = secuencia.Numero_Dibujo;
                dibujo_Produccion_busqueda.Proceso = secuencia.proceso;

                dibujo_Produccions_disponibles = Class_Dibujos_Produccion.
                    Adquiere_dibujos_produccion_busqueda_en_base_datos(dibujo_Produccion_busqueda);

                if(!comboBoxNombreEmpleado.Items.Contains(secuencia.Empleado))
                {
                    comboBoxNombreEmpleado.Items.Add(secuencia.Empleado);
                }

                if(!comboBoxCodigoProyecto.Items.Contains(dibujo_Produccions_disponibles[0].proyecto))
                {
                    comboBoxCodigoProyecto.Items.Add(dibujo_Produccions_disponibles[0].proyecto);
                }

            }
        }

        private void Aparece_label_empleado()
        {
            labelNombreEmpleado.Visible = true;
        }

        private void Aparece_label_proyecto()
        {
            labelCodigoProyecto.Visible = true;
        }

        private void Desaparece_label_empleado()
        {
            labelNombreEmpleado.Visible = false;
        }

        private void Desaparece_label_proyecto()
        {
            labelCodigoProyecto.Visible = false;
        }
    }

}
