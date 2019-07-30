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

namespace Coset_Sistema_Produccion
{
    public partial class Forma_Actividades_Procesos_Electricos : Form
    {
        public List<Proceso_electrico> procesos_disponibles = new List<Proceso_electrico>();
        public Class_Procesos_Electrico clase_procesos_electrico = new Class_Procesos_Electrico();
        public Proceso_electrico Proceso_Modificaciones = new Proceso_electrico();
        public Proceso_electrico Proceso_agregar = new Proceso_electrico();
        public Class_Control_Folios class_folio_disponible = new Class_Control_Folios();
        public Class_Actividades_Proceso_Electrico Class_Actividades_Proceso_Electrico = new Class_Actividades_Proceso_Electrico();
        public List<Actividad_Proceso_Electrico> actividad_Proceso_Electricos_disponibles = new List<Actividad_Proceso_Electrico>();
        public Actividad_Proceso_Electrico Actividad_Proceso_Electrico_modificaciones = new Actividad_Proceso_Electrico();
        public Actividad_Proceso_Electrico Actividad_Proceso_Electrico_visualizar = new Actividad_Proceso_Electrico();
        public Actividad_Proceso_Electrico Actividad_Proceso_Electrico_eliminar = new Actividad_Proceso_Electrico();
        public Control_folio folio_disponible = new Control_folio();
        public string Operacio_actividades_procesos = "";
        public Forma_Actividades_Procesos_Electricos()
        {
            InitializeComponent();
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            Regresar_forma_principal();
        }

        private void Regresar_forma_principal()
        {
            procesos_disponibles = null;
            clase_procesos_electrico = null;
            class_folio_disponible = null;
            Proceso_Modificaciones = null;
            this.Dispose();
            GC.Collect();
            this.Close();
        }

        private void buttonAgregarUsuario_Click(object sender, EventArgs e)
        {
            Agrega_proceso();
        }

        private void Agrega_proceso()
        {
            //Asigna_codigo_proceso_foilio_disponible();
            //Asigna_nuevo_folio_proceso();
            Buscar_todos_procesos_electricos_disponibles();
            Rellenar_combo_nombre_proceso();
            Desactiva_botones_operacion();
            Aparece_combo_nombre_proceso();
            Activa_combo_nombre_proceso();
            //Aparece_caja_codigo_proceso();
            //Desaparece_combo_nombre_proceso();
            //Activa_cajas_informacion();
            Inicia_timer_para_asegurar_informacion_en_todos_los_campos();
            Activa_boton_cancelar_operacio();
            Operacio_actividades_procesos = "Agregar";
        }

        private void Buscar_todos_procesos_electricos_disponibles()
        {
            procesos_disponibles = clase_procesos_electrico.Adquiere_procesos_disponibles_en_base_datos();
        }

        private void Asigna_codigo_proceso_foilio_disponible()
        {
            folio_disponible = class_folio_disponible.Obtener_informacion_control_folio_base_datos();
            textBoxCodigoProceso.Text = folio_disponible.Folio_procesos_electricos;
        }

        private void Aparece_caja_codigo_proceso()
        {
            textBoxCodigoProceso.Visible = true;
        }

        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos()
        {
            timerAgregarProceso.Enabled = true;
        }

        private void Activa_boton_guardar_base_de_datos()
        {
            buttonGuardarBasedeDatos.Visible = true;
        }

       
        private void Activa_caja_notas_actividad()
        {
            textBoxNotasActividad.Enabled = true;
        }

        private void Activa_caja_actividad_proceso()
        {
            textBoxActividadProcesoElectrico.Enabled = true;
        }

        private void Desactiva_botones_operacion()
        {
            Desactiva_boton_agregar_proceso();
            Desactiva_boton_modificar_proceso();
            Desactiva_boton_eliminar_proceso();
            Desactiva_boton_visualizar_proceso();
        }

        private void Desactiva_boton_visualizar_proceso()
        {
            buttonBuscarProceso.Enabled = false;
        }

