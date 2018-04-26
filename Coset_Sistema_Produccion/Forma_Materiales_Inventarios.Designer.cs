namespace Coset_Sistema_Produccion
{
    partial class Forma_Materiales_Inventarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma_Materiales_Inventarios));
            this.timerAgregarMaterial = new System.Windows.Forms.Timer(this.components);
            this.timerActualizrempleado = new System.Windows.Forms.Timer(this.components);
            this.timerEliminaempleado = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxMaterial = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewPartidasMaterialSeleccion = new System.Windows.Forms.DataGridView();
            this.buttonRegresarNoAgregar = new System.Windows.Forms.Button();
            this.Codigo_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad_medida_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartidasMaterialSeleccion)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMaterial
            // 
            this.pictureBoxMaterial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxMaterial.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMaterial.Image")));
            this.pictureBoxMaterial.Location = new System.Drawing.Point(344, 39);
            this.pictureBoxMaterial.Name = "pictureBoxMaterial";
            this.pictureBoxMaterial.Size = new System.Drawing.Size(379, 222);
            this.pictureBoxMaterial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMaterial.TabIndex = 40;
            this.pictureBoxMaterial.TabStop = false;
            this.pictureBoxMaterial.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1052, 561);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewPartidasMaterialSeleccion
            // 
            this.dataGridViewPartidasMaterialSeleccion.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewPartidasMaterialSeleccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPartidasMaterialSeleccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_partida,
            this.Codigo_Proveedor,
            this.Descripcion,
            this.Minimo,
            this.Cantidad,
            this.Maximo,
            this.Marca,
            this.Unidad_medida_partida,
            this.Foto});
            this.dataGridViewPartidasMaterialSeleccion.Enabled = false;
            this.dataGridViewPartidasMaterialSeleccion.Location = new System.Drawing.Point(56, 290);
            this.dataGridViewPartidasMaterialSeleccion.Name = "dataGridViewPartidasMaterialSeleccion";
            this.dataGridViewPartidasMaterialSeleccion.Size = new System.Drawing.Size(883, 259);
            this.dataGridViewPartidasMaterialSeleccion.TabIndex = 49;
            this.dataGridViewPartidasMaterialSeleccion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPartidasMaterialSeleccion_CellClick);
            // 
            // buttonRegresarNoAgregar
            // 
            this.buttonRegresarNoAgregar.AutoSize = true;
            this.buttonRegresarNoAgregar.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresarNoAgregar.Image = ((System.Drawing.Image)(resources.GetObject("buttonRegresarNoAgregar.Image")));
            this.buttonRegresarNoAgregar.Location = new System.Drawing.Point(957, 475);
            this.buttonRegresarNoAgregar.Name = "buttonRegresarNoAgregar";
            this.buttonRegresarNoAgregar.Size = new System.Drawing.Size(79, 74);
            this.buttonRegresarNoAgregar.TabIndex = 55;
            this.buttonRegresarNoAgregar.Text = "Regresar";
            this.buttonRegresarNoAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonRegresarNoAgregar.UseVisualStyleBackColor = true;
            this.buttonRegresarNoAgregar.Click += new System.EventHandler(this.buttonRegresarNoAgregar_Click);
            // 
            // Codigo_partida
            // 
            this.Codigo_partida.HeaderText = "Codigo";
            this.Codigo_partida.Name = "Codigo_partida";
            this.Codigo_partida.Width = 80;
            // 
            // Codigo_Proveedor
            // 
            this.Codigo_Proveedor.HeaderText = "Codigo Proveedor";
            this.Codigo_Proveedor.Name = "Codigo_Proveedor";
            this.Codigo_Proveedor.Width = 80;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 400;
            // 
            // Minimo
            // 
            this.Minimo.HeaderText = "Minimo";
            this.Minimo.Name = "Minimo";
            this.Minimo.Width = 50;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 50;
            // 
            // Maximo
            // 
            this.Maximo.HeaderText = "Maximo";
            this.Maximo.Name = "Maximo";
            this.Maximo.Width = 50;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.Width = 80;
            // 
            // Unidad_medida_partida
            // 
            this.Unidad_medida_partida.HeaderText = "Unidad Medida";
            this.Unidad_medida_partida.Name = "Unidad_medida_partida";
            this.Unidad_medida_partida.Width = 50;
            // 
            // Foto
            // 
            this.Foto.HeaderText = "Foto";
            this.Foto.Name = "Foto";
            this.Foto.Visible = false;
            // 
            // Forma_Materiales_Inventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 561);
            this.Controls.Add(this.buttonRegresarNoAgregar);
            this.Controls.Add(this.dataGridViewPartidasMaterialSeleccion);
            this.Controls.Add(this.pictureBoxMaterial);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Forma_Materiales_Inventarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materiales Inventarios";
            this.Load += new System.EventHandler(this.Forma_Materiales_Seleccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartidasMaterialSeleccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerAgregarMaterial;
        private System.Windows.Forms.Timer timerActualizrempleado;
        private System.Windows.Forms.Timer timerEliminaempleado;
        private System.Windows.Forms.PictureBox pictureBoxMaterial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewPartidasMaterialSeleccion;
        private System.Windows.Forms.Button buttonRegresarNoAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad_medida_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Foto;
    }
}