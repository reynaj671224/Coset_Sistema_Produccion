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
    public partial class Forma_Requisiciones : Form
    {
        public Class_Requisiciones class_Requisiciones = new Class_Requisiciones();
        public Requisicion requisicion_visualizar = new Requisicion();
        public Requisicion Requisicion_modificaciones = new Requisicion();
        public List<Requisicion> requisiciones_disponibles = new List<Requisicion>();
        public Class_Usuarios class_Usuarios = new Class_Usuarios();
        public Usuario Usuario_requisitores = new Usuario();
        public List<Usuario> Usuarios_administrativos = new List<Usuario>();
        public List<Usuario> Usuarios_requisitores = new List<Usuario>();
        public Partida_requisicion partida_requisicion_agregar = new Partida_requisicion();
        public Class_Control_Folios class_folio_disponible = new Class_Control_Folios();
        public Control_folio folio_disponible = new Control_folio();
        public Datos_generales datos_generales = new Datos_generales();
        public Class_Datos_Generales Class_Datos_Generales = new Class_Datos_Generales();
        public List<Partida_requisicion> Partidas_requisicion_disponibles = new List<Partida_requisicion>();
        public Class_Partidas_Requisiciones Class_partidas_requisiciones = new Class_Partidas_Requisiciones();
        public Class_Proveedores Class_Proveedores = new Class_Proveedores();
        public List<Proveedor> Proveedores_disponibles = new List<Proveedor>();
        public List<Proyecto> proyectos_disponibles = new List<Proyecto>();
        public Class_Proyectos Class_proyectos = new Class_Proyectos();
        string RenglonParaEliminar = "";
        string appPath = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
        public CultureInfo cultureInfo = new CultureInfo("en-US");
        public string nombre_archivo_word = "";
        public word.Application application = null;
        public word.Document Documento = null;
        public int Numero_renglones_rellenos_requisicion=0;
        public enum Campos_partidas
        {
            codigo,partida,cantidad,numero, descripcion,
            uidad_medida, proyecto,proveedor
        };

        public string Operacio_requisiciones = "";

        public Forma_Requisiciones()
        {
            InitializeComponent();
        }

        private void Forma_Clientes_Load(object sender, EventArgs e)
        {
            Desactiva_columna_codigo_partidas_cotizaciones();
            if (Forma_Inicio_Usuario.Usuario_global.tipo_empleado == "Administrativo" || Forma_Inicio_Usuario.Usuario_global.tipo_empleado == "Admin-Compras")
            {
                buttonModificarRequisicion.Visible = true;
                buttonBuscarRequisicion.Visible = true;

            }

            Habilita_combo_para_aceptar_buscar_elemento_escribiendo_en_ventana();
        }

        private void Habilita_combo_para_aceptar_buscar_elemento_escribiendo_en_ventana()
        {
            comboBoxRequsitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBoxRequsitor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxRequsitor.AutoCompleteSource = AutoCompleteSource.ListItems;


            comboBoxProveedoresPrevio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBoxProveedoresPrevio.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxProveedoresPrevio.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Elimina_informacion_requisiciones_disponibles();
            class_folio_disponible = null;
            folio_disponible = null;
            Cierra_documento_word();
            Terminar_applicacion_word();
            this.Dispose();
            this.Close();
            GC.Collect();
            
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
            Limpia_combo_requisiciones();
            Limpia_combo_proyectos_partidas();
            Desaparece_caja_captura_codigo_requisciciones();
            Aparece_combo_codigo_cotizacion();
            Activa_combo_codigo_requisiciones();
            Obtener_datos_requisiciones_disponibles_base_datos();
            Rellena_combo_codigo_requisiciones();
            Aparece_boton_cancelar_operacio();
            Activa_cajas_informacion_requisiciones();
            No_aceptar_agregar_contactos_requisiciones();
            Activa_dataview_partidas_requisiciones();
            Obtener_proveedores_disponibles();
            Rellena_combo_proveedores_partida_requisicion();
            obtener_proyectos_disponibles();
            Rellenar_combo_proyectos_partidas_requisiciones();
            Operacio_requisiciones = "Visualizar";
        }

        private void Aparece_grupo_previo_word()
        {
            groupBoxPrevio.Visible=true;
        }

        private void Activa_combo_codigo_requisiciones()
        {
            comboBoxCodigoRequisiciones.Enabled = true;
        }

        private void Activa_dataview_partidas_requisiciones()
        {
            dataGridViewPartidasRequisiciones.Enabled = true;
        }

        private void limpia_partidas_requisicion()
        {
            dataGridViewPartidasRequisiciones.Rows.Clear();
        }

        private void No_aceptar_agregar_contactos_requisiciones()
        {
            dataGridViewPartidasRequisiciones.AllowUserToAddRows = false;
        }

        private void Aparece_boton_cancelar_operacio()
        {
            buttonCancelar.Visible = true;
        }


        private void Aparece_combo_codigo_cotizacion()
        {
            comboBoxCodigoRequisiciones.Visible = true;
        }

        private void Desaparece_caja_captura_codigo_requisciciones()
        {
            textBoxCodigoRequisiciones.Visible = false;
        }

        private void Desactiva_botones_operacion()
        {
            Desactiva_boton_agregar_cotizacion();
            Desactiva_boton_visualizar_cotizacion();
            Desactiva_boton_Agregar_proveedor();

        }

        private void Desactiva_boton_Agregar_proveedor()
        {
            buttonModificarRequisicion.Enabled = false;
        }

        private void Desactiva_boton_visualizar_cotizacion()
        {
            buttonBuscarRequisicion.Enabled = false;
        }

        private void Desactiva_boton_agregar_cotizacion()
        {
            buttonAgregarCotizacion.Enabled = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Limpia_combo_codigo_requisicion();
            Limpia_combo_requisitor();
            Limpia_combo_dirigido();
            Limpia_cajas_captura_despues_de_agregar_cotizacion();
            Limpia_combo_codigo_requisicion();
            Desactiva_cajas_captura_despues_de_agregar_cotizacion();
            Desaparece_boton_guardar_base_de_datos();
            Desaparece_boton_cancelar();
            Desaparece_combo_codigo_requisicion();
            Desaparece_combo_requisitor();
            Desaparece_combo_dirigido();
            Desaparece_combo_codigo_requisicion();
            Activa_botones_operacion();
            limpia_partidas_requisicion();
            Desactiva_datagridview_partidas();
            Aparece_caja_codigo_empleado();
            Aparece_textbox_requisitor();
            Aparece_textbox_dirigido();
            Acepta_datagridview_agregar_renglones();
            Desaparce_previo_word();
            Cierra_documento_word();
            Activa_boton_cotizacion_previo();
            Desabilita_boton_word_previo();
            Elimina_archivo();
            Elimina_informacion_requisiciones_disponibles();
        }

        private void Limpia_combo_dirigido()
        {
            comboBoxDirigido.Items.Clear();
            comboBoxDirigido.Text = "";
        }

        private void Limpia_combo_requisitor()
        {
            comboBoxRequsitor.Items.Clear();
            comboBoxRequsitor.Text = "";
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

        private void Aparece_caja_codigo_empleado()
        {
            textBoxCodigoRequisiciones.Visible = true;
        }

        private void comboBoxCodigoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Operacio_requisiciones == "Modificar")
                configura_forma_modificar();
            else if (Operacio_requisiciones == "Visualizar")
                configura_forma_visualizar();

        }

        private void configura_forma_copiar()
        {
            limpia_partidas_requisicion();
            Aparce_boton_guardar_base_datos();
        }

        private void configura_forma_agregar()
        {
            Desactiva_combobox_codigo_requisiciones();
        }


        private void configura_forma_operaciones_contactos()
        {
            Desactiva_combobox_codigo_requisiciones();
            limpia_partidas_requisicion();

        }

        private void configura_forma_visualizar()
        {
            limpia_partidas_requisicion();
            Activa_combo_proveedor_previo();
            limpia_combo_proveedoes_previo();
            rellena_cajas_informacio_requisicion();
            Obtener_datos_partidas_requisiciones_disponibles_base_datos();
            Rellena_campos_partidas_requisiciones();
            Aparece_grupo_previo_word();
            Crear_lista_proveedores_para_previo();
        }

        private void limpia_combo_proveedoes_previo()
        {
            comboBoxProveedoresPrevio.Items.Clear();
            comboBoxProveedoresPrevio.Text = "";
        }

        private void Activa_combo_proveedor_previo()
        {
            comboBoxProveedoresPrevio.Enabled = true;
        }

        private void Crear_lista_proveedores_para_previo()
        {
            List<string> lista_sin_repeticiones = new List<string>();
            lista_sin_repeticiones=Adquiere_lista_completa_proveedores_de_datagridview().Distinct().ToList();
            Rellena_combo_codigo_requisiciones_proveedores_previo(lista_sin_repeticiones);
        }

        private void Rellena_combo_codigo_requisiciones_proveedores_previo(List<string> Proveedores)
        {
            foreach (string proveedor in Proveedores)
            {
                comboBoxProveedoresPrevio.Items.Add(proveedor);
            }
        }

        private List<string> Adquiere_lista_completa_proveedores_de_datagridview()
        {
            List<string> proveedores = new List<string>();
            for (int partidas = 0; partidas < dataGridViewPartidasRequisiciones.Rows.Count; partidas++)
            {
                if (dataGridViewPartidasRequisiciones.Rows[partidas].Cells["Proveedor_requisicion"].Value != null ||
                     dataGridViewPartidasRequisiciones.Rows[partidas].Cells["Proveedor_requisicion"].Value.ToString() != "")
                {
                    proveedores.Add(dataGridViewPartidasRequisiciones.Rows[partidas].Cells["Proveedor_requisicion"].Value.ToString());
                }            }
                return proveedores;
        }

        private void rellena_cajas_informacio_requisicion()
        {
            requisicion_visualizar = requisiciones_disponibles.Find(requision => requision.Codigo.Contains(comboBoxCodigoRequisiciones.SelectedItem.ToString()));
            textBoxRequsitor.Text = requisicion_visualizar.Requisitor;
            textBoxDirigido.Text = requisicion_visualizar.Dirigido;
            dateTimePickerFechaActual.Text = requisicion_visualizar.Fecha;
        }

        private void configura_forma_eliminar()
        {
            limpia_partidas_requisicion();
        }


        private void configura_forma_modificar()
        {
            limpia_partidas_requisicion();
            //Activa_cajas_informacion_requisiciones();
            Desactiva_combobox_codigo_requisiciones();
            rellena_combos_informacio_requisicion();
            Obtener_datos_partidas_requisiciones_disponibles_base_datos();
            Rellena_campos_partidas_requisiciones();
            Limpia_combo_clientes_partidas();
            Obtener_proveedores_disponibles();
            Rellena_combo_proveedores_partida_requisicion();
            Aparce_boton_guardar_base_datos();


        }

        private void Limpia_combo_clientes_partidas()
        {
            Proveedor_requisicion.Items.Clear();
        }

        private void Rellena_combo_proveedores_partida_requisicion()
        {

            foreach (Proveedor proveedor in Proveedores_disponibles)
            {
                if (proveedor.error == "")
                    Proveedor_requisicion.Items.Add(proveedor.Nombre);
                else
                {
                    MessageBox.Show(proveedor.error);
                    break;
                }
            }
        }

        private void Obtener_proveedores_disponibles()
        {
            Proveedores_disponibles = Class_Proveedores.Adquiere_proveedores_disponibles_en_base_datos();
        }

        private void Rellena_campos_partidas_requisiciones()
        {
            foreach (Partida_requisicion partida in Partidas_requisicion_disponibles)
            {

                try
                {
                    dataGridViewPartidasRequisiciones.Rows.Add(partida.Codigo.ToString(), partida.Partida,
                        partida.Cantidad, partida.Numero ,partida.Descripcion, partida.Unidad_medida, 
                        partida.Proyecto,partida.Proveedor);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Obtener_datos_partidas_requisiciones_disponibles_base_datos()
        {
            Partidas_requisicion_disponibles = Class_partidas_requisiciones.Adquiere_partidas_requisiciones_disponibles_en_base_datos(comboBoxCodigoRequisiciones.Text);
        }

        private void rellena_combos_informacio_requisicion()
        {
            Requisicion_modificaciones = requisiciones_disponibles.Find(requision => requision.Codigo.Contains(comboBoxCodigoRequisiciones.SelectedItem.ToString()));
            comboBoxRequsitor.Text = Requisicion_modificaciones.Requisitor;
            comboBoxDirigido.Text = Requisicion_modificaciones.Dirigido;
            dateTimePickerFechaActual.Text = Requisicion_modificaciones.Fecha;
        }

        private void Aparce_boton_guardar_base_datos()
        {
            buttonGuardarBasedeDatos.Visible = true;
        }

        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos_modificar_clientes()
        {
            timerModificarClientes.Enabled = true;
        }

        private void Desactiva_combobox_codigo_requisiciones()
        {
            comboBoxCodigoRequisiciones.Enabled = false;
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
            Limpia_combo_dirigido();
            Limpia_combo_requisitor();
            Limpia_combo_requisiciones();
            Limpia_combo_proyectos_partidas();
            Desactiva_botones_operacion();
            Activa_fecha_seleccion();
            Acepta_datagridview_agregar_renglones();
            Aparece_combo_requisitor();
            Activa_combo_requisitor();
            Activa_Combo_dirigido();
            Aparece_combo_dirigido();
            Obtener_datos_usuarios_administrativos_compas_disponibles_base_datos();
            rellena_combo_dirigido();
            Obtener_datos_usuarios_requisitores_disponibles_base_datos();
            rellena_combo_requisitores();
            obtener_proyectos_disponibles();
            Rellenar_combo_proyectos_partidas_requisiciones();
            Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_requisicion();
            Aparece_boton_cancelar_operacio();
            Activa_datagridview_contactos_clientes();
            Desactiva_combobox_codigo_requisiciones();
            Desactiva_combo_partidas_proveedores();
            Operacio_requisiciones = "Agregar";
        }

        private void Limpia_combo_proyectos_partidas()
        {
            Proyecto_partida.Items.Clear();
        }

        private void Rellenar_combo_proyectos_partidas_requisiciones()
        {
            foreach(Proyecto proyecto in proyectos_disponibles)
            {
                if (proyecto.error == "")
                {
                    Proyecto_partida.Items.Add(proyecto.Codigo);
                }
                else
                {
                    MessageBox.Show(proyecto.error);
                }

            }
        }

        private void obtener_proyectos_disponibles()
        {
            proyectos_disponibles = Class_proyectos.Adquiere_proyectos_disponibles_en_base_datos();
        }

        private void Desactiva_combo_partidas_proveedores()
        {
            Proveedor_requisicion.ReadOnly = true;
        }

        private void Activa_fecha_seleccion()
        {
            dateTimePickerFechaActual.Enabled = true;
        }

        private void rellena_combo_requisitores()
        {
            foreach (Usuario usuario in Usuarios_requisitores)
            {
                if (usuario.error == "")
                    comboBoxRequsitor.Items.Add(usuario.nombre_empleado);
                else
                {
                    MessageBox.Show(usuario.error);
                    break;
                }
            }
        }

        private void Obtener_datos_usuarios_requisitores_disponibles_base_datos()
        {
            Usuarios_requisitores = class_Usuarios.Adquiere_usuarios_requsitores_disponibles_en_base_datos();
        }

        private void rellena_combo_dirigido()
        {
            foreach (Usuario usuario in Usuarios_administrativos)
            {
                if (usuario.error == "")
                    comboBoxDirigido.Items.Add(usuario.nombre_empleado);
                else
                {
                    MessageBox.Show(usuario.error);
                    break;
                }
            }
        }

        private void Obtener_datos_usuarios_administrativos_compas_disponibles_base_datos()
        {
            Usuarios_administrativos = class_Usuarios.Adquiere_usuarios_administrativos_compras_disponibles_en_base_datos();
        }

        private void Aparece_combo_dirigido()
        {
            comboBoxDirigido.Visible = true;
        }

        private void Aparece_combo_requisitor()
        {
            comboBoxRequsitor.Visible = true;
        }

        private void Aparecer_combo_atencion()
        {
            comboBoxRequsitor.Visible = true;
        }

        private void Activa_combo_requisitor()
        {
            comboBoxRequsitor.Enabled = true;
        }

        private void Desaparece_textbox_atencion()
        {
            textBoxRequsitor.Visible = false;
        }

        private void Asigna_codigo_cliente_foilio_disponible()
        {
            folio_disponible = class_folio_disponible.Obtener_informacion_control_folio_base_datos();
            textBoxCodigoRequisiciones.Text = folio_disponible.Folio_requisiciones;
        }

        private void Acepta_datagridview_agregar_renglones()
        {
            dataGridViewPartidasRequisiciones.AllowUserToAddRows = true;
        }

        private void Activa_datagridview_contactos_clientes()
        {
            dataGridViewPartidasRequisiciones.Enabled = true;
        }

        private void Desactiva_columna_codigo_partidas_cotizaciones()
        {
            dataGridViewPartidasRequisiciones.Columns[0].Visible = false;
        }

        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_requisicion()
        {
            timerAgregarRequisicion.Enabled = true;
        }

        private void Activa_cajas_informacion_requisiciones()
        {
            dateTimePickerFechaActual.Enabled = true;
            textBoxRequsitor.Enabled = true;
            textBoxDirigido.Enabled = true;
        }

        private void Modifica_contactos_cliente()
        {
            throw new NotImplementedException();
        }

        private void buttonGuardarBasedeDatos_Click(object sender, EventArgs e)
        {
            if (Operacio_requisiciones == "Agregar")
                Secuencia_agregar_partidas_requisiciones();
            else if (Operacio_requisiciones == "Modificar")
                Secuencia_modificar_requisiciones();

        }

        private void Secuencia_modificar_requisiciones()
        {
            if (Actulaiza_datos_partidas_requisiciones())
            {
                if (Actualiza_datos_requisicion())
                {
                    Limpia_cajas_captura_despues_de_agregar_cotizacion();
                    Limpia_combo_codigo_requisicion();
                    Limpia_combo_requisitor();
                    Limpia_combo_dirigido();
                    Desactiva_cajas_captura_despues_de_agregar_cotizacion();
                    Desaparece_boton_guardar_base_de_datos();
                    Desaparece_boton_cancelar();
                    Desaparece_combo_codigo_requisicion();
                    Activa_botones_operacion();
                    limpia_partidas_requisicion();
                    Desactiva_datagridview_partidas();
                    Desaparece_combo_requisitor();
                    Desactiva_combo_requisitor();
                    Desaparece_combo_dirigido();
                    Desactiva_combo_dirigido();
                    Aparece_textbox_requisitor();
                    Aparece_textbox_dirigido();
                    Desactiva_columna_proveedores_datagrid();
                    Elimina_informacion_requisiciones_disponibles();
                }
            }
        }

        private void Desactiva_columna_proveedores_datagrid()
        {
            dataGridViewPartidasRequisiciones.Columns["Proveedor_requisicion"].ReadOnly = true;
        }

        private bool Actualiza_datos_requisicion()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_compras());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_modificar_en_base_de_datos_requisiciones(), connection);
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

        private string Configura_cadena_comando_modificar_en_base_de_datos_requisiciones()
        {
            return "UPDATE requisiciones set  requisitor_requisicion='" + comboBoxRequsitor.Text +
              "',diriguido_requisicion='" + comboBoxDirigido.Text +
              "',fecha_requisicion='" + dateTimePickerFechaActual.Text +
              "',proveedor_asignado='" + "Asignado" +
              "' where codigo_requisicion='" + comboBoxCodigoRequisiciones.Text + "';";
        }

        private bool Actulaiza_datos_partidas_requisiciones()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_compras());
            try
            {
                connection.Open();
                for (int partidas = 0; partidas < dataGridViewPartidasRequisiciones.Rows.Count; partidas++)
                {
                    for (int campo = 0; campo < dataGridViewPartidasRequisiciones.Rows[partidas].Cells.Count; campo++)
                    {
                        if (!dataGridViewPartidasRequisiciones.Rows[partidas].Cells[campo].ReadOnly ||
                            (dataGridViewPartidasRequisiciones.Rows[partidas].Cells[campo].ReadOnly && campo == (int)Campos_partidas.partida))
                        {
                            if (dataGridViewPartidasRequisiciones.Rows[partidas].Cells[campo].Value != null)
                            {
                                if (dataGridViewPartidasRequisiciones.Rows[partidas].Cells[campo].Value.ToString() != "")
                                {
                                    if (campo == (int)Campos_partidas.partida)
                                        partida_requisicion_agregar.Partida = dataGridViewPartidasRequisiciones.Rows[partidas].Cells[campo].Value.ToString();
                                    else if (campo == (int)Campos_partidas.cantidad)
                                        partida_requisicion_agregar.Cantidad = dataGridViewPartidasRequisiciones.Rows[partidas].Cells[campo].Value.ToString();
                                    else if (campo == (int)Campos_partidas.descripcion)
                                        partida_requisicion_agregar.Descripcion = dataGridViewPartidasRequisiciones.Rows[partidas].Cells[campo].Value.ToString();
                                    else if (campo == (int)Campos_partidas.uidad_medida)
                                        partida_requisicion_agregar.Unidad_medida = dataGridViewPartidasRequisiciones.Rows[partidas].Cells[campo].Value.ToString();
                                    else if (campo == (int)Campos_partidas.proyecto)
                                        partida_requisicion_agregar.Proyecto = dataGridViewPartidasRequisiciones.Rows[partidas].Cells[campo].Value.ToString();
                                    else if (campo == (int)Campos_partidas.proveedor)
                                        partida_requisicion_agregar.Proveedor = dataGridViewPartidasRequisiciones.Rows[partidas].Cells[campo].Value.ToString();
                                    else if (campo == (int)Campos_partidas.codigo)
                                        partida_requisicion_agregar.Codigo = Convert.ToInt32(dataGridViewPartidasRequisiciones.Rows[partidas].Cells[campo].Value);
                                    else if (campo == (int)Campos_partidas.numero)
                                        partida_requisicion_agregar.Numero = dataGridViewPartidasRequisiciones.Rows[partidas].Cells[campo].Value.ToString();
                                }
                                else
                                {
                                    MessageBox.Show("campo en blanco");
                                    connection.Close();
                                    return false;
                                }

                            }

                            else
                            {
                                MessageBox.Show("campo en blanco");
                                connection.Close();
                                return false;
                            }
                        }
                    }
                    partida_requisicion_agregar.Codigo_requisicion = textBoxCodigoRequisiciones.Text;
                    MySqlCommand command = new MySqlCommand(Configura_cadena_comando_actualiza_en_base_de_datos_partidas_requisiciones(partida_requisicion_agregar), connection);
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

        private string Configura_cadena_comando_actualiza_en_base_de_datos_partidas_requisiciones(Partida_requisicion partida_requisicion_actualizar)
        {
            return "UPDATE partidas_requisiciones set  proveedor_requisicion='" + partida_requisicion_actualizar.Proveedor +
                 "',partida_requisicion='" + partida_requisicion_actualizar.Partida +
                "',cantidad_requisicion='" + partida_requisicion_actualizar.Cantidad +
                "',descripcion_requisicion='" + partida_requisicion_actualizar.Descripcion +
                "',unidad_medida='" + partida_requisicion_actualizar.Unidad_medida +
                "',proyecto_requisicion='" + partida_requisicion_actualizar.Proyecto +
                "',numero_parte='" + partida_requisicion_actualizar.Numero +
                "' where codigo_partida='" + partida_requisicion_actualizar.Codigo + "';";
        }

        private void Secuencia_agregar_partidas_requisiciones()
        {
            if (Guarda_datos_partidas_requisiciones())
            {
                if (Guarda_datos_requisicion())
                {
                    Limpia_cajas_captura_despues_de_agregar_cotizacion();
                    Limpia_combo_codigo_requisicion();
                    Limpia_combo_requisitor();
                    Limpia_combo_dirigido();
                    Desactiva_cajas_captura_despues_de_agregar_cotizacion();
                    Desaparece_boton_guardar_base_de_datos();
                    Desaparece_boton_cancelar();
                    Desaparece_combo_codigo_requisicion();
                    Activa_botones_operacion();
                    limpia_partidas_requisicion();
                    Desactiva_datagridview_partidas();
                    Desaparece_combo_requisitor();
                    Desactiva_combo_requisitor();
                    Desaparece_combo_dirigido();
                    Desactiva_combo_dirigido();
                    Aparece_textbox_requisitor();
                    Aparece_textbox_dirigido();
                    Asigna_nuevo_folio_requisiciones();
                    Elimina_informacion_requisiciones_disponibles();
                }
            }
        }

        private bool Guarda_datos_requisicion()
        {
            
                MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_compras());
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
                return "INSERT INTO requisiciones(codigo_requisicion, requisitor_requisicion,diriguido_requisicion," +
                    "fecha_requisicion,proveedor_asignado) " +
                    "VALUES('" + textBoxCodigoRequisiciones.Text + "','" + comboBoxRequsitor.Text + "'," +
                    "'" + comboBoxDirigido.Text + "','" + dateTimePickerFechaActual.Text + "'," +
                    "'" + "No_asignado" +"');";
        }
   
        private bool Guarda_datos_partidas_requisiciones()
        {
                MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_compras());
                try
                {
                    connection.Open();
                    for (int partidas = 0; partidas < dataGridViewPartidasRequisiciones.Rows.Count - 1; partidas++)
                    {
                    for (int campo = 1; campo < dataGridViewPartidasRequisiciones.Rows[partidas].Cells.Count; campo++)
                    {
                        if (!dataGridViewPartidasRequisiciones.Rows[partidas].Cells[campo].ReadOnly || 
                            (dataGridViewPartidasRequisiciones.Rows[partidas].Cells[campo].ReadOnly && campo == (int)Campos_partidas.partida))
                        {
                            if (dataGridViewPartidasRequisiciones.Rows[partidas].Cells[campo].Value != null)
                            {
                                if (campo == (int)Campos_partidas.partida)
                                    partida_requisicion_agregar.Partida = dataGridViewPartidasRequisiciones.Rows[partidas].Cells[campo].Value.ToString();
                                else if (campo == (int)Campos_partidas.cantidad)
                                    partida_requisicion_agregar.Cantidad = dataGridViewPartidasRequisiciones.Rows[partidas].Cells[campo].Value.ToString();
                                else if (campo == (int)Campos_partidas.descripcion)
                                    partida_requisicion_agregar.Descripcion = dataGridViewPartidasRequisiciones.Rows[partidas].Cells[campo].Value.ToString();
                                else if (campo == (int)Campos_partidas.uidad_medida)
                                    partida_requisicion_agregar.Unidad_medida = dataGridViewPartidasRequisiciones.Rows[partidas].Cells[campo].Value.ToString();
                                else if (campo == (int)Campos_partidas.proyecto)
                                    partida_requisicion_agregar.Proyecto = dataGridViewPartidasRequisiciones.Rows[partidas].Cells[campo].Value.ToString();
                                else if (campo == (int)Campos_partidas.proveedor)
                                    partida_requisicion_agregar.Proveedor = dataGridViewPartidasRequisiciones.Rows[partidas].Cells[campo].Value.ToString();
                                else if (campo == (int)Campos_partidas.numero)
                                    partida_requisicion_agregar.Numero = dataGridViewPartidasRequisiciones.Rows[partidas].Cells[campo].Value.ToString();
                            }

                            else
                            {
                                MessageBox.Show("campo en blanco");
                                connection.Close();
                                return false;
                            }
                        }
                    }
                    partida_requisicion_agregar.Codigo_requisicion = textBoxCodigoRequisiciones.Text;
                    MySqlCommand command = new MySqlCommand(Configura_cadena_comando_insertar_en_base_de_datos_partidas_requisiciones(partida_requisicion_agregar), connection);
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
            throw new NotImplementedException();
        }

        private void Aparce_caja_codigo_cliente()
        {
            textBoxCodigoRequisiciones.Visible = true;
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

       

        private void Aparece_textbox_dirigido()
        {
            textBoxDirigido.Visible = true;
        }

        private void Aparece_textbox_requisitor()
        {
            textBoxRequsitor.Visible = true;
        }


        private void Desactiva_combo_dirigido()
        {
            comboBoxDirigido.Enabled = false;
        }

        private void Desaparece_combo_dirigido()
        {
            comboBoxDirigido.Visible = false;
        }

        private void Desactiva_combo_requisitor()
        {
            comboBoxRequsitor.Enabled = false;
        }

        private void Desaparece_combo_requisitor()
        {
            comboBoxRequsitor.Visible = false;
        }


        private void Asigna_nuevo_folio_requisiciones()
        {
            int numero_folio = Convert.ToInt32(folio_disponible.Folio_requisiciones.Substring(2, folio_disponible.Folio_requisiciones.Length - 2));
            numero_folio++;
            folio_disponible.Folio_requisiciones = folio_disponible.Folio_requisiciones.Substring(0, 2) +numero_folio.ToString();
            string respuesta = class_folio_disponible.Actualiza_Control_folios_base_datos(folio_disponible);
            if (respuesta != "")
                MessageBox.Show(folio_disponible.error);
        }

        private void Desactiva_datagridview_partidas()
        {
            dataGridViewPartidasRequisiciones.Enabled = false;
        }

        private void Elimina_informacion_requisiciones_disponibles()
        {
            Partidas_requisicion_disponibles = null;
            Proveedores_disponibles = null;
            requisiciones_disponibles = null;
            Usuarios_administrativos = null;
            Usuarios_requisitores = null;

            GC.Collect();
        }

        private void Activa_botones_operacion()
        {
            Activa_boton_agregar_ccotizacion();
            Activa_boton_visualizar_cotizacion();
            Activa_boton_modoficar_proveedor();
        }

        private void Activa_boton_modoficar_proveedor()
        {
            buttonModificarRequisicion.Enabled = true;
        }

        private void Activa_boton_visualizar_cotizacion()
        {
            buttonBuscarRequisicion.Enabled = true;
        }

        private void Activa_boton_agregar_ccotizacion()
        {
            buttonAgregarCotizacion.Enabled = true;
        }

        private void Desaparece_combo_codigo_requisicion()
        {
            comboBoxCodigoRequisiciones.Visible = false;
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
            dateTimePickerFechaActual.Enabled = false;
            textBoxRequsitor.Enabled = false;
            textBoxDirigido.Enabled = false;
        }

        private void Limpia_combo_codigo_requisicion()
        {
            comboBoxCodigoRequisiciones.Items.Clear();
            comboBoxCodigoRequisiciones.Text = "";
        }

        private void Limpia_cajas_captura_despues_de_agregar_cotizacion()
        {
            textBoxCodigoRequisiciones.Text = "";
            dateTimePickerFechaActual.Text = DateTime.Today.ToString();
            textBoxRequsitor.Text = "";
            textBoxDirigido.Text = "";
        }

        private string Configura_cadena_comando_insertar_en_base_de_datos_partidas_requisiciones(
            Partida_requisicion partida_requisicion)
        {
            return "INSERT INTO partidas_requisiciones(codigo_requisicion, partida_requisicion,cantidad_requisicion," +
                "descripcion_requisicion,unidad_medida,proyecto_requisicion,proveedor_requisicion,numero_parte," +
                "orden_compra_asignada) " +"VALUES('" + partida_requisicion.Codigo_requisicion + "','" 
                + partida_requisicion.Partida + "'," + "'" + partida_requisicion.Cantidad + "','" + 
                partida_requisicion.Descripcion + "'" +",'" + partida_requisicion.Unidad_medida + "','" + 
                partida_requisicion.Proyecto + "'," +"'" + partida_requisicion.Proveedor + "','" + 
                partida_requisicion.Numero + "'," +"'No_Asignada'"+");";
        }


        private string Configura_cadena_conexion_MySQL_compras()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=compras;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }


        private void buttonModificarCliente_Click(object sender, EventArgs e)
        {
            Modifica_clientes();
        }

        private void Modifica_clientes()
        {
            Desactiva_botones_operacion();
            Desaparece_caja_captura_codigo_requisciciones();
            Aparece_combo_codigo_cotizacion();
            Aparece_boton_cancelar_operacio();
            No_aceptar_agregar_contactos_requisiciones();
            Activa_dataview_partidas_requisiciones();

            Operacio_requisiciones = "Modificar";
        }

        private void buttonEliminarCliente_Click(object sender, EventArgs e)
        {
            Desactiva_botones_operacion();
            Desaparece_caja_captura_codigo_requisciciones();
            Aparece_combo_codigo_cotizacion();
            Aparece_boton_cancelar_operacio();
            Operacio_requisiciones = "Eliminar";
        }

        private bool Elimina_informacion_clienete_en_base_de_datos()
        {
            return (Elimina_datos_cotizacion() && Elinina_partidas_cotizacion());
        }

        private bool Elinina_partidas_cotizacion()
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
            return "DELETE from partidas_cotizaciones where codigo_cotizacion='" +
               comboBoxCodigoRequisiciones.Text + "';";
        }


        private bool Elimina_datos_cotizacion()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_compras());
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
               comboBoxCodigoRequisiciones.Text + "';";
        }

        private void timerModificarClientes_Tick(object sender, EventArgs e)
        {

        }

        private void buttonAgregaContactosCliente_Click(object sender, EventArgs e)
        {
            Agrega_contactos_clientes();
        }

        private void Agrega_contactos_clientes()
        {
            limpia_partidas_requisicion();
            Acepta_datagridview_agregar_renglones();
            Aparce_boton_guardar_base_datos();
            Operacio_requisiciones = "Agregar Partidas";

        }

        private void buttonBorrarBasedeDatos_Click(object sender, EventArgs e)
        {

            if (Operacio_requisiciones == "Eliminar partida")
                Elimina_partida_cotizacion();
            else if (Operacio_requisiciones == "Eliminar")
                Elimina_cotizacion();
        }

        private void Elimina_partida_cotizacion()
        {
            if (MessageBox.Show("Esta Seguro de Eiliminar el contacto seleccionado?",
                "Eliminar Contacto Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Elimina_informacion_partida_cotizacion_en_base_de_datos())
                {
                    limpia_partidas_requisicion();
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
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_compras());
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
                    Limpia_combo_codigo_requisicion();
                    Desactiva_cajas_captura_despues_de_agregar_cotizacion();
                    Desaparece_boton_cancelar();
                    Desaparece_combo_codigo_requisicion();
                    Activa_botones_operacion();
                    limpia_partidas_requisicion();
                    Desactiva_datagridview_partidas();
                    Elimina_informacion_requisiciones_disponibles();
                    Aparce_caja_codigo_cliente();
                }
            }
        }

        private void buttonEliminarContacto_Click(object sender, EventArgs e)
        {
            Elimina_Contacto_cliente();
        }

        private void Elimina_Contacto_cliente()
        {
            No_aceptar_agregar_contactos_requisiciones();
            Operacio_requisiciones = "Eliminar partida";
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
            Desaparece_caja_captura_codigo_requisciciones();
            Aparece_combo_codigo_cotizacion();
            Aparece_boton_cancelar_operacio();
            No_aceptar_agregar_contactos_requisiciones();
            Activa_dataview_partidas_requisiciones();
            Operacio_requisiciones = "Operaciones Patidas";
        }

        private void dataGridViewContactosClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Operacio_requisiciones == "Eliminar partida")
            {
                RenglonParaEliminar=dataGridViewPartidasRequisiciones.Rows[e.RowIndex].Cells["Codigo_partida"].Value.ToString();
            }
           
        }

        private void dataGridViewPartidasCotizacion_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Operacio_requisiciones == "Agregar")/*verifica si esta agregando Partidas*/
            {
                if (dataGridViewPartidasRequisiciones.CurrentCell.ColumnIndex == (int)Campos_partidas.partida) /*verifica si esta modificando el precio*/
                {
                    try
                    {
                        /*Valida Numeros en la caja de horas estimadas*/
                        Convert.ToSingle(dataGridViewPartidasRequisiciones[e.ColumnIndex, e.RowIndex].Value.ToString());
                        

                    }
                    catch
                    {
                        /* en caso de error limpia la caja de precio*/
                        dataGridViewPartidasRequisiciones[(int)Campos_partidas.partida, e.RowIndex].Value = "";
                    }

                }
                else if (dataGridViewPartidasRequisiciones.CurrentCell.ColumnIndex == (int)Campos_partidas.cantidad)
                {
                    try
                    {
                        /*Valida Numeros en la caja cantidad*/
                        Convert.ToSingle(dataGridViewPartidasRequisiciones[e.ColumnIndex, e.RowIndex].Value.ToString());
                        dataGridViewPartidasRequisiciones[(int)Campos_partidas.partida, e.RowIndex].Value = e.RowIndex + 1;

                    }
                    catch
                    {
                        /* en caso de error limpia la cantidad*/
                        dataGridViewPartidasRequisiciones[(int)Campos_partidas.cantidad, e.RowIndex].Value = "";
                    }

                }
            }
        }

        private void comboBoxNombreCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Desaparece_textbox_atencion();
            Limpia_combo_requisitor();
            Limpia_combo_dirigido();
            Aparecer_combo_atencion();
            Activa_combo_requisitor();
            Desaparece_textbox_atencio_copia();
            Aparece_combo_copia_atencio();
            Activa_Combo_dirigido();
        }

        private void Activa_Combo_dirigido()
        {
            comboBoxDirigido.Enabled = true;
        }

        private void Aparece_combo_copia_atencio()
        {
            comboBoxDirigido.Visible = true;
        }

        private void Desaparece_textbox_atencio_copia()
        {
            textBoxDirigido.Visible = false;
        }

        private void buttonCopiarCotizacion_Click(object sender, EventArgs e)
        {
            Copiar_cotizacion();
        }

        private void Copiar_cotizacion()
        {
            Desactiva_botones_operacion();
            Desaparece_caja_captura_codigo_requisciciones();
            Aparece_combo_codigo_cotizacion();
            Aparece_boton_cancelar_operacio();
            No_aceptar_agregar_contactos_requisiciones();
            Activa_dataview_partidas_requisiciones();
            Operacio_requisiciones = "Copiar";
        }

        private void buttonWordPrevio_Click(object sender, EventArgs e)
        {
            if (Inicia_variables_word())
            {
                Desactiva_boton_requisiciones_previo();
                Desactiva_boton_guardar();
                Desactiva_combo_provedores_previo();
                Asigna_nombre_archivo_para_analizar();
                Elimina_archivo();
                Copiar_template_requisicion();
                Abrir_documento_word();
                Rellenar_campos_requisicion();
                Guardar_archivo_word();
                Visible_instancia_word();

            }
            
        }

        private void Desactiva_boton_guardar()
        {
            buttonSaveFile.Enabled = false;
        }

        private void Desactiva_combo_provedores_previo()
        {
            comboBoxProveedoresPrevio.Enabled = false;
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
            nombre_archivo_word = @appPath + "\\" + comboBoxCodigoRequisiciones.Text +"_" +
                comboBoxProveedoresPrevio.Text + ".docx";
        }

        private void Desactiva_boton_requisiciones_previo()
        {
            buttonWordPrevio.Enabled = false;
        }

        private void Visible_instancia_word()
        {
            application.Visible = true;
           
        }

        private void Copiar_template_requisicion()
        {
            try
            {
                File.Copy(@appPath + "\\Requisicion_Coset_template.docx", @appPath + "\\" + comboBoxCodigoRequisiciones.Text + 
                    "_"+ comboBoxProveedoresPrevio.Text +".docx", false);
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

        private void Rellenar_campos_requisicion()
        {
            Rellena_informacion_requisicion();
            Rellena_partidas_Requisicion();
            Limpia_partidas_sin_informacion();
        }

        private void Rellena_informacion_requisicion()
        {
            Remplaza_texto_en_Documento("<REQN>", comboBoxCodigoRequisiciones.Text);
            Remplaza_texto_en_Documento("<realizador>", textBoxDirigido.Text);
            Remplaza_texto_en_Documento("<requisitor>", textBoxRequsitor.Text);
            Remplaza_texto_en_Documento("<dirigido>", comboBoxProveedoresPrevio.Text);
            Remplaza_texto_en_Documento("<fecha>", dateTimePickerFechaActual.Text);
        }

        private void Rellena_partidas_Requisicion()
        {
            if (dataGridViewPartidasRequisiciones.Rows.Count <= 16)
            {
                for (int partida = 1; partida <= dataGridViewPartidasRequisiciones.Rows.Count; partida++)
                {
                    if (comboBoxProveedoresPrevio.Text == dataGridViewPartidasRequisiciones.Rows[partida - 1].
                        Cells["Proveedor_requisicion"].Value.ToString())
                    {
                        Remplaza_texto_en_Documento("<n" + partida + ">",
                            dataGridViewPartidasRequisiciones[(int)Campos_partidas.partida, partida - 1].Value.ToString());
                        Remplaza_texto_en_Documento("<c" + partida + ">",
                            dataGridViewPartidasRequisiciones[(int)Campos_partidas.cantidad, partida - 1].Value.ToString());
                        Remplaza_texto_en_Documento("<np" + partida + ">",
                            dataGridViewPartidasRequisiciones[(int)Campos_partidas.numero, partida - 1].Value.ToString());
                        Remplaza_texto_en_Documento("<d" + partida + ">",
                            dataGridViewPartidasRequisiciones[(int)Campos_partidas.descripcion, partida - 1].Value.ToString());
                        Remplaza_texto_en_Documento("<m" + partida + ">",
                            dataGridViewPartidasRequisiciones[(int)Campos_partidas.uidad_medida, partida - 1].Value.ToString());
                        Remplaza_texto_en_Documento("<p" + partida + ">",
                            dataGridViewPartidasRequisiciones[(int)Campos_partidas.proyecto, partida - 1].Value.ToString());
                        Numero_renglones_rellenos_requisicion++;
                    }
                                     
                }
            }
            else
            {
                MessageBox.Show("Esta Applicacion solo Puede desplegar Hasta 16 Partidas", "Previo Requisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            Asigna_espacios_en_renglones_sin_informacion();
            word.Table table = Documento.Tables[2];
            for (int renglon = 1; renglon <= table.Rows.Count; renglon++)
            {
                if (table.Rows[renglon].Cells[1].Range.Text == "\r\a")
                {
                    table.Rows[renglon].Delete();
                    renglon--;
                }

            }
        }

        private void Asigna_espacios_en_renglones_sin_informacion()
        {
            for(int renglon =1; renglon<=16; renglon++)
            {
                Remplaza_texto_en_Documento("<n" + renglon + ">", "");
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
                File.Copy(@appPath + "\\Quote_Coset_Template_Ingles.docx", @appPath + "\\" + comboBoxCodigoRequisiciones.Text + ".docx", false);
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

        private void timerAgregarRequisicion_Tick(object sender, EventArgs e)
        {
            if (textBoxCodigoRequisiciones.Text != "" &&
            comboBoxRequsitor.Text != "" &&
            comboBoxDirigido.Text != "")

            {
                timerAgregarRequisicion.Enabled = false;
                buttonGuardarBasedeDatos.Visible = true;
            }
        }

        private void buttonModificarRequisicion_Click(object sender, EventArgs e)
        {
            Modificar_requisicion_asignar_proveedor();
        }

        private void Modificar_requisicion_asignar_proveedor()
        {
            Desactiva_botones_operacion();
            Limpia_combo_dirigido();
            Limpia_combo_requisitor();
            Limpia_combo_requisiciones();
            Limpia_combo_proyectos_partidas();
            Desactiva_botones_operacion();
            Activa_cajas_informacion_requisiciones();
            Acepta_datagridview_agregar_renglones();
            Aparece_combo_codigo_requisiciones();
            Aparece_combo_requisitor();
            Activa_combo_requisitor();
            Activa_Combo_dirigido();
            Activa_combo_codigo_requisiciones();
            Aparece_combo_dirigido();
            Obtener_datos_usuarios_administrativos_compas_disponibles_base_datos();
            rellena_combo_dirigido();
            Obtener_datos_usuarios_requisitores_disponibles_base_datos();
            rellena_combo_requisitores();
            obtener_proyectos_disponibles();
            Rellenar_combo_proyectos_partidas_requisiciones();
            Obtener_datos_requisiciones_disponibles_base_datos();
            Rellena_combo_codigo_requisiciones();
            Aparece_boton_cancelar_operacio();
            No_aceptar_agregar_contactos_requisiciones();
            Activa_dataview_partidas_requisiciones();
            Activa_columna_proveedores_ser_mododificada();

            Operacio_requisiciones = "Modificar";
        }

        private void Activa_caja_dirigida()
        {
            textBoxDirigido.Enabled = true;
        }

        private void Activa_caja_requisitor()
        {
            textBoxRequsitor.Enabled = true;
        }

        private void Activa_columna_proveedores_ser_mododificada()
        {
            dataGridViewPartidasRequisiciones.Columns["Proveedor_requisicion"].ReadOnly = false;
        }

        private void Rellena_combo_codigo_requisiciones()
        {
            foreach (Requisicion requisicion in requisiciones_disponibles)
            {
                if (requisicion.error == "")
                    comboBoxCodigoRequisiciones.Items.Add(requisicion.Codigo);
                else
                {
                    MessageBox.Show(requisicion.error);
                    break;
                }
            }
        }

        private void Obtener_datos_requisiciones_disponibles_base_datos()
        {
            requisiciones_disponibles = class_Requisiciones.Adquiere_requisiciones_disponibles_en_base_datos();
        }

        private void Activa_combo_requisiciones()
        {
            comboBoxCodigoRequisiciones.Enabled = true;
        }

        private void Aparece_combo_codigo_requisiciones()
        {
            comboBoxCodigoRequisiciones.Visible = true;
        }

        private void Limpia_combo_requisiciones()
        {
            comboBoxCodigoRequisiciones.Items.Clear();
            comboBoxCodigoRequisiciones.Text = "";
        }

        private void comboBoxProveedoresPrevio_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonWordPrevio.Enabled = true;
            buttonSaveFile.Enabled = true;
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            if (Inicia_variables_word())
            {
                Desactiva_boton_requisiciones_previo();
                Desactiva_boton_guardar();
                Desactiva_combo_provedores_previo();
                Asigna_nombre_archivo_para_analizar();
                Elimina_archivo();
                Copiar_template_requisicion();
                Abrir_documento_word();
                Rellenar_campos_requisicion();
                Guardar_archivo_word_en_ruta_en_datos_generales();
            }
        }

        private void Guardar_archivo_word_en_ruta_en_datos_generales()
        {
            string nombre_archivo = "";
            datos_generales = Class_Datos_Generales.Obtener_informacion_datos_generales_base_datos();
            nombre_archivo = "@" + datos_generales.folder_requisiciones + @"\" + comboBoxCodigoRequisiciones.Text + "_" +
                comboBoxProveedoresPrevio.Text + ".docx";
            if (!Directory.Exists(datos_generales.folder_requisiciones))
            {
                Directory.CreateDirectory(datos_generales.folder_requisiciones);
            }
        }
    }
}