        private void Activa_cajas_informacion()
        {
            Activa_caja_actividad_proceso();
            Activa_caja_notas_actividad();
        }

        private void Desactiva_boton_eliminar_proceso()
        {
            buttonEliminarProceso.Enabled = false;
        }

        private void Desactiva_boton_modificar_proceso()
        {
            buttonModificarProceso.Enabled = false;
        }

        private void Desactiva_boton_agregar_proceso()
        {
            buttonAgregarProceso.Enabled = false;
        }


        private void TimerAgregarUsuario_Tick(object sender, EventArgs e)
        {
            if(textBoxNotasActividad.Text!="" && textBoxNotasActividad.Text !="")
            {
                timerAgregarProceso.Enabled = false;
                Activa_boton_guardar_base_de_datos();
            }

        }

        private void Activa_boton_cancelar_operacio()
        {
            buttonCancelar.Visible = true;
        }

        private void buttonGuardarBasedeDatos_Click(object sender, EventArgs e)
        {
            if (Operacio_actividades_procesos == "Modificar")
                Secuencia_modificar_actividad_proceso();
            else if (Operacio_actividades_procesos == "Agregar")
                Secuencia_agregar_actividad_proceso();
        }

        private void Secuencia_agregar_actividad_proceso()
        {

            if (Guarda_datos_agregar_proceso_electrico())
            {
                Limpia_cajas_captura_despues_de_agregar_proceso();
                Limpia_combo_nombre_proceso();
                Desactiva_cajas_captura_despues_de_agregar_actividad_proceso();
                Desactiva_boton_guardar_base_de_datos();
                Desactiva_boton_cancelar();
                Desaparece_combo_nombre_proceso();
                Desactiva_cajas_captura_despues_de_agregar_actividad_proceso();
                Activa_botones_operacion();
                Aparece_caja_nombre_proceso();
                Elimina_informacion_usuarios_disponibles();
            }
     
        }

        private void Asigna_nuevo_folio_proceso()
        {
            int numero_folio = Convert.ToInt32(folio_disponible.Folio_procesos_electricos.Substring(2, folio_disponible.Folio_procesos_electricos.Length - 2));
            numero_folio++;
            folio_disponible.Folio_procesos_electricos = folio_disponible.Folio_procesos_electricos.Substring(0, 2) + numero_folio.ToString("00000");
            string respuesta = class_folio_disponible.Actualiza_Control_folios_base_datos(folio_disponible);
            if (respuesta != "")
                MessageBox.Show(folio_disponible.error);
        }

        private void Secuencia_modificar_actividad_proceso()
        {

            if (Guarda_datos_modificar_proceso_electrico(Actividad_Proceso_Electrico_modificaciones))
            {
                Limpia_cajas_captura_despues_de_agregar_proceso();
                Limpia_combo_nombre_proceso();
                Limpia_combo_actividades_proceso();
                Desaparece_combo_actividad_proceso();
                Desactiva_cajas_captura_despues_de_agregar_actividad_proceso();
                Desactiva_boton_guardar_base_de_datos();
                Desactiva_boton_cancelar();
                Desaparece_combo_nombre_proceso();
                Activa_botones_operacion();
                Aparece_caja_nombre_proceso();
                Elimina_informacion_usuarios_disponibles();
            }    
            
        }

        private void Elimina_informacion_usuarios_disponibles()
        {
            procesos_disponibles = null;
        }

        private void Limpia_combo_codigo_empleadlo()
        {
            comboBoxCodigoProceso.Items.Clear();
            comboBoxCodigoProceso.Text = "";
        }

        private void Activa_Combo_codigo_empleado()
        {
            comboBoxCodigoProceso.Enabled = true;
        }

        private void Desaparece_combo_codigo_empleado()
        {
            comboBoxCodigoProceso.Visible = false;
        }

        private void Desactiva_boton_cancelar()
        {
            buttonCancelar.Visible = false;
        }

        private void Activa_botones_operacion()
        {
            Activa_boton_agregar_usuarios();
            Activa_boton_modificar_usuarios();
            Activa_boton_eliminar_usuarios();
            Activa_boton_visualizar_usuarios();
        }

