namespace Coset_Sistema_Produccion
{
    partial class Forma_Movimientos_Autos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma_Movimientos_Autos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonBuscarMovimientos = new System.Windows.Forms.Button();
            this.buttonEntradaAuto = new System.Windows.Forms.Button();
            this.buttonSalidaAuto = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonBorrarBasedeDatos = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonGuardarBasedeDatos = new System.Windows.Forms.Button();
            this.timerAgregarAuto = new System.Windows.Forms.Timer(this.components);
            this.textBoxAutoModelo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxAutoColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAutoDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigoAutoPlacas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCodigoAutoPlacas = new System.Windows.Forms.ComboBox();
            this.timerModificarClientes = new System.Windows.Forms.Timer(this.components);
            this.comboBoxAutoDescripcion = new System.Windows.Forms.ComboBox();
            this.textBoxAutoMarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TimePickerHora = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewEmpleadosAuto = new System.Windows.Forms.DataGridView();
            this.Empleado_nombre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Responsable = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleadosAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1039, 486);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonBuscarMovimientos
            // 
            this.buttonBuscarMovimientos.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarMovimientos.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarMovimientos.Image")));
            this.buttonBuscarMovimientos.Location = new System.Drawing.Point(374, 21);
            this.buttonBuscarMovimientos.Name = "buttonBuscarMovimientos";
            this.buttonBuscarMovimientos.Size = new System.Drawing.Size(79, 74);
            this.buttonBuscarMovimientos.TabIndex = 31;
            this.buttonBuscarMovimientos.Text = "Visualizar";
            this.buttonBuscarMovimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBuscarMovimientos.UseVisualStyleBackColor = true;
            this.buttonBuscarMovimientos.Click += new System.EventHandler(this.buttonBuscarempleado_Click);
            // 
            // buttonEntradaAuto
            // 
            this.buttonEntradaAuto.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntradaAuto.Image = ((System.Drawing.Image)(resources.GetObject("buttonEntradaAuto.Image")));
            this.buttonEntradaAuto.Location = new System.Drawing.Point(544, 21);
            this.buttonEntradaAuto.Name = "buttonEntradaAuto";
            this.buttonEntradaAuto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonEntradaAuto.Size = new System.Drawing.Size(79, 74);
            this.buttonEntradaAuto.TabIndex = 29;
            this.buttonEntradaAuto.Text = "Entrada";
            this.buttonEntradaAuto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEntradaAuto.UseVisualStyleBackColor = true;
            this.buttonEntradaAuto.Click += new System.EventHandler(this.buttonAgregarAuto_Click);
            // 
            // buttonSalidaAuto
            // 
            this.buttonSalidaAuto.AutoSize = true;
            this.buttonSalidaAuto.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalidaAuto.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalidaAuto.Image")));
            this.buttonSalidaAuto.Location = new System.Drawing.Point(459, 21);
            this.buttonSalidaAuto.Name = "buttonSalidaAuto";
            this.buttonSalidaAuto.Size = new System.Drawing.Size(81, 74);
            this.buttonSalidaAuto.TabIndex = 28;
            this.buttonSalidaAuto.Text = "Salida";
            this.buttonSalidaAuto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSalidaAuto.UseVisualStyleBackColor = true;
            this.buttonSalidaAuto.Click += new System.EventHandler(this.buttonModificarCliente_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AutoSize = true;
            this.buttonCancelar.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.Location = new System.Drawing.Point(948, 292);
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
            this.buttonBorrarBasedeDatos.Location = new System.Drawing.Point(948, 192);
            this.buttonBorrarBasedeDatos.Name = "buttonBorrarBasedeDatos";
            this.buttonBorrarBasedeDatos.Size = new System.Drawing.Size(79, 74);
            this.buttonBorrarBasedeDatos.TabIndex = 34;
            this.buttonBorrarBasedeDatos.Text = "Eliminar";
            this.buttonBorrarBasedeDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBorrarBasedeDatos.UseVisualStyleBackColor = true;
            this.buttonBorrarBasedeDatos.Visible = false;
            this.buttonBorrarBasedeDatos.Click += new System.EventHandler(this.buttonBorrarBasedeDatos_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.AutoSize = true;
            this.buttonHome.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(948, 372);
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
            this.buttonGuardarBasedeDatos.Location = new System.Drawing.Point(948, 212);
            this.buttonGuardarBasedeDatos.Name = "buttonGuardarBasedeDatos";
            this.buttonGuardarBasedeDatos.Size = new System.Drawing.Size(79, 74);
            this.buttonGuardarBasedeDatos.TabIndex = 32;
            this.buttonGuardarBasedeDatos.Text = "Guardar";
            this.buttonGuardarBasedeDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonGuardarBasedeDatos.UseVisualStyleBackColor = true;
            this.buttonGuardarBasedeDatos.Visible = false;
            this.buttonGuardarBasedeDatos.Click += new System.EventHandler(this.buttonGuardarBasedeDatos_Click);
            // 
            // timerAgregarAuto
            // 
            this.timerAgregarAuto.Interval = 1000;
            this.timerAgregarAuto.Tick += new System.EventHandler(this.timerAgregarAuto_Tick);
            // 
            // textBoxAutoModelo
            // 
            this.textBoxAutoModelo.Enabled = false;
            this.textBoxAutoModelo.Location = new System.Drawing.Point(207, 270);
            this.textBoxAutoModelo.Name = "textBoxAutoModelo";
            this.textBoxAutoModelo.Size = new System.Drawing.Size(147, 20);
            this.textBoxAutoModelo.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(85, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 16);
            this.label12.TabIndex = 45;
            this.label12.Text = "Auto Modelo";
            // 
            // textBoxAutoColor
            // 
            this.textBoxAutoColor.Enabled = false;
            this.textBoxAutoColor.Location = new System.Drawing.Point(207, 244);
            this.textBoxAutoColor.Name = "textBoxAutoColor";
            this.textBoxAutoColor.Size = new System.Drawing.Size(147, 20);
            this.textBoxAutoColor.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(85, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Auto Color";
            // 
            // textBoxAutoDescripcion
            // 
            this.textBoxAutoDescripcion.Enabled = false;
            this.textBoxAutoDescripcion.Location = new System.Drawing.Point(207, 190);
            this.textBoxAutoDescripcion.Name = "textBoxAutoDescripcion";
            this.textBoxAutoDescripcion.Size = new System.Drawing.Size(311, 20);
            this.textBoxAutoDescripcion.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(85, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Auto Descripcion";
            // 
            // textBoxCodigoAutoPlacas
            // 
            this.textBoxCodigoAutoPlacas.Enabled = false;
            this.textBoxCodigoAutoPlacas.Location = new System.Drawing.Point(207, 163);
            this.textBoxCodigoAutoPlacas.Name = "textBoxCodigoAutoPlacas";
            this.textBoxCodigoAutoPlacas.Size = new System.Drawing.Size(311, 20);
            this.textBoxCodigoAutoPlacas.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(85, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Cliente/Proveedor";
            // 
            // comboBoxCodigoAutoPlacas
            // 
            this.comboBoxCodigoAutoPlacas.FormattingEnabled = true;
            this.comboBoxCodigoAutoPlacas.Location = new System.Drawing.Point(207, 163);
            this.comboBoxCodigoAutoPlacas.Name = "comboBoxCodigoAutoPlacas";
            this.comboBoxCodigoAutoPlacas.Size = new System.Drawing.Size(311, 21);
            this.comboBoxCodigoAutoPlacas.TabIndex = 49;
            this.comboBoxCodigoAutoPlacas.Visible = false;
            this.comboBoxCodigoAutoPlacas.SelectedIndexChanged += new System.EventHandler(this.comboBoxCodigoCliente_SelectedIndexChanged);
            // 
            // timerModificarClientes
            // 
            this.timerModificarClientes.Interval = 1000;
            // 
            // comboBoxAutoDescripcion
            // 
            this.comboBoxAutoDescripcion.FormattingEnabled = true;
            this.comboBoxAutoDescripcion.Location = new System.Drawing.Point(207, 190);
            this.comboBoxAutoDescripcion.Name = "comboBoxAutoDescripcion";
            this.comboBoxAutoDescripcion.Size = new System.Drawing.Size(311, 21);
            this.comboBoxAutoDescripcion.TabIndex = 54;
            this.comboBoxAutoDescripcion.Visible = false;
            this.comboBoxAutoDescripcion.SelectedIndexChanged += new System.EventHandler(this.comboBoxNombreCliente_SelectedIndexChanged);
            // 
            // textBoxAutoMarca
            // 
            this.textBoxAutoMarca.Enabled = false;
            this.textBoxAutoMarca.Location = new System.Drawing.Point(207, 217);
            this.textBoxAutoMarca.Name = "textBoxAutoMarca";
            this.textBoxAutoMarca.Size = new System.Drawing.Size(147, 20);
            this.textBoxAutoMarca.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(85, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "Contacto Visita";
            // 
            // TimePickerHora
            // 
            this.TimePickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TimePickerHora.Location = new System.Drawing.Point(207, 312);
            this.TimePickerHora.Name = "TimePickerHora";
            this.TimePickerHora.Size = new System.Drawing.Size(147, 20);
            this.TimePickerHora.TabIndex = 58;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(207, 342);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(147, 20);
            this.dateTimePickerFecha.TabIndex = 59;
            // 
            // dataGridViewEmpleadosAuto
            // 
            this.dataGridViewEmpleadosAuto.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewEmpleadosAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleadosAuto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Empleado_nombre,
            this.Responsable});
            this.dataGridViewEmpleadosAuto.Location = new System.Drawing.Point(544, 163);
            this.dataGridViewEmpleadosAuto.Name = "dataGridViewEmpleadosAuto";
            this.dataGridViewEmpleadosAuto.Size = new System.Drawing.Size(343, 184);
            this.dataGridViewEmpleadosAuto.TabIndex = 60;
            this.dataGridViewEmpleadosAuto.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpleadosAuto_CellEnter);
            this.dataGridViewEmpleadosAuto.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewEmpleadosAuto_RowsAdded);
            // 
            // Empleado_nombre
            // 
            this.Empleado_nombre.HeaderText = "Empleado";
            this.Empleado_nombre.Name = "Empleado_nombre";
            this.Empleado_nombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Empleado_nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Empleado_nombre.Width = 200;
            // 
            // Responsable
            // 
            this.Responsable.HeaderText = "Responsable LLaves";
            this.Responsable.Items.AddRange(new object[] {
            "Responsable",
            "Acompañante"});
            this.Responsable.Name = "Responsable";
            this.Responsable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Responsable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Forma_Movimientos_Autos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 486);
            this.Controls.Add(this.dataGridViewEmpleadosAuto);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.TimePickerHora);
            this.Controls.Add(this.textBoxAutoMarca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxAutoDescripcion);
            this.Controls.Add(this.comboBoxCodigoAutoPlacas);
            this.Controls.Add(this.textBoxAutoModelo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxAutoColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAutoDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCodigoAutoPlacas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonBorrarBasedeDatos);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonGuardarBasedeDatos);
            this.Controls.Add(this.buttonBuscarMovimientos);
            this.Controls.Add(this.buttonEntradaAuto);
            this.Controls.Add(this.buttonSalidaAuto);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Forma_Movimientos_Autos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimientos Autos";
            this.Load += new System.EventHandler(this.Forma_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleadosAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBuscarMovimientos;
        private System.Windows.Forms.Button buttonEntradaAuto;
        private System.Windows.Forms.Button buttonSalidaAuto;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonBorrarBasedeDatos;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonGuardarBasedeDatos;
        private System.Windows.Forms.Timer timerAgregarAuto;
        private System.Windows.Forms.TextBox textBoxAutoModelo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxAutoColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAutoDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodigoAutoPlacas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCodigoAutoPlacas;
        private System.Windows.Forms.Timer timerModificarClientes;
        private System.Windows.Forms.ComboBox comboBoxAutoDescripcion;
        private System.Windows.Forms.TextBox textBoxAutoMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker TimePickerHora;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.DataGridView dataGridViewEmpleadosAuto;
        private System.Windows.Forms.DataGridViewComboBoxColumn Empleado_nombre;
        private System.Windows.Forms.DataGridViewComboBoxColumn Responsable;
    }
}