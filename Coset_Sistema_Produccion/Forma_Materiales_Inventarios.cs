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
using System.IO;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace Coset_Sistema_Produccion
{
    public partial class Forma_Materiales_Inventarios : Form
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
        public Excel._Worksheet oSheet = null;
        public Forma_Materiales_Inventarios()
        {
            InitializeComponent();
        }


        private void Aparece_boton_no_agregar_material()
        {
            buttonRegresarNoAgregar.Visible = true;
        }


        private void Rellena_partidas_materiales_disponibles() 
        {
            foreach (Material material in Materiales_disponibles_busqueda)
            {
                dataGridViewPartidasMaterialSeleccion.Rows.Add(material.Codigo, material.Codigo_proveedor,
                    material.Descripcion, material.Minimo, material.Maximo, material.Cantidad, material.Marca, material.Unidad_medida, material.foto);
            }
            Activa_datagrid_materiales();
            
        }

        private void Activa_datagrid_materiales()
        {
            dataGridViewPartidasMaterialSeleccion.Enabled = true;
        }

        private void Forma_Materiales_Seleccion_Load(object sender, EventArgs e)
        {
            Materiales_disponibles_busqueda = class_materiales.Adquiere_materiales_inventarios_en_base_datos();
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
            this.Close();
            GC.Collect();
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            try
            {
                //Start Excel and get Application object.
                oXL = new Excel.Application();
                oXL.Visible = true;
                oSheet = oXL.ActiveSheet;
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Imprime_titiulos_excel()
        {
            oSheet.Cells[1, 1] = "Codigo Material";
            oSheet.Cells[1, 2] = "Codigo Proveedor";
            oSheet.Cells[1, 3] = "Descripcion";
            oSheet.Cells[1, 4] = "Cantidad";
            oSheet.Cells[1, 5] = "Marca";
            oSheet.Cells[1, 6] = "Unidad Medida";

        }

        private void Termina_applicacion()
        {
            if (oXL != null)
            {
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(oXL);
            }
        }

        private void Close_Excel()
        {
            if (oXL != null)
            {
                oXL.Quit();
                oXL = null;
                oSheet = null;
            }

        }
    }
}
 