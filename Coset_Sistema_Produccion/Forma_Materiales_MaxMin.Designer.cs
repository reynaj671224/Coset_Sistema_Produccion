namespace Coset_Sistema_Produccion
{
    partial class Forma_Materiales_MaxMin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma_Materiales_MaxMin));
            this.timerAgregarMaterial = new System.Windows.Forms.Timer(this.components);
            this.timerActualizrempleado = new System.Windows.Forms.Timer(this.components);
            this.timerEliminaempleado = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxMaterial = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewPartidasMaterialSeleccion = new System.Windows.Forms.DataGridView();
            this.Codigo_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requerido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad_medida_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRegresarNoAgregar = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonMaxMin = new System.Windows.Forms.Button();
            this.buttonFiltrosMateriales = new System.Windows.Forms.Button();
            this.comboBoxFiltroCategoria = new System.Windows.Forms.ComboBox();
            this.labelFiltroCatergoria = new System.Windows.Forms.Label();
            this.comboBoxFiltroMarca = new System.Windows.Forms.ComboBox();
            this.labelFiltroMarca = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartidasMaterialSeleccion)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMaterial
            // 
            this.pictureBoxMaterial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxMaterial.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMaterial.Image")));
            this.pictureBoxMaterial.Location = new System.Drawing.Point(745, 24);
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
            this.pictureBox1.Size = new System.Drawing.Size(1225, 561);
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
            this.Maximo,
            this.Cantidad,
            this.Requerido,
            this.Marca,
            this.Unidad_medida_partida,
            this.Ubicacion,
            this.Categoria,
            this.Foto});
            this.dataGridViewPartidasMaterialSeleccion.Enabled = false;
            this.dataGridViewPartidasMaterialSeleccion.Location = new System.Drawing.Point(26, 290);
            this.dataGridViewPartidasMaterialSeleccion.Name = "dataGridViewPartidasMaterialSeleccion";
            this.dataGridViewPartidasMaterialSeleccion.Size = new System.Drawing.Size(1086, 259);
            this.dataGridViewPartidasMaterialSeleccion.TabIndex = 49;
            this.dataGridViewPartidasMaterialSeleccion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPartidasMaterialSeleccion_CellClick);
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
            this.Descripcion.Width = 300;
            // 
            // Minimo
            // 
            this.Minimo.HeaderText = "Minimo";
            this.Minimo.Name = "Minimo";
            this.Minimo.Width = 50;
            // 
            // Maximo
            // 
            this.Maximo.HeaderText = "Maximo";
            this.Maximo.Name = "Maximo";
            this.Maximo.Width = 50;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 50;
            // 
            // Requerido
            // 
            this.Requerido.HeaderText = "Requerido";
            this.Requerido.Name = "Requerido";
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
            // Ubicacion
            // 
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.Name = "Ubicacion";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // Foto
            // 
            this.Foto.HeaderText = "Foto";
            this.Foto.Name = "Foto";
            this.Foto.Visible = false;
            // 
            // buttonRegresarNoAgregar
            // 
            this.buttonRegresarNoAgregar.AutoSize = true;
            this.buttonRegresarNoAgregar.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresarNoAgregar.Image = ((System.Drawing.Image)(resources.GetObject("buttonRegresarNoAgregar.Image")));
            this.buttonRegresarNoAgregar.Location = new System.Drawing.Point(1134, 475);
            this.buttonRegresarNoAgregar.Name = "buttonRegresarNoAgregar";
            this.buttonRegresarNoAgregar.Size = new System.Drawing.Size(79, 74);
            this.buttonRegresarNoAgregar.TabIndex = 55;
            this.buttonRegresarNoAgregar.Text = "Regresar";
            this.buttonRegresarNoAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonRegresarNoAgregar.UseVisualStyleBackColor = true;
            this.buttonRegresarNoAgregar.Click += new System.EventHandler(this.buttonRegresarNoAgregar_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.AutoSize = true;
            this.buttonExcel.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcel.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcel.Image")));
            this.buttonExcel.Location = new System.Drawing.Point(1134, 312);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(79, 74);
            this.buttonExcel.TabIndex = 56;
            this.buttonExcel.Text = "Excel";
            this.buttonExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Visible = false;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMax.Image = ((System.Drawing.Image)(resources.GetObject("buttonMax.Image")));
            this.buttonMax.Location = new System.Drawing.Point(365, 42);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonMax.Size = new System.Drawing.Size(79, 74);
            this.buttonMax.TabIndex = 58;
            this.buttonMax.Text = "MAX";
            this.buttonMax.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.AutoSize = true;
            this.buttonMin.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMin.Image = ((System.Drawing.Image)(resources.GetObject("buttonMin.Image")));
            this.buttonMin.Location = new System.Drawing.Point(273, 42);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(86, 74);
            this.buttonMin.TabIndex = 57;
            this.buttonMin.Text = "MIN";
            this.buttonMin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // buttonMaxMin
            // 
            this.buttonMaxMin.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaxMin.Image = ((System.Drawing.Image)(resources.GetObject("buttonMaxMin.Image")));
            this.buttonMaxMin.Location = new System.Drawing.Point(450, 42);
            this.buttonMaxMin.Name = "buttonMaxMin";
            this.buttonMaxMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonMaxMin.Size = new System.Drawing.Size(79, 74);
            this.buttonMaxMin.TabIndex = 59;
            this.buttonMaxMin.Text = "MAX/MIN";
            this.buttonMaxMin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonMaxMin.UseVisualStyleBackColor = true;
            this.buttonMaxMin.Click += new System.EventHandler(this.buttonMaxMin_Click);
            // 
            // buttonFiltrosMateriales
            // 
            this.buttonFiltrosMateriales.BackColor = System.Drawing.Color.White;
            this.buttonFiltrosMateriales.Enabled = false;
            this.buttonFiltrosMateriales.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltrosMateriales.Image = ((System.Drawing.Image)(resources.GetObject("buttonFiltrosMateriales.Image")));
            this.buttonFiltrosMateriales.Location = new System.Drawing.Point(535, 42);
            this.buttonFiltrosMateriales.Name = "buttonFiltrosMateriales";
            this.buttonFiltrosMateriales.Size = new System.Drawing.Size(79, 74);
            this.buttonFiltrosMateriales.TabIndex = 60;
            this.buttonFiltrosMateriales.Text = "Filtros";
            this.buttonFiltrosMateriales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFiltrosMateriales.UseVisualStyleBackColor = false;
            this.buttonFiltrosMateriales.Click += new System.EventHandler(this.buttonBusquedaBaseDatos_Click);
            // 
            // comboBoxFiltroCategoria
            // 
            this.comboBoxFiltroCategoria.FormattingEnabled = true;
            this.comboBoxFiltroCategoria.Location = new System.Drawing.Point(198, 187);
            this.comboBoxFiltroCategoria.Name = "comboBoxFiltroCategoria";
            this.comboBoxFiltroCategoria.Size = new System.Drawing.Size(246, 21);
            this.comboBoxFiltroCategoria.Sorted = true;
            this.comboBoxFiltroCategoria.TabIndex = 97;
            this.comboBoxFiltroCategoria.Visible = false;
            this.comboBoxFiltroCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltroCategoria_SelectedIndexChanged);
            // 
            // labelFiltroCatergoria
            // 
            this.labelFiltroCatergoria.AutoSize = true;
            this.labelFiltroCatergoria.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltroCatergoria.Image = ((System.Drawing.Image)(resources.GetObject("labelFiltroCatergoria.Image")));
            this.labelFiltroCatergoria.Location = new System.Drawing.Point(73, 189);
            this.labelFiltroCatergoria.Name = "labelFiltroCatergoria";
            this.labelFiltroCatergoria.Size = new System.Drawing.Size(96, 16);
            this.labelFiltroCatergoria.TabIndex = 96;
            this.labelFiltroCatergoria.Text = "Filtro Catergoria";
            this.labelFiltroCatergoria.Visible = false;
            // 
            // comboBoxFiltroMarca
            // 
            this.comboBoxFiltroMarca.FormattingEnabled = true;
            this.comboBoxFiltroMarca.Location = new System.Drawing.Point(198, 160);
            this.comboBoxFiltroMarca.Name = "comboBoxFiltroMarca";
            this.comboBoxFiltroMarca.Size = new System.Drawing.Size(246, 21);
            this.comboBoxFiltroMarca.Sorted = true;
            this.comboBoxFiltroMarca.TabIndex = 95;
            this.comboBoxFiltroMarca.Visible = false;
            this.comboBoxFiltroMarca.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltroMarca_SelectedIndexChanged);
            // 
            // labelFiltroMarca
            // 
            this.labelFiltroMarca.AutoSize = true;
            this.labelFiltroMarca.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltroMarca.Image = ((System.Drawing.Image)(resources.GetObject("labelFiltroMarca.Image")));
            this.labelFiltroMarca.Location = new System.Drawing.Point(73, 164);
            this.labelFiltroMarca.Name = "labelFiltroMarca";
            this.labelFiltroMarca.Size = new System.Drawing.Size(73, 16);
            this.labelFiltroMarca.TabIndex = 94;
            this.labelFiltroMarca.Text = "Filtro Marca";
            this.labelFiltroMarca.Visible = false;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AutoSize = true;
            this.buttonCancelar.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.Location = new System.Drawing.Point(1134, 395);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(79, 74);
            this.buttonCancelar.TabIndex = 98;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Visible = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // Forma_Materiales_MaxMin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 561);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.comboBoxFiltroCategoria);
            this.Controls.Add(this.labelFiltroCatergoria);
            this.Controls.Add(this.comboBoxFiltroMarca);
            this.Controls.Add(this.labelFiltroMarca);
            this.Controls.Add(this.buttonFiltrosMateriales);
            this.Controls.Add(this.buttonMaxMin);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.buttonRegresarNoAgregar);
            this.Controls.Add(this.dataGridViewPartidasMaterialSeleccion);
            this.Controls.Add(this.pictureBoxMaterial);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Forma_Materiales_MaxMin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materiales Maximos-Minimos";
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
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonMaxMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requerido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad_medida_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Foto;
        private System.Windows.Forms.Button buttonFiltrosMateriales;
        private System.Windows.Forms.ComboBox comboBoxFiltroCategoria;
        private System.Windows.Forms.Label labelFiltroCatergoria;
        private System.Windows.Forms.ComboBox comboBoxFiltroMarca;
        private System.Windows.Forms.Label labelFiltroMarca;
        private System.Windows.Forms.Button buttonCancelar;
    }
}