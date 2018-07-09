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
        public Class_Proyectos Class_Proyectos = new Class_Proyectos();
        public Proyecto proyecto_visualizar = new Proyecto();
        public Dibujos_proyecto dibujos_proyecto_modificar = new Dibujos_proyecto();
        public Class_Procesos Class_Procesos = new Class_Procesos();
        public List<Proceso> procesos_disponibles = new List<Proceso>();
        public enum Campos_dibujos
        {
            codigo, cantidad, numero, descripcion,
            proceso, tiempo_estimado
        };

        public string Operacio_proyectos = "";

        public Forma_Reporte_Proyectos()
        {
            InitializeComponent();
        }

        private void Forma_Clientes_Load(object sender, EventArgs e)
        {
            //Desactiva_columna_codigo_partidas_cotizaciones();
            //Rellena_combo_procesos_datagridview_dibujos();
            Obtener_datos_proyectos_disponibles_base_datos();
            Rellena_combo_codigo_proyecto();
            Habilita_combo_para_aceptar_buscar_elemento_escribiendo_en_ventana();

        }

        private void Habilita_combo_para_aceptar_buscar_elemento_escribiendo_en_ventana()
        {
            comboBoxCodigoProyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBoxCodigoProyecto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCodigoProyecto.AutoCompleteSource = AutoCompleteSource.ListItems;
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
            Desaparece_caja_captura_codigo_proyecto();
            Aparece_combo_codigo_proyecto();
            Activa_combo_codigo_proyecto();
            Obtener_datos_proyectos_disponibles_base_datos();
            Rellena_combo_codigo_proyecto();
            Aparece_boton_cancelar_operacio();
            No_aceptar_agregar_dibujos_proyecto();
            Activa_dataview_dibujos_proyecto();
            Operacio_proyectos = "Visualizar";
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
            
        }

        private void Desaparece_caja_captura_codigo_proyecto()
        {
            textBoxCodigoProyecto.Visible = false;
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Operacio_proyectos = "Cancelar";
            
            Limpia_cajas_captura_despues_de_agregar_proyecto();
            
            Desaparece_boton_guardar_base_de_datos();
 
            Aparece_textbox_codigo_proyecto();
            Aparece_textbox_ingeniero_cliente();
            Aparece_textbox_ingeniero_coset();
            Aparece_textbox_nombre_cliente();
            limpia_dibujos_proyecto();
            Desactiva_datagridview_dibujos();
            Acepta_datagridview_agregar_renglones();  
            Elimina_informacion_proyectos_disponibles();
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

      

        private void configura_forma_copiar()
        {
            limpia_dibujos_proyecto();
            Rellena_cajas_informacion_de_proyectos();
            Obtener_datos_partidas_cotizacion_disponibles_base_datos(comboBoxCodigoProyecto.Text);
            Rellena_cajas_informacion_de_dibujos_proyecto();
            Aparce_boton_guardar_base_datos();
        }

        private void configura_forma_agregar()
        {
            Desactiva_combobox_codigo_proyecto();
            Desaparece_textbox_nombre_cliente();
            Obtener_clientes_disponibles();
        }

       

        private void Obtener_clientes_disponibles()
        {
            clientes_disponibles = clase_clientes.Adquiere_clientes_disponibles_en_base_datos();
        }

        private void Desaparece_textbox_nombre_cliente()
        {
            textBoxNombreCliente.Visible = false;
        }


        private void configura_forma_visualizar()
        {
            limpia_dibujos_proyecto();
            Rellena_cajas_informacion_de_proyectos();
            Obtener_datos_dibujos_proyectos_disponibles_base_datos(comboBoxCodigoProyecto.Text);
            Rellena_cajas_informacion_de_dibujos_proyecto();
        }

        private void Obtener_datos_dibujos_proyectos_disponibles_base_datos(string codigo_proyecto)
        {
            dibujos_proyecto_disponibles = clase_dibujos_proyecto.Adquiere_dibujos_proyecto_disponibles_en_base_datos(comboBoxCodigoProyecto.Text);
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

        private void Rellena_cajas_informacion_de_proyectos()
        {
            proyecto_visualizar = proyectos_disponibles.Find(proyecto => proyecto.Codigo.Contains(comboBoxCodigoProyecto.SelectedItem.ToString()));
            textBoxNombreCliente.Text = proyecto_visualizar.Nombre_cliente;
            textBoxIngenieroCoset.Text = proyecto_visualizar.Ingeniero_coset;;
            textBoxIngenieroCliente.Text = proyecto_visualizar.Ingeriero_cliente;
            textBoxCodigoCliente.Text = proyecto_visualizar.Codigo_cliente;
            textBoxNombreProyecto.Text = proyecto_visualizar.Nombre;
            
        }

      

        private void configura_forma_eliminar()
        {
            limpia_dibujos_proyecto();
            Rellena_cajas_informacion_de_proyectos();
            Obtener_datos_dibujos_proyectos_disponibles_base_datos(comboBoxCodigoProyecto.Text);
            Rellena_cajas_informacion_de_dibujos_proyecto();
            Aparece_boton_eliminar_datos_en_base_de_datos();
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
            Asigna_nuevo_folio_proyecto();
           
            Activa_cajas_informacion_proyecto();
            No_aceptar_agregar_dibujos_proyecto();
            Acepta_datagridview_agregar_renglones();
            Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_proyecto();
            Aparece_boton_cancelar_operacio();
            Activa_datagridview_dibujos_proyecto();

            Desaparece_textbox_nombre_cliente();
            
            Obtener_clientes_disponibles();
            
            Aparece_combo_codigo_cotizacion();
            Activa_combo_codigo_cotizacion();
            Obtener_datos_cotizaciones_disponibles_base_datos();
            Rellena_combo_codigo_cotizacion();

            
            
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
           
        }

        private void Modifica_contactos_cliente()
        {
            throw new NotImplementedException();
        }



        private void timerAgregarCliente_Tick(object sender, EventArgs e)
        {
            
        }


        private void Aparce_caja_codigo_cliente()
        {
            textBoxCodigoProyecto.Visible = true;
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

        

        private void Aparece_textbox_atencion_copia()
        {
            textBoxIngenieroCoset.Visible = true;
        }


        private void Aparece_textbox_nombre_cliente()
        {
            textBoxNombreCliente.Visible = true;
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
           

        }

        private string Configura_cadena_comando_insertar_en_base_de_datos_dibujos_proyecto(Dibujos_proyecto partida_cotizacion)
        {
            return "INSERT INTO dibujos_proyecto(cantidad_dibujos, numero_dibujo,descripcion_dibujo," +
                "proceso,tiempo_estimado_horas,codigo_proyecto) " +
                "VALUES('" + partida_cotizacion.Cantidad + "','" + partida_cotizacion.Numero + "'," +
                "'" + partida_cotizacion.Descripcion + "','" + partida_cotizacion.proceso + "'" +
                ",'" + partida_cotizacion.tiempo_estimado_horas + "','" + partida_cotizacion.Codigo_proyecto +"');";
        }

       


       

        private string Configura_cadena_conexion_MySQL_ingenieria()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=ingenieria;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
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

       

        private void Desaparece_boton_eliminar_base_de_datos()
        {
            buttonBorrarBasedeDatos.Visible = false;
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

      


        private void Obtener_ingenieros_coset_disponibles()
        {
            ingenieros_disponibles = clase_usuarios.Adquiere_ingenieros_disponibles_en_base_datos();
        }

        
        private void Desaparece_textbox_ingeniero_coset()
        {
            textBoxIngenieroCoset.Visible = false;
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
            foreach(Proceso proceso in procesos_disponibles)
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

        private void comboBoxCodigoProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rellena_cajas_informacion_de_proyectos();
        }
    }
}
