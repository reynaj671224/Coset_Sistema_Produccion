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
        public Material Material_seleccionado_data_view = new Material();
        public string agregar_seleccion = "";
        public Excel.Application oXL = null;
        public Excel.Worksheet oSheet = null;
        public Excel.Workbook oWB = null;
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
            foreach (Material material in Materiales_disponibles_busqueda)
            {
                if (material.error == "")
                {
                    try
                    {
                        if (Convert.ToInt32(material.Cantidad) < ((Convert.ToInt32(material.Maximo) - Convert.ToInt32(material.Minimo)) / 2))
                        {
                            Material_requerido = Convert.ToInt32(material.Maximo) - Convert.ToInt32(material.Cantidad);
                            if(Material_requerido < 0)
                            {
                                Material_requerido = 0;
                            }
                        }


                        dataGridViewPartidasMaterialSeleccion.Rows.Add(material.Codigo, material.Codigo_proveedor,
                            material.Descripcion, material.Minimo, material.Maximo, material.Cantidad, Material_requerido.ToString(), material.Marca, material.Unidad_medida, material.foto);
                    }
                    catch(Exception ex)
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
            }
            Activa_datagrid_materiales();
            
        }

        private void Activa_datagrid_materiales()
        {
            dataGridViewPartidasMaterialSeleccion.Enabled = true;
        }

        private void Forma_Materiales_Seleccion_Load(object sender, EventArgs e)
        {
            
            Materiales_disponibles_busqueda = class_materiales.Adquiere_materiales_MaxMIn_en_base_datos();
            Rellena_partidas_materiales_disponibles();
        }

        private void dataGridViewPartidasMaterialSeleccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPartidasMaterialSeleccion.Rows[e.RowIndex].Cells["Foto"].Value != null)
            {
                Material_seleccionado_data_view = Materiales_disponibles_busqueda.Find(material =>
                        material.Codigo.Contains(dataGridViewPartidasMaterialSeleccion.Rows[e.RowIndex].Cells["Codigo_partida"]
                        .Value.ToString()));
                if (dataGridViewPartidasMaterialSeleccion.Rows[e.RowIndex].Cells["Foto"].Value.ToString() != "")
                {
                    Aparece_foto_material();
                    try
                    {
                        dataGridViewPartidasMaterialSeleccion.Rows[e.RowIndex].Cells["Codigo_partida"].Value.ToString();
                        pictureBoxMaterial.Image = Image.FromFile(@appPath + "\\Fotos\\" +
                            dataGridViewPartidasMaterialSeleccion.Rows[e.RowIndex].Cells["Foto"].Value.ToString());

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    Desaparece_foto_material();
                }
            }
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
            Close_Excel();
            Termina_applicacion();
            Elimina_archivo_excel();
            this.Close();
            GC.Collect();
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            Desactiva_boton_excel();
            Elimina_archivo_excel();
            if (Inicia_Excel())
            {
                oXL.Visible = true;
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
            }
        }

        private bool Abrir_Archivo_Excel()
        {
            try
            {
                oWB = oXL.Workbooks.Open(appPath + "\\Maximos_minimos.xlsx");
                return true;
            }
            catch
            {
                MessageBox.Show("Maximos_minimos.xlsx No existe en el Folder de aplicacion", "Maximos Minimos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            try
            {
                File.Copy(@appPath + "\\Excel_template.xlsx", @appPath + "\\Maximos_minimos.xlsx", true);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void Elimina_archivo_excel()
        {
            try
            {
                File.Delete(@appPath + "\\Maximos_minimos.xlsx");
            }
            catch
            {

            }
        }

        private void Desactiva_boton_excel()
        {
            buttonExcel.Enabled = false;
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

        }

        private void Termina_applicacion()
        {
            if (oXL != null)
            {
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(oXL);
            }
        }
        public bool Borrar_archivo_excel()
        {
            try
            {
                File.Delete(appPath + "\\maximos-mininos.xlsx");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Guarda_archivo_excel()
        {
            oWB.Save();
        }
        private void Close_Excel()
        {
            Elimina_archivo_excel();
            if (oXL!=null)
            {
                oXL.Quit();
                oXL = null;
                oSheet = null;
                oWB = null;
            }
            
        }
    }
}
 