﻿using System;
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
    public partial class Forma_Materiales : Form
    {
        public List<Proceso> procesos_disponibles = new List<Proceso>();
        public Class_Procesos clase_procesos = new Class_Procesos();
        public Proceso Proceso_Modificaciones = new Proceso();
        public Class_Control_Folios class_folio_disponible = new Class_Control_Folios();
        public Control_folio folio_disponible = new Control_folio();
        public string Operacio_procesos = "";
        public Forma_Materiales()
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

        private void buttonAgregarUsuario_Click(object sender, EventArgs e)
        {
            Agrega_proceso();
        }

        private void Agrega_proceso()
        {
            Asigna_codigo_proceso_foilio_disponible();
            Desactiva_botones_operacion();
            Aparece_caja_codigo_proceso();
            Desaparece_combo_nombre_proceso();
            Activa_cajas_informacion();
            Inicia_timer_para_asegurar_informacion_en_todos_los_campos();
            Activa_boton_cancelar_operacio();
            Operacio_procesos = "Agregar";
        }

        private void Asigna_codigo_proceso_foilio_disponible()
        {
            folio_disponible = class_folio_disponible.Obtener_informacion_control_folio_base_datos();
            textBoxCodigoProceso.Text = folio_disponible.Folio_procesos;
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

       
        private void Activa_caja_nombre_proceso()
        {
            textBoxNombreProceso.Enabled = true;
        }

        private void Activa_caja_codigo_proceso()
        {
            textBoxCodigoProceso.Enabled = true;
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
            Activa_caja_codigo_proceso();
            Activa_caja_nombre_proceso();
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
            if(textBoxCodigoProceso.Text!="" && textBoxNombreProceso.Text !="")
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
            if (Operacio_procesos == "Modificar")
                Secuencia_modificar_usuario();
            else if (Operacio_procesos == "Agregar")
                Secuencia_agregar_proceso();
        }

        private void Secuencia_agregar_proceso()
        {

            if (Guarda_datos_agregar_proceso())
            {
                Limpia_cajas_captura_despues_de_agregar_proceso();
                Limpia_combo_nombre_proceso();
                Desactiva_cajas_captura_despues_de_agregar_empleado();
                Desactiva_boton_guardar_base_de_datos();
                Desactiva_boton_cancelar();
                Desaparece_combo_nombre_proceso();
                Activa_botones_operacion();
                Aparece_caja_nombre_empleado();
                Asigna_nuevo_folio_proceso();
                Elimina_informacion_usuarios_disponibles();
            }
     
        }

        private void Asigna_nuevo_folio_proceso()
        {
            int numero_folio = Convert.ToInt32(folio_disponible.Folio_procesos.Substring(2, folio_disponible.Folio_procesos.Length - 2));
            numero_folio++;
            folio_disponible.Folio_procesos = folio_disponible.Folio_procesos.Substring(0, 2) + numero_folio.ToString();
            string respuesta = class_folio_disponible.Actualiza_Control_folios_base_datos(folio_disponible);
            if (respuesta != "")
                MessageBox.Show(folio_disponible.error);
        }

        private void Secuencia_modificar_usuario()
        {

            if (Guarda_datos_modificar_usuario())
            {
                Limpia_cajas_captura_despues_de_agregar_proceso();
                Limpia_combo_nombre_proceso();
                Desactiva_cajas_captura_despues_de_agregar_empleado();
                Desactiva_boton_guardar_base_de_datos();
                Desactiva_boton_cancelar();
                Desaparece_combo_nombre_proceso();
                Activa_botones_operacion();
                Aparece_caja_nombre_empleado();
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
            textBoxCodigoProceso.Enabled = false;
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
            textBoxCodigoProceso.Text = "";
        }

        private bool Guarda_datos_modificar_usuario()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_ingenieria_procesos());
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(Configura_cadena_comando_modificar_en_base_de_datos(), connection);
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

        private string Configura_cadena_comando_modificar_en_base_de_datos()
        {
            return "UPDATE procesos set  nombre_proceso='" + comboBoxNombreProceso.Text +
                "' where codigo_proceso='" + textBoxCodigoProceso.Text + "';";
        }

        private bool Guarda_datos_agregar_proceso()
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
            return "INSERT INTO procesos(codigo_proceso, nombre_proceso) " +
                "VALUES('" + textBoxCodigoProceso.Text + "','" + textBoxNombreProceso.Text  + "');";
        }

        private bool Elimina_datos_usuario()
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
            return "DELETE from procesos where nombre_proceso='" +
               comboBoxNombreProceso.Text + "';";
        }

        
        private string Configura_cadena_conexion_MySQL_ingenieria_procesos()
        {
            return "Server=" + Coset_Sistema_Produccion.ip_addres_server + ";Database=ingenieria;Uid=root;Pwd=" + Coset_Sistema_Produccion.password_server + ";";
        }

        private void buttonModificarUsuario_Click(object sender, EventArgs e)
        {
            Modifica_proceso();
        }

        private void Modifica_proceso()
        {
            Desactiva_botones_operacion();
            Desaparce_caja_nombre_proceso();
            Aparece_combo_nombre_proceso();
            Activa_combo_nombre_proceso();
            Obtener_datos_procesos_disponibles_base_datos();
            Rellenar_combo_nombre_proceso();
            Activa_boton_cancelar_operacio();
            Operacio_procesos = "Modificar";
        }

        private void Obtener_datos_procesos_disponibles_base_datos()
        {
            procesos_disponibles = clase_procesos.Adquiere_procesos_disponibles_en_base_datos();
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
            if (Operacio_procesos == "Modificar")
                configura_forma_modificar();
            else if (Operacio_procesos == "Eliminar")
                configura_forma_eliminar();
            else if (Operacio_procesos == "Visualizar")
                configura_forma_visualizar();


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
            comboBoxCodigoProceso.Enabled = false;
        }

        private void Rellena_cajas_informacion_de_proceso()
        {
            Proceso_Modificaciones = procesos_disponibles.Find(usuario => usuario.Nombre.Contains(comboBoxNombreProceso.SelectedItem.ToString()));

            textBoxCodigoProceso.Text = Proceso_Modificaciones.Codigo;
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
            Limpia_cajas_captura_despues_de_agregar_proceso();
            Limpia_combo_codigo_empleadlo();
            Limpia_combo_nombre_proceso();
            Desactiva_cajas_captura_despues_de_agregar_empleado();
            Desactiva_boton_guardar_base_de_datos();
            Desaparece_combo_nombre_proceso();
            Desaparece_combo_codigo_empleado();
            Desactiva_boton_cancelar();
            Desactiva_boton_eliminar_base_de_datos();
            Activa_botones_operacion();
            Activa_Combo_codigo_empleado();
            Aparece_caja_nombre_empleado();
            Aparece_caja_codigo_proceso();
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

        private void buttonEliminarUsuario_Click(object sender, EventArgs e)
        {
            Eliminar_usuarios();
            
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
                    Desactiva_cajas_captura_despues_de_agregar_empleado();
                    Desactiva_boton_eliminar_base_de_datos();
                    Desactiva_boton_cancelar();
                    Desaparece_combo_nombre_proceso();
                    Activa_botones_operacion();
                    Activa_Combo_codigo_empleado();
                    Aparece_caja_nombre_empleado();
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
            return Elimina_datos_usuario();
        }

        private void Eliminar_usuarios()
        {
            Desactiva_botones_operacion();
            Desaparce_caja_nombre_proceso();
            Aparece_combo_nombre_proceso();
            Activa_combo_nombre_proceso();
            Obtener_datos_procesos_disponibles_base_datos();
            Rellenar_combo_nombre_proceso();
            Activa_boton_cancelar_operacio();
            Inicia_timer_eliminar_usuario();
            Operacio_procesos = "Eliminar";
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

        private void buttonBuscarempleado_Click(object sender, EventArgs e)
        {
            Visualiza_proceso();
        }

        private void Visualiza_proceso()
        {
            Desactiva_botones_operacion();
            Desaparce_caja_nombre_proceso();
            Activa_combo_nombre_proceso();
            Aparece_combo_nombre_proceso();
            Obtener_datos_procesos_disponibles_base_datos();
            Rellenar_combo_nombre_proceso();
            Activa_boton_cancelar_operacio();
            Operacio_procesos = "Visualizar";
        }

        private void Activa_combo_nombre_proceso()
        {
            comboBoxNombreProceso.Enabled = true;
        }

        private void Rellenar_combo_nombre_proceso()
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

    }
}
 