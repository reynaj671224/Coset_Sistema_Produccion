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
using System.IO;

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
        string appPath = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
        public Class_Materiales class_materiales = new Class_Materiales();
        public Material Agregar_material = new Material();
        public Material Visualizar_material = new Material();
        public List<Material> Materiales_disponibles_busqueda = new List<Material>();
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
            Aparece_caja_codigo_proveedor();
            Desaparece_combo_codigo_material();
            Activa_cajas_informacion();
            Inicia_timer_para_asegurar_informacion_en_todos_los_campos();
            Activa_boton_cancelar_operacio();
            Operacio_procesos = "Agregar";
        }

        private void Asigna_codigo_proceso_foilio_disponible()
        {
            folio_disponible = class_folio_disponible.Obtener_informacion_control_folio_base_datos();
            textBoxCodigoMaterial.Text = folio_disponible.Folio_materiales;
        }

        private void Aparece_caja_codigo_proveedor()
        {
            textBoxCodigoMaterial.Visible = true;
        }

        private void Inicia_timer_para_asegurar_informacion_en_todos_los_campos()
        {
            timerAgregarMaterial.Enabled = true;
        }

        private void Activa_boton_guardar_base_de_datos()
        {
            buttonGuardarBasedeDatos.Visible = true;
        }

       
        private void Activa_caja_nombre_proceso()
        {
            textBoxCodigoProveedor.Enabled = true;
        }

        private void Activa_caja_codigo_proceso()
        {
            textBoxCodigoMaterial.Enabled = true;
        }

        private void Desactiva_botones_operacion()
        {
            Desactiva_boton_agregar_Material();
            Desactiva_boton_modificar_material();
            Desactiva_boton_visualizar_material();
        }

        private void Desactiva_boton_visualizar_material()
        {
            buttonBuscarMaterial.Enabled = false;
        }

        private void Activa_cajas_informacion()
        {
            textBoxCodigoProveedor.Enabled = true;
            textBoxDescripcion.Enabled = true;
            textBoxCantidad.Enabled = true;
            textBoxMinimo.Enabled = true;
            textBoxMaximo.Enabled = true;
            textBoxNombreFoto.Enabled = true;
            textBoxUnidadMedida.Enabled = true;
            textBoxMarca.Enabled = true;
            textBoxUbicacion.Enabled = true;
        }

        private void Desactiva_boton_buscar_base_datos()
        {
            buttonBusquedaBaseDatos.Enabled = false;
        }

        private void Desactiva_boton_modificar_material()
        {
            buttonModificarMaterial.Enabled = false;
        }

        private void Desactiva_boton_agregar_Material()
        {
            buttonAgregarMaterial.Enabled = false;
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
                Secuencia_agregar_material();
        }

        private void Secuencia_agregar_material()
        {

            if (Guarda_datos_agregar_Material())
            {
                Limpia_cajas_captura_despues_de_agregar_proceso();
                Desactiva_cajas_captura_despues_de_agregar_material();
                Desactiva_boton_guardar_base_de_datos();
                Desactiva_boton_cancelar();
                Desaparece_combo_codigo_material();
                Activa_botones_operacion();
                Aparece_caja_codigo_material();
                Desaparece_foto_material();
                Asigna_nuevo_folio_proceso();
                Elimina_informacion_materiales_disponibles();
            }
     
        }

        private void Desaparece_foto_material()
        {
            pictureBoxMaterial.Visible = false;
        }

        private void Asigna_nuevo_folio_proceso()
        {
            int numero_folio = Convert.ToInt32(folio_disponible.Folio_materiales.Substring(1, folio_disponible.Folio_materiales.Length - 1));
            numero_folio++;
            folio_disponible.Folio_materiales = folio_disponible.Folio_materiales.Substring(0, 1) + numero_folio.ToString();
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
                Desactiva_cajas_captura_despues_de_agregar_material();
                Desactiva_boton_guardar_base_de_datos();
                Desactiva_boton_cancelar();
                Desaparece_combo_codigo_material();
                Activa_botones_operacion();
                Aparece_caja_codigo_material();
                Elimina_informacion_materiales_disponibles();
            }    
            
        }

        private void Elimina_informacion_materiales_disponibles()
        {
            procesos_disponibles = null;
        }

        private void Limpia_combo_codigo_empleadlo()
        {
            comboBoxCodigoMaterial.Items.Clear();
            comboBoxCodigoMaterial.Text = "";
        }

        private void Activa_Combo_codigo_empleado()
        {
            comboBoxCodigoMaterial.Enabled = true;
        }

        private void Desaparece_combo_codigo_empleado()
        {
            comboBoxCodigoMaterial.Visible = false;
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
            buttonBuscarMaterial.Enabled = true;
        }

        private void Activa_boton_eliminar_usuarios()
        {
            buttonBusquedaBaseDatos.Enabled = true;
        }

        private void Activa_boton_modificar_usuarios()
        {
            buttonModificarMaterial.Enabled = true;
        }

        private void Activa_boton_agregar_usuarios()
        {
            buttonAgregarMaterial.Enabled = true;
        }

        private void Desactiva_boton_guardar_base_de_datos()
        {
            buttonGuardarBasedeDatos.Visible = false;
        }

        private void Desactiva_cajas_captura_despues_de_agregar_material()
        {
            textBoxCodigoProveedor.Enabled = false;
            textBoxDescripcion.Enabled = false;
            textBoxCantidad.Enabled = false;
            textBoxMinimo.Enabled = false;
            textBoxMaximo.Enabled = false;
            textBoxNombreFoto.Enabled = false;
            textBoxUnidadMedida.Enabled = false;
            textBoxMarca.Enabled = false;
            textBoxUbicacion.Enabled = false;
        }

        private void Desactiva_caja_nombre_proceso()
        {
            textBoxCodigoProveedor.Enabled = false;
        }

        private void Desactiva_caja_codigo_proceso()
        {
            textBoxCodigoMaterial.Enabled = false;
        }

        private void Limpia_cajas_captura_despues_de_agregar_proceso()
        {
            textBoxCodigoProveedor.Text = "";
            textBoxDescripcion.Text = "";
            textBoxCantidad.Text = "";
            textBoxMinimo.Text = "";
            textBoxMaximo.Text = "";
            textBoxNombreFoto.Text = "";
            textBoxUnidadMedida.Text = "";
            textBoxCodigoMaterial.Text = "";
            textBoxMarca.Text = "";
            textBoxUbicacion.Text = "";
        }

       

        private void Limpia_caja_nombre_proceso()
        {
            textBoxCodigoProveedor.Text = "";
        }

        private void Limpia_caja_codigo_proceso()
        {
            textBoxCodigoMaterial.Text = "";
        }

        private bool Guarda_datos_modificar_usuario()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_ingenieria_procesos());
            try
            {
                //connection.Open();
                //MySqlCommand command = new MySqlCommand(Configura_cadena_comando_modificar_en_base_de_datos(), connection);
                //command.ExecuteNonQuery();
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

        //private string Configura_cadena_comando_modificar_en_base_de_datos()
        //{
        //    //return "UPDATE procesos set  nombre_proceso='" + comboBoxNombreProceso.Text +
        //    //    "' where codigo_proceso='" + textBoxCodigoMaterial.Text + "';";
        //}

        private bool Guarda_datos_agregar_Material()
        {
            string respuesta = "";
            Agregar_material.Codigo = textBoxCodigoMaterial.Text;
            Agregar_material.Codigo_proveedor = textBoxCodigoProveedor.Text;
            Agregar_material.Descripcion = textBoxDescripcion.Text;
            Agregar_material.foto = textBoxNombreFoto.Text;
            Agregar_material.Unidad_medida = textBoxUnidadMedida.Text;
            Agregar_material.Cantidad = textBoxCantidad.Text;
            Agregar_material.Maximo = textBoxMaximo.Text;
            Agregar_material.Minimo = textBoxMinimo.Text;
            Agregar_material.Marca = textBoxMarca.Text;
            Agregar_material.Ubicacion = textBoxUbicacion.Text;
            
            respuesta = class_materiales.Inserta_nuevo_material_base_datos(Agregar_material);
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

        private string Configura_cadena_comando_insertar_en_base_de_datos()
        {
            return "INSERT INTO procesos(codigo_proceso, nombre_proceso) " +
                "VALUES('" + textBoxCodigoMaterial.Text + "','" + textBoxCodigoProveedor.Text  + "');";
        }

        private bool Elimina_datos_usuario()
        {
            MySqlConnection connection = new MySqlConnection(Configura_cadena_conexion_MySQL_ingenieria_procesos());
            try
            {
                //connection.Open();
                //MySqlCommand command = new MySqlCommand(Configura_cadena_comando_eliminar_en_base_de_datos(), connection);
                //command.ExecuteNonQuery();
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
        //private string Configura_cadena_comando_eliminar_en_base_de_datos()
        //{
        //    //return "DELETE from procesos where nombre_proceso='" +
        //    //   comboBoxNombreProceso.Text + "';";
        //}

        
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
            Obtener_datos_procesos_disponibles_base_datos();
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
            comboBoxCodigoMaterial.Visible = true;
        }

        private void Desaparece_caja_captura_codigo_empleado()
        {
            textBoxCodigoMaterial.Visible = false;
        }

        private void Forma_Usuarios_Load(object sender, EventArgs e)
        {
            Habilita_combo_para_aceptar_buscar_elemento_escribiendo_en_ventana();
        }

        private void Habilita_combo_para_aceptar_buscar_elemento_escribiendo_en_ventana()
        {
            //comboBoxNombreProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            //comboBoxNombreProceso.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //comboBoxNombreProceso.AutoCompleteSource = AutoCompleteSource.ListItems;
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
            //comboBoxNombreProceso.Enabled = false;
        }

        private void Inicia_timer_modificar_empleado()
        {
            timerActualizrempleado.Enabled = true;
        }

        private void Desactiva_Combo_codigo_empleado()
        {
            comboBoxCodigoMaterial.Enabled = false;
        }

        private void Rellena_cajas_informacion_de_proceso()
        {
            //Proceso_Modificaciones = procesos_disponibles.Find(usuario => usuario.Nombre.Contains(comboBoxNombreProceso.SelectedItem.ToString()));

            //textBoxCodigoMaterial.Text = Proceso_Modificaciones.Codigo;
        }

        private void timerActualizrempleado_Tick(object sender, EventArgs e)
        {
            if(textBoxCodigoProveedor.Text!= Proceso_Modificaciones.Nombre)
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
            Desactiva_cajas_captura_despues_de_agregar_material();
            Desactiva_boton_guardar_base_de_datos();
            Desaparece_combo_codigo_material();
            Desaparece_combo_codigo_empleado();
            Desactiva_boton_cancelar();
            Desactiva_boton_eliminar_base_de_datos();
            Activa_botones_operacion();
            Activa_Combo_codigo_empleado();
            Aparece_caja_codigo_material();
            Aparece_caja_codigo_proveedor();
        }

        private void Limpia_combo_nombre_proceso()
        {
            //comboBoxNombreProceso.Items.Clear();
            //comboBoxNombreProceso.Text = "";
        }

        private void Aparece_caja_codigo_material()
        {
            textBoxCodigoProveedor.Visible = true;
        }

        private void Desaparece_combo_codigo_material()
        {
            comboBoxCodigoMaterial.Visible=false;
        }

        private void buttonEliminarUsuario_Click(object sender, EventArgs e)
        {
            Desactiva_boton_buscar_base_datos();
            Obtener_datos_materiales_busqueda();
            if (Materiales_disponibles_busqueda.Count == 1)
            {

            }
            else if (Materiales_disponibles_busqueda.Count > 1)
            {
                Forma_Materiales_Seleccion forma_Materiales_Seleccion = new Forma_Materiales_Seleccion(Materiales_disponibles_busqueda);
                forma_Materiales_Seleccion.ShowDialog();
                textBoxCodigoMaterial.Text = forma_Materiales_Seleccion.Codigo_material_seleccionado;
            }
            else if(Materiales_disponibles_busqueda.Count ==  0)
            {


            }

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
                    Desactiva_cajas_captura_despues_de_agregar_material();
                    Desactiva_boton_eliminar_base_de_datos();
                    Desactiva_boton_cancelar();
                    Desaparece_combo_codigo_material();
                    Activa_botones_operacion();
                    Activa_Combo_codigo_empleado();
                    Aparece_caja_codigo_material();
                    Elimina_informacion_materiales_disponibles();
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
            //if (comboBoxNombreProceso.Text != "")
            //{
            //    timerEliminaempleado.Enabled = false;
            //    Activa_boton_borrar_ususraio_base_datos();
            //}
        }

        private void buttonBuscarempleado_Click(object sender, EventArgs e)
        {
            Visualiza_proceso();
        }

        private void Visualiza_proceso()
        {
            Desactiva_botones_operacion();
            Aparece_boton_busqueda_base_datos();
            Activa_cajas_de_informacion_visualizar();
            Activa_boton_cancelar_operacio();
            Operacio_procesos = "Visualizar";
        }

        private void Aparece_boton_busqueda_base_datos()
        {
            buttonBusquedaBaseDatos.Visible = true;
        }

        private void Obtener_datos_materiales_busqueda()
        {
            Asigna_datos_visualizar_material();
            Materiales_disponibles_busqueda = class_materiales.Adquiere_materiales_busqueda_en_base_datos(Visualizar_material);
        }

        private void Asigna_datos_visualizar_material()
        {
            Visualizar_material.Codigo = textBoxCodigoMaterial.Text;
            Visualizar_material.Codigo_proveedor = textBoxCodigoProveedor.Text;
            Visualizar_material.Descripcion = textBoxDescripcion.Text;

        }

        private void Activa_cajas_de_informacion_visualizar()
        {
            textBoxCodigoMaterial.Enabled = true;
            textBoxCodigoProveedor.Enabled = true;
            textBoxDescripcion.Enabled = true;
        }

        private void Desaparce_caja_nombre_proceso()
        {
            textBoxCodigoProveedor.Visible = false;
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

        private void TimerAgregarMaterial_Tick(object sender, EventArgs e)
        {
            if(textBoxCodigoMaterial.Text !="" && textBoxCodigoProveedor.Text!="" &&
               textBoxDescripcion.Text !="")
            {
                timerAgregarMaterial.Enabled = false;
                Activa_boton_guardar_base_de_datos();
            }
            
        }

        private void textBoxNombreFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog1.InitialDirectory = @appPath + "\\Fotos";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxNombreFoto.Text = openFileDialog1.SafeFileName;
                try
                {
                    Aparece_foto_material();
                    Carga_foto_selccionada();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Carga_foto_selccionada()
        {
            pictureBoxMaterial.Image = Image.FromFile(@appPath + "\\Fotos\\" +textBoxNombreFoto.Text);
        }

        private void Aparece_foto_material()
        {
            pictureBoxMaterial.Visible = true;
        }


    }
}
 