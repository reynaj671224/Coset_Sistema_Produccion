﻿namespace Coset_Sistema_Produccion
{
    partial class Forma_Devolucion_Materiales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma_Devolucion_Materiales));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonBuscarDevolucion = new System.Windows.Forms.Button();
            this.buttonDevolucionMaterial = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonBorrarBasedeDatos = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonGuardarBasedeDatos = new System.Windows.Forms.Button();
            this.timerAgregarDevolucionMateriales = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxDescripcionMotivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigoProyecto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewDevolucionEntradaMateriales = new System.Windows.Forms.DataGridView();
            this.Codigo_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parte_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo_Devolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxCodigoProyecto = new System.Windows.Forms.ComboBox();
            this.timerBusquedaMaterial = new System.Windows.Forms.Timer(this.components);
            this.dateTimePickerFechaActual = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxEmpleado = new System.Windows.Forms.ComboBox();
            this.textBoxCodigoProveedor = new System.Windows.Forms.TextBox();
            this.textCodigoMaterial = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPrecioMaterial = new System.Windows.Forms.TextBox();
            this.textBoxUnidadesEntrada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBusquedaBaseDatos = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxTotalUnidades = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDescripcionMaterial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevolucionEntradaMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1183, 582);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonBuscarDevolucion
            // 
            this.buttonBuscarDevolucion.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarDevolucion.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarDevolucion.Image")));
            this.buttonBuscarDevolucion.Location = new System.Drawing.Point(416, 24);
            this.buttonBuscarDevolucion.Name = "buttonBuscarDevolucion";
            this.buttonBuscarDevolucion.Size = new System.Drawing.Size(79, 74);
            this.buttonBuscarDevolucion.TabIndex = 31;
            this.buttonBuscarDevolucion.Text = "Visualizar";
            this.buttonBuscarDevolucion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBuscarDevolucion.UseVisualStyleBackColor = true;
            this.buttonBuscarDevolucion.Click += new System.EventHandler(this.buttonBuscarOrdenCompra_Click);
            // 
            // buttonDevolucionMaterial
            // 
            this.buttonDevolucionMaterial.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDevolucionMaterial.Image = ((System.Drawing.Image)(resources.GetObject("buttonDevolucionMaterial.Image")));
            this.buttonDevolucionMaterial.Location = new System.Drawing.Point(501, 24);
            this.buttonDevolucionMaterial.Name = "buttonDevolucionMaterial";
            this.buttonDevolucionMaterial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDevolucionMaterial.Size = new System.Drawing.Size(79, 74);
            this.buttonDevolucionMaterial.TabIndex = 29;
            this.buttonDevolucionMaterial.Text = "Devolución";
            this.buttonDevolucionMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDevolucionMaterial.UseVisualStyleBackColor = true;
            this.buttonDevolucionMaterial.Click += new System.EventHandler(this.buttonSalidaMaterial_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AutoSize = true;
            this.buttonCancelar.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.Location = new System.Drawing.Point(1087, 395);
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
            this.buttonBorrarBasedeDatos.Location = new System.Drawing.Point(1087, 301);
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
            this.buttonHome.Location = new System.Drawing.Point(1087, 475);
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
            this.buttonGuardarBasedeDatos.Location = new System.Drawing.Point(1087, 315);
            this.buttonGuardarBasedeDatos.Name = "buttonGuardarBasedeDatos";
            this.buttonGuardarBasedeDatos.Size = new System.Drawing.Size(79, 74);
            this.buttonGuardarBasedeDatos.TabIndex = 32;
            this.buttonGuardarBasedeDatos.Text = "Guardar";
            this.buttonGuardarBasedeDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonGuardarBasedeDatos.UseVisualStyleBackColor = true;
            this.buttonGuardarBasedeDatos.Visible = false;
            this.buttonGuardarBasedeDatos.Click += new System.EventHandler(this.buttonGuardarBasedeDatos_Click);
            // 
            // timerAgregarDevolucionMateriales
            // 
            this.timerAgregarDevolucionMateriales.Interval = 1000;
            this.timerAgregarDevolucionMateriales.Tick += new System.EventHandler(this.timerAgregarDevolucionMateriales_Tick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(106, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 16);
            this.label12.TabIndex = 45;
            this.label12.Text = "Codigo Proveedor Material";
            // 
            // textBoxDescripcionMotivo
            // 
            this.textBoxDescripcionMotivo.Enabled = false;
            this.textBoxDescripcionMotivo.Location = new System.Drawing.Point(263, 188);
            this.textBoxDescripcionMotivo.Multiline = true;
            this.textBoxDescripcionMotivo.Name = "textBoxDescripcionMotivo";
            this.textBoxDescripcionMotivo.Size = new System.Drawing.Size(246, 37);
            this.textBoxDescripcionMotivo.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(106, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Motivo Devolución";
            // 
            // textBoxEmpleado
            // 
            this.textBoxEmpleado.Enabled = false;
            this.textBoxEmpleado.Location = new System.Drawing.Point(262, 261);
            this.textBoxEmpleado.Name = "textBoxEmpleado";
            this.textBoxEmpleado.Size = new System.Drawing.Size(246, 20);
            this.textBoxEmpleado.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(106, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Empleado";
            // 
            // textBoxCodigoProyecto
            // 
            this.textBoxCodigoProyecto.Enabled = false;
            this.textBoxCodigoProyecto.Location = new System.Drawing.Point(262, 136);
            this.textBoxCodigoProyecto.Name = "textBoxCodigoProyecto";
            this.textBoxCodigoProyecto.Size = new System.Drawing.Size(121, 20);
            this.textBoxCodigoProyecto.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(106, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "CodigoProyecto";
            // 
            // dataGridViewDevolucionEntradaMateriales
            // 
            this.dataGridViewDevolucionEntradaMateriales.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewDevolucionEntradaMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDevolucionEntradaMateriales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_partida,
            this.Proyecto,
            this.Fecha,
            this.Codigo_material,
            this.Parte_proveedor,
            this.Nombre_empleado,
            this.Motivo_Devolucion,
            this.Cantidad});
            this.dataGridViewDevolucionEntradaMateriales.Enabled = false;
            this.dataGridViewDevolucionEntradaMateriales.Location = new System.Drawing.Point(23, 347);
            this.dataGridViewDevolucionEntradaMateriales.Name = "dataGridViewDevolucionEntradaMateriales";
            this.dataGridViewDevolucionEntradaMateriales.Size = new System.Drawing.Size(993, 202);
            this.dataGridViewDevolucionEntradaMateriales.TabIndex = 48;
            // 
            // Codigo_partida
            // 
            this.Codigo_partida.HeaderText = "Codigo";
            this.Codigo_partida.Name = "Codigo_partida";
            this.Codigo_partida.Width = 50;
            // 
            // Proyecto
            // 
            this.Proyecto.HeaderText = "Proyecto";
            this.Proyecto.Name = "Proyecto";
            this.Proyecto.Width = 50;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Codigo_material
            // 
            this.Codigo_material.HeaderText = "Codigo Material";
            this.Codigo_material.Name = "Codigo_material";
            this.Codigo_material.Width = 50;
            // 
            // Parte_proveedor
            // 
            this.Parte_proveedor.HeaderText = "Codigo Parte Proveedor";
            this.Parte_proveedor.Name = "Parte_proveedor";
            this.Parte_proveedor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Nombre_empleado
            // 
            this.Nombre_empleado.HeaderText = "Nombre Empleado";
            this.Nombre_empleado.Name = "Nombre_empleado";
            this.Nombre_empleado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nombre_empleado.Width = 200;
            // 
            // Motivo_Devolucion
            // 
            this.Motivo_Devolucion.HeaderText = "Motivo Devolución";
            this.Motivo_Devolucion.Name = "Motivo_Devolucion";
            this.Motivo_Devolucion.Width = 400;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 50;
            // 
            // comboBoxCodigoProyecto
            // 
            this.comboBoxCodigoProyecto.FormattingEnabled = true;
            this.comboBoxCodigoProyecto.Location = new System.Drawing.Point(263, 135);
            this.comboBoxCodigoProyecto.Name = "comboBoxCodigoProyecto";
            this.comboBoxCodigoProyecto.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCodigoProyecto.Sorted = true;
            this.comboBoxCodigoProyecto.TabIndex = 49;
            this.comboBoxCodigoProyecto.Visible = false;
            this.comboBoxCodigoProyecto.SelectedIndexChanged += new System.EventHandler(this.buttonDevolucionMaterial_SelectedIndexChanged);
            // 
            // timerBusquedaMaterial
            // 
            this.timerBusquedaMaterial.Interval = 1000;
            this.timerBusquedaMaterial.Tick += new System.EventHandler(this.timerBusquedaMaterial_Tick);
            // 
            // dateTimePickerFechaActual
            // 
            this.dateTimePickerFechaActual.Enabled = false;
            this.dateTimePickerFechaActual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaActual.Location = new System.Drawing.Point(660, 218);
            this.dateTimePickerFechaActual.Name = "dateTimePickerFechaActual";
            this.dateTimePickerFechaActual.Size = new System.Drawing.Size(124, 20);
            this.dateTimePickerFechaActual.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(539, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "Fecha Actual";
            // 
            // comboBoxEmpleado
            // 
            this.comboBoxEmpleado.FormattingEnabled = true;
            this.comboBoxEmpleado.Location = new System.Drawing.Point(262, 260);
            this.comboBoxEmpleado.Name = "comboBoxEmpleado";
            this.comboBoxEmpleado.Size = new System.Drawing.Size(246, 21);
            this.comboBoxEmpleado.Sorted = true;
            this.comboBoxEmpleado.TabIndex = 62;
            this.comboBoxEmpleado.Visible = false;
            // 
            // textBoxCodigoProveedor
            // 
            this.textBoxCodigoProveedor.Enabled = false;
            this.textBoxCodigoProveedor.Location = new System.Drawing.Point(262, 231);
            this.textBoxCodigoProveedor.Name = "textBoxCodigoProveedor";
            this.textBoxCodigoProveedor.Size = new System.Drawing.Size(121, 20);
            this.textBoxCodigoProveedor.TabIndex = 66;
            this.textBoxCodigoProveedor.TextChanged += new System.EventHandler(this.textBoxCodigoProveedor_TextChanged);
            // 
            // textCodigoMaterial
            // 
            this.textCodigoMaterial.Enabled = false;
            this.textCodigoMaterial.Location = new System.Drawing.Point(660, 140);
            this.textCodigoMaterial.Name = "textCodigoMaterial";
            this.textCodigoMaterial.Size = new System.Drawing.Size(124, 20);
            this.textCodigoMaterial.TabIndex = 79;
            this.textCodigoMaterial.TextChanged += new System.EventHandler(this.textCodigoMaterial_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(539, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 78;
            this.label9.Text = "Codigo Material";
            // 
            // textBoxPrecioMaterial
            // 
            this.textBoxPrecioMaterial.Enabled = false;
            this.textBoxPrecioMaterial.Location = new System.Drawing.Point(660, 166);
            this.textBoxPrecioMaterial.Name = "textBoxPrecioMaterial";
            this.textBoxPrecioMaterial.Size = new System.Drawing.Size(124, 20);
            this.textBoxPrecioMaterial.TabIndex = 81;
            // 
            // textBoxUnidadesEntrada
            // 
            this.textBoxUnidadesEntrada.Enabled = false;
            this.textBoxUnidadesEntrada.Location = new System.Drawing.Point(660, 244);
            this.textBoxUnidadesEntrada.Name = "textBoxUnidadesEntrada";
            this.textBoxUnidadesEntrada.Size = new System.Drawing.Size(124, 20);
            this.textBoxUnidadesEntrada.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(539, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 82;
            this.label3.Text = "Unidades Entrada";
            // 
            // buttonBusquedaBaseDatos
            // 
            this.buttonBusquedaBaseDatos.BackColor = System.Drawing.Color.White;
            this.buttonBusquedaBaseDatos.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBusquedaBaseDatos.Image = ((System.Drawing.Image)(resources.GetObject("buttonBusquedaBaseDatos.Image")));
            this.buttonBusquedaBaseDatos.Location = new System.Drawing.Point(586, 24);
            this.buttonBusquedaBaseDatos.Name = "buttonBusquedaBaseDatos";
            this.buttonBusquedaBaseDatos.Size = new System.Drawing.Size(79, 74);
            this.buttonBusquedaBaseDatos.TabIndex = 84;
            this.buttonBusquedaBaseDatos.Text = "Buscar";
            this.buttonBusquedaBaseDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBusquedaBaseDatos.UseVisualStyleBackColor = false;
            this.buttonBusquedaBaseDatos.Visible = false;
            this.buttonBusquedaBaseDatos.Click += new System.EventHandler(this.buttonBusquedaBaseDatos_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(539, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 16);
            this.label10.TabIndex = 80;
            this.label10.Text = "Precio Material";
            // 
            // textBoxTotalUnidades
            // 
            this.textBoxTotalUnidades.Enabled = false;
            this.textBoxTotalUnidades.Location = new System.Drawing.Point(660, 192);
            this.textBoxTotalUnidades.Name = "textBoxTotalUnidades";
            this.textBoxTotalUnidades.Size = new System.Drawing.Size(124, 20);
            this.textBoxTotalUnidades.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(539, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 85;
            this.label5.Text = "Total Unidades";
            // 
            // textBoxDescripcionMaterial
            // 
            this.textBoxDescripcionMaterial.Enabled = false;
            this.textBoxDescripcionMaterial.Location = new System.Drawing.Point(263, 162);
            this.textBoxDescripcionMaterial.Name = "textBoxDescripcionMaterial";
            this.textBoxDescripcionMaterial.Size = new System.Drawing.Size(246, 20);
            this.textBoxDescripcionMaterial.TabIndex = 88;
            this.textBoxDescripcionMaterial.TextChanged += new System.EventHandler(this.textBoxDescripcionMaterial_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(106, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 87;
            this.label7.Text = "Descripcion Material";
            // 
            // Forma_Devolucion_Materiales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 582);
            this.Controls.Add(this.textBoxDescripcionMaterial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTotalUnidades);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonBusquedaBaseDatos);
            this.Controls.Add(this.textBoxUnidadesEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrecioMaterial);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textCodigoMaterial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxCodigoProveedor);
            this.Controls.Add(this.comboBoxEmpleado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePickerFechaActual);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxCodigoProyecto);
            this.Controls.Add(this.dataGridViewDevolucionEntradaMateriales);
            this.Controls.Add(this.textBoxDescripcionMotivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCodigoProyecto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonBorrarBasedeDatos);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonGuardarBasedeDatos);
            this.Controls.Add(this.buttonBuscarDevolucion);
            this.Controls.Add(this.buttonDevolucionMaterial);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Forma_Devolucion_Materiales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolución Materiales";
            this.Load += new System.EventHandler(this.Forma_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevolucionEntradaMateriales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBuscarDevolucion;
        private System.Windows.Forms.Button buttonDevolucionMaterial;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonBorrarBasedeDatos;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonGuardarBasedeDatos;
        private System.Windows.Forms.Timer timerAgregarDevolucionMateriales;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxDescripcionMotivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodigoProyecto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewDevolucionEntradaMateriales;
        private System.Windows.Forms.ComboBox comboBoxCodigoProyecto;
        private System.Windows.Forms.Timer timerBusquedaMaterial;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaActual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxEmpleado;
        private System.Windows.Forms.TextBox textBoxCodigoProveedor;
        private System.Windows.Forms.TextBox textCodigoMaterial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPrecioMaterial;
        private System.Windows.Forms.TextBox textBoxUnidadesEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBusquedaBaseDatos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxTotalUnidades;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDescripcionMaterial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parte_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo_Devolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}