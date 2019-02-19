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
        public Class_Usuarios class_Usuarios = new Class_Usuarios();
        public Usuario Usuario_requisitores = new Usuario();
        public List<Usuario> Usuarios_administrativos = new List<Usuario>();
        public Usuario Usuario_seleccionado = new Usuario();
        public Class_Datos_Generales Class_datos_generales = new Class_Datos_Generales();
        public Datos_generales datos_Generales = new Datos_generales();
        public List<Orden_compra> ordenes_compra_disponibles = new List<Orden_compra>();
        public Class_Ordenes_Compra Class_ordenes_compra = new Class_Ordenes_Compra();
        public Orden_compra orden_compra_visualizar = new Orden_compra();
        public Orden_compra orden_compra_modificar = new Orden_compra();
        public Orden_compra orden_compra_seleccionada = new Orden_compra();
        public List<Partida_orden_compra> partidas_ordenes_compra_disponibles =
            new List<Partida_orden_compra>();
        public Class_Materiales Class_Materiales = new Class_Materiales();
        public List<Material> Materiales_disponible_entrada_materiales = new List<Material>();
        public Material Material_disponible_entrada_materiales = new Material();
        public Entrada_Material Insertar_entrada_materiales = new Entrada_Material();
        public Entrada_Material Entrada_materiales_seleccion = new Entrada_Material();
        public Class_Entrada_Material Class_entrada_material = new Class_Entrada_Material();
        public List<Entrada_Material> Entrada_materiales_disponibles = new List<Entrada_Material>();
        public Class_Partidas_Orden_compra class_partidas_Orden_compra = new Class_Partidas_Orden_compra();
        public Partida_orden_compra Partida_orden_compra_seleccionada = new Partida_orden_compra();
        public Material Visualizar_material = new Material();
        public Material Busqueda_material = new Material();
        public List<Material> Materiales_disponibles_busqueda = new List<Material>();
        string RenglonParaEliminar = "";
        string appPath = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
        public CultureInfo cultureInfo = new CultureInfo("en-US");
        public string nombre_archivo_word = "";
        public word.Application application = null;
        public word.Document Documento = null;
        public enum Campos_entrada_materiales_visualizar
        {
            codigo, orden_compra, fecha, codigo_material, cidigo_proveedor, nombre_empleado, descripcion,
            cantidad, precio, tipo_cambio, referencia
        };

        public enum Campos_entrada_materiales_agregar
        {
            codigo, codigo_material, codigo_proveedor, descripcion, unidades_entrada,
            cantidad_entrada, precio, divisa
        };

        public string Operacio_entrada_materiales = "";

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

            comboBoxCodigoOrdenCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBoxCodigoOrdenCompra.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCodigoOrdenCompra.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBoxEmpleado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxEmpleado.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxCodigoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBoxCodigoEmpleado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCodigoEmpleado.AutoCompleteSource = AutoCompleteSource.ListItems;

        }


        private void buttonHome_Click(object sender, EventArgs e)
        {
            Materiales_disponibles_busqueda = null;
            Materiales_disponible_entrada_materiales = null;
            partidas_ordenes_compra_disponibles = null;
            Entrada_materiales_disponibles = null;
            ordenes_compra_disponibles = null;
            class_folio_disponible = null;
            folio_disponible = null;
            Usuarios_administrativos = null;
            this.Dispose();
            GC.Collect();
            this.Close();
        }





        private void Visualiza_entrada_materiales()
        {
            Operacio_entrada_materiales = "Visualizar OC";
            Aparece_datagridview_entrada_visualizar();
            Desactiva_botones_operacion();
            Desaparece_caja_captura_codigo_orden_compra();
            Aparece_boton_cancelar_operacio();
            Acepta_datagridview_agregar_renglones();
            Activa_dataview_partidas_ordenes_compra();
            limpia_combo_ordenes_compra();
            Aparece_combo_orden_compra();
            Activa_combo_orden_compra();
            obtener_ordenes_compra_disponibles();
            Rellenar_combo_ordenes_compra();
        }

        private void Rellenar_combo_ordenes_compra()
        {
            foreach (Orden_compra orden in ordenes_compra_disponibles)
            {
                if (orden.error == "")
                {
                    if (Operacio_entrada_materiales == "Visualizar OC")
                    {
                        comboBoxCodigoOrdenCompra.Items.Add(orden.Codigo);
                    }
                    else
                    {
                        if (orden.Estado_entrada != "Cerrada" && orden.Estado_entrada!= "Cancelada")
                        {
                            comboBoxCodigoOrdenCompra.Items.Add(orden.Codigo);
                        }
                    }
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
            dataGridViewPartidasEntradaMaterialesVisualizar.Enabled = true;
        }

        private void limpia_partidas_ordenes_compra_visualizar()
        {
            dataGridViewPartidasEntradaMaterialesVisualizar.Rows.Clear();
        }

        private void No_aceptar_agregar_partidas_ordenes_compra()
        {
            dataGridViewPartidasEntradaMaterialesVisualizar.AllowUserToAddRows = false;
        }

        private void Aparece_boton_cancelar_operacio()
        {
            buttonCancelar.Visible = true;
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
            Termina_secuencia_operaciones_entrada_materiales();
        }




        private void Limpia_textbox_divisa()
        {
            textBoxTotalUnidades.Text = "";
        }


        private void Limpia_combo_descripcion_materiales()
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


        private void configura_forma_agregar()
        {
            Desactiva_combobox_codigo_orden_compra();
            Obtener_orden_compra_seleccionada();
            Muestra_informacion_orden_compra();
            //Limpia_combo_descripcion_materiales();
            //Aparecer_combo_descripcion_materiales();
            //Activa_combo_descripcion_materiales();
            //Desaparece_textbox_descripcion_materiales();
            if (orden_compra_seleccionada.Estado_entrada != "Cancelada" && orden_compra_seleccionada.Estado_entrada != "Cerrada")
            {
                Limpia_datagridview_agrega_materiales();
                Obtener_materiales_ordenes_compra();
                if (Rellena_datagridview_agregar_materiales() != 0)
                {
                    No_acepta_datagridview_agregar_renglones();
                    Limpia_combo_empleado();
                    Limpia_combo_empleado_codigo();
                    Aparece_combo_empleado();
                    Activa_combo_empleado();
                    Aparece_combo_empleado_codigo();
                    Activa_combo_empleado_codigo();
                    obtener_usuarios_administrativos_compras_disponibles();
                    Rellena_combo_empleado();
                    Activa_seleccion_fecha_actual();
                    Activa_grupo_referencia();
                    Activa_textbox_referencia();
                }
            }
            else
            {
                MessageBox.Show("Orden de Compra " + textBoxEstadoOC.Text, "Entrada Material", 
                MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                Termina_secuencia_operaciones_entrada_materiales();
            }
            //Rellena_combo_descripcion_materiales();

        }

        private void Muestra_informacion_orden_compra()
        {
            textBoxEstadoOC.Text = orden_compra_seleccionada.Estado_entrada;
        }

        private void Obtener_orden_compra_seleccionada()
        {
            orden_compra_seleccionada = ordenes_compra_disponibles.Find(orden_compra_seleccion => 
            orden_compra_seleccion.Codigo.Contains(comboBoxCodigoOrdenCompra.Text));
        }

        private int Rellena_datagridview_agregar_materiales()
        {
            int Row_material = 0;
            int Unidades_ordenadas = 0;
            Limpia_datagridview_agrega_materiales();
            foreach (Partida_orden_compra partida_orden_compra in partidas_ordenes_compra_disponibles)
            {

                try
                {
                    Partida_orden_compra_seleccionada = partida_orden_compra;
                    if (Obtener_materiales_con_codigo_material())
                    {
                        Material_disponible_entrada_materiales = Materiales_disponible_entrada_materiales.Find(
                        material_disponible => material_disponible.Codigo.Contains(partida_orden_compra.Material));
                    }

                    Unidades_ordenadas = Convert.ToInt32(partida_orden_compra.Cantidad) - Calculo_unidades_entradas();
                    if (Unidades_ordenadas != 0)
                    {
                        if (Material_disponible_entrada_materiales.Generico == "1")
                        {
                            dataGridViewPartidasEntradaMaterialesEntrada.Rows.Add(partida_orden_compra.Codigo.ToString(), Material_disponible_entrada_materiales.Codigo,
                                Material_disponible_entrada_materiales.Codigo_proveedor, partida_orden_compra.Descripcion, Unidades_ordenadas.ToString(),
                                "", partida_orden_compra.precio_unitario, Material_disponible_entrada_materiales.divisa);
                        }
                        else
                        {
                            dataGridViewPartidasEntradaMaterialesEntrada.Rows.Add(partida_orden_compra.Codigo.ToString(), Material_disponible_entrada_materiales.Codigo,
                                Material_disponible_entrada_materiales.Codigo_proveedor, Material_disponible_entrada_materiales.Descripcion, Unidades_ordenadas.ToString(),
                                "", partida_orden_compra.precio_unitario, Material_disponible_entrada_materiales.divisa);
                        }
                        dataGridViewPartidasEntradaMaterialesEntrada["Cantidad_recibidas",
                            Row_material].Style.BackColor = Color.Yellow;
                        Row_material++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return 0;
                }

            }
            return Row_material;
        }
        private int Verifica_materiales_ordenes_compra()
        {
            int Row_material = 0;
            int Unidades_ordenadas = 0;
            Limpia_datagridview_agrega_materiales();
            foreach (Partida_orden_compra partida_orden_compra in partidas_ordenes_compra_disponibles)
            {

                try
                {
                    /*Partida_orden_compra_seleccionada = partidas_ordenes_compra_disponibles.
                        Find(partidas_ordenes_compra => partidas_ordenes_compra.Descripcion.Contains(partida_orden_compra.Descripcion));*/
                    Partida_orden_compra_seleccionada = partida_orden_compra;
                    if (Obtener_materiales_con_codigo_material())
                    {
                        Material_disponible_entrada_materiales = Materiales_disponible_entrada_materiales.Find(
                        material_disponible => material_disponible.Codigo.Contains(partida_orden_compra.Material));
                    }

                    Unidades_ordenadas = Convert.ToInt32(partida_orden_compra.Cantidad) - Calculo_unidades_entradas();
                    if (Unidades_ordenadas != 0)
                    {
                        Row_material++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return 0;
                }

            }
            return Row_material;
        }

        private int Calculo_unidades_entradas()
        {
            Obtener_partidas_entrada_materiales();
            int Total_cantidad = 0;
            for (int renglones = 0; renglones < Entrada_materiales_disponibles.Count; renglones++)
            {

                try
                {
                    Total_cantidad = Total_cantidad + Convert.ToInt32(Entrada_materiales_disponibles[renglones].Cantidad);
                }
                catch
                {
                    MessageBox.Show("No valores numericos en cantidad", "Entrada Materriales",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            return Total_cantidad;

        }

        private void Limpia_datagridview_agrega_materiales()
        {
            dataGridViewPartidasEntradaMaterialesEntrada.Rows.Clear();
        }

        private void Obtener_materiales_ordenes_compra()
        {
            partidas_ordenes_compra_disponibles = class_partidas_Orden_compra.
                Adquiere_partidas_ordenes_compra_disponibles_en_base_datos(comboBoxCodigoOrdenCompra.Text);
        }

        private void Rellena_combo_descripcion_materiales()
        {
            foreach (Partida_orden_compra partida in partidas_ordenes_compra_disponibles)
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

        private void Activa_combo_empleado_codigo()
        {
            comboBoxCodigoEmpleado.Enabled = true;
        }

        private void Aparece_combo_empleado_codigo()
        {
            comboBoxCodigoEmpleado.Visible = true;
        }

        private void Desaparece_textbox_requisitor()
        {
            textBoxEmpleado.Visible = false;
        }


        private void configura_forma_visualizar()
        {
            //Desactiva_combobox_codigo_orden_compra();
            //Limpia_combo_descripcion_materiales();
            //Aparecer_combo_descripcion_materiales();
            //Activa_combo_descripcion_materiales();
            Desaparece_textbox_descripcion_materiales();
            Mostrar_materiales_entrada();
            
            //Rellena_combo_descripcion_materiales();

        }

        private void Mostrar_materiales_entrada()
        {
            Obtener_materiales_ordenes_compra();
            foreach(Partida_orden_compra orden in partidas_ordenes_compra_disponibles)
            {
                Entrada_materiales_seleccion.Codigo_material = orden.Material;
                Entrada_materiales_seleccion.Orden_compra = orden.Codigo_orden;
                Entrada_materiales_disponibles = Class_entrada_material.
                    Adquiere_entrada_materiales_busqueda_en_base_datos(Entrada_materiales_seleccion);
                Rellena_datagrid_entrada_materiales();
            }
            
            
        }

        private void Aparece_boton_eliminar_datos_en_base_de_datos()
        {
            buttonBorrarBasedeDatos.Visible = true;
        }


        private void Desaparece_textbox_realizado()
        {
            comboBoxEmpleado.Visible = false;
        }

        private void Aparece_boton_guardar_base_datos()
        {
            buttonGuardarBasedeDatos.Visible = true;
        }

        private void Asigna_datos_en_cajas_a_variable()
        {

        }

        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos_modificar_clientes()
        {
            timerBusquedaMaterial.Enabled = true;
        }

        private void Desactiva_combobox_codigo_orden_compra()
        {
            comboBoxCodigoOrdenCompra.Enabled = false;
        }

        private void buttonAgregarCotizacion_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("La entrada de Material cuenta con orden de compra?",
                "Entrada Material", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Agrega_entrada_materiales_orden_compra();

            }
            else
            {
                Agrega_entrada_materiales();
            }
        }

        private void Aparece_datagridview_entrada_materiales()
        {
            dataGridViewPartidasEntradaMaterialesEntrada.Visible = true;
        }

        private void Agrega_entrada_materiales()
        {
            Operacio_entrada_materiales = "Agregar";
            Aparece_datagridview_entrada_visualizar();
            Desactiva_botones_operacion();
            Acepta_datagridview_agregar_renglones();
            Aparece_boton_cancelar_operacio();
            Activa_datagridview_partidas_entrada_materiales();
            Activa_textbox_codigo_proveedor();
            Activa_textbox_descripcion_material();
            Activa_textbox_codigo_material();
            Activa_textbox_referencia();
            Activa_grupo_referencia();
            Asigna_caracter_busqueda_material();
            Inicia_timer_busqueda_materiales();
            
        }

        private void Aparece_datagridview_entrada_visualizar()
        {
            dataGridViewPartidasEntradaMaterialesVisualizar.Visible = true;
        }

        public void secuencia_despues_de_busqueda_material()
        {
            if (Operacio_entrada_materiales == "Visualizar" || Operacio_entrada_materiales == "Visualizar OC")
            {

            }
            else
            {
                Limpia_combo_empleado();
                Limpia_combo_empleado_codigo();
                Aparece_combo_empleado();
                Activa_combo_empleado();
                obtener_usuarios_administrativos_compras_disponibles();
                Rellena_combo_empleado();
                Activa_seleccion_fecha_actual();
                Activa_textbox_cantidad_material();
                Activa_textbox_precio();
                Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_material();
            }
        }

        private void Activa_textbox_precio()
        {
            textBoxPrecioMaterial.Enabled = true;
        }

        private void Activa_textbox_cantidad_material()
        {
            textBoxUnidadesEntrada.Enabled = true;
        }

        private void Inicia_timer_busqueda_materiales()
        {
            timerBusquedaMaterial.Enabled = true;
        }

        private void Asigna_caracter_busqueda_material()
        {
            textBoxCodigoProveedor.BackColor = Color.Yellow;
            textCodigoMaterial.BackColor = Color.Yellow;
            textBoxDescripcionMaterial.BackColor = Color.Yellow;

        }

        private void Activa_textbox_codigo_material()
        {
            textCodigoMaterial.Enabled = true;
        }

        private void Activa_textbox_descripcion_material()
        {
            textBoxDescripcionMaterial.Enabled = true;
        }

        private void Agrega_entrada_materiales_orden_compra()
        {
            Operacio_entrada_materiales = "Agregar OC";
            Aparece_datagridview_entrada_materiales();
            Desactiva_botones_operacion();
            Acepta_datagridview_agregar_renglones();
            Aparece_boton_cancelar_operacio();
            Activa_datagridview_partidas_entrada_materiales();
            //Activa_textbox_codigo_proveedor();
            Limpia_datagridview_agrega_materiales();
            limpia_combo_ordenes_compra();
            Aparece_combo_orden_compra();
            Activa_combo_orden_compra();
            obtener_ordenes_compra_disponibles();
            Rellenar_combo_ordenes_compra();
            Aparece_textboxestadoOC();
            Aparece_label_estado_OC();
            Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_material();
            
        }

        private void Aparece_label_estado_OC()
        {
            textBoxEstadoOC.Visible = true;
        }

        private void Aparece_textboxestadoOC()
        {
            labelEstadoOC.Visible = true;
        }

        private void Activa_textbox_referencia()
        {
            textBoxReferencia.Enabled = true;
        }

        private void Activa_grupo_referencia()
        {
            groupBoxReferencia.Enabled = true;
        }

        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_material()
        {
            timerAgregarEntradaMateriales.Enabled = true;
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
                {
                    comboBoxEmpleado.Items.Add(usuario.nombre_empleado);
                    comboBoxCodigoEmpleado.Items.Add(usuario.codigo_empleado);
                }
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

        private void Limpia_combo_empleado_codigo()
        {
            comboBoxCodigoEmpleado.Items.Clear();
            comboBoxCodigoEmpleado.Text = "";
        }

        private void Activa_textbox_codigo_proveedor()
        {
            textBoxCodigoProveedor.Enabled = true;
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
            dataGridViewPartidasEntradaMaterialesVisualizar.AllowUserToAddRows = true;
        }

        private void No_acepta_datagridview_agregar_renglones()
        {
            dataGridViewPartidasEntradaMaterialesEntrada.AllowUserToAddRows = false;
        }

        private void Activa_datagridview_partidas_entrada_materiales()
        {
            dataGridViewPartidasEntradaMaterialesEntrada.Enabled = true;
        }

        private void Desactiva_columna_codigo_partidas_cotizaciones()
        {
            dataGridViewPartidasEntradaMaterialesVisualizar.Columns[0].Visible = false;
        }

        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_orden_compra()
        {
            timerAgregarEntradaMateriales.Enabled = true;
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
            if (Operacio_entrada_materiales == "Agregar OC")
                Secuencia_agregar_entrada_materiales_ordenes_compra();
            else if (Operacio_entrada_materiales == "Agregar")
                Secuencia_agregar_entrada_materiales();
        }


        private void Aparce_caja_codigo_cliente()
        {
            textBoxCodigoOrdenCompra.Visible = true;
        }


        private void Secuencia_agregar_entrada_materiales_ordenes_compra()
        {
            if (Verifica_datos_partidas_entradas_materiales())
            {
                if (verfica_datos_entrada_materiales())
                {
                    if(Insertar_datos_entrada_materiales())
                    {
                        if(Agrega_entrada_materiales_base_datos())
                        {
                            Verifica_estado_orden_compra();
                            Limpia_cajas_captura_despues_de_agregar_orden_compra();
                            Limpia_combo_nombre_cliente();
                            Limpia_combo_descripcion_materiales();
                            Desactiva_cajas_captura_despues_de_agregar_orden_compra();
                            Desaparece_boton_guardar_base_de_datos();
                            Desaparece_boton_cancelar();
                            Desaparece_combo_codigo_cotizacion();
                            Activa_botones_operacion();
                            limpia_partidas_ordenes_compra_visualizar();
                            limpia_partidas_ordenes_compra_entradas();
                            Desactiva_datagridview_partidas();
                            Desaparece_combo_cliente_nombre();
                            Desactiva_combo_cliente_nombre();
                            Desaparece_combo_cliente_codigo();
                            Desactiva_combo_cliente_codigo();
                            Desaparece_combo_atencion();
                            Desactiva_combo_atencion();
                            Desactiva_grupo_referencia();
                            Aparece_textbox_nombre_cliente();
                            Aparece_textbox_nombre_cliente();
                            Aparece_textbox_atencion();
                            Desaparece_textbox_estadoOC();
                            Desaparece_label_estadoOC();
                            Desaparece_datagridview_entrada_materiales();
                            Elimina_informacion_orden_compra_disponibles();
                        }
                    }

                }
            }
        }

        private void Verifica_estado_orden_compra()
        {
            string Respuesta = "";
            Obtener_materiales_ordenes_compra();
            orden_compra_seleccionada.Codigo = comboBoxCodigoOrdenCompra.Text;
            if (Verifica_materiales_ordenes_compra() != 0)
            {
                Respuesta = Class_ordenes_compra.Modifica_estado_entrada_orden_compra(orden_compra_seleccionada, "Parcial");
                if (Respuesta != "No Errores")
                {
                    MessageBox.Show(Respuesta);
                }
            }
            else
            {
                Respuesta = Class_ordenes_compra.Modifica_estado_entrada_orden_compra(orden_compra_seleccionada, "Cerrar");
                if (Respuesta != "No Errores")
                {
                    MessageBox.Show(Respuesta);
                }
            }

        }

        private void Desactiva_grupo_referencia()
        {
            groupBoxReferencia.Enabled = false;
        }

        private void limpia_partidas_ordenes_compra_entradas()
        {
            dataGridViewPartidasEntradaMaterialesEntrada.Rows.Clear();
        }

        private void Desaparece_datagridview_entrada_materiales()
        {
            dataGridViewPartidasEntradaMaterialesEntrada.Visible = false;
        }

        private bool Agrega_entrada_materiales_base_datos()
        {
            string respuesta = "";
            for (int partidas = 0; partidas < dataGridViewPartidasEntradaMaterialesEntrada.Rows.Count; partidas++)
            {
                if (dataGridViewPartidasEntradaMaterialesEntrada[(int)Campos_entrada_materiales_agregar.
                    cantidad_entrada, partidas].Value.ToString() != "")
                {
                    /*Busqueda_material.Descripcion = dataGridViewPartidasEntradaMaterialesEntrada[
                        (int)Campos_entrada_materiales_agregar.descripcion, partidas].Value.ToString();*/
                    Busqueda_material.Codigo = dataGridViewPartidasEntradaMaterialesEntrada[
                    (int)Campos_entrada_materiales_agregar.codigo_material, partidas].Value.ToString();
                    Materiales_disponibles_busqueda = Class_Materiales.
                        Adquiere_materiales_codigo_material_en_base_datos(Busqueda_material);
                    Visualizar_material = Materiales_disponibles_busqueda.Find(material_disponible =>
                    material_disponible.Codigo.Contains(Busqueda_material.Codigo));

                    Visualizar_material.Cantidad = (Convert.ToInt32(
                    Visualizar_material.Cantidad.ToString()) +
                                Convert.ToUInt32(dataGridViewPartidasEntradaMaterialesEntrada[
                         (int)Campos_entrada_materiales_agregar.cantidad_entrada, partidas].Value.ToString())).ToString();
                    Visualizar_material.precio =
                        dataGridViewPartidasEntradaMaterialesEntrada[
                        (int)Campos_entrada_materiales_agregar.precio, partidas].Value.ToString();

                    respuesta = Class_Materiales.Actualiza_base_datos_materiales(
                    Visualizar_material);
                    if (respuesta != "NO errores")
                    {
                        MessageBox.Show(respuesta, "Entrada Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private bool Insertar_datos_entrada_materiales()
        {
            for (int partidas = 0; partidas < dataGridViewPartidasEntradaMaterialesEntrada.Rows.Count; partidas++)
            {
                if (dataGridViewPartidasEntradaMaterialesEntrada[(int)Campos_entrada_materiales_agregar.
                    cantidad_entrada, partidas].Value.ToString() != "")
                {
                    Insertar_entrada_materiales.Orden_compra = comboBoxCodigoOrdenCompra.Text;
                    if (radioButtonFactura.Checked)
                        Insertar_entrada_materiales.Referencia = "F-" + textBoxReferencia.Text;
                    else if (radioButtonRemision.Checked)
                        Insertar_entrada_materiales.Referencia = "R-" + textBoxReferencia.Text;
                    Insertar_entrada_materiales.Descripcion_material =
                        dataGridViewPartidasEntradaMaterialesEntrada[(int)Campos_entrada_materiales_agregar.descripcion, partidas].Value.ToString();
                    Insertar_entrada_materiales.Codigo_proveedor =
                         dataGridViewPartidasEntradaMaterialesEntrada[(int)Campos_entrada_materiales_agregar.codigo_proveedor, partidas].Value.ToString();
                    Insertar_entrada_materiales.Nombre_empleado = comboBoxEmpleado.Text;
                    Insertar_entrada_materiales.Fecha = dateTimePickerFechaActual.Text;
                    Insertar_entrada_materiales.Codigo_material =
                        dataGridViewPartidasEntradaMaterialesEntrada[(int)Campos_entrada_materiales_agregar.codigo_material, partidas].Value.ToString();
                    Insertar_entrada_materiales.Precio =
                        dataGridViewPartidasEntradaMaterialesEntrada[(int)Campos_entrada_materiales_agregar.precio, partidas].Value.ToString();
                    Insertar_entrada_materiales.Cantidad =
                        dataGridViewPartidasEntradaMaterialesEntrada[(int)Campos_entrada_materiales_agregar.cantidad_entrada, partidas].Value.ToString();
                    Insertar_entrada_materiales.Divisa =
                        dataGridViewPartidasEntradaMaterialesEntrada[(int)Campos_entrada_materiales_agregar.divisa, partidas].Value.ToString();
                    if (Convert.ToInt32(Insertar_entrada_materiales.Cantidad) != 0)
                    {
                        if (!Insertar_datos_entrada_materiales_class())
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        private bool Verifica_datos_partidas_entradas_materiales()
        {
            for (int partidas = 0; partidas < dataGridViewPartidasEntradaMaterialesEntrada.Rows.Count; partidas++)
            {
                for (int campo = 1; campo < dataGridViewPartidasEntradaMaterialesEntrada.Rows[partidas].Cells.Count; campo++)
                {
                    if (dataGridViewPartidasEntradaMaterialesEntrada.Rows[partidas].
                        Cells[(int)Campos_entrada_materiales_agregar.cantidad_entrada].Value.ToString() != "")
                    {
                        if (dataGridViewPartidasEntradaMaterialesEntrada.Rows[partidas].Cells[campo].Value.ToString() == "")
                        {
                            MessageBox.Show("campo en blanco");
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void Secuencia_agregar_entrada_materiales()
        {
            if (verifica_campos_numericos())
            {
                if (verfica_datos_entrada_materiales())
                {
                    if (Insertar_datos_entrada_materiales_class())
                    {
                        if (Agrega_entrada_material_base_datos())
                        {
                            Limpia_cajas_captura_despues_de_agregar_orden_compra();
                            Limpia_combo_nombre_cliente();
                            Limpia_combo_descripcion_materiales();
                            Desactiva_cajas_captura_despues_de_agregar_orden_compra();
                            Desaparece_boton_guardar_base_de_datos();
                            Desaparece_boton_cancelar();
                            Desaparece_combo_codigo_cotizacion();
                            Activa_botones_operacion();
                            limpia_partidas_ordenes_compra_visualizar();
                            Desactiva_datagridview_partidas();
                            Desaparece_combo_cliente_nombre();
                            Desactiva_combo_cliente_nombre();
                            Desaparece_combo_cliente_codigo();
                            Desactiva_combo_cliente_codigo();
                            Desaparece_combo_atencion();
                            Desactiva_combo_atencion();
                            Aparece_textbox_nombre_cliente();
                            Aparece_textbox_nombre_cliente();
                            Aparece_textbox_atencion();
                            Desaparece_datagridview_entrada_visualizar();
                            Elimina_informacion_orden_compra_disponibles();
                        }
                    }

                }
            }

        }

        private void Desaparece_datagridview_entrada_visualizar()
        {
            dataGridViewPartidasEntradaMaterialesVisualizar.Visible = false;
        }

        private bool verica_cantidad_entrada()
        {
            try
            {
                if (Convert.ToInt32(textBoxUnidadesEntrada.Text) + Convert.ToInt32(textBoxUnidadesEntradas.Text) <=
                    Convert.ToInt32(textBoxTotalUnidades.Text))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Cantidad Entrada Mayor a Cantidad OC", "Entrada Material", MessageBoxButtons.OK,
                      MessageBoxIcon.Exclamation);
                    textBoxUnidadesEntrada.Text = "";
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool Agrega_entrada_material_base_datos()
        {
            string respuesta = "";
            Material_disponible_entrada_materiales.Cantidad = (Convert.ToInt32(
                Material_disponible_entrada_materiales.Cantidad.ToString()) +
                            Convert.ToUInt32(textBoxUnidadesEntrada.Text)).ToString();
           
            Material_disponible_entrada_materiales.precio = textBoxPrecioMaterial.Text;
            respuesta = Class_Materiales.Actualiza_base_datos_materiales(
                Material_disponible_entrada_materiales);
            if (respuesta == "NO errores")
            {
                return true;
            }
            else
            {
                MessageBox.Show(respuesta, "Entrada Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool Insertar_datos_entrada_materiales_class()
        {
            string respuesta = "";
            if (Operacio_entrada_materiales == "Agregar")
            {
                Asigna_valores_entrada_materiales();
            }
                respuesta = Class_entrada_material.Inserta_nuevo_entrada_material_base_datos(
                Insertar_entrada_materiales);
            if (respuesta == "NO errores")
            {
                return true;
            }
            else
            {
                MessageBox.Show(respuesta, "Entrada Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void Asigna_valores_entrada_materiales()
        {
            if (Operacio_entrada_materiales == "Agregar OC")
            {
                Insertar_entrada_materiales.Orden_compra = comboBoxCodigoOrdenCompra.Text;
                Insertar_entrada_materiales.Descripcion_material = comboBoxDescripcionMaterial.Text;
                Insertar_entrada_materiales.Codigo_proveedor = textBoxCodigoProveedor.Text;
                Insertar_entrada_materiales.Nombre_empleado = comboBoxEmpleado.Text;
                Insertar_entrada_materiales.Fecha = dateTimePickerFechaActual.Text;
                Insertar_entrada_materiales.Codigo_material = textCodigoMaterial.Text;
                Insertar_entrada_materiales.Precio = textBoxPrecioMaterial.Text;
                Insertar_entrada_materiales.Cantidad = textBoxUnidadesEntrada.Text;
            }
            else
            {
                Insertar_entrada_materiales.Orden_compra = "NA";
                Insertar_entrada_materiales.Descripcion_material = textBoxDescripcionMaterial.Text;
                Insertar_entrada_materiales.Codigo_proveedor = textBoxCodigoProveedor.Text;
                Insertar_entrada_materiales.Nombre_empleado = comboBoxEmpleado.Text;
                Insertar_entrada_materiales.Fecha = dateTimePickerFechaActual.Text;
                Insertar_entrada_materiales.Codigo_material = textCodigoMaterial.Text;
                Insertar_entrada_materiales.Precio = textBoxPrecioMaterial.Text;
                Insertar_entrada_materiales.Cantidad = textBoxUnidadesEntrada.Text;
                if (radioButtonFactura.Checked)
                    Insertar_entrada_materiales.Referencia = "F-" + textBoxReferencia.Text;
                else if (radioButtonRemision.Checked)
                    Insertar_entrada_materiales.Referencia = "R-" + textBoxReferencia.Text;
                Insertar_entrada_materiales.Divisa = textBoxDivisa.Text;
            }
        }

        private bool verfica_datos_entrada_materiales()
        {
            if (Operacio_entrada_materiales == "Agregar OC")
            {
                if (comboBoxCodigoOrdenCompra.Text != "" &&
                comboBoxEmpleado.Text != "")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Campos en blanco", "Entrada Materiales", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            else
            {
                if (
                textBoxDescripcionMaterial.Text != "" &&
                textBoxCodigoProveedor.Text != "" &&
                comboBoxEmpleado.Text != "" &&
                textCodigoMaterial.Text != "" &&
                textBoxPrecioMaterial.Text != "" &&
                textBoxUnidadesEntrada.Text != "")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Campos en blanco", "Entrada Materiales", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return false;
                }
            }
        }

        private bool verifica_campos_numericos()
        {
            if (Operacio_entrada_materiales == "Agregar")
            {
                return verifica_cantidad_numerico_cantidad_unidades() &&
                    verifica_cantidad_numerico_precio();
            }
            else
            {
                return verifica_cantidad_numerico_cantidad_unidades();
            }


        }
        private bool verifica_cantidad_numerico_cantidad_unidades()
        {
            try
            {
                Convert.ToInt32(textBoxUnidadesEntrada.Text);
                return true;
            }
            catch
            {
                textBoxUnidadesEntrada.Text = "";
                return false;
            }


        }

        private bool verifica_cantidad_numerico_precio()
        {

            try
            {
                Convert.ToSingle(textBoxPrecioMaterial.Text);
                return true;
            }
            catch
            {
                textBoxPrecioMaterial.Text = "";
                return false;
            }
        }

        private bool verifica_datos_partidas()
        {
            for (int partidas = 0; partidas < dataGridViewPartidasEntradaMaterialesVisualizar.Rows.Count - 1; partidas++)
            {
                for (int campo = 1; campo < dataGridViewPartidasEntradaMaterialesVisualizar.Rows[partidas].Cells.Count; campo++)
                {
                    if (dataGridViewPartidasEntradaMaterialesVisualizar.Rows[partidas].Cells[campo].Value == null)
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

        private void Desactiva_combo_cliente_codigo()
        {
            comboBoxCodigoEmpleado.Enabled = false;
        }

        private void Desaparece_combo_cliente_codigo()
        {
            comboBoxCodigoEmpleado.Visible = false;
        }
        private void Desactiva_datagridview_partidas()
        {
            dataGridViewPartidasEntradaMaterialesVisualizar.Enabled = false;
        }

        private void Elimina_informacion_orden_compra_disponibles()
        {
            partidas_ordenes_compra_disponibles = null;
            Materiales_disponible_entrada_materiales = null;
            partidas_ordenes_compra_disponibles = null;
            Entrada_materiales_disponibles = null;
            ordenes_compra_disponibles = null;
            class_folio_disponible = null;
            folio_disponible = null;
            Usuarios_administrativos = null;
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
            textBoxUnidadesEntrada.Enabled = false;
            textBoxPrecioMaterial.Enabled = false;
            textCodigoMaterial.Enabled = false;

        }


        private void Limpia_cajas_captura_despues_de_agregar_orden_compra()
        {
            textBoxEmpleado.Text = "";
            textBoxCodigoOrdenCompra.Text = "";
            dateTimePickerFechaActual.Text = DateTime.Today.ToString();
            textBoxDescripcionMaterial.Text = "";
            textBoxCodigoProveedor.Text = "";
            textBoxUnidadesEntrada.Text = "";
            textBoxUnidadesEntradas.Text = "";
            textBoxTotalUnidades.Text = "";
            textCodigoMaterial.Text = "";
            textBoxPrecioMaterial.Text = "";
            textBoxReferencia.Text = "";
            textBoxEstadoOC.Text = "";
        }



        private string Configura_cadena_comando_actualizar_en_base_de_datos_partidas_requisiciones(Partida_orden_compra partida_orden_compra_agregar)
        {
            return "UPDATE partidas_requisiciones set  orden_compra_asignada='" + partida_orden_compra_agregar.Codigo_orden +
                "' where codigo_requisicion='" + partida_orden_compra_agregar.Material + "' and numero_parte='" +
                partida_orden_compra_agregar.Parte + "' ;";
        }


        private string Configura_cadena_comando_insertar_en_base_de_datos_partidas_orden_compra(Partida_orden_compra partida_orden_compra)
        {
            return "INSERT INTO partidas_oredenes_compra(codigo_orden_compra,partida_compra, material_compra," +
                "cantidad_compra,parte_compra,descripcion_compra,unidad_medida,proyecto_compra,precio_unitario,total_compra) " +
                "VALUES('" + partida_orden_compra.Codigo_orden + "','" + partida_orden_compra.Partida + "','" +
                partida_orden_compra.Material + "','" + partida_orden_compra.Cantidad + "','" + partida_orden_compra.Parte + "','" +
                partida_orden_compra.Descripcion + "','" + partida_orden_compra.Unidad_medida + "','" + partida_orden_compra.Proyecto + "','" +
                partida_orden_compra.precio_unitario + "','" + partida_orden_compra.Total + "');";
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
            Operacio_entrada_materiales = "Modificar";
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
            Operacio_entrada_materiales = "Eliminar partida";
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
            Operacio_entrada_materiales = "Operaciones Patidas";
        }



        private void dataGridViewContactosClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Operacio_entrada_materiales == "Eliminar partida")
            {
                Aparece_boton_eliminar_datos_en_base_de_datos();
                RenglonParaEliminar = dataGridViewPartidasEntradaMaterialesVisualizar.Rows[e.RowIndex].Cells["Codigo_partida"].Value.ToString();
            }

        }



        private void comboBoxDescripcionMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            Limpia_datagridview_entrada_material();
            Partida_orden_compra_seleccionada = partidas_ordenes_compra_disponibles.Find(partidas_ordenes_compra => partidas_ordenes_compra.Descripcion.Contains(comboBoxDescripcionMaterial.SelectedItem.ToString()));
            Rellenar_campos_entrada_materiales();
            Rellenar_partidas_entrada_materiales();
        }

        private void Rellenar_partidas_entrada_materiales()
        {
            Obtener_partidas_entrada_materiales();
            Rellena_datagrid_entrada_materiales();
            Rellena_caja_cantidad_entradas_anteriormente();
            Verfica_total_unidades_entradas();
        }

        private void Rellena_datagrid_entrada_materiales()
        {
            foreach (Entrada_Material material in Entrada_materiales_disponibles)
            {

                try
                {
                    Busqueda_material.Codigo = material.Codigo_material;

                    Materiales_disponibles_busqueda = Class_Materiales.
                        Adquiere_materiales_codigo_material_en_base_datos(Busqueda_material);

         
                    if (Materiales_disponibles_busqueda[0].Generico == "1")
                    {
                        dataGridViewPartidasEntradaMaterialesVisualizar.Rows.Add(material.Codigo.ToString(), material.Orden_compra,
                            material.Fecha, material.Codigo_material, material.Codigo_proveedor,
                            material.Nombre_empleado, material.Descripcion_material, material.Cantidad, material.Precio, material.Divisa, material.Referencia);
                    }
                    else
                    {
                        dataGridViewPartidasEntradaMaterialesVisualizar.Rows.Add(material.Codigo.ToString(), material.Orden_compra,
                            material.Fecha, material.Codigo_material, Materiales_disponibles_busqueda[0].Codigo_proveedor,
                            material.Nombre_empleado, Materiales_disponibles_busqueda[0].Descripcion, material.Cantidad, material.Precio, material.Divisa, material.Referencia);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Obtener_partidas_entrada_materiales()
        {
            Asigna_valores_entrada_materiales_visualizar();
            if (Operacio_entrada_materiales == "Visualizar")
            {
                Entrada_materiales_disponibles = Class_entrada_material.Adquiere_entrada_materiales_busqueda_en_base_datos_no_orden_compra(Entrada_materiales_seleccion);
            }
            else if(Operacio_entrada_materiales == "Visualizar OC" || 
                Operacio_entrada_materiales == "Agregar OC" || Operacio_entrada_materiales == "Agregar")
            {
                Entrada_materiales_disponibles = Class_entrada_material.Adquiere_entrada_materiales_busqueda_en_base_datos(Entrada_materiales_seleccion);
            }

        }

        private void Asigna_valores_entrada_materiales_visualizar()
        {
            if (Operacio_entrada_materiales == "Visualizar OC")
            {
                Entrada_materiales_seleccion.Orden_compra = comboBoxCodigoOrdenCompra.Text;
                Entrada_materiales_seleccion.Descripcion_material = comboBoxDescripcionMaterial.Text;
                Entrada_materiales_seleccion.Codigo_proveedor = textBoxCodigoProveedor.Text;
                Entrada_materiales_seleccion.Nombre_empleado = comboBoxEmpleado.Text;
                Entrada_materiales_seleccion.Fecha = dateTimePickerFechaActual.Text;
                Entrada_materiales_seleccion.Codigo_material = textCodigoMaterial.Text;
                Entrada_materiales_seleccion.Precio = textBoxPrecioMaterial.Text;
                Entrada_materiales_seleccion.Cantidad = textBoxUnidadesEntrada.Text;
            }
            else if (Operacio_entrada_materiales == "Visualizar" || Operacio_entrada_materiales == "Agregar")
            {
                Entrada_materiales_seleccion.Orden_compra = "NA";
                Entrada_materiales_seleccion.Descripcion_material = comboBoxDescripcionMaterial.Text;
                Entrada_materiales_seleccion.Codigo_proveedor = textBoxCodigoProveedor.Text;
                Entrada_materiales_seleccion.Nombre_empleado = comboBoxEmpleado.Text;
                Entrada_materiales_seleccion.Fecha = dateTimePickerFechaActual.Text;
                Entrada_materiales_seleccion.Codigo_material = textCodigoMaterial.Text;
                Entrada_materiales_seleccion.Precio = textBoxPrecioMaterial.Text;
                Entrada_materiales_seleccion.Cantidad = textBoxUnidadesEntrada.Text;
            }
            else if(Operacio_entrada_materiales == "Agregar OC")
            {
                Entrada_materiales_seleccion.Orden_compra = comboBoxCodigoOrdenCompra.Text;
                Entrada_materiales_seleccion.Codigo_material = Material_disponible_entrada_materiales.Codigo;
            }


        }

        private void Rellenar_campos_entrada_materiales()
        {
            if (Obtener_materiales_con_codigo_material())
            {
                textBoxTotalUnidades.Text = Partida_orden_compra_seleccionada.Cantidad;
                textBoxCodigoProveedor.Text = Partida_orden_compra_seleccionada.Parte;
                Material_disponible_entrada_materiales = Materiales_disponible_entrada_materiales.Find(
                    material_disponible => material_disponible.Codigo_proveedor.Contains(textBoxCodigoProveedor.Text));
                textCodigoMaterial.Text = Material_disponible_entrada_materiales.Codigo;
                textBoxPrecioMaterial.Text = Partida_orden_compra_seleccionada.precio_unitario;
            }

        }

        private void Verfica_total_unidades_entradas()
        {
            if (Operacio_entrada_materiales == "Agregar OC")
            {
                try
                {
                    if (Convert.ToInt32(textBoxUnidadesEntradas.Text) < Convert.ToInt32(textBoxTotalUnidades.Text))
                    {
                        textBoxUnidadesEntrada.Enabled = true;
                    }
                }
                catch
                {
                    MessageBox.Show("No valores numericos en cantidad", "Entrada Materriales",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Rellena_caja_cantidad_entradas_anteriormente()
        {
            int Total_cantidad = 0;
            for (int renglones = 0; renglones < dataGridViewPartidasEntradaMaterialesVisualizar.Rows.Count; renglones++)
            {

                if (dataGridViewPartidasEntradaMaterialesVisualizar[(int)Campos_entrada_materiales_visualizar.cantidad, renglones].Value != null)
                {
                    try
                    {
                        Total_cantidad = Total_cantidad + Convert.ToInt32(dataGridViewPartidasEntradaMaterialesVisualizar[
                            (int)Campos_entrada_materiales_visualizar.cantidad, renglones].Value.ToString());
                    }
                    catch
                    {
                        MessageBox.Show("No valores numericos en cantidad", "Entrada Materriales",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            textBoxUnidadesEntradas.Text = Total_cantidad.ToString();
        }

        private bool Obtener_materiales_con_codigo_material()
        {
            Materiales_disponible_entrada_materiales = Class_Materiales.Adquiere_materiales_Consulta_Entrada_materiales_en_base_datos(Partida_orden_compra_seleccionada);
            if (Materiales_disponible_entrada_materiales.Count == 0)
            {
                MessageBox.Show("No se encontro el material en base de datos", "Entrada Materiales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Materiales_disponible_entrada_materiales.Count > 1)
            {
                MessageBox.Show("Se encontro mas de un material en base de datos", "Entrada Materiales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                Material_disponible_entrada_materiales = Materiales_disponible_entrada_materiales.Find(material_disponible => material_disponible.Codigo_proveedor.Contains(textBoxCodigoProveedor.Text));
                return true;
            }

        }

        private void Limpia_datagridview_entrada_material()
        {
            dataGridViewPartidasEntradaMaterialesVisualizar.Rows.Clear();
        }



        private void buttonBuscarOrdenCompra_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("El Material fue agregado con una orden de compra?",
                "Entrada Material", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Visualiza_entrada_materiales();
            }
            else
            {
                Visualiza_entrada_materiales_no_orden_compra();
            }
        }

        private void Visualiza_entrada_materiales_no_orden_compra()
        {
            Operacio_entrada_materiales = "Visualizar";
            Aparece_datagridview_entrada_visualizar();
            Desactiva_botones_operacion();
            Acepta_datagridview_agregar_renglones();
            Aparece_boton_cancelar_operacio();
            Activa_datagridview_partidas_entrada_materiales();
            Activa_textbox_codigo_proveedor();
            Activa_textbox_descripcion_material();
            Activa_textbox_codigo_material();
            Asigna_caracter_busqueda_material();
            Inicia_timer_busqueda_materiales();
        }

        private void comboBoxCodigoOrdenCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Operacio_entrada_materiales == "Agregar OC")
                configura_forma_agregar();
            else if (Operacio_entrada_materiales == "Visualizar OC")
                configura_forma_visualizar();

        }

        private void buttonModificarCotizacion_Click(object sender, EventArgs e)
        {
            Modifica_orden_compra();
        }


        private void Termina_secuencia_operaciones_entrada_materiales()
        {
            Limpia_combo_nombre_cliente();
            Limpia_combo_descripcion_materiales();
            Limpia_cajas_captura_despues_de_agregar_orden_compra();
            Desactiva_cajas_captura_despues_de_agregar_orden_compra();
            Desaparece_boton_guardar_base_de_datos();
            Desaparece_boton_cancelar();
            Desaparece_combo_codigo_cotizacion();
            Desaparece_combo_atencion();
            Desaparece_combo_codigo_cotizacion();
            Desaparece_combo_cliente_nombre();
            Desactiva_combo_cliente_nombre();
            Desaparece_combo_cliente_codigo();
            Desactiva_combo_cliente_codigo();
            Activa_botones_operacion();
            limpia_partidas_ordenes_compra_visualizar();
            Desactiva_datagridview_partidas();
            Desactiva_grupo_referencia();
            Aparece_caja_codigo_empleado();
            Aparece_textbox_atencion();
            Aparece_textbox_nombre_cliente();
            Acepta_datagridview_agregar_renglones();
            Desaparece_datagridview_entrada_visualizar();
            Desaparece_datagridview_entrada_materiales();
            Pinta_color_blanco_cajas_busqueda_material();
            Termina_timer_busqueda();
            Desaparece_boton_buscar_base_datos();
            Desaparece_textbox_estadoOC();
            Desaparece_label_estadoOC();
            Elimina_informacion_orden_compra_disponibles();

        }

        private void Desaparece_label_estadoOC()
        {
            labelEstadoOC.Visible = false;
        }

        private void Desaparece_textbox_estadoOC()
        {
            textBoxEstadoOC.Visible = false;
        }

        private void Termina_timer_busqueda()
        {
            timerBusquedaMaterial.Enabled = false;
        }

        private void Pinta_color_blanco_cajas_busqueda_material()
        {
            textBoxCodigoProveedor.BackColor = Color.White;
            textBoxDescripcionMaterial.BackColor = Color.White;
            textCodigoMaterial.BackColor = Color.White;
        }

        private void Termina_secuencia_save_file()
        {
            Termina_secuencia_operaciones_entrada_materiales();
        }

        private void timerAgregarEntradaMateriales_Tick(object sender, EventArgs e)
        {
            if (Operacio_entrada_materiales == "Agregar OC")
            {
                if (comboBoxCodigoOrdenCompra.Text != "" &&
                    comboBoxEmpleado.Text != "" &&
                    textBoxReferencia.Text !="")
                {
                    timerAgregarEntradaMateriales.Enabled = false;
                    Aparece_boton_guardar_base_datos();
                }
            }
            else if (Operacio_entrada_materiales == "Agregar")
            {
                if (
                    comboBoxEmpleado.Text != "" &&
                    textBoxPrecioMaterial.Text != "" &&
                    textBoxUnidadesEntrada.Text != "" &&
                    textBoxReferencia.Text != "")
                {
                    timerAgregarEntradaMateriales.Enabled = false;
                    Aparece_boton_guardar_base_datos();
                }
            }
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
            Desaparece_boton_buscar_base_datos();
            Obtener_datos_materiales_busqueda();
            if (Materiales_disponibles_busqueda.Count == 1)
            {
                Desactiva_cajas_captura_busqueda_material();
                Rellena_cajas_informacion_despues_busqueda(Materiales_disponibles_busqueda[0]);
                Material_disponible_entrada_materiales = Materiales_disponibles_busqueda[0];
                secuencia_despues_de_busqueda_material();
                if (Operacio_entrada_materiales == "Visualizar")
                {
                    Rellenar_partidas_entrada_materiales();
                }

            }
            else if (Materiales_disponibles_busqueda.Count > 1)
            {
                Forma_Materiales_Seleccion forma_Materiales_Seleccion = new Forma_Materiales_Seleccion(Materiales_disponibles_busqueda, "Entrada Materiales");
                forma_Materiales_Seleccion.ShowDialog();

                Desactiva_cajas_captura_busqueda_material();
                Limpia_cajas_captura_despues_de_agregar_material();
                if (forma_Materiales_Seleccion.Material_seleccionado_data_view != null)
                {
                    Rellena_cajas_informacion_despues_busqueda(forma_Materiales_Seleccion.Material_seleccionado_data_view);
                    Material_disponible_entrada_materiales = forma_Materiales_Seleccion.Material_seleccionado_data_view;
                    secuencia_despues_de_busqueda_material();
                }

                if (Operacio_entrada_materiales == "Visualizar" /*|| Operacio_entrada_materiales == "Agregar"*/)
                {
                    Rellenar_partidas_entrada_materiales();
                }

            }
            else if (Materiales_disponibles_busqueda.Count == 0)
            {

                MessageBox.Show("NO se encontraron Material Con este criterio",
                    "Busqueda Material", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Termina_secuencia_operaciones_entrada_materiales();

            }
        }

        private void Rellena_cajas_informacion_despues_busqueda(Material material)
        {
            if (Operacio_entrada_materiales == "Visualizar" || Operacio_entrada_materiales == "Visualizar OC")
            {
                textBoxCodigoProveedor.Text = material.Codigo_proveedor;
                textCodigoMaterial.Text = material.Codigo;
                textBoxDescripcionMaterial.Text = material.Descripcion;
                textBoxUnidadesEntradas.Text = material.Cantidad;
                textBoxPrecioMaterial.Text = material.precio;
            }
            else
            {
                textBoxCodigoProveedor.Text = material.Codigo_proveedor;
                textCodigoMaterial.Text = material.Codigo;
                textBoxDescripcionMaterial.Text = material.Descripcion;
                textBoxUnidadesEntradas.Text = material.Cantidad;
                textBoxDivisa.Text = material.divisa;
                textBoxPrecioMaterial.Text = material.precio;
            }
        }

        private void Limpia_cajas_captura_despues_de_agregar_material()
        {
            textBoxCodigoProveedor.Text = "";
            textCodigoMaterial.Text = "";
            textBoxDescripcionMaterial.Text = "";
        }

        private void Desactiva_cajas_captura_busqueda_material()
        {
            textBoxCodigoProveedor.Enabled = false;
            textCodigoMaterial.Enabled = false;
            textBoxDescripcionMaterial.Enabled = false;
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

            if(textBoxCodigoProveedor.Text=="")
            {
                Visualizar_material.Codigo_proveedor = "~";
            }
            else
            {
                Visualizar_material.Codigo_proveedor = textBoxCodigoProveedor.Text;
            }

            if(textBoxDescripcionMaterial.Text=="")
            {
                Visualizar_material.Descripcion = "~";
            }
            else
            {
                Visualizar_material.Descripcion = textBoxDescripcionMaterial.Text;
            }
            
        }

        private void Desaparece_boton_buscar_base_datos()
        {
            buttonBusquedaBaseDatos.Visible = false;
        }

        private void dataGridViewPartidasEntradaMaterialesEntrada_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Operacio_entrada_materiales == "Agregar OC")
            {
                if (dataGridViewPartidasEntradaMaterialesEntrada.CurrentCell.ColumnIndex == (int)Campos_entrada_materiales_agregar.cantidad_entrada)
                {
                    try
                    {
                        /*Valida Numeros en la caja partida*/
                        Convert.ToSingle(dataGridViewPartidasEntradaMaterialesEntrada[e.ColumnIndex, e.RowIndex].Value.ToString());
                        if (Convert.ToSingle(dataGridViewPartidasEntradaMaterialesEntrada[e.ColumnIndex, e.RowIndex].Value.ToString()) >
                             Convert.ToSingle(dataGridViewPartidasEntradaMaterialesEntrada[e.ColumnIndex - 1, e.RowIndex].Value.ToString()))
                        {
                            throw new System.ArgumentException("Numero de Unidades Mayor a unidades ordenadas", "Entrada Materiales");
                        }
                        dataGridViewPartidasEntradaMaterialesEntrada[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        dataGridViewPartidasEntradaMaterialesEntrada[(int)Campos_entrada_materiales_agregar.cantidad_entrada, e.RowIndex].Value = "";
                    }

                }

            }
        }

        private void textBoxDescripcionMaterial_TextChanged(object sender, EventArgs e)
        {
            textBoxDescripcionMaterial.BackColor = Color.White;
        }

        private void textBoxCodigoProveedor_TextChanged(object sender, EventArgs e)
        {
            textBoxCodigoProveedor.BackColor = Color.White;
        }

        private void textCodigoMaterial_TextChanged(object sender, EventArgs e)
        {
            textCodigoMaterial.BackColor = Color.White;
        }

        private void buttonMateriales_Click(object sender, EventArgs e)
        {
            Forma_Materiales forma_Materiales = new Forma_Materiales();
            forma_Materiales.ShowDialog();
        }

        private void comboBoxCodigoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usuario_seleccionado = Usuarios_administrativos.Find( usuario_seleccion =>
            usuario_seleccion.codigo_empleado.Contains(comboBoxCodigoEmpleado.Text));

            comboBoxEmpleado.Text = Usuario_seleccionado.nombre_empleado;
        }
    }
}
