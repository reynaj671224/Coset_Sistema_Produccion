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
    public partial class Forma_Reporte_Proyectos : Form
    {
        public Class_Control_Folios class_folio_disponible = new Class_Control_Folios();
        public Control_folio folio_disponible = new Control_folio();
        public Datos_generales datos_generales = new Datos_generales();
        public Class_Datos_Generales Class_Datos_Generales = new Class_Datos_Generales();
        public List<Cliente> clientes_disponibles = new List<Cliente>();
        public Class_Clientes clase_clientes = new Class_Clientes();
        public List<Contacto_cliente> contactos_cliente_disponibles = new List<Contacto_cliente>();
        public Class_Contactos_Clientes clase_contactos_cliente = new Class_Contactos_Clientes();
        public List<Usuario> ingenieros_disponibles = new List<Usuario>();
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
        public Material material_seleccion = new Material();
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


        public enum Campos_dibujos
        {
            codigo, cantidad, numero, descripcion,
            proceso, tiempo_estimado
        };

        public string Operacio_reporte_proyectos = "";

        public Forma_Reporte_Proyectos()
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
            folio_disponible = null;
            this.Dispose();
            GC.Collect();
            this.Close();
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
            dataGridViewProyectoReportes.Enabled = true;
        }

        private void limpia_datagrid_materiales_proyecto()
        {
            dataGridViewProyectoReportes.Rows.Clear();
        }

        private void No_aceptar_agregar_dibujos_proyecto()
        {
            dataGridViewProyectoReportes.AllowUserToAddRows = false;
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
                    comboBoxCodigoProyecto.Items.Add(proyecto.Codigo);
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


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Operacio_reporte_proyectos = "Cancelar";           
            Limpia_cajas_captura_despues_de_agregar_proyecto();
            //Limpia_combo_proyecto();
            Desaparece_boton_guardar_base_de_datos();
            //Aparece_textbox_codigo_proyecto();
            //Aparece_textbox_ingeniero_cliente();
            //Aparece_textbox_ingeniero_coset();
            //Aparece_textbox_nombre_cliente();
            Limpia_combo_nombre_empleados();
            limpia_datagrid_materiales_proyecto();
            Desactiva_datagridview_dibujos();
            Acepta_datagridview_agregar_renglones();
            Desaparece_cajas_etiquetas_reporte_proyectos();
            Deaparece_elementos_reporte_usuarios_reporte();
            Desaparece_elementos_reporte_materiales();
            Desactiva_timer_busqueda();
            Desaparece_boton_busqueda();
            //Elimina_informacion_proyectos_disponibles();

        }

        private void Desaparece_boton_busqueda()
        {
            buttonBusquedaBaseDatos.Visible = false;
        }

        private void Desactiva_timer_busqueda()
        {
            if (timerBusquedaMaterial.Enabled)
                timerBusquedaMaterial.Enabled = false;

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


        private void Rellena_cajas_informacion_de_proyectos()
        {
            proyecto_visualizar = proyectos_disponibles.Find(proyecto => proyecto.Codigo.Contains(comboBoxCodigoProyecto.SelectedItem.ToString()));
            textBoxNombreCliente.Text = proyecto_visualizar.Nombre_cliente;
            textBoxIngenieroCoset.Text = proyecto_visualizar.Ingeniero_coset;;
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
            dataGridViewProyectoReportes.AllowUserToAddRows = true;
        }

        private void Activa_datagridview_dibujos_proyecto()
        {
            dataGridViewProyectoReportes.Enabled = true;
        }

        private void Desactiva_columna_codigo_partidas_cotizaciones()
        {
            dataGridViewProyectoReportes.Columns[0].Visible = false;
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
            dataGridViewProyectoReportes.Enabled = false;
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

            textBoxTotalPrecioProyectoSalidas.Text = "";

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
            ingenieros_disponibles = clase_usuarios.Adquiere_ingenieros_disponibles_en_base_datos();
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
            limpia_datagrid_materiales_proyecto();
            Aparce_boton_cancelar();
            Rellena_cajas_informacion_de_proyectos();
            Obtener_materiales_asignados_proyecto(comboBoxCodigoProyecto.Text);
            Activa_datagrid_reporte_proyectos();
        }

        private void Aparce_boton_cancelar()
        {
            buttonCancelar.Visible = true;
        }

        private void Desaparce_boton_cancelar()
        {
            buttonCancelar.Visible = false;
        }
        private void Activa_datagrid_reporte_proyectos()
        {
            dataGridViewProyectoReportes.Enabled = true;
        }

        private void Desactiva_datagrid_reporte_proyectos()
        {
            dataGridViewProyectoReportes.Enabled = true;
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
                if (textBoxTotalPrecioProyectoSalidas.Text != "" && textBoxTotalPrecioProyectoDevoluciones.Text != "")
                {
                    textBoxTotalPrecioProyecto.Text = (Convert.ToDouble(textBoxTotalPrecioProyectoSalidas.Text) -
                        Convert.ToDouble(textBoxTotalPrecioProyectoDevoluciones.Text)).ToString("0.00");
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
                    material_seleccion = Materiales_disponibles.
                            Find(material_combo => material_combo.Codigo.Contains(material.Codigo_material));
                    if (material_seleccion.divisa == "Pesos")
                    {
                        Precio_unitario = Convert.ToDouble(material_seleccion.precio);
                        Total_precio = Convert.ToDouble(material.Cantidad) * Precio_unitario;
                    }
                    else if (material_seleccion.divisa == "Dolares")
                    {
                        Precio_unitario = Convert.ToDouble(material_seleccion.precio) * Convert.ToDouble(datos_generales.Tc);
                        Total_precio = Convert.ToDouble(material.Cantidad) * Precio_unitario;

                    }
                    Total_precio_proyecto_devolucion += Total_precio;
                    dataGridViewProyectoReportes.Rows.Add(material_seleccion.Codigo,
                           material_seleccion.Codigo_proveedor,
                            material_seleccion.Descripcion, material_seleccion.Marca,
                            material.Cantidad, material.Nombre_empleado, material.Fecha,
                            Precio_unitario.ToString("0.00"), Total_precio.ToString("0.00"),
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
            textBoxTotalPrecioProyectoDevoluciones.Text = Total_precio_proyecto_devolucion.ToString("0.00");
        }

        private void Rellena_partida_materiales_salida_proyecto()
        {
            double Total_precio_proyecto_salidas = 0.0; 
            double Total_precio = 0.0;
            double Precio_unitario = 0.0;
            Ordenes_compra_disponibles = Class_Ordenes_Compra.
                Adquiere_ordenes_compra_disponibles_en_base_datos();
            foreach(Salida_Material material in Salida_materiales_disponibles)
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
                        material_seleccion = Materiales_disponibles.
                            Find(material_combo => material_combo.Codigo.Contains(material.Codigo_material));
                        if (material_seleccion.divisa == "Pesos")
                        {
                            Precio_unitario = Convert.ToDouble(material_seleccion.precio);
                            Total_precio = Convert.ToDouble(material.Cantidad) * Precio_unitario;
                        }
                        else if (material_seleccion.divisa == "Dolares")
                        {
                            Precio_unitario = Convert.ToDouble(material_seleccion.precio) * Convert.ToDouble(datos_generales.Tc);
                            Total_precio = Convert.ToDouble(material.Cantidad) * Precio_unitario;

                        }
                        Total_precio_proyecto_salidas += Total_precio;

                        dataGridViewProyectoReportes.Rows.Add(material_seleccion.Codigo,
                          material_seleccion.Codigo_proveedor,
                           material_seleccion.Descripcion, material_seleccion.Marca,
                           material.Cantidad, material.Nombre_empleado, material.Fecha,
                           Precio_unitario.ToString("0.00"), Total_precio.ToString("0.00"),
                           Partida_orden_compra_seleccion.Proyecto,
                           Partida_orden_compra_seleccion.Cantidad,
                           Partida_orden_compra_seleccion.Codigo_orden,
                           "Salida", "");
                    }
                    else if (material.Orden_compra == "NA")
                    {
                       
                        Material_busqueda.Codigo = material.Codigo_material;
                        Materiales_disponibles = Class_Materiales.Adquiere_materiales_codigo_material_en_base_datos(Material_busqueda);
                        material_seleccion = Materiales_disponibles.
                            Find(material_combo => material_combo.Codigo.Contains(material.Codigo_material));
                        if (material_seleccion.divisa == "Pesos")
                        {
                            Precio_unitario = Convert.ToDouble(material_seleccion.precio);
                            Total_precio = Convert.ToDouble(material.Cantidad) * Precio_unitario;
                        }
                        else if (material_seleccion.divisa == "Dolares")
                        {
                            Precio_unitario = Convert.ToDouble(material_seleccion.precio) * Convert.ToDouble(datos_generales.Tc);
                            Total_precio = Convert.ToDouble(material.Cantidad) * Precio_unitario;

                        }
                        dataGridViewProyectoReportes.Rows.Add(material_seleccion.Codigo,
                            material_seleccion.Codigo_proveedor,
                            material_seleccion.Descripcion, Materiales_disponibles[0].Marca,
                            material.Cantidad, material.Nombre_empleado, material.Fecha,
                            Precio_unitario.ToString("0.00"), Total_precio.ToString("0.00"),
                            "",
                            "",
                            "",
                            "Salida", "");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            textBoxTotalPrecioProyectoSalidas.Text = Total_precio_proyecto_salidas.ToString("0.00");
        }

        private void Asigna_campos_salida_materiales()
        {
            Busqueda_salida_material.Proyecto = comboBoxCodigoProyecto.Text;
        }

        private void buttonReporteProyectos_Click(object sender, EventArgs e)
        {
            Operacio_reporte_proyectos = "proyectos";
            Aparece_cajas_etiquetas_reporte_proyectos();
            Obtener_datos_proyectos_disponibles_base_datos();
            Rellena_combo_codigo_proyecto();

        }

        private void Aparece_cajas_etiquetas_reporte_proyectos()
        {
            labelCodigoProyecto.Visible = true;
            comboBoxCodigoProyecto.Visible = true;
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
            labelTotalSalidas.Visible = true;
            textBoxTotalPrecioProyectoSalidas.Visible = true;
            labelTotalDevoluciones.Visible = true;
            textBoxTotalPrecioProyectoDevoluciones.Visible = true;
            labelTotalProyectoPrecio.Visible = true;
            textBoxTotalPrecioProyecto.Visible = true;
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
            labelTotalSalidas.Visible = false;
            textBoxTotalPrecioProyectoSalidas.Visible = false;
            labelTotalDevoluciones.Visible = false;
            textBoxTotalPrecioProyectoDevoluciones.Visible = false;
            labelTotalProyectoPrecio.Visible = false;
            textBoxTotalPrecioProyecto.Visible = false;
        }

        private void buttonReporteUsuarios_Click(object sender, EventArgs e)
        {
            Operacio_reporte_proyectos = "Usuarios";
            Aparece_boton_cancelar_operacio();
            Aparece_elementos_reporte_usuarios_reporte();
            Obtener_empleados_disponibles();
            Limpia_combo_nombre_empleados();
            Rellena_combo_usuarios();

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
            Usuarios_disponibles = clase_usuarios.Adquiere_usuarios_disponibles_en_base_datos();
        }

        private void Aparece_elementos_reporte_usuarios_reporte()
        {
            labelNombreEmpleado.Visible = true;
            comboBoxNombreEmpleado.Visible = true;
        }
        private void Deaparece_elementos_reporte_usuarios_reporte()
        {
            labelNombreEmpleado.Visible = false;
            comboBoxNombreEmpleado.Visible = false;
        }

        private void comboBoxNombreEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpia_datagrid_materiales_proyecto();
            Activa_datagridview_dibujos_proyecto();
            obtener_salida_materiales_usuario();
            Rellena_partida_materiales_salida_proyecto();
            Obtener_devoluciones_materiales_usuarios();
            Rellena_partida_materiales_devolucion_proyecto();

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
            timerBusquedaMaterial.Enabled = true;
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

        private void timerBusquedaMaterial_Tick(object sender, EventArgs e)
        {
            if (
                textBoxCodigoProveedor.Text != "" ||
                textCodigoMaterial.Text != "" ||
                textBoxDescripcionMaterial.Text != "")
            {
                timerBusquedaMaterial.Enabled = false;
                buttonBusquedaBaseDatos.Visible = true;
            }
        }

        private void buttonBusquedaBaseDatos_Click(object sender, EventArgs e)
        {
            Desactiva_boton_busqueda();
           
        }

        private void Desactiva_boton_busqueda()
        {
            buttonBusquedaBaseDatos.Enabled = false;
        }
    }
}
