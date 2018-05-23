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
    public partial class Forma_Captura_Produccion : Form
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
        public Forma_Captura_Produccion()
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

        private void buttonTerminarProceso_Click(object sender, EventArgs e)
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
                "' where codigo_proceso='" + textBoxEmpleado.Text + "';";
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
                "VALUES('" + textBoxEmpleado.Text + "','" + textBoxNombreProceso.Text  + "');";
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

        private void buttonPausaProceso_Click(object sender, EventArgs e)
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

        private void Secuencia_usuarios_produccion()
        {
            Obtener_usuarios_produccion();
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

        private void Obtener_usuarios_produccion()
        {
            Empleados_produccion_disponibles = Class_Usuarios.Adquiere_usuarios_produccion_disponibles_en_base_datos();
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

        private void buttonBuscarDibujo_Click(object sender, EventArgs e)
        {
            buscar_dubujo_base_datos();
        }

        private void buscar_dubujo_base_datos()
        {
            if (obtener_dibujos_disponibles_base_datos())
            {
                Busca_dibujo_produccion_base_datos();
                //Secuencia_operacion_produccion();
            }
            else
                Cancela_operacio_produccion();

        }

        private void Busca_dibujo_produccion_base_datos()
        {
            if (Dibujo_existe_base_datos_produccion() == false)
            {
                Inserta_nuevo_registro_dibujos_produccion_base_datos();
            }
            Configura_botones_operacion();

        }

        private bool Dibujo_existe_base_datos_produccion()
        {

            obtener_dibujos_produccio_disponibles();
            if (Dibujos_produccion_disponible.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void obtener_dibujos_produccio_disponibles()
        {
            Dibujos_produccion_disponible = Class_Dibujos_Produccion.Adquiere_agregar_materiales_busqueda_en_base_datos(textBoxNumeroDibujo.Text);
            
        }

        private void Configura_botones_operacion()
        {
            throw new NotImplementedException();
        }

        private void Inserta_nuevo_registro_dibujos_produccion_base_datos()
        {
            Asigna_valores_dibujo_produccion();
            Class_Dibujos_Produccion.Inserta_nuevo_dibujo_produccion_base_datos(Dibujos_produccion_insertar);
        }

        private void Asigna_valores_dibujo_produccion()
        {
            Dibujos_produccion_insertar.Numero_dibujo = textBoxNumeroDibujo.Text;
            Dibujos_produccion_insertar.proyecto=Dibujos_proyectos_disponibles[0].Codigo_proyecto;
            Dibujos_produccion_insertar.Proceso = Dibujos_proyectos_disponibles[0].proceso;
            Dibujos_produccion_insertar.Calidad = "";
        }

        private void Secuencia_operacion_produccion()
        {
            Visualiza_proceso();
        }

        private void Cancela_operacio_produccion()
        {
            throw new NotImplementedException();
        }

        private bool obtener_dibujos_disponibles_base_datos()
        {
            Dibujos_proyectos_disponibles = Class_Dibujos_Proyecto.Adquiere_dibujos_disponibles_en_base_datos(textBoxNumeroDibujo.Text);
            if(Dibujos_proyectos_disponibles.Count > 1 )
            {
                MessageBox.Show("Numeo de dibujo Duplicado", "Busqueda Numero Dibujo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if(Dibujos_proyectos_disponibles.Count < 1)
            {
                MessageBox.Show("Numeo de dibujo No existe", "Busqueda Numero Dibujo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
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

        private void buttonIncioProceso_Click(object sender, EventArgs e)
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

        private void textBoxNombreProceso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 