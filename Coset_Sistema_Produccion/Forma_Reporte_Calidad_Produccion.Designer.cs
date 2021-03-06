﻿namespace Coset_Sistema_Produccion
{
    partial class Forma_Reporte_Calidad_Produccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma_Reporte_Calidad_Produccion));
            this.timerAgregarProyecto = new System.Windows.Forms.Timer(this.components);
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.textBoxCodigoProyecto = new System.Windows.Forms.TextBox();
            this.dataGridViewReporteDibujosCalidad = new System.Windows.Forms.DataGridView();
            this.comboBoxCodigoProyecto = new System.Windows.Forms.ComboBox();
            this.timerModificarClientes = new System.Windows.Forms.Timer(this.components);
            this.textBoxIngenieroCoset = new System.Windows.Forms.TextBox();
            this.textBoxNumeroDibujo = new System.Windows.Forms.TextBox();
            this.textBoxCodigoCliente = new System.Windows.Forms.TextBox();
            this.textBoxIngenieroCliente = new System.Windows.Forms.TextBox();
            this.textBoxTotalDibujos = new System.Windows.Forms.TextBox();
            this.textBoxTotalDibujoCompletos = new System.Windows.Forms.TextBox();
            this.textBoxPorcentajeProyecto = new System.Windows.Forms.TextBox();
            this.comboBoxNombreEmpleado = new System.Windows.Forms.ComboBox();
            this.textCodigoMaterial = new System.Windows.Forms.TextBox();
            this.textBoxCodigoProveedor = new System.Windows.Forms.TextBox();
            this.textBoxDescripcionMaterial = new System.Windows.Forms.TextBox();
            this.timerBusquedaMaterial = new System.Windows.Forms.Timer(this.components);
            this.comboBoxNombreProyecto = new System.Windows.Forms.ComboBox();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.labelMaterialDescripcion = new System.Windows.Forms.Label();
            this.labelCodigoMaterialProveedor = new System.Windows.Forms.Label();
            this.labelCodigoMaterial = new System.Windows.Forms.Label();
            this.labelNombreEmpleado = new System.Windows.Forms.Label();
            this.buttonBusquedaBaseDatos = new System.Windows.Forms.Button();
            this.buttonReoprteMateriales = new System.Windows.Forms.Button();
            this.buttonReporteUsuarios = new System.Windows.Forms.Button();
            this.buttonReporteDibujos = new System.Windows.Forms.Button();
            this.labelTotalPorcentajeDibujos = new System.Windows.Forms.Label();
            this.labelTotalDibujosCompletos = new System.Windows.Forms.Label();
            this.labelTotalDibujos = new System.Windows.Forms.Label();
            this.labelIngenieroCliente = new System.Windows.Forms.Label();
            this.labelCodigoCliente = new System.Windows.Forms.Label();
            this.labelNumeroDibujo = new System.Windows.Forms.Label();
            this.labelIngenieroCoset = new System.Windows.Forms.Label();
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.labelCodigoProyecto = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonBorrarBasedeDatos = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonGuardarBasedeDatos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Numero_dibujo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proceso_dibujo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Calidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotivoRechazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccionCorrectiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporteDibujosCalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerAgregarProyecto
            // 
            this.timerAgregarProyecto.Interval = 1000;
            this.timerAgregarProyecto.Tick += new System.EventHandler(this.timerAgregarCliente_Tick);
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Enabled = false;
            this.textBoxNombreCliente.Location = new System.Drawing.Point(220, 174);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.Size = new System.Drawing.Size(268, 20);
            this.textBoxNombreCliente.TabIndex = 40;
            this.textBoxNombreCliente.Visible = false;
            // 
            // textBoxCodigoProyecto
            // 
            this.textBoxCodigoProyecto.Enabled = false;
            this.textBoxCodigoProyecto.Location = new System.Drawing.Point(220, 91);
            this.textBoxCodigoProyecto.Name = "textBoxCodigoProyecto";
            this.textBoxCodigoProyecto.Size = new System.Drawing.Size(121, 20);
            this.textBoxCodigoProyecto.TabIndex = 38;
            this.textBoxCodigoProyecto.Visible = false;
            this.textBoxCodigoProyecto.WordWrap = false;
            // 
            // dataGridViewReporteDibujosCalidad
            // 
            this.dataGridViewReporteDibujosCalidad.AllowUserToDeleteRows = false;
            this.dataGridViewReporteDibujosCalidad.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewReporteDibujosCalidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReporteDibujosCalidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_dibujo,
            this.Empleado,
            this.FechaCalidad,
            this.Proceso_dibujo,
            this.Estado_Calidad,
            this.MotivoRechazo,
            this.AccionCorrectiva});
            this.dataGridViewReporteDibujosCalidad.Enabled = false;
            this.dataGridViewReporteDibujosCalidad.Location = new System.Drawing.Point(23, 275);
            this.dataGridViewReporteDibujosCalidad.Name = "dataGridViewReporteDibujosCalidad";
            this.dataGridViewReporteDibujosCalidad.ReadOnly = true;
            this.dataGridViewReporteDibujosCalidad.Size = new System.Drawing.Size(1148, 234);
            this.dataGridViewReporteDibujosCalidad.TabIndex = 48;
            // 
            // comboBoxCodigoProyecto
            // 
            this.comboBoxCodigoProyecto.FormattingEnabled = true;
            this.comboBoxCodigoProyecto.Location = new System.Drawing.Point(220, 90);
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
            this.textBoxIngenieroCoset.Location = new System.Drawing.Point(220, 203);
            this.textBoxIngenieroCoset.Name = "textBoxIngenieroCoset";
            this.textBoxIngenieroCoset.Size = new System.Drawing.Size(268, 20);
            this.textBoxIngenieroCoset.TabIndex = 55;
            this.textBoxIngenieroCoset.Visible = false;
            // 
            // textBoxNumeroDibujo
            // 
            this.textBoxNumeroDibujo.Enabled = false;
            this.textBoxNumeroDibujo.Location = new System.Drawing.Point(220, 117);
            this.textBoxNumeroDibujo.Name = "textBoxNumeroDibujo";
            this.textBoxNumeroDibujo.Size = new System.Drawing.Size(268, 20);
            this.textBoxNumeroDibujo.TabIndex = 69;
            this.textBoxNumeroDibujo.Visible = false;
            this.textBoxNumeroDibujo.TextChanged += new System.EventHandler(this.textBoxNumeroDibujo_TextChanged);
            // 
            // textBoxCodigoCliente
            // 
            this.textBoxCodigoCliente.Enabled = false;
            this.textBoxCodigoCliente.Location = new System.Drawing.Point(220, 145);
            this.textBoxCodigoCliente.Name = "textBoxCodigoCliente";
            this.textBoxCodigoCliente.Size = new System.Drawing.Size(121, 20);
            this.textBoxCodigoCliente.TabIndex = 74;
            this.textBoxCodigoCliente.Visible = false;
            // 
            // textBoxIngenieroCliente
            // 
            this.textBoxIngenieroCliente.Enabled = false;
            this.textBoxIngenieroCliente.Location = new System.Drawing.Point(220, 230);
            this.textBoxIngenieroCliente.Name = "textBoxIngenieroCliente";
            this.textBoxIngenieroCliente.Size = new System.Drawing.Size(268, 20);
            this.textBoxIngenieroCliente.TabIndex = 76;
            this.textBoxIngenieroCliente.Visible = false;
            // 
            // textBoxTotalDibujos
            // 
            this.textBoxTotalDibujos.Enabled = false;
            this.textBoxTotalDibujos.Location = new System.Drawing.Point(771, 99);
            this.textBoxTotalDibujos.Name = "textBoxTotalDibujos";
            this.textBoxTotalDibujos.Size = new System.Drawing.Size(124, 20);
            this.textBoxTotalDibujos.TabIndex = 78;
            this.textBoxTotalDibujos.Visible = false;
            // 
            // textBoxTotalDibujoCompletos
            // 
            this.textBoxTotalDibujoCompletos.Enabled = false;
            this.textBoxTotalDibujoCompletos.Location = new System.Drawing.Point(771, 125);
            this.textBoxTotalDibujoCompletos.Name = "textBoxTotalDibujoCompletos";
            this.textBoxTotalDibujoCompletos.Size = new System.Drawing.Size(124, 20);
            this.textBoxTotalDibujoCompletos.TabIndex = 80;
            this.textBoxTotalDibujoCompletos.Visible = false;
            // 
            // textBoxPorcentajeProyecto
            // 
            this.textBoxPorcentajeProyecto.Enabled = false;
            this.textBoxPorcentajeProyecto.Location = new System.Drawing.Point(771, 151);
            this.textBoxPorcentajeProyecto.Name = "textBoxPorcentajeProyecto";
            this.textBoxPorcentajeProyecto.Size = new System.Drawing.Size(124, 20);
            this.textBoxPorcentajeProyecto.TabIndex = 82;
            this.textBoxPorcentajeProyecto.Visible = false;
            // 
            // comboBoxNombreEmpleado
            // 
            this.comboBoxNombreEmpleado.FormattingEnabled = true;
            this.comboBoxNombreEmpleado.Location = new System.Drawing.Point(220, 91);
            this.comboBoxNombreEmpleado.Name = "comboBoxNombreEmpleado";
            this.comboBoxNombreEmpleado.Size = new System.Drawing.Size(268, 21);
            this.comboBoxNombreEmpleado.Sorted = true;
            this.comboBoxNombreEmpleado.TabIndex = 88;
            this.comboBoxNombreEmpleado.Visible = false;
            this.comboBoxNombreEmpleado.SelectedIndexChanged += new System.EventHandler(this.comboBoxNombreEmpleado_SelectedIndexChanged);
            // 
            // textCodigoMaterial
            // 
            this.textCodigoMaterial.Location = new System.Drawing.Point(771, 177);
            this.textCodigoMaterial.Name = "textCodigoMaterial";
            this.textCodigoMaterial.Size = new System.Drawing.Size(124, 20);
            this.textCodigoMaterial.TabIndex = 90;
            this.textCodigoMaterial.Visible = false;
            // 
            // textBoxCodigoProveedor
            // 
            this.textBoxCodigoProveedor.Location = new System.Drawing.Point(771, 203);
            this.textBoxCodigoProveedor.Name = "textBoxCodigoProveedor";
            this.textBoxCodigoProveedor.Size = new System.Drawing.Size(124, 20);
            this.textBoxCodigoProveedor.TabIndex = 92;
            this.textBoxCodigoProveedor.Visible = false;
            // 
            // textBoxDescripcionMaterial
            // 
            this.textBoxDescripcionMaterial.Location = new System.Drawing.Point(771, 230);
            this.textBoxDescripcionMaterial.Name = "textBoxDescripcionMaterial";
            this.textBoxDescripcionMaterial.Size = new System.Drawing.Size(246, 20);
            this.textBoxDescripcionMaterial.TabIndex = 94;
            this.textBoxDescripcionMaterial.Visible = false;
            // 
            // timerBusquedaMaterial
            // 
            this.timerBusquedaMaterial.Interval = 1000;
            this.timerBusquedaMaterial.Tick += new System.EventHandler(this.timerBusquedaMaterial_Tick);
            // 
            // comboBoxNombreProyecto
            // 
            this.comboBoxNombreProyecto.FormattingEnabled = true;
            this.comboBoxNombreProyecto.Location = new System.Drawing.Point(220, 117);
            this.comboBoxNombreProyecto.Name = "comboBoxNombreProyecto";
            this.comboBoxNombreProyecto.Size = new System.Drawing.Size(268, 21);
            this.comboBoxNombreProyecto.Sorted = true;
            this.comboBoxNombreProyecto.TabIndex = 96;
            this.comboBoxNombreProyecto.Visible = false;
            this.comboBoxNombreProyecto.SelectedIndexChanged += new System.EventHandler(this.comboBoxNombreProyecto_SelectedIndexChanged);
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
            // labelMaterialDescripcion
            // 
            this.labelMaterialDescripcion.AutoSize = true;
            this.labelMaterialDescripcion.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaterialDescripcion.Image = ((System.Drawing.Image)(resources.GetObject("labelMaterialDescripcion.Image")));
            this.labelMaterialDescripcion.Location = new System.Drawing.Point(574, 228);
            this.labelMaterialDescripcion.Name = "labelMaterialDescripcion";
            this.labelMaterialDescripcion.Size = new System.Drawing.Size(120, 16);
            this.labelMaterialDescripcion.TabIndex = 93;
            this.labelMaterialDescripcion.Text = "Material Descripcion";
            this.labelMaterialDescripcion.Visible = false;
            // 
            // labelCodigoMaterialProveedor
            // 
            this.labelCodigoMaterialProveedor.AutoSize = true;
            this.labelCodigoMaterialProveedor.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoMaterialProveedor.Image = ((System.Drawing.Image)(resources.GetObject("labelCodigoMaterialProveedor.Image")));
            this.labelCodigoMaterialProveedor.Location = new System.Drawing.Point(573, 201);
            this.labelCodigoMaterialProveedor.Name = "labelCodigoMaterialProveedor";
            this.labelCodigoMaterialProveedor.Size = new System.Drawing.Size(150, 16);
            this.labelCodigoMaterialProveedor.TabIndex = 91;
            this.labelCodigoMaterialProveedor.Text = "Codigo Proveedor Material";
            this.labelCodigoMaterialProveedor.Visible = false;
            // 
            // labelCodigoMaterial
            // 
            this.labelCodigoMaterial.AutoSize = true;
            this.labelCodigoMaterial.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoMaterial.Image = ((System.Drawing.Image)(resources.GetObject("labelCodigoMaterial.Image")));
            this.labelCodigoMaterial.Location = new System.Drawing.Point(574, 177);
            this.labelCodigoMaterial.Name = "labelCodigoMaterial";
            this.labelCodigoMaterial.Size = new System.Drawing.Size(94, 16);
            this.labelCodigoMaterial.TabIndex = 89;
            this.labelCodigoMaterial.Text = "Codigo Material";
            this.labelCodigoMaterial.Visible = false;
            // 
            // labelNombreEmpleado
            // 
            this.labelNombreEmpleado.AutoSize = true;
            this.labelNombreEmpleado.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("labelNombreEmpleado.Image")));
            this.labelNombreEmpleado.Location = new System.Drawing.Point(99, 95);
            this.labelNombreEmpleado.Name = "labelNombreEmpleado";
            this.labelNombreEmpleado.Size = new System.Drawing.Size(106, 16);
            this.labelNombreEmpleado.TabIndex = 87;
            this.labelNombreEmpleado.Text = "Nombre Empleado";
            this.labelNombreEmpleado.Visible = false;
            // 
            // buttonBusquedaBaseDatos
            // 
            this.buttonBusquedaBaseDatos.BackColor = System.Drawing.Color.White;
            this.buttonBusquedaBaseDatos.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBusquedaBaseDatos.Image = ((System.Drawing.Image)(resources.GetObject("buttonBusquedaBaseDatos.Image")));
            this.buttonBusquedaBaseDatos.Location = new System.Drawing.Point(723, 12);
            this.buttonBusquedaBaseDatos.Name = "buttonBusquedaBaseDatos";
            this.buttonBusquedaBaseDatos.Size = new System.Drawing.Size(79, 74);
            this.buttonBusquedaBaseDatos.TabIndex = 86;
            this.buttonBusquedaBaseDatos.Text = "Buscar";
            this.buttonBusquedaBaseDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBusquedaBaseDatos.UseVisualStyleBackColor = false;
            this.buttonBusquedaBaseDatos.Visible = false;
            this.buttonBusquedaBaseDatos.Click += new System.EventHandler(this.buttonBusquedaBaseDatos_Click);
            // 
            // buttonReoprteMateriales
            // 
            this.buttonReoprteMateriales.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReoprteMateriales.Image = ((System.Drawing.Image)(resources.GetObject("buttonReoprteMateriales.Image")));
            this.buttonReoprteMateriales.Location = new System.Drawing.Point(638, 12);
            this.buttonReoprteMateriales.Name = "buttonReoprteMateriales";
            this.buttonReoprteMateriales.Size = new System.Drawing.Size(79, 74);
            this.buttonReoprteMateriales.TabIndex = 85;
            this.buttonReoprteMateriales.Text = "Materiales";
            this.buttonReoprteMateriales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonReoprteMateriales.UseVisualStyleBackColor = true;
            this.buttonReoprteMateriales.Visible = false;
            this.buttonReoprteMateriales.Click += new System.EventHandler(this.buttonReoprteMateriales_Click);
            // 
            // buttonReporteUsuarios
            // 
            this.buttonReporteUsuarios.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReporteUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("buttonReporteUsuarios.Image")));
            this.buttonReporteUsuarios.Location = new System.Drawing.Point(553, 12);
            this.buttonReporteUsuarios.Name = "buttonReporteUsuarios";
            this.buttonReporteUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonReporteUsuarios.Size = new System.Drawing.Size(79, 74);
            this.buttonReporteUsuarios.TabIndex = 84;
            this.buttonReporteUsuarios.Text = "Empleados";
            this.buttonReporteUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonReporteUsuarios.UseVisualStyleBackColor = true;
            this.buttonReporteUsuarios.Click += new System.EventHandler(this.buttonReporteUsuarios_Click);
            // 
            // buttonReporteDibujos
            // 
            this.buttonReporteDibujos.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReporteDibujos.Image = ((System.Drawing.Image)(resources.GetObject("buttonReporteDibujos.Image")));
            this.buttonReporteDibujos.Location = new System.Drawing.Point(468, 12);
            this.buttonReporteDibujos.Name = "buttonReporteDibujos";
            this.buttonReporteDibujos.Size = new System.Drawing.Size(79, 74);
            this.buttonReporteDibujos.TabIndex = 83;
            this.buttonReporteDibujos.Text = "Didujos";
            this.buttonReporteDibujos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonReporteDibujos.UseVisualStyleBackColor = true;
            this.buttonReporteDibujos.Click += new System.EventHandler(this.buttonReporteProyectos_Click);
            // 
            // labelTotalPorcentajeDibujos
            // 
            this.labelTotalPorcentajeDibujos.AutoSize = true;
            this.labelTotalPorcentajeDibujos.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPorcentajeDibujos.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalPorcentajeDibujos.Image")));
            this.labelTotalPorcentajeDibujos.Location = new System.Drawing.Point(573, 149);
            this.labelTotalPorcentajeDibujos.Name = "labelTotalPorcentajeDibujos";
            this.labelTotalPorcentajeDibujos.Size = new System.Drawing.Size(133, 16);
            this.labelTotalPorcentajeDibujos.TabIndex = 81;
            this.labelTotalPorcentajeDibujos.Text = "Porcentaje Proyecto (%)";
            this.labelTotalPorcentajeDibujos.Visible = false;
            // 
            // labelTotalDibujosCompletos
            // 
            this.labelTotalDibujosCompletos.AutoSize = true;
            this.labelTotalDibujosCompletos.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDibujosCompletos.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalDibujosCompletos.Image")));
            this.labelTotalDibujosCompletos.Location = new System.Drawing.Point(573, 125);
            this.labelTotalDibujosCompletos.Name = "labelTotalDibujosCompletos";
            this.labelTotalDibujosCompletos.Size = new System.Drawing.Size(138, 16);
            this.labelTotalDibujosCompletos.TabIndex = 79;
            this.labelTotalDibujosCompletos.Text = "Total Dibujos Completos";
            this.labelTotalDibujosCompletos.Visible = false;
            // 
            // labelTotalDibujos
            // 
            this.labelTotalDibujos.AutoSize = true;
            this.labelTotalDibujos.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDibujos.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalDibujos.Image")));
            this.labelTotalDibujos.Location = new System.Drawing.Point(573, 99);
            this.labelTotalDibujos.Name = "labelTotalDibujos";
            this.labelTotalDibujos.Size = new System.Drawing.Size(127, 16);
            this.labelTotalDibujos.TabIndex = 77;
            this.labelTotalDibujos.Text = "Total Dibujos Proyecto";
            this.labelTotalDibujos.Visible = false;
            // 
            // labelIngenieroCliente
            // 
            this.labelIngenieroCliente.AutoSize = true;
            this.labelIngenieroCliente.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngenieroCliente.Image = ((System.Drawing.Image)(resources.GetObject("labelIngenieroCliente.Image")));
            this.labelIngenieroCliente.Location = new System.Drawing.Point(99, 230);
            this.labelIngenieroCliente.Name = "labelIngenieroCliente";
            this.labelIngenieroCliente.Size = new System.Drawing.Size(101, 16);
            this.labelIngenieroCliente.TabIndex = 75;
            this.labelIngenieroCliente.Text = "Ingeniero Cliente";
            this.labelIngenieroCliente.Visible = false;
            // 
            // labelCodigoCliente
            // 
            this.labelCodigoCliente.AutoSize = true;
            this.labelCodigoCliente.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoCliente.Image = ((System.Drawing.Image)(resources.GetObject("labelCodigoCliente.Image")));
            this.labelCodigoCliente.Location = new System.Drawing.Point(99, 145);
            this.labelCodigoCliente.Name = "labelCodigoCliente";
            this.labelCodigoCliente.Size = new System.Drawing.Size(87, 16);
            this.labelCodigoCliente.TabIndex = 72;
            this.labelCodigoCliente.Text = "Codigo Cliente";
            this.labelCodigoCliente.Visible = false;
            // 
            // labelNumeroDibujo
            // 
            this.labelNumeroDibujo.AutoSize = true;
            this.labelNumeroDibujo.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroDibujo.Image = ((System.Drawing.Image)(resources.GetObject("labelNumeroDibujo.Image")));
            this.labelNumeroDibujo.Location = new System.Drawing.Point(99, 120);
            this.labelNumeroDibujo.Name = "labelNumeroDibujo";
            this.labelNumeroDibujo.Size = new System.Drawing.Size(89, 16);
            this.labelNumeroDibujo.TabIndex = 68;
            this.labelNumeroDibujo.Text = "Nombre Dibujo";
            this.labelNumeroDibujo.Visible = false;
            // 
            // labelIngenieroCoset
            // 
            this.labelIngenieroCoset.AutoSize = true;
            this.labelIngenieroCoset.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngenieroCoset.Image = ((System.Drawing.Image)(resources.GetObject("labelIngenieroCoset.Image")));
            this.labelIngenieroCoset.Location = new System.Drawing.Point(99, 203);
            this.labelIngenieroCoset.Name = "labelIngenieroCoset";
            this.labelIngenieroCoset.Size = new System.Drawing.Size(100, 16);
            this.labelIngenieroCoset.TabIndex = 54;
            this.labelIngenieroCoset.Text = "Ingeniero COSET";
            this.labelIngenieroCoset.Visible = false;
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.AutoSize = true;
            this.labelNombreCliente.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCliente.Image = ((System.Drawing.Image)(resources.GetObject("labelNombreCliente.Image")));
            this.labelNombreCliente.Location = new System.Drawing.Point(99, 174);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.Size = new System.Drawing.Size(92, 16);
            this.labelNombreCliente.TabIndex = 39;
            this.labelNombreCliente.Text = "Nombre Cliente";
            this.labelNombreCliente.Visible = false;
            // 
            // labelCodigoProyecto
            // 
            this.labelCodigoProyecto.AutoSize = true;
            this.labelCodigoProyecto.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoProyecto.Image = ((System.Drawing.Image)(resources.GetObject("labelCodigoProyecto.Image")));
            this.labelCodigoProyecto.Location = new System.Drawing.Point(99, 95);
            this.labelCodigoProyecto.Name = "labelCodigoProyecto";
            this.labelCodigoProyecto.Size = new System.Drawing.Size(93, 16);
            this.labelCodigoProyecto.TabIndex = 37;
            this.labelCodigoProyecto.Text = "Codigo Proyecto";
            this.labelCodigoProyecto.Visible = false;
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
            // Numero_dibujo
            // 
            this.Numero_dibujo.HeaderText = "Nunero Dibujo";
            this.Numero_dibujo.Name = "Numero_dibujo";
            this.Numero_dibujo.ReadOnly = true;
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empledado";
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            // 
            // FechaCalidad
            // 
            this.FechaCalidad.HeaderText = "Fecha";
            this.FechaCalidad.Name = "FechaCalidad";
            this.FechaCalidad.ReadOnly = true;
            // 
            // Proceso_dibujo
            // 
            this.Proceso_dibujo.HeaderText = "Proceso Dibujo";
            this.Proceso_dibujo.Name = "Proceso_dibujo";
            this.Proceso_dibujo.ReadOnly = true;
            // 
            // Estado_Calidad
            // 
            this.Estado_Calidad.HeaderText = "Estado Calidad";
            this.Estado_Calidad.Name = "Estado_Calidad";
            this.Estado_Calidad.ReadOnly = true;
            this.Estado_Calidad.Width = 150;
            // 
            // MotivoRechazo
            // 
            this.MotivoRechazo.HeaderText = "Motivo Rechazo/ReTrabajo";
            this.MotivoRechazo.Name = "MotivoRechazo";
            this.MotivoRechazo.ReadOnly = true;
            this.MotivoRechazo.Width = 300;
            // 
            // AccionCorrectiva
            // 
            this.AccionCorrectiva.HeaderText = "Accion Correctiva";
            this.AccionCorrectiva.Name = "AccionCorrectiva";
            this.AccionCorrectiva.ReadOnly = true;
            this.AccionCorrectiva.Width = 300;
            // 
            // Forma_Reporte_Calidad_Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 521);
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
            this.Controls.Add(this.buttonReporteDibujos);
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
            this.Controls.Add(this.textBoxNumeroDibujo);
            this.Controls.Add(this.labelNumeroDibujo);
            this.Controls.Add(this.textBoxIngenieroCoset);
            this.Controls.Add(this.labelIngenieroCoset);
            this.Controls.Add(this.comboBoxCodigoProyecto);
            this.Controls.Add(this.dataGridViewReporteDibujosCalidad);
            this.Controls.Add(this.textBoxNombreCliente);
            this.Controls.Add(this.labelNombreCliente);
            this.Controls.Add(this.textBoxCodigoProyecto);
            this.Controls.Add(this.labelCodigoProyecto);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonBorrarBasedeDatos);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonGuardarBasedeDatos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Forma_Reporte_Calidad_Produccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Calidad Produccion";
            this.Load += new System.EventHandler(this.Forma_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporteDibujosCalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewReporteDibujosCalidad;
        private System.Windows.Forms.ComboBox comboBoxCodigoProyecto;
        private System.Windows.Forms.Timer timerModificarClientes;
        private System.Windows.Forms.TextBox textBoxIngenieroCoset;
        private System.Windows.Forms.Label labelIngenieroCoset;
        private System.Windows.Forms.Label labelNumeroDibujo;
        private System.Windows.Forms.TextBox textBoxNumeroDibujo;
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
        private System.Windows.Forms.Button buttonReporteDibujos;
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
        private System.Windows.Forms.Timer timerBusquedaMaterial;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.ComboBox comboBoxNombreProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_dibujo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proceso_dibujo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Calidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotivoRechazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccionCorrectiva;
    }
}