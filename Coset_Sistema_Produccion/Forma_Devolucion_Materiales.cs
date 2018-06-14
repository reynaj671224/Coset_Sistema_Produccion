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
    public partial class Forma_Devolucion_Materiales : Form
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
        public Devolucion_Material Insertar_devolucion_materiales = new Devolucion_Material();
        public Devolucion_Material Devolucion_materiales_seleccion = new Devolucion_Material();
        public Class_Devolucion_Material Class_devolucion_material = new Class_Devolucion_Material();
        public List<Devolucion_Material> Devolucion_materiales_disponibles = new List<Devolucion_Material>();
        public Class_Partidas_Orden_compra class_partidas_Orden_compra = new Class_Partidas_Orden_compra();
        public Partida_orden_compra Partida_orden_compra_seleccionada = new Partida_orden_compra();
        public Material Visualizar_material = new Material();
        public List<Material> Materiales_disponibles_busqueda = new List<Material>();
        public Class_Proyectos Class_Proyectos = new Class_Proyectos();
        public List<Proyecto> Proyectos_disponibles = new List<Proyecto>();
        public Proyecto Proyecto_seleccionado = new Proyecto();
        string appPath = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
        public CultureInfo cultureInfo = new CultureInfo("en-US");
        public string nombre_archivo_word = "";
        public word.Application application = null;
        public word.Document Documento = null;
        public enum Campos_entrada_materiales
        {
            codigo, orden_compra, fecha, codigo_material, cidigo_proveedor, nombre_empleado, descripcion,
            cantidad, precio,
        };

        public string Operacio_devolucion_materiales = "";

        public Forma_Devolucion_Materiales()
        {
            InitializeComponent();
        }

        private void Forma_Clientes_Load(object sender, EventArgs e)
        {
            Desactiva_columna_codigo_partidas_cotizaciones();

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Devolucion_materiales_disponibles = null;
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
            dataGridViewDevolucionEntradaMateriales.Enabled = true;
        }

        private void limpia_partidas_salida_materiales()
        {
            dataGridViewDevolucionEntradaMateriales.Rows.Clear();
        }

        private void No_aceptar_agregar_partidas_salida_materiales()
        {
            dataGridViewDevolucionEntradaMateriales.AllowUserToAddRows = false;
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
            buttonBuscarDevolucion.Enabled = false;
        }


        private void Desactiva_boton_agregar_salida_materiales()
        {
            buttonDevolucionMaterial.Enabled = false;
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

        private void Aparece_caja_codigo_empleado()
        {
            textBoxCodigoProyecto.Visible = true;
        }


        private void configura_forma_devolucion()
        {
            Desactiva_combobox_codigo_proyecto();
            Activa_textbox_codigo_proveedor();
            Activa_textbox_descripcion_material();
            Activa_textbox_codigo_material();
            Asigna_caracter_busqueda_material();
            Inicia_timer_busqueda_materiales();

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
            Desactiva_combobox_codigo_proyecto();
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

        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos_modificar_clientes()
        {
            timerBusquedaMaterial.Enabled = true;
        }

        private void Desactiva_combobox_codigo_proyecto()
        {
            comboBoxCodigoProyecto.Enabled = false;
        }

        public void secuencia_despues_de_busqueda_material()
        {
            if (Operacio_devolucion_materiales == "Visualizar")
            {
                Desactiva_textboxdescripcion_materiales();
            }
            else
            {
                Limpia_combo_empleado();
                Aparece_combo_empleado();
                Activa_combo_empleado();
                obtener_usuarios_administrativos_compras_disponibles();
                Rellena_combo_empleado();
                Activa_seleccion_fecha_actual();
                Activa_textbox_cantidad_material();
                Activa_textbox_motivo_devolucion();
                Desactiva_textboxdescripcion_materiales();
                Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_material();
            }
        }

        private void Desactiva_textboxdescripcion_materiales()
        {
            textBoxDescripcionMaterial.Enabled = false;
        }

        private void Activa_textbox_motivo_devolucion()
        {
            textBoxDescripcionMotivo.Enabled = true;
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

        private void Agrega_devolucion_materiales()
        {

            Desactiva_botones_operacion();
            Acepta_datagridview_agregar_renglones();
            Aparece_boton_cancelar_operacio();
            Activa_datagridview_partidas_entrada_materiales();
            Activa_textbox_codigo_proveedor();
            limpia_combo_proyectos();
            Aparece_combo_proyectos();
            Activa_combo_proyectos();
            obtener_proyectos_base_datos_disponibles();
            Rellenar_combo_proyectos();
            Limpia_combo_empleado();
            Aparece_combo_empleado();
            Activa_combo_empleado();
            obtener_usuarios_administrativos_compras_disponibles();
            Rellena_combo_empleado();
            Activa_seleccion_fecha_actual();
            Operacio_devolucion_materiales = "Devolucion";
        }

        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_material()
        {
            timerAgregarDevolucionMateriales.Enabled = true;
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
            textBoxDescripcionMotivo.Visible = false;
        }

        private void Acepta_datagridview_agregar_renglones()
        {
            dataGridViewDevolucionEntradaMateriales.AllowUserToAddRows = true;
        }

        private void Activa_datagridview_partidas_entrada_materiales()
        {
            dataGridViewDevolucionEntradaMateriales.Enabled = true;
        }

        private void Desactiva_columna_codigo_partidas_cotizaciones()
        {
            dataGridViewDevolucionEntradaMateriales.Columns[0].Visible = false;
        }

        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_orden_compra()
        {
            timerAgregarDevolucionMateriales.Enabled = true;
        }

        private void Activa_cajas_informacion_cotizaciones()
        {
            textBoxEmpleado.Enabled = true;
            dateTimePickerFechaActual.Enabled = true;
            textBoxDescripcionMotivo.Enabled = true;
        }

        private void Modifica_contactos_cliente()
        {
            throw new NotImplementedException();
        }


        private void buttonGuardarBasedeDatos_Click(object sender, EventArgs e)
        {
            if (Operacio_devolucion_materiales == "Devolucion")
            {
                Secuencia_devolucion_materiales();
            }

        }


        private void Aparce_caja_codigo_cliente()
        {
            textBoxCodigoProyecto.Visible = true;
        }


        private void Secuencia_devolucion_materiales()
        {
            if (verifica_campos_numericos())
            {
                if (verfica_datos_entrada_materiales())
                {
                    if (Insertar_datos_devolucion_materiales_class())
                    {
                        if (Devolucion_material_base_datos())
                        {
                            Limpia_cajas_captura_despues_de_agregar_devolucion_material();
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
                            Elimina_informacion_salida_materiales_disponibles();
                        }
                    }

                }
            }

        }

        private bool Devolucion_material_base_datos()
        {
            string respuesta = "";
            try
            {
                Material_disponible_salida_materiales.Cantidad = (Convert.ToInt32(
                    Material_disponible_salida_materiales.Cantidad.ToString()) +
                                Convert.ToUInt32(textBoxUnidadesEntrada.Text)).ToString();

                respuesta = Class_Materiales.Actualiza_base_datos_materiales(
                    Material_disponible_salida_materiales);
                if (respuesta == "NO errores")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(respuesta, "Devolucion Materiales", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private bool Insertar_datos_devolucion_materiales_class()
        {
            string respuesta = "";
            Asigna_valores_salida_materiales();
            respuesta = Class_devolucion_material.Inserta_nuevo_devolucion_material_base_datos(
                Insertar_devolucion_materiales);
            if (respuesta == "NO errores")
            {
                return true;
            }
            else
            {
                MessageBox.Show(respuesta, "Devolucion Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void Asigna_valores_salida_materiales()
        {

            Insertar_devolucion_materiales.Proyecto = comboBoxCodigoProyecto.Text;
            Insertar_devolucion_materiales.Motivo_devolucion = textBoxDescripcionMotivo.Text;
            Insertar_devolucion_materiales.Codigo_proveedor = textBoxCodigoProveedor.Text;
            Insertar_devolucion_materiales.Nombre_empleado = comboBoxEmpleado.Text;
            Insertar_devolucion_materiales.Fecha = dateTimePickerFechaActual.Text;
            Insertar_devolucion_materiales.Codigo_material = textCodigoMaterial.Text;
            Insertar_devolucion_materiales.Cantidad = textBoxUnidadesEntrada.Text;
            Insertar_devolucion_materiales.Descripcion_material = textBoxDescripcionMaterial.Text;

        }

        private bool verfica_datos_entrada_materiales()
        {

            if (
            textBoxDescripcionMotivo.Text != "" &&
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
                MessageBox.Show("Campos en blanco", "Devolucion Materiales", MessageBoxButtons.OK,
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
            for (int partidas = 0; partidas < dataGridViewDevolucionEntradaMateriales.Rows.Count - 1; partidas++)
            {
                for (int campo = 1; campo < dataGridViewDevolucionEntradaMateriales.Rows[partidas].Cells.Count; campo++)
                {
                    if (dataGridViewDevolucionEntradaMateriales.Rows[partidas].Cells[campo].Value == null)
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
            textBoxDescripcionMotivo.Visible = true;
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
            dataGridViewDevolucionEntradaMateriales.Enabled = false;
        }

        private void Elimina_informacion_salida_materiales_disponibles()
        {
            Devolucion_materiales_disponibles = null;
            Usuarios_administrativos = null;
            Proyectos_disponibles = null;
            Materiales_disponibles_busqueda = null;
            Devolucion_materiales_disponibles = null;
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
            buttonBuscarDevolucion.Enabled = true;
        }

        private void Activa_boton_agregar_ccotizacion()
        {
            buttonDevolucionMaterial.Enabled = true;
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
            textBoxDescripcionMotivo.Enabled = false;
            textBoxCodigoProveedor.Enabled = false;
            textBoxUnidadesEntrada.Enabled = false;
            textBoxPrecioMaterial.Enabled = false;
            textBoxDescripcionMaterial.Enabled = false;
            textCodigoMaterial.Enabled = false;

        }


        private void Limpia_cajas_captura_despues_de_agregar_devolucion_material()
        {
            textBoxEmpleado.Text = "";
            textBoxCodigoProyecto.Text = "";
            dateTimePickerFechaActual.Text = DateTime.Today.ToString();
            textBoxDescripcionMotivo.Text = "";
            textBoxCodigoProveedor.Text = "";
            textBoxUnidadesEntrada.Text = "";
            textCodigoMaterial.Text = "";
            textBoxPrecioMaterial.Text = "";
            textBoxTotalUnidades.Text = "";
            textBoxDescripcionMaterial.Text = "";
        }

        private void Desaparece_boton_eliminar_base_de_datos()
        {
            buttonBorrarBasedeDatos.Visible = false;
        }

        private void Rellenar_partidas_salida_materiales()
        {
            Obtener_partidas_devolucion_materiales();
            Rellena_datagrid_devolucion_materiales();

        }
        
        private void Rellena_datagrid_devolucion_materiales()
        {
            foreach (Devolucion_Material material in Devolucion_materiales_disponibles)
            {

                try
                {
                    dataGridViewDevolucionEntradaMateriales.Rows.Add(material.Codigo.ToString(), material.Proyecto,
                        material.Fecha, material.Codigo_material, material.Codigo_proveedor,
                        material.Nombre_empleado, material.Motivo_devolucion, material.Cantidad);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Obtener_partidas_devolucion_materiales()
        {
            Asigna_valores_devolucion_materiales_visualizar();
            Devolucion_materiales_disponibles = Class_devolucion_material.Adquiere_devolucion_materiales_busqueda_en_base_datos(Devolucion_materiales_seleccion);

        }

        private void Asigna_valores_devolucion_materiales_visualizar()
        {

            Devolucion_materiales_seleccion.Proyecto = "N";
            Devolucion_materiales_seleccion.Motivo_devolucion = textBoxDescripcionMotivo.Text;
            Devolucion_materiales_seleccion.Codigo_proveedor = textBoxCodigoProveedor.Text;
            Devolucion_materiales_seleccion.Nombre_empleado = comboBoxEmpleado.Text;
            Devolucion_materiales_seleccion.Fecha = dateTimePickerFechaActual.Text;
            Devolucion_materiales_seleccion.Codigo_material = textCodigoMaterial.Text;
            Devolucion_materiales_seleccion.Cantidad = textBoxUnidadesEntrada.Text;
            Devolucion_materiales_seleccion.Descripcion_material = textBoxDescripcionMaterial.Text;

        }

        private void Limpia_datagridview_entrada_material()
        {
            dataGridViewDevolucionEntradaMateriales.Rows.Clear();
        }

        private void buttonBuscarOrdenCompra_Click(object sender, EventArgs e)
        {
            Visualiza_salida_materiales();
        }

        private void Visualiza_salida_materiales()
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
            Operacio_devolucion_materiales = "Visualizar";

        }

        private void buttonDevolucionMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Operacio_devolucion_materiales == "Devolucion")
                configura_forma_devolucion();
            else if (Operacio_devolucion_materiales == "Visualizar")
                configura_forma_visualizar();

        }

        private void Termina_secuencia_operaciones_salida_materiales()
        {
            Limpia_combo_nombre_cliente();
            Limpia_cajas_captura_despues_de_agregar_devolucion_material();
            Desactiva_cajas_captura_despues_de_agregar_salida_materiales();
            Desaparece_boton_guardar_base_de_datos();
            Desaparece_boton_cancelar();
            Desaparece_combo_codigo_proyecto();
            Desaparece_combo_codigo_proyecto();
            Desaparece_combo_cliente_nombre();
            Activa_botones_operacion();
            limpia_partidas_salida_materiales();
            Desactiva_datagridview_partidas();
            Aparece_caja_codigo_empleado();
            Aparece_textbox_descripcion();
            Aparece_textbox_nombre_cliente();
            Acepta_datagridview_agregar_renglones();
            Pinta_color_blanco_cajas_busqueda_material();
            Termina_timer_busqueda();
            Desaparece_boton_buscar_base_datos();
            Elimina_informacion_salida_materiales_disponibles();

        }

        private void Pinta_color_blanco_cajas_busqueda_material()
        {
            textBoxCodigoProveedor.BackColor = Color.White;
            textBoxDescripcionMaterial.BackColor = Color.White;
            textCodigoMaterial.BackColor = Color.White;
        }

        private void Termina_timer_busqueda()
        {
            timerBusquedaMaterial.Enabled = false;
        }

        private void timerAgregarDevolucionMateriales_Tick(object sender, EventArgs e)
        {

                if (comboBoxEmpleado.Text != "" &&
                    textBoxUnidadesEntrada.Text != "" &&
                    textBoxDescripcionMotivo.Text != "")
                {
                    timerAgregarDevolucionMateriales.Enabled = false;
                    Aparece_boton_guardar_base_datos();
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
                if(Operacio_devolucion_materiales=="Visualizar")
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

                if (Operacio_devolucion_materiales == "Visualizar")
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

        private void Rellena_cajas_informacion_despues_busqueda(Material material)
        {
            if (Operacio_devolucion_materiales == "Visualizar")
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
            textBoxDescripcionMotivo.Text = "";
        }

        private void Desactiva_cajas_captura_busqueda_material()
        {
            textBoxCodigoProveedor.Enabled = false;
            textCodigoMaterial.Enabled = false;
            textBoxDescripcionMotivo.Enabled = false;
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
            if(textCodigoMaterial.Text=="")
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

        private void buttonSalidaMaterial_Click(object sender, EventArgs e)
        {
            Agrega_devolucion_materiales();
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
    }
}
