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
    public partial class Forma_Movimientos_Autos : Form
    {
        public Class_Autos Class_Autos = new Class_Autos();
        public List<Auto> autos_disponibles = new List<Auto>();
        public Auto auto_modificacion = new Auto();
        public Auto auto_agregar = new Auto();
        public Auto auto_busqueda = new Auto();
        public Auto auto_eliminar = new Auto();
        public string Operacion_autos = "";

        public Forma_Movimientos_Autos()
        { 
            InitializeComponent();
        }

        private void Forma_Clientes_Load(object sender, EventArgs e)
        {
            Habilita_combo_para_aceptar_buscar_elemento_escribiendo_en_ventana();
            TimePickerHora.Format = DateTimePickerFormat.Time;
            TimePickerHora.ShowUpDown = true;
            Genera_lineas_empleados_datagridview();
            deshabilita_datagridview_empleados();
            

        }

        private void deshabilita_datagridview_empleados()
        {
            dataGridViewEmpleadosAuto.AllowUserToAddRows = false;
        }

        private void Genera_lineas_empleados_datagridview()
        {
           for(int renglon=0; renglon<5;renglon++)
            {
                dataGridViewEmpleadosAuto.Rows.Add();
            }
        }

        private void Habilita_combo_para_aceptar_buscar_elemento_escribiendo_en_ventana()
        {
            comboBoxAutoDescripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBoxAutoDescripcion.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxAutoDescripcion.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Elimina_informacion_auto_disponibles();
            this.Dispose();
            GC.Collect();
            this.Close();
        }

        private void buttonBuscarempleado_Click(object sender, EventArgs e)
        {
            Visualiza_cliente();
        }

        private void Visualiza_cliente()
        {
            Operacion_autos = "Visualizar";
            Desactiva_botones_operacion();
            Desaparece_caja_descripcion_auto();
            Aparece_combo_descrpcion_auto();
            Activa_combo_descripcion_auto();
            Obtener_datos_autos_disponibles_base_datos();
            Rellena_combo_auto_descripcion();
            Aparece_boton_cancelar_operacio();
            
        }

        private void Rellena_combo_auto_descripcion()
        {
            foreach (Auto auto in autos_disponibles)
            {
                if (auto.error == "")
                    comboBoxAutoDescripcion.Items.Add(auto.Descripcion);
                else
                {
                    MessageBox.Show(auto.error);
                    break;
                }
            }
        }

        private void Activa_combo_descripcion_auto()
        {
            comboBoxAutoDescripcion.Enabled = true;
        }

        private void Aparece_combo_descrpcion_auto()
        {
            comboBoxAutoDescripcion.Visible=true;
        }

        private void Desaparece_caja_descripcion_auto()
        {
            textBoxAutoDescripcion.Visible=false;
        }

        private void Activa_combo_codigo_cliente()
        {
            comboBoxCodigoAutoPlacas.Enabled = true;
        }

        private void Aparece_boton_cancelar_operacio()
        {
            buttonCancelar.Visible = true;
        }


        private void Obtener_datos_autos_disponibles_base_datos()
        {
            autos_disponibles = Class_Autos.Adquiere_autos_disponibles_en_base_datos();
        }

     

        private void Aparece_combo_placas_autos()
        {
            comboBoxCodigoAutoPlacas.Visible = true;
        }

        private void Desaparece_caja_captura_placas_auto()
        {
            textBoxCodigoAutoPlacas.Visible = false;
        }

        private void Desactiva_botones_operacion()
        {
            Desactiva_boton_agregar_auto();
            Desactiva_boton_modificar_auto();
            Desactiva_boton_visualizar_auto();
        }


        private void Desactiva_boton_visualizar_auto()
        {
            buttonBuscarMovimientos.Enabled = false;
        }

        private void Desactiva_boton_modificar_auto()
        {
            buttonSalidaAuto.Enabled = false;
        }

        private void Desactiva_boton_agregar_auto()
        {
            buttonEntradaAuto.Enabled = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Limpia_combo_codigo_cliente();
            Limpia_combo_nombre_cliente();
            Limpia_cajas_captura_despues_de_agregar_cliente();
            Limpia_combo_codigo_cliente();
            Desactiva_cajas_captura_despues_de_agregar_cliente();
            Desaparece_boton_guardar_base_de_datos();
            Desaparece_boton_cancelar();
            Desaparece_combo_codigo_cliente();
            Desaparece_combo_nombre_cliente();
            Activa_botones_operacion();
            Aparece_caja_codigo_empleado();
            Aparece_caja_nombre_cliente();
            Elimina_informacion_auto_disponibles();
        }

        private void Aparece_caja_nombre_cliente()
        {
            textBoxAutoDescripcion.Visible=true;
        }

        private void Desaparece_combo_nombre_cliente()
        {
            comboBoxAutoDescripcion.Visible = false;
        }

        private void Limpia_combo_nombre_cliente()
        {
            comboBoxAutoDescripcion.Items.Clear();
            comboBoxAutoDescripcion.Text = "";
        }

        private void Aparece_caja_codigo_empleado()
        {
            textBoxCodigoAutoPlacas.Visible = true;
        }

        private void comboBoxCodigoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Operacion_autos == "Modificar")
                configura_forma_modificar();
            else if (Operacion_autos == "Eliminar")
                configura_forma_eliminar();
            else if (Operacion_autos == "Visualizar")
                configura_forma_visualizar();

        }



        private void Desactiva_combo_nombre_cliente()
        {
            comboBoxAutoDescripcion.Enabled=false;
        }

        private void configura_forma_visualizar()
        { 
            Rellena_cajas_informacion_de_clientes();
        }

      

        private void Rellena_cajas_informacion_de_clientes()
        {
            auto_busqueda = autos_disponibles.Find(autos => autos.Descripcion.Contains(comboBoxAutoDescripcion.SelectedItem.ToString()));

            textBoxCodigoAutoPlacas.Text = auto_busqueda.Placas;
            textBoxAutoColor.Text = auto_busqueda.Color;
            textBoxAutoModelo.Text = auto_busqueda.Modelo;
            textBoxAutoMarca.Text = auto_busqueda.Marca;
        }

        private void configura_forma_eliminar()
        {
            Rellena_cajas_informacion_de_clientes();
            Aparece_boton_eliminar_datos_en_base_de_datos();
        }

        private void Aparece_boton_eliminar_datos_en_base_de_datos()
        {
            buttonBorrarBasedeDatos.Visible = true;
        }

        private void configura_forma_modificar()
        {
            Rellena_cajas_informacion_de_clientes();
            Activa_cajas_informacion_auto();
            Asigna_datos_en_cajas_a_variable();
            Aparce_boton_guardar_base_datos();
        }

        private void Aparce_boton_guardar_base_datos()
        {
            buttonGuardarBasedeDatos.Visible = true;
        }

        private void Asigna_datos_en_cajas_a_variable()
        {
            auto_modificacion.Descripcion = textBoxAutoDescripcion.Text;
            auto_modificacion.Color = textBoxAutoColor.Text;
            auto_modificacion.Modelo = textBoxAutoModelo.Text;
            auto_modificacion.Marca = textBoxAutoMarca.Text;

        }

        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos_modificar_clientes()
        {
            timerModificarClientes.Enabled = true;
        }

        private void Desactiva_combobox_codigo_clientes()
        {
            comboBoxCodigoAutoPlacas.Enabled = false;
        }

        private void buttonAgregarAuto_Click(object sender, EventArgs e)
        {
            Agrega_auto();
        }


        private void Agrega_auto()
        {
            Operacion_autos = "Agregar";
            Desactiva_botones_operacion();
            Activa_cajas_informacion_auto();
            Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_auto();
            Aparece_boton_cancelar_operacio();
            
        }


        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_auto()
        {
            timerAgregarAuto.Enabled = true;
        }

        private void Activa_cajas_informacion_auto()
        {
            textBoxAutoDescripcion.Enabled = true;
            textBoxAutoColor.Enabled = true;
            textBoxAutoModelo.Enabled = true;
            textBoxAutoMarca.Enabled = true;
            if (Operacion_autos == "Agregar")
            {
                textBoxCodigoAutoPlacas.Enabled = true;
            }
        }


        private void timerAgregarAuto_Tick(object sender, EventArgs e)
        {
            if (textBoxAutoDescripcion.Text != "" &&
            textBoxAutoColor.Text != "" &&
            textBoxAutoModelo.Text != "" &&
            textBoxAutoMarca.Text != "")
            {
                timerAgregarAuto.Enabled = false;
                buttonGuardarBasedeDatos.Visible = true;
            }
        }

        private void buttonGuardarBasedeDatos_Click(object sender, EventArgs e)
        {
            if (Operacion_autos == "Agregar")
                Secuencia_agregar_auto();
            else if (Operacion_autos == "Modificar")
                Secuencia_modificar_auto();

        }


        private void Secuencia_modificar_auto()
        {

            if (Modifica_datos_autos())
            {
                Limpia_cajas_captura_despues_de_agregar_cliente();
                Limpia_combo_nombre_cliente();
                Desactiva_cajas_captura_despues_de_agregar_cliente();
                Desaparece_boton_guardar_base_de_datos();
                Desaparece_boton_cancelar();
                Desaparece_combo_nombre_cliente();
                Aparce_caja_descripcion_auto();
                Activa_botones_operacion();
                Elimina_informacion_auto_disponibles();
            }

        }

        private bool Modifica_datos_autos()
        {
            string respuesta = "";
            Asigna_datos_modificar_auto();
            respuesta = Class_Autos.Modifica_datos_auto(auto_modificacion);
            if (respuesta == "NO errores")
            {
                return true;
            }
            else
            {
                MessageBox.Show(respuesta);
                return false;
            }
        }

        private void Asigna_datos_modificar_auto()
        {
            auto_modificacion.Marca = textBoxAutoMarca.Text;
            auto_modificacion.Descripcion = comboBoxAutoDescripcion.Text;
            auto_modificacion.Color = textBoxAutoColor.Text;
            auto_modificacion.Modelo = textBoxAutoModelo.Text;
            auto_modificacion.Placas = textBoxCodigoAutoPlacas.Text;

        }

        private void Aparce_caja_descripcion_auto()
        {
            textBoxAutoDescripcion.Visible = true;
        }

        private void Aparce_caja_codigo_cliente()
        {
            textBoxCodigoAutoPlacas.Visible = true;
        }

        private void Secuencia_agregar_auto()
        {
            if (Guarda_datos_auto())
            {
                Limpia_cajas_captura_despues_de_agregar_cliente();
                Limpia_combo_codigo_cliente();
                Desactiva_cajas_captura_despues_de_agregar_cliente();
                Desaparece_boton_guardar_base_de_datos();
                Desaparece_boton_cancelar();
                Desaparece_combo_codigo_cliente();
                Activa_botones_operacion();
                Elimina_informacion_auto_disponibles();
            }

        }

        private bool Guarda_datos_auto()
        {
            string respuesta = "";
            Asigna_datos_agregar_auto();
            respuesta = Class_Autos.Inserta_datos_auto(auto_modificacion);
            if(respuesta == "NO errores")
            {
                return true;
            }
            else
            {
                MessageBox.Show(respuesta);
                return false;
            }
        }

        private void Asigna_datos_agregar_auto()
        {
            auto_modificacion.Marca = textBoxAutoMarca.Text;
            auto_modificacion.Descripcion = textBoxAutoDescripcion.Text;
            auto_modificacion.Color = textBoxAutoColor.Text;
            auto_modificacion.Modelo = textBoxAutoModelo.Text;
            auto_modificacion.Placas = textBoxCodigoAutoPlacas.Text;
        }

        private void Elimina_informacion_auto_disponibles()
        {
            autos_disponibles = null;
            GC.Collect();
        }

        private void Activa_botones_operacion()
        {
            Activa_boton_agregar_cliente();
            Activa_boton_modificar_cliente();
            Activa_boton_visualizar_cliente();
        }

        private void Activa_boton_visualizar_cliente()
        {
            buttonBuscarMovimientos.Enabled = true;
        }


        private void Activa_boton_modificar_cliente()
        {
            buttonSalidaAuto.Enabled = true;
        }

        private void Activa_boton_agregar_cliente()
        {
            buttonEntradaAuto.Enabled = true;
        }

        private void Desaparece_combo_codigo_cliente()
        {
            comboBoxCodigoAutoPlacas.Visible = false;
        }

        private void Desaparece_boton_cancelar()
        {
            buttonCancelar.Visible = false;
        }

        private void Desaparece_boton_guardar_base_de_datos()
        {
            buttonGuardarBasedeDatos.Visible = false;
        }

        private void Desactiva_cajas_captura_despues_de_agregar_cliente()
        {
            textBoxCodigoAutoPlacas.Enabled = false;
            textBoxAutoDescripcion.Enabled = false;
            textBoxAutoColor.Enabled = false;
            textBoxAutoModelo.Enabled = false;
            textBoxAutoMarca.Enabled = false;
        }

        private void Limpia_combo_codigo_cliente()
        {
            comboBoxCodigoAutoPlacas.Items.Clear();
            comboBoxCodigoAutoPlacas.Text = "";
        }

        private void Limpia_cajas_captura_despues_de_agregar_cliente()
        {
            textBoxCodigoAutoPlacas.Text = "";
            textBoxAutoDescripcion.Text = "";
            textBoxAutoColor.Text = "";
            textBoxAutoModelo.Text = "";
            textBoxAutoMarca.Text = "";
        }

        private void buttonModificarCliente_Click(object sender, EventArgs e)
        {
            Modifica_clientes();
        }

        private void Modifica_clientes()
        {
            Operacion_autos = "Modificar";
            Desactiva_botones_operacion();
            Desaparece_caja_descripcion_auto();
            Aparece_combo_descrpcion_auto();
            Activa_combo_descripcion_auto();
            Obtener_datos_autos_disponibles_base_datos();
            Rellena_combo_auto_descripcion();
            Aparece_boton_cancelar_operacio();
            Activa_combo_codigo_cliente();
            
        }

        private void buttonEliminarCliente_Click(object sender, EventArgs e)
        {
            Operacion_autos = "Eliminar";
            Desactiva_botones_operacion();
            Desaparece_caja_descripcion_auto();
            Aparece_combo_descrpcion_auto();
            Activa_combo_descripcion_auto();
            Obtener_datos_autos_disponibles_base_datos();
            Rellena_combo_auto_descripcion();
            Aparece_boton_cancelar_operacio();
           
        }


        private void buttonAgregaContactosCliente_Click(object sender, EventArgs e)
        {
            Agrega_contactos_clientes();
        }

        private void Agrega_contactos_clientes()
        {
            Aparce_boton_guardar_base_datos();
            Operacion_autos = "Agregar Contactos";

        }


        private void buttonBorrarBasedeDatos_Click(object sender, EventArgs e)
        {


            if (Operacion_autos == "Eliminar")
                Elimina_auto();
        }

     
        private void Elimina_auto()
        {
            if (MessageBox.Show("Esta Seguro de Eiliminar Este Auto?",
                "Eliminar Auto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Elimina_informacion_auto_en_base_de_datos())
                {
                    Limpia_cajas_captura_despues_de_agregar_cliente();
                    Limpia_combo_nombre_cliente();
                    Desactiva_cajas_captura_despues_de_agregar_cliente();
                    Desaparece_boton_eliminar_base_de_datos();
                    Desaparece_boton_cancelar();
                    Desaparece_combo_nombre_cliente();
                    Activa_botones_operacion();
                    Elimina_informacion_auto_disponibles();
                    Aparce_caja_descripcion_auto();
                }
            }
        }

        private bool Elimina_informacion_auto_en_base_de_datos()
        {
            string respuesta = "";
            Asigna_datos_elimira_auto();
            respuesta = Class_Autos.Elimina_datos_auto(auto_eliminar);
            if (respuesta == "NO errores")
            {
                return true;
            }
            else
            {
                MessageBox.Show(respuesta);
                return false;
            }

        }

        private void Asigna_datos_elimira_auto()
        {
            auto_eliminar.Marca = textBoxAutoMarca.Text;
            auto_eliminar.Descripcion = comboBoxAutoDescripcion.Text;
            auto_eliminar.Color = textBoxAutoColor.Text;
            auto_eliminar.Modelo = textBoxAutoModelo.Text;
            auto_eliminar.Placas = textBoxCodigoAutoPlacas.Text;
        }

        private void Desaparece_boton_eliminar_base_de_datos()
        {
            buttonBorrarBasedeDatos.Visible = false;
        }


        private void buttonAgregarContacto_Click(object sender, EventArgs e)
        {
            Agrega_contactos_clientes();
        }

        private void comboBoxNombreCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Operacion_autos == "Modificar")
                configura_forma_modificar();
            else if (Operacion_autos == "Eliminar")
                configura_forma_eliminar();
            else if (Operacion_autos == "Visualizar")
                configura_forma_visualizar();

        }

        private void dataGridViewEmpleadosAuto_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                if (dataGridViewEmpleadosAuto.Rows.Count >= 5)
                {
                    //dataGridViewEmpleadosAuto.AllowUserToAddRows = false;
                    //dataGridViewEmpleadosAuto.Rows.RemoveAt(dataGridViewEmpleadosAuto.Rows.Count-1);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewEmpleadosAuto_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >5)
            {
                SendKeys.Send("{UP}");
            }
        }
    }
}
