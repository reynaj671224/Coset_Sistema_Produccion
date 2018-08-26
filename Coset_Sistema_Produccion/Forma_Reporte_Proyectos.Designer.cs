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
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.textBoxCodigoProyecto = new System.Windows.Forms.TextBox();
            this.labelCodigoProyecto = new System.Windows.Forms.Label();
            this.dataGridViewProyectoReportes = new System.Windows.Forms.DataGridView();
            this.Codigo_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_dibujo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_dibujos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProyectoOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdenCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperacionProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.textBoxTotalPrecioProyectoSalidas = new System.Windows.Forms.TextBox();
            this.labelTotalSalidas = new System.Windows.Forms.Label();
            this.textBoxTotalPrecioProyectoDevoluciones = new System.Windows.Forms.TextBox();
            this.labelTotalDevoluciones = new System.Windows.Forms.Label();
            this.textBoxTotalPrecioProyecto = new System.Windows.Forms.TextBox();
            this.labelTotalProyectoPrecio = new System.Windows.Forms.Label();
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
            this.timerBusquedaMaterial = new System.Windows.Forms.Timer(this.components);
            this.buttonExcel = new System.Windows.Forms.Button();
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
            this.textBoxNombreCliente.Location = new System.Drawing.Point(220, 174);
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
            this.labelNombreCliente.Location = new System.Drawing.Point(99, 174);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.Size = new System.Drawing.Size(92, 16);
            this.labelNombreCliente.TabIndex = 39;
            this.labelNombreCliente.Text = "Nombre Cliente";
            this.labelNombreCliente.Visible = false;
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
            // dataGridViewProyectoReportes
            // 
            this.dataGridViewProyectoReportes.AllowUserToDeleteRows = false;
            this.dataGridViewProyectoReportes.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewProyectoReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProyectoReportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_material,
            this.Codigo_proveedor,
            this.Descripcion_dibujo,
            this.NombreProveedor,
            this.Cantidad_dibujos,
            this.Empleado,
            this.Fecha,
            this.Precio_Unitario,
            this.Total_Precio,
            this.Proyecto,
            this.ProyectoOC,
            this.CantidadOC,
            this.OrdenCompra,
            this.OperacionProyecto,
            this.Observaciones});
            this.dataGridViewProyectoReportes.Enabled = false;
            this.dataGridViewProyectoReportes.Location = new System.Drawing.Point(23, 275);
            this.dataGridViewProyectoReportes.Name = "dataGridViewProyectoReportes";
            this.dataGridViewProyectoReportes.ReadOnly = true;
            this.dataGridViewProyectoReportes.Size = new System.Drawing.Size(1148, 234);
            this.dataGridViewProyectoReportes.TabIndex = 48;
            this.dataGridViewProyectoReportes.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewDibujosProyecto_RowsAdded);
            // 
            // Codigo_material
            // 
            this.Codigo_material.HeaderText = "Codigo Material";
            this.Codigo_material.Name = "Codigo_material";
            this.Codigo_material.ReadOnly = true;
            // 
            // Codigo_proveedor
            // 
            this.Codigo_proveedor.HeaderText = "Codigo Proveedor";
            this.Codigo_proveedor.Name = "Codigo_proveedor";
            this.Codigo_proveedor.ReadOnly = true;
            // 
            // Descripcion_dibujo
            // 
            this.Descripcion_dibujo.HeaderText = "Descripcion";
            this.Descripcion_dibujo.Name = "Descripcion_dibujo";
            this.Descripcion_dibujo.ReadOnly = true;
            this.Descripcion_dibujo.Width = 350;
            // 
            // NombreProveedor
            // 
            this.NombreProveedor.HeaderText = "Nombre Proveedor";
            this.NombreProveedor.Name = "NombreProveedor";
            this.NombreProveedor.ReadOnly = true;
            this.NombreProveedor.Width = 200;
            // 
            // Cantidad_dibujos
            // 
            this.Cantidad_dibujos.HeaderText = "Cantidad";
            this.Cantidad_dibujos.Name = "Cantidad_dibujos";
            this.Cantidad_dibujos.ReadOnly = true;
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            this.Empleado.Width = 250;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Precio_Unitario
            // 
            this.Precio_Unitario.HeaderText = "Precio Unitario";
            this.Precio_Unitario.Name = "Precio_Unitario";
            this.Precio_Unitario.ReadOnly = true;
            // 
            // Total_Precio
            // 
            this.Total_Precio.HeaderText = "Total Precio";
            this.Total_Precio.Name = "Total_Precio";
            this.Total_Precio.ReadOnly = true;
            // 
            // Proyecto
            // 
            this.Proyecto.HeaderText = "Proyecto";
            this.Proyecto.Name = "Proyecto";
            this.Proyecto.ReadOnly = true;
            // 
            // ProyectoOC
            // 
            this.ProyectoOC.HeaderText = "Proyecto OC";
            this.ProyectoOC.Name = "ProyectoOC";
            this.ProyectoOC.ReadOnly = true;
            // 
            // CantidadOC
            // 
            this.CantidadOC.HeaderText = "Total Unidades OC";
            this.CantidadOC.Name = "CantidadOC";
            this.CantidadOC.ReadOnly = true;
            // 
            // OrdenCompra
            // 
            this.OrdenCompra.HeaderText = "Orden Compra";
            this.OrdenCompra.Name = "OrdenCompra";
            this.OrdenCompra.ReadOnly = true;
            // 
            // OperacionProyecto
            // 
            this.OperacionProyecto.HeaderText = "Operacion";
            this.OperacionProyecto.Name = "OperacionProyecto";
            this.OperacionProyecto.ReadOnly = true;
            this.OperacionProyecto.Width = 150;
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.Width = 300;
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
            // labelNombreProyecto
            // 
            this.labelNombreProyecto.AutoSize = true;
            this.labelNombreProyecto.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreProyecto.Image = ((System.Drawing.Image)(resources.GetObject("labelNombreProyecto.Image")));
            this.labelNombreProyecto.Location = new System.Drawing.Point(99, 120);
            this.labelNombreProyecto.Name = "labelNombreProyecto";
            this.labelNombreProyecto.Size = new System.Drawing.Size(98, 16);
            this.labelNombreProyecto.TabIndex = 68;
            this.labelNombreProyecto.Text = "Nombre Proyecto";
            this.labelNombreProyecto.Visible = false;
            // 
            // textBoxNombreProyecto
            // 
            this.textBoxNombreProyecto.Enabled = false;
            this.textBoxNombreProyecto.Location = new System.Drawing.Point(220, 117);
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
            this.labelCodigoCliente.Location = new System.Drawing.Point(99, 145);
            this.labelCodigoCliente.Name = "labelCodigoCliente";
            this.labelCodigoCliente.Size = new System.Drawing.Size(87, 16);
            this.labelCodigoCliente.TabIndex = 72;
            this.labelCodigoCliente.Text = "Codigo Cliente";
            this.labelCodigoCliente.Visible = false;
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
            // textBoxIngenieroCliente
            // 
            this.textBoxIngenieroCliente.Enabled = false;
            this.textBoxIngenieroCliente.Location = new System.Drawing.Point(220, 230);
            this.textBoxIngenieroCliente.Name = "textBoxIngenieroCliente";
            this.textBoxIngenieroCliente.Size = new System.Drawing.Size(268, 20);
            this.textBoxIngenieroCliente.TabIndex = 76;
            this.textBoxIngenieroCliente.Visible = false;
            // 
            // textBoxTotalPrecioProyectoSalidas
            // 
            this.textBoxTotalPrecioProyectoSalidas.Enabled = false;
            this.textBoxTotalPrecioProyectoSalidas.Location = new System.Drawing.Point(771, 99);
            this.textBoxTotalPrecioProyectoSalidas.Name = "textBoxTotalPrecioProyectoSalidas";
            this.textBoxTotalPrecioProyectoSalidas.Size = new System.Drawing.Size(124, 20);
            this.textBoxTotalPrecioProyectoSalidas.TabIndex = 78;
            this.textBoxTotalPrecioProyectoSalidas.Visible = false;
            // 
            // labelTotalSalidas
            // 
            this.labelTotalSalidas.AutoSize = true;
            this.labelTotalSalidas.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalSalidas.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalSalidas.Image")));
            this.labelTotalSalidas.Location = new System.Drawing.Point(573, 99);
            this.labelTotalSalidas.Name = "labelTotalSalidas";
            this.labelTotalSalidas.Size = new System.Drawing.Size(161, 16);
            this.labelTotalSalidas.TabIndex = 77;
            this.labelTotalSalidas.Text = "Total Precio Salidas Proyecto";
            this.labelTotalSalidas.Visible = false;
            // 
            // textBoxTotalPrecioProyectoDevoluciones
            // 
            this.textBoxTotalPrecioProyectoDevoluciones.Enabled = false;
            this.textBoxTotalPrecioProyectoDevoluciones.Location = new System.Drawing.Point(771, 125);
            this.textBoxTotalPrecioProyectoDevoluciones.Name = "textBoxTotalPrecioProyectoDevoluciones";
            this.textBoxTotalPrecioProyectoDevoluciones.Size = new System.Drawing.Size(124, 20);
            this.textBoxTotalPrecioProyectoDevoluciones.TabIndex = 80;
            this.textBoxTotalPrecioProyectoDevoluciones.Visible = false;
            // 
            // labelTotalDevoluciones
            // 
            this.labelTotalDevoluciones.AutoSize = true;
            this.labelTotalDevoluciones.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDevoluciones.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalDevoluciones.Image")));
            this.labelTotalDevoluciones.Location = new System.Drawing.Point(573, 125);
            this.labelTotalDevoluciones.Name = "labelTotalDevoluciones";
            this.labelTotalDevoluciones.Size = new System.Drawing.Size(192, 16);
            this.labelTotalDevoluciones.TabIndex = 79;
            this.labelTotalDevoluciones.Text = "Total Precio Devoluciones Proyecto";
            this.labelTotalDevoluciones.Visible = false;
            // 
            // textBoxTotalPrecioProyecto
            // 
            this.textBoxTotalPrecioProyecto.Enabled = false;
            this.textBoxTotalPrecioProyecto.Location = new System.Drawing.Point(771, 151);
            this.textBoxTotalPrecioProyecto.Name = "textBoxTotalPrecioProyecto";
            this.textBoxTotalPrecioProyecto.Size = new System.Drawing.Size(124, 20);
            this.textBoxTotalPrecioProyecto.TabIndex = 82;
            this.textBoxTotalPrecioProyecto.Visible = false;
            // 
            // labelTotalProyectoPrecio
            // 
            this.labelTotalProyectoPrecio.AutoSize = true;
            this.labelTotalProyectoPrecio.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalProyectoPrecio.Image = ((System.Drawing.Image)(resources.GetObject("labelTotalProyectoPrecio.Image")));
            this.labelTotalProyectoPrecio.Location = new System.Drawing.Point(573, 149);
            this.labelTotalProyectoPrecio.Name = "labelTotalProyectoPrecio";
            this.labelTotalProyectoPrecio.Size = new System.Drawing.Size(71, 16);
            this.labelTotalProyectoPrecio.TabIndex = 81;
            this.labelTotalProyectoPrecio.Text = "Total Precio";
            this.labelTotalProyectoPrecio.Visible = false;
            // 
            // buttonReporteProyectos
            // 
            this.buttonReporteProyectos.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReporteProyectos.Image = ((System.Drawing.Image)(resources.GetObject("buttonReporteProyectos.Image")));
            this.buttonReporteProyectos.Location = new System.Drawing.Point(468, 12);
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
            this.buttonReoprteMateriales.Click += new System.EventHandler(this.buttonReoprteMateriales_Click);
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
            // comboBoxNombreEmpleado
            // 
            this.comboBoxNombreEmpleado.FormattingEnabled = true;
            this.comboBoxNombreEmpleado.Location = new System.Drawing.Point(211, 77);
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
            this.labelNombreEmpleado.Location = new System.Drawing.Point(99, 95);
            this.labelNombreEmpleado.Name = "labelNombreEmpleado";
            this.labelNombreEmpleado.Size = new System.Drawing.Size(106, 16);
            this.labelNombreEmpleado.TabIndex = 87;
            this.labelNombreEmpleado.Text = "Nombre Empleado";
            this.labelNombreEmpleado.Visible = false;
            // 
            // textCodigoMaterial
            // 
            this.textCodigoMaterial.Location = new System.Drawing.Point(771, 177);
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
            this.labelCodigoMaterial.Location = new System.Drawing.Point(574, 177);
            this.labelCodigoMaterial.Name = "labelCodigoMaterial";
            this.labelCodigoMaterial.Size = new System.Drawing.Size(94, 16);
            this.labelCodigoMaterial.TabIndex = 89;
            this.labelCodigoMaterial.Text = "Codigo Material";
            this.labelCodigoMaterial.Visible = false;
            // 
            // textBoxCodigoProveedor
            // 
            this.textBoxCodigoProveedor.Location = new System.Drawing.Point(771, 203);
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
            this.labelCodigoMaterialProveedor.Location = new System.Drawing.Point(573, 201);
            this.labelCodigoMaterialProveedor.Name = "labelCodigoMaterialProveedor";
            this.labelCodigoMaterialProveedor.Size = new System.Drawing.Size(150, 16);
            this.labelCodigoMaterialProveedor.TabIndex = 91;
            this.labelCodigoMaterialProveedor.Text = "Codigo Proveedor Material";
            this.labelCodigoMaterialProveedor.Visible = false;
            // 
            // textBoxDescripcionMaterial
            // 
            this.textBoxDescripcionMaterial.Location = new System.Drawing.Point(771, 230);
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
            this.labelMaterialDescripcion.Location = new System.Drawing.Point(574, 228);
            this.labelMaterialDescripcion.Name = "labelMaterialDescripcion";
            this.labelMaterialDescripcion.Size = new System.Drawing.Size(120, 16);
            this.labelMaterialDescripcion.TabIndex = 93;
            this.labelMaterialDescripcion.Text = "Material Descripcion";
            this.labelMaterialDescripcion.Visible = false;
            // 
            // timerBusquedaMaterial
            // 
            this.timerBusquedaMaterial.Interval = 1000;
            this.timerBusquedaMaterial.Tick += new System.EventHandler(this.timerBusquedaMaterial_Tick);
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
            // Forma_Reporte_Proyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 521);
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
            this.Controls.Add(this.textBoxTotalPrecioProyecto);
            this.Controls.Add(this.labelTotalProyectoPrecio);
            this.Controls.Add(this.textBoxTotalPrecioProyectoDevoluciones);
            this.Controls.Add(this.labelTotalDevoluciones);
            this.Controls.Add(this.textBoxTotalPrecioProyectoSalidas);
            this.Controls.Add(this.labelTotalSalidas);
            this.Controls.Add(this.textBoxIngenieroCliente);
            this.Controls.Add(this.labelIngenieroCliente);
            this.Controls.Add(this.textBoxCodigoCliente);
            this.Controls.Add(this.labelCodigoCliente);
            this.Controls.Add(this.textBoxNombreProyecto);
            this.Controls.Add(this.labelNombreProyecto);
            this.Controls.Add(this.textBoxIngenieroCoset);
            this.Controls.Add(this.labelIngenieroCoset);
            this.Controls.Add(this.comboBoxCodigoProyecto);
            this.Controls.Add(this.dataGridViewProyectoReportes);
            this.Controls.Add(this.textBoxNombreCliente);
            this.Controls.Add(this.labelNombreCliente);
            this.Controls.Add(this.textBoxCodigoProyecto);
            this.Controls.Add(this.labelCodigoProyecto);
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
        private System.Windows.Forms.Label labelNombreCliente;
        private System.Windows.Forms.TextBox textBoxCodigoProyecto;
        private System.Windows.Forms.Label labelCodigoProyecto;
        private System.Windows.Forms.DataGridView dataGridViewProyectoReportes;
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
        private System.Windows.Forms.TextBox textBoxTotalPrecioProyectoSalidas;
        private System.Windows.Forms.Label labelTotalSalidas;
        private System.Windows.Forms.TextBox textBoxTotalPrecioProyectoDevoluciones;
        private System.Windows.Forms.Label labelTotalDevoluciones;
        private System.Windows.Forms.TextBox textBoxTotalPrecioProyecto;
        private System.Windows.Forms.Label labelTotalProyectoPrecio;
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
        private System.Windows.Forms.Timer timerBusquedaMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_dibujo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_dibujos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProyectoOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdenCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperacionProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.Button buttonExcel;
    }
}