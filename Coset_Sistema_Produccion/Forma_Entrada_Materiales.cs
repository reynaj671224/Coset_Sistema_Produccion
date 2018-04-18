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
        public Partida_orden_compra Partida_orden_compra_seleccionada = new Partida_orden_compra();
        public Proveedor Proveedor_modificaciones = new Proveedor();
        public List<Partida_requisicion> Partidas_requisiciones_disponibles_numero_parte
            = new List<Partida_requisicion>();
        public Class_Materiales Class_Materiales = new Class_Materiales();
        public List<Material> Materiales_disponible_entrada_materiales = new List<Material>();
        public Material Material_disponible_entrada_materiales = new Material();
        public Entrada_Material Insertar_entrada_materiales = new Entrada_Material();
        public Entrada_Material Entrada_materiales_seleccion = new Entrada_Material();
        public Class_Entrada_Material Class_entrada_material = new Class_Entrada_Material();
        public List<Entrada_Material> Entrada_materiles_disponibles = new List<Entrada_Material>();
        string RenglonParaEliminar = "";
        string Requisicion_eliminar = "";
        string Descripcion_eleiminar = "";
        string appPath = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
        public CultureInfo cultureInfo = new CultureInfo("en-US");
        public string nombre_archivo_word = "";
        public word.Application application = null;
        public word.Document Documento = null;
        public enum Campos_entrada_materiales
        {
            codigo, orden_compra, fecha, codigo_material, cidigo_proveedor,nombre_empleado,descripcion,
            cantidad,precio,
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
            this.Dispose();
            GC.Collect();
            this.Close();
        }




        
        private void Visualiza_orden_compra()
        {
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
            Operacio_entrada_materiales = "Visualizar";
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

        private void configura_forma_copiar()
        {
            limpia_partidas_ordenes_compra();
            Rellena_cajas_informacion_de_orden_compra();
            Obtener_datos_partidas_ordenes_compra_disponibles_base_datos(comboBoxCodigoOrdenCompra.Text);
            Aparece_boton_guardar_base_datos();
        }

        private void configura_forma_agregar()
        {
            Limpia_combo_descripcion_materiales();
            Aparecer_combo_descripcion_materiales();
            Activa_combo_descripcion_materiales();
            Desaparece_textbox_descripcion_materiales();
            Obtener_materiales_ordenes_compra();
            Rellena_combo_descripcion_materiales();

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
         }

        private void configura_forma_visualizar()
        {
            Limpia_combo_descripcion_materiales();
            Aparecer_combo_descripcion_materiales();
            Activa_combo_descripcion_materiales();
            Desaparece_textbox_descripcion_materiales();
            Obtener_materiales_ordenes_compra();
            Rellena_combo_descripcion_materiales();

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
            Aparece_boton_guardar_base_datos();
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

        private void Aparece_boton_guardar_base_datos()
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
            Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_material();
            Operacio_entrada_materiales = "Agregar";
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
            if (Operacio_entrada_materiales == "Agregar")
                Secuencia_agregar_entrada_materiales();
            else if (Operacio_entrada_materiales == "Visualizar")
                Secuencia_agregar_entrada_materiales();
        }

        private void Secuencia_agregar_partidas()
        {
            if (verifica_datos_partidas())
            {

                Desaparece_boton_guardar_base_de_datos();
                limpia_partidas_ordenes_compra();
                Obtener_datos_partidas_ordenes_compra_disponibles_base_datos(comboBoxCodigoOrdenCompra.Text);
                Elimina_informacion_orden_compra_disponibles();

            }
        }



        private void Secuencia_modificar_orden_compra()
        {
            if (verifica_datos_partidas())
            {
                    if (Modifica_datos_orden_compra())
                    {
                        Limpia_cajas_captura_despues_de_agregar_orden_compra();
                        Limpia_combo_nombre_cliente();
                        Limpia_combo_descripcion_materiales();
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


        private void Aparce_caja_codigo_cliente()
        {
            textBoxCodigoOrdenCompra.Visible = true;
        }

        private bool Modifica_datos_orden_compra()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_almacen());
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

        private void Secuencia_agregar_entrada_materiales()
        {
            if (verifica_cantidad_numerico())
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

        }

        private bool Agrega_entrada_material_base_datos()
        {
            Material_disponible_entrada_materiales.Cantidad = (Convert.ToInt32(Material_disponible_entrada_materiales.Cantidad.ToString()) +
                            Convert.ToUInt32(textBoxUnidadesEntrada.Text)).ToString();
            if (Class_Materiales.Actualiza_base_datos_materiales(
                Material_disponible_entrada_materiales) == "NO errores")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Insertar_datos_entrada_materiales_class()
        {
            Asigna_valores_entrada_materiales();
            if (Class_entrada_material.Inserta_nuevo_entrada_material_base_datos(
                Insertar_entrada_materiales) == "NO errores")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void Asigna_valores_entrada_materiales()
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

        private bool verfica_datos_entrada_materiales()
        {
            if (comboBoxCodigoOrdenCompra.Text != "" &&
                comboBoxDescripcionMaterial.Text != "" &&
                textBoxCodigoProveedor.Text != "" &&
                comboBoxEmpleado.Text != "" &&
                textBoxTotalUnidades.Text != "" &&
                textBoxUnidadesEntradas.Text != "" &&
                textCodigoMaterial.Text != "" &&
                textBoxPrecioMaterial.Text != "" &&
                textBoxUnidadesEntrada.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool verifica_cantidad_numerico()
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
            textBoxUnidadesEntrada.Enabled = false;

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
        }

       

        private string Configura_cadena_comando_actualizar_en_base_de_datos_partidas_requisiciones(Partida_orden_compra partida_orden_compra_agregar)
        {
            return "UPDATE partidas_requisiciones set  orden_compra_asignada='" + partida_orden_compra_agregar.Codigo_orden+
                "' where codigo_requisicion='" + partida_orden_compra_agregar.Requisicion + "' and numero_parte='" +
                partida_orden_compra_agregar.Parte+"' ;";
        }

        private void Asigna_codigo_orden_compra_para_tipo_de_operacio()
        {
            if (Operacio_entrada_materiales == "Agregar")
                Partida_orden_compra_agregar.Codigo_orden = textBoxCodigoOrdenCompra.Text;
            else if (Operacio_entrada_materiales == "Agregar Partidas" || Operacio_entrada_materiales == "Copiar")
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

        private bool Insertar_datos_entrada_materiales()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_almacen());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_insertar_en_base_de_datos_entrada_materiales(), connection);
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

        private string Configura_cadena_comando_insertar_en_base_de_datos_entrada_materiales()
        {
            return "INSERT INTO entrada_material(orden_compra,fecha, codigo_material," +
                "cantidad_material,codigo_proveedor_material,nombre_empleado,descripcion_material,precio) " +
                "VALUES('" + comboBoxCodigoOrdenCompra.Text + "','" + dateTimePickerFechaActual.Text + "','" +
                textCodigoMaterial.Text + "','" + textBoxUnidadesEntrada.Text + "','" + textBoxCodigoProveedor.Text + 
                "','" + comboBoxEmpleado.Text + "','" +comboBoxDescripcionMaterial.Text + "','" + 
                textBoxPrecioMaterial.Text + "');";
        }

        private string Configura_cadena_conexion_MySQL_almacen()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=almacen;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
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

        private bool Elimina_informacion_orden_compra_en_base_de_datos()
        {
            return (Elimina_datos_orden_compra() && Elinina_partidas_orden_compra());
        }

        private bool Elinina_partidas_orden_compra()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_almacen());
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
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_almacen());
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
            Operacio_entrada_materiales = "Agregar Partidas";
            limpia_partidas_ordenes_compra();
            Obtener_requisiciones_sin_orden_compra_asiganda_por_proveedor();
            Limpia_datagridview_ordenes_compra();
            Acepta_datagridview_agregar_renglones();
            Aparece_boton_guardar_base_datos();
        }


        private void buttonBorrarBasedeDatos_Click(object sender, EventArgs e)
        {

            if (Operacio_entrada_materiales == "Eliminar partida")
                Elimina_partida_orden_compra();
            else if (Operacio_entrada_materiales == "Eliminar")
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
                            limpia_texto_eliminar_pertida_orden_compra();
                            Desaparece_boton_eliminar_base_de_datos();
                        }
                    }
                }
            }
            
        }

        private bool Actualiza_requisicion_orden_compra_asignada()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_almacen());
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
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_almacen());
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

            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_almacen());
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
            Operacio_entrada_materiales = "Copiar";
        }


        private void comboBoxDescripcionMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            Partida_orden_compra_seleccionada = partidas_ordenes_compra_disponibles.Find(partidas_ordenes_compra => partidas_ordenes_compra.Descripcion.Contains(comboBoxDescripcionMaterial.SelectedItem.ToString()));
            Rellenar_campos_entrada_materiales();
            Rellenar_partidas_entrada_materiles();
        }

        private void Rellenar_partidas_entrada_materiles()
        {
            Obtener_partidas_entrada_materiles();
            Rellena_datagrid_entrada_materiles();
            Rellena_caja_cantidad_entradas_anteriormente();
            Verfica_total_unidades_entradas();
        }

        private void Rellena_datagrid_entrada_materiles()
        {
            foreach (Entrada_Material material in Entrada_materiles_disponibles)
            {

                try
                {
                    dataGridViewPartidasOrdenCompra.Rows.Add(material.Codigo.ToString(), material.Orden_compra,
                        material.Fecha, material.Codigo_material, material.Codigo_proveedor,
                        material.Nombre_empleado, material.Descripcion_material, material.Cantidad, material.Precio);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Obtener_partidas_entrada_materiles()
        {
            Asigna_valores_entrada_materiales_visualizar();
            Entrada_materiles_disponibles = Class_entrada_material.Adquiere_entrada_materiales_busqueda_en_base_datos(Entrada_materiales_seleccion);
        }

        private void Asigna_valores_entrada_materiales_visualizar()
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

        private void Rellenar_campos_entrada_materiales()
        {
            if (Obtener_materiales_con_descripcion_codigo_proveedor())
            {
                textBoxTotalUnidades.Text = Partida_orden_compra_seleccionada.Cantidad;
                textBoxCodigoProveedor.Text = Partida_orden_compra_seleccionada.Parte;
                textCodigoMaterial.Text = Material_disponible_entrada_materiales.Codigo;
                textBoxPrecioMaterial.Text = Partida_orden_compra_seleccionada.precio_unitario;
            }

        }

        private void Verfica_total_unidades_entradas()
        {
            if (Operacio_entrada_materiales == "Agregar")
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
           for(int renglones=0;renglones< dataGridViewPartidasOrdenCompra.Rows.Count; renglones++)
            { 

                if (dataGridViewPartidasOrdenCompra[(int)Campos_entrada_materiales.cantidad, renglones].Value != null)
                {
                    try
                    {
                        Total_cantidad = Total_cantidad + Convert.ToInt32(dataGridViewPartidasOrdenCompra[
                            (int)Campos_entrada_materiales.cantidad, renglones].Value.ToString());
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

        private bool Obtener_materiales_con_descripcion_codigo_proveedor()
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
            if (Operacio_entrada_materiales == "Agregar" )
            {
                Partidas_requisiciones_disponibles_ordenes_compra_no_asignadas = Class_partidas_requisiciones.
                    Adquiere_partidas_requisiciones_disponibles_en_base_datos_orden_compra_no_asignadas(comboBoxDescripcionMaterial.Text);
            }
            else if (Operacio_entrada_materiales == "Operaciones Patidas" || Operacio_entrada_materiales == "Agregar Partidas")
            {
                Partidas_requisiciones_disponibles_ordenes_compra_no_asignadas = Class_partidas_requisiciones.
                    Adquiere_partidas_requisiciones_disponibles_en_base_datos_orden_compra_no_asignadas(textBoxDescripcionMaterial.Text);
            }
        }


        private void dataGridViewPartidasOrdenCompra_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    if (e.ColumnIndex == (int)Campos_entrada_materiales.requisicion && e.RowIndex >= 0) //check if combobox column
            //    {
            //        if (dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //        {
            //            string selectedValue = dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            //            /*rellena combo numero de parte disponible para requisicio*/

            //            DataGridViewComboBoxCell combo_descripcion = (DataGridViewComboBoxCell)dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[(int)Campos_entrada_materiales.descrpcion];
            //            combo_descripcion.Items.Clear();
            //            combo_descripcion.Value = "";
            //            foreach (Partida_requisicion partida_requisicion in Partidas_requisiciones_disponibles_ordenes_compra_no_asignadas)
            //            {
            //                if (partida_requisicion.Codigo_requisicion == selectedValue)
            //                {
            //                    combo_descripcion.Items.Add(partida_requisicion.Descripcion);
            //                }

            //            }
            //        }
            //    }
            //    else if (e.ColumnIndex == (int)Campos_entrada_materiales.descrpcion && e.RowIndex >= 0) //check if combobox column
            //    {
            //        if (Operacio_orden_compra == "Agregar" || Operacio_orden_compra == "Agregar Partidas")
            //        {
            //            if (dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //            {
            //                string selectedValue = dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            //                foreach (Partida_requisicion partida_requisicion in Partidas_requisiciones_disponibles_ordenes_compra_no_asignadas)
            //                {
            //                    if (partida_requisicion.Descripcion == selectedValue)
            //                    {
            //                        dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells["Cantidad_partida"].Value = partida_requisicion.Cantidad;
            //                        dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells["Parte_partida"].Value = partida_requisicion.Numero;
            //                        dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells["UnidadMedida_compra"].Value = partida_requisicion.Unidad_medida;
            //                        dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells["Proyecto_compra"].Value = partida_requisicion.Proyecto;

            //                    }

            //                }
            //            }
            //        }else if(Operacio_orden_compra == "Modificar")
            //        {
            //            if (dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //            {
            //                string selectedValue = dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            //                foreach (Partida_requisicion partida_requisicion in Partidas_requisiciones_disponibles_numero_parte)
            //                {
            //                    if (partida_requisicion.Descripcion == selectedValue)
            //                    {
            //                        dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells["Cantidad_partida"].Value = partida_requisicion.Cantidad;
            //                        dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells["Parte_partida"].Value = partida_requisicion.Numero;
            //                        dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells["UnidadMedida_compra"].Value = partida_requisicion.Unidad_medida;
            //                        dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells["Proyecto_compra"].Value = partida_requisicion.Proyecto;

            //                    }

            //                }
            //            }
            //        }
            //    }
            //    else if (e.ColumnIndex == (int)Campos_entrada_materiales.cantidad && e.RowIndex >= 0)
            //    {
            //        if (dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //        {
            //            try
            //            {
            //                Convert.ToSingle(dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            //            }
            //            catch
            //            {
            //                dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
            //            }
            //        }
            //    }
            //    else if (e.ColumnIndex == (int)Campos_entrada_materiales.partida && e.RowIndex >= 0)
            //    {
            //        if (dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //        {
            //            try
            //            {
            //                Convert.ToSingle(dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            //            }
            //            catch
            //            {
            //                dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
            //            }
            //        }

            //    }
            //    else if (e.ColumnIndex == (int)Campos_entrada_materiales.precio && e.RowIndex >= 0)
            //    {
            //        if (dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //        {
            //            try
            //            {
            //                dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[(int)Campos_entrada_materiales.total].Value =
            //                    (Convert.ToSingle(dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) *
            //                    Convert.ToSingle(dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[(int)Campos_entrada_materiales.cantidad].Value)).ToString("####.##");

            //            }
            //            catch
            //            {
            //                dataGridViewPartidasOrdenCompra.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
            //            }
            //        }
            //    }
            //}
            //catch(Exception er)
            //{
            //    MessageBox.Show(er.Message);
            //}

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
            if (Operacio_entrada_materiales == "Agregar")
                configura_forma_agregar();
            else if (Operacio_entrada_materiales == "Visualizar")
                configura_forma_visualizar();

        }

        private void buttonAgregarPartida_Click(object sender, EventArgs e)
        {
            Agrega_partida_orden_compra();
        }

        private void dataGridViewPartidasOrdenCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Operacio_entrada_materiales == "Eliminar partida")
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
            Operacio_entrada_materiales = "Eliminar";
        }

        private void buttonModificarCotizacion_Click(object sender, EventArgs e)
        {
            Modifica_orden_compra();
        }


        private void Termina_secuencia_operaciones_ordenes_compra()
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
            Activa_botones_operacion();
            limpia_partidas_ordenes_compra();
            Desactiva_datagridview_partidas();
            Aparece_caja_codigo_empleado();
            Aparece_textbox_atencion();
            Aparece_textbox_nombre_cliente();
            Acepta_datagridview_agregar_renglones();
            Elimina_informacion_orden_compra_disponibles();

        }
        private void Termina_secuencia_save_file()
        {
            Termina_secuencia_operaciones_ordenes_compra();
        }

        private void timerAgregarEntradaMateriales_Tick(object sender, EventArgs e)
        {
            if(comboBoxCodigoOrdenCompra.Text != "" &&
                comboBoxDescripcionMaterial.Text !="" &&
                textBoxCodigoProveedor.Text != "" &&
                comboBoxEmpleado.Text !="" &&
                textBoxTotalUnidades.Text != "" &&
                textBoxUnidadesEntradas.Text !="" &&
                textCodigoMaterial.Text !="" &&
                textBoxPrecioMaterial.Text != "" &&
                textBoxUnidadesEntrada.Text !="")
            {
                timerAgregarEntradaMateriales.Enabled = false;
                Aparece_boton_guardar_base_datos();
            }
        }
    }
}
