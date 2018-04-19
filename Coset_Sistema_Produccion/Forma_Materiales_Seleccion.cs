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
        public Material Material_seleccionado_data_view = null;
        public string agregar_seleccion = "";
        public Forma_Materiales_Seleccion(List<Material> materiales_busqueda_disponibles,string Operacion_materiales)
        {
            InitializeComponent();

            if (Operacion_materiales == "Agregar")
            {
                Aparece_boton_agregar_material();
                Aparece_boton_no_agregar_material();
            }
            else if(Operacion_materiales == "Requisiciones")
            {
                Aparece_boton_agregar_material();
          
            }

            Rellena_partidas_materiales_disponibles(materiales_busqueda_disponibles);
        }

        private void Aparece_boton_seleccionar_material()
        {
            buttonSeleccionMaterial.Visible = true;
        }

        private void Aparece_boton_no_agregar_material()
        {
            buttonRegresarNoAgregar.Visible = true;
        }

        private void Aparece_boton_agregar_material()
        {
            buttonAgregarMaterial.Visible = true;
        }

        private void Rellena_partidas_materiales_disponibles(List<Material> materiales_busqueda_disponibles) 
        {
            Materiales_disponibles_busqueda = materiales_busqueda_disponibles;
            foreach (Material material in materiales_busqueda_disponibles)
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
            buttonSeleccionMaterial.Visible = true;
            buttonAgregarMaterial.Visible = false;
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

        private void Desaparece_foto_material()
        {
            pictureBoxMaterial.Visible = false;
        }

        private void Aparece_foto_material()
        {
            pictureBoxMaterial.Visible = true;
        }
        public Material  Material_seleccionado
        {
            
            get
                { return Material_seleccionado_data_view; }
        }
        public string Material_operacion_seleccion
        {

            get
            { return agregar_seleccion; }
        }

        private void buttonSeleccionMaterial_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Materiales_disponibles_busqueda = null;
            this.Close();
            GC.Collect();
        }

        private void buttonAgregarMaterial_Click(object sender, EventArgs e)
        {
            agregar_seleccion = "Agregar";
            Materiales_disponibles_busqueda = null;
            this.Close();
            GC.Collect();
        }

        private void buttonRegresarNoAgregar_Click(object sender, EventArgs e)
        {
            Materiales_disponibles_busqueda = null;
            this.Close();
            GC.Collect();
        }
    }
}
 