        private void Activa_boton_visualizar_usuarios()
        {
            buttonBuscarProceso.Enabled = true;
        }

        private void Activa_boton_eliminar_usuarios()
        {
            buttonEliminarProceso.Enabled = true;
        }

        private void Activa_boton_modificar_usuarios()
        {
            buttonModificarProceso.Enabled = true;
        }

        private void Activa_boton_agregar_usuarios()
        {
            buttonAgregarProceso.Enabled = true;
        }

        private void Desactiva_boton_guardar_base_de_datos()
        {
            buttonGuardarBasedeDatos.Visible = false;
        }

        private void Desactiva_cajas_captura_despues_de_agregar_actividad_proceso()
        {
            Desactiva_caja_actividad_proceso();
            Desactiva_caja_notas_actividad();
        }

        private void Desactiva_caja_notas_actividad()
        {
            textBoxNotasActividad.Enabled = false;
        }

        private void Desactiva_caja_actividad_proceso()
        {
            textBoxActividadProcesoElectrico.Enabled = false;
        }

        private void Limpia_cajas_captura_despues_de_agregar_proceso()
        {
            Limpia_caja_actividad_proceso();
            Limpia_caja_notas_actividad();
        }

       

        private void Limpia_caja_notas_actividad()
        {
            textBoxNotasActividad.Text = "";
        }

        private void Limpia_caja_actividad_proceso()
        {
            textBoxActividadProcesoElectrico.Text = "";
        }

