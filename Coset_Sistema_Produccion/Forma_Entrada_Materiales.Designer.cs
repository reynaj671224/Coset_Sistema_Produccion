namespace Coset_Sistema_Produccion
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonBuscarOrdenCompra = new System.Windows.Forms.Button();
            this.buttonAgregarCotizacion = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonBorrarBasedeDatos = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonGuardarBasedeDatos = new System.Windows.Forms.Button();
            this.timerAgregarOrdenCompra = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxDescripcionMaterial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigoOrdenCompra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewPartidasOrdenCompra = new System.Windows.Forms.DataGridView();
            this.Codigo_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orden_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parte_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxCodigoOrdenCompra = new System.Windows.Forms.ComboBox();
            this.timerModificarClientes = new System.Windows.Forms.Timer(this.components);
            this.dateTimePickerFechaActual = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxDescripcionMaterial = new System.Windows.Forms.ComboBox();
            this.comboBoxEmpleado = new System.Windows.Forms.ComboBox();
            this.textBoxCodigoProveedor = new System.Windows.Forms.TextBox();
            this.labeldivisa = new System.Windows.Forms.Label();
            this.textBoxTotalUnidades = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textCodigoMaterial = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPrecioMaterial = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartidasOrdenCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1139, 582);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.buttonAgregarCotizacion.Text = "Agregar";
            this.buttonAgregarCotizacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAgregarCotizacion.UseVisualStyleBackColor = true;
            this.buttonAgregarCotizacion.Click += new System.EventHandler(this.buttonAgregarCotizacion_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AutoSize = true;
            this.buttonCancelar.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.Location = new System.Drawing.Point(1044, 395);
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
            this.buttonBorrarBasedeDatos.Location = new System.Drawing.Point(1044, 300);
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
            this.buttonHome.Location = new System.Drawing.Point(1044, 475);
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
            this.buttonGuardarBasedeDatos.Location = new System.Drawing.Point(1044, 315);
            this.buttonGuardarBasedeDatos.Name = "buttonGuardarBasedeDatos";
            this.buttonGuardarBasedeDatos.Size = new System.Drawing.Size(79, 74);
            this.buttonGuardarBasedeDatos.TabIndex = 32;
            this.buttonGuardarBasedeDatos.Text = "Guardar";
            this.buttonGuardarBasedeDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonGuardarBasedeDatos.UseVisualStyleBackColor = true;
            this.buttonGuardarBasedeDatos.Visible = false;
            this.buttonGuardarBasedeDatos.Click += new System.EventHandler(this.buttonGuardarBasedeDatos_Click);
            // 
            // timerAgregarOrdenCompra
            // 
            this.timerAgregarOrdenCompra.Interval = 1000;
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
            // textBoxDescripcionMaterial
            // 
            this.textBoxDescripcionMaterial.Enabled = false;
            this.textBoxDescripcionMaterial.Location = new System.Drawing.Point(262, 162);
            this.textBoxDescripcionMaterial.Name = "textBoxDescripcionMaterial";
            this.textBoxDescripcionMaterial.Size = new System.Drawing.Size(246, 20);
            this.textBoxDescripcionMaterial.TabIndex = 42;
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
            // textBoxEmpleado
            // 
            this.textBoxEmpleado.Enabled = false;
            this.textBoxEmpleado.Location = new System.Drawing.Point(262, 214);
            this.textBoxEmpleado.Name = "textBoxEmpleado";
            this.textBoxEmpleado.Size = new System.Drawing.Size(246, 20);
            this.textBoxEmpleado.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(106, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Empleado";
            // 
            // textBoxCodigoOrdenCompra
            // 
            this.textBoxCodigoOrdenCompra.Enabled = false;
            this.textBoxCodigoOrdenCompra.Location = new System.Drawing.Point(262, 136);
            this.textBoxCodigoOrdenCompra.Name = "textBoxCodigoOrdenCompra";
            this.textBoxCodigoOrdenCompra.Size = new System.Drawing.Size(121, 20);
            this.textBoxCodigoOrdenCompra.TabIndex = 38;
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
            // dataGridViewPartidasOrdenCompra
            // 
            this.dataGridViewPartidasOrdenCompra.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewPartidasOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPartidasOrdenCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_partida,
            this.Orden_compra,
            this.Fecha,
            this.Codigo_material,
            this.Parte_proveedor,
            this.Nombre_empleado,
            this.Descripcion,
            this.Precio_partida});
            this.dataGridViewPartidasOrdenCompra.Enabled = false;
            this.dataGridViewPartidasOrdenCompra.Location = new System.Drawing.Point(23, 347);
            this.dataGridViewPartidasOrdenCompra.Name = "dataGridViewPartidasOrdenCompra";
            this.dataGridViewPartidasOrdenCompra.Size = new System.Drawing.Size(994, 202);
            this.dataGridViewPartidasOrdenCompra.TabIndex = 48;
            this.dataGridViewPartidasOrdenCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPartidasOrdenCompra_CellClick);
            this.dataGridViewPartidasOrdenCompra.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPartidasOrdenCompra_CellEndEdit);
            // 
            // Codigo_partida
            // 
            this.Codigo_partida.HeaderText = "Codigo";
            this.Codigo_partida.Name = "Codigo_partida";
            this.Codigo_partida.Width = 50;
            // 
            // Orden_compra
            // 
            this.Orden_compra.HeaderText = "Orden Compra";
            this.Orden_compra.Name = "Orden_compra";
            this.Orden_compra.Width = 50;
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
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 400;
            // 
            // Precio_partida
            // 
            this.Precio_partida.HeaderText = "Precio";
            this.Precio_partida.Name = "Precio_partida";
            this.Precio_partida.Width = 50;
            // 
            // comboBoxCodigoOrdenCompra
            // 
            this.comboBoxCodigoOrdenCompra.FormattingEnabled = true;
            this.comboBoxCodigoOrdenCompra.Location = new System.Drawing.Point(262, 136);
            this.comboBoxCodigoOrdenCompra.Name = "comboBoxCodigoOrdenCompra";
            this.comboBoxCodigoOrdenCompra.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCodigoOrdenCompra.TabIndex = 49;
            this.comboBoxCodigoOrdenCompra.Visible = false;
            this.comboBoxCodigoOrdenCompra.SelectedIndexChanged += new System.EventHandler(this.comboBoxCodigoOrdenCompra_SelectedIndexChanged);
            // 
            // timerModificarClientes
            // 
            this.timerModificarClientes.Interval = 1000;
            this.timerModificarClientes.Tick += new System.EventHandler(this.timerModificarClientes_Tick);
            // 
            // dateTimePickerFechaActual
            // 
            this.dateTimePickerFechaActual.Enabled = false;
            this.dateTimePickerFechaActual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaActual.Location = new System.Drawing.Point(263, 240);
            this.dateTimePickerFechaActual.Name = "dateTimePickerFechaActual";
            this.dateTimePickerFechaActual.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerFechaActual.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(106, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "Fecha Actual";
            // 
            // comboBoxDescripcionMaterial
            // 
            this.comboBoxDescripcionMaterial.FormattingEnabled = true;
            this.comboBoxDescripcionMaterial.Location = new System.Drawing.Point(262, 163);
            this.comboBoxDescripcionMaterial.Name = "comboBoxDescripcionMaterial";
            this.comboBoxDescripcionMaterial.Size = new System.Drawing.Size(246, 21);
            this.comboBoxDescripcionMaterial.TabIndex = 60;
            this.comboBoxDescripcionMaterial.Visible = false;
            this.comboBoxDescripcionMaterial.SelectedIndexChanged += new System.EventHandler(this.comboBoxNombreProveedor_SelectedIndexChanged);
            // 
            // comboBoxEmpleado
            // 
            this.comboBoxEmpleado.FormattingEnabled = true;
            this.comboBoxEmpleado.Location = new System.Drawing.Point(262, 213);
            this.comboBoxEmpleado.Name = "comboBoxEmpleado";
            this.comboBoxEmpleado.Size = new System.Drawing.Size(246, 21);
            this.comboBoxEmpleado.TabIndex = 62;
            this.comboBoxEmpleado.Visible = false;
            // 
            // textBoxCodigoProveedor
            // 
            this.textBoxCodigoProveedor.Enabled = false;
            this.textBoxCodigoProveedor.Location = new System.Drawing.Point(262, 188);
            this.textBoxCodigoProveedor.Name = "textBoxCodigoProveedor";
            this.textBoxCodigoProveedor.Size = new System.Drawing.Size(121, 20);
            this.textBoxCodigoProveedor.TabIndex = 66;
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
            // textBoxTotalUnidades
            // 
            this.textBoxTotalUnidades.Enabled = false;
            this.textBoxTotalUnidades.Location = new System.Drawing.Point(660, 138);
            this.textBoxTotalUnidades.Name = "textBoxTotalUnidades";
            this.textBoxTotalUnidades.Size = new System.Drawing.Size(124, 20);
            this.textBoxTotalUnidades.TabIndex = 72;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(660, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 77;
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
            // textCodigoMaterial
            // 
            this.textCodigoMaterial.Enabled = false;
            this.textCodigoMaterial.Location = new System.Drawing.Point(660, 191);
            this.textCodigoMaterial.Name = "textCodigoMaterial";
            this.textCodigoMaterial.Size = new System.Drawing.Size(124, 20);
            this.textCodigoMaterial.TabIndex = 79;
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
            // textBoxPrecioMaterial
            // 
            this.textBoxPrecioMaterial.Enabled = false;
            this.textBoxPrecioMaterial.Location = new System.Drawing.Point(660, 217);
            this.textBoxPrecioMaterial.Name = "textBoxPrecioMaterial";
            this.textBoxPrecioMaterial.Size = new System.Drawing.Size(124, 20);
            this.textBoxPrecioMaterial.TabIndex = 81;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(539, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 16);
            this.label10.TabIndex = 80;
            this.label10.Text = "Precio Material";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(660, 244);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 20);
            this.textBox2.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(539, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 82;
            this.label3.Text = "Unidades Entrada";
            // 
            // Forma_Entrada_Materiales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 582);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrecioMaterial);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textCodigoMaterial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
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
            this.Controls.Add(this.dataGridViewPartidasOrdenCompra);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartidasOrdenCompra)).EndInit();
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
        private System.Windows.Forms.Timer timerAgregarOrdenCompra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxDescripcionMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodigoOrdenCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewPartidasOrdenCompra;
        private System.Windows.Forms.ComboBox comboBoxCodigoOrdenCompra;
        private System.Windows.Forms.Timer timerModificarClientes;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaActual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxDescripcionMaterial;
        private System.Windows.Forms.ComboBox comboBoxEmpleado;
        private System.Windows.Forms.TextBox textBoxCodigoProveedor;
        private System.Windows.Forms.Label labeldivisa;
        private System.Windows.Forms.TextBox textBoxTotalUnidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orden_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parte_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_partida;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCodigoMaterial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPrecioMaterial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}