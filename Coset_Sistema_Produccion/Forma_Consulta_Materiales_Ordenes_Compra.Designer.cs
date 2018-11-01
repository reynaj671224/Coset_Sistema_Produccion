namespace Coset_Sistema_Produccion
{
    partial class Forma_Consulta_Materiales_Ordenes_Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma_Consulta_Materiales_Ordenes_Compra));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonBusquedaBaseDatos = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.labelCodigoMaterial = new System.Windows.Forms.Label();
            this.textBoxCodigoMaterial = new System.Windows.Forms.TextBox();
            this.labelCodigoProveedor = new System.Windows.Forms.Label();
            this.textBoxCodigoProveedor = new System.Windows.Forms.TextBox();
            this.timerConsultaMaterial = new System.Windows.Forms.Timer(this.components);
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.pictureBoxMaterial = new System.Windows.Forms.PictureBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.textBoxUbicacion = new System.Windows.Forms.TextBox();
            this.labelUbicacion = new System.Windows.Forms.Label();
            this.dataGridViewPartidasMaterialSelecionOrdenesCompra = new System.Windows.Forms.DataGridView();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.Codigo_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orden_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades_Ordenadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades_recibidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartidasMaterialSelecionOrdenesCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1013, 530);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonBusquedaBaseDatos
            // 
            this.buttonBusquedaBaseDatos.BackColor = System.Drawing.Color.White;
            this.buttonBusquedaBaseDatos.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBusquedaBaseDatos.Image = ((System.Drawing.Image)(resources.GetObject("buttonBusquedaBaseDatos.Image")));
            this.buttonBusquedaBaseDatos.Location = new System.Drawing.Point(922, 284);
            this.buttonBusquedaBaseDatos.Name = "buttonBusquedaBaseDatos";
            this.buttonBusquedaBaseDatos.Size = new System.Drawing.Size(79, 74);
            this.buttonBusquedaBaseDatos.TabIndex = 3;
            this.buttonBusquedaBaseDatos.Text = "Buscar";
            this.buttonBusquedaBaseDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBusquedaBaseDatos.UseVisualStyleBackColor = false;
            this.buttonBusquedaBaseDatos.Visible = false;
            this.buttonBusquedaBaseDatos.Click += new System.EventHandler(this.buttonBusquedaBaseDatos_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.AutoSize = true;
            this.buttonHome.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(922, 444);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(79, 74);
            this.buttonHome.TabIndex = 5;
            this.buttonHome.Text = "Regresar";
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // labelCodigoMaterial
            // 
            this.labelCodigoMaterial.AutoSize = true;
            this.labelCodigoMaterial.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoMaterial.Image = ((System.Drawing.Image)(resources.GetObject("labelCodigoMaterial.Image")));
            this.labelCodigoMaterial.Location = new System.Drawing.Point(43, 32);
            this.labelCodigoMaterial.Name = "labelCodigoMaterial";
            this.labelCodigoMaterial.Size = new System.Drawing.Size(94, 16);
            this.labelCodigoMaterial.TabIndex = 6;
            this.labelCodigoMaterial.Text = "Codigo Material";
            this.labelCodigoMaterial.Click += new System.EventHandler(this.labelCodigoMaterial_Click);
            // 
            // textBoxCodigoMaterial
            // 
            this.textBoxCodigoMaterial.BackColor = System.Drawing.Color.Yellow;
            this.textBoxCodigoMaterial.Location = new System.Drawing.Point(173, 32);
            this.textBoxCodigoMaterial.Name = "textBoxCodigoMaterial";
            this.textBoxCodigoMaterial.Size = new System.Drawing.Size(135, 20);
            this.textBoxCodigoMaterial.TabIndex = 7;
            this.textBoxCodigoMaterial.TextChanged += new System.EventHandler(this.textBoxCodigoMaterial_TextChanged);
            // 
            // labelCodigoProveedor
            // 
            this.labelCodigoProveedor.AutoSize = true;
            this.labelCodigoProveedor.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoProveedor.Image = ((System.Drawing.Image)(resources.GetObject("labelCodigoProveedor.Image")));
            this.labelCodigoProveedor.Location = new System.Drawing.Point(43, 63);
            this.labelCodigoProveedor.Name = "labelCodigoProveedor";
            this.labelCodigoProveedor.Size = new System.Drawing.Size(101, 16);
            this.labelCodigoProveedor.TabIndex = 8;
            this.labelCodigoProveedor.Text = "Codigo Proveedor";
            this.labelCodigoProveedor.Click += new System.EventHandler(this.labelCodigoProveedor_Click);
            // 
            // textBoxCodigoProveedor
            // 
            this.textBoxCodigoProveedor.BackColor = System.Drawing.Color.Yellow;
            this.textBoxCodigoProveedor.Location = new System.Drawing.Point(173, 61);
            this.textBoxCodigoProveedor.Name = "textBoxCodigoProveedor";
            this.textBoxCodigoProveedor.Size = new System.Drawing.Size(135, 20);
            this.textBoxCodigoProveedor.TabIndex = 9;
            this.textBoxCodigoProveedor.TextChanged += new System.EventHandler(this.textBoxCodigoProveedor_TextChanged);
            // 
            // timerConsultaMaterial
            // 
            this.timerConsultaMaterial.Enabled = true;
            this.timerConsultaMaterial.Interval = 1000;
            this.timerConsultaMaterial.Tick += new System.EventHandler(this.timerConsultaMaterial_Tick);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.BackColor = System.Drawing.Color.Yellow;
            this.textBoxDescripcion.Location = new System.Drawing.Point(175, 90);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(430, 20);
            this.textBoxDescripcion.TabIndex = 29;
            this.textBoxDescripcion.TextChanged += new System.EventHandler(this.textBoxDescripcion_TextChanged);
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Image = ((System.Drawing.Image)(resources.GetObject("labelDescripcion.Image")));
            this.labelDescripcion.Location = new System.Drawing.Point(43, 94);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(71, 16);
            this.labelDescripcion.TabIndex = 28;
            this.labelDescripcion.Text = "Descripcion";
            this.labelDescripcion.Click += new System.EventHandler(this.labelDescripcion_Click);
            // 
            // pictureBoxMaterial
            // 
            this.pictureBoxMaterial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxMaterial.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMaterial.Image")));
            this.pictureBoxMaterial.Location = new System.Drawing.Point(622, 32);
            this.pictureBoxMaterial.Name = "pictureBoxMaterial";
            this.pictureBoxMaterial.Size = new System.Drawing.Size(379, 222);
            this.pictureBoxMaterial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMaterial.TabIndex = 40;
            this.pictureBoxMaterial.TabStop = false;
            this.pictureBoxMaterial.Visible = false;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.BackColor = System.Drawing.Color.Yellow;
            this.textBoxMarca.Location = new System.Drawing.Point(445, 61);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(160, 20);
            this.textBoxMarca.TabIndex = 42;
            this.textBoxMarca.TextChanged += new System.EventHandler(this.textBoxMarca_TextChanged);
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Image = ((System.Drawing.Image)(resources.GetObject("labelMarca.Image")));
            this.labelMarca.Location = new System.Drawing.Point(359, 61);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(41, 16);
            this.labelMarca.TabIndex = 41;
            this.labelMarca.Text = "Marca";
            this.labelMarca.Click += new System.EventHandler(this.labelMarca_Click);
            // 
            // textBoxUbicacion
            // 
            this.textBoxUbicacion.BackColor = System.Drawing.Color.Yellow;
            this.textBoxUbicacion.Enabled = false;
            this.textBoxUbicacion.Location = new System.Drawing.Point(445, 35);
            this.textBoxUbicacion.Name = "textBoxUbicacion";
            this.textBoxUbicacion.Size = new System.Drawing.Size(160, 20);
            this.textBoxUbicacion.TabIndex = 44;
            this.textBoxUbicacion.Visible = false;
            // 
            // labelUbicacion
            // 
            this.labelUbicacion.AutoSize = true;
            this.labelUbicacion.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUbicacion.Image = ((System.Drawing.Image)(resources.GetObject("labelUbicacion.Image")));
            this.labelUbicacion.Location = new System.Drawing.Point(359, 37);
            this.labelUbicacion.Name = "labelUbicacion";
            this.labelUbicacion.Size = new System.Drawing.Size(60, 16);
            this.labelUbicacion.TabIndex = 43;
            this.labelUbicacion.Text = "Ubicacion";
            this.labelUbicacion.Visible = false;
            this.labelUbicacion.Click += new System.EventHandler(this.labelUbicacion_Click);
            // 
            // dataGridViewPartidasMaterialSelecionOrdenesCompra
            // 
            this.dataGridViewPartidasMaterialSelecionOrdenesCompra.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewPartidasMaterialSelecionOrdenesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPartidasMaterialSelecionOrdenesCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_partida,
            this.Codigo_Proveedor,
            this.Descripcion,
            this.Orden_Compra,
            this.Unidades_Ordenadas,
            this.Unidades_recibidas,
            this.foto});
            this.dataGridViewPartidasMaterialSelecionOrdenesCompra.Enabled = false;
            this.dataGridViewPartidasMaterialSelecionOrdenesCompra.Location = new System.Drawing.Point(12, 284);
            this.dataGridViewPartidasMaterialSelecionOrdenesCompra.Name = "dataGridViewPartidasMaterialSelecionOrdenesCompra";
            this.dataGridViewPartidasMaterialSelecionOrdenesCompra.Size = new System.Drawing.Size(825, 234);
            this.dataGridViewPartidasMaterialSelecionOrdenesCompra.TabIndex = 50;
            this.dataGridViewPartidasMaterialSelecionOrdenesCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPartidasMaterialSeleccion_CellClick);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AutoSize = true;
            this.buttonCancelar.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.Location = new System.Drawing.Point(922, 364);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(79, 74);
            this.buttonCancelar.TabIndex = 51;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Visible = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // Codigo_partida
            // 
            this.Codigo_partida.HeaderText = "Codigo Material";
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
            // Orden_Compra
            // 
            this.Orden_Compra.HeaderText = "Orden Compra";
            this.Orden_Compra.Name = "Orden_Compra";
            // 
            // Unidades_Ordenadas
            // 
            this.Unidades_Ordenadas.HeaderText = "Unidades Ordenadas";
            this.Unidades_Ordenadas.Name = "Unidades_Ordenadas";
            // 
            // Unidades_recibidas
            // 
            this.Unidades_recibidas.HeaderText = "Unidades Recibidas";
            this.Unidades_recibidas.Name = "Unidades_recibidas";
            // 
            // foto
            // 
            this.foto.HeaderText = "foto";
            this.foto.Name = "foto";
            this.foto.Visible = false;
            // 
            // Forma_Consulta_Materiales_Ordenes_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 530);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.dataGridViewPartidasMaterialSelecionOrdenesCompra);
            this.Controls.Add(this.textBoxUbicacion);
            this.Controls.Add(this.labelUbicacion);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.pictureBoxMaterial);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.textBoxCodigoProveedor);
            this.Controls.Add(this.labelCodigoProveedor);
            this.Controls.Add(this.textBoxCodigoMaterial);
            this.Controls.Add(this.labelCodigoMaterial);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonBusquedaBaseDatos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Forma_Consulta_Materiales_Ordenes_Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Materiales Ordenes Compta";
            this.Load += new System.EventHandler(this.Forma_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartidasMaterialSelecionOrdenesCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBusquedaBaseDatos;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label labelCodigoMaterial;
        private System.Windows.Forms.TextBox textBoxCodigoMaterial;
        private System.Windows.Forms.Label labelCodigoProveedor;
        private System.Windows.Forms.TextBox textBoxCodigoProveedor;
        private System.Windows.Forms.Timer timerConsultaMaterial;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.PictureBox pictureBoxMaterial;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.TextBox textBoxUbicacion;
        private System.Windows.Forms.Label labelUbicacion;
        private System.Windows.Forms.DataGridView dataGridViewPartidasMaterialSelecionOrdenesCompra;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orden_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades_Ordenadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades_recibidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn foto;
    }
}