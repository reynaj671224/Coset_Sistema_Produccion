﻿namespace Coset_Sistema_Produccion
{
    partial class Forma_Entrada_Materiales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma_Entrada_Materiales));
            this.timerAgregarEntradaMateriales = new System.Windows.Forms.Timer(this.components);
            this.textBoxDescripcionMaterial = new System.Windows.Forms.TextBox();
            this.textBoxEmpleado = new System.Windows.Forms.TextBox();
            this.textBoxCodigoOrdenCompra = new System.Windows.Forms.TextBox();
            this.dataGridViewPartidasEntradaMaterialesVisualizar = new System.Windows.Forms.DataGridView();
            this.Codigo_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orden_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parte_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_cambio_visualizar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxCodigoOrdenCompra = new System.Windows.Forms.ComboBox();
            this.timerBusquedaMaterial = new System.Windows.Forms.Timer(this.components);
            this.dateTimePickerFechaActual = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDescripcionMaterial = new System.Windows.Forms.ComboBox();
            this.comboBoxEmpleado = new System.Windows.Forms.ComboBox();
            this.textBoxCodigoProveedor = new System.Windows.Forms.TextBox();
            this.textBoxTotalUnidades = new System.Windows.Forms.TextBox();
            this.textBoxUnidadesEntradas = new System.Windows.Forms.TextBox();
            this.textCodigoMaterial = new System.Windows.Forms.TextBox();
            this.textBoxPrecioMaterial = new System.Windows.Forms.TextBox();
            this.textBoxUnidadesEntrada = new System.Windows.Forms.TextBox();
            this.dataGridViewPartidasEntradaMaterialesEntrada = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_materiales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades_ordenadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_recibidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_cambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxDivisa = new System.Windows.Forms.TextBox();
            this.textBoxEstadoOC = new System.Windows.Forms.TextBox();
            this.buttonMateriales = new System.Windows.Forms.Button();
            this.labelEstadoOC = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxReferencia = new System.Windows.Forms.GroupBox();
            this.textBoxReferencia = new System.Windows.Forms.TextBox();
            this.radioButtonRemision = new System.Windows.Forms.RadioButton();
            this.radioButtonFactura = new System.Windows.Forms.RadioButton();
            this.buttonBusquedaBaseDatos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labeldivisa = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonBorrarBasedeDatos = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonGuardarBasedeDatos = new System.Windows.Forms.Button();
            this.buttonBuscarOrdenCompra = new System.Windows.Forms.Button();
            this.buttonAgregarCotizacion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxCodigoEmpleado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartidasEntradaMaterialesVisualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartidasEntradaMaterialesEntrada)).BeginInit();
            this.groupBoxReferencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerAgregarEntradaMateriales
            // 
            this.timerAgregarEntradaMateriales.Interval = 1000;
            this.timerAgregarEntradaMateriales.Tick += new System.EventHandler(this.timerAgregarEntradaMateriales_Tick);
            // 
            // textBoxDescripcionMaterial
            // 
            this.textBoxDescripcionMaterial.Enabled = false;
            this.textBoxDescripcionMaterial.Location = new System.Drawing.Point(262, 162);
            this.textBoxDescripcionMaterial.Name = "textBoxDescripcionMaterial";
            this.textBoxDescripcionMaterial.Size = new System.Drawing.Size(246, 20);
            this.textBoxDescripcionMaterial.TabIndex = 42;
            this.textBoxDescripcionMaterial.TextChanged += new System.EventHandler(this.textBoxDescripcionMaterial_TextChanged);
            // 
            // textBoxEmpleado
            // 
            this.textBoxEmpleado.Enabled = false;
            this.textBoxEmpleado.Location = new System.Drawing.Point(262, 214);
            this.textBoxEmpleado.Name = "textBoxEmpleado";
            this.textBoxEmpleado.Size = new System.Drawing.Size(246, 20);
            this.textBoxEmpleado.TabIndex = 40;
            // 
            // textBoxCodigoOrdenCompra
            // 
            this.textBoxCodigoOrdenCompra.Enabled = false;
            this.textBoxCodigoOrdenCompra.Location = new System.Drawing.Point(262, 136);
            this.textBoxCodigoOrdenCompra.Name = "textBoxCodigoOrdenCompra";
            this.textBoxCodigoOrdenCompra.Size = new System.Drawing.Size(121, 20);
            this.textBoxCodigoOrdenCompra.TabIndex = 38;
            // 
            // dataGridViewPartidasEntradaMaterialesVisualizar
            // 
            this.dataGridViewPartidasEntradaMaterialesVisualizar.AllowUserToAddRows = false;
            this.dataGridViewPartidasEntradaMaterialesVisualizar.AllowUserToDeleteRows = false;
            this.dataGridViewPartidasEntradaMaterialesVisualizar.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewPartidasEntradaMaterialesVisualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPartidasEntradaMaterialesVisualizar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_partida,
            this.Orden_compra,
            this.Fecha,
            this.Codigo_material,
            this.Parte_proveedor,
            this.Nombre_empleado,
            this.Descripcion,
            this.Cantidad,
            this.Precio_partida,
            this.Tipo_cambio_visualizar,
            this.Referencia});
            this.dataGridViewPartidasEntradaMaterialesVisualizar.Enabled = false;
            this.dataGridViewPartidasEntradaMaterialesVisualizar.Location = new System.Drawing.Point(12, 384);
            this.dataGridViewPartidasEntradaMaterialesVisualizar.Name = "dataGridViewPartidasEntradaMaterialesVisualizar";
            this.dataGridViewPartidasEntradaMaterialesVisualizar.ReadOnly = true;
            this.dataGridViewPartidasEntradaMaterialesVisualizar.Size = new System.Drawing.Size(1250, 202);
            this.dataGridViewPartidasEntradaMaterialesVisualizar.TabIndex = 48;
            this.dataGridViewPartidasEntradaMaterialesVisualizar.Visible = false;
            // 
            // Codigo_partida
            // 
            this.Codigo_partida.HeaderText = "Codigo";
            this.Codigo_partida.Name = "Codigo_partida";
            this.Codigo_partida.ReadOnly = true;
            this.Codigo_partida.Width = 50;
            // 
            // Orden_compra
            // 
            this.Orden_compra.HeaderText = "Orden Compra";
            this.Orden_compra.Name = "Orden_compra";
            this.Orden_compra.ReadOnly = true;
            this.Orden_compra.Width = 50;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Codigo_material
            // 
            this.Codigo_material.HeaderText = "Codigo Material";
            this.Codigo_material.Name = "Codigo_material";
            this.Codigo_material.ReadOnly = true;
            // 
            // Parte_proveedor
            // 
            this.Parte_proveedor.HeaderText = "Codigo Parte Proveedor";
            this.Parte_proveedor.Name = "Parte_proveedor";
            this.Parte_proveedor.ReadOnly = true;
            this.Parte_proveedor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Nombre_empleado
            // 
            this.Nombre_empleado.HeaderText = "Nombre Empleado";
            this.Nombre_empleado.Name = "Nombre_empleado";
            this.Nombre_empleado.ReadOnly = true;
            this.Nombre_empleado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nombre_empleado.Width = 200;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 350;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 50;
            // 
            // Precio_partida
            // 
            this.Precio_partida.HeaderText = "Precio";
            this.Precio_partida.Name = "Precio_partida";
            this.Precio_partida.ReadOnly = true;
            this.Precio_partida.Width = 50;
            // 
            // Tipo_cambio_visualizar
            // 
            this.Tipo_cambio_visualizar.HeaderText = "Tipo Cambio";
            this.Tipo_cambio_visualizar.Name = "Tipo_cambio_visualizar";
            this.Tipo_cambio_visualizar.ReadOnly = true;
            // 
            // Referencia
            // 
            this.Referencia.HeaderText = "Referencia";
            this.Referencia.Name = "Referencia";
            this.Referencia.ReadOnly = true;
            // 
            // comboBoxCodigoOrdenCompra
            // 
            this.comboBoxCodigoOrdenCompra.FormattingEnabled = true;
            this.comboBoxCodigoOrdenCompra.Location = new System.Drawing.Point(262, 136);
            this.comboBoxCodigoOrdenCompra.Name = "comboBoxCodigoOrdenCompra";
            this.comboBoxCodigoOrdenCompra.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCodigoOrdenCompra.Sorted = true;
            this.comboBoxCodigoOrdenCompra.TabIndex = 49;
            this.comboBoxCodigoOrdenCompra.Visible = false;
            this.comboBoxCodigoOrdenCompra.SelectedIndexChanged += new System.EventHandler(this.comboBoxCodigoOrdenCompra_SelectedIndexChanged);
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
            this.dateTimePickerFechaActual.Location = new System.Drawing.Point(262, 266);
            this.dateTimePickerFechaActual.Name = "dateTimePickerFechaActual";
            this.dateTimePickerFechaActual.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerFechaActual.TabIndex = 57;
            // 
            // comboBoxDescripcionMaterial
            // 
            this.comboBoxDescripcionMaterial.FormattingEnabled = true;
            this.comboBoxDescripcionMaterial.Location = new System.Drawing.Point(262, 161);
            this.comboBoxDescripcionMaterial.Name = "comboBoxDescripcionMaterial";
            this.comboBoxDescripcionMaterial.Size = new System.Drawing.Size(246, 21);
            this.comboBoxDescripcionMaterial.Sorted = true;
            this.comboBoxDescripcionMaterial.TabIndex = 60;
            this.comboBoxDescripcionMaterial.Visible = false;
            this.comboBoxDescripcionMaterial.SelectedIndexChanged += new System.EventHandler(this.comboBoxDescripcionMaterial_SelectedIndexChanged);
            // 
            // comboBoxEmpleado
            // 
            this.comboBoxEmpleado.FormattingEnabled = true;
            this.comboBoxEmpleado.Location = new System.Drawing.Point(262, 213);
            this.comboBoxEmpleado.Name = "comboBoxEmpleado";
            this.comboBoxEmpleado.Size = new System.Drawing.Size(246, 21);
            this.comboBoxEmpleado.Sorted = true;
            this.comboBoxEmpleado.TabIndex = 62;
            this.comboBoxEmpleado.Visible = false;
            // 
            // textBoxCodigoProveedor
            // 
            this.textBoxCodigoProveedor.Enabled = false;
            this.textBoxCodigoProveedor.Location = new System.Drawing.Point(262, 186);
            this.textBoxCodigoProveedor.Name = "textBoxCodigoProveedor";
            this.textBoxCodigoProveedor.Size = new System.Drawing.Size(121, 20);
            this.textBoxCodigoProveedor.TabIndex = 66;
            this.textBoxCodigoProveedor.TextChanged += new System.EventHandler(this.textBoxCodigoProveedor_TextChanged);
            // 
            // textBoxTotalUnidades
            // 
            this.textBoxTotalUnidades.Enabled = false;
            this.textBoxTotalUnidades.Location = new System.Drawing.Point(660, 138);
            this.textBoxTotalUnidades.Name = "textBoxTotalUnidades";
            this.textBoxTotalUnidades.Size = new System.Drawing.Size(124, 20);
            this.textBoxTotalUnidades.TabIndex = 72;
            // 
            // textBoxUnidadesEntradas
            // 
            this.textBoxUnidadesEntradas.Enabled = false;
            this.textBoxUnidadesEntradas.Location = new System.Drawing.Point(660, 165);
            this.textBoxUnidadesEntradas.Name = "textBoxUnidadesEntradas";
            this.textBoxUnidadesEntradas.Size = new System.Drawing.Size(124, 20);
            this.textBoxUnidadesEntradas.TabIndex = 77;
            // 
            // textCodigoMaterial
            // 
            this.textCodigoMaterial.Enabled = false;
            this.textCodigoMaterial.Location = new System.Drawing.Point(660, 191);
            this.textCodigoMaterial.Name = "textCodigoMaterial";
            this.textCodigoMaterial.Size = new System.Drawing.Size(124, 20);
            this.textCodigoMaterial.TabIndex = 79;
            this.textCodigoMaterial.TextChanged += new System.EventHandler(this.textCodigoMaterial_TextChanged);
            // 
            // textBoxPrecioMaterial
            // 
            this.textBoxPrecioMaterial.Enabled = false;
            this.textBoxPrecioMaterial.Location = new System.Drawing.Point(660, 241);
            this.textBoxPrecioMaterial.Name = "textBoxPrecioMaterial";
            this.textBoxPrecioMaterial.Size = new System.Drawing.Size(124, 20);
            this.textBoxPrecioMaterial.TabIndex = 81;
            // 
            // textBoxUnidadesEntrada
            // 
            this.textBoxUnidadesEntrada.Enabled = false;
            this.textBoxUnidadesEntrada.Location = new System.Drawing.Point(660, 269);
            this.textBoxUnidadesEntrada.Name = "textBoxUnidadesEntrada";
            this.textBoxUnidadesEntrada.Size = new System.Drawing.Size(124, 20);
            this.textBoxUnidadesEntrada.TabIndex = 83;
            // 
            // dataGridViewPartidasEntradaMaterialesEntrada
            // 
            this.dataGridViewPartidasEntradaMaterialesEntrada.AllowUserToDeleteRows = false;
            this.dataGridViewPartidasEntradaMaterialesEntrada.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewPartidasEntradaMaterialesEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPartidasEntradaMaterialesEntrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Codigo_materiales,
            this.Codigo_proveedor,
            this.Descripcion_partida,
            this.Unidades_ordenadas,
            this.Cantidad_recibidas,
            this.dataGridViewTextBoxColumn9,
            this.Tipo_cambio});
            this.dataGridViewPartidasEntradaMaterialesEntrada.Enabled = false;
            this.dataGridViewPartidasEntradaMaterialesEntrada.Location = new System.Drawing.Point(12, 384);
            this.dataGridViewPartidasEntradaMaterialesEntrada.Name = "dataGridViewPartidasEntradaMaterialesEntrada";
            this.dataGridViewPartidasEntradaMaterialesEntrada.Size = new System.Drawing.Size(1044, 202);
            this.dataGridViewPartidasEntradaMaterialesEntrada.TabIndex = 85;
            this.dataGridViewPartidasEntradaMaterialesEntrada.Visible = false;
            this.dataGridViewPartidasEntradaMaterialesEntrada.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPartidasEntradaMaterialesEntrada_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // Codigo_materiales
            // 
            this.Codigo_materiales.HeaderText = "Codigo Material";
            this.Codigo_materiales.Name = "Codigo_materiales";
            this.Codigo_materiales.ReadOnly = true;
            // 
            // Codigo_proveedor
            // 
            this.Codigo_proveedor.HeaderText = "Codigo Parte Proveedor";
            this.Codigo_proveedor.Name = "Codigo_proveedor";
            this.Codigo_proveedor.ReadOnly = true;
            this.Codigo_proveedor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Descripcion_partida
            // 
            this.Descripcion_partida.HeaderText = "Descripcion";
            this.Descripcion_partida.Name = "Descripcion_partida";
            this.Descripcion_partida.ReadOnly = true;
            this.Descripcion_partida.Width = 400;
            // 
            // Unidades_ordenadas
            // 
            this.Unidades_ordenadas.HeaderText = "Unidades";
            this.Unidades_ordenadas.Name = "Unidades_ordenadas";
            this.Unidades_ordenadas.ReadOnly = true;
            // 
            // Cantidad_recibidas
            // 
            this.Cantidad_recibidas.HeaderText = "Recibidas";
            this.Cantidad_recibidas.Name = "Cantidad_recibidas";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // Tipo_cambio
            // 
            this.Tipo_cambio.HeaderText = "Tipo Cambio";
            this.Tipo_cambio.Name = "Tipo_cambio";
            this.Tipo_cambio.ReadOnly = true;
            // 
            // textBoxDivisa
            // 
            this.textBoxDivisa.Enabled = false;
            this.textBoxDivisa.Location = new System.Drawing.Point(660, 215);
            this.textBoxDivisa.Name = "textBoxDivisa";
            this.textBoxDivisa.Size = new System.Drawing.Size(124, 20);
            this.textBoxDivisa.TabIndex = 88;
            // 
            // textBoxEstadoOC
            // 
            this.textBoxEstadoOC.Enabled = false;
            this.textBoxEstadoOC.Location = new System.Drawing.Point(262, 296);
            this.textBoxEstadoOC.Name = "textBoxEstadoOC";
            this.textBoxEstadoOC.Size = new System.Drawing.Size(124, 20);
            this.textBoxEstadoOC.TabIndex = 90;
            this.textBoxEstadoOC.Visible = false;
            // 
            // buttonMateriales
            // 
            this.buttonMateriales.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMateriales.Image = ((System.Drawing.Image)(resources.GetObject("buttonMateriales.Image")));
            this.buttonMateriales.Location = new System.Drawing.Point(331, 24);
            this.buttonMateriales.Name = "buttonMateriales";
            this.buttonMateriales.Size = new System.Drawing.Size(79, 74);
            this.buttonMateriales.TabIndex = 91;
            this.buttonMateriales.Text = "Materiales Agregar";
            this.buttonMateriales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonMateriales.UseVisualStyleBackColor = true;
            this.buttonMateriales.Click += new System.EventHandler(this.buttonMateriales_Click);
            // 
            // labelEstadoOC
            // 
            this.labelEstadoOC.AutoSize = true;
            this.labelEstadoOC.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoOC.Image = ((System.Drawing.Image)(resources.GetObject("labelEstadoOC.Image")));
            this.labelEstadoOC.Location = new System.Drawing.Point(106, 298);
            this.labelEstadoOC.Name = "labelEstadoOC";
            this.labelEstadoOC.Size = new System.Drawing.Size(125, 16);
            this.labelEstadoOC.TabIndex = 89;
            this.labelEstadoOC.Text = "Estado Orden Compra";
            this.labelEstadoOC.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(539, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 87;
            this.label7.Text = "Tipo de Cambio";
            // 
            // groupBoxReferencia
            // 
            this.groupBoxReferencia.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxReferencia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxReferencia.BackgroundImage")));
            this.groupBoxReferencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxReferencia.Controls.Add(this.textBoxReferencia);
            this.groupBoxReferencia.Controls.Add(this.radioButtonRemision);
            this.groupBoxReferencia.Controls.Add(this.radioButtonFactura);
            this.groupBoxReferencia.Enabled = false;
            this.groupBoxReferencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxReferencia.Location = new System.Drawing.Point(838, 136);
            this.groupBoxReferencia.Name = "groupBoxReferencia";
            this.groupBoxReferencia.Size = new System.Drawing.Size(288, 65);
            this.groupBoxReferencia.TabIndex = 86;
            this.groupBoxReferencia.TabStop = false;
            this.groupBoxReferencia.Text = "Referencia";
            // 
            // textBoxReferencia
            // 
            this.textBoxReferencia.Enabled = false;
            this.textBoxReferencia.Location = new System.Drawing.Point(96, 28);
            this.textBoxReferencia.Name = "textBoxReferencia";
            this.textBoxReferencia.Size = new System.Drawing.Size(178, 20);
            this.textBoxReferencia.TabIndex = 87;
            // 
            // radioButtonRemision
            // 
            this.radioButtonRemision.AutoSize = true;
            this.radioButtonRemision.BackColor = System.Drawing.SystemColors.Highlight;
            this.radioButtonRemision.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButtonRemision.BackgroundImage")));
            this.radioButtonRemision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonRemision.ForeColor = System.Drawing.Color.White;
            this.radioButtonRemision.Location = new System.Drawing.Point(7, 42);
            this.radioButtonRemision.Name = "radioButtonRemision";
            this.radioButtonRemision.Size = new System.Drawing.Size(68, 17);
            this.radioButtonRemision.TabIndex = 66;
            this.radioButtonRemision.Text = "Remision";
            this.radioButtonRemision.UseVisualStyleBackColor = false;
            // 
            // radioButtonFactura
            // 
            this.radioButtonFactura.AutoSize = true;
            this.radioButtonFactura.BackColor = System.Drawing.Color.White;
            this.radioButtonFactura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButtonFactura.BackgroundImage")));
            this.radioButtonFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonFactura.Checked = true;
            this.radioButtonFactura.ForeColor = System.Drawing.Color.White;
            this.radioButtonFactura.Location = new System.Drawing.Point(7, 19);
            this.radioButtonFactura.Name = "radioButtonFactura";
            this.radioButtonFactura.Size = new System.Drawing.Size(61, 17);
            this.radioButtonFactura.TabIndex = 65;
            this.radioButtonFactura.TabStop = true;
            this.radioButtonFactura.Text = "Factura";
            this.radioButtonFactura.UseVisualStyleBackColor = false;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(539, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 82;
            this.label3.Text = "Unidades Entrada";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(539, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 16);
            this.label10.TabIndex = 80;
            this.label10.Text = "Precio Material";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(539, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 78;
            this.label9.Text = "Codigo Material";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(539, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 76;
            this.label5.Text = "Unidades Entradas";
            // 
            // labeldivisa
            // 
            this.labeldivisa.AutoSize = true;
            this.labeldivisa.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldivisa.Image = ((System.Drawing.Image)(resources.GetObject("labeldivisa.Image")));
            this.labeldivisa.Location = new System.Drawing.Point(539, 141);
            this.labeldivisa.Name = "labeldivisa";
            this.labeldivisa.Size = new System.Drawing.Size(109, 16);
            this.labeldivisa.TabIndex = 71;
            this.labeldivisa.Text = "Total Unidades OC";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(106, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 16);
            this.label12.TabIndex = 45;
            this.label12.Text = "Codigo Proveedor Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(106, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "Fecha Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(106, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Material Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(106, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nombre Empleado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(106, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Codigo Orden Compra";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AutoSize = true;
            this.buttonCancelar.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.Location = new System.Drawing.Point(1268, 432);
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
            this.buttonBorrarBasedeDatos.Location = new System.Drawing.Point(1268, 332);
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
            this.buttonHome.Location = new System.Drawing.Point(1268, 512);
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
            this.buttonGuardarBasedeDatos.Location = new System.Drawing.Point(1268, 352);
            this.buttonGuardarBasedeDatos.Name = "buttonGuardarBasedeDatos";
            this.buttonGuardarBasedeDatos.Size = new System.Drawing.Size(79, 74);
            this.buttonGuardarBasedeDatos.TabIndex = 32;
            this.buttonGuardarBasedeDatos.Text = "Guardar";
            this.buttonGuardarBasedeDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonGuardarBasedeDatos.UseVisualStyleBackColor = true;
            this.buttonGuardarBasedeDatos.Visible = false;
            this.buttonGuardarBasedeDatos.Click += new System.EventHandler(this.buttonGuardarBasedeDatos_Click);
            // 
            // buttonBuscarOrdenCompra
            // 
            this.buttonBuscarOrdenCompra.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarOrdenCompra.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarOrdenCompra.Image")));
            this.buttonBuscarOrdenCompra.Location = new System.Drawing.Point(416, 24);
            this.buttonBuscarOrdenCompra.Name = "buttonBuscarOrdenCompra";
            this.buttonBuscarOrdenCompra.Size = new System.Drawing.Size(79, 74);
            this.buttonBuscarOrdenCompra.TabIndex = 31;
            this.buttonBuscarOrdenCompra.Text = "Visualizar";
            this.buttonBuscarOrdenCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBuscarOrdenCompra.UseVisualStyleBackColor = true;
            this.buttonBuscarOrdenCompra.Click += new System.EventHandler(this.buttonBuscarOrdenCompra_Click);
            // 
            // buttonAgregarCotizacion
            // 
            this.buttonAgregarCotizacion.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarCotizacion.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregarCotizacion.Image")));
            this.buttonAgregarCotizacion.Location = new System.Drawing.Point(501, 24);
            this.buttonAgregarCotizacion.Name = "buttonAgregarCotizacion";
            this.buttonAgregarCotizacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAgregarCotizacion.Size = new System.Drawing.Size(79, 74);
            this.buttonAgregarCotizacion.TabIndex = 29;
            this.buttonAgregarCotizacion.Text = "Entrada";
            this.buttonAgregarCotizacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAgregarCotizacion.UseVisualStyleBackColor = true;
            this.buttonAgregarCotizacion.Click += new System.EventHandler(this.buttonAgregarCotizacion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1354, 601);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxCodigoEmpleado
            // 
            this.comboBoxCodigoEmpleado.FormattingEnabled = true;
            this.comboBoxCodigoEmpleado.Location = new System.Drawing.Point(262, 239);
            this.comboBoxCodigoEmpleado.Name = "comboBoxCodigoEmpleado";
            this.comboBoxCodigoEmpleado.Size = new System.Drawing.Size(246, 21);
            this.comboBoxCodigoEmpleado.Sorted = true;
            this.comboBoxCodigoEmpleado.TabIndex = 93;
            this.comboBoxCodigoEmpleado.Visible = false;
            this.comboBoxCodigoEmpleado.SelectedIndexChanged += new System.EventHandler(this.comboBoxCodigoEmpleado_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(106, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 92;
            this.label8.Text = "Clave Empleado";
            // 
            // Forma_Entrada_Materiales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 601);
            this.Controls.Add(this.comboBoxCodigoEmpleado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonMateriales);
            this.Controls.Add(this.textBoxEstadoOC);
            this.Controls.Add(this.labelEstadoOC);
            this.Controls.Add(this.textBoxDivisa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBoxReferencia);
            this.Controls.Add(this.dataGridViewPartidasEntradaMaterialesEntrada);
            this.Controls.Add(this.buttonBusquedaBaseDatos);
            this.Controls.Add(this.textBoxUnidadesEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrecioMaterial);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textCodigoMaterial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxUnidadesEntradas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTotalUnidades);
            this.Controls.Add(this.labeldivisa);
            this.Controls.Add(this.textBoxCodigoProveedor);
            this.Controls.Add(this.comboBoxEmpleado);
            this.Controls.Add(this.comboBoxDescripcionMaterial);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePickerFechaActual);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxCodigoOrdenCompra);
            this.Controls.Add(this.dataGridViewPartidasEntradaMaterialesVisualizar);
            this.Controls.Add(this.textBoxDescripcionMaterial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCodigoOrdenCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonBorrarBasedeDatos);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonGuardarBasedeDatos);
            this.Controls.Add(this.buttonBuscarOrdenCompra);
            this.Controls.Add(this.buttonAgregarCotizacion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Forma_Entrada_Materiales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada Materiales";
            this.Load += new System.EventHandler(this.Forma_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartidasEntradaMaterialesVisualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartidasEntradaMaterialesEntrada)).EndInit();
            this.groupBoxReferencia.ResumeLayout(false);
            this.groupBoxReferencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBuscarOrdenCompra;
        private System.Windows.Forms.Button buttonAgregarCotizacion;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonBorrarBasedeDatos;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonGuardarBasedeDatos;
        private System.Windows.Forms.Timer timerAgregarEntradaMateriales;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxDescripcionMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodigoOrdenCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewPartidasEntradaMaterialesVisualizar;
        private System.Windows.Forms.ComboBox comboBoxCodigoOrdenCompra;
        private System.Windows.Forms.Timer timerBusquedaMaterial;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaActual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxDescripcionMaterial;
        private System.Windows.Forms.ComboBox comboBoxEmpleado;
        private System.Windows.Forms.TextBox textBoxCodigoProveedor;
        private System.Windows.Forms.Label labeldivisa;
        private System.Windows.Forms.TextBox textBoxTotalUnidades;
        private System.Windows.Forms.TextBox textBoxUnidadesEntradas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCodigoMaterial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPrecioMaterial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxUnidadesEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBusquedaBaseDatos;
        private System.Windows.Forms.DataGridView dataGridViewPartidasEntradaMaterialesEntrada;
        private System.Windows.Forms.GroupBox groupBoxReferencia;
        private System.Windows.Forms.TextBox textBoxReferencia;
        private System.Windows.Forms.RadioButton radioButtonRemision;
        private System.Windows.Forms.RadioButton radioButtonFactura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDivisa;
        private System.Windows.Forms.TextBox textBoxEstadoOC;
        private System.Windows.Forms.Label labelEstadoOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orden_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parte_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_cambio_visualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_materiales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades_ordenadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_recibidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_cambio;
        private System.Windows.Forms.Button buttonMateriales;
        private System.Windows.Forms.ComboBox comboBoxCodigoEmpleado;
        private System.Windows.Forms.Label label8;
    }
}