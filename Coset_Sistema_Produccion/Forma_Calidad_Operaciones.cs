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
    public partial class Forma_Calidad_Operaciones : Form
    {
        public List<Proceso_electricos> procesos_disponibles = new List<Proceso_electricos>();
        public Class_Procesos clase_procesos = new Class_Procesos();
        public Proceso_electricos Proceso_Modificaciones = new Proceso_electricos();
        public Class_Control_Folios class_folio_disponible = new Class_Control_Folios();
        public Control_folio folio_disponible = new Control_folio();
        public List<Usuario> Empleados_produccion_disponibles = new List<Usuario>();
        public Class_Usuarios Class_Usuarios = new Class_Usuarios();
        public Usuario Usuario_seeccion = new Usuario();
        public string Operacio_procesos = "";
        public List<Dibujos_proyecto> Dibujos_proyectos_disponibles = new List<Dibujos_proyecto>();
        public Class_Dibujos_Proyecto Class_Dibujos_Proyecto = new Class_Dibujos_Proyecto();
        public Dibujos_proyecto Dibujo_seleccion = new Dibujos_proyecto();
        public List<Dibujo_produccion> Dibujos_produccion_disponible = new List<Dibujo_produccion>();
        public Class_Dibujos_Produccion Class_Dibujos_Produccion = new Class_Dibujos_Produccion();
        public Dibujo_produccion Dibujos_produccion_seleccion = new Dibujo_produccion();
        public Dibujo_produccion Dibujos_produccion_insertar = new Dibujo_produccion();
        public Dibujo_produccion Dibujos_produccion_busqueda = new Dibujo_produccion();
        public Dibujo_produccion Dibujos_produccion_actualizar = new Dibujo_produccion();
        public Class_Secuencia_Calidad Class_secuencia_calidad = new Class_Secuencia_Calidad();
        public List<Secuencia_calidad> Secuencias_calidad_disponibles = new List<Secuencia_calidad>();
        public Secuencia_calidad Secuencia_calidad_seleccion = new Secuencia_calidad();
        public Secuencia_calidad Secuencia_calidad_modificacion = new Secuencia_calidad();
        public Secuencia_calidad Secuencia_calidad_insertar = new Secuencia_calidad();
        public Secuencia_calidad Secuencia_calidad_busqueda = new Secuencia_calidad();
        public string secuencia_operacion = "";

        public Forma_Calidad_Operaciones()
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
            clase_procesos = null;
            Proceso_Modificaciones = null;
            this.Dispose();
            GC.Collect();
            this.Close();
        }

        private void buttonDesecho_Click(object sender, EventArgs e)
        {
            secuencia_operacion = "desecho";
            Aparece_caja_descripcion_rechazo();
            Activa_caja_descripcion_rechazo();
            Aparece_boton_guardar_base_datos();
            Desactiva_botones_operacion();

        }

        private void Elimina_informacion_secuencia_disponibles()
        {
            Dibujos_proyectos_disponibles = null;
            Dibujos_produccion_disponible = null;
            Secuencias_calidad_disponibles = null;
        }

        private void Genera_secuencia_produccion_terminar_transaccion()
        {
            //Obtener_secuencias_calidad_disponibles();
            //Asigna_valores_secuencia_produccion_modificaciones();
            //Class_Secuencia_Produccion.Actualiza_base_datos_secuencia_produccion(Secuencia_produccion_seleccion);
            //Asigna_valores_dibujo_produccion_actualizar();
            //Class_Dibujos_Produccion.Actualiza_base_datos_dibujo_produccion(Dibujos_produccion_disponible[0]);
        }

        private void Asigna_codigo_proceso_foilio_disponible()
        {
            folio_disponible = class_folio_disponible.Obtener_informacion_control_folio_base_datos();
            textBoxEmpleado.Text = folio_disponible.Folio_procesos;
        }

        private void Aparece_caja_codigo_proceso()
        {
            textBoxEmpleado.Visible = true;
        }

        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos()
        {
            timerInciarProcesoBusqueda.Enabled = true;
        }

        private void Activa_boton_guardar_base_de_datos()
        {
            buttonGuardarBasedeDatos.Visible = true;
        }

       
        private void Activa_caja_nombre_proceso()
        {
            textBoxNombreProceso.Enabled = true;
        }

        private void Activa_caja_codigo_proceso()
        {
            textBoxEmpleado.Enabled = true;
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
            buttonAceptar.Enabled = false;
        }

        private void Activa_cajas_informacion()
        {
            Activa_caja_codigo_proceso();
            Activa_caja_nombre_proceso();
        }

        private void Desactiva_boton_eliminar_proceso()
        {
            buttonBuscarDibujo.Enabled = false;
        }

        private void Desactiva_boton_modificar_proceso()
        {
            buttonRetrabajo.Enabled = false;
        }

        private void Desactiva_boton_agregar_proceso()
        {
            buttonDesecho.Enabled = false;
        }


        private void timerInciarProcesoBusqueda_Tick(object sender, EventArgs e)
        {
            if(textBoxNumeroDibujo.Text!="")
            {
                timerInciarProcesoBusqueda.Enabled = false;
                Activa_boton_buscar_dibujo_base_de_datos();
                Activa_boton_visualizar_secuencia();
            }
        }

        private void Activa_boton_buscar_dibujo_base_de_datos()
        {
            buttonBuscarDibujo.Enabled = true;
        }

        private void Activa_boton_cancelar_operacio()
        {
            buttonCancelar.Visible = true;
        }

        private void buttonGuardarBasedeDatos_Click(object sender, EventArgs e)
        {
            if (secuencia_operacion == "retrabajo")
            {
                Dibujos_produccion_disponible[0].Secuencia = "Produccion";
                Dibujos_produccion_disponible[0].Calidad = "Re-trabajo";
                Dibujos_produccion_disponible[0].Estado = "Nuevo";
                Class_Dibujos_Produccion.Actualiza_base_datos_dibujo_produccion(Dibujos_produccion_disponible[0]);
                Genera_secuencia_calidad_retrabajo_transaccion();
            }
            else if(secuencia_operacion == "desecho")
            {
                Dibujos_produccion_disponible[0].Secuencia = "Produccion";
                Dibujos_produccion_disponible[0].Calidad = "Desecho";
                Dibujos_produccion_disponible[0].Estado = "Nuevo";
                Class_Dibujos_Produccion.Actualiza_base_datos_dibujo_produccion(Dibujos_produccion_disponible[0]);
                Genera_secuencia_calidad_desecho_transaccion();
            }
            Cancela_operacio_produccion();
            Elimina_informacion_secuencia_disponibles();
        }

        private void Genera_secuencia_calidad_desecho_transaccion()
        {
            Asigna_valores_variable_secuencia_calidad_aceptar();
            Class_secuencia_calidad.Inserta_nuevo_secuencia_calidad_base_datos(Secuencia_calidad_insertar);
        }

        private void Genera_secuencia_calidad_retrabajo_transaccion()
        {
            Asigna_valores_variable_secuencia_calidad_aceptar();
            Class_secuencia_calidad.Inserta_nuevo_secuencia_calidad_base_datos(Secuencia_calidad_insertar);
        }


        private void Limpia_combo_codigo_empleadlo()
        {
            comboBoxEmpleado.Items.Clear();
            comboBoxEmpleado.Text = "";
        }

        private void Activa_Combo_codigo_empleado()
        {
            comboBoxEmpleado.Enabled = true;
        }

        private void Desaparece_combo_codigo_empleado()
        {
            comboBoxEmpleado.Visible = false;
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
            buttonAceptar.Enabled = true;
        }

        private void Activa_boton_eliminar_usuarios()
        {
            buttonBuscarDibujo.Enabled = true;
        }

        private void Activa_boton_modificar_usuarios()
        {
            buttonRetrabajo.Enabled = true;
        }

        private void Activa_boton_agregar_usuarios()
        {
            buttonDesecho.Enabled = true;
        }

        private void Desactiva_boton_guardar_base_de_datos()
        {
            buttonGuardarBasedeDatos.Visible = false;
        }

        private void Desactiva_cajas_captura_despues_de_agregar_empleado()
        {
            Desactiva_caja_codigo_proceso();
            Desactiva_caja_nombre_proceso();
        }

        private void Desactiva_caja_nombre_proceso()
        {
            textBoxNombreProceso.Enabled = false;
        }

        private void Desactiva_caja_codigo_proceso()
        {
            textBoxEmpleado.Enabled = false;
        }

        private void Limpia_cajas_captura_despues_de_agregar_proceso()
        {
            Limpia_caja_codigo_proceso();
            Limpia_caja_nombre_proceso();
        }

       

        private void Limpia_caja_nombre_proceso()
        {
            textBoxNombreProceso.Text = "";
        }

        private void Limpia_caja_codigo_proceso()
        {
            textBoxEmpleado.Text = "";
        }

        private void buttonRetrabajo_Click(object sender, EventArgs e)
        {
            secuencia_operacion = "retrabajo";
            Aparece_caja_descripcion_rechazo();
            Activa_caja_descripcion_rechazo();
            Aparece_boton_guardar_base_datos();
            Desactiva_botones_operacion();
        }

        private void Activa_caja_descripcion_rechazo()
        {
            textBoxMotivoRechazo.Enabled = true;
            labelDescripcionRechazo.Enabled = true;
            textBoxAccionCorrectiva.Enabled = true;
            labelaccionCorrectiva.Enabled = true;
        }

        private void Aparece_boton_guardar_base_datos()
        {
            buttonGuardarBasedeDatos.Visible = true;
        }

        private void Aparece_caja_descripcion_rechazo()
        {
            textBoxMotivoRechazo.Visible = true;
            labelDescripcionRechazo.Visible = true;
            textBoxAccionCorrectiva.Visible = true;
            labelaccionCorrectiva.Visible = true;

        }

        private void Genera_secuencia_produccion_pausar_transaccion()
        {
            //Obtener_secuencias_calidad_disponibles();
            //Asigna_valores_secuencia_produccion_modificaciones();
            //Class_Secuencia_Produccion.Actualiza_base_datos_secuencia_produccion(Secuencia_produccion_seleccion);
            //Asigna_valores_dibujo_produccion_actualizar();
            //Class_Dibujos_Produccion.Actualiza_base_datos_dibujo_produccion(Dibujos_produccion_disponible[0]);
        }

        private void Asigna_valores_dibujo_produccion_actualizar()
        {
            //DateTime Final = Convert.ToDateTime(Secuencia_produccion_seleccion.final_proceso);
            //DateTime Inicio = Convert.ToDateTime(Secuencia_produccion_seleccion.inicio_proceso);
            //TimeSpan timeSpan = Final - Inicio;
            //if(Dibujos_produccion_disponible[0].Calidad == "Proceso")
            //{
            //    Dibujos_produccion_disponible[0].Horas_produccion =
            //        (Convert.ToSingle(Dibujos_produccion_disponible[0].Horas_produccion) +
            //        Convert.ToSingle(timeSpan.TotalMinutes / 60.0)).ToString();
            //}
            //else if(Dibujos_produccion_disponible[0].Calidad == "Re-trabajo" || 
            //    Dibujos_produccion_disponible[0].Calidad == "Desecho")
            //{
            //    Dibujos_produccion_disponible[0].Horas_retrabajo =
            //        (Convert.ToSingle(Dibujos_produccion_disponible[0].Horas_retrabajo) +
            //        Convert.ToSingle(timeSpan.TotalMinutes / 60.0)).ToString();
            //}
            
            //if(secuencia_operacion == "Terminar")
            //{
            //    Dibujos_produccion_disponible[0].Secuencia = "Calidad";
            //}

        }

        private void Asigna_valores_secuencia_produccion_modificaciones()
        {

            //Secuencia_produccion_seleccion.final_proceso = DateTime.Now.ToString();
            //if (secuencia_operacion == "Pausar")
            //{
            //    Secuencia_produccion_seleccion.estado = "pausado";
            //}
            //else if (secuencia_operacion == "Terminar")
            //{
            //    Secuencia_produccion_seleccion.estado = "Terminado";
            //}


        }

        private void Obtener_secuencias_calidad_disponibles()
        {
            Secuencia_calidad_busqueda.Numero_Dibujo = textBoxNumeroDibujo.Text;
            Secuencias_calidad_disponibles = Class_secuencia_calidad.
                Adquiere_secuencia_calidad_busqueda_en_base_datos(Secuencia_calidad_busqueda);
        }

        private void Obtener_datos_procesos_disponibles_base_datos()
        {
            procesos_disponibles = clase_procesos.Adquiere_procesos_disponibles_en_base_datos();
        }


        private void Aparece_combo_codigo_empleado()
        {
            comboBoxEmpleado.Visible = true;
        }

        private void Desaparece_caja_captura_codigo_empleado()
        {
            textBoxEmpleado.Visible = false;
        }

        private void Forma_Usuarios_Load(object sender, EventArgs e)
        {
            Habilita_combo_para_aceptar_buscar_elemento_escribiendo_en_ventana();
            Obtener_dibujos_en_calidad();
            //aqui se 
            Secuencia_usuarios_produccion();
           
        }



        private void Obtener_dibujos_en_calidad()
        {
            Buscar_dibujos_en_calidad();
            Rellena_datagrid_dibujos_en_calidad();

    }

        private void Rellena_datagrid_dibujos_en_calidad()
        {
            foreach (Dibujo_produccion dibujo_en_calidad in Dibujos_produccion_disponible)
            {
                dataGridViewSecuenciasCalidad.Rows.Add(
               dibujo_en_calidad.Numero_dibujo,
               dibujo_en_calidad.Empleado,
               dibujo_en_calidad.Proceso);

            }
        }

        private void Buscar_dibujos_en_calidad()
        {
            Dibujos_produccion_disponible = Class_Dibujos_Produccion.
                Adquiere_dibujos_produccion_busqueda_en_base_datos_en_calidad();
        }

        private void Secuencia_usuarios_produccion()
        {
            Obtener_usuarios_disponibles();
            Limpia_combo_empleados_produccion();
            Muestra_combo_empleados_produccion();
            Activa_Combo_codigo_empleado();
            Rellenar_combo_nombre_proceso();
            
        }

        private void Muestra_combo_empleados_produccion()
        {
            comboBoxEmpleado.Visible = true;
        }

        private void Limpia_combo_empleados_produccion()
        {
            comboBoxEmpleado.Items.Clear();
            comboBoxEmpleado.Text = "";
        }

        private void Obtener_usuarios_disponibles()
        {
            Empleados_produccion_disponibles = Class_Usuarios.Adquiere_usuarios_disponibles_en_base_datos();
        }

        private void Habilita_combo_para_aceptar_buscar_elemento_escribiendo_en_ventana()
        {
            comboBoxNombreProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBoxNombreProceso.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxNombreProceso.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void comboBoxEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Activa_caja_numero_dibujo();
            Inicia_timer_busqueda_dibujo();
            Activa_boton_cancelar_operacio();
            
        }

        private void Activa_boton_visualizar_secuencia()
        {
            buttonBuscarSecuenciaDibujo.Enabled = true;
        }

        private void Inicia_timer_busqueda_dibujo()
        {
            timerInciarProcesoBusqueda.Enabled = true;
        }

        private void Activa_caja_numero_dibujo()
        {
            textBoxNumeroDibujo.Enabled = true;
        }

        private void configura_forma_visualizar()
        {
            Rellena_cajas_informacion_de_proceso();
        }

        private void configura_forma_eliminar()
        {
            Activa_cajas_informacion();
            Rellena_cajas_informacion_de_proceso();
            Desactiva_combo_nombre_empleado();
        }

        private void configura_forma_modificar()
        {
            Activa_cajas_informacion();
            Rellena_cajas_informacion_de_proceso();
            Desactiva_caja_codigo_proceso();
            Inicia_timer_modificar_empleado();
        }

        private void Desactiva_combo_nombre_empleado()
        {
            comboBoxNombreProceso.Enabled = false;
        }

        private void Inicia_timer_modificar_empleado()
        {
            timerActualizrempleado.Enabled = true;
        }

        private void Desactiva_Combo_codigo_empleado()
        {
            comboBoxEmpleado.Enabled = false;
        }

        private void Rellena_cajas_informacion_de_proceso()
        {
            Proceso_Modificaciones = procesos_disponibles.Find(usuario => usuario.Nombre.Contains(comboBoxNombreProceso.SelectedItem.ToString()));

            textBoxEmpleado.Text = Proceso_Modificaciones.Codigo;
        }

        private void timerActualizrempleado_Tick(object sender, EventArgs e)
        {
            if(textBoxNombreProceso.Text!= Proceso_Modificaciones.Nombre)
            {
                timerActualizrempleado.Enabled = false;
                buttonGuardarBasedeDatos.Visible = true;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Cancela_operacio_produccion();
        }

        private void Limpia_combo_nombre_proceso()
        {
            comboBoxNombreProceso.Items.Clear();
            comboBoxNombreProceso.Text = "";
        }

        private void Aparece_caja_nombre_empleado()
        {
            textBoxNombreProceso.Visible = true;
        }

        private void Desaparece_combo_nombre_proceso()
        {
            comboBoxNombreProceso.Visible=false;
        }

        private void buttonBuscarDibujo_Click(object sender, EventArgs e)
        {
            buscar_dibujo_secuencia_calidad_base_datos();
            Deabilita_boton_busqueda_dibujo();
            Deactiva_boton_visualizar();
        }

        private void Deabilita_boton_busqueda_dibujo()
        {
            buttonBuscarDibujo.Enabled=false;
        }

        private void buscar_dibujo_secuencia_calidad_base_datos()
        {

            if (Busca_dibujo_produccion_base_datos())
            {

                if (verifica_dibujo_en_calidad())
                {
                    Configura_botones_operacion();
                }
                else
                {
                    Cancela_operacio_produccion();
                }
            }

        }

        private bool verifica_dibujo_en_calidad()
        {
            if (Dibujos_produccion_disponible[0].Secuencia == "Calidad")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Numeo de dibujo, " + Dibujos_produccion_disponible[0].Secuencia, "Busqueda Numero Dibujo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private bool Busca_dibujo_produccion_base_datos()
        {
            if (Dibujo_existe_base_datos_produccion() == false)
            {
                /*Inserta_nuevo_registro_dibujos_produccion_base_datos();
                   solo aplica para captura de produccion */
                return false;
            }
            else
            {
                return true;
            }

        }

        private bool Dibujo_existe_base_datos_produccion()
        {

            return obtener_dibujos_produccio_disponibles();
            
        }

        private bool verifica_dibujo_asignado_empleado_solicitante()
        {
            if((Dibujos_produccion_disponible[0].Empleado == comboBoxEmpleado.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Numeo de dibujo asignado, " + Dibujos_produccion_disponible[0].Empleado, "Busqueda Numero Dibujo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            

        }

        private bool obtener_dibujos_produccio_disponibles()
        {
            Asigna_valores_dibujo_produccion_busqueda();
            Dibujos_produccion_disponible = Class_Dibujos_Produccion.
                Adquiere_dibujos_produccion_busqueda_en_base_datos(Dibujos_produccion_busqueda);
            if (Dibujos_produccion_disponible.Count > 1)
            {
                MessageBox.Show("Numeo de dibujo Duplicado", "Busqueda Numero Dibujo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (Dibujos_produccion_disponible.Count < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Asigna_valores_dibujo_produccion_busqueda()
        {
            Dibujos_produccion_busqueda.Numero_dibujo = textBoxNumeroDibujo.Text;
            Dibujos_produccion_busqueda.Empleado = comboBoxEmpleado.Text;
        }

        private void Configura_botones_operacion()
        {
            textBoxNombreProceso.Text = Dibujos_produccion_disponible[0].Proceso;
            textBoxCalidad.Text = Dibujos_produccion_disponible[0].Calidad;
            //Rellena_datagridview_secuencias_calidad();
            Activa_botones_operacion();
        }


        private void Rellena_datagridview_secuencias_calidad()
        {
            Limpia_datagridview_secuencia_calidad();
            Obtener_secuencias_calidad_disponibles();
            Asigna_valores_datagridview_secuencias_calidad();
        }

        private void Limpia_datagridview_secuencia_calidad()
        {
            dataGridViewSecuenciasCalidad.Rows.Clear();
        }

        private void Asigna_valores_datagridview_secuencias_calidad()
        {

            foreach (Secuencia_calidad secuencia in Secuencias_calidad_disponibles)
            {

                dataGridViewSecuenciasCalidad.Rows.Add(
               secuencia.Codigo,
               secuencia.Numero_Dibujo,
               secuencia.Empleado,
               secuencia.Fecha,
               secuencia.Proceso,
               secuencia.calidad,
               secuencia.Motivo_rechazo);


            }
               
        }

        private void Secuencia_proceso_terminado()
        {
            MessageBox.Show("Dibujo Terminado en Produccion", "Dibujos Produccion",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Secuencia_pausa_treminar_proceso()
        {
            buttonRetrabajo.Enabled = true;
            buttonDesecho.Enabled = true;
        }

        private void Secuencia_inicia_proceso()
        {
            buttonAceptar.Enabled = true;
        }

        private void Inserta_nuevo_registro_dibujos_produccion_base_datos()
        {
            MessageBox.Show("El numero de Dibujo se agregara a produccion", "Dibujos Produccion", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxCalidad.Text = "Proceso";
            Asigna_valores_dibujo_produccion();
            Class_Dibujos_Produccion.Inserta_nuevo_dibujo_produccion_base_datos(Dibujos_produccion_insertar);
        }

        private void Asigna_valores_dibujo_produccion()
        {
            Dibujos_produccion_insertar.Numero_dibujo = textBoxNumeroDibujo.Text;
            Dibujos_produccion_insertar.proyecto = Dibujos_proyectos_disponibles[0].Codigo_proyecto;
            Dibujos_produccion_insertar.Calidad = "Proceso";
            Dibujos_produccion_insertar.Empleado = comboBoxEmpleado.Text;
            Dibujos_produccion_insertar.Proceso = Dibujos_proyectos_disponibles[0].proceso;

        }


        private void Cancela_operacio_produccion()
        {
            Limpia_cajas_captura_despues_de_secuencia();
            Desactiva_cajas_captura_despues_de_secuencia();
            Desactiva_botones_operacion();
            Desactiva_boton_cancelar();
            Deactiva_boton_visualizar();
            Desaparece_textbox_descripcion_rechazo();
            Desaparece_boton_guardar_base_datos();
            Desactiva_textbox_descripcion_rechazo();
            Limpia_combo_usuario();
            Limpia_seleccion_secuencia_operacion();
            Limpia_datagridview_secuencia_calidad();
            Obtener_dibujos_en_calidad();
        }

        private void Desaparece_boton_guardar_base_datos()
        {
            buttonGuardarBasedeDatos.Visible = false;
        }

        private void Desactiva_textbox_descripcion_rechazo()
        {
            textBoxMotivoRechazo.Enabled = false;
            labelDescripcionRechazo.Enabled = false;
            textBoxAccionCorrectiva.Enabled = false;
            labelaccionCorrectiva.Enabled = false;
        }

        private void Desaparece_textbox_descripcion_rechazo()
        {
            textBoxMotivoRechazo.Visible = false;
            labelDescripcionRechazo.Visible = false;
            textBoxAccionCorrectiva.Visible = false;
            labelaccionCorrectiva.Visible = false;

        }

        private void Limpia_seleccion_secuencia_operacion()
        {
            secuencia_operacion = "";
        }

        private void Limpia_combo_usuario()
        {
            comboBoxEmpleado.Text = "";
        }

        private void Desactiva_cajas_captura_despues_de_secuencia()
        {
            textBoxNumeroDibujo.Enabled = false;
            textBoxNombreProceso.Enabled = false;
            textBoxCalidad.Enabled = false;

        }

        private void Limpia_cajas_captura_despues_de_secuencia()
        {
            textBoxNumeroDibujo.Text = "";
            textBoxNombreProceso.Text = "";
            textBoxCalidad.Text = "";
            textBoxMotivoRechazo.Text = "";
            textBoxAccionCorrectiva.Text = "";

        }

        private bool obtener_dibujos_Proyectos_disponibles_base_datos()
        {
            Dibujos_proyectos_disponibles = Class_Dibujos_Proyecto.Adquiere_dibujos_disponibles_en_base_datos(textBoxNumeroDibujo.Text);
            if(Dibujos_proyectos_disponibles.Count > 1 )
            {
                MessageBox.Show("Numeo de dibujo Duplicado En Proyectos", "Busqueda Numero Dibujo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if(Dibujos_proyectos_disponibles.Count < 1)
            {
                MessageBox.Show("Numeo de dibujo No existe En Proyectos", "Busqueda Numero Dibujo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
            
        }

        private void buttonBorrarBasedeDatos_Click(object sender, EventArgs e)
        {
           
        }

        private void Desactiva_boton_eliminar_base_de_datos()
        {
            buttonBorrarBasedeDatos.Visible = false;
        }


        private void Inicia_timer_eliminar_usuario()
        {
            timerEliminaempleado.Enabled = true;
        }

        private void Activa_boton_borrar_ususraio_base_datos()
        {
            buttonBorrarBasedeDatos.Visible = true;
        }

        private void timerEliminaempleado_Tick(object sender, EventArgs e)
        {
            if (comboBoxNombreProceso.Text != "")
            {
                timerEliminaempleado.Enabled = false;
                Activa_boton_borrar_ususraio_base_datos();
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

            secuencia_operacion = "Aceptar";
            Dibujos_produccion_disponible[0].Secuencia= "Completo";
            Dibujos_produccion_disponible[0].Calidad = "Aceptado";
            Class_Dibujos_Produccion.Actualiza_base_datos_dibujo_produccion(Dibujos_produccion_disponible[0]);
            Genera_secuencia_calidad_Aceptar_transaccion();
            Cancela_operacio_produccion();
            Elimina_informacion_secuencia_disponibles();

        }

        private void Genera_secuencia_calidad_Aceptar_transaccion()
        {
            Asigna_valores_variable_secuencia_calidad_aceptar();
            Class_secuencia_calidad.Inserta_nuevo_secuencia_calidad_base_datos(Secuencia_calidad_insertar);
        }

        private void Asigna_valores_variable_secuencia_calidad_aceptar()
        {
            if (secuencia_operacion == "Aceptar")
            {
                Secuencia_calidad_insertar.Numero_Dibujo = textBoxNumeroDibujo.Text;
                Secuencia_calidad_insertar.Empleado = comboBoxEmpleado.Text;
                Secuencia_calidad_insertar.Fecha = DateTime.Now.Date.ToString("dd/MM/yyyy");
                Secuencia_calidad_insertar.Proceso = textBoxNombreProceso.Text;
                Secuencia_calidad_insertar.Motivo_rechazo = "";
                Secuencia_calidad_insertar.Accion_correctiva = "";
                Secuencia_calidad_insertar.calidad = "Aceptado";

            }
            else if(secuencia_operacion == "retrabajo")
            {
                Secuencia_calidad_insertar.Numero_Dibujo = textBoxNumeroDibujo.Text;
                Secuencia_calidad_insertar.Empleado = comboBoxEmpleado.Text;
                Secuencia_calidad_insertar.Fecha = DateTime.Now.Date.ToString("dd/MM/yyyy");
                Secuencia_calidad_insertar.Proceso = textBoxNombreProceso.Text;
                Secuencia_calidad_insertar.Motivo_rechazo = textBoxMotivoRechazo.Text;
                Secuencia_calidad_insertar.Accion_correctiva = textBoxAccionCorrectiva.Text;
                Secuencia_calidad_insertar.calidad = "Re-trabajo";
            }
            else if(secuencia_operacion == "desecho")
            {
                Secuencia_calidad_insertar.Numero_Dibujo = textBoxNumeroDibujo.Text;
                Secuencia_calidad_insertar.Empleado = comboBoxEmpleado.Text;
                Secuencia_calidad_insertar.Fecha = DateTime.Now.Date.ToString("dd/MM/yyyy");
                Secuencia_calidad_insertar.Proceso = textBoxNombreProceso.Text;
                Secuencia_calidad_insertar.Motivo_rechazo = textBoxMotivoRechazo.Text;
                Secuencia_calidad_insertar.Accion_correctiva = textBoxAccionCorrectiva.Text;
                Secuencia_calidad_insertar.calidad = "Desecho";
            }
        }

        private void Activa_combo_nombre_proceso()
        {
            comboBoxNombreProceso.Enabled = true;
        }

        private void Rellenar_combo_nombre_proceso()
        {
            foreach (Usuario usuario in Empleados_produccion_disponibles)
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
            if (Operacio_procesos == "Modificar")
                configura_forma_modificar();
            else if (Operacio_procesos == "Eliminar")
                configura_forma_eliminar();
            else if (Operacio_procesos == "Visualizar")
                configura_forma_visualizar();
        }

        private void buttonBuscarSecuenciaDibujo_Click(object sender, EventArgs e)
        {
            Limpia_datagridview_secuencia_calidad();
            Deabilita_boton_busqueda_dibujo();
            Deactiva_boton_visualizar();
            obtener_dibujos_produccio_disponibles();
            Asigna_valores_forma_secuencia_produccion();
            Rellena_datagridview_secuencias_calidad();
        }

        private void Deactiva_boton_visualizar()
        {
            buttonBuscarSecuenciaDibujo.Enabled=false;
        }

        private void Asigna_valores_forma_secuencia_produccion()
        {
            textBoxNombreProceso.Text = Dibujos_produccion_disponible[0].Proceso;
            textBoxCalidad.Text = Dibujos_produccion_disponible[0].Calidad;
        }

        private void dataGridViewSecuenciasCalidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSecuenciasCalidad.Rows[e.RowIndex].
                Cells["Numero_Dibujo"].Value != null)
            {
                textBoxNumeroDibujo.Text = dataGridViewSecuenciasCalidad.Rows[e.RowIndex].
                    Cells["Numero_Dibujo"].Value.ToString();
                buscar_dibujo_secuencia_calidad_base_datos();
            }
        }
    }
}
 