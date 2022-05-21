﻿using System;
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
    public partial class Forma_Captura_Produccion : Form
    {
        public static bool Usuario_permitido_cerrar_operacion = false;
        public string forma_cerrada_por = "";
        public List<Proceso> procesos_disponibles = new List<Proceso>();
        public Class_Procesos clase_procesos = new Class_Procesos();
        public Proceso Proceso_Modificaciones = new Proceso();
        public Proceso Proceso_busqueda = new Proceso();
        public Class_Control_Folios class_folio_disponible = new Class_Control_Folios();
        public Control_folio folio_disponible = new Control_folio();
        public List<Usuario> Empleados_produccion_disponibles = new List<Usuario>();
        public Class_Usuarios Class_Usuarios = new Class_Usuarios();
        public Usuario Usuario_seeccion = new Usuario();
        public string Operacio_procesos = "";
        public List<Dibujos_proyecto> Dibujos_proyectos_disponibles = new List<Dibujos_proyecto>();
        public Class_Dibujos_Proyecto Class_Dibujos_Proyecto = new Class_Dibujos_Proyecto();
        public Dibujos_proyecto Dibujo_seleccion = new Dibujos_proyecto();
        public Dibujos_proyecto Dibujo_busqueda = new Dibujos_proyecto();
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
        public Class_Actividades_Proceso_Electrico Class_Actividades_Proceso_Electrico =
            new Class_Actividades_Proceso_Electrico();
        public List<Actividad_Proceso_Electrico> actividad_Proceso_Electricos_disponibles =
            new List<Actividad_Proceso_Electrico>();
        public Actividad_Proceso_Electrico Actividad_Proceso_Electrico_busqueda =
            new Actividad_Proceso_Electrico();
        public string secuencia_operacion = "";

        public Class_Fecha_Hora Fecha_Hora = new Class_Fecha_Hora();
        public Forma_Captura_Produccion()
        {
            InitializeComponent();
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            forma_cerrada_por = "boton_cancel";
            if (Coset_Sistema_Produccion.Tipo_Usuario == "Usuario-Produccion")
            {
                Forma_Produccion_Usuario forma_Produccion_Usuario = new Forma_Produccion_Usuario();
                forma_Produccion_Usuario.ShowDialog();

                if (Forma_Captura_Produccion.Usuario_permitido_cerrar_operacion == false)
                {

                }
                else
                {
                    Regresar_forma_principal();
                }
            }
            else
            {
                Regresar_forma_principal();
            }

        }

        private void Regresar_forma_principal()
        {
            procesos_disponibles = null;
            clase_procesos = null;
            Proceso_Modificaciones = null;
            actividad_Proceso_Electricos_disponibles = null; 
            Forma_Captura_Produccion.Usuario_permitido_cerrar_operacion = false;
            this.Dispose();
            GC.Collect();
            this.Close();
        }

        private void buttonTerminarProceso_Click(object sender, EventArgs e)
        {
            secuencia_operacion = "Terminar";
            Dibujos_produccion_disponible[0].Estado = "Terminado";
            Class_Dibujos_Produccion.Actualiza_base_datos_dibujo_produccion(Dibujos_produccion_disponible[0]);
            Genera_secuencia_produccion_terminar_transaccion();
            Cancela_operacio_produccion();
            Elimina_informacion_secuencia_disponibles();

        }

        private void Elimina_informacion_secuencia_disponibles()
        {
            Dibujos_proyectos_disponibles = null;
            Dibujos_produccion_disponible = null;
            Secuencias_produccion_disponibles = null;
            actividad_Proceso_Electricos_disponibles = null;
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
            if (textBoxNumeroDibujo.Text != "" && comboBoxNombreProceso.Text!="")
            {
                timerInciarProcesoBusqueda.Enabled = false;
                Activa_boton_buscar_dibujo_base_de_datos();
                //Activa_boton_visualizar_secuencia();
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
            if (Dibujos_produccion_disponible[0].Calidad == "Proceso")
            {
                try
                {
                    Dibujos_produccion_disponible[0].Horas_produccion =
                        (Convert.ToSingle(Dibujos_produccion_disponible[0].Horas_produccion) +
                        Convert.ToSingle(timeSpan.TotalMinutes / 60.0)).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (Dibujos_produccion_disponible[0].Calidad == "Re-trabajo" ||
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

            if (secuencia_operacion == "Terminar")
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
            Secuencia_produccion_busqueda.proceso = comboBoxNombreProceso.Text;
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
            Secuencia_usuarios_produccion();

        }

        protected void Forma_Captura_Produccion_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (forma_cerrada_por != "boton_cancel")
            {
                if (Coset_Sistema_Produccion.Tipo_Usuario == "Usuario-Produccion")
                {
                    Forma_Produccion_Usuario forma_Produccion_Usuario = new Forma_Produccion_Usuario();
                    forma_Produccion_Usuario.ShowDialog();

                    if (Forma_Captura_Produccion.Usuario_permitido_cerrar_operacion == false)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        Regresar_forma_principal();
                    }
                }
            }
        }

        private void Secuencia_usuarios_produccion()
        {
            Obtener_usuarios_produccion();
            Limpia_combo_empleados_produccion();
            Muestra_combo_empleados_produccion();
            Activa_Combo_codigo_empleado();
            Rellenar_combo_nombre_empleado();
            Limpia_combo_nombre_proceso();
            Obtener_datos_procesos_disponibles_base_datos();
            Rellena_combo_proceso_disponibles();

        }

        private void Rellena_combo_proceso_disponibles()
        {
            foreach (Proceso proceso in procesos_disponibles)
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

        private void Muestra_combo_empleados_produccion()
        {
            comboBoxEmpleado.Visible = true;
        }

        private void Limpia_combo_empleados_produccion()
        {
            comboBoxEmpleado.Items.Clear();
            comboBoxEmpleado.Text = "";
        }

        private void Obtener_usuarios_produccion()
        {
            Empleados_produccion_disponibles = Class_Usuarios.Adquiere_usuarios_produccion_disponibles_en_base_datos();
        }

        private void Habilita_combo_para_aceptar_buscar_elemento_escribiendo_en_ventana()
        {
            comboBoxNombreProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBoxNombreProceso.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxNombreProceso.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBoxEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBoxEmpleado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxEmpleado.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void comboBoxEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Operacio_procesos == "Visualizar_empleados")
            {
                Deactiva_boton_visualizar();
                Deactiva_boton_visualizar_empleados();
                Activa_boton_cancelar_operacio();
                Desactiva_botones_operacion();
                Limpia_datagridview_secuencia_produccion();
                obtener_dibujos_iniciados_pausados_por_empleado();
                Asigna_valores_datagridview_secuencias_produccion();
            }
            else
            {
                Activa_caja_numero_dibujo();
                Activa_combo_nombre_proceso();
                Inicia_timer_busqueda_dibujo();
                Deactiva_boton_visualizar();
                Deactiva_boton_visualizar_empleados();
                Activa_boton_cancelar_operacio();
                Desactiva_botones_operacion();
                Limpia_cajas_despues_combo_proceso_seleccion();
                Limpia_datagridview_secuencia_produccion();
            }

        }

        private void obtener_dibujos_iniciados_pausados_por_empleado()
        {
            Secuencias_produccion_disponibles.Clear();

            Secuencias_produccion_disponibles = Class_Secuencia_Produccion
                .Adquiere_secuencia_produccion_busqueda_dibujos_pendientes_empleados(comboBoxEmpleado.Text);


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
            if (textBoxNombreProceso.Text != Proceso_Modificaciones.Nombre)
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
            comboBoxNombreProceso.Visible = false;
        }

        private void buttonBuscarDibujo_Click(object sender, EventArgs e)
        {
            if (Operacio_procesos == "Visualizar")
            {
                Rellena_datagridview_secuencias_produccion();
                Deabilita_boton_busqueda_dibujo();
            }
            else
            {
                buscar_dibujo_proyectos_base_datos();
                Deabilita_boton_busqueda_dibujo();

            }
        }

        private void Deabilita_boton_busqueda_dibujo()
        {
            buttonBuscarDibujo.Enabled = false;
        }

        private void buscar_dibujo_proyectos_base_datos()
        {
            if (obtener_dibujos_Proyectos_disponibles_base_datos())
            {
                if (Busca_dibujo_produccion_base_datos())
                {
                    if (dibujo_esta_iniciado())
                    {
                        if (verifica_dibujo_asignado_empleado_solicitante())
                        {
                            if (verifica_dibujo_en_produccion())
                            {
                                Configura_botones_operacion();
                            }
                            else
                            {
                                Cancela_operacio_produccion();
                            }
                        }
                        else
                        {
                            Desactiva_botones_operacion();
                            Limpia_cajas_despues_combo_nombre_empleado_seleccion();
                            Limpia_datagridview_secuencia_produccion();
                        }
                    }
                    else
                    {
                        if (Asigna_dibujo_empleado())
                        {
                            if (verifica_dibujo_en_produccion())
                            {
                                Configura_botones_operacion();
                            }
                            else
                            {

                            }
                        }
                        else
                        {
                            Cancela_operacio_produccion();
                        }
                    }
                }
                else
                {
                    Configura_botones_operacion();
                }

            }
            else
            {
                Cancela_operacio_produccion();
            }


        }

        private bool Asigna_dibujo_empleado()
        {
            string Respuesta = "";
            Dibujos_produccion_disponible[0].Empleado = comboBoxEmpleado.Text;
            Respuesta = Class_Dibujos_Produccion.Actualiza_base_datos_dibujo_produccion(Dibujos_produccion_disponible[0]);
            if (Respuesta == "NO errores")
                return true;
            else
                return false;
        }

        private bool dibujo_esta_iniciado()
        {

            return Dibujos_produccion_disponible[0].Estado == "Iniciado";
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
            if ((Dibujos_produccion_disponible[0].Empleado == comboBoxEmpleado.Text))
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
            Dibujos_produccion_busqueda.Proceso = comboBoxNombreProceso.Text;
            Dibujos_produccion_busqueda.Empleado = comboBoxEmpleado.Text;
        }

        private void Configura_botones_operacion()
        {
            if (textBoxEstado.Text == "") /*La unidad ya esiste en la base de datos de produccion*/
            {
                textBoxCalidad.Text = Dibujos_produccion_disponible[0].Calidad;
                textBoxEstado.Text = Dibujos_produccion_disponible[0].Estado;
                textBoxNombreProceso.Text = Dibujos_produccion_disponible[0].Proceso;
                textBoxHorasProceso.Text = Dibujos_produccion_disponible[0].Horas_produccion;
                textBoxHorasRetrabajo.Text = Dibujos_produccion_disponible[0].Horas_retrabajo;
                textBoxUnidades.Text = Dibujos_proyectos_disponibles[0].Cantidad;
                textBoxTipoProceso.Text = Dibujos_proyectos_disponibles[0].Tipo_proceso;
                if (Dibujos_proyectos_disponibles[0].Tipo_proceso == "Electrico")
                {
                    Muestra_informacion_actividades_proceso_electrico();
                    textBoxActividadesProcesoElectrico.Text = Dibujos_proyectos_disponibles[0].Actividades_proceso_electrico;
                    Muestra_informacion_notas_actividades_prceso_electrico();
                    Busca_notas_activida_proceso_electrico(Dibujos_proyectos_disponibles[0].Actividades_proceso_electrico);
                    textBoxNotasActividad.Text = actividad_Proceso_Electricos_disponibles[0].Notas;
                }
            }
            else
            {
                Dibujos_produccion_disponible = Class_Dibujos_Produccion.
                    Adquiere_dibujos_produccion_busqueda_en_base_datos(Dibujos_produccion_insertar);
                if (Dibujos_produccion_disponible.Count == 1)
                {
                    textBoxNombreProceso.Text = Dibujos_produccion_disponible[0].Proceso;
                    textBoxHorasProceso.Text = Dibujos_produccion_disponible[0].Horas_produccion;
                    textBoxHorasRetrabajo.Text = Dibujos_produccion_disponible[0].Horas_retrabajo;
                    textBoxCalidad.Text = Dibujos_produccion_disponible[0].Calidad;
                    textBoxUnidades.Text = Dibujos_proyectos_disponibles[0].Cantidad;
                    textBoxTipoProceso.Text = Dibujos_proyectos_disponibles[0].Tipo_proceso;
                    if (Dibujos_proyectos_disponibles[0].Tipo_proceso == "Electrico")
                    {
                        Muestra_informacion_actividades_proceso_electrico();
                        textBoxActividadesProcesoElectrico.Text = Dibujos_proyectos_disponibles[0].Actividades_proceso_electrico;
                        Muestra_informacion_notas_actividades_prceso_electrico();
                        Busca_notas_activida_proceso_electrico(Dibujos_proyectos_disponibles[0].Actividades_proceso_electrico);
                        textBoxNotasActividad.Text = actividad_Proceso_Electricos_disponibles[0].Notas;
                    }
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

        private void Busca_notas_activida_proceso_electrico(string Actividad_prceso_elecgtrico)
        {
            actividad_Proceso_Electricos_disponibles = Class_Actividades_Proceso_Electrico.
                Adquiere_notas_actividad_procesos_disponibles_en_base_datos(Actividad_prceso_elecgtrico);
        }

        private void Muestra_informacion_notas_actividades_prceso_electrico()
        {
            Aparece_label_notas_actividad_proceso_electrico();
            Aparece_textbox_notas_actividades_proceso_electrico();
        }

        private void Aparece_textbox_notas_actividades_proceso_electrico()
        {
            textBoxNotasActividad.Visible = true;
        }

        private void Desaparece_textbox_notas_actividades_proceso_electrico()
        {
            textBoxNotasActividad.Visible = false;
        }

        private void Aparece_label_notas_actividad_proceso_electrico()
        {
            labelNotasActividad.Visible = true;
        }

        private void Desaparece_label_notas_actividad_proceso_electrico()
        {
            labelNotasActividad.Visible = false;
        }

        private void Muestra_informacion_actividades_proceso_electrico()
        {
            Aparece_label_actividad_proceso_electrico();
            Aparece_textbox_actividades_proceso_electrico();
        }

        private void Aparece_textbox_actividades_proceso_electrico()
        {
            textBoxActividadesProcesoElectrico.Visible = true;
        }
        private void Desaparece_textbox_actividades_proceso_electrico()
        {
            textBoxActividadesProcesoElectrico.Visible = false;
        }

        private void Aparece_label_actividad_proceso_electrico()
        {
            labelActividadesProcesoElectrico.Visible = true;
        }

        private void Desaparece_label_actividad_proceso_electrico()
        {
            labelActividadesProcesoElectrico.Visible = false;
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
            Activa_boton_visualizar();
            Activa_boton_visualizar_empleados();
            Activa_Combo_codigo_empleado();
            Limpia_combo_usuario();
            Limpia_seleccion_secuencia_operacion();
            Limpia_datagridview_secuencia_produccion();
            Desaparece_label_actividad_proceso_electrico();
            Desaparece_textbox_actividades_proceso_electrico();
            Desaparece_label_notas_actividad_proceso_electrico();
            Desaparece_textbox_notas_actividades_proceso_electrico();
            Limpia_combo_nombre_proceso_texto();
            Desactiva_combo_nombre_proceso();
        }

        private void Limpia_combo_nombre_proceso_texto()
        {
            comboBoxNombreProceso.Text = "";
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
            textBoxHorasProceso.Enabled = false;
            textBoxNombreProceso.Enabled = false;
            textBoxEstado.Enabled = false;
            textBoxCalidad.Enabled = false;
            textBoxHorasProceso.Enabled = false;
            textBoxHorasRetrabajo.Enabled = false;
        }

        private void Limpia_cajas_captura_despues_de_secuencia()
        {
            textBoxNumeroDibujo.Text = "";
            textBoxHorasProceso.Text = "";
            textBoxNombreProceso.Text = "";
            textBoxEstado.Text = "";
            textBoxCalidad.Text = "";
            textBoxHorasProceso.Text = "";
            textBoxHorasRetrabajo.Text = "";
            textBoxUnidades.Text = "";
            textBoxNotasActividad.Text = "";
            textBoxActividadesProcesoElectrico.Text = "";
            textBoxTipoProceso.Text = "";
        }

        private bool obtener_dibujos_Proyectos_disponibles_base_datos()
        {
            Assigna_valores_dibujo_proceso_busqueda();
              Dibujos_proyectos_disponibles = Class_Dibujos_Proyecto.
                Adquiere_dibujos_proceso_proyecto_disponibles_en_base_datos(Dibujo_busqueda);
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

        private void Assigna_valores_dibujo_proceso_busqueda()
        {
            Dibujo_busqueda.proceso = comboBoxNombreProceso.Text;
            Dibujo_busqueda.Numero = textBoxNumeroDibujo.Text;
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

            Dibujos_produccion_disponible[0].Estado = "Iniciado";
            Class_Dibujos_Produccion.Actualiza_base_datos_dibujo_produccion(Dibujos_produccion_disponible[0]);
            Genera_secuencia_produccion_iniciar_transaccion();
            Cancela_operacio_produccion();
            Elimina_informacion_secuencia_disponibles();

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
            Secuencia_produccion_insertar.calidad = textBoxCalidad.Text;

        }

        private void Activa_combo_nombre_proceso()
        {
            comboBoxNombreProceso.Enabled = true;
        }

        private void Desactiva_combo_nombre_proceso()
        {
            comboBoxNombreProceso.Enabled = false;
        }


        private void Rellenar_combo_nombre_empleado()
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


        private void ComboBoxNombreEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(!timerInciarProcesoBusqueda.Enabled)
            {
                timerInciarProcesoBusqueda.Enabled = true;
                Desactiva_botones_operacion();
                Limpia_cajas_despues_combo_proceso_seleccion();
                Limpia_datagridview_secuencia_produccion();
            }
        }

        private void Limpia_cajas_despues_combo_proceso_seleccion()
        {
           
            textBoxHorasProceso.Text = "";
            textBoxEstado.Text = "";
            textBoxCalidad.Text = "";
            textBoxHorasProceso.Text = "";
            textBoxHorasRetrabajo.Text = "";
            textBoxUnidades.Text = "";
            textBoxTipoProceso.Text = "";


        }

        private void Limpia_cajas_despues_combo_nombre_empleado_seleccion()
        {
            comboBoxEmpleado.Text = "";
            textBoxHorasProceso.Text = "";
            textBoxEstado.Text = "";
            textBoxCalidad.Text = "";
            textBoxHorasProceso.Text = "";
            textBoxHorasRetrabajo.Text = "";
            textBoxUnidades.Text = "";
            textBoxTipoProceso.Text = "";


        }

        private void buttonBuscarSecuenciaDibujo_Click(object sender, EventArgs e)
        {
            Operacio_procesos = "Visualizar";
            //Limpia_datagridview_secuencia_produccion();
            //Deabilita_boton_busqueda_dibujo();
            //Deactiva_boton_visualizar();
            //obtener_dibujos_produccio_disponibles();
            //Asigna_valores_forma_secuencia_produccion();
            //Rellena_datagridview_secuencias_produccion();
            Deactiva_boton_visualizar();
            Deactiva_boton_visualizar_empleados();
            Desactiva_Combo_codigo_empleado();
            Activa_caja_numero_dibujo();
            Activa_boton_cancelar_operacio();
            Activa_combo_nombre_proceso();
            Inicia_timer_busqueda_dibujo();
        }

        private void Deactiva_boton_visualizar()
        {
            buttonBuscarSecuenciaDibujo.Enabled=false;
        }

        private void Activa_boton_visualizar()
        {
            buttonBuscarSecuenciaDibujo.Enabled = true;
        }

        private void Deactiva_boton_visualizar_empleados()
        {
            buttonBuscarSecuenciaEmplados.Enabled = false;
        }

        private void Activa_boton_visualizar_empleados()
        {
            buttonBuscarSecuenciaEmplados.Enabled = true;
        }



        private void Asigna_valores_forma_secuencia_produccion()
        {
            textBoxHorasProceso.Text = Dibujos_produccion_disponible[0].Horas_produccion;
            textBoxNombreProceso.Text = Dibujos_produccion_disponible[0].Proceso;
            textBoxEstado.Text = Dibujos_produccion_disponible[0].Estado;
            textBoxCalidad.Text = Dibujos_produccion_disponible[0].Calidad;
            textBoxHorasRetrabajo.Text = Dibujos_produccion_disponible[0].Horas_retrabajo;
        }

        private void buttonBuscarSecuenciaEmplados_Click(object sender, EventArgs e)
        {
            Operacio_procesos = "Visualizar_empleados";
            Deactiva_boton_visualizar();
            Deactiva_boton_visualizar_empleados();
            Activa_boton_cancelar_operacio();
        }
    }
}
 