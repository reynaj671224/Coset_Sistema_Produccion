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
    public partial class Forma_Materiales_Seleccion : Form
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
        public string Material_seleccionado = "";
        public Forma_Materiales_Seleccion(List<Material> materiales_busqueda_disponibles)
        {
            InitializeComponent();
            Rellena_partidas_materiales_disponibles(materiales_busqueda_disponibles);
        }

        private void Rellena_partidas_materiales_disponibles(List<Material> materiales_busqueda_disponibles) 
        {
            foreach(Material material in materiales_busqueda_disponibles)
            {
                dataGridViewPartidasMaterialSeleccion.Rows.Add(material.Codigo, material.Codigo_proveedor,
                    material.Descripcion, material.Cantidad, material.Marca, material.Unidad_medida, material.foto);
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
            if (dataGridViewPartidasMaterialSeleccion.Rows[e.RowIndex].Cells["Foto"].Value.ToString() != "")
            {
                Aparece_foto_material();
                try
                {
                    Material_seleccionado = dataGridViewPartidasMaterialSeleccion.Rows[e.RowIndex].Cells["Codigo_partida"].Value.ToString();
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

        private void Desaparece_foto_material()
        {
            pictureBoxMaterial.Visible = false;
        }

        private void Aparece_foto_material()
        {
            pictureBoxMaterial.Visible = true;
        }
        public string  Codigo_material_seleccionado
        {
            
            get
                { return Material_seleccionado; }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
 