        private bool Guarda_datos_modificar_proceso_electrico(Actividad_Proceso_Electrico actividad)
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_ingenieria_procesos());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_modificar_en_base_de_datos(actividad), connection);
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

        private string Configura_cadena_comando_modificar_en_base_de_datos(Actividad_Proceso_Electrico actividad)
        {
            return "UPDATE actividades_procesos_electricos set  actividad='" + comboBoxActividadProcesoElectrico.Text +
                "',notas='" + textBoxNotasActividad.Text +
                "' where codigo ='" + actividad.Codigo + "';";
        }


        private bool Guarda_datos_agregar_proceso_electrico()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_ingenieria_procesos());
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
            Proceso_agregar = procesos_disponibles.
                Find(proceso => proceso.Nombre.Contains(comboBoxNombreProceso.SelectedItem.ToString()));
            if (Proceso_agregar != null)
            {
                return "INSERT INTO actividades_procesos_electricos(codigo_proceso_electrico," +
                    "proceso_electrico,actividad, notas) " +
                    "VALUES('" + Proceso_agregar.Codigo + "','" + Proceso_agregar.Nombre + "','" +
                    textBoxActividadProcesoElectrico.Text + "','" + textBoxNotasActividad.Text + "');";
            }
            else
                return "";
        }

        private bool Elimina_datos_proceso_electrico()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_ingenieria_procesos());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_eliminar_en_base_de_datos(), connection);
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
        private string Configura_cadena_comando_eliminar_en_base_de_datos()
        {
            return "DELETE from actividades_procesos_electricos where codigo='" +
               Actividad_Proceso_Electrico_eliminar.Codigo + "';";
        }

        
        private string Configura_cadena_conexion_MySQL_ingenieria_procesos()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=ingenieria;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }

        private void buttonModificarUsuario_Click(object sender, EventArgs e)
        {
            Modifica_actividad_proceso();
        }

        private void Modifica_actividad_proceso()
        {
            Desactiva_botones_operacion();
            Aparece_combo_nombre_proceso();
            Activa_combo_nombre_proceso();
            Obtener_datos_procesos_disponibles_base_datos();
            Rellenar_combo_nombre_proceso();
            Activa_boton_cancelar_operacio();
            Operacio_actividades_procesos = "Modificar";
        }

        private void Obtener_datos_procesos_disponibles_base_datos()
        {
            procesos_disponibles = clase_procesos_electrico.Adquiere_procesos_disponibles_en_base_datos();
        }

        private void Configura_cadena_comando_actualizar_en_base_de_datos()
        {
            //throw new NotImplementedException();
        }

        private void Aparece_combo_codigo_empleado()
        {
            comboBoxCodigoProceso.Visible = true;
        }

        private void Desaparece_caja_captura_codigo_empleado()
        {
            textBoxCodigoProceso.Visible = false;
        }

        private void Forma_Usuarios_Load(object sender, EventArgs e)
        {
            Habilita_combo_para_aceptar_buscar_elemento_escribiendo_en_ventana();
        }

        private void Habilita_combo_para_aceptar_buscar_elemento_escribiendo_en_ventana()
        {
            comboBoxNombreProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBoxNombreProceso.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxNombreProceso.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void comboBoxCodigoempleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Operacio_actividades_procesos == "Modificar")
                configura_forma_modificar_actividad_proceso();
            else if (Operacio_actividades_procesos == "Eliminar")
                configura_forma_eliminar_actividad_proceso();
            else if (Operacio_actividades_procesos == "Visualizar")
                configura_forma_visualizar_actividad_proceso();


        }

        private void configura_forma_visualizar_actividad_proceso()
        {
            Aparece_combo_actividad_proceso();
            Obtener_actividades_proceso();
            Limpia_combo_actividades_proceso();
            Rellenar_combo_actividades_proceso();
        }

        private void configura_forma_eliminar_actividad_proceso()
        {
            Aparece_combo_actividad_proceso();
            Obtener_actividades_proceso();
            Limpia_combo_actividades_proceso();
            Rellenar_combo_actividades_proceso();
        }

        private void configura_forma_modificar_actividad_proceso()
        {
           
            Aparece_combo_actividad_proceso();
            Obtener_actividades_proceso();
            Limpia_combo_actividades_proceso();
            Rellenar_combo_actividades_proceso();
            
        }

        private void Rellenar_combo_actividades_proceso()
        {
            foreach (Actividad_Proceso_Electrico Actividad_proceso in actividad_Proceso_Electricos_disponibles)
            {
                if (Actividad_proceso.error == "")
                    comboBoxActividadProcesoElectrico.Items.Add(Actividad_proceso.Actividad);
                else
                {
                    MessageBox.Show(Actividad_proceso.error);
                    break;
                }
            }
        }

        private void Limpia_combo_actividades_proceso()
        {
            comboBoxActividadProcesoElectrico.Items.Clear();
            comboBoxActividadProcesoElectrico.Text = "";
        }

        private void Obtener_actividades_proceso()
        {
            actividad_Proceso_Electricos_disponibles = Class_Actividades_Proceso_Electrico.
                Adquiere_actividad_procesos_disponibles_en_base_datos();
        }

        private void Aparece_combo_actividad_proceso()
        {
            comboBoxActividadProcesoElectrico.Visible = true;
        }

        private void Desaparece_combo_actividad_proceso()
        {
            comboBoxActividadProcesoElectrico.Visible = false;
        }

        private void Desactiva_combo_nombre_proceso()
        {
            comboBoxNombreProceso.Enabled = false;
        }

        private void Inicia_timer_modificar_actividades_proceso()
        {
            timerActualizarActividadesProceso.Enabled = true;
        }

        private void Termina_timer_modificar_actividades_proceso()
        {
            timerActualizarActividadesProceso.Enabled = false;
        }

        private void Desactiva_Combo_codigo_empleado()
        {
            comboBoxCodigoProceso.Enabled = false;
        }

        private void Rellena_cajas_informacion_de_proceso()
        {
            int numero_folio = 0;

            Proceso_Modificaciones = procesos_disponibles.Find(usuario => usuario.Nombre.Contains(comboBoxNombreProceso.SelectedItem.ToString()));
            numero_folio = Convert.ToInt32(Proceso_Modificaciones.Codigo.Substring(2, Proceso_Modificaciones.Codigo.Length - 2));
            Proceso_Modificaciones.Codigo = Proceso_Modificaciones.Codigo.Substring(0, 2) + numero_folio.ToString("00000");
            textBoxCodigoProceso.Text = Proceso_Modificaciones.Codigo;
        }

        private void timerActualizarActividadesProceso_Tick(object sender, EventArgs e)
        {
            if(comboBoxActividadProcesoElectrico.Text!= Actividad_Proceso_Electrico_modificaciones.Actividad
                || textBoxNotasActividad.Text!= Actividad_Proceso_Electrico_modificaciones.Notas)
            {
                timerActualizarActividadesProceso.Enabled = false;
                buttonGuardarBasedeDatos.Visible = true;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Limpia_cajas_captura_despues_de_agregar_proceso();
            Limpia_combo_nombre_proceso();
            Limpia_combo_actividades_proceso();
            Desactiva_cajas_captura_despues_de_agregar_actividad_proceso();
            Desactiva_boton_guardar_base_de_datos();
            Desaparece_combo_nombre_proceso();
            Desaparece_combo_actividad_proceso();
            Desactiva_boton_cancelar();
            Desactiva_boton_eliminar_base_de_datos();
            Activa_botones_operacion();
            Activa_Combo_codigo_empleado();
            Aparece_caja_nombre_proceso();
            Termina_timer_modificar_actividades_proceso();
            Termina_timer_eliminar_actividad_proceso();
            Desactiva_boton_eliminar_base_de_datos();
            Desactiva_boton_guardar_base_de_datos();

        }

        private void Limpia_combo_nombre_proceso()
        {
            comboBoxNombreProceso.Items.Clear();
            comboBoxNombreProceso.Text = "";
        }

        private void Aparece_caja_nombre_proceso()
        {
            textBoxNombreProceso.Visible = true;
        }

        private void Desaparece_combo_nombre_proceso()
        {
            comboBoxNombreProceso.Visible=false;
        }

        private void buttonEliminarUsuario_Click(object sender, EventArgs e)
        {
            Eliminar_actividad_proceso();
            
        }

        private void buttonBorrarBasedeDatos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro de Eiliminar Este Proceso?", "Eliminar Proceso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Elimina_informacion_en_base_de_datos())
                {
                    Limpia_cajas_captura_despues_de_agregar_proceso();
                    Limpia_combo_nombre_proceso();
                    Limpia_combo_actividades_proceso();
                    Desaparece_combo_actividad_proceso();
                    Desactiva_cajas_captura_despues_de_agregar_actividad_proceso();
                    Desactiva_boton_guardar_base_de_datos();
                    Desactiva_boton_cancelar();
                    Desaparece_combo_nombre_proceso();
                    Activa_botones_operacion();
                    Aparece_caja_nombre_proceso();
                    Desactiva_boton_eliminar_base_de_datos();
                    Elimina_informacion_usuarios_disponibles();
                }
            }
        }

        private void Desactiva_boton_eliminar_base_de_datos()
        {
            buttonBorrarBasedeDatos.Visible = false;
        }

        private bool Elimina_informacion_en_base_de_datos()
        {
            return Elimina_datos_proceso_electrico();
        }

        private void Eliminar_actividad_proceso()
        {
            Desactiva_botones_operacion();
            Aparece_combo_nombre_proceso();
            Activa_combo_nombre_proceso();
            Obtener_datos_procesos_disponibles_base_datos();
            Rellenar_combo_nombre_proceso();
            Activa_boton_cancelar_operacio();
            Operacio_actividades_procesos = "Eliminar";
        }

        private void Inicia_timer_eliminar_actividad_proceso()
        {
            timerEliminarActividadProceso.Enabled = true;
        }

        private void Termina_timer_eliminar_actividad_proceso()
        {
            timerEliminarActividadProceso.Enabled = false;
        }

        private void Activa_boton_borrar_ususraio_base_datos()
        {
            buttonBorrarBasedeDatos.Visible = true;
        }

        private void timerEliminarActividadProceso_Tick(object sender, EventArgs e)
        {
            if (comboBoxActividadProcesoElectrico.Text != "")
            {
                timerEliminarActividadProceso.Enabled = false;
                Activa_boton_borrar_ususraio_base_datos();
            }
        }

        private void buttonBuscarempleado_Click(object sender, EventArgs e)
        {
            Visualiza_proceso();
        }

        private void Visualiza_proceso()
        {
            Desactiva_botones_operacion();
            Aparece_combo_nombre_proceso();
            Activa_combo_nombre_proceso();
            Obtener_datos_procesos_disponibles_base_datos();
            Rellenar_combo_nombre_proceso();
            Activa_boton_cancelar_operacio();
            Operacio_actividades_procesos = "Visualizar";
        }

        private void Activa_combo_nombre_proceso()
        {
            comboBoxNombreProceso.Enabled = true;
        }

        private void Rellenar_combo_nombre_proceso()
        {
            foreach (Proceso_electrico proceso in procesos_disponibles)
            {
                if (proceso.error == "")
                    comboBoxNombreProceso.Items.Add(proceso.Nombre);
                else
                {
                    MessageBox.Show(proceso.error);
                    break;
                }
            }
        }

        private void Aparece_combo_nombre_proceso()
        {
            comboBoxNombreProceso.Visible = true;
        }

        private void Desaparce_caja_nombre_proceso()
        {
            textBoxNombreProceso.Visible = false;
        }


        private void comboBoxNombreEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Operacio_actividades_procesos == "Modificar")
                configura_forma_modificar_actividad_proceso();
            else if (Operacio_actividades_procesos == "Eliminar")
                configura_forma_eliminar_actividad_proceso();
            else if (Operacio_actividades_procesos == "Visualizar")
                configura_forma_visualizar_actividad_proceso();
            else if(Operacio_actividades_procesos == "Agregar")
                configura_forma_agregar();
        }

        private void configura_forma_agregar()
        {
            Desactiva_combo_nombre_proceso();
            Activa_cajas_informacion();
            Inicia_timer_para_asegurar_informacion_en_todos_los_campos();
        }

        private void comboBoxActividadProcesoElectrico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Operacio_actividades_procesos == "Modificar")
                configura_forma_modificar_notas_actividad();
            else if (Operacio_actividades_procesos == "Eliminar")
                configura_forma_eliminar_notas_actividad();
            else if (Operacio_actividades_procesos == "Visualizar")
                configura_forma_visualizar_notas_actividad();
            else if (Operacio_actividades_procesos == "Agregar")
                configura_forma_agregar();
        }

        private void configura_forma_eliminar_notas_actividad()
        {
            
                Desactiva_combo_nombre_proceso();
            Actividad_Proceso_Electrico_eliminar = actividad_Proceso_Electricos_disponibles.
                Find(actividades => actividades.Actividad.Contains(comboBoxActividadProcesoElectrico.SelectedItem.ToString()));
            textBoxNotasActividad.Text = Actividad_Proceso_Electrico_eliminar.Notas;
            Inicia_timer_eliminar_actividad_proceso();
            Activa_caja_notas_actividad();
        }

        private void configura_forma_visualizar_notas_actividad()
        {
            
                Desactiva_combo_nombre_proceso();
            Actividad_Proceso_Electrico_visualizar = actividad_Proceso_Electricos_disponibles.
                Find(actividades => actividades.Actividad.Contains(comboBoxActividadProcesoElectrico.SelectedItem.ToString()));
            textBoxNotasActividad.Text = Actividad_Proceso_Electrico_visualizar.Notas;
            Activa_caja_notas_actividad();
        }

        private void configura_forma_modificar_notas_actividad()
        {
            Desactiva_combo_nombre_proceso();
            Actividad_Proceso_Electrico_modificaciones = actividad_Proceso_Electricos_disponibles.
                Find(actividades => actividades.Actividad.Contains(comboBoxActividadProcesoElectrico.SelectedItem.ToString()));
            textBoxNotasActividad.Text = Actividad_Proceso_Electrico_modificaciones.Notas;
            Activa_caja_notas_actividad();
            Inicia_timer_modificar_actividades_proceso();
        }
    }
}
 