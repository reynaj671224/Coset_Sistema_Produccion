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
        public Auto auto_agregar = new Auto();
        public Class_Proveedores Class_Proveedores = new Class_Proveedores();
        public List<Proveedor> Proeveedores_disponibles = new List<Proveedor>();
        public Proveedor Proveedor_seleccion = new Proveedor();
        public Class_Contactos_Proveedor Class_Contactos_Proveedor = new Class_Contactos_Proveedor();
        public List<Contacto_proveedor> Contactos_proveedor_disponibles = new List<Contacto_proveedor>();
        public Class_Clientes Class_Clientes = new Class_Clientes();
        public List<Cliente> Clientes_disponibles = new List<Cliente>();
        public Cliente Cliente_seleccionado = new Cliente();
        public Class_Contactos_Clientes Class_Contactos_Clientes = new Class_Contactos_Clientes();
        public List<Contacto_cliente> Contactos_clientes_disponibles = new List<Contacto_cliente>();
        public Class_Usuarios Class_Usuarios = new Class_Usuarios();
        public List<Usuario> Usuarios_disponibles = new List<Usuario>();

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

        private void Activa_combo_cliente_proveedor()
        {
            comboBoxClienteProveedor.Enabled = true;
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
            comboBoxClienteProveedor.Visible = true;
        }

        private void Desaparece_caja_captura_placas_auto()
        {
            textBoxClienteProveedor.Visible = false;
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
            Limpia_combo_cliente_proveedor();
            Limpia_combo_nombre_cliente();
            Limpia_cajas_captura_despues_de_agregar_cliente();
            Limpia_combo_cliente_proveedor();
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
            textBoxClienteProveedor.Visible = true;
        }

        private void comboBoxCodigoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Operacion_autos == "Salida")
                configura_forma_salida();
            else if (Operacion_autos == "Entrada")
                configura_forma_entrada();
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
            //auto_busqueda = autos_disponibles.Find(autos => autos.Descripcion.Contains(comboBoxAutoDescripcion.SelectedItem.ToString()));

            //textBoxCodigoAutoPlacas.Text = auto_busqueda.Placas;
            //textBoxAutoColor.Text = auto_busqueda.Color;
            //textBoxAutoModelo.Text = auto_busqueda.Modelo;
            //textBoxAutoMarca.Text = auto_busqueda.Marca;
        }

        private void configura_forma_salida()
        {
            Limpia_combo_contactos_cleinte_proveedor();
            Aparece_combo_contacto_cliente_proveedor();
            Activa_combo_contacto_cliente_proveedor();
            Obtener_contactos_clientes_disponibles();
            Rellena_combo_contactos_clientes();
        }

        private void Activa_combo_contacto_cliente_proveedor()
        {
            comboBoxContactoClienteProveedor.Enabled = true;
        }

        private void Aparece_combo_contacto_cliente_proveedor()
        {
            comboBoxContactoClienteProveedor.Visible = true;
        }

        private void Limpia_combo_contactos_cleinte_proveedor()
        {
            comboBoxContactoClienteProveedor.Items.Clear();
            comboBoxContactoClienteProveedor.Text = "";
        }

        private void Rellena_combo_contactos_clientes()
        {
            foreach (Contacto_cliente contacto in Contactos_clientes_disponibles)
            {
                if (contacto.error == "")
                    comboBoxContactoClienteProveedor.Items.Add(contacto.Nombre);
                else
                {
                    MessageBox.Show(contacto.error);
                    break;
                }
            }

        }

        private void Obtener_contactos_clientes_disponibles()
        {
            Cliente_seleccionado = Clientes_disponibles.Find(cliente => cliente.Nombre.Contains(comboBoxClienteProveedor.SelectedItem.ToString()));
            Contactos_clientes_disponibles = Class_Contactos_Clientes.Adquiere_contactos_cliente_disponibles_en_base_datos(Cliente_seleccionado.Codigo);
        }

        private void Aparece_boton_eliminar_datos_en_base_de_datos()
        {
            buttonBorrarBasedeDatos.Visible = true;
        }

        private void configura_forma_entrada()
        {
            Rellena_cajas_informacion_de_clientes();
            Activa_cajas_informacion_auto();
            //Asigna_datos_en_cajas_a_variable();
            Aparce_boton_guardar_base_datos();
        }

        private void Aparce_boton_guardar_base_datos()
        {
            buttonGuardarBasedeDatos.Visible = true;
        }



        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos_modificar_clientes()
        {
            timerModificarClientes.Enabled = true;
        }

        private void Desactiva_combobox_codigo_clientes()
        {
            comboBoxClienteProveedor.Enabled = false;
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
            textBoxContactoClienteProveedor.Enabled = true;
            if (Operacion_autos == "Agregar")
            {
                textBoxClienteProveedor.Enabled = true;
            }
        }


        private void timerAgregarAuto_Tick(object sender, EventArgs e)
        {
            if (textBoxAutoDescripcion.Text != "" &&
            textBoxAutoColor.Text != "" &&
            textBoxAutoModelo.Text != "" &&
            textBoxContactoClienteProveedor.Text != "")
            {
                timerAgregarAuto.Enabled = false;
                buttonGuardarBasedeDatos.Visible = true;
            }
        }

        private void buttonGuardarBasedeDatos_Click(object sender, EventArgs e)
        {
 


        }





        private void Aparce_caja_descripcion_auto()
        {
            textBoxAutoDescripcion.Visible = true;
        }

        private void Aparce_caja_codigo_cliente()
        {
            textBoxClienteProveedor.Visible = true;
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
            comboBoxClienteProveedor.Visible = false;
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
            textBoxClienteProveedor.Enabled = false;
            textBoxAutoDescripcion.Enabled = false;
            textBoxAutoColor.Enabled = false;
            textBoxAutoModelo.Enabled = false;
            textBoxContactoClienteProveedor.Enabled = false;
        }

        private void Limpia_combo_cliente_proveedor()
        {
            comboBoxClienteProveedor.Items.Clear();
            comboBoxClienteProveedor.Text = "";
        }

        private void Limpia_cajas_captura_despues_de_agregar_cliente()
        {
            textBoxClienteProveedor.Text = "";
            textBoxAutoDescripcion.Text = "";
            textBoxAutoColor.Text = "";
            textBoxAutoModelo.Text = "";
            textBoxContactoClienteProveedor.Text = "";
        }

        private void buttonSalidaAuto_Click(object sender, EventArgs e)
        {
            Salida_auto();
        }

        private void Salida_auto()
        {
            Operacion_autos = "Salida";
            Aparece_combo_cliente_proveedor();
            Activa_combo_cliente_proveedor();

            DialogResult dialogResult = MessageBox.Show("La visita en el Auto es a un cliente?", "Salida Auto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                labelClienteProveedor.Text = "Nombre Cliente";
                Limpia_combo_cliente_proveedor();
                Obtener_clientes_disponibles_base_datos();
                Rellenar_combo_clientes();

            }
            else
            {
                labelClienteProveedor.Text = "Nombre Proveedor";
                Limpia_combo_cliente_proveedor();
                Obtener_proveedores_disponibles_base_datos();
            }

            Desactiva_botones_operacion();
            Desaparece_caja_descripcion_auto();
            Aparece_combo_descrpcion_auto();
            Activa_combo_descripcion_auto();
            Obtener_datos_autos_disponibles_base_datos();
            Rellena_combo_auto_descripcion();
            Aparece_boton_cancelar_operacio();
 
        }

        private void Aparece_combo_cliente_proveedor()
        {
            comboBoxClienteProveedor.Visible = true;
        }

        private void Rellenar_combo_clientes()
        {
            foreach(Cliente cliente in Clientes_disponibles)
            {
                if (cliente.error == "")
                    comboBoxClienteProveedor.Items.Add(cliente.Nombre);
                else
                {
                    MessageBox.Show(cliente.error);
                    break;
                }
            }
        }

        private void Obtener_proveedores_disponibles_base_datos()
        {
            throw new NotImplementedException();
        }

        private void Obtener_clientes_disponibles_base_datos()
        {
            Clientes_disponibles = Class_Clientes.Adquiere_clientes_disponibles_en_base_datos();
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
                configura_forma_salida();
            else if (Operacion_autos == "Eliminar")
                configura_forma_salida();
            else if (Operacion_autos == "Visualizar")
                configura_forma_visualizar();

        }

        private void comboBoxContactoClienteProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Activa_datagridview_empleados();
            //Limpia_datagridview_empleados();
            Obtener_usuarios_disponibles_base_datos();
            Limpia_combo_nombre_empleado_en_datagridview();
            Rellenar_combo_usuarios_datagridview();

           
        }

        private void Limpia_combo_nombre_empleado_en_datagridview()
        {
            Empleado_nombre.Items.Clear();
        }

        private void Rellenar_combo_usuarios_datagridview()
        {
            foreach (Usuario usario in Usuarios_disponibles)
            {
                if (usario.error == "")
                {
                    Empleado_nombre.Items.Add(usario.nombre_empleado);
                }
                else
                {
                    MessageBox.Show(usario.error);
                }

            }

        }

        private void Obtener_usuarios_disponibles_base_datos()
        {
            Usuarios_disponibles = Class_Usuarios.Adquiere_usuarios_disponibles_en_base_datos();
        }

        private void Limpia_datagridview_empleados()
        {
            dataGridViewEmpleadosAuto.Rows.Clear();
        }

        private void Activa_datagridview_empleados()
        {
            dataGridViewEmpleadosAuto.Enabled = true;
        }
    }
}
