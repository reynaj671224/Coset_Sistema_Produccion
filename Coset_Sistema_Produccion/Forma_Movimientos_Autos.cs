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
        public Auto auto_seleccion = new Auto();
        public Class_Proveedores Class_Proveedores = new Class_Proveedores();
        public List<Proveedor> Proveedores_disponibles = new List<Proveedor>();
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
        public Class_Movimientos_Autos Class_Movimientos_Autos = new Class_Movimientos_Autos();
        public List<Movimiento_auto> Movimientos_auto_en_uso_disponibles = new List<Movimiento_auto>();
        public List<Movimiento_auto> Movimientos_auto_visualizar_disponibles = new List<Movimiento_auto>();
        public Movimiento_auto Movimiento_salida = new Movimiento_auto();
        public Movimiento_auto Movimiento_entrada = new Movimiento_auto();
        public Movimiento_auto Movimiento_visualizar = new Movimiento_auto();

        public string Operacion_autos = "";

        enum Empleados
        {
            nombre, acceso_auto
        };
        enum Movimientos
        {
            codigo,hora_salida,fecha_salida,hora_entrada,fecha_entrada,compania,contacto,estado,empeados
        };
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

        private void buttonBuscarMovimientos_Click(object sender, EventArgs e)
        {
            Visualiza_Movimientos();
        }

        private void Visualiza_Movimientos()
        {
            Operacion_autos = "Visualizar";
            Desactiva_botones_operacion();
            Desaparece_caja_descripcion_auto();
            Aparece_combo_descrpcion_auto();
            Activa_combo_descripcion_auto();
            Obtener_datos_autos_disponibles_base_datos();
            Rellena_combo_auto_descripcion();
            Aparece_boton_cancelar_operacio();
            Activa_datagridview_movimiento_autos();
           
            
        }

        private void Desactiva_datagridview_movimiento_autos()
        {
            dataGridViewMovimientosAutos.Enabled = false;
        }

        private void Activa_datagridview_movimiento_autos()
        {
            dataGridViewMovimientosAutos.Enabled = true;
        }

        private void Rellena_combo_auto_descripcion()
        {
            foreach (Auto auto in autos_disponibles)
            {
                if (auto.error == "")
                {
                    if (Operacion_autos == "Salida")
                    {
                        if (auto.Status != "Usando")
                        {
                            comboBoxAutoDescripcion.Items.Add(auto.Descripcion);
                        }
                    }
                    else if(Operacion_autos == "Entrada")
                    {
                        if (auto.Status == "Usando")
                        {
                            comboBoxAutoDescripcion.Items.Add(auto.Descripcion);
                        }
                    }
                    else if (Operacion_autos == "Visualizar")
                    {
                        comboBoxAutoDescripcion.Items.Add(auto.Descripcion);
                    }
                }
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
            Limpia_combo_descripcion_auto();
            Limpia_combo_contactos_cliente_proveedor();
            Limpia_cajas_captura_despues_de_agregar_cliente();
            Limpia_datagridview_texto_empleados();
            Limpia_datagridview_movimiento_autos();
            Desactiva_datagridview_movimiento_autos();
            Desactiva_cajas_captura_despues_de_agregar_cliente();
            Desaparece_boton_guardar_base_de_datos();
            Desaparece_boton_cancelar();
            Desaparece_combo_cliente_proveedor();
            Desaparece_combo_descripcion_auto();
            Desaparece_combo_contacto_cliente_proveedor();
            Activa_botones_operacion();
            Aparece_caja_codigo_empleado();
            Aparece_caja_nombre_cliente();
            Desactiva_seleccion_fecha();
            Desactiva_seleccion_hora();
            Elimina_informacion_auto_disponibles();
            
        }

        private void Limpia_datagridview_texto_empleados()
        {
            foreach (DataGridViewRow renglon in dataGridViewEmpleadosAuto.Rows)
            {
                renglon.Cells[(int)Empleados.nombre].Value = null;
                renglon.Cells[(int)Empleados.acceso_auto].Value = null;
            }
        }

        private void Desaparece_combo_contacto_cliente_proveedor()
        {
            comboBoxContactoClienteProveedor.Visible = false;
        }

        private void Aparece_caja_nombre_cliente()
        {
            textBoxAutoDescripcion.Visible=true;
        }

        private void Desaparece_combo_descripcion_auto()
        {
            comboBoxAutoDescripcion.Visible = false;
        }

        private void Limpia_combo_descripcion_auto()
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
                configura_forma_salida_clientes_proveedores();
            else if (Operacion_autos == "Entrada")
                configura_forma_entrada();
        }

        private void configura_forma_salida_clientes_proveedores()
        {
            
            Obtener_contactos_clientes_provedores_disponibles();
            Rellena_combo_contactos_clientes();

        }

        private void Desactiva_combo_nombre_cliente()
        {
            comboBoxAutoDescripcion.Enabled=false;
        }

        private void configura_forma_visualizar()
        {
            Obtener_usuarios_disponibles_base_datos();
            Limpia_combo_nombre_empleado_en_datagridview();
            Limpia_datagridview_movimiento_autos();
            Rellenar_combo_usuarios_datagridview();
            Obtener_movimientos_visualizar_base_datos();
            Rellenar_datagridview_movimientos_autos();
        }

        private void Obtener_movimientos_visualizar_base_datos()
        {
            Movimientos_auto_visualizar_disponibles = Class_Movimientos_Autos.Adquiere_movimientos_autos_busqueda_en_base_datos(comboBoxAutoDescripcion.Text);
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
            Limpia_combo_cliente_proveedor();
            Aparece_combo_cliente_proveedor();
            Activa_combo_cliente_proveedor();
            Obtener_contactos_clientes_provedores_disponibles();
            Rellenar_combo_clientes();
            Activa_datagridview_empleados();
            Obtener_usuarios_disponibles_base_datos();
            Limpia_combo_nombre_empleado_en_datagridview();
            Rellenar_combo_usuarios_datagridview();
            Limpia_datagridview_movimiento_autos();
            Limpia_combo_contactos_cliente_proveedor();
            Aparece_combo_contacto_cliente_proveedor();
            Activa_combo_contacto_cliente_proveedor();


        }

        private void Activa_combo_contacto_cliente_proveedor()
        {
            comboBoxContactoClienteProveedor.Enabled = true;
        }

        private void Aparece_combo_contacto_cliente_proveedor()
        {
            comboBoxContactoClienteProveedor.Visible = true;
        }

        private void Limpia_combo_contactos_cliente_proveedor()
        {
            comboBoxContactoClienteProveedor.Items.Clear();
            comboBoxContactoClienteProveedor.Text = "";
        }

        private void Rellena_combo_contactos_clientes()
        {
            if (labelClienteProveedor.Text == "Nombre Cliente")
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
            else if(labelClienteProveedor.Text == "Nombre Proveedor")
            {
                foreach (Contacto_proveedor proveedor in Contactos_proveedor_disponibles)
                {
                    if (proveedor.error == "")
                        comboBoxContactoClienteProveedor.Items.Add(proveedor.Nombre);
                    else
                    {
                        MessageBox.Show(proveedor.error);
                        break;
                    }
                }
            }

        }

        private void Obtener_contactos_clientes_provedores_disponibles()
        {
            if (labelClienteProveedor.Text == "Nombre Cliente" && comboBoxClienteProveedor.Text!="")
            {
                Cliente_seleccionado = Clientes_disponibles.Find(cliente => cliente.Nombre.Contains(comboBoxClienteProveedor.SelectedItem.ToString()));
                Contactos_clientes_disponibles = Class_Contactos_Clientes.Adquiere_contactos_cliente_disponibles_en_base_datos(Cliente_seleccionado.Codigo);
            }
            else if(labelClienteProveedor.Text == "Nombre Proveedor" && comboBoxClienteProveedor.Text!="")
            {
                Proveedor_seleccion = Proveedores_disponibles.Find(proveedores => proveedores.Nombre.Contains(comboBoxClienteProveedor.SelectedItem.ToString()));
                Contactos_proveedor_disponibles = Class_Contactos_Proveedor.Adquiere_contactos_proveedores_disponibles_en_base_datos(Proveedor_seleccion.Codigo);
            }
        }

        private void Aparece_boton_eliminar_datos_en_base_de_datos()
        {
            buttonBorrarBasedeDatos.Visible = true;
        }

        private void configura_forma_entrada()
        {
            Obtener_usuarios_disponibles_base_datos();
            Limpia_combo_nombre_empleado_en_datagridview();
            Limpia_datagridview_movimiento_autos();
            Rellenar_combo_usuarios_datagridview();
            Obtener_autos_en_uso_con_descripcion();
            Rellenar_datagridview_movimientos_autos();
            Rellena_datagridview_empleados();
            Aparce_boton_guardar_base_datos();

        }

        private void Rellena_datagridview_empleados()
        {
            string[] empleados_responsabilidad = null;
            string[] empleados_individuales = null;
            int renglon_datagridview_empleados = 0;

            try
            {
                foreach (Movimiento_auto movimiento in Movimientos_auto_en_uso_disponibles)
                {
                    empleados_responsabilidad = movimiento.Empleados.Split(',');
                    foreach (string empleados in empleados_responsabilidad)
                    {
                        if (empleados != "")
                        {
                            empleados_individuales = empleados.Split(':');
                            dataGridViewEmpleadosAuto[(int)Empleados.nombre, renglon_datagridview_empleados].Value
                                = empleados_individuales[(int)Empleados.nombre];
                            if (empleados_individuales[(int)Empleados.acceso_auto] == "R")
                            {
                                dataGridViewEmpleadosAuto[(int)Empleados.acceso_auto, renglon_datagridview_empleados].Value
                                    = "Responsable";
                            }
                            else if (empleados_individuales[(int)Empleados.acceso_auto] == "A")
                            {
                                dataGridViewEmpleadosAuto[(int)Empleados.acceso_auto, renglon_datagridview_empleados].Value
                                    = "Acompañante";
                            }
                            else
                            {
                                MessageBox.Show("Problemas con el tipo de usuario de auto", "Entrada Auto",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            renglon_datagridview_empleados++;
                        }
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Rellenar_datagridview_movimientos_autos()
        {
            if (Operacion_autos == "Entrada")
            {
                foreach (Movimiento_auto movimiento in Movimientos_auto_en_uso_disponibles)
                {
                    dataGridViewMovimientosAutos.Rows.Add(movimiento.Codigo, movimiento.Hora_salida, movimiento.Fecha_salida,
                    movimiento.Hora_entrada, movimiento.Fecha_entrada, movimiento.Nombre_visita, movimiento.Nombre_contacto, movimiento.Status, movimiento.Empleados);
                }
            }
            else if(Operacion_autos == "Visualizar")
            {
                foreach (Movimiento_auto movimiento in Movimientos_auto_visualizar_disponibles)
                {
                    dataGridViewMovimientosAutos.Rows.Add(movimiento.Codigo, movimiento.Hora_salida, movimiento.Fecha_salida,
                    movimiento.Hora_entrada, movimiento.Fecha_entrada, movimiento.Nombre_visita, movimiento.Nombre_contacto, movimiento.Status, movimiento.Empleados);
                }
            }
        }

        private void Obtener_autos_en_uso_con_descripcion()
        {
            Movimientos_auto_en_uso_disponibles = 
                Class_Movimientos_Autos.Adquiere_movimientos_autos_en_uso_busqueda_en_base_datos(comboBoxAutoDescripcion.Text);
            if (Movimientos_auto_en_uso_disponibles.Count > 1)
            {
                MessageBox.Show("Existen Mas de una salida de este Auto", "Entrada Autos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void buttonEntradaAuto_Click(object sender, EventArgs e)
        {
            Entrada_auto();
        }


        private void Entrada_auto()
        {
            Operacion_autos = "Entrada";
            Desactiva_botones_operacion();
            Desaparece_caja_descripcion_auto();
            Aparece_combo_descrpcion_auto();
            Activa_combo_descripcion_auto();
            Obtener_datos_autos_disponibles_base_datos();
            Rellena_combo_auto_descripcion();
            Aparece_boton_cancelar_operacio();
            Activa_seleccion_fecha();
            Activa_seleccion_hora();
            

        }


        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos_agreagar_auto()
        {
            timerMovimientosAuto.Enabled = true;
        }

        private void Activa_cajas_informacion_auto()
        {
            textBoxAutoDescripcion.Enabled = true;
            textBoxContactoClienteProveedor.Enabled = true;
            if (Operacion_autos == "Agregar")
            {
                textBoxClienteProveedor.Enabled = true;
            }
        }


        private void timerMovimientosAuto_Tick(object sender, EventArgs e)
        {

            if (comboBoxContactoClienteProveedor.Text != "" &&
                comboBoxAutoDescripcion.Text != "" &&
                comboBoxContactoClienteProveedor.Text != "" &&
                dataGridViewEmpleadosAuto[0, 0].Value != null)
            {
                timerMovimientosAuto.Enabled = false;
                buttonGuardarBasedeDatos.Visible = true;
            }
        }

        private void buttonGuardarBasedeDatos_Click(object sender, EventArgs e)
        {
 
            if(Operacion_autos == "Salida")
                secuencia_guarda_salida();
            else if(Operacion_autos == "Entrada")
                secuencia_guarda_entrada();
        }

        private void secuencia_guarda_entrada()
        {
            Asigna_valores_datos_entrada_autos();
            if (Actializa_datos_entrada())
            {
                if (Asigna_usando_status_auto())
                {
                    Limpia_combo_cliente_proveedor();
                    Limpia_combo_descripcion_auto();
                    Limpia_combo_contactos_cliente_proveedor();
                    Limpia_cajas_captura_despues_de_agregar_cliente();
                    Limpia_datagridview_texto_empleados();
                    Limpia_datagridview_movimiento_autos();
                    Desactiva_cajas_captura_despues_de_agregar_cliente();
                    Desaparece_boton_guardar_base_de_datos();
                    Desaparece_boton_cancelar();
                    Desaparece_combo_cliente_proveedor();
                    Desaparece_combo_descripcion_auto();
                    Desaparece_combo_contacto_cliente_proveedor();
                    Activa_botones_operacion();
                    Aparece_caja_codigo_empleado();
                    Aparece_caja_nombre_cliente();
                    Desactiva_seleccion_fecha();
                    Desactiva_seleccion_hora();
                    Elimina_informacion_auto_disponibles();
                }
            }
        }

        private void Limpia_datagridview_movimiento_autos()
        {
            dataGridViewMovimientosAutos.Rows.Clear();
        }

        private bool Actializa_datos_entrada()
        {
            string respuesta = "";
            respuesta = Class_Movimientos_Autos.Actualiza_base_datos_movimiento_auto(Movimiento_entrada);
            if (respuesta == "NO errores")
            {
                return true;
            }
            else
            {
                MessageBox.Show(respuesta, "Entrada Autos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Asigna_valores_datos_entrada_autos()
        {
            Movimiento_entrada = Movimientos_auto_en_uso_disponibles.Find(movimiento => movimiento.Auto_descripcion.Contains(comboBoxAutoDescripcion.SelectedItem.ToString()));
            Movimiento_entrada.Fecha_entrada = dateTimePickerFecha.Text;
            Movimiento_entrada.Hora_entrada = TimePickerHora.Text;
            Movimiento_entrada.Status = "Entregado";

        }

        private void secuencia_guarda_salida()
        {
            Asigna_valores_de_cajas_variable_movimientos_autos();
            if(Guarda_datos_salida())
            {
                if (Asigna_usando_status_auto())
                {
                    Limpia_combo_cliente_proveedor();
                    Limpia_combo_descripcion_auto();
                    Limpia_combo_contactos_cliente_proveedor();
                    Limpia_cajas_captura_despues_de_agregar_cliente();
                    Limpia_datagridview_texto_empleados();
                    Desactiva_datagridview_movimiento_autos();
                    Desactiva_cajas_captura_despues_de_agregar_cliente();
                    Desaparece_boton_guardar_base_de_datos();
                    Desaparece_boton_cancelar();
                    Desaparece_combo_cliente_proveedor();
                    Desaparece_combo_descripcion_auto();
                    Desaparece_combo_contacto_cliente_proveedor();
                    Activa_botones_operacion();
                    Aparece_caja_codigo_empleado();
                    Aparece_caja_nombre_cliente();
                    Desactiva_seleccion_fecha();
                    Desactiva_seleccion_hora();
                    Elimina_informacion_auto_disponibles();
                }
            }
        }

        private void Desactiva_seleccion_hora()
        {
            TimePickerHora.Enabled=false;
        }

        private void Desactiva_seleccion_fecha()
        {
            dateTimePickerFecha.Enabled = false;
        }

        private bool Asigna_usando_status_auto()
        {
            auto_seleccion = autos_disponibles.Find(autos => autos.Descripcion.Contains(comboBoxAutoDescripcion.SelectedItem.ToString()));
            string respuesta = "";
            if(Operacion_autos == "Salida")
                auto_seleccion.Status = "Usando";
            else if(Operacion_autos == "Entrada")
                auto_seleccion.Status = "";
            respuesta = Class_Autos.Modifica_datos_auto(auto_seleccion);
            if(respuesta == "NO errores")
            {
                return true;
            }
            else
            {
                MessageBox.Show(respuesta, "Salida/Entrada Autos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool Guarda_datos_salida()
        {
            string respuesta = "";
            respuesta = Class_Movimientos_Autos.Inserta_nuevo_movimiento_auto_base_datos(Movimiento_salida);
            if(respuesta == "NO errores")
            {
                return true;
            }
            else
            {
                MessageBox.Show(respuesta, "Salida Autos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Asigna_valores_de_cajas_variable_movimientos_autos()
        {
            Movimiento_salida.Auto_descripcion = comboBoxAutoDescripcion.Text;
            Movimiento_salida.Fecha_salida = dateTimePickerFecha.Text;
            Movimiento_salida.Hora_salida = TimePickerHora.Text;
            Movimiento_salida.Nombre_visita = comboBoxClienteProveedor.Text;
            Movimiento_salida.Nombre_contacto = comboBoxContactoClienteProveedor.Text;
            Movimiento_salida.Status = "Usando";
            Movimiento_salida.Empleados = Contruye_cadena_empleados_en_auto();
        }

        private string Contruye_cadena_empleados_en_auto()
        {
            string Empleados = "";
            foreach(DataGridViewRow renglon in dataGridViewEmpleadosAuto.Rows)
            {
                if (renglon.Cells[0].Value != null)
                {
                    Empleados = Empleados + renglon.Cells[0].Value.ToString() + ":" + renglon.Cells[1].Value.ToString().Substring(0, 1) + ",";
                }
            }
            return Empleados;
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
            Proveedores_disponibles = null;
            Clientes_disponibles = null;
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

        private void Desaparece_combo_cliente_proveedor()
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
            textBoxAutoDescripcion.Enabled = false;;
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
            textBoxContactoClienteProveedor.Text = "";
        }

        private void buttonSalidaAuto_Click(object sender, EventArgs e)
        {
            Salida_auto();
        }

        private void Salida_auto()
        {
            Operacion_autos = "Salida";
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
                Rellenar_combo_clientes();
            }
           
            Aparece_combo_descrpcion_auto();
            Activa_combo_descripcion_auto();
            Obtener_datos_autos_disponibles_base_datos();
            Rellena_combo_auto_descripcion();
            Desactiva_botones_operacion();
            Aparece_boton_cancelar_operacio();
            Inicia_timer_movimiento_autos();
            Activa_seleccion_fecha();
            Activa_seleccion_hora();
            Operacion_autos = "Salida";
        }

        private void Activa_seleccion_hora()
        {
            TimePickerHora.Enabled=true;
            TimePickerHora.Value = DateTime.Now;
        }

        private void Activa_seleccion_fecha()
        {
            dateTimePickerFecha.Enabled = true;
        }

        private void Inicia_timer_movimiento_autos()
        {
            timerMovimientosAuto.Enabled = true;
        }

        private void Aparece_combo_cliente_proveedor()
        {
            comboBoxClienteProveedor.Visible = true;
        }

        private void Rellenar_combo_clientes()
        {
            if (labelClienteProveedor.Text == "Nombre Cliente")
            {
                foreach (Cliente cliente in Clientes_disponibles)
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
            else if(labelClienteProveedor.Text == "Nombre Proveedor")
            {
                foreach (Proveedor proveedor in Proveedores_disponibles)
                {
                    if (proveedor.error == "")
                        comboBoxClienteProveedor.Items.Add(proveedor.Nombre);
                    else
                    {
                        MessageBox.Show(proveedor.error);
                        break;
                    }
                }

            }
        }

        private void Obtener_proveedores_disponibles_base_datos()
        {
            Proveedores_disponibles = Class_Proveedores.Adquiere_proveedores_disponibles_en_base_datos();
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
            if (Operacion_autos == "Salida")
                configura_forma_salida();
            else if (Operacion_autos == "Entrada")
                configura_forma_entrada();
            else if (Operacion_autos == "Visualizar")
                configura_forma_visualizar();

        }

        private void comboBoxContactoClienteProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Activa_datagridview_empleados();
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

        private void dataGridViewMovimientosAutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Operacion_autos == "Visualizar")
            {
                Rellena_datagridview_empleados_visualizar(e.RowIndex);
            }
        }

        private void Rellena_datagridview_empleados_visualizar(int RowIndex)
        {
            string[] empleados_individuales = null;
            int renglon_datagridview_empleados = 0;
            string Empleados_asignados = dataGridViewMovimientosAutos[(int)Movimientos.empeados, RowIndex].
                Value.ToString();
            string[] Empleados_arreglo = Empleados_asignados.Split(',');
            try
            {
                foreach (string empleados in Empleados_arreglo)
                {
                    if (empleados != "")
                    {
                        empleados_individuales = empleados.Split(':');
                        dataGridViewEmpleadosAuto[(int)Empleados.nombre, renglon_datagridview_empleados].Value
                            = empleados_individuales[(int)Empleados.nombre];
                        if (empleados_individuales[(int)Empleados.acceso_auto] == "R")
                        {
                            dataGridViewEmpleadosAuto[(int)Empleados.acceso_auto, renglon_datagridview_empleados].Value
                                = "Responsable";
                        }
                        else if (empleados_individuales[(int)Empleados.acceso_auto] == "A")
                        {
                            dataGridViewEmpleadosAuto[(int)Empleados.acceso_auto, renglon_datagridview_empleados].Value
                                = "Acompañante";
                        }
                        else
                        {
                            MessageBox.Show("Problemas con el tipo de usuario de auto", "Entrada Auto",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        renglon_datagridview_empleados++;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
