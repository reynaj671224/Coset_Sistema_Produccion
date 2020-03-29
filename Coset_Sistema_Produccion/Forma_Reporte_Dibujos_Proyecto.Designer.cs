﻿namespace Coset_Sistema_Produccion
{
    partial class Forma_Reporte_Dibujos_Proyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma_Reporte_Dibujos_Proyecto));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonBorrarBasedeDatos = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonGuardarBasedeDatos = new System.Windows.Forms.Button();
            this.timerAgregarProyecto = new System.Windows.Forms.Timer(this.components);
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.textBoxCodigoProyecto = new System.Windows.Forms.TextBox();
            this.labelCodigoProyecto = new System.Windows.Forms.Label();
            this.dataGridViewReporteDibujosProyecto = new System.Windows.Forms.DataGridView();
            this.Numero_dibujo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proceso_dibujo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_dibujo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas_produccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas_retrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxCodigoProyecto = new System.Windows.Forms.ComboBox();
            this.timerModificarClientes = new System.Windows.Forms.Timer(this.components);
            this.textBoxIngenieroCoset = new System.Windows.Forms.TextBox();
            this.labelIngenieroCoset = new System.Windows.Forms.Label();
            this.labelNombreProyecto = new System.Windows.Forms.Label();
            this.textBoxNombreProyecto = new System.Windows.Forms.TextBox();
            this.labelCodigoCliente = new System.Windows.Forms.Label();
            this.textBoxCodigoCliente = new System.Windows.Forms.TextBox();
            this.labelIngenieroCliente = new System.Windows.Forms.Label();
            this.textBoxIngenieroCliente = new System.Windows.Forms.TextBox();
            this.textBoxTotalDibujos = new System.Windows.Forms.TextBox();
            this.labelTotalDibujos = new System.Windows.Forms.Label();
            this.textBoxTotalDibujoCompletos = new System.Windows.Forms.TextBox();
            this.labelTotalDibujosCompletos = new System.Windows.Forms.Label();
            this.textBoxPorcentajeProyecto = new System.Windows.Forms.TextBox();
            this.labelTotalPorcentajeDibujos = new System.Windows.Forms.Label();
            this.buttonReporteProyectos = new System.Windows.Forms.Button();
            this.buttonReporteUsuarios = new System.Windows.Forms.Button();
            this.buttonReoprteMateriales = new System.Windows.Forms.Button();
            this.buttonBusquedaBaseDatos = new System.Windows.Forms.Button();
            this.comboBoxNombreEmpleado = new System.Windows.Forms.ComboBox();
            this.labelNombreEmpleado = new System.Windows.Forms.Label();
            this.textCodigoMaterial = new System.Windows.Forms.TextBox();
            this.labelCodigoMaterial = new System.Windows.Forms.Label();
            this.textBoxCodigoProveedor = new System.Windows.Forms.TextBox();
            this.labelCodigoMaterialProveedor = new System.Windows.Forms.Label();
            this.textBoxDescripcionMaterial = new System.Windows.Forms.TextBox();
            this.labelMaterialDescripcion = new System.Windows.Forms.Label();
            this.timerBusquedaFecha = new System.Windows.Forms.Timer(this.components);
            this.buttonExcel = new System.Windows.Forms.Button();
            this.comboBoxNombreProyecto = new System.Windows.Forms.ComboBox();
            this.buttonFecha = new System.Windows.Forms.Button();
            this.dateTimePickerFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelFechaFinal = new System.Windows.Forms.Label();
            this.comboBoxFechaFiltro = new System.Windows.Forms.ComboBox();
            this.labelFechaFiltro = new System.Windows.Forms.Label();
            this.buttonFiltros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporteDibujosProyecto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1265, 599);
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
            this.buttonBorrarBasedeDatos.Location = new System.Drawing.Point(1177, 275);
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
            this.textBoxNombreCliente.Location = new System.Drawing.Point(220, 208);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.Size = new System.Drawing.Size(268, 20);
            this.textBoxNombreCliente.TabIndex = 40;
            this.textBoxNombreCliente.Visible = false;
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.AutoSize = true;
            this.labelNombreCliente.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCliente.Image = ((System.Drawing.Image)(resources.GetObject("labelNombreCliente.Image")));
            this.labelNombreCliente.Location = new System.Drawing.Point(99, 208);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.Size = new System.Drawing.Size(92, 16);
            this.labelNombreCliente.TabIndex = 39;
            this.labelNombreCliente.Text = "Nombre Cliente";
            this.labelNombreCliente.Visible = false;
            // 
            // textBoxCodigoProyecto
            // 
            this.textBoxCodigoProyecto.Enabled = false;
            this.textBoxCodigoProyecto.Location = new System.Drawing.Point(220, 98);
            this.textBoxCodigoProyecto.Name = "textBoxCodigoProyecto";
            this.textBoxCodigoProyecto.Size = new System.Drawing.Size(121, 20);
            this.textBoxCodigoProyecto.TabIndex = 38;
            this.textBoxCodigoProyecto.Visible = false;
            this.textBoxCodigoProyecto.WordWrap = false;
            // 
            // labelCodigoProyecto
            // 
            this.labelCodigoProyecto.AutoSize = true;
            this.labelCodigoProyecto.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoProyecto.Image = ((System.Drawing.Image)(resources.GetObject("labelCodigoProyecto.Image")));
            this.labelCodigoProyecto.Location = new System.Drawing.Point(99, 100);
            this.labelCodigoProyecto.Name = "labelCodigoProyecto";
            this.labelCodigoProyecto.Size = new System.Drawing.Size(93, 16);
            this.labelCodigoProyecto.TabIndex = 37;
            this.labelCodigoProyecto.Text = "Codigo Proyecto";
            this.labelCodigoProyecto.Visible = false;
            // 
            // dataGridViewReporteDibujosProyecto
            // 
            this.dataGridViewReporteDibujosProyecto.AllowUserToDeleteRows = false;
            this.dataGridViewReporteDibujosProyecto.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewReporteDibujosProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReporteDibujosProyecto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_dibujo,
            this.Cantidad_Unidades,
            this.Proceso_dibujo,
            this.Estado_dibujo,
            this.Empleado,
            this.Horas_produccion,
            this.Horas_retrabajo});
            this.dataGridViewReporteDibujosProyecto.Location = new System.Drawing.Point(135, 353);
            this.dataGridViewReporteDibujosProyecto.Name = "dataGridViewReporteDibujosProyecto";
            this.dataGridViewReporteDibujosProyecto.ReadOnly = true;
            this.dataGridViewReporteDibujosProyecto.Size = new System.Drawing.Size(795, 234);
            this.dataGridViewReporteDibujosProyecto.TabIndex = 48;
            this.dataGridViewReporteDibujosProyecto.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewDibujosProyecto_RowsAdded);
            // 
            // Numero_dibujo
            // 
            this.Numero_dibujo.HeaderText = "Nunero Dibujo";
            this.Numero_dibujo.Name = "Numero_dibujo";
            this.Numero_dibujo.ReadOnly = true;
            // 
            // Cantidad_Unidades
            // 
            this.Cantidad_Unidades.HeaderText = "Cantidad Unidades";
            this.Cantidad_Unidades.Name = "Cantidad_Unidades";
            this.Cantidad_Unidades.ReadOnly = true;
            // 
            // Proceso_dibujo
            // 
            this.Proceso_dibujo.HeaderText = "Proceso Dibujo";
            this.Proceso_dibujo.Name = "Proceso_dibujo";
            this.Proceso_dibujo.ReadOnly = true;
            // 
            // Estado_dibujo
            // 
            this.Estado_dibujo.HeaderText = "Estado Dibujo";
            this.Estado_dibujo.Name = "Estado_dibujo";
            this.Estado_dibujo.ReadOnly = true;
            this.Estado_dibujo.Width = 150;
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empledado";
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            // 
            // Horas_produccion
            // 
            this.Horas_produccion.HeaderText = "Horas Produccion";
            this.Horas_produccion.Name = "Horas_produccion";
            this.Horas_produccion.ReadOnly = true;
            // 
            // Horas_retrabajo
            // 
            this.Horas_retrabajo.HeaderText = "Horas Retrabajo";
            this.Horas_retrabajo.Name = "Horas_retrabajo";
            this.Horas_retrabajo.ReadOnly = true;
            // 
            // comboBoxCodigoProyecto
            // 
            this.comboBoxCodigoProyecto.FormattingEnabled = true;
            this.comboBoxCodigoProyecto.Location = new System.Drawing.Point(220, 98);
            this.comboBoxCodigoProyecto.Name = "comboBoxCodigoProyecto";
            this.comboBoxCodigoProyecto.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCodigoProyecto.Sorted = true;
            this.comboBoxCodigoProyecto.TabIndex = 49;
            this.comboBoxCodigoProyecto.Visible = false;
            this.comboBoxCodigoProyecto.SelectedIndexChanged += new System.EventHandler(this.comboBoxCodigoProyecto_SelectedIndexChanged);
            // 
            // textBoxIngenieroCoset
            // 
            this.textBoxIngenieroCoset.Enabled = false;
            this.textBoxIngenieroCoset.Location = new System.Drawing.Point(220, 237);
            this.textBoxIngenieroCoset.Name = "textBoxIngenieroCoset";
            this.textBoxIngenieroCoset.Size = new System.Drawing.Size(268, 20);
            this.textBoxIngenieroCoset.TabIndex = 55;
            this.textBoxIngenieroCoset.Visible = false;
            // 
            // labelIngenieroCoset
            // 
            this.labelIngenieroCoset.AutoSize = true;
            this.labelIngenieroCoset.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngenieroCoset.Image = ((System.Drawing.Image)(resources.GetObject("labelIngenieroCoset.Image")));
            this.labelIngenieroCoset.Location = new System.Drawing.Point(99, 237);
            this.labelIngenieroCoset.Name = "labelIngenieroCoset";
            this.labelIngenieroCoset.Size = new System.Drawing.Size(100, 16);
            this.labelIngenieroCoset.TabIndex = 54;
            this.labelIngenieroCoset.Text = "Ingeniero COSET";
            this.labelIngenieroCoset.Visible = false;
            // 
            // labelNombreProyecto
            // 
            this.labelNombreProyecto.AutoSize = true;
            this.labelNombreProyecto.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreProyecto.Image = ((System.Drawing.Image)(resources.GetObject("labelNombreProyecto.Image")));
            this.labelNombreProyecto.Location = new System.Drawing.Point(99, 155);
            this.labelNombreProyecto.Name = "labelNombreProyecto";
            this.labelNombreProyecto.Size = new System.Drawing.Size(98, 16);
            this.labelNombreProyecto.TabIndex = 68;
            this.labelNombreProyecto.Text = "Nombre Proyecto";
            this.labelNombreProyecto.Visible = false;
            // 
            // textBoxNombreProyecto
            // 
            this.textBoxNombreProyecto.Enabled = false;
            this.textBoxNombreProyecto.Location = new System.Drawing.Point(220, 151);
            this.textBoxNombreProyecto.Name = "textBoxNombreProyecto";
            this.textBoxNombreProyecto.Size = new System.Drawing.Size(268, 20);
            this.textBoxNombreProyecto.TabIndex = 69;
            this.textBoxNombreProyecto.Visible = false;
            // 
            // labelCodigoCliente
            // 
            this.labelCodigoCliente.AutoSize = true;
            this.labelCodigoCliente.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoCliente.Image = ((System.Drawing.Image)(resources.GetObject("labelCodigoCliente.Image")));
            this.labelCodigoCliente.Location = new System.Drawing.Point(99, 179);
            this.labelCodigoCliente.Name = "labelCodigoCliente";
            this.labelCodigoCliente.Size = new System.Drawing.Size(87, 16);
            this.labelCodigoCliente.TabIndex = 72;
            this.labelCodigoCliente.Text = "Codigo Cliente";
            this.labelCodigoCliente.Visible = false;
            // 
            // textBoxCodigoCliente
            // 
            this.textBoxCodigoCliente.Enabled = false;
            this.textBoxCodigoCliente.Location = new System.Drawing.Point(220, 179);
            this.textBoxCodigoCliente.Name = "textBoxCodigoCliente";
            this.textBoxCodigoCliente.Size = new System.Drawing.Size(121, 20);
            this.textBoxCodigoCliente.TabIndex = 74;
            this.textBoxCodigoCliente.Visible = false;
            // 
            // labelIngenieroCliente
            // 
            this.labelIngenieroCliente.AutoSize = true;
            this.labelIngenieroCliente.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngenieroCliente.Image = ((System.Drawing.Image)(resources.GetObject("labelIngenieroCliente.Image")));
            this.labelIngenieroCliente.Location = new System.Drawing.Point(99, 264);
            this.labelIngenieroCliente.Name = "labelIngenieroCliente";
            this.labelIngenieroCliente.Size = new System.Drawing.Size(101, 16);
            this.labelIngenieroCliente.TabIndex = 75;
            this.labelIngenieroCliente.Text = "Ingeniero Cliente";
            this.labelIngenieroCliente.Visible = false;
            // 
            // textBoxIngenieroCliente
            // 
            this.textBoxIngenieroCliente.Enabled = false;
            this.textBoxIngenieroCliente.Location = new System.Drawing.Point(220, 264);
            this.textBoxIngenieroCliente.Name = "textBoxIngenieroCliente";
            this.textBoxIngenieroCliente.Size = new System.Drawing.Size(268, 20);
            this.textBoxIngenieroCliente.TabIndex = 76;
            this.textBoxIngenieroCliente.Visible = false;
            // 
            // textBoxTotalDibujos
            // 
            this.textBoxTotalDibujos.Enabled = false;
            this.textBoxTotalDibujos.Location = new System.Drawing.Point(1132, 129);
            this.textBoxTotalDibujos.Name = "textBoxTotalDibujos";
            this.textBoxTotalDibujos.Size = new System.Drawing.Size(124, 20);
            this.textBoxTotalDibujos.TabIndex = 78;
            this.textBoxTotalDibujos.Visible = false;
            // 
            // labelTotalDibujos
            // 
            this.labelTotalDibujos.AutoSize = true;
            this.labelTotalDibujos.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDibujos.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalDibujos.Image")));
            this.labelTotalDibujos.Location = new System.Drawing.Point(934, 129);
            this.labelTotalDibujos.Name = "labelTotalDibujos";
            this.labelTotalDibujos.Size = new System.Drawing.Size(127, 16);
            this.labelTotalDibujos.TabIndex = 77;
            this.labelTotalDibujos.Text = "Total Dibujos Proyecto";
            this.labelTotalDibujos.Visible = false;
            // 
            // textBoxTotalDibujoCompletos
            // 
            this.textBoxTotalDibujoCompletos.Enabled = false;
            this.textBoxTotalDibujoCompletos.Location = new System.Drawing.Point(1132, 155);
            this.textBoxTotalDibujoCompletos.Name = "textBoxTotalDibujoCompletos";
            this.textBoxTotalDibujoCompletos.Size = new System.Drawing.Size(124, 20);
            this.textBoxTotalDibujoCompletos.TabIndex = 80;
            this.textBoxTotalDibujoCompletos.Visible = false;
            // 
            // labelTotalDibujosCompletos
            // 
            this.labelTotalDibujosCompletos.AutoSize = true;
            this.labelTotalDibujosCompletos.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDibujosCompletos.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalDibujosCompletos.Image")));
            this.labelTotalDibujosCompletos.Location = new System.Drawing.Point(934, 155);
            this.labelTotalDibujosCompletos.Name = "labelTotalDibujosCompletos";
            this.labelTotalDibujosCompletos.Size = new System.Drawing.Size(138, 16);
            this.labelTotalDibujosCompletos.TabIndex = 79;
            this.labelTotalDibujosCompletos.Text = "Total Dibujos Completos";
            this.labelTotalDibujosCompletos.Visible = false;
            // 
            // textBoxPorcentajeProyecto
            // 
            this.textBoxPorcentajeProyecto.Enabled = false;
            this.textBoxPorcentajeProyecto.Location = new System.Drawing.Point(1132, 181);
            this.textBoxPorcentajeProyecto.Name = "textBoxPorcentajeProyecto";
            this.textBoxPorcentajeProyecto.Size = new System.Drawing.Size(124, 20);
            this.textBoxPorcentajeProyecto.TabIndex = 82;
            this.textBoxPorcentajeProyecto.Visible = false;
            // 
            // labelTotalPorcentajeDibujos
            // 
            this.labelTotalPorcentajeDibujos.AutoSize = true;
            this.labelTotalPorcentajeDibujos.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPorcentajeDibujos.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalPorcentajeDibujos.Image")));
            this.labelTotalPorcentajeDibujos.Location = new System.Drawing.Point(934, 179);
            this.labelTotalPorcentajeDibujos.Name = "labelTotalPorcentajeDibujos";
            this.labelTotalPorcentajeDibujos.Size = new System.Drawing.Size(133, 16);
            this.labelTotalPorcentajeDibujos.TabIndex = 81;
            this.labelTotalPorcentajeDibujos.Text = "Porcentaje Proyecto (%)";
            this.labelTotalPorcentajeDibujos.Visible = false;
            // 
            // buttonReporteProyectos
            // 
            this.buttonReporteProyectos.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReporteProyectos.Image = ((System.Drawing.Image)(resources.GetObject("buttonReporteProyectos.Image")));
            this.buttonReporteProyectos.Location = new System.Drawing.Point(362, 11);
            this.buttonReporteProyectos.Name = "buttonReporteProyectos";
            this.buttonReporteProyectos.Size = new System.Drawing.Size(79, 74);
            this.buttonReporteProyectos.TabIndex = 83;
            this.buttonReporteProyectos.Text = "Proyectos";
            this.buttonReporteProyectos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonReporteProyectos.UseVisualStyleBackColor = true;
            this.buttonReporteProyectos.Click += new System.EventHandler(this.buttonReporteProyectos_Click);
            // 
            // buttonReporteUsuarios
            // 
            this.buttonReporteUsuarios.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReporteUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("buttonReporteUsuarios.Image")));
            this.buttonReporteUsuarios.Location = new System.Drawing.Point(447, 11);
            this.buttonReporteUsuarios.Name = "buttonReporteUsuarios";
            this.buttonReporteUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonReporteUsuarios.Size = new System.Drawing.Size(79, 74);
            this.buttonReporteUsuarios.TabIndex = 84;
            this.buttonReporteUsuarios.Text = "Empleados";
            this.buttonReporteUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonReporteUsuarios.UseVisualStyleBackColor = true;
            this.buttonReporteUsuarios.Click += new System.EventHandler(this.buttonReporteUsuarios_Click);
            // 
            // buttonReoprteMateriales
            // 
            this.buttonReoprteMateriales.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReoprteMateriales.Image = ((System.Drawing.Image)(resources.GetObject("buttonReoprteMateriales.Image")));
            this.buttonReoprteMateriales.Location = new System.Drawing.Point(808, 12);
            this.buttonReoprteMateriales.Name = "buttonReoprteMateriales";
            this.buttonReoprteMateriales.Size = new System.Drawing.Size(70, 73);
            this.buttonReoprteMateriales.TabIndex = 85;
            this.buttonReoprteMateriales.Text = "Materiales";
            this.buttonReoprteMateriales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonReoprteMateriales.UseVisualStyleBackColor = true;
            this.buttonReoprteMateriales.Visible = false;
            this.buttonReoprteMateriales.Click += new System.EventHandler(this.buttonReoprteMateriales_Click);
            // 
            // buttonBusquedaBaseDatos
            // 
            this.buttonBusquedaBaseDatos.BackColor = System.Drawing.Color.White;
            this.buttonBusquedaBaseDatos.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBusquedaBaseDatos.Image = ((System.Drawing.Image)(resources.GetObject("buttonBusquedaBaseDatos.Image")));
            this.buttonBusquedaBaseDatos.Location = new System.Drawing.Point(617, 11);
            this.buttonBusquedaBaseDatos.Name = "buttonBusquedaBaseDatos";
            this.buttonBusquedaBaseDatos.Size = new System.Drawing.Size(79, 74);
            this.buttonBusquedaBaseDatos.TabIndex = 86;
            this.buttonBusquedaBaseDatos.Text = "Fechas";
            this.buttonBusquedaBaseDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBusquedaBaseDatos.UseVisualStyleBackColor = false;
            this.buttonBusquedaBaseDatos.Visible = false;
            this.buttonBusquedaBaseDatos.Click += new System.EventHandler(this.buttonBusquedaBaseDatos_Click);
            // 
            // comboBoxNombreEmpleado
            // 
            this.comboBoxNombreEmpleado.FormattingEnabled = true;
            this.comboBoxNombreEmpleado.Location = new System.Drawing.Point(220, 125);
            this.comboBoxNombreEmpleado.Name = "comboBoxNombreEmpleado";
            this.comboBoxNombreEmpleado.Size = new System.Drawing.Size(268, 21);
            this.comboBoxNombreEmpleado.Sorted = true;
            this.comboBoxNombreEmpleado.TabIndex = 88;
            this.comboBoxNombreEmpleado.Visible = false;
            this.comboBoxNombreEmpleado.SelectedIndexChanged += new System.EventHandler(this.comboBoxNombreEmpleado_SelectedIndexChanged);
            // 
            // labelNombreEmpleado
            // 
            this.labelNombreEmpleado.AutoSize = true;
            this.labelNombreEmpleado.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("labelNombreEmpleado.Image")));
            this.labelNombreEmpleado.Location = new System.Drawing.Point(99, 129);
            this.labelNombreEmpleado.Name = "labelNombreEmpleado";
            this.labelNombreEmpleado.Size = new System.Drawing.Size(106, 16);
            this.labelNombreEmpleado.TabIndex = 87;
            this.labelNombreEmpleado.Text = "Nombre Empleado";
            this.labelNombreEmpleado.Visible = false;
            // 
            // textCodigoMaterial
            // 
            this.textCodigoMaterial.Location = new System.Drawing.Point(1117, 21);
            this.textCodigoMaterial.Name = "textCodigoMaterial";
            this.textCodigoMaterial.Size = new System.Drawing.Size(124, 20);
            this.textCodigoMaterial.TabIndex = 90;
            this.textCodigoMaterial.Visible = false;
            // 
            // labelCodigoMaterial
            // 
            this.labelCodigoMaterial.AutoSize = true;
            this.labelCodigoMaterial.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoMaterial.Image = ((System.Drawing.Image)(resources.GetObject("labelCodigoMaterial.Image")));
            this.labelCodigoMaterial.Location = new System.Drawing.Point(920, 21);
            this.labelCodigoMaterial.Name = "labelCodigoMaterial";
            this.labelCodigoMaterial.Size = new System.Drawing.Size(94, 16);
            this.labelCodigoMaterial.TabIndex = 89;
            this.labelCodigoMaterial.Text = "Codigo Material";
            this.labelCodigoMaterial.Visible = false;
            // 
            // textBoxCodigoProveedor
            // 
            this.textBoxCodigoProveedor.Location = new System.Drawing.Point(1117, 47);
            this.textBoxCodigoProveedor.Name = "textBoxCodigoProveedor";
            this.textBoxCodigoProveedor.Size = new System.Drawing.Size(124, 20);
            this.textBoxCodigoProveedor.TabIndex = 92;
            this.textBoxCodigoProveedor.Visible = false;
            // 
            // labelCodigoMaterialProveedor
            // 
            this.labelCodigoMaterialProveedor.AutoSize = true;
            this.labelCodigoMaterialProveedor.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoMaterialProveedor.Image = ((System.Drawing.Image)(resources.GetObject("labelCodigoMaterialProveedor.Image")));
            this.labelCodigoMaterialProveedor.Location = new System.Drawing.Point(919, 45);
            this.labelCodigoMaterialProveedor.Name = "labelCodigoMaterialProveedor";
            this.labelCodigoMaterialProveedor.Size = new System.Drawing.Size(150, 16);
            this.labelCodigoMaterialProveedor.TabIndex = 91;
            this.labelCodigoMaterialProveedor.Text = "Codigo Proveedor Material";
            this.labelCodigoMaterialProveedor.Visible = false;
            // 
            // textBoxDescripcionMaterial
            // 
            this.textBoxDescripcionMaterial.Location = new System.Drawing.Point(1007, 103);
            this.textBoxDescripcionMaterial.Name = "textBoxDescripcionMaterial";
            this.textBoxDescripcionMaterial.Size = new System.Drawing.Size(246, 20);
            this.textBoxDescripcionMaterial.TabIndex = 94;
            this.textBoxDescripcionMaterial.Visible = false;
            // 
            // labelMaterialDescripcion
            // 
            this.labelMaterialDescripcion.AutoSize = true;
            this.labelMaterialDescripcion.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaterialDescripcion.Image = ((System.Drawing.Image)(resources.GetObject("labelMaterialDescripcion.Image")));
            this.labelMaterialDescripcion.Location = new System.Drawing.Point(920, 72);
            this.labelMaterialDescripcion.Name = "labelMaterialDescripcion";
            this.labelMaterialDescripcion.Size = new System.Drawing.Size(120, 16);
            this.labelMaterialDescripcion.TabIndex = 93;
            this.labelMaterialDescripcion.Text = "Material Descripcion";
            this.labelMaterialDescripcion.Visible = false;
            // 
            // timerBusquedaFecha
            // 
            this.timerBusquedaFecha.Interval = 1000;
            this.timerBusquedaFecha.Tick += new System.EventHandler(this.timerBusquedaFecha_Tick);
            // 
            // buttonExcel
            // 
            this.buttonExcel.AutoSize = true;
            this.buttonExcel.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcel.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcel.Image")));
            this.buttonExcel.Location = new System.Drawing.Point(1177, 275);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(79, 74);
            this.buttonExcel.TabIndex = 95;
            this.buttonExcel.Text = "Excel";
            this.buttonExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Visible = false;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // comboBoxNombreProyecto
            // 
            this.comboBoxNombreProyecto.FormattingEnabled = true;
            this.comboBoxNombreProyecto.Location = new System.Drawing.Point(220, 150);
            this.comboBoxNombreProyecto.Name = "comboBoxNombreProyecto";
            this.comboBoxNombreProyecto.Size = new System.Drawing.Size(268, 21);
            this.comboBoxNombreProyecto.Sorted = true;
            this.comboBoxNombreProyecto.TabIndex = 96;
            this.comboBoxNombreProyecto.Visible = false;
            this.comboBoxNombreProyecto.SelectedIndexChanged += new System.EventHandler(this.comboBoxNombreProyecto_SelectedIndexChanged);
            // 
            // buttonFecha
            // 
            this.buttonFecha.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFecha.Image = ((System.Drawing.Image)(resources.GetObject("buttonFecha.Image")));
            this.buttonFecha.Location = new System.Drawing.Point(532, 11);
            this.buttonFecha.Name = "buttonFecha";
            this.buttonFecha.Size = new System.Drawing.Size(79, 74);
            this.buttonFecha.TabIndex = 97;
            this.buttonFecha.Text = "Fecha";
            this.buttonFecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFecha.UseVisualStyleBackColor = true;
            this.buttonFecha.Click += new System.EventHandler(this.buttonFecha_Click);
            // 
            // dateTimePickerFechaFinal
            // 
            this.dateTimePickerFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaFinal.Location = new System.Drawing.Point(656, 167);
            this.dateTimePickerFechaFinal.Name = "dateTimePickerFechaFinal";
            this.dateTimePickerFechaFinal.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerFechaFinal.TabIndex = 99;
            this.dateTimePickerFechaFinal.Visible = false;
            // 
            // dateTimePickerFechaInicio
            // 
            this.dateTimePickerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaInicio.Location = new System.Drawing.Point(656, 141);
            this.dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            this.dateTimePickerFechaInicio.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerFechaInicio.TabIndex = 98;
            this.dateTimePickerFechaInicio.Visible = false;
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaInicio.Image = ((System.Drawing.Image)(resources.GetObject("labelFechaInicio.Image")));
            this.labelFechaInicio.Location = new System.Drawing.Point(541, 145);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(71, 16);
            this.labelFechaInicio.TabIndex = 100;
            this.labelFechaInicio.Text = "Fecha Inicio";
            this.labelFechaInicio.Visible = false;
            // 
            // labelFechaFinal
            // 
            this.labelFechaFinal.AutoSize = true;
            this.labelFechaFinal.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaFinal.Image = ((System.Drawing.Image)(resources.GetObject("labelFechaFinal.Image")));
            this.labelFechaFinal.Location = new System.Drawing.Point(541, 172);
            this.labelFechaFinal.Name = "labelFechaFinal";
            this.labelFechaFinal.Size = new System.Drawing.Size(68, 16);
            this.labelFechaFinal.TabIndex = 101;
            this.labelFechaFinal.Text = "Fecha Final";
            this.labelFechaFinal.Visible = false;
            // 
            // comboBoxFechaFiltro
            // 
            this.comboBoxFechaFiltro.FormattingEnabled = true;
            this.comboBoxFechaFiltro.Items.AddRange(new object[] {
            "Tiempo Inicio",
            "Tiempo Termino"});
            this.comboBoxFechaFiltro.Location = new System.Drawing.Point(656, 103);
            this.comboBoxFechaFiltro.Name = "comboBoxFechaFiltro";
            this.comboBoxFechaFiltro.Size = new System.Drawing.Size(156, 21);
            this.comboBoxFechaFiltro.Sorted = true;
            this.comboBoxFechaFiltro.TabIndex = 102;
            this.comboBoxFechaFiltro.Visible = false;
            // 
            // labelFechaFiltro
            // 
            this.labelFechaFiltro.AutoSize = true;
            this.labelFechaFiltro.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaFiltro.Image = ((System.Drawing.Image)(resources.GetObject("labelFechaFiltro.Image")));
            this.labelFechaFiltro.Location = new System.Drawing.Point(541, 108);
            this.labelFechaFiltro.Name = "labelFechaFiltro";
            this.labelFechaFiltro.Size = new System.Drawing.Size(38, 16);
            this.labelFechaFiltro.TabIndex = 103;
            this.labelFechaFiltro.Text = "Fecha";
            this.labelFechaFiltro.Visible = false;
            // 
            // buttonFiltros
            // 
            this.buttonFiltros.BackColor = System.Drawing.Color.White;
            this.buttonFiltros.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltros.Image = ((System.Drawing.Image)(resources.GetObject("buttonFiltros.Image")));
            this.buttonFiltros.Location = new System.Drawing.Point(702, 11);
            this.buttonFiltros.Name = "buttonFiltros";
            this.buttonFiltros.Size = new System.Drawing.Size(79, 74);
            this.buttonFiltros.TabIndex = 104;
            this.buttonFiltros.Text = "Filtros";
            this.buttonFiltros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFiltros.UseVisualStyleBackColor = false;
            this.buttonFiltros.Visible = false;
            this.buttonFiltros.Click += new System.EventHandler(this.buttonFiltros_Click);
            // 
            // Forma_Reporte_Dibujos_Proyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 599);
            this.Controls.Add(this.buttonFiltros);
            this.Controls.Add(this.labelFechaFiltro);
            this.Controls.Add(this.comboBoxFechaFiltro);
            this.Controls.Add(this.labelFechaFinal);
            this.Controls.Add(this.labelFechaInicio);
            this.Controls.Add(this.dateTimePickerFechaFinal);
            this.Controls.Add(this.dateTimePickerFechaInicio);
            this.Controls.Add(this.buttonFecha);
            this.Controls.Add(this.comboBoxNombreProyecto);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.textBoxDescripcionMaterial);
            this.Controls.Add(this.labelMaterialDescripcion);
            this.Controls.Add(this.textBoxCodigoProveedor);
            this.Controls.Add(this.labelCodigoMaterialProveedor);
            this.Controls.Add(this.textCodigoMaterial);
            this.Controls.Add(this.labelCodigoMaterial);
            this.Controls.Add(this.comboBoxNombreEmpleado);
            this.Controls.Add(this.labelNombreEmpleado);
            this.Controls.Add(this.buttonBusquedaBaseDatos);
            this.Controls.Add(this.buttonReoprteMateriales);
            this.Controls.Add(this.buttonReporteUsuarios);
            this.Controls.Add(this.buttonReporteProyectos);
            this.Controls.Add(this.textBoxPorcentajeProyecto);
            this.Controls.Add(this.labelTotalPorcentajeDibujos);
            this.Controls.Add(this.textBoxTotalDibujoCompletos);
            this.Controls.Add(this.labelTotalDibujosCompletos);
            this.Controls.Add(this.textBoxTotalDibujos);
            this.Controls.Add(this.labelTotalDibujos);
            this.Controls.Add(this.textBoxIngenieroCliente);
            this.Controls.Add(this.labelIngenieroCliente);
            this.Controls.Add(this.textBoxCodigoCliente);
            this.Controls.Add(this.labelCodigoCliente);
            this.Controls.Add(this.textBoxNombreProyecto);
            this.Controls.Add(this.labelNombreProyecto);
            this.Controls.Add(this.textBoxIngenieroCoset);
            this.Controls.Add(this.labelIngenieroCoset);
            this.Controls.Add(this.comboBoxCodigoProyecto);
            this.Controls.Add(this.dataGridViewReporteDibujosProyecto);
            this.Controls.Add(this.textBoxNombreCliente);
            this.Controls.Add(this.labelNombreCliente);
            this.Controls.Add(this.textBoxCodigoProyecto);
            this.Controls.Add(this.labelCodigoProyecto);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonBorrarBasedeDatos);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonGuardarBasedeDatos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Forma_Reporte_Dibujos_Proyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Dibujos Proyectos";
            this.Load += new System.EventHandler(this.Forma_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporteDibujosProyecto)).EndInit();
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
        private System.Windows.Forms.Label labelNombreCliente;
        private System.Windows.Forms.TextBox textBoxCodigoProyecto;
        private System.Windows.Forms.Label labelCodigoProyecto;
        private System.Windows.Forms.DataGridView dataGridViewReporteDibujosProyecto;
        private System.Windows.Forms.ComboBox comboBoxCodigoProyecto;
        private System.Windows.Forms.Timer timerModificarClientes;
        private System.Windows.Forms.TextBox textBoxIngenieroCoset;
        private System.Windows.Forms.Label labelIngenieroCoset;
        private System.Windows.Forms.Label labelNombreProyecto;
        private System.Windows.Forms.TextBox textBoxNombreProyecto;
        private System.Windows.Forms.Label labelCodigoCliente;
        private System.Windows.Forms.TextBox textBoxCodigoCliente;
        private System.Windows.Forms.Label labelIngenieroCliente;
        private System.Windows.Forms.TextBox textBoxIngenieroCliente;
        private System.Windows.Forms.TextBox textBoxTotalDibujos;
        private System.Windows.Forms.Label labelTotalDibujos;
        private System.Windows.Forms.TextBox textBoxTotalDibujoCompletos;
        private System.Windows.Forms.Label labelTotalDibujosCompletos;
        private System.Windows.Forms.TextBox textBoxPorcentajeProyecto;
        private System.Windows.Forms.Label labelTotalPorcentajeDibujos;
        private System.Windows.Forms.Button buttonReporteProyectos;
        private System.Windows.Forms.Button buttonReporteUsuarios;
        private System.Windows.Forms.Button buttonReoprteMateriales;
        private System.Windows.Forms.Button buttonBusquedaBaseDatos;
        private System.Windows.Forms.ComboBox comboBoxNombreEmpleado;
        private System.Windows.Forms.Label labelNombreEmpleado;
        private System.Windows.Forms.TextBox textCodigoMaterial;
        private System.Windows.Forms.Label labelCodigoMaterial;
        private System.Windows.Forms.TextBox textBoxCodigoProveedor;
        private System.Windows.Forms.Label labelCodigoMaterialProveedor;
        private System.Windows.Forms.TextBox textBoxDescripcionMaterial;
        private System.Windows.Forms.Label labelMaterialDescripcion;
        private System.Windows.Forms.Timer timerBusquedaFecha;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.ComboBox comboBoxNombreProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_dibujo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proceso_dibujo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_dibujo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas_produccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas_retrabajo;
        private System.Windows.Forms.Button buttonFecha;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFinal;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicio;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Label labelFechaFinal;
        private System.Windows.Forms.ComboBox comboBoxFechaFiltro;
        private System.Windows.Forms.Label labelFechaFiltro;
        private System.Windows.Forms.Button buttonFiltros;
    }
}