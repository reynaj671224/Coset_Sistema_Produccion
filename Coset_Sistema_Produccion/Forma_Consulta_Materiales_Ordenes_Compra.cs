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
    public partial class Forma_Consulta_Materiales_Ordenes_Compra : Form
    {
        public Class_Procesos clase_procesos = new Class_Procesos();
        public Proceso_electricos Proceso_Modificaciones = new Proceso_electricos();
        public Class_Control_Folios class_folio_disponible = new Class_Control_Folios();
        public Control_folio folio_disponible = new Control_folio();
        public string Operacio_materiales = "";
        string appPath = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
        public Class_Materiales class_materiales = new Class_Materiales();
        public Material Agregar_material = new Material();
        public Material Visualizar_material = new Material();
        public Material Modificar_material = new Material();
        public Material Material_Seleccion_busqueda_orden_compra = new Material();
        public List<Material> Materiales_disponibles_busqueda = new List<Material>();
        public string criterio_busqueda = "";
        public List<Partida_orden_compra> partidas_ordenes_compra_disponibles =
            new List<Partida_orden_compra>();
        public Class_Partidas_Orden_compra class_partidas_Orden_compra = new Class_Partidas_Orden_compra();
        public List<Material> Materiales_disponible_entrada_materiales = new List<Material>();
        public Material Material_disponible_entrada_materiales = new Material();
        public Partida_orden_compra Partida_orden_compra_seleccionada = new Partida_orden_compra();
        public Class_Materiales Class_Materiales = new Class_Materiales();
        public Class_Entrada_Material Class_entrada_material = new Class_Entrada_Material();
        public List<Entrada_Material> Entrada_materiales_disponibles = new List<Entrada_Material>();
        public Entrada_Material Entrada_materiales_seleccion = new Entrada_Material();

        public Forma_Consulta_Materiales_Ordenes_Compra()
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
            partidas_ordenes_compra_disponibles = null;
            Entrada_materiales_disponibles = null;
            timerConsultaMaterial.Enabled = false;
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
            Aparece_caja_codigo_proveedor();
            Activa_cajas_informacion_agregar_busqueda_inicial();
            Rellena_cajas_busqueda_interrogacion_agregar();
            Activa_boton_cancelar_operacio();
            Operacio_materiales = "Agregar";
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
            timerConsultaMaterial.Enabled = true;
        }



       
        private void Activa_caja_nombre_proceso()
        {
            textBoxCodigoProveedor.Enabled = true;
        }

        private void Activa_caja_codigo_proceso()
        {
            textBoxCodigoMaterial.Enabled = true;
        }


        private void Activa_cajas_informacion()
        {
            textBoxCodigoProveedor.Enabled = true;
            textBoxDescripcion.Enabled = true;
            textBoxMarca.Enabled = true;
            textBoxUbicacion.Enabled = true;
        }

        private void Desactiva_boton_buscar_base_datos()
        {
            buttonBusquedaBaseDatos.Enabled = false;
        }


        private void Activa_boton_cancelar_operacio()
        {
            buttonCancelar.Visible = true;
        }


        private void Desaparece_foto_material()
        {
            pictureBoxMaterial.Visible = false;
        }

        private void Asigna_nuevo_folio_material()
        {
            int numero_folio = Convert.ToInt32(folio_disponible.Folio_materiales.Substring(2, folio_disponible.Folio_materiales.Length - 2));
            numero_folio++;
            folio_disponible.Folio_materiales = folio_disponible.Folio_materiales.Substring(0, 2) + numero_folio.ToString();
            string respuesta = class_folio_disponible.Actualiza_Control_folios_base_datos(folio_disponible);
            if (respuesta != "")
                MessageBox.Show(folio_disponible.error);
        }

        private void Elimina_informacion_materiales_disponibles()
        {
            Materiales_disponibles_busqueda = null;
        }


        private void Desactiva_boton_cancelar()
        {
            buttonCancelar.Visible = false;
        }

 

        private void Activa_boton_busqueda_base_datos()
        {
            buttonBusquedaBaseDatos.Enabled = true;
        }



        private void Desactiva_cajas_captura_despues_de_agregar_material()
        {
            textBoxCodigoProveedor.Enabled = false;
            textBoxDescripcion.Enabled = false;
            textBoxMarca.Enabled = false;
            textBoxUbicacion.Enabled = false;
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
            Aparece_boton_busqueda_base_datos();
            Activa_boton_busqueda_base_datos();
            Activa_cajas_de_informacion_visualizar();
            Rellena_cajas_busqueda_interrogacion();
            Activa_boton_cancelar_operacio();
            Operacio_materiales = "Modificar";
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
        }

        private void Desactiva_combo_nombre_empleado()
        {
            //comboBoxNombreProceso.Enabled = false;
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
                buttonBusquedaBaseDatos.Visible = true;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            
            Limpia_cajas_captura_despues_de_agregar_material();
            Pinta_amarillo_cajas_captura();
            Activa_cajas_decaptura_busqueda_material();
            Desactiva_boton_cancelar();
            Desaparece_foto_material();
            Desaparece_boton_busqueda_base_datos();
            Limpiar_partidas_materiales();
            Inicia_timer_buscar_materiales();
            
        }

        private void Pinta_amarillo_cajas_captura()
        {
            textBoxCodigoMaterial.BackColor= Color.Yellow;
            textBoxCodigoProveedor.BackColor = Color.Yellow;
            textBoxDescripcion.BackColor = Color.Yellow;
            textBoxMarca.BackColor = Color.Yellow;
            textBoxUbicacion.BackColor = Color.Yellow;
        }

        private void Activa_cajas_decaptura_busqueda_material()
        {
            textBoxCodigoMaterial.Enabled = true;
            textBoxCodigoProveedor.Enabled = true;
            textBoxDescripcion.Enabled = true;
            textBoxMarca.Enabled = true;
            textBoxUbicacion.Enabled = true;
        }

        private void Inicia_timer_buscar_materiales()
        {
            timerConsultaMaterial.Enabled = true;
        }

        private void Limpiar_partidas_materiales()
        {
            dataGridViewPartidasMaterialSelecionOrdenesCompra.Rows.Clear();
        }

        private void Desaparece_boton_busqueda_base_datos()
        {
            buttonBusquedaBaseDatos.Visible = false;
        }

        private void Aparece_caja_codigo_material()
        {
            textBoxCodigoProveedor.Visible = true;
        }


        private void buttonBusquedaBaseDatos_Click(object sender, EventArgs e)
        {
            Desaparece_boton_buscar_base_datos();
            Obtener_datos_materiales_busqueda();

            if (Materiales_disponibles_busqueda.Count == 1)
            {
                Material_Seleccion_busqueda_orden_compra = Materiales_disponibles_busqueda[0];
                Obtener_ordenes_compra_codigo_material();
                Rellena_datagrid_Material_Ordenes_Compra();

            }
            else if (Materiales_disponibles_busqueda.Count > 1)
            {
                Forma_Materiales_Seleccion forma_Materiales_Seleccion = new Forma_Materiales_Seleccion(Materiales_disponibles_busqueda, "Entrada Materiales");
                forma_Materiales_Seleccion.ShowDialog();

                if (forma_Materiales_Seleccion.Material_seleccionado_data_view != null)
                {
                    Material_Seleccion_busqueda_orden_compra = forma_Materiales_Seleccion.Material_seleccionado_data_view;
                    Obtener_ordenes_compra_codigo_material();
                    Rellena_datagrid_Material_Ordenes_Compra();
                }

                }
            else if (Materiales_disponibles_busqueda.Count == 0)
            {

                MessageBox.Show("NO se encontraron Material Con este criterio",
                    "Busqueda Material", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Desaparece_foto_material();
            Desactiva_cajas_captura_busqueda_material();
            //Rellena_partidas_materiales_disponibles_busqueda();
            Pinta_blanco_cajas_captura();
            //Desactiva_cajas_captura_busqueda_material();
            //Muestra_foto_material();
        }

        private void Rellena_datagrid_Material_Ordenes_Compra()
        {
            int Unidades_Recibidas = 0;
            Limpia_datageid_ordenes_compra_materiales();
            Activa_datagrid_materiales();
            foreach (Partida_orden_compra partida_orden_compra in partidas_ordenes_compra_disponibles)
            {
                try
                {
                    Partida_orden_compra_seleccionada = partida_orden_compra;

                    Unidades_Recibidas = Calculo_unidades_entradas();
                    if (Obtener_materiales_con_codigo_material())
                    {
                        Material_disponible_entrada_materiales = Materiales_disponible_entrada_materiales.Find(
                        material_disponible => material_disponible.Codigo.Contains(partida_orden_compra.Material));
                    }

                    if (Material_disponible_entrada_materiales.Generico == "1")
                    {
                        dataGridViewPartidasMaterialSelecionOrdenesCompra.Rows.Add(Material_disponible_entrada_materiales.Codigo,
                            Material_disponible_entrada_materiales.Codigo_proveedor, partida_orden_compra.Descripcion, 
                            partida_orden_compra.Codigo_orden, partida_orden_compra.Cantidad,Unidades_Recibidas.ToString(), 
                            Material_disponible_entrada_materiales.foto);
                    }
                    else
                    {
                        dataGridViewPartidasMaterialSelecionOrdenesCompra.Rows.Add(Material_disponible_entrada_materiales.Codigo,
                            Material_disponible_entrada_materiales.Codigo_proveedor, Material_disponible_entrada_materiales.Descripcion,
                            partida_orden_compra.Codigo_orden,partida_orden_compra.Cantidad, Unidades_Recibidas.ToString(),
                            Material_disponible_entrada_materiales.foto);
                    }
                   /* dataGridViewPartidasEntradaMaterialesEntrada["Cantidad_recibidas",
                        Row_material].Style.BackColor = Color.Yellow;*/

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }

        }

        private void Limpia_datageid_ordenes_compra_materiales()
        {
            dataGridViewPartidasMaterialSelecionOrdenesCompra.Rows.Clear();
        }

        private void Pinta_blanco_cajas_captura()
        {
            textBoxCodigoMaterial.BackColor=Color.White;
            textBoxCodigoProveedor.BackColor = Color.White;
            textBoxDescripcion.BackColor = Color.White;
            textBoxMarca.BackColor = Color.White;
        }

        private void Activa_timer_agregar_material()
        {
            timerConsultaMaterial.Enabled = true;
        }

        private void Cancela_operacion_agregar()
        {
            Limpia_cajas_captura_despues_de_agregar_material();
            Desactiva_cajas_captura_despues_de_agregar_material();
            Desactiva_boton_cancelar();
            Desaparece_foto_material();
            Desaparece_boton_busqueda_base_datos();
        }

        private void Desaparece_boton_buscar_base_datos()
        {
            buttonBusquedaBaseDatos.Visible = false;
        }



        private void Activa_cajas_informacion_material_modificaciones()
        {
            textBoxCodigoMaterial.Enabled = false;
            textBoxCodigoProveedor.Enabled = true;
            textBoxDescripcion.Enabled = true;
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
            //if (textBoxNombreFoto.Text != "")
            //{
            //    Aparece_foto_material();
            //    try
            //    {
            //        pictureBoxMaterial.Image = Image.FromFile(@appPath + "\\Fotos\\" +
            //               textBoxNombreFoto.Text);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
        }

        private void Desactiva_cajas_captura_busqueda_material()
        {
            textBoxCodigoMaterial.Enabled = false;
            textBoxCodigoProveedor.Enabled = false;
            textBoxDescripcion.Enabled = false;
            textBoxMarca.Enabled = false;
            textBoxUbicacion.Enabled = false;
        }

        private void Rellena_partidas_materiales_disponibles_busqueda()
        {
            //Materiales_disponibles_busqueda = materiales_busqueda_disponibles;
            foreach (Material material in Materiales_disponibles_busqueda)
            {
                dataGridViewPartidasMaterialSelecionOrdenesCompra.Rows.Add(material.Codigo, material.Codigo_proveedor,
                    material.Descripcion, material.Cantidad, material.Marca, material.Unidad_medida, 
                    material.Ubicacion, material.foto);
            }
            Activa_datagrid_materiales();

        }

        private void Activa_datagrid_materiales()
        {
            dataGridViewPartidasMaterialSelecionOrdenesCompra.Enabled = true;
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
                    Desactiva_boton_cancelar();
                    Aparece_caja_codigo_material();
                    Elimina_informacion_materiales_disponibles();
                }
            }
        }


        private bool Elimina_informacion_en_base_de_datos()
        {
            return Elimina_datos_usuario();
        }

        private void buttonBuscarempleado_Click(object sender, EventArgs e)
        {
            Visualiza_material();
        }

        private void Visualiza_material()
        {
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
            Materiales_disponibles_busqueda = class_materiales.Adquiere_materiales_busqueda_en_base_datos(Visualizar_material);
        }

        private void Asigna_datos_visualizar_material()
        {
            if (textBoxCodigoMaterial.Text == "")
            {
                Visualizar_material.Codigo = "~";

            }
            else
            {
                Visualizar_material.Codigo = textBoxCodigoMaterial.Text;

            }

            if (textBoxCodigoProveedor.Text == "")
            {
                Visualizar_material.Codigo_proveedor = "~";
            }
            else
            {
                Visualizar_material.Codigo_proveedor = textBoxCodigoProveedor.Text;
            }

            if (textBoxDescripcion.Text == "")
            {
                Visualizar_material.Descripcion = "~";
            }
            else
            {
                Visualizar_material.Descripcion = textBoxDescripcion.Text;
            }

            if (textBoxMarca.Text == "")
            {
                Visualizar_material.Marca = "~";
            }
            else
            {
                Visualizar_material.Marca = textBoxMarca.Text;
            }

        }

        private void Activa_cajas_de_informacion_visualizar()
        {
            textBoxCodigoMaterial.Enabled = true;
            textBoxCodigoProveedor.Enabled = true;
            textBoxDescripcion.Enabled = true;
            textBoxMarca.Enabled = true;
            textBoxUbicacion.Enabled = true;
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
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            //openFileDialog1.InitialDirectory = @appPath + "\\Fotos";
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    textBoxNombreFoto.Text = openFileDialog1.SafeFileName;
            //    try
            //    {
            //        Aparece_foto_material();
            //        Carga_foto_selccionada();
            //    }
            //    catch(Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
        }

        private void Carga_foto_selccionada()
        {
            //pictureBoxMaterial.Image = Image.FromFile(@appPath + "\\Fotos\\" +textBoxNombreFoto.Text);
        }

        private void Aparece_foto_material()
        {
            pictureBoxMaterial.Visible = true;
        }

        private void timerConsultaMaterial_Tick(object sender, EventArgs e)
        {
            if (textBoxCodigoProveedor.Text != "" || 
                textBoxDescripcion.Text != "" ||
                textBoxMarca.Text !="" ||
                textBoxCodigoMaterial.Text != "")
            {
                timerConsultaMaterial.Enabled = false;
                buttonBusquedaBaseDatos.Visible = true;
                buttonCancelar.Visible = true;
            }
        }

        private void dataGridViewPartidasMaterialSeleccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewPartidasMaterialSelecionOrdenesCompra.Rows[e.RowIndex].Cells["Foto"].Value != null)
                {
                    pictureBoxMaterial.Image = Image.FromFile(@appPath + "\\Fotos\\" +
                            dataGridViewPartidasMaterialSelecionOrdenesCompra.Rows[e.RowIndex].Cells["Foto"].Value.ToString());
                    Aparece_foto_material();
                }
                else
                {
                    Desaparece_foto_material();
                }

            }
            catch
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void labelCodigoMaterial_Click(object sender, EventArgs e)
        {
            if ((!textBoxCodigoMaterial.Enabled && !textBoxCodigoProveedor.Enabled &&
                !textBoxDescripcion.Enabled && !textBoxMarca.Enabled && !textBoxUbicacion.Enabled) ||
                textBoxCodigoMaterial.Enabled)
            {
                if (textBoxCodigoMaterial.Enabled == false)
                {
                    textBoxCodigoMaterial.Enabled = true;
                    criterio_busqueda = "CodigoMaterial";
                }
                else
                {
                    textBoxCodigoMaterial.Enabled = false;
                    criterio_busqueda = "";
                }
            }
        }

        private void labelCodigoProveedor_Click(object sender, EventArgs e)
        {
            if ((!textBoxCodigoMaterial.Enabled && !textBoxCodigoProveedor.Enabled &&
                !textBoxDescripcion.Enabled && !textBoxMarca.Enabled && !textBoxUbicacion.Enabled) ||
                 textBoxCodigoProveedor.Enabled)
            {
                if (textBoxCodigoProveedor.Enabled == false)
                {
                    textBoxCodigoProveedor.Enabled = true;
                    criterio_busqueda = "CodigoProveedor";
                }
                else
                {
                    textBoxCodigoProveedor.Enabled = false;
                    criterio_busqueda = "";
                }
            }
        }

        private void labelDescripcion_Click(object sender, EventArgs e)
        {
            if ((!textBoxCodigoMaterial.Enabled && !textBoxCodigoProveedor.Enabled &&
               !textBoxDescripcion.Enabled && !textBoxMarca.Enabled && !textBoxUbicacion.Enabled) ||
               textBoxDescripcion.Enabled)
            {
                if (textBoxDescripcion.Enabled == false)
                {
                    textBoxDescripcion.Enabled = true;
                    criterio_busqueda = "Descripcion";
                }
                else
                {
                    textBoxDescripcion.Enabled = false;
                    criterio_busqueda = "";
                }
            }
        }

        private void labelUbicacion_Click(object sender, EventArgs e)
        {
            if ((!textBoxCodigoMaterial.Enabled && !textBoxCodigoProveedor.Enabled &&
               !textBoxDescripcion.Enabled && !textBoxMarca.Enabled && !textBoxUbicacion.Enabled) ||
               textBoxUbicacion.Enabled)
            {
                if (textBoxUbicacion.Enabled == false)
                {
                    textBoxUbicacion.Enabled = true;
                    criterio_busqueda = "Ubicacion";
                }
                else
                {
                    textBoxUbicacion.Enabled = false;
                    criterio_busqueda = "";
                }
            }
        }

        private void labelMarca_Click(object sender, EventArgs e)
        {
            if ((!textBoxCodigoMaterial.Enabled && !textBoxCodigoProveedor.Enabled &&
               !textBoxDescripcion.Enabled && !textBoxMarca.Enabled && !textBoxUbicacion.Enabled) ||
               textBoxMarca.Enabled)
            {
                if (textBoxMarca.Enabled == false)
                {
                    textBoxMarca.Enabled = true;
                    criterio_busqueda = "Marca";

                }
                else
                {
                    textBoxMarca.Enabled = false;
                    criterio_busqueda = "";
                }
            }
        }

        private void textBoxDescripcion_TextChanged(object sender, EventArgs e)
        {
            textBoxDescripcion.BackColor = Color.White;
        }

        private void textBoxCodigoProveedor_TextChanged(object sender, EventArgs e)
        {
            textBoxCodigoProveedor.BackColor = Color.White;
        }

        private void textBoxCodigoMaterial_TextChanged(object sender, EventArgs e)
        {
            textBoxCodigoMaterial.BackColor = Color.White;
        }

        private void textBoxMarca_TextChanged(object sender, EventArgs e)
        {
            textBoxMarca.BackColor = Color.White;
        }

        private void Obtener_ordenes_compra_codigo_material()
        {
            partidas_ordenes_compra_disponibles = class_partidas_Orden_compra.
                Adquiere_partidas_ordenes_compra_disponibles_en_base_datos_material(Material_Seleccion_busqueda_orden_compra.Codigo);
        }

        private bool Obtener_materiales_con_codigo_material()
        {
            Materiales_disponible_entrada_materiales = Class_Materiales.Adquiere_materiales_Consulta_Entrada_materiales_en_base_datos(Partida_orden_compra_seleccionada);
            if (Materiales_disponible_entrada_materiales.Count == 0)
            {
                MessageBox.Show("No se encontro el material en base de datos", "Entrada Materiales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Materiales_disponible_entrada_materiales.Count > 1)
            {
                MessageBox.Show("Se encontro mas de un material en base de datos", "Entrada Materiales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                Material_disponible_entrada_materiales = Materiales_disponible_entrada_materiales.Find(material_disponible => material_disponible.Codigo_proveedor.Contains(textBoxCodigoProveedor.Text));
                return true;
            }



        }

        private int Calculo_unidades_entradas()
        {
            Obtener_partidas_entrada_materiales();
            int Total_cantidad = 0;
            for (int renglones = 0; renglones < Entrada_materiales_disponibles.Count; renglones++)
            {

                try
                {
                    Total_cantidad = Total_cantidad + Convert.ToInt32(Entrada_materiales_disponibles[renglones].Cantidad);
                }
                catch
                {
                    MessageBox.Show("No valores numericos en cantidad", "Entrada Materriales",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            return Total_cantidad;

        }

        private void Obtener_partidas_entrada_materiales()
        {
            Asigna_valores_entrada_materiales_visualizar();
            Entrada_materiales_disponibles = Class_entrada_material.
                Adquiere_entrada_materiales_busqueda_en_base_datos(Entrada_materiales_seleccion);

        }

        private void Asigna_valores_entrada_materiales_visualizar()
        {
            Entrada_materiales_seleccion.Codigo_material = Partida_orden_compra_seleccionada.Material;
            Entrada_materiales_seleccion.Orden_compra = Partida_orden_compra_seleccionada.Codigo_orden;
            Entrada_materiales_seleccion.Descripcion_material = Partida_orden_compra_seleccionada.Descripcion;
        }
    }
}
 