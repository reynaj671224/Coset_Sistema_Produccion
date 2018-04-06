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
        public Class_Procesos clase_procesos = new Class_Procesos();
        public Proceso Proceso_Modificaciones = new Proceso();
        public Class_Control_Folios class_folio_disponible = new Class_Control_Folios();
        public Control_folio folio_disponible = new Control_folio();
        public string Operacio_materiales = "";
        string appPath = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
        public Class_Materiales class_materiales = new Class_Materiales();
        public Material Agregar_material = new Material();
        public Material Visualizar_material = new Material();
        public Material Modificar_material = new Material();
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
            Materiales_disponibles_busqueda = null;
            clase_procesos = null;
            Proceso_Modificaciones = null;
            this.Dispose();
            GC.Collect();
            this.Close();
        }

        private void buttonAgregarMaterial_Click(object sender, EventArgs e)
        {
            Agrega_material();
        }

        private void Agrega_material()
        {
            Asigna_codigo_proceso_foilio_disponible();
            Desactiva_botones_operacion();
            Aparece_caja_codigo_proveedor();
            Desaparece_combo_codigo_material();
            Activa_cajas_informacion_agregar_busqueda_inicial();
            Rellena_cajas_busqueda_interrogacion_agregar();
            Inicia_timer_para_asegurar_informacion_busqueda_agregar();
            Activa_boton_cancelar_operacio();
            Operacio_materiales = "Agregar";
        }

        private void Inicia_timer_para_asegurar_informacion_busqueda_agregar()
        {
            timerBusquedaAgregar.Enabled = true;
        }

        private void Activa_cajas_informacion_agregar_busqueda_inicial()
        {
            textBoxCodigoProveedor.Enabled = true;
            textBoxDescripcion.Enabled = true;
        }

        private void Rellena_cajas_busqueda_interrogacion_agregar()
        {
            textBoxDescripcion.Text = "?";
            textBoxCodigoProveedor.Text = "?";
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
            if (Operacio_materiales == "Modificar")
                Secuencia_modificar_material();
            else if (Operacio_materiales == "Agregar")
                Secuencia_agregar_material();
        }

        private void Secuencia_agregar_material()
        {
            if (verifica_datos_numericos_cantidad() && verifica_datos_numericos_minimo() &&
                verifica_datos_numericos_maximo())
            {
                if (Guarda_datos_agregar_Material())
                {
                    Limpia_cajas_captura_despues_de_agregar_material();
                    Desactiva_cajas_captura_despues_de_agregar_material();
                    Desactiva_boton_guardar_base_de_datos();
                    Desactiva_boton_cancelar();
                    Desaparece_combo_codigo_material();
                    Activa_botones_operacion();
                    Aparece_caja_codigo_material();
                    Desaparece_foto_material();
                    Asigna_nuevo_folio_material();
                    Desaparece_foto_material();
                    Elimina_informacion_materiales_disponibles();
                }
            }
     
        }

        private void Desaparece_foto_material()
        {
            pictureBoxMaterial.Visible = false;
        }

        private void Asigna_nuevo_folio_material()
        {
            int numero_folio = Convert.ToInt32(folio_disponible.Folio_materiales.Substring(1, folio_disponible.Folio_materiales.Length - 1));
            numero_folio++;
            folio_disponible.Folio_materiales = folio_disponible.Folio_materiales.Substring(0, 1) + numero_folio.ToString();
            string respuesta = class_folio_disponible.Actualiza_Control_folios_base_datos(folio_disponible);
            if (respuesta != "")
                MessageBox.Show(folio_disponible.error);
        }

        private void Secuencia_modificar_material()
        {
            if (verifica_datos_numericos_cantidad() && verifica_datos_numericos_minimo() &&
                verifica_datos_numericos_maximo())
            {
                if (Guarda_datos_modificar_material())
                {
                    Limpia_cajas_captura_despues_de_agregar_material();
                    Desactiva_cajas_captura_despues_de_agregar_material();
                    Desactiva_boton_guardar_base_de_datos();
                    Desactiva_boton_cancelar();
                    Activa_botones_operacion();
                    Desaparece_foto_material();
                    Elimina_informacion_materiales_disponibles();
                }
            }
        }

        private bool verifica_datos_numericos_cantidad()
        {
            try
            {
                Convert.ToSingle(textBoxCantidad.Text);
                return true;
            }
            catch
            {
                textBoxCantidad.Text = "";
                MessageBox.Show("Cantidad NO numerico", "Guardar Material", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;

            }
        }

        private bool verifica_datos_numericos_minimo()
        {
            try
            {
                Convert.ToSingle(textBoxMinimo.Text);
                return true;
            }
            catch
            {
                textBoxMinimo.Text = "";
                MessageBox.Show("Minimo NO numerico", "Guardar Material", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;

            }
        }

        private bool verifica_datos_numericos_maximo()
        {
            try
            {
                Convert.ToSingle(textBoxMaximo.Text);
                return true;
            }
            catch
            {
                textBoxMaximo.Text = "";
                MessageBox.Show("Maximo NO numerico", "Guardar Material", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;

            }
        }

        private void Elimina_informacion_materiales_disponibles()
        {
            Materiales_disponibles_busqueda = null;
        }

        private void Limpia_combo_codigo_material()
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
            Activa_boton_agregar_material();
            Activa_boton_modificar_material();
            Activa_boton_visualizar_material();
        }

        private void Activa_boton_visualizar_material()
        {
            buttonBuscarMaterial.Enabled = true;
        }

        private void Activa_boton_busqueda_base_datos()
        {
            buttonBusquedaBaseDatos.Enabled = true;
        }

        private void Activa_boton_modificar_material()
        {
            buttonModificarMaterial.Enabled = true;
        }

        private void Activa_boton_agregar_material()
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

        private void Limpia_cajas_captura_despues_de_agregar_material()
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

        private bool Guarda_datos_modificar_material()
        {
            Asigna_datos_modificar_material();
            string Respuesta = class_materiales.Actualiza_base_datos_materiales(Modificar_material);
            if (Respuesta == "NO errores")
            {
                return true;
            }
            else
            {
                MessageBox.Show(Respuesta);
                return false;
            }
        }

        private void Asigna_datos_modificar_material()
        {
            Modificar_material.Codigo = textBoxCodigoMaterial.Text;
            Modificar_material.Descripcion =  textBoxDescripcion.Text;
            Modificar_material.foto = textBoxNombreFoto.Text;
            Modificar_material.Unidad_medida = textBoxUnidadMedida.Text;
            Modificar_material.Cantidad = textBoxCantidad.Text;
            Modificar_material.Maximo = textBoxMaximo.Text;
            Modificar_material.Minimo = textBoxMinimo.Text;
            Modificar_material.Marca = textBoxMarca.Text;
            Modificar_material.Ubicacion = textBoxUbicacion.Text;
            Modificar_material.Codigo_proveedor = textBoxCodigoProveedor.Text;
        }

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

        private void buttonModificarMaterial_Click(object sender, EventArgs e)
        {
            Modifica_material();
        }

        private void Modifica_material()
        {
            Desactiva_botones_operacion();
            Aparece_boton_busqueda_base_datos();
            Activa_boton_busqueda_base_datos();
            Activa_cajas_de_informacion_visualizar();
            Rellena_cajas_busqueda_interrogacion();
            Activa_boton_cancelar_operacio();
            Operacio_materiales = "Modificar";
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
            timerBusquedaAgregar.Enabled = true;
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

        private void timerBusquedaAgregar_Tick(object sender, EventArgs e)
        {
            if(textBoxCodigoProveedor.Text!= "?" || textBoxDescripcion.Text !="?")
            {
                timerBusquedaAgregar.Enabled = false;
                buttonBusquedaBaseDatos.Visible = true;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Limpia_cajas_captura_despues_de_agregar_material();
            Desactiva_cajas_captura_despues_de_agregar_material();
            Desactiva_boton_guardar_base_de_datos();
            Desactiva_boton_cancelar();
            Desactiva_boton_eliminar_base_de_datos();
            Activa_botones_operacion();
            Desaparece_foto_material();
            Desaparece_boton_busqueda_base_datos();

        }

        private void Desaparece_boton_busqueda_base_datos()
        {
            buttonBusquedaBaseDatos.Visible = false;
        }

        private void Aparece_caja_codigo_material()
        {
            textBoxCodigoProveedor.Visible = true;
        }

        private void Desaparece_combo_codigo_material()
        {
            comboBoxCodigoMaterial.Visible=false;
        }

        private void buttonBusquedaBaseDatos_Click(object sender, EventArgs e)
        {
            Desaparece_boton_buscar_base_datos();
            Obtener_datos_materiales_busqueda();
            Desaparece_foto_material();
            if (Materiales_disponibles_busqueda.Count == 1)
            {
                if (Operacio_materiales == "Visualizar")
                {
                    Desactiva_cajas_captura_busqueda_material();
                    Rellena_cajas_informacion_despues_busqueda(Materiales_disponibles_busqueda[0]);
                    Muestra_foto_material();
                }
                else if(Operacio_materiales == "Modificar")
                {
                    Activa_cajas_informacion_material_modificaciones();
                    Aparece_boton_guardar_material_base_datos();
                    Rellena_cajas_informacion_despues_busqueda(Materiales_disponibles_busqueda[0]);
                    Muestra_foto_material();
                }else if(Operacio_materiales == "Agregar")
                {
                    Forma_Materiales_Seleccion forma_Materiales_Seleccion = new Forma_Materiales_Seleccion(Materiales_disponibles_busqueda, Operacio_materiales);
                    forma_Materiales_Seleccion.ShowDialog();
                    if (forma_Materiales_Seleccion.agregar_seleccion == "Agregar")
                    {
                        Activa_cajas_informacion();
                        Activa_timer_agregar_material();
                    }
                    else
                    {
                        Cancela_operacion_agregar();
                    }
                }
                
                
            }
            else if (Materiales_disponibles_busqueda.Count > 1)
            {
                Forma_Materiales_Seleccion forma_Materiales_Seleccion = new Forma_Materiales_Seleccion(Materiales_disponibles_busqueda,Operacio_materiales);
                forma_Materiales_Seleccion.ShowDialog();
                if (Operacio_materiales == "Visualizar")
                {
                    Desactiva_cajas_captura_busqueda_material();
                    Limpia_cajas_captura_despues_de_agregar_material();
                    if (forma_Materiales_Seleccion.Material_seleccionado_data_view != null)
                    {
                        Rellena_cajas_informacion_despues_busqueda(forma_Materiales_Seleccion.Material_seleccionado_data_view);
                        Muestra_foto_material();
                    }
                }
                else if (Operacio_materiales == "Modificar")
                {
                    Activa_cajas_informacion_material_modificaciones();
                    Aparece_boton_guardar_material_base_datos();
                    Limpia_cajas_captura_despues_de_agregar_material();
                    if (forma_Materiales_Seleccion.Material_seleccionado_data_view != null)
                    {
                        Rellena_cajas_informacion_despues_busqueda(forma_Materiales_Seleccion.Material_seleccionado_data_view);
                        Muestra_foto_material();
                    }
                }else if(Operacio_materiales == "Agregar")
                {
                    if (forma_Materiales_Seleccion.agregar_seleccion == "Agregar")
                    {
                        Activa_cajas_informacion();
                        Activa_timer_agregar_material();
                    }
                    else
                    {
                        Cancela_operacion_agregar();
                    }

                }
               
            }
            else if(Materiales_disponibles_busqueda.Count ==  0)
            {
                if (Operacio_materiales == "Agregar")
                {
                    Activa_cajas_informacion();
                    Activa_timer_agregar_material();

                }
                else
                {
                    Desactiva_cajas_captura_busqueda_material();
                    Limpia_cajas_captura_despues_de_agregar_material();
                    MessageBox.Show("NO se encontraron Material Con esta busqueda", "Busqueda Material", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void Activa_timer_agregar_material()
        {
            timerAgregarMaterial.Enabled = true;
        }

        private void Cancela_operacion_agregar()
        {
            Limpia_cajas_captura_despues_de_agregar_material();
            Desactiva_cajas_captura_despues_de_agregar_material();
            Desactiva_boton_guardar_base_de_datos();
            Desactiva_boton_cancelar();
            Desactiva_boton_eliminar_base_de_datos();
            Activa_botones_operacion();
            Desaparece_foto_material();
            Desaparece_boton_busqueda_base_datos();
        }

        private void Desaparece_boton_buscar_base_datos()
        {
            buttonBusquedaBaseDatos.Visible = false;
        }

        private void Aparece_boton_guardar_material_base_datos()
        {
            buttonGuardarBasedeDatos.Visible = true;
        }

        private void Activa_cajas_informacion_material_modificaciones()
        {
            textBoxCodigoMaterial.Enabled = false;
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

        private void Cambia_Color_window_fondo_cajas_busqueda()
        {
            textBoxCodigoMaterial.BackColor = Color.White;
            textBoxCodigoProveedor.BackColor = Color.White;
            textBoxDescripcion.BackColor = Color.White;
            textBoxMarca.BackColor = Color.White;
        }

        private void Muestra_foto_material()
        {
            if (textBoxNombreFoto.Text != "")
            {
                Aparece_foto_material();
                try
                {
                    pictureBoxMaterial.Image = Image.FromFile(@appPath + "\\Fotos\\" +
                           textBoxNombreFoto.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Desactiva_cajas_captura_busqueda_material()
        {
            textBoxCodigoMaterial.Enabled = false;
            textBoxCodigoProveedor.Enabled = false;
            textBoxDescripcion.Enabled = false;
            textBoxMarca.Enabled = false;
        }

        private void Rellena_cajas_informacion_despues_busqueda(Material material_busqueda)
        {
            textBoxCodigoMaterial.Text = material_busqueda.Codigo;
            textBoxCodigoProveedor.Text = material_busqueda.Codigo_proveedor;
            textBoxDescripcion.Text = material_busqueda.Descripcion;
            textBoxNombreFoto.Text = material_busqueda.foto;
            textBoxUnidadMedida.Text = material_busqueda.Unidad_medida;
            textBoxCantidad.Text = material_busqueda.Cantidad;
            textBoxMaximo.Text = material_busqueda.Maximo;
            textBoxMinimo.Text = material_busqueda.Minimo;
            textBoxMarca.Text = material_busqueda.Marca;
            textBoxUbicacion.Text = material_busqueda.Ubicacion;
        }

        private void buttonBorrarBasedeDatos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta Seguro de Eiliminar Este Proceso?", "Eliminar Proceso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Elimina_informacion_en_base_de_datos())
                {
                    Limpia_cajas_captura_despues_de_agregar_material();
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


        private void buttonBuscarempleado_Click(object sender, EventArgs e)
        {
            Visualiza_material();
        }

        private void Visualiza_material()
        {
            Desactiva_botones_operacion();
            Aparece_boton_busqueda_base_datos();
            Activa_boton_busqueda_base_datos();
            Activa_cajas_de_informacion_visualizar();
            Rellena_cajas_busqueda_interrogacion();
            Activa_boton_cancelar_operacio();
            Operacio_materiales = "Visualizar";
        }

        private void Cambia_Color_aqua_fondo_cajas_busqueda()
        {
            textBoxCodigoMaterial.BackColor = Color.Aqua;
            textBoxCodigoProveedor.BackColor = Color.Aqua;
            textBoxDescripcion.BackColor = Color.Aqua;
            textBoxMarca.BackColor = Color.Aqua;
        }

        private void Rellena_cajas_busqueda_interrogacion()
        {
            textBoxCodigoMaterial.Text = "?";
            textBoxCodigoProveedor.Text = "?";
            textBoxDescripcion.Text = "?";
            textBoxMarca.Text = "?";
        }

        private void Aparece_boton_busqueda_base_datos()
        {
            buttonBusquedaBaseDatos.Visible = true;
        }

        private void Obtener_datos_materiales_busqueda()
        {
            Asigna_datos_visualizar_material();
            if (Operacio_materiales == "Agregar")
            {
                Materiales_disponibles_busqueda = class_materiales.Adquiere_agregar_materiales_busqueda_en_base_datos(Visualizar_material);
            }
            else
            {
                Materiales_disponibles_busqueda = class_materiales.Adquiere_materiales_busqueda_en_base_datos(Visualizar_material);
            }
        }

        private void Asigna_datos_visualizar_material()
        {           
                Visualizar_material.Codigo = textBoxCodigoMaterial.Text;
                Visualizar_material.Codigo_proveedor = textBoxCodigoProveedor.Text;
                Visualizar_material.Descripcion = textBoxDescripcion.Text;
                Visualizar_material.Marca = textBoxMarca.Text;
        }

        private void Activa_cajas_de_informacion_visualizar()
        {
            textBoxCodigoMaterial.Enabled = true;
            textBoxCodigoProveedor.Enabled = true;
            textBoxDescripcion.Enabled = true;
            textBoxMarca.Enabled = true;
        }

        private void Desaparce_caja_nombre_proceso()
        {
            textBoxCodigoProveedor.Visible = false;
        }


        private void comboBoxNombreEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Operacio_materiales == "Modificar")
                configura_forma_modificar();
            else if (Operacio_materiales == "Eliminar")
                configura_forma_eliminar();
            else if (Operacio_materiales == "Visualizar")
                configura_forma_visualizar();
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

        private void timerAgregarMaterial_Tick(object sender, EventArgs e)
        {
            if (textBoxCodigoProveedor.Text != "" && textBoxDescripcion.Text != "" &&
                textBoxMarca.Text !="")
            {
                timerBusquedaAgregar.Enabled = false;
                buttonGuardarBasedeDatos.Visible = true;
            }
        }
    }
}
 