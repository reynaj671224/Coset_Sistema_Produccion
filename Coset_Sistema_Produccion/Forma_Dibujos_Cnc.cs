using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Coset_Sistema_Produccion
{
    public partial class Forma_Dibujos_Cnc : Form
    {
        public List<Proceso> procesos_disponibles = new List<Proceso>();
        public Class_Procesos clase_procesos = new Class_Procesos();
        public Proceso Proceso_Modificaciones = new Proceso();
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
        public Class_Secuencia_Produccion Class_Secuencia_Produccion = new Class_Secuencia_Produccion();
        public List<Secuencia_produccion> Secuencias_produccion_disponibles = new List<Secuencia_produccion>();
        public Secuencia_produccion Secuencia_produccion_seleccion = new Secuencia_produccion();
        public Secuencia_produccion Secuencia_produccion_modificacion = new Secuencia_produccion();
        public Secuencia_produccion Secuencia_produccion_insertar = new Secuencia_produccion();
        public Secuencia_produccion Secuencia_produccion_busqueda = new Secuencia_produccion();
        public Class_dibujos_Cnc class_Dibujos_Cnc = new Class_dibujos_Cnc();
        public List<Dibujos_cnc> Dibujos_cnc_disponibles = new List<Dibujos_cnc>();
        public Dibujos_cnc dibujos_cnc_seleccion = new Dibujos_cnc();
        public Dibujos_cnc dibujos_cnc_insertar = new Dibujos_cnc();
        public Class_Fecha_Hora Fecha_Hora = new Class_Fecha_Hora();

        public string secuencia_operacion = "";

        public Forma_Dibujos_Cnc()
        {
            InitializeComponent();
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            Regresar_forma_principal();
        }

        private void Regresar_forma_principal()
        {
            Termina_timer_busqueda();
            procesos_disponibles = null;
            clase_procesos = null;
            Proceso_Modificaciones = null;
            this.Dispose();
            GC.Collect();
            this.Close();
        }

        private void Termina_timer_busqueda()
        {
            timerInciarProcesoBusqueda.Enabled = false;
        }

        private void buttonTerminarProceso_Click(object sender, EventArgs e)
        {
            dibujos_cnc_seleccion.fecha_final= DateTime.Now.Date.Year + "-" + DateTime.Now.Date.Month + "-" + DateTime.Now.Day;
            dibujos_cnc_seleccion.estado = "Terminado";
            class_Dibujos_Cnc.Actualiza_base_datos_dibujo_cnc(dibujos_cnc_seleccion);
            //secuencia_operacion = "Terminar";
            //Dibujos_produccion_disponible[0].Estado = "Terminado";
            //Class_Dibujos_Produccion.Actualiza_base_datos_dibujo_produccion(Dibujos_produccion_disponible[0]);
            //Genera_secuencia_produccion_terminar_transaccion();
            Cancela_operacio_produccion();
            //Elimina_informacion_secuencia_disponibles();

        }

        private void Elimina_informacion_secuencia_disponibles()
        {
            Dibujos_proyectos_disponibles = null;
            Dibujos_cnc_disponibles = null;
            Secuencias_produccion_disponibles = null;
        }

        private void Genera_secuencia_produccion_terminar_transaccion()
        {
            Obtener_secuencias_produccion_disponibles();
            Asigna_valores_secuencia_produccion_modificaciones();
            Class_Secuencia_Produccion.Actualiza_base_datos_secuencia_produccion(Secuencia_produccion_seleccion);
            Asigna_valores_dibujo_produccion_actualizar();
            Class_Dibujos_Produccion.Actualiza_base_datos_dibujo_produccion(Dibujos_produccion_disponible[0]);
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
            buttonIncioProceso.Enabled = false;
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
            buttonPausaProceso.Enabled = false;
        }

        private void Desactiva_boton_agregar_proceso()
        {
            buttonTerminarProceso.Enabled = false;
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
           
        }

        private void Elimina_informacion_usuarios_disponibles()
        {
            procesos_disponibles = null;
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
            buttonIncioProceso.Enabled = true;
        }

        private void Activa_boton_eliminar_usuarios()
        {
            buttonBuscarDibujo.Enabled = true;
        }

        private void Activa_boton_modificar_usuarios()
        {
            buttonPausaProceso.Enabled = true;
        }

        private void Activa_boton_agregar_usuarios()
        {
            buttonTerminarProceso.Enabled = true;
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

        private void buttonPausaProceso_Click(object sender, EventArgs e)
        {
            secuencia_operacion = "Pausar";
            Dibujos_produccion_disponible[0].Estado = "Pausado";
            Class_Dibujos_Produccion.Actualiza_base_datos_dibujo_produccion(Dibujos_produccion_disponible[0]);
            Genera_secuencia_produccion_pausar_transaccion();
            Cancela_operacio_produccion();
            Elimina_informacion_secuencia_disponibles();
        }

        private void Genera_secuencia_produccion_pausar_transaccion()
        {
            Obtener_secuencias_produccion_disponibles();
            Asigna_valores_secuencia_produccion_modificaciones();
            Class_Secuencia_Produccion.Actualiza_base_datos_secuencia_produccion(Secuencia_produccion_seleccion);
            Asigna_valores_dibujo_produccion_actualizar();
            Class_Dibujos_Produccion.Actualiza_base_datos_dibujo_produccion(Dibujos_produccion_disponible[0]);
        }

        private void Asigna_valores_dibujo_produccion_actualizar()
        {
            
            DateTime Final = Fecha_Hora.calcula_fecha_hora(Secuencia_produccion_seleccion.final_proceso);
            DateTime Inicio = Fecha_Hora.calcula_fecha_hora(Secuencia_produccion_seleccion.inicio_proceso);
            TimeSpan timeSpan = Final - Inicio;
            if(Dibujos_produccion_disponible[0].Calidad == "Proceso")
            {
                try
                {
                    Dibujos_produccion_disponible[0].Horas_produccion =
                        (Convert.ToSingle(Dibujos_produccion_disponible[0].Horas_produccion) +
                        Convert.ToSingle(timeSpan.TotalMinutes / 60.0)).ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(Dibujos_produccion_disponible[0].Calidad == "Re-trabajo" || 
                Dibujos_produccion_disponible[0].Calidad == "Desecho")
            {
                try
                {
                    Dibujos_produccion_disponible[0].Horas_retrabajo =
                    (Convert.ToSingle(Dibujos_produccion_disponible[0].Horas_retrabajo) +
                    Convert.ToSingle(timeSpan.TotalMinutes / 60.0)).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            
            if(secuencia_operacion == "Terminar")
            {
                Dibujos_produccion_disponible[0].Secuencia = "Calidad";
            }

        }

        private void Asigna_valores_secuencia_produccion_modificaciones()
        {
            CultureInfo culture = new CultureInfo("es-MX");
            Secuencia_produccion_seleccion.final_proceso = DateTime.Now.ToString(culture);
            if (secuencia_operacion == "Pausar")
            {
                Secuencia_produccion_seleccion.estado = "pausado";
            }
            else if (secuencia_operacion == "Terminar")
            {
                Secuencia_produccion_seleccion.estado = "Terminado";
            }


        }

        private void Obtener_secuencias_produccion_disponibles()
        {
            Secuencia_produccion_busqueda.Numero_Dibujo = textBoxNumeroDibujo.Text;
            Secuencias_produccion_disponibles = Class_Secuencia_Produccion.
                Adquiere_secuencia_produccion_busqueda_en_base_datos(Secuencia_produccion_busqueda);
            Secuencia_produccion_seleccion = Secuencias_produccion_disponibles.Find
                (secuencia_produccion => secuencia_produccion.estado.Contains(textBoxEstado.Text));
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
            Inicia_timer_busqueda_dibujo();
            Secuencia_usuarios_produccion();

        }

        private void Secuencia_usuarios_produccion()
        {
            //Obtener_usuarios_produccion();
            //Limpia_combo_empleados_produccion();
            //Muestra_combo_empleados_produccion();
            //Activa_Combo_codigo_empleado();
            //Rellenar_combo_nombre_proceso();
            textBoxEmpleado.Text = Coset_Sistema_Produccion.Nombre_Usuario;


        }

        private void Obtener_usuarios_produccion()
        {
            Empleados_produccion_disponibles = Class_Usuarios.Adquiere_usuarios_produccion_disponibles_en_base_datos();
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

        private void Obtener_usuarios()
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
            Limpia_datagridview_secuencia_produccion();
            Limpia_datagridview_dibujos_produccion();
            Aparece_datagrid_produccion_dibujos();
            Activa_boton_cancelar_operacio();
            Desactiva_caja_numero_dibujo();
            obtener_dibujos_produccio_por_empleado_disponibles();
            Asigna_valores_datagridview_dibujos_produccion();

        }

        private void Desactiva_caja_numero_dibujo()
        {
            textBoxNumeroDibujo.Enabled = false;
        }

        private void Activa_caja_numero_dibujo()
        {
            textBoxNumeroDibujo.Enabled = true;
        }

        private void Limpia_datagridview_dibujos_produccion()
        {
            dataGridViewProduccionDibujos.Rows.Clear();
        }

        private void Aparece_datagrid_produccion_dibujos()
        {
            dataGridViewProduccionDibujos.Visible = true;
        }

        private void Desaparece_datagrid_produccion_dibujos()
        {
            dataGridViewProduccionDibujos.Visible = false;
        }

        private void obtener_dibujos_produccio_por_empleado_disponibles()
        {
            Dibujos_produccion_busqueda.Empleado = comboBoxEmpleado.Text;
            Dibujos_produccion_disponible = Class_Dibujos_Produccion.
                Adquiere_dibujos_produccion_por_empleado_busqueda_en_base_datos(Dibujos_produccion_busqueda);

        }

        private void Activa_boton_visualizar_secuencia()
        {
            buttonBuscarSecuenciaDibujo.Enabled = true;
        }

        private void Inicia_timer_busqueda_dibujo()
        {
            timerInciarProcesoBusqueda.Enabled = true;
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
            int busqueda_proyecto = buscar_dibujo_proyectos_base_datos();
            if (busqueda_proyecto == 2)
            {
                Desabilita_boton_busqueda_dibujo();
                Deactiva_boton_visualizar();
                Busca_dibujo_cnc_base_datos();
                if(Dibujos_cnc_disponibles.Count==1)
                {
                    Rellenar_informacion_terminar_tiempo();

                }
                else if (Dibujos_cnc_disponibles.Count == 0)
                {
                    Rellenar_informacion_iniciar_tiempo();
                }
            }
            else if(busqueda_proyecto == 0)
            {
                MessageBox.Show("No se encontro el numero de dibujo para proceso de CNC", "Dibujo CNC",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Desabilita_boton_busqueda_dibujo();
                Deactiva_boton_visualizar();
                Limpia_caja_numero_dibujo();
                Inicia_timer_busqueda_dibujo();
            }
            else if (busqueda_proyecto == 1)
            {
                Desabilita_boton_busqueda_dibujo();
                Deactiva_boton_visualizar();
                Limpia_caja_numero_dibujo();
                Inicia_timer_busqueda_dibujo();
            }

        }

        private void Rellenar_informacion_iniciar_tiempo()
        {
            textBoxNombreProceso.Text = dibujos_cnc_seleccion.proceso;
            textBoxEstado.Text = "Nuevo";
            textBoxUnidades.Text = Dibujo_seleccion.Cantidad;
            textBoxProyecto.Text = Dibujo_seleccion.Codigo_proyecto;
            Secuencia_inicia_proceso();
            Activa_boton_cancelar_operacio();
        }

        private void Rellenar_informacion_terminar_tiempo()
        {
            
            if (Dibujos_cnc_disponibles[0].estado== "Inciado")
            {
                
                DateTime Fecha_inicio = Fecha_Hora.calcula_fecha_hora(Dibujos_cnc_disponibles[0].fecha_inicio);
                textBoxNombreProceso.Text = dibujos_cnc_seleccion.proceso;
                textBoxEstado.Text = Dibujos_cnc_disponibles[0].estado;
                textBoxUnidades.Text = Dibujo_seleccion.Cantidad;
                textBoxProyecto.Text = Dibujo_seleccion.Codigo_proyecto;
                textBoxFechaInicio.Text = Fecha_inicio.Day + "-" + Fecha_inicio.Month + "-" + Fecha_inicio.Year;
                Secuencia_pausa_treminar_proceso();
            }
            else if (Dibujos_cnc_disponibles[0].estado == "Terminado")
            {
                
                DateTime Fecha_inicio = Fecha_Hora.calcula_fecha_hora(Dibujos_cnc_disponibles[0].fecha_inicio);
                DateTime Fecha_final = Fecha_Hora.calcula_fecha_hora(Dibujos_cnc_disponibles[0].fecha_final);
                textBoxNombreProceso.Text = dibujos_cnc_seleccion.proceso;
                textBoxEstado.Text = Dibujos_cnc_disponibles[0].estado;
                textBoxUnidades.Text = Dibujo_seleccion.Cantidad;
                textBoxProyecto.Text = Dibujo_seleccion.Codigo_proyecto;
                textBoxFechaInicio.Text = Fecha_inicio.Day + "-" + Fecha_inicio.Month + "-" + Fecha_inicio.Year;
                textBoxFechaFinal.Text = Fecha_final.Day + "-" + Fecha_final.Month + "-" + Fecha_final.Year;
                Activa_boton_cancelar_operacio();
            }
            
        }

        private void Busca_dibujo_cnc_base_datos()
        {
            Dibujos_cnc_disponibles.Clear();
            dibujos_cnc_seleccion.Numero_Dibujo = Dibujo_seleccion.Numero;
            dibujos_cnc_seleccion.proceso = Dibujo_seleccion.proceso;
            Dibujos_cnc_disponibles = class_Dibujos_Cnc.
                Adquiere_dibujos_cnc_en_base_datos(dibujos_cnc_seleccion);
        }

        private void Limpia_caja_numero_dibujo()
        {
            textBoxNumeroDibujo.Text = "";
        }

        private void Desabilita_boton_busqueda_dibujo()
        {
            buttonBuscarDibujo.Enabled=false;
        }

        private int buscar_dibujo_proyectos_base_datos()
        {
            int dibujos_cnc = 0;
            if (obtener_dibujos_Proyectos_disponibles_base_datos())
            {
                foreach(Dibujos_proyecto dibujos in  Dibujos_proyectos_disponibles)
                {
                    if(dibujos.proceso == "CNC")
                    {
                        Dibujo_seleccion = dibujos;
                        dibujos_cnc = 2;
                        break;
                    }
                }
                
            }
            else
            {
                dibujos_cnc = 1;
            }

            return dibujos_cnc;
        }

        private void Rellena_cajas_informacion_dibujo(Dibujos_proyecto dibujos)
        {
            throw new NotImplementedException();
        }

        private bool verifica_dibujo_en_produccion()
        {
            if (Dibujos_produccion_disponible[0].Secuencia == "Produccion")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Numeo de dibujo en, " + Dibujos_produccion_disponible[0].Secuencia, "Busqueda Numero Dibujo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private bool Busca_dibujo_produccion_base_datos()
        {
            if (Dibujo_existe_base_datos_produccion() == false)
            {
                Inserta_nuevo_registro_dibujos_produccion_base_datos();
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
                MessageBox.Show("Numeo de dibujoNo Existe", "Busqueda Numero Dibujo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            if (textBoxEstado.Text == "") /*La unidad ya esiste en la base de datos de produccion*/
            {
                textBoxProyecto.Text = Dibujos_produccion_disponible[0].Calidad;
                textBoxEstado.Text = Dibujos_produccion_disponible[0].Estado;
                textBoxNombreProceso.Text = Dibujos_produccion_disponible[0].Proceso;
                textBoxFechaInicio.Text = Dibujos_produccion_disponible[0].Horas_produccion;
                textBoxFechaFinal.Text = Dibujos_produccion_disponible[0].Horas_retrabajo;
                textBoxUnidades.Text = Dibujos_proyectos_disponibles[0].Cantidad;
            }
            else
            {
                Dibujos_produccion_disponible = Class_Dibujos_Produccion.
                    Adquiere_dibujos_produccion_busqueda_en_base_datos(Dibujos_produccion_insertar);
                if(Dibujos_produccion_disponible.Count==1)
                {
                    textBoxNombreProceso.Text = Dibujos_produccion_disponible[0].Proceso;
                    textBoxFechaInicio.Text = Dibujos_produccion_disponible[0].Horas_produccion;
                    textBoxFechaFinal.Text = Dibujos_produccion_disponible[0].Horas_retrabajo;
                    textBoxProyecto.Text = Dibujos_produccion_disponible[0].Calidad;
                    textBoxUnidades.Text = Dibujos_proyectos_disponibles[0].Cantidad;
                }
                else
                {
                    MessageBox.Show("Dibujo No se encontro en Produccion", "Dibujos Produccion",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            switch (textBoxEstado.Text)
            {
                case "Nuevo":
                    {
                        Secuencia_inicia_proceso();
                        break;
                    }
                case "Iniciado":
                    {
                        Secuencia_pausa_treminar_proceso();
                        break;
                    }
                case "Pausado":
                    {
                        Secuencia_inicia_proceso();
                        break;
                    }
                case "Terminado":
                    {
                        Secuencia_proceso_terminado();
                        break;
                    }

            }
            Rellena_datagridview_secuencias_produccion();
        }

        private void Rellena_datagridview_secuencias_produccion()
        {
            Limpia_datagridview_secuencia_produccion();
            Obtener_secuencias_produccion_disponibles();
            Asigna_valores_datagridview_secuencias_produccion();
        }

        private void Limpia_datagridview_secuencia_produccion()
        {
            dataGridViewSecuenciasProduccion.Rows.Clear();
        }

        private void Asigna_valores_datagridview_secuencias_produccion()
        {
            
            foreach (Secuencia_produccion secuencia in Secuencias_produccion_disponibles)
            {
                DateTime Inicial, Final;
                if (secuencia.final_proceso != "")
                {
                    
                    Inicial = Fecha_Hora.calcula_fecha_hora(secuencia.inicio_proceso);
                    Final = Fecha_Hora.calcula_fecha_hora(secuencia.final_proceso);
                    TimeSpan timeSpan = Final - Inicial;
                    dataGridViewSecuenciasProduccion.Rows.Add(
                   secuencia.Codigo,
                   secuencia.Numero_Dibujo,
                   secuencia.Empleado,
                   secuencia.inicio_proceso,
                   secuencia.final_proceso,
                   secuencia.proceso,
                   secuencia.estado,
                   secuencia.calidad,
                   timeSpan.ToString());
                }
                else
                {
                    dataGridViewSecuenciasProduccion.Rows.Add(
                   secuencia.Codigo,
                   secuencia.Numero_Dibujo,
                   secuencia.Empleado,
                   secuencia.inicio_proceso,
                   secuencia.final_proceso,
                   secuencia.proceso,
                   secuencia.estado,
                   secuencia.calidad);

                }
               
                
            }
        }

        private void Asigna_valores_datagridview_dibujos_produccion()
        {

            foreach (Dibujo_produccion dibujo in Dibujos_produccion_disponible)
            {

                dataGridViewProduccionDibujos.Rows.Add(
               dibujo.Numero_dibujo,
               dibujo.Empleado,
               dibujo.Proceso,
               dibujo.Estado,
               dibujo.Calidad,
               dibujo.proyecto);
            }
        }

        private void Secuencia_proceso_terminado()
        {
            MessageBox.Show("Dibujo Terminado en Produccion", "Dibujos Produccion",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Secuencia_pausa_treminar_proceso()
        {
            buttonPausaProceso.Enabled = true;
            buttonTerminarProceso.Enabled = true;
        }

        private void Secuencia_inicia_proceso()
        {
            buttonIncioProceso.Enabled = true;
        }

        private void Inserta_nuevo_registro_dibujos_produccion_base_datos()
        {
            MessageBox.Show("El numero de Dibujo se agregara a produccion", "Dibujos Produccion", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxEstado.Text = "Nuevo";
            textBoxProyecto.Text = "Proceso";
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
            Limpia_combo_usuario();
            Limpia_seleccion_secuencia_operacion();
            Limpia_datagridview_secuencia_produccion();
            Inicia_timer_busqueda_dibujo();
            Desaparece_datagrid_secuencia_produccion();
            Desaparece_datagrid_produccion_dibujos();
            Activa_caja_numero_dibujo();
            Activa_Combo_codigo_empleado();
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
            //textBoxNumeroDibujo.Enabled = false;
            textBoxFechaInicio.Enabled = false;
            textBoxNombreProceso.Enabled = false;
            textBoxEstado.Enabled = false;
            textBoxProyecto.Enabled = false;
            textBoxFechaInicio.Enabled = false;
            textBoxFechaFinal.Enabled = false;
        }

        private void Limpia_cajas_captura_despues_de_secuencia()
        {
            textBoxNumeroDibujo.Text = "";
            textBoxFechaInicio.Text = "";
            textBoxNombreProceso.Text = "";
            textBoxEstado.Text = "";
            textBoxProyecto.Text = "";
            textBoxFechaInicio.Text = "";
            textBoxFechaFinal.Text = "";
            textBoxUnidades.Text = "";


        }

        private bool obtener_dibujos_Proyectos_disponibles_base_datos()
        {
            Dibujos_proyectos_disponibles = Class_Dibujos_Proyecto.Adquiere_dibujos_disponibles_en_base_datos(textBoxNumeroDibujo.Text);
            if(Dibujos_proyectos_disponibles.Count >= 1 )
            {
                //MessageBox.Show("Numeo de dibujo Duplicado En Proyectos", "Busqueda Numero Dibujo", 
                //    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            else if(Dibujos_proyectos_disponibles.Count < 1)
            {
                MessageBox.Show("Numeo de dibujo No existe En Proyectos", "Busqueda Numero Dibujo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return false;
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

        private void buttonIncioProceso_Click(object sender, EventArgs e)
        {

            dibujos_cnc_insertar.codigo_proyecto = textBoxProyecto.Text;
            dibujos_cnc_insertar.Empleado = textBoxEmpleado.Text;
            dibujos_cnc_insertar.proceso = textBoxNombreProceso.Text;
            dibujos_cnc_insertar.estado = "Inciado";
            dibujos_cnc_insertar.Numero_Dibujo = textBoxNumeroDibujo.Text;
            dibujos_cnc_insertar.fecha_inicio = DateTime.Now.Date.Year + "-" + DateTime.Now.Date.Month + "-" + DateTime.Now.Day;
            dibujos_cnc_insertar.fecha_final = DateTime.Now.Date.Year + "-" + DateTime.Now.Date.Month + "-" + DateTime.Now.Day;
            class_Dibujos_Cnc.Inserta_nuevo_dibujo_cnc_base_datos(dibujos_cnc_insertar);
            //Dibujos_produccion_disponible[0].Estado = "Iniciado";
            //Class_Dibujos_Produccion.Actualiza_base_datos_dibujo_produccion(Dibujos_produccion_disponible[0]);
            //Genera_secuencia_produccion_iniciar_transaccion();
            Cancela_operacio_produccion();
            //Elimina_informacion_secuencia_disponibles();

        }

        private void Genera_secuencia_produccion_iniciar_transaccion()
        {
            Asigna_valores_variable_secuencia_produccion_iniciar();
            Class_Secuencia_Produccion.Inserta_nuevo_secuencia_produccion_base_datos(Secuencia_produccion_insertar);
        }

        private void Asigna_valores_variable_secuencia_produccion_iniciar()
        {
            CultureInfo culture = new CultureInfo("es-MX");
            Secuencia_produccion_insertar.Numero_Dibujo = textBoxNumeroDibujo.Text;
            Secuencia_produccion_insertar.Empleado = comboBoxEmpleado.Text;
            Secuencia_produccion_insertar.inicio_proceso = DateTime.Now.ToString(culture);
            Secuencia_produccion_insertar.final_proceso = "";
            Secuencia_produccion_insertar.proceso = textBoxNombreProceso.Text;
            Secuencia_produccion_insertar.estado = "Iniciado";
            Secuencia_produccion_insertar.calidad = textBoxProyecto.Text;

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
            Limpia_datagridview_secuencia_produccion();
            Aparece_datagrid_secuencia_produccion();
            Desabilita_boton_busqueda_dibujo();
            Deactiva_boton_visualizar();
            Desactiva_Combo_codigo_empleado();
            Activa_boton_cancelar_operacio();
            if (obtener_dibujos_produccio_disponibles())
            {
                Asigna_valores_forma_secuencia_produccion();
                Rellena_datagridview_secuencias_produccion();
            }
        }

        private void Aparece_datagrid_secuencia_produccion()
        {
            dataGridViewSecuenciasProduccion.Visible = true;
        }

        private void Desaparece_datagrid_secuencia_produccion()
        {
            dataGridViewSecuenciasProduccion.Visible = false;
        }

        private void Deactiva_boton_visualizar()
        {
            buttonBuscarSecuenciaDibujo.Enabled=false;
        }

        private void Asigna_valores_forma_secuencia_produccion()
        {
            textBoxFechaInicio.Text = Dibujos_produccion_disponible[0].Horas_produccion;
            textBoxNombreProceso.Text = Dibujos_produccion_disponible[0].Proceso;
            textBoxEstado.Text = Dibujos_produccion_disponible[0].Estado;
            textBoxProyecto.Text = Dibujos_produccion_disponible[0].Calidad;
            textBoxFechaFinal.Text = Dibujos_produccion_disponible[0].Horas_retrabajo;
        }
    }
}
 