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
    public partial class Forma_Salida_Materiales : Form
    {
        public Datos_generales datos_generales = new Datos_generales();
        public Class_Datos_Generales Class_Datos_Generales = new Class_Datos_Generales();
        public Class_Usuarios class_Usuarios = new Class_Usuarios();
        public Usuario Usuario_requisitores = new Usuario();
        public List<Usuario> Usuarios_administrativos = new List<Usuario>();
        public Class_Datos_Generales Class_datos_generales = new Class_Datos_Generales();
        public Datos_generales datos_Generales = new Datos_generales();
        public Class_Materiales Class_Materiales = new Class_Materiales();
        public Material Material_disponible_salida_materiales = new Material();
        public Salida_Material Insertar_salida_materiales = new Salida_Material();
        public Salida_Material Salida_materiales_seleccion = new Salida_Material();
        public Class_Salida_Material Class_salida_material = new Class_Salida_Material();
        public List<Partida_orden_compra> Partidas_orden_compra_disponibles = new List<Partida_orden_compra>();
        public List<Salida_Material> Salida_materiales_disponibles = new List<Salida_Material>();
        public Class_Partidas_Orden_compra class_partidas_Orden_compra = new Class_Partidas_Orden_compra();
        public Partida_orden_compra Partida_orden_compra_seleccionada = new Partida_orden_compra();
        public Partida_orden_compra Partida_orden_compra_busqueda = new Partida_orden_compra();
        public Material Visualizar_material = new Material();
        public List<Material> Materiales_disponibles_busqueda = new List<Material>();
        public Class_Proyectos Class_Proyectos = new Class_Proyectos();
        public List<Proyecto> Proyectos_disponibles = new List<Proyecto>();
        public Proyecto Proyecto_seleccionado = new Proyecto();
        string RenglonParaEliminar = "";
        string appPath = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
        public CultureInfo cultureInfo = new CultureInfo("en-US");
        public string nombre_archivo_word = "";
        public word.Application application = null;
        public word.Document Documento = null;
        public Class_Ordenes_Compra Class_Ordenes_Compra = new Class_Ordenes_Compra();
        public List<Orden_compra> Ordenes_compra_disponibles = new List<Orden_compra>();
        public List<Orden_compra> Ordenes_compra_con_material_abiertas = new List<Orden_compra>();
        public Orden_compra Ordene_compra_seleccion = new Orden_compra();
        





        /*Revisar*/
        public enum Campos_entrada_materiales_proyectos
        {
            codigo, orden_compra, fecha, codigo_material, cidigo_proveedor, nombre_empleado, descripcion,
            cantidad, precio,
        };

        public enum Campos_salida_materiales_orden_compra
        {
            codigo, proyecto, codigo_material,codigo_proveedor,descripcion,cantidad
        };

        public string Operacio_salida_materiales = "";

        public Forma_Salida_Materiales()
        {
            InitializeComponent();
        }

        private void Forma_Clientes_Load(object sender, EventArgs e)
        {
            Desactiva_columna_codigo_partidas_cotizaciones();

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Salida_materiales_disponibles = null;
            Usuarios_administrativos = null;
            Proyectos_disponibles = null;
            Materiales_disponibles_busqueda = null;
            this.Dispose();
            GC.Collect();
            this.Close();
        }

        private void Rellenar_combo_proyectos()
        {
            foreach (Proyecto proyecto in Proyectos_disponibles)
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

        private void obtener_proyectos_base_datos_disponibles()
        {
            Proyectos_disponibles = Class_Proyectos.Adquiere_proyectos_disponibles_en_base_datos();
        }

        private void Activa_combo_proyectos()
        {
            comboBoxCodigoProyecto.Enabled = true;
        }

        private void Aparece_combo_proyectos()
        {
            comboBoxCodigoProyecto.Visible = true;
        }

        private void limpia_combo_proyectos()
        {
            comboBoxCodigoProyecto.Items.Clear();
            comboBoxCodigoProyecto.Text = "";
        }

        private void Activa_dataview_partidas_salida_materiales()
        {
            dataGridViewSalidasMateriales.Enabled = true;
        }

        private void limpia_partidas_salida_materiales()
        {
            dataGridViewSalidasMateriales.Rows.Clear();
        }

        private void No_aceptar_agregar_partidas_salida_materiales()
        {
            dataGridViewSalidasMateriales.AllowUserToAddRows = false;
        }

        private void Aparece_boton_cancelar_operacio()
        {
            buttonCancelar.Visible = true;
        }

        private void Desaparece_caja_captura_codigo_proyecto()
        {
            textBoxCodigoProyecto.Visible = false;
        }

        private void Desactiva_botones_operacion()
        {
            Desactiva_boton_agregar_salida_materiales();
            Desactiva_boton_visualizar_cotizacion();

        }

        private void Desactiva_boton_visualizar_cotizacion()
        {
            buttonBuscarOrdenCompra.Enabled = false;
        }


        private void Desactiva_boton_agregar_salida_materiales()
        {
            buttonSalidaMaterial.Enabled = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Termina_secuencia_operaciones_salida_materiales();
        }

        private void Limpia_combo_nombre_cliente()
        {
            comboBoxEmpleado.Items.Clear();
            comboBoxEmpleado.Text = "";
        }

        private void Aparece_caja_codigo_proyecto()
        {
            textBoxCodigoProyecto.Visible = true;
        }


        private void configura_forma_salida()
        {
            Desactiva_combobox_codigo_proyectos();
            //Activa_textbox_codigo_proveedor();
            //Activa_textbox_descripcion_material();
            //Activa_textbox_codigo_material();
            //Asigna_caracter_busqueda_material();
            //Inicia_timer_busqueda_materiales();

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


        private void configura_forma_visualizar()
        {
            Desactiva_combobox_codigo_proyectos();
            Desaparece_textbox_descripcion_materiales();

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

        private void Inicia_timer_para_buscar_informacion_materiales_busqueda()
        {
            timerBusquedaMaterial.Enabled = true;
        }

        private void Desactiva_combobox_codigo_proyectos()
        {
            comboBoxCodigoProyecto.Enabled = false;
        }

        private void buttonAgregarCotizacion_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("La entrada de Material cuenta con orden de compra?",
                "Entrada Material", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Agrega_salida_materiales_proyecto();
            }
            else
            {
                Agrega_entrada_materiales();
            }
        }

        private void Agrega_entrada_materiales()
        {
            Desactiva_botones_operacion();
            Acepta_datagridview_agregar_renglones();
            Aparece_boton_cancelar_operacio();
            Activa_datagridview_partidas_entrada_materiales();
            Activa_textbox_codigo_proveedor();
            Activa_textbox_descripcion_material();
            Activa_textbox_codigo_material();
            Asigna_caracter_busqueda_material();
            Inicia_timer_busqueda_materiales();
            Operacio_salida_materiales = "Agregar";
        }

        public void secuencia_despues_de_busqueda_material()
        {
            if (Operacio_salida_materiales == "Visualizar" || Operacio_salida_materiales == "Visualizar OC")
            {

            }
            else
            {
                Limpia_combo_empleado();
                Aparece_combo_empleado();
                Activa_combo_empleado();
                Aparece_combo_proyectos();
                limpia_combo_proyectos();
                Activa_combo_proyectos();
                obtener_proyectos_base_datos_disponibles();
                Rellenar_combo_proyectos();
                obtener_usuarios_administrativos_compras_disponibles();
                Rellena_combo_empleado();
                Activa_seleccion_fecha_actual();
                Activa_textbox_cantidad_material();
                Aparece_label_proyecto();
                Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_material();
            }
        }

        private void Activa_textbox_precio()
        {
            textBoxPrecioMaterial.Enabled = true;
        }

        private void Activa_textbox_cantidad_material()
        {
            textBoxUnidadesSalida.Enabled = true;
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

        private void Agrega_salida_materiales_proyecto()
        {
            Operacio_salida_materiales = "Salida";
            Desactiva_botones_operacion();
            Acepta_datagridview_agregar_renglones();
            Aparece_boton_cancelar_operacio();
            Activa_datagridview_partidas_entrada_materiales();
            Activa_textbox_codigo_proveedor();
            limpia_combo_proyectos();
            Limpia_combo_orden_compra();
            Limpia_combo_empleado();
            Aparece_combo_empleado();
            Activa_combo_empleado();
            obtener_usuarios_administrativos_compras_disponibles();
            Rellena_combo_empleado();
            Activa_seleccion_fecha_actual();
            Activa_textbox_codigo_proveedor();
            Activa_textbox_descripcion_material();
            Activa_textbox_codigo_material();
            Asigna_caracter_busqueda_material();
            Activa_combo_OC();
            Inicia_timer_para_buscar_informacion_materiales_busqueda();
            //Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_material();
        }

        private void Aparece_label_proyecto()
        {
            labelCodigoProyecto.Visible = true;
        }

        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_material()
        {
            timerAgregarSalidaMateriales.Enabled = true;
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

        private void Desaparece_textbox_descripcion_materiales()
        {
            textBoxDescripcionMaterial.Visible = false;
        }

        private void Acepta_datagridview_agregar_renglones()
        {
            dataGridViewSalidasMateriales.AllowUserToAddRows = true;
        }

        private void Activa_datagridview_partidas_entrada_materiales()
        {
            dataGridViewSalidasMateriales.Enabled = true;
        }

        private void Desactiva_columna_codigo_partidas_cotizaciones()
        {
            dataGridViewSalidasMateriales.Columns[0].Visible = false;
        }

        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_orden_compra()
        {
            timerAgregarSalidaMateriales.Enabled = true;
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
            if (Operacio_salida_materiales == "Salida")
            {
                Secuencia_salida_materiales();
            }
            else if(Operacio_salida_materiales == "SalidaOC")
            {
                Secuencia_salida_materiales_orden_compra();
            }

        }


        private void Aparce_caja_codigo_cliente()
        {
            textBoxCodigoProyecto.Visible = true;
        }


        private void Secuencia_salida_materiales_orden_compra()
        {
            if (Verifica_valores_datagrid())
            {
                if (Verifica_exitencia_materiales_disponer())
                {
                    if (Insertar_datos_salida_materiales_orden_compra())
                    {
                        if (Salida_material_base_datos_orden_compra())
                        {
                            Asigna_estado_orden_compra_salida_materiales();
                            Limpia_cajas_captura_despues_de_agregar_salida_material();
                            Limpia_combo_nombre_cliente();
                            Limpia_datagrid_salida_materiales_orden_compra();
                            Desactiva_cajas_captura_despues_de_agregar_salida_materiales();
                            Desaparece_boton_guardar_base_de_datos();
                            Desaparece_boton_cancelar();
                            Desaparece_combo_codigo_proyecto();
                            Activa_botones_operacion();
                            limpia_partidas_salida_materiales();
                            Desactiva_datagridview_partidas();
                            Desaparece_combo_cliente_nombre();
                            Desactiva_combo_cliente_nombre();
                            Aparece_textbox_nombre_cliente();
                            Aparece_textbox_nombre_cliente();
                            Aparece_textbox_descripcion();
                            Desaparece_combo_OC();
                            Desaparece_label_OC();
                            Desaparece_datagrid_salida_materiales_orden_compra();
                            Desactiva_datagrid_salida_materiales_orden_compra();
                            Elimina_informacion_salida_materiales_disponibles();
                        }
                    }
                }
            }

        }

        private void Asigna_estado_orden_compra_salida_materiales()
        {
            string Respuesta="";
            Obtener_partidas_ordenes_compra_disponibles();
            Ordene_compra_seleccion.Codigo = comboBoxOC.Text;
            if (Verifica_unidades_pendientes_salida_ordenes_compra()!=0)
            {
                Respuesta = Class_Ordenes_Compra.Modifica_estado_salida_orden_compra(Ordene_compra_seleccion, "Parcial");
                if (Respuesta != "No Errores")
                {
                    MessageBox.Show(Respuesta);
                }
            }
            else
            {
                Respuesta = Class_Ordenes_Compra.Modifica_estado_salida_orden_compra(Ordene_compra_seleccion, "Cerrar");
                if (Respuesta != "No Errores")
                {
                    MessageBox.Show(Respuesta);
                }
            }

        }
        public int Verifica_unidades_pendientes_salida_ordenes_compra()
        {
            int Row_material = 0;
            int Unidades_salidas = 0;
            try
            {

                foreach (Partida_orden_compra partida in Partidas_orden_compra_disponibles)
                {
                    Unidades_salidas = Convert.ToInt32(partida.Cantidad) - Calculo_unidades_salidas(partida);
                    if (Unidades_salidas != 0)
                    {
                        Row_material++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            return Row_material;
        }
        

        private bool Verifica_exitencia_materiales_disponer()
        {
            for (int partidas = 0; partidas < dataGridViewSalidasMaterialesOC.Rows.Count - 1; partidas++)
            {
                Salida_materiales_seleccion.Cantidad = dataGridViewSalidasMaterialesOC
                    [(int)Campos_salida_materiales_orden_compra.cantidad, partidas].Value.ToString();

                Salida_materiales_seleccion.Codigo_material = dataGridViewSalidasMaterialesOC
                    [(int)Campos_salida_materiales_orden_compra.codigo_material, partidas].Value.ToString();
                Salida_materiales_seleccion.Codigo_proveedor = dataGridViewSalidasMaterialesOC
                    [(int)Campos_salida_materiales_orden_compra.codigo_proveedor, partidas].Value.ToString();
                Salida_materiales_seleccion.Descripcion_material = dataGridViewSalidasMaterialesOC
                    [(int)Campos_salida_materiales_orden_compra.descripcion, partidas].Value.ToString();


                if (!Revisa_almacen())
                {
                    MessageBox.Show("No unidades suficientes en almacen " + dataGridViewSalidasMaterialesOC
                    [(int)Campos_salida_materiales_orden_compra.codigo_material, partidas].Value.ToString(), "Salida Material",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            return true;
        }

        private bool Revisa_almacen()
        {
            try
            {
                Visualizar_material.Codigo = Salida_materiales_seleccion.Codigo_material;
                Visualizar_material.Codigo_proveedor = Salida_materiales_seleccion.Codigo_proveedor;
                Visualizar_material.Descripcion = Salida_materiales_seleccion.Descripcion_material;
                Materiales_disponibles_busqueda = Class_Materiales.
                    Adquiere_materiales_busqueda_entrada_materiales_en_base_datos(Visualizar_material);
                Materiales_disponibles_busqueda[0].Cantidad = (Convert.ToInt32(
                    Materiales_disponibles_busqueda[0].Cantidad.ToString()) -
                                Convert.ToUInt32(Salida_materiales_seleccion.Cantidad)).ToString();
                if(Convert.ToInt32(Materiales_disponibles_busqueda[0].Cantidad)>=0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch
            {
                MessageBox.Show("Datos No Numericos", "Devolucion Materiales",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool Salida_material_base_datos_orden_compra()
        {
            for (int partidas = 0; partidas < dataGridViewSalidasMaterialesOC.Rows.Count - 1; partidas++)
            {
                Salida_materiales_seleccion.Cantidad = dataGridViewSalidasMaterialesOC
                    [(int)Campos_salida_materiales_orden_compra.cantidad, partidas].Value.ToString();

                Salida_materiales_seleccion.Codigo_material = dataGridViewSalidasMaterialesOC
                    [(int)Campos_salida_materiales_orden_compra.codigo_material, partidas].Value.ToString();
                Salida_materiales_seleccion.Codigo_proveedor = dataGridViewSalidasMaterialesOC
                    [(int)Campos_salida_materiales_orden_compra.codigo_proveedor, partidas].Value.ToString();
                Salida_materiales_seleccion.Descripcion_material = dataGridViewSalidasMaterialesOC
                    [(int)Campos_salida_materiales_orden_compra.descripcion, partidas].Value.ToString();


                if (!Actualiza_material_almacen())
                {
                    return false;
                }
            }
            return true;
        }

        private bool Actualiza_material_almacen()
        {
            string respuesta = "";
            try
            {
                Visualizar_material.Codigo = Salida_materiales_seleccion.Codigo_material;
                Visualizar_material.Codigo_proveedor = Salida_materiales_seleccion.Codigo_proveedor;
                Visualizar_material.Descripcion = Salida_materiales_seleccion.Descripcion_material;
                Materiales_disponibles_busqueda = Class_Materiales.
                    Adquiere_materiales_busqueda_entrada_materiales_en_base_datos(Visualizar_material);
                Materiales_disponibles_busqueda[0].Cantidad = (Convert.ToInt32(
                    Materiales_disponibles_busqueda[0].Cantidad.ToString()) -
                                Convert.ToUInt32(Salida_materiales_seleccion.Cantidad)).ToString();

                respuesta = Class_Materiales.Actualiza_base_datos_materiales(
                    Materiales_disponibles_busqueda[0]);
                if (respuesta == "NO errores")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(respuesta, "Salida Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Datos No Numericos", "Devolucion Materiales",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool Verifica_valores_datagrid()
        {
            for (int partidas = 0; partidas < dataGridViewSalidasMaterialesOC.Rows.Count - 1; partidas++)
            {
                if(dataGridViewSalidasMaterialesOC[(int)Campos_salida_materiales_orden_compra.proyecto,partidas].Value==null
                    || dataGridViewSalidasMaterialesOC[(int)Campos_salida_materiales_orden_compra.proyecto,partidas].Value.ToString() =="")
                {
                    MessageBox.Show("No valor en Proyecto", "Salida Materiales",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else if (dataGridViewSalidasMaterialesOC[(int)Campos_salida_materiales_orden_compra.cantidad, partidas].Value == null
                    || dataGridViewSalidasMaterialesOC[(int)Campos_salida_materiales_orden_compra.cantidad, partidas].Value.ToString() == "")

                {
                    MessageBox.Show("No valor en Cantidad", "Salida Materiales",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            return true;
        }

        private bool Insertar_datos_salida_materiales_orden_compra()
        {
            for (int partidas = 0; partidas < dataGridViewSalidasMaterialesOC.Rows.Count - 1; partidas++)
            {
                Insertar_salida_materiales.Proyecto = dataGridViewSalidasMaterialesOC
                    [(int)Campos_salida_materiales_orden_compra.proyecto, partidas].Value.ToString();

                Insertar_salida_materiales.Fecha = dateTimePickerFechaActual.Text;
                Insertar_salida_materiales.Codigo_material = dataGridViewSalidasMaterialesOC
                    [(int)Campos_salida_materiales_orden_compra.codigo_material, partidas].Value.ToString();
                Insertar_salida_materiales.Codigo_proveedor = dataGridViewSalidasMaterialesOC
                    [(int)Campos_salida_materiales_orden_compra.codigo_proveedor, partidas].Value.ToString();
                Insertar_salida_materiales.Descripcion_material = dataGridViewSalidasMaterialesOC
                    [(int)Campos_salida_materiales_orden_compra.descripcion, partidas].Value.ToString();
                Insertar_salida_materiales.Nombre_empleado = comboBoxEmpleado.Text;
                Insertar_salida_materiales.Cantidad = dataGridViewSalidasMaterialesOC
                    [(int)Campos_salida_materiales_orden_compra.cantidad, partidas].Value.ToString();
                Insertar_salida_materiales.Orden_compra = comboBoxOC.Text;

                if (!Insertar_datos_salida_materiales())
                {
                    return false;
                }
            }
            return true;

        }

        private bool Insertar_datos_salida_materiales()
        {
            string respuesta = "";
            respuesta = Class_salida_material.Inserta_nuevo_salida_material_base_datos(
                Insertar_salida_materiales);
            if (respuesta == "NO errores")
            {
                return true;
            }
            else
            {
                MessageBox.Show(respuesta, "Salida Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Secuencia_salida_materiales()
        {
            if (unidades_disponibles_suficientes_para_salida())
            {
                if (Unidades_disponibles_orden_compra())
                {
                    if (verifica_campos_numericos())
                    {
                        if (verfica_datos_entrada_materiales())
                        {
                            if (Insertar_datos_salida_materiales_class())
                            {
                                if (Salida_material_base_datos())
                                {
                                    Asigna_estado_orden_compra_salida_materiales();
                                    Limpia_cajas_captura_despues_de_agregar_salida_material();
                                    Limpia_combo_nombre_cliente();
                                    Desactiva_cajas_captura_despues_de_agregar_salida_materiales();
                                    Desaparece_boton_guardar_base_de_datos();
                                    Desaparece_boton_cancelar();
                                    Desaparece_combo_codigo_proyecto();
                                    Activa_botones_operacion();
                                    limpia_partidas_salida_materiales();
                                    Desactiva_datagridview_partidas();
                                    Desaparece_combo_cliente_nombre();
                                    Desactiva_combo_cliente_nombre();
                                    Aparece_textbox_nombre_cliente();
                                    Aparece_textbox_nombre_cliente();
                                    Aparece_textbox_descripcion();
                                    Desaparece_label_proyecto();
                                    Desaparece_combo_OC();
                                    Desaparece_label_OC();
                                    Desaparece_textbox_unidades_pendientes_OC();
                                    Desaparece_label_unidades_pendientes_OC();
                                    Elimina_informacion_salida_materiales_disponibles();
                                }
                            }

                        }
                    }
                }
            }

        }

        private bool Unidades_disponibles_orden_compra()
        {
            if (comboBoxOC.Visible)
            {
                try
                {
                    if (Convert.ToInt32(textBoxUnidadesSalida.Text) <= Convert.ToInt32(textBoxOCtotalUnits.Text))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Unidades Orden Compra Disponibles Menor a las requeridas", "Salida Materiales",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("Problemas Calculando Salida Unidades", "Salida Materiales",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        private bool unidades_disponibles_suficientes_para_salida()
        {
           try
            {
                if(Convert.ToInt32(textBoxUnidadesSalida.Text)<= Convert.ToInt32(textBoxTotalUnidades.Text))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Unidades Disponibles Menor a las requeridas", "Salida Materiales",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Problemas Calculando Salida Unidades", "Salida Materiales", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool Salida_material_base_datos()
        {
            string respuesta = "";
            try
            {
                Material_disponible_salida_materiales.Cantidad = (Convert.ToInt32(
                    Material_disponible_salida_materiales.Cantidad.ToString()) -
                                Convert.ToUInt32(textBoxUnidadesSalida.Text)).ToString();

                if (
                    Convert.ToSingle(textBoxPrecioMaterial.Text) < 0)
                {
                    Material_disponible_salida_materiales.precio = "0";
                }

                respuesta = Class_Materiales.Actualiza_base_datos_materiales(
                    Material_disponible_salida_materiales);
                if (respuesta == "NO errores")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(respuesta, "Salida Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Datos No Numericos", "Devolucion Materiales",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool Insertar_datos_salida_materiales_class()
        {
            string respuesta = "";
            Asigna_valores_salida_materiales();
            respuesta = Class_salida_material.Inserta_nuevo_salida_material_base_datos(
                Insertar_salida_materiales);
            if (respuesta == "NO errores")
            {
                return true;
            }
            else
            {
                MessageBox.Show(respuesta, "Salida Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void Asigna_valores_salida_materiales()
        {

            if (comboBoxOC.Items.Count == 0)
            {
                Insertar_salida_materiales.Proyecto = comboBoxCodigoProyecto.Text;
                Insertar_salida_materiales.Descripcion_material = textBoxDescripcionMaterial.Text;
                Insertar_salida_materiales.Codigo_proveedor = textBoxCodigoProveedor.Text;
                Insertar_salida_materiales.Nombre_empleado = comboBoxEmpleado.Text;
                Insertar_salida_materiales.Fecha = dateTimePickerFechaActual.Text;
                Insertar_salida_materiales.Codigo_material = textCodigoMaterial.Text;
                Insertar_salida_materiales.Cantidad = textBoxUnidadesSalida.Text;
                Insertar_salida_materiales.Orden_compra = "NA";
            }
            else
            {
                Insertar_salida_materiales.Proyecto = comboBoxCodigoProyecto.Text;
                Insertar_salida_materiales.Descripcion_material = textBoxDescripcionMaterial.Text;
                Insertar_salida_materiales.Codigo_proveedor = textBoxCodigoProveedor.Text;
                Insertar_salida_materiales.Nombre_empleado = comboBoxEmpleado.Text;
                Insertar_salida_materiales.Fecha = dateTimePickerFechaActual.Text;
                Insertar_salida_materiales.Codigo_material = textCodigoMaterial.Text;
                Insertar_salida_materiales.Cantidad = textBoxUnidadesSalida.Text;
                Insertar_salida_materiales.Orden_compra = comboBoxOC.Text;
            }
        }

        private bool verfica_datos_entrada_materiales()
        {

            if (
            textBoxDescripcionMaterial.Text != "" &&
            textBoxCodigoProveedor.Text != "" &&
            comboBoxEmpleado.Text != "" &&
            textCodigoMaterial.Text != "" &&
            textBoxPrecioMaterial.Text != "" &&
            textBoxUnidadesSalida.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Campos en blanco", "Salida Materiales", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return false;
            }

        }

        private bool verifica_campos_numericos()
        {

            return verifica_cantidad_numerico_cantidad_unidades();

        }
        private bool verifica_cantidad_numerico_cantidad_unidades()
        {
            try
            {
                Convert.ToInt32(textBoxUnidadesSalida.Text);
                return true;
            }
            catch
            {
                textBoxUnidadesSalida.Text = "";
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
            for (int partidas = 0; partidas < dataGridViewSalidasMateriales.Rows.Count - 1; partidas++)
            {
                for (int campo = 1; campo < dataGridViewSalidasMateriales.Rows[partidas].Cells.Count; campo++)
                {
                    if (dataGridViewSalidasMateriales.Rows[partidas].Cells[campo].Value == null)
                    {
                        MessageBox.Show("campo en blanco");
                        return false;
                    }

                }
            }
            return true;
        }

        private void Aparece_textbox_descripcion()
        {
            textBoxDescripcionMaterial.Visible = true;
        }

        private void Aparece_textbox_nombre_cliente()
        {
            textBoxEmpleado.Visible = true;
        }

        private void Desactiva_combo_cliente_nombre()
        {
            comboBoxEmpleado.Enabled = false;
        }

        private void Desaparece_combo_cliente_nombre()
        {
            comboBoxEmpleado.Visible = false;
        }

        private void Desactiva_datagridview_partidas()
        {
            dataGridViewSalidasMateriales.Enabled = false;
        }

        private void Elimina_informacion_salida_materiales_disponibles()
        {
            Salida_materiales_disponibles = null;
            Usuarios_administrativos = null;
            Proyectos_disponibles = null;
            Materiales_disponibles_busqueda = null;
            Salida_materiales_disponibles = null;
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
            buttonSalidaMaterial.Enabled = true;
        }

        private void Desaparece_combo_codigo_proyecto()
        {
            comboBoxCodigoProyecto.Visible = false;
        }

        private void Desaparece_boton_cancelar()
        {
            buttonCancelar.Visible = false;
        }

        private void Desaparece_boton_guardar_base_de_datos()
        {
            buttonGuardarBasedeDatos.Visible = false;
        }

        private void Desactiva_cajas_captura_despues_de_agregar_salida_materiales()
        {
            textBoxEmpleado.Enabled = false;
            dateTimePickerFechaActual.Enabled = false;
            textBoxDescripcionMaterial.Enabled = false;
            textBoxCodigoProveedor.Enabled = false;
            textBoxUnidadesSalida.Enabled = false;
            textBoxPrecioMaterial.Enabled = false;
            textCodigoMaterial.Enabled = false;

        }


        private void Limpia_cajas_captura_despues_de_agregar_salida_material()
        {
            textBoxEmpleado.Text = "";
            textBoxCodigoProyecto.Text = "";
            dateTimePickerFechaActual.Text = DateTime.Today.ToString();
            textBoxDescripcionMaterial.Text = "";
            textBoxCodigoProveedor.Text = "";
            textBoxUnidadesSalida.Text = "";
            textCodigoMaterial.Text = "";
            textBoxPrecioMaterial.Text = "";
            textBoxTotalUnidades.Text = "";
            textBoxOCtotalUnits.Text = "";
        }

       

        private string Configura_cadena_comando_actualizar_en_base_de_datos_partidas_requisiciones(Partida_orden_compra partida_orden_compra_agregar)
        {
            return "UPDATE partidas_requisiciones set  orden_compra_asignada='" + partida_orden_compra_agregar.Codigo_orden+
                "' where codigo_requisicion='" + partida_orden_compra_agregar.Material + "' and numero_parte='" +
                partida_orden_compra_agregar.Parte+"' ;";
        }


        private string Configura_cadena_comando_insertar_en_base_de_datos_partidas_orden_compra(Partida_orden_compra partida_orden_compra)
        {
            return "INSERT INTO partidas_oredenes_compra(codigo_orden_compra,partida_compra, material_compra," +
                "cantidad_compra,parte_compra,descripcion_compra,unidad_medida,proyecto_compra,precio_unitario,total_compra) " +
                "VALUES('" + partida_orden_compra.Codigo_orden + "','" + partida_orden_compra.Partida + "','" +
                partida_orden_compra.Material + "','" + partida_orden_compra.Cantidad + "','" + partida_orden_compra.Parte + "','" +
                partida_orden_compra.Descripcion + "','" + partida_orden_compra.Unidad_medida + "','" + partida_orden_compra.Proyecto + "','" +
                partida_orden_compra.precio_unitario + "','"+ partida_orden_compra.Total + "');";
        }


        private void Modifica_orden_compra()
        {
            Desactiva_botones_operacion();
            limpia_combo_proyectos();
            Desaparece_caja_captura_codigo_proyecto();
            obtener_proyectos_base_datos_disponibles();
            Aparece_boton_cancelar_operacio();
            Activa_dataview_partidas_salida_materiales();
            No_aceptar_agregar_partidas_salida_materiales();
            Aparece_combo_proyectos();
            Activa_combo_proyectos();
            obtener_proyectos_base_datos_disponibles();
            Activa_dataview_partidas_salida_materiales();
            Operacio_salida_materiales = "Modificar";
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
            Operacio_salida_materiales = "Eliminar partida";
            No_aceptar_agregar_partidas_salida_materiales();
            
        }


        private void buttonContactos_Click(object sender, EventArgs e)
        {
            Partidas_operaciones();
        }

        private void Partidas_operaciones()
        {
            Desactiva_botones_operacion();
            Desaparece_caja_captura_codigo_proyecto();
            Aparece_boton_cancelar_operacio();
            No_aceptar_agregar_partidas_salida_materiales();
            Activa_dataview_partidas_salida_materiales();
            limpia_combo_proyectos();
            Aparece_combo_proyectos();
            Activa_combo_proyectos();
            obtener_proyectos_base_datos_disponibles();
            Operacio_salida_materiales = "Operaciones Patidas";
        }



        private void dataGridViewContactosClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Operacio_salida_materiales == "Eliminar partida")
            {
                Aparece_boton_eliminar_datos_en_base_de_datos();
                RenglonParaEliminar=dataGridViewSalidasMateriales.Rows[e.RowIndex].Cells["Codigo_partida"].Value.ToString();
            }
           
        }

        private void Rellenar_partidas_salida_materiales()
        {
            Obtener_partidas_entrada_materiales_NO_orden_compra();
            Rellena_datagrid_entrada_materiales();

        }

        private void Obtener_partidas_entrada_materiales_NO_orden_compra()
        {
            Asigna_valores_entrada_materiales_visualizar();
            Salida_materiales_disponibles = Class_salida_material
                .Adquiere_salida_materiales_NO_orden_compra(Salida_materiales_seleccion);
        }

        private void Rellena_datagrid_entrada_materiales()
        {
            foreach (Salida_Material material in Salida_materiales_disponibles)
            {

                try
                {
                    dataGridViewSalidasMateriales.Rows.Add(material.Codigo.ToString(), material.Proyecto,
                        material.Fecha, material.Codigo_material, material.Codigo_proveedor,
                        material.Nombre_empleado, material.Descripcion_material, material.Cantidad);
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
            Salida_materiales_disponibles = Class_salida_material.Adquiere_salida_materiales_busqueda_en_base_datos(Salida_materiales_seleccion);

        }

        private void Asigna_valores_entrada_materiales_visualizar()
        {

            Salida_materiales_seleccion.Proyecto = comboBoxCodigoProyecto.Text;
            Salida_materiales_seleccion.Descripcion_material = textBoxDescripcionMaterial.Text;
            Salida_materiales_seleccion.Codigo_proveedor = textBoxCodigoProveedor.Text;
            Salida_materiales_seleccion.Nombre_empleado = comboBoxEmpleado.Text;
            Salida_materiales_seleccion.Fecha = dateTimePickerFechaActual.Text;
            Salida_materiales_seleccion.Codigo_material = textCodigoMaterial.Text;
            Salida_materiales_seleccion.Cantidad = textBoxUnidadesSalida.Text;

        }

        private void Limpia_datagridview_entrada_material()
        {
            dataGridViewSalidasMateriales.Rows.Clear();
        }

        private void buttonBuscarOrdenCompra_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("La Salida de Material cuenta con orden de compra?",
               "Salida Material", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
               Visualizar_salida_materiales_orden_compra();
            }
            else
            {
                Visualiza_salida_materiales();
            }
            
        }

        private void Visualizar_salida_materiales_orden_compra()
        {
            Operacio_salida_materiales = "VisualizarOC";
            Limpia_combo_orden_compra();
            Aparece_combo_orden_compra();
            Aparece_label_orden_compra();
            Desactiva_botones_operacion();
            Acepta_datagridview_agregar_renglones();
            Aparece_boton_cancelar_operacio();
            Aparece_datagrid_salida_materiales();
            Activa_datagridview_partidas_entrada_materiales();
            Aparece_boton_cancelar_operacio();
            Desactiva_botones_operacion();
            Obtener_ordenes_compra_disponibles();
            Rellena_combo_ordenes_compra();

        }

        private void Visualiza_salida_materiales()
        {
            Operacio_salida_materiales = "Visualizar";
            Desactiva_botones_operacion();
            Acepta_datagridview_agregar_renglones();
            Aparece_boton_cancelar_operacio();
            Aparece_datagrid_salida_materiales();
            Activa_datagridview_partidas_entrada_materiales();
            Activa_textbox_codigo_proveedor();
            Activa_textbox_descripcion_material();
            Activa_textbox_codigo_material();
            Asigna_caracter_busqueda_material();
            Inicia_timer_busqueda_materiales();
        }

        private void Aparece_datagrid_salida_materiales()
        {
            dataGridViewSalidasMateriales.Visible = true;
        }

        private void comboBoxCodigoOrdenCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Operacio_salida_materiales == "Salida")
                configura_forma_salida();
            else if (Operacio_salida_materiales == "Visualizar")
                configura_forma_visualizar();

        }

        private void buttonModificarCotizacion_Click(object sender, EventArgs e)
        {
            Modifica_orden_compra();
        }


        private void Termina_secuencia_operaciones_salida_materiales()
        {
            Limpia_combo_nombre_cliente();
            Limpia_cajas_captura_despues_de_agregar_salida_material();
            Desactiva_cajas_captura_despues_de_agregar_salida_materiales();
            Desaparece_boton_guardar_base_de_datos();
            Desaparece_boton_cancelar();
            Desaparece_combo_codigo_proyecto();
            Desaparece_combo_cliente_nombre();
            Activa_botones_operacion();
            limpia_partidas_salida_materiales();
            Desactiva_datagridview_partidas();
            Aparece_textbox_descripcion();
            Aparece_textbox_nombre_cliente();
            Acepta_datagridview_agregar_renglones();
            Pinta_color_blanco_cajas_busqueda_material();
            Termina_timer_busqueda();
            Desaparece_boton_buscar_base_datos();
            Desaparece_combo_OC();
            Desaparece_label_OC();
            Desaparece_label_proyecto();
            Desaparece_datagrid_salida_materiales_orden_compra();
            Desactiva_datagrid_salida_materiales_orden_compra();
            Desaparece_datagrid_salida_materiales_orden_compra_visualizar();
            Desactiva_datagrid_salida_materiales_orden_compra_visualizar();
            Desaparece_textbox_unidades_pendientes_OC();
            Desaparece_label_unidades_pendientes_OC();
            Elimina_informacion_salida_materiales_disponibles();

        }

        private void Desactiva_datagrid_salida_materiales_orden_compra_visualizar()
        {
            dataGridViewSalidasMateriales.Enabled = false;
        }

        private void Desaparece_datagrid_salida_materiales_orden_compra_visualizar()
        {
            dataGridViewSalidasMateriales.Visible = false;
        }

        private void Desaparece_label_proyecto()
        {
            labelCodigoProyecto.Visible = false;
        }

        private void Desaparece_label_OC()
        {
            labelCodigoOC.Visible = false;
        }

        private void Desaparece_combo_OC()
        {
            comboBoxOC.Visible = false;
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

        private void timerAgregarSalidaMateriales_Tick(object sender, EventArgs e)
        {
            if (Operacio_salida_materiales == "Salida")
            {
                if (comboBoxOC.Visible)
                {
                    if (comboBoxEmpleado.Text != "" &&
                        textBoxUnidadesSalida.Text != "" &&
                        comboBoxOC.Text != "" &&
                        comboBoxCodigoProyecto.Text != "")
                    {
                        timerAgregarSalidaMateriales.Enabled = false;
                        Aparece_boton_guardar_base_datos();
                    }
                }
                else
                {
                    if (comboBoxEmpleado.Text != "" &&
                        textBoxUnidadesSalida.Text != "" &&
                        comboBoxCodigoProyecto.Text != "")
                    {
                        timerAgregarSalidaMateriales.Enabled = false;
                        Aparece_boton_guardar_base_datos();
                    }
                }
            }
            else
            {
                if (comboBoxEmpleado.Text != "")
                {
                    timerAgregarSalidaMateriales.Enabled = false;
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
                Material_disponible_salida_materiales = Materiales_disponibles_busqueda[0];
                secuencia_despues_de_busqueda_material();
                if(Operacio_salida_materiales == "Salida" && textCodigoMaterial.Text !="")
                {
                    Busca_material_en_partidas_orden_compra();
                }
                if(Operacio_salida_materiales=="Visualizar")
                {
                    Rellenar_partidas_salida_materiales();
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
                    Material_disponible_salida_materiales = forma_Materiales_Seleccion.Material_seleccionado_data_view;
                    secuencia_despues_de_busqueda_material();
                }
                
                if (Operacio_salida_materiales == "Salida" && textCodigoMaterial.Text != "")
                {
                    Busca_material_en_partidas_orden_compra();
                }

                if (Operacio_salida_materiales == "Visualizar")
                {
                    Rellenar_partidas_salida_materiales();
                }

            }
            else if (Materiales_disponibles_busqueda.Count == 0)
            {

                MessageBox.Show("NO se encontraron Material Con este criterio",
                    "Busqueda Material", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Termina_secuencia_operaciones_salida_materiales();

            }
        }

        private void Busca_material_en_partidas_orden_compra()
        {
            Limpia_partidas_ordenes_compra_disponibles();
            Obtener_partidas_ordenes_compra_disponibles_material();
            if(Partidas_orden_compra_disponibles.Count>0)
            {
                Buscar_material_ordenes_compra_salidas_abiertas();
                if(Ordenes_compra_con_material_abiertas.Count>0)
                {
                    Limpia_combo_orden_compra();
                    Aparece_combo_orden_compra();
                    Rellena_combo_ordenes_compra();
                    Aparece_label_orden_compra();

                }

            }
            
        }

        private void Buscar_material_ordenes_compra_salidas_abiertas()
        {
            int Unidades_pendientes_orden_compra = 0;
            Limpia_ordenes_compra_con_material_abiertas();
            foreach (Partida_orden_compra partida in Partidas_orden_compra_disponibles)
            {

                Ordenes_compra_disponibles = Class_Ordenes_Compra
                    .Adquiere_ordenes_compra_disponibles_material_salidas_abiertas(partida.Codigo_orden);
                if(Ordenes_compra_disponibles.Count>0)
                {
                    foreach(Orden_compra orden in Ordenes_compra_disponibles)
                    {
                        Partida_orden_compra_busqueda.Codigo_orden = orden.Codigo;
                        Partida_orden_compra_busqueda.Material = textCodigoMaterial.Text;
                        Partidas_orden_compra_disponibles = class_partidas_Orden_compra
                .Adquiere_partidas_ordenes_compra_disponibles_material_orden_compra(Partida_orden_compra_busqueda);
                        Unidades_pendientes_orden_compra = Verifica_unidades_pendientes_salida_ordenes_compra_material_indivudual();
                        if (Unidades_pendientes_orden_compra > 0)
                        {
                            Ordenes_compra_con_material_abiertas.Add(orden);
                        }

                        
                    }
                    
                }
            }
        }

        private void Limpia_ordenes_compra_con_material_abiertas()
        {
            Ordenes_compra_con_material_abiertas.Clear();
        }

        private void Obtener_partidas_ordenes_compra_disponibles_material()
        {
            Partidas_orden_compra_disponibles = class_partidas_Orden_compra.
                Adquiere_partidas_ordenes_compra_disponibles_en_base_datos_material(textCodigoMaterial.Text);
        }

        private void Limpia_partidas_ordenes_compra_disponibles()
        {
            Partidas_orden_compra_disponibles = null;
        }

        private void Rellena_cajas_informacion_despues_busqueda(Material material)
        {
            if (Operacio_salida_materiales == "Visualizar")
            {
                textBoxCodigoProveedor.Text = material.Codigo_proveedor;
                textCodigoMaterial.Text = material.Codigo;
                textBoxDescripcionMaterial.Text = material.Descripcion;
                textBoxPrecioMaterial.Text = material.precio;
                textBoxTotalUnidades.Text = material.Cantidad;
            }
            else
            {
                textBoxCodigoProveedor.Text = material.Codigo_proveedor;
                textCodigoMaterial.Text = material.Codigo;
                textBoxDescripcionMaterial.Text = material.Descripcion;
                textBoxPrecioMaterial.Text = material.precio;
                textBoxTotalUnidades.Text = material.Cantidad;
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
            textBoxPrecioMaterial.Enabled = false;
            textBoxTotalUnidades.Enabled = false;
        }

        private void Obtener_datos_materiales_busqueda()
        {
            Asigna_datos_visualizar_material();
            Materiales_disponibles_busqueda = Class_Materiales.Adquiere_materiales_busqueda_entrada_materiales_en_base_datos(Visualizar_material);
        }

        private void Asigna_datos_visualizar_material()
        {
            if (textCodigoMaterial.Text=="")
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

        private void Desaparece_boton_buscar_base_datos()
        {
            buttonBusquedaBaseDatos.Visible = false;
        }

        private void buttonSalidaMaterial_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("La Salida de Material es Individual?",
                "Salida Material", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Agrega_salida_materiales_proyecto();
                
            }
            else
            {
                Agrega_salida_materiales_proyecto_orden_compra();
            }
            
        }

        private void Agrega_salida_materiales_proyecto_orden_compra()
        {
            Operacio_salida_materiales = "SalidaOC";
            Limpia_combo_orden_compra();
            Activa_combo_OC();
            Aparece_combo_orden_compra();
            Aparece_label_orden_compra();
            Aparece_boton_cancelar_operacio();
            Desactiva_botones_operacion();
            Obtener_ordenes_compra_disponibles();
            Rellena_combo_ordenes_compra();
            Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_material();
        }

        private void Rellena_combo_ordenes_compra()
        {
            if (Operacio_salida_materiales == "Salida")
            {
                foreach (Orden_compra orden_compra in Ordenes_compra_con_material_abiertas)
                {
                    if (orden_compra.error == "")
                    {
                        comboBoxOC.Items.Add(orden_compra.Codigo);
                    }
                    else
                    {
                        MessageBox.Show(orden_compra.error);
                        break;
                    }
                }
            }
            else
            {
                foreach (Orden_compra orden_compra in Ordenes_compra_disponibles)
                {
                    if (orden_compra.error == "")
                    {
                        comboBoxOC.Items.Add(orden_compra.Codigo);
                    }
                    else
                    {
                        MessageBox.Show(orden_compra.error);
                        break;
                    }
                }
            }
        }

        private void Obtener_ordenes_compra_disponibles()
        {
            Ordenes_compra_disponibles = Class_Ordenes_Compra.Adquiere_ordenes_compra_disponibles_en_base_datos();
        }

        private void Aparece_label_orden_compra()
        {
            labelCodigoOC.Visible = true;
        }

        private void Aparece_combo_orden_compra()
        {
            comboBoxOC.Visible = true;
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

        private void comboBoxOC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Operacio_salida_materiales == "SalidaOC")
            {
                configura_salida_orden_compra();
            }
            else if(Operacio_salida_materiales == "VisualizarOC")
            {
                configura_visualizar_salida_orden_compra();
            }
            else if(Operacio_salida_materiales == "Salida")
            {
                configura_salida_material_individual();
            }
            
        }

        private void configura_salida_material_individual()
        {
            Desactiva_combo_OC();
            Aparece_label_unidades_pendientes_OC();
            Aparece_textbox_unidades_pendientes_OC();
            Actualiza_unidades_orden_compra_pendientes();
            
        }

        private void Aparece_textbox_unidades_pendientes_OC()
        {
            textBoxOCtotalUnits.Visible = true;
        }
        private void Desaparece_textbox_unidades_pendientes_OC()
        {
            textBoxOCtotalUnits.Visible = false;
        }

        private void Aparece_label_unidades_pendientes_OC()
        {
            labelOCtotalUnits.Visible = true;
        }

        private void Desaparece_label_unidades_pendientes_OC()
        {
            labelOCtotalUnits.Visible = false;
        }

        private void Actualiza_unidades_orden_compra_pendientes()
        {
            int Unidades_pendientes_orden_compra = 0;
            Obtener_partidas_ordenes_compra_disponibles_material_orden_compra();
            Ordene_compra_seleccion.Codigo = comboBoxOC.Text;
            Unidades_pendientes_orden_compra = Verifica_unidades_pendientes_salida_ordenes_compra_material_indivudual();
            if (Unidades_pendientes_orden_compra > 0)
            {
                textBoxOCtotalUnits.Text =  Unidades_pendientes_orden_compra.ToString();
            }
            else
            {
                MessageBox.Show("Todo el Material de la Orden esta asignado",
                   "Salida Material", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Termina_secuencia_operaciones_salida_materiales();
            }

        }

        private void Obtener_partidas_ordenes_compra_disponibles_material_orden_compra()
        {
            Asigna_campos_partida_oerden_compra_busqueda();
            Partidas_orden_compra_disponibles = class_partidas_Orden_compra
                .Adquiere_partidas_ordenes_compra_disponibles_material_orden_compra(Partida_orden_compra_busqueda);
        }

        private void Asigna_campos_partida_oerden_compra_busqueda()
        {
            Partida_orden_compra_busqueda.Codigo_orden = comboBoxOC.Text;
            Partida_orden_compra_busqueda.Material = textCodigoMaterial.Text;
        }

        private int Verifica_unidades_pendientes_salida_ordenes_compra_material_indivudual()
        {
            int Unidades_salidas = 0;
            try
            {

                foreach (Partida_orden_compra partida in Partidas_orden_compra_disponibles)
                {
                    Unidades_salidas = Convert.ToInt32(partida.Cantidad) - Calculo_unidades_salidas(partida);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            return Unidades_salidas;
        }

        private void Desactiva_combo_OC()
        {
            comboBoxOC.Enabled = false;
        }
        private void Activa_combo_OC()
        {
            comboBoxOC.Enabled = true;
        }

        private void configura_visualizar_salida_orden_compra()
        {
            Partidas_orden_compra_disponibles = class_partidas_Orden_compra.
                Adquiere_partidas_ordenes_compra_disponibles_en_base_datos(comboBoxOC.Text);
            foreach(Partida_orden_compra partida in Partidas_orden_compra_disponibles)
            {
                Salida_materiales_seleccion.Orden_compra = comboBoxOC.Text;
                Salida_materiales_seleccion.Codigo_material = partida.Material;
                Salida_materiales_disponibles = Class_salida_material.
                    Adquiere_salida_materiales_orden_compra_base_datos(Salida_materiales_seleccion);
                foreach(Salida_Material material in Salida_materiales_disponibles)
                {
                    dataGridViewSalidasMateriales.Rows.Add(material.Codigo.ToString(), material.Proyecto,
                        material.Fecha, material.Codigo_material, material.Codigo_proveedor,
                        material.Nombre_empleado, material.Descripcion_material, material.Cantidad);
                }
            }
        }

        private void Limpia_combo_orden_compra()
        {
            comboBoxOC.Text = "";
            comboBoxOC.Items.Clear();
        }

        private void configura_salida_orden_compra()
        {
            Aparece_datagrid_salida_materiales_orden_compra();
            Activate_datagrid_salida_materiales_orden_compra();
            Limpia_datagrid_salida_materiales_orden_compra();
            obtener_proyectos_base_datos_disponibles();
            Rellenar_combo_proyectos_datagrid_salida_materiales();
            Obtener_partidas_ordenes_compra_disponibles();
            if (Rellenar_partidas_datagrid_ordenes_compra()!=0)
            {
                Limpia_combo_empleado();
                Aparece_combo_empleado();
                Activa_combo_empleado();
                obtener_usuarios_administrativos_compras_disponibles();
                Rellena_combo_empleado();
                Activa_seleccion_fecha_actual();
            }
            else
            {
                MessageBox.Show("Todo el Material de la Orden esta asignado",
                    "Salida Material", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Termina_secuencia_operaciones_salida_materiales();
            }
        }

        private int Rellenar_partidas_datagrid_ordenes_compra()
        {
            int Row_material = 0;
            int Unidades_salidas = 0;
            Limpia_datagrid_salida_materiales_orden_compra();

            try
            {

                foreach (Partida_orden_compra partida in Partidas_orden_compra_disponibles)
                {
                    Unidades_salidas = Convert.ToInt32(partida.Cantidad) - Calculo_unidades_salidas(partida);
                    if (Unidades_salidas != 0)
                    {
                        dataGridViewSalidasMaterialesOC.Rows.Add(partida.Codigo, "", partida.Material, partida.Parte,
                        partida.Descripcion, "", Unidades_salidas.ToString());
                        

                        dataGridViewSalidasMaterialesOC
                            [(int)Campos_salida_materiales_orden_compra.cantidad, Row_material].Style.BackColor = Color.Yellow;
                        Row_material++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            return Row_material;
        }

        private int Calculo_unidades_salidas(Partida_orden_compra partida)
        {
            Obtener_partidas_salidas_materiales(partida);
            int Total_cantidad = 0;
            for (int renglones = 0; renglones < Salida_materiales_disponibles.Count; renglones++)
            {

                try
                {
                    Total_cantidad = Total_cantidad + Convert.ToInt32(Salida_materiales_disponibles[renglones].Cantidad);
                }
                catch
                {
                    MessageBox.Show("No valores numericos en cantidad", "Salida Materiales",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            return Total_cantidad;

        }

        private void Obtener_partidas_salidas_materiales(Partida_orden_compra partida)
        {
            Asigna_valores_salida_materiales_partidas_material(partida);

            Salida_materiales_disponibles = Class_salida_material.
                Adquiere_salida_materiales_orden_compra_base_datos(Salida_materiales_seleccion);

        }

        private void Asigna_valores_salida_materiales_partidas_material(Partida_orden_compra partida)
        {
            if (Operacio_salida_materiales == "SalidaOC")
            {
                Salida_materiales_seleccion.Orden_compra = comboBoxOC.Text;
                Salida_materiales_seleccion.Codigo_material = partida.Material;
            }
            else if (Operacio_salida_materiales == "Salida")
            {
                if (comboBoxOC.Items.Count != 0)
                {
                    Salida_materiales_seleccion.Orden_compra = comboBoxOC.Text;
                    Salida_materiales_seleccion.Codigo_material = partida.Material;
                }

                else
                {
                    Salida_materiales_seleccion.Orden_compra = partida.Codigo_orden;
                    Salida_materiales_seleccion.Codigo_material = partida.Material;
                }
            }
        }

        private void Obtener_partidas_ordenes_compra_disponibles()
        {

            Partidas_orden_compra_disponibles = class_partidas_Orden_compra.
                Adquiere_partidas_ordenes_compra_disponibles_en_base_datos(comboBoxOC.Text);
        }

        private void Activate_datagrid_salida_materiales_orden_compra()
        {
            dataGridViewSalidasMaterialesOC.Enabled = true;
        }

        private void Desactiva_datagrid_salida_materiales_orden_compra()
        {
            dataGridViewSalidasMaterialesOC.Enabled = true;
        }


        private void Rellenar_combo_proyectos_datagrid_salida_materiales()
        {
            foreach (Proyecto proyecto in Proyectos_disponibles)
            {
                if (proyecto.error == "")
                {
                    Proyectos_ordenes_compra.Items.Add(proyecto.Codigo);
                }
                else
                {
                    MessageBox.Show(proyecto.error);
                    break;
                }
            }
        }

        private void Aparece_datagrid_salida_materiales_orden_compra()
        {
            dataGridViewSalidasMaterialesOC.Visible = true;
        }

        private void Limpia_datagrid_salida_materiales_orden_compra()
        {
            dataGridViewSalidasMaterialesOC.Rows.Clear();
        }

        private void Desaparece_datagrid_salida_materiales_orden_compra()
        {
            dataGridViewSalidasMaterialesOC.Visible = false;
        }

        private void dataGridViewSalidasMaterialesOC_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(Operacio_salida_materiales=="SalidaOC")
            {
                try
                {
                    if (e.ColumnIndex == (int)Campos_salida_materiales_orden_compra.cantidad)
                    {
                        Convert.ToInt32(dataGridViewSalidasMaterialesOC[
                            (int)Campos_salida_materiales_orden_compra.cantidad, e.RowIndex].Value);
                        if (Convert.ToSingle(dataGridViewSalidasMaterialesOC[e.ColumnIndex, e.RowIndex].Value.ToString()) >
                                 Convert.ToSingle(dataGridViewSalidasMaterialesOC[e.ColumnIndex + 1, e.RowIndex].Value.ToString()))
                        {
                            throw new System.ArgumentException("Numero de Unidades Mayor a unidades ordenadas", "Salida Materiales");
                        }

                        dataGridViewSalidasMaterialesOC[
                            (int)Campos_salida_materiales_orden_compra.cantidad, e.RowIndex].Style.BackColor = Color.White;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    dataGridViewSalidasMaterialesOC[
                        (int)Campos_salida_materiales_orden_compra.cantidad, e.RowIndex].Value = "";
                    dataGridViewSalidasMaterialesOC[
                        (int)Campos_salida_materiales_orden_compra.cantidad, e.RowIndex].Style.BackColor = Color.Yellow;
                }
            }
        }

        private void buttonMateriales_Click(object sender, EventArgs e)
        {
            Forma_Consulta_Materiales forma_Consulta_Materiales = new Forma_Consulta_Materiales();
            forma_Consulta_Materiales.ShowDialog();
        }

        private void dataGridViewSalidasMaterialesOC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
