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
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace Coset_Sistema_Produccion
{
    public partial class Forma_Materiales_MaxMin : Form
    {
        public string Operacio_procesos = "";
        string appPath = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
        public Class_Materiales class_materiales = new Class_Materiales();
        public Material Agregar_material = new Material();
        public Material Visualizar_material = new Material();
        public List<Material> Materiales_disponibles_busqueda = new List<Material>();
        public List<Material> Materiales_disponibles_filtros = new List<Material>();
        public Material Material_seleccionado_data_view = new Material();
        public string agregar_seleccion = "";
        public Excel.Application oXL = null;
        public Excel.Worksheet oSheet = null;
        public Excel.Workbook oWB = null;
        public string Archivo_Excel_nombre= "";
        public Forma_Materiales_MaxMin()
        {
            InitializeComponent();
        }


        private void Aparece_boton_no_agregar_material()
        {
            buttonRegresarNoAgregar.Visible = true;
        }


        private void Rellena_partidas_materiales_disponibles() 
        {
            int Material_requerido = 0;
            string Material_requerido_string = "";
            string Material_cantidad_string = "";
            foreach (Material material in Materiales_disponibles_busqueda)
            {
                if (material.error == "")
                {
                    try
                    {

                        Material_requerido = Convert.ToInt32(material.Maximo) - Convert.ToInt32(material.Cantidad);
                        if (Material_requerido < 0)
                        {
                            Material_requerido = 0;
                            
                        }

                        Material_requerido_string = Material_requerido.ToString();
                        if (Convert.ToInt32(material.Cantidad) > Convert.ToInt32(material.Maximo))
                        {
                            Material_cantidad_string = "*" + material.Cantidad + "*";
                        }
                        else
                        {
                            Material_cantidad_string = material.Cantidad.ToString();
                        }
                        dataGridViewPartidasMaterialSeleccion.Rows.Add(material.Codigo, material.Codigo_proveedor,
                            material.Descripcion, material.Minimo, material.Maximo, Material_cantidad_string, Material_requerido_string, 
                            material.Marca, material.Unidad_medida, material.Ubicacion,material.Categoria,material.foto);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        break;
                    }
                }
                else
                {
                    MessageBox.Show(material.error);
                    break;
                }
                Material_requerido = 0;
            }
            Activa_datagrid_materiales();
            
        }

        private void Rellena_partidas_materiales_filtros()
        {
            int Material_requerido = 0;
            string Material_requerido_string = "";
            string Material_cantidad_string = "";
            foreach (Material material in Materiales_disponibles_filtros)
            {
                if (material.error == "")
                {
                    try
                    {

                        Material_requerido = Convert.ToInt32(material.Maximo) - Convert.ToInt32(material.Cantidad);
                        if (Material_requerido < 0)
                        {
                            Material_requerido = 0;

                        }

                        Material_requerido_string = Material_requerido.ToString();
                        if (Convert.ToInt32(material.Cantidad) > Convert.ToInt32(material.Maximo))
                        {
                            Material_cantidad_string = "*" + material.Cantidad + "*";
                        }
                        else
                        {
                            Material_cantidad_string = material.Cantidad.ToString();
                        }
                        dataGridViewPartidasMaterialSeleccion.Rows.Add(material.Codigo, material.Codigo_proveedor,
                            material.Descripcion, material.Minimo, material.Maximo, Material_cantidad_string, Material_requerido_string,
                            material.Marca, material.Unidad_medida, material.Ubicacion, material.Categoria, material.foto);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        break;
                    }
                }
                else
                {
                    MessageBox.Show(material.error);
                    break;
                }
                Material_requerido = 0;
            }
            Activa_datagrid_materiales();

        }

        private void Activa_datagrid_materiales()
        {
            dataGridViewPartidasMaterialSeleccion.Enabled = true;
        }

        private void Forma_Materiales_Seleccion_Load(object sender, EventArgs e)
        {
            
            
            
        }

        private void dataGridViewPartidasMaterialSeleccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridViewPartidasMaterialSeleccion.Rows[e.RowIndex].Cells["Foto"].Value != null)
            //{
            //    Material_seleccionado_data_view = Materiales_disponibles_busqueda.Find(material =>
            //            material.Codigo.Contains(dataGridViewPartidasMaterialSeleccion.Rows[e.RowIndex].Cells["Codigo_partida"]
            //            .Value.ToString()));
            //    if (dataGridViewPartidasMaterialSeleccion.Rows[e.RowIndex].Cells["Foto"].Value.ToString() != "")
            //    {
            //        Aparece_foto_material();
            //        try
            //        {
            //            dataGridViewPartidasMaterialSeleccion.Rows[e.RowIndex].Cells["Codigo_partida"].Value.ToString();
            //            pictureBoxMaterial.Image = Image.FromFile(@appPath + "\\Fotos\\" +
            //                dataGridViewPartidasMaterialSeleccion.Rows[e.RowIndex].Cells["Foto"].Value.ToString());

            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message);
            //        }
            //    }
            //    else
            //    {
            //        Desaparece_foto_material();
            //    }
            //}
        }

        private void Desaparece_foto_material()
        {
            pictureBoxMaterial.Visible = false;
        }

        private void Aparece_foto_material()
        {
            pictureBoxMaterial.Visible = true;
        }

        private void buttonRegresarNoAgregar_Click(object sender, EventArgs e)
        {
            Materiales_disponibles_busqueda = null;
            Materiales_disponibles_filtros = null;
            Cierra_archivo_Excel();
            Close_Excel();
            Termina_applicacion();
            Elimina_archivo_excel();
            oXL = null;
            oSheet = null;
            oWB = null;
            Archivo_Excel_nombre = "";
            this.Close();
            GC.Collect();
        }

        private void Cierra_archivo_Excel()
        {
            try
            {
                oWB.Close();
            }
            catch
            {

            }
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            Desaparece_boton_excel();
            Elimina_archivo_excel();
            if (Inicia_Excel())
            {
                
                if (Copiar_template_a_maximos_minimos())
                {
                    if (Abrir_Archivo_Excel())
                    {

                        try
                        {
                            oSheet = (Excel.Worksheet)oWB.Worksheets.get_Item(1);
                            Imprime_titiulos_excel();

                            for (int Row = 0; Row < dataGridViewPartidasMaterialSeleccion.RowCount - 1; Row++)
                            {
                                for (int Column = 0; Column < dataGridViewPartidasMaterialSeleccion.ColumnCount; Column++)
                                {
                                    oSheet.Cells[Row + 2, Column + 1] = dataGridViewPartidasMaterialSeleccion[Column, Row].Value.ToString();
                                }
                            }
                            oSheet.Cells.EntireColumn.AutoFit();
                        }
                        catch
                        {
                            MessageBox.Show("Probelmas para mostrar informacion en Excel", "Maximos-Minimos",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                Guarda_archivo_excel();
                oXL.Visible = true;
            }
        }

        private bool Abrir_Archivo_Excel()
        {
            try
            {
                oWB = oXL.Workbooks.Open(@appPath + Archivo_Excel_nombre);
                return true;
            }
            catch
            {
                MessageBox.Show(Archivo_Excel_nombre + " No existe en el Folder de aplicacion", 
                    "Maximos Minimos",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private void Obterner_wokbook_activo()
        {
            try
            {
                oWB = oXL.ActiveWorkbook;
            }
            catch
            {
                oWB = oXL.Workbooks.Add();
            }
        }

        public bool Inicia_Excel()
        {
            try
            {
                oXL = new Excel.Application();
               
                return true;
            }
            catch
            {
                MessageBox.Show("No Excel Instalado", "Maximox-Minimos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private bool Copiar_template_a_maximos_minimos()
        {
            Archivo_Excel_nombre = "\\Maximos_minimos-" +
                    Forma_Inicio_Usuario.Usuario_global.nombre_usuario + ".xlsx";
            try
            {
                File.Copy(@appPath + "\\Excel_template.xlsx", @appPath + Archivo_Excel_nombre, false);
                return true;
            }
            catch 
            {
                return false;
            }
        }

        private void Elimina_archivo_excel()
        {
            Archivo_Excel_nombre = "\\Maximos_minimos-" +
                    Forma_Inicio_Usuario.Usuario_global.nombre_usuario + ".xlsx";
            try
            {
                File.Delete(@appPath + Archivo_Excel_nombre);
            }
            catch
            {

            }
        }

        private void Desaparece_boton_excel()
        {
            buttonExcel.Visible = false;
        }

        private void Imprime_titiulos_excel()
        {
            oSheet.Cells[1, 1] = "Codigo Material";
            oSheet.Cells[1, 2] = "Codigo Proveedor";
            oSheet.Cells[1, 3] = "Descripcion";
            oSheet.Cells[1, 4] = "Minimo";
            oSheet.Cells[1, 5] = "Maximo";
            oSheet.Cells[1, 6] = "Cantidad";
            oSheet.Cells[1, 7] = "Requerido";
            oSheet.Cells[1, 8] = "Marca";
            oSheet.Cells[1, 9] = "Unidad Medida";
            oSheet.Cells[1, 10] = "Ubicacion";
            oSheet.Cells[1, 11] = "Categoria";


        }

        private void Termina_applicacion()
        {
            try
            {
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(oXL);
            }
            catch
            {

            }

        }
        
        public void Guarda_archivo_excel()
        {
            try
            {
                oWB.Save();
            }
            catch
            {

            }
        }
        private void Close_Excel()
        {
            try
            {
                oXL.Quit();
            }
            catch
            {

            }
        }

        private void buttonMaxMin_Click(object sender, EventArgs e)
        {
            botton_excel_operacion();
            Limpia_datagridview_datos();
            Materiales_disponibles_busqueda.Clear();
            Materiales_disponibles_busqueda = class_materiales.Adquiere_materiales_MaxMIn_en_base_datos();
            Rellena_partidas_materiales_disponibles();
            Verifica_datagridview_para_activar_filtros();
            botton_excel_operacion();
            Aparece_botton_cancelar();
        }

        private void Limpia_datagridview_datos()
        {
            dataGridViewPartidasMaterialSeleccion.Rows.Clear();
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            botton_excel_operacion();
            Limpia_datagridview_datos();
            Desaparece_etiquetas_combos_filtros();
            Desactiva_boton_filtros_materiales();
            Materiales_disponibles_busqueda.Clear();
            Materiales_disponibles_busqueda = class_materiales.Adquiere_materiales_Min_en_base_datos();
            Rellena_partidas_materiales_disponibles();
            Verifica_datagridview_para_activar_filtros();
            botton_excel_operacion();
            Aparece_botton_cancelar();
        }

        private void botton_excel_operacion()
        {
           if(!buttonExcel.Visible)
            {
                buttonExcel.Visible = true;
            }
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            botton_excel_operacion();
            Limpia_datagridview_datos();
            Desaparece_etiquetas_combos_filtros();
            Desactiva_boton_filtros_materiales();
            Materiales_disponibles_busqueda.Clear();
            Materiales_disponibles_busqueda = class_materiales.Adquiere_materiales_Max_en_base_datos();
            Rellena_partidas_materiales_disponibles();
            Verifica_datagridview_para_activar_filtros();
            botton_excel_operacion();
            Aparece_botton_cancelar();
        }

        private void Verifica_datagridview_para_activar_filtros()
        {
            if (dataGridViewPartidasMaterialSeleccion.Rows.Count != 0)
            {
                Activa_boton_filtros_materiales();
            }
        }

        private void Activa_boton_filtros_materiales()
        {
            buttonFiltrosMateriales.Enabled = true;
        }

        private void Desactiva_boton_filtros_materiales()
        {
            buttonFiltrosMateriales.Enabled = false;
        }

        private void buttonBusquedaBaseDatos_Click(object sender, EventArgs e)
        {
            Desactiva_botones_oeracion();
            if (dataGridViewPartidasMaterialSeleccion.Rows.Count!=0)
            {
                Aparece_etiquetas_combos_filtros();
                Limpiar_combo_marca();
                Limpiar_combo_categoria();
                Rellena_combo_marca_materiales_en_datagridview();
                Rellena_combo_categoria_materiales_en_datgridview();
            }
        }

        private void Desactiva_botones_oeracion()
        {
            buttonMaxMin.Enabled = false;
            buttonMin.Enabled = false;
            buttonMax.Enabled = false;
        }

        private void Activa_botones_operacion()
        {
            buttonMaxMin.Enabled = true;
            buttonMin.Enabled = true;
            buttonMax.Enabled = true;
        }

        private void Limpiar_combo_categoria()
        {
            comboBoxFiltroCategoria.Items.Clear();
            comboBoxFiltroCategoria.Text = "";
        }

        private void Limpiar_combo_marca()
        {
            comboBoxFiltroMarca.Items.Clear();
            comboBoxFiltroMarca.Text = "";
        }

        private void Rellena_combo_categoria_materiales_en_datgridview()
        {
            foreach (Material material in Materiales_disponibles_busqueda)
            {
                if (!comboBoxFiltroCategoria.Items.Contains(material.Categoria) && material.Categoria != "")
                {
                    comboBoxFiltroCategoria.Items.Add(material.Categoria);
                }
            }
        }

        private void Rellena_combo_marca_materiales_en_datagridview()
        {
            foreach(Material material in Materiales_disponibles_busqueda)
            {
                if(!comboBoxFiltroMarca.Items.Contains(material.Marca) && material.Marca !="")
                {
                    comboBoxFiltroMarca.Items.Add(material.Marca);
                }
            }
        }

        private void Aparece_etiquetas_combos_filtros()
        {
            labelFiltroMarca.Visible = true;
            labelFiltroCatergoria.Visible = true;
            comboBoxFiltroMarca.Visible = true;
            comboBoxFiltroCategoria.Visible = true;
        }

        private void Desaparece_etiquetas_combos_filtros()
        {
            labelFiltroMarca.Visible = false;
            labelFiltroCatergoria.Visible = false;
            comboBoxFiltroMarca.Visible = false;
            comboBoxFiltroCategoria.Visible = false;
        }

        private void Aparece_botton_cancelar()
        {
            buttonCancelar.Visible = true;
        }

        private void Desaparece_botton_cancelar()
        {
            buttonCancelar.Visible = false;
        }

        private void comboBoxFiltroMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            Limpia_datagridview_datos();
            Materiales_disponibles_filtros.Clear();
            foreach (Material material in Materiales_disponibles_busqueda)
            {
                if (comboBoxFiltroMarca.Text != "" && comboBoxFiltroCategoria.Text != "")
                {
                    if (material.Marca == comboBoxFiltroMarca.Text && material.Categoria == comboBoxFiltroCategoria.Text)
                    {
                        Materiales_disponibles_filtros.Add(material);
                    }

                }
                else if (comboBoxFiltroMarca.Text == "" && comboBoxFiltroCategoria.Text != "")
                {
                    if (material.Categoria == comboBoxFiltroCategoria.Text)
                    {
                        Materiales_disponibles_filtros.Add(material);
                    }
                }

                else if (comboBoxFiltroMarca.Text != "" && comboBoxFiltroCategoria.Text == "")
                {
                    if (material.Marca == comboBoxFiltroMarca.Text)
                    {
                        Materiales_disponibles_filtros.Add(material);
                    }
                }
            }
            Rellena_partidas_materiales_filtros();
            botton_excel_operacion();
            Aparece_botton_cancelar();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Limpiar_combo_categoria();
            Limpiar_combo_marca();
            Limpia_datagridview_datos();
            Desaparece_etiquetas_combos_filtros();
            Desactiva_boton_filtros_materiales();
            Desaparece_boton_excel();
            Desaparece_botton_cancelar();
            Activa_botones_operacion();
        }

        private void comboBoxFiltroCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Limpia_datagridview_datos();
            Materiales_disponibles_filtros.Clear();
            foreach (Material material in Materiales_disponibles_busqueda)
            {
                if (comboBoxFiltroMarca.Text != "" && comboBoxFiltroCategoria.Text != "")
                {
                    if (material.Marca == comboBoxFiltroMarca.Text && material.Categoria == comboBoxFiltroCategoria.Text)
                    {
                        Materiales_disponibles_filtros.Add(material);
                    }

                }
                else if (comboBoxFiltroMarca.Text == "" && comboBoxFiltroCategoria.Text != "")
                {
                    if (material.Categoria == comboBoxFiltroCategoria.Text)
                    {
                        Materiales_disponibles_filtros.Add(material);
                    }
                }

                else if (comboBoxFiltroMarca.Text != "" && comboBoxFiltroCategoria.Text == "")
                {
                    if (material.Marca == comboBoxFiltroMarca.Text)
                    {
                        Materiales_disponibles_filtros.Add(material);
                    }
                }
            }
            Rellena_partidas_materiales_filtros();
            botton_excel_operacion();
            Aparece_botton_cancelar();
        }
    }
}
 