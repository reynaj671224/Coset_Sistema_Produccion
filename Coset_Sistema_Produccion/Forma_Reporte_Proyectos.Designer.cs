namespace Coset_Sistema_Produccion
{
    partial class Forma_Reporte_Proyectos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma_Reporte_Proyectos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonBorrarBasedeDatos = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonGuardarBasedeDatos = new System.Windows.Forms.Button();
            this.timerAgregarProyecto = new System.Windows.Forms.Timer(this.components);
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigoProyecto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewProyectoReportes = new System.Windows.Forms.DataGridView();
            this.comboBoxCodigoProyecto = new System.Windows.Forms.ComboBox();
            this.timerModificarClientes = new System.Windows.Forms.Timer(this.components);
            this.textBoxIngenieroCoset = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNombreProyecto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxCodigoCliente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxIngenieroCliente = new System.Windows.Forms.TextBox();
            this.Codigo_proyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_dibujo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_dibujos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProyectoReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1265, 521);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AutoSize = true;
            this.buttonCancelar.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.Location = new System.Drawing.Point(1177, 355);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(79, 74);
            this.buttonCancelar.TabIndex = 35;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Visible = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonBorrarBasedeDatos
            // 
            this.buttonBorrarBasedeDatos.AutoSize = true;
            this.buttonBorrarBasedeDatos.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrarBasedeDatos.Image = ((System.Drawing.Image)(resources.GetObject("buttonBorrarBasedeDatos.Image")));
            this.buttonBorrarBasedeDatos.Location = new System.Drawing.Point(1177, 251);
            this.buttonBorrarBasedeDatos.Name = "buttonBorrarBasedeDatos";
            this.buttonBorrarBasedeDatos.Size = new System.Drawing.Size(79, 74);
            this.buttonBorrarBasedeDatos.TabIndex = 34;
            this.buttonBorrarBasedeDatos.Text = "Eliminar";
            this.buttonBorrarBasedeDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBorrarBasedeDatos.UseVisualStyleBackColor = true;
            this.buttonBorrarBasedeDatos.Visible = false;
            // 
            // buttonHome
            // 
            this.buttonHome.AutoSize = true;
            this.buttonHome.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(1177, 435);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(79, 74);
            this.buttonHome.TabIndex = 33;
            this.buttonHome.Text = "Regresar";
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonGuardarBasedeDatos
            // 
            this.buttonGuardarBasedeDatos.AutoSize = true;
            this.buttonGuardarBasedeDatos.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarBasedeDatos.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardarBasedeDatos.Image")));
            this.buttonGuardarBasedeDatos.Location = new System.Drawing.Point(1177, 275);
            this.buttonGuardarBasedeDatos.Name = "buttonGuardarBasedeDatos";
            this.buttonGuardarBasedeDatos.Size = new System.Drawing.Size(79, 74);
            this.buttonGuardarBasedeDatos.TabIndex = 32;
            this.buttonGuardarBasedeDatos.Text = "Guardar";
            this.buttonGuardarBasedeDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonGuardarBasedeDatos.UseVisualStyleBackColor = true;
            this.buttonGuardarBasedeDatos.Visible = false;
            // 
            // timerAgregarProyecto
            // 
            this.timerAgregarProyecto.Interval = 1000;
            this.timerAgregarProyecto.Tick += new System.EventHandler(this.timerAgregarCliente_Tick);
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Enabled = false;
            this.textBoxNombreCliente.Location = new System.Drawing.Point(220, 144);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.Size = new System.Drawing.Size(268, 20);
            this.textBoxNombreCliente.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(99, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nombre Cliente";
            // 
            // textBoxCodigoProyecto
            // 
            this.textBoxCodigoProyecto.Enabled = false;
            this.textBoxCodigoProyecto.Location = new System.Drawing.Point(220, 61);
            this.textBoxCodigoProyecto.Name = "textBoxCodigoProyecto";
            this.textBoxCodigoProyecto.Size = new System.Drawing.Size(121, 20);
            this.textBoxCodigoProyecto.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(99, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Codigo Proyecto";
            // 
            // dataGridViewProyectoReportes
            // 
            this.dataGridViewProyectoReportes.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewProyectoReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProyectoReportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_proyecto,
            this.Codigo_proveedor,
            this.Descripcion_dibujo,
            this.Cantidad_dibujos,
            this.Fecha,
            this.Precio_Unitario,
            this.Total_Precio,
            this.Observaciones});
            this.dataGridViewProyectoReportes.Enabled = false;
            this.dataGridViewProyectoReportes.Location = new System.Drawing.Point(23, 239);
            this.dataGridViewProyectoReportes.Name = "dataGridViewProyectoReportes";
            this.dataGridViewProyectoReportes.Size = new System.Drawing.Size(1148, 270);
            this.dataGridViewProyectoReportes.TabIndex = 48;
            this.dataGridViewProyectoReportes.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewDibujosProyecto_RowsAdded);
            // 
            // comboBoxCodigoProyecto
            // 
            this.comboBoxCodigoProyecto.FormattingEnabled = true;
            this.comboBoxCodigoProyecto.Location = new System.Drawing.Point(220, 60);
            this.comboBoxCodigoProyecto.Name = "comboBoxCodigoProyecto";
            this.comboBoxCodigoProyecto.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCodigoProyecto.Sorted = true;
            this.comboBoxCodigoProyecto.TabIndex = 49;
            this.comboBoxCodigoProyecto.SelectedIndexChanged += new System.EventHandler(this.comboBoxCodigoProyecto_SelectedIndexChanged);
            // 
            // textBoxIngenieroCoset
            // 
            this.textBoxIngenieroCoset.Enabled = false;
            this.textBoxIngenieroCoset.Location = new System.Drawing.Point(220, 173);
            this.textBoxIngenieroCoset.Name = "textBoxIngenieroCoset";
            this.textBoxIngenieroCoset.Size = new System.Drawing.Size(268, 20);
            this.textBoxIngenieroCoset.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(99, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 54;
            this.label5.Text = "Ingeniero COSET";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(99, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 68;
            this.label9.Text = "Nombre Proyecto";
            // 
            // textBoxNombreProyecto
            // 
            this.textBoxNombreProyecto.Enabled = false;
            this.textBoxNombreProyecto.Location = new System.Drawing.Point(220, 87);
            this.textBoxNombreProyecto.Name = "textBoxNombreProyecto";
            this.textBoxNombreProyecto.Size = new System.Drawing.Size(268, 20);
            this.textBoxNombreProyecto.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(99, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 16);
            this.label11.TabIndex = 72;
            this.label11.Text = "Codigo Cliente";
            // 
            // textBoxCodigoCliente
            // 
            this.textBoxCodigoCliente.Enabled = false;
            this.textBoxCodigoCliente.Location = new System.Drawing.Point(220, 115);
            this.textBoxCodigoCliente.Name = "textBoxCodigoCliente";
            this.textBoxCodigoCliente.Size = new System.Drawing.Size(121, 20);
            this.textBoxCodigoCliente.TabIndex = 74;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.Location = new System.Drawing.Point(99, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 16);
            this.label13.TabIndex = 75;
            this.label13.Text = "Ingeniero Cliente";
            // 
            // textBoxIngenieroCliente
            // 
            this.textBoxIngenieroCliente.Enabled = false;
            this.textBoxIngenieroCliente.Location = new System.Drawing.Point(220, 200);
            this.textBoxIngenieroCliente.Name = "textBoxIngenieroCliente";
            this.textBoxIngenieroCliente.Size = new System.Drawing.Size(268, 20);
            this.textBoxIngenieroCliente.TabIndex = 76;
            // 
            // Codigo_proyecto
            // 
            this.Codigo_proyecto.HeaderText = "Codigo";
            this.Codigo_proyecto.Name = "Codigo_proyecto";
            // 
            // Codigo_proveedor
            // 
            this.Codigo_proveedor.HeaderText = "Codigo Proveedor";
            this.Codigo_proveedor.Name = "Codigo_proveedor";
            // 
            // Descripcion_dibujo
            // 
            this.Descripcion_dibujo.HeaderText = "Descripcion";
            this.Descripcion_dibujo.Name = "Descripcion_dibujo";
            this.Descripcion_dibujo.Width = 350;
            // 
            // Cantidad_dibujos
            // 
            this.Cantidad_dibujos.HeaderText = "Cantidad";
            this.Cantidad_dibujos.Name = "Cantidad_dibujos";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Precio_Unitario
            // 
            this.Precio_Unitario.HeaderText = "Precio Unitario";
            this.Precio_Unitario.Name = "Precio_Unitario";
            // 
            // Total_Precio
            // 
            this.Total_Precio.HeaderText = "Total Precio";
            this.Total_Precio.Name = "Total_Precio";
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Width = 150;
            // 
            // Forma_Reporte_Proyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 521);
            this.Controls.Add(this.textBoxIngenieroCliente);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxCodigoCliente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxNombreProyecto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxIngenieroCoset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxCodigoProyecto);
            this.Controls.Add(this.dataGridViewProyectoReportes);
            this.Controls.Add(this.textBoxNombreCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCodigoProyecto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonBorrarBasedeDatos);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonGuardarBasedeDatos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Forma_Reporte_Proyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyectos";
            this.Load += new System.EventHandler(this.Forma_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProyectoReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonBorrarBasedeDatos;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonGuardarBasedeDatos;
        private System.Windows.Forms.Timer timerAgregarProyecto;
        private System.Windows.Forms.TextBox textBoxNombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodigoProyecto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewProyectoReportes;
        private System.Windows.Forms.ComboBox comboBoxCodigoProyecto;
        private System.Windows.Forms.Timer timerModificarClientes;
        private System.Windows.Forms.TextBox textBoxIngenieroCoset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNombreProyecto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxCodigoCliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxIngenieroCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_proyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_dibujo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_dibujos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
    }
}