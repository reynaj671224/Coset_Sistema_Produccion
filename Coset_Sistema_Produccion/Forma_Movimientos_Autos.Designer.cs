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
            this.timerMovimientosAuto = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAutoDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxClienteProveedor = new System.Windows.Forms.TextBox();
            this.labelClienteProveedor = new System.Windows.Forms.Label();
            this.comboBoxClienteProveedor = new System.Windows.Forms.ComboBox();
            this.timerModificarClientes = new System.Windows.Forms.Timer(this.components);
            this.comboBoxAutoDescripcion = new System.Windows.Forms.ComboBox();
            this.textBoxContactoClienteProveedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TimePickerHora = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewEmpleadosAuto = new System.Windows.Forms.DataGridView();
            this.Empleado_nombre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Responsable = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comboBoxContactoClienteProveedor = new System.Windows.Forms.ComboBox();
            this.dataGridViewMovimientosAutos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxEmpleado = new System.Windows.Forms.ComboBox();
            this.textBoxEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleadosAuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovimientosAutos)).BeginInit();
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
            this.buttonBuscarMovimientos.Click += new System.EventHandler(this.buttonBuscarMovimientos_Click);
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
            this.buttonEntradaAuto.Click += new System.EventHandler(this.buttonEntradaAuto_Click);
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
            this.buttonSalidaAuto.Click += new System.EventHandler(this.buttonSalidaAuto_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AutoSize = true;
            this.buttonCancelar.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.Location = new System.Drawing.Point(948, 320);
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
            this.buttonBorrarBasedeDatos.Location = new System.Drawing.Point(948, 240);
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
            this.buttonHome.Location = new System.Drawing.Point(948, 400);
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
            this.buttonGuardarBasedeDatos.Location = new System.Drawing.Point(948, 240);
            this.buttonGuardarBasedeDatos.Name = "buttonGuardarBasedeDatos";
            this.buttonGuardarBasedeDatos.Size = new System.Drawing.Size(79, 74);
            this.buttonGuardarBasedeDatos.TabIndex = 32;
            this.buttonGuardarBasedeDatos.Text = "Guardar";
            this.buttonGuardarBasedeDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonGuardarBasedeDatos.UseVisualStyleBackColor = true;
            this.buttonGuardarBasedeDatos.Visible = false;
            this.buttonGuardarBasedeDatos.Click += new System.EventHandler(this.buttonGuardarBasedeDatos_Click);
            // 
            // timerMovimientosAuto
            // 
            this.timerMovimientosAuto.Interval = 1000;
            this.timerMovimientosAuto.Tick += new System.EventHandler(this.timerMovimientosAuto_Tick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(86, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 16);
            this.label12.TabIndex = 45;
            this.label12.Text = "Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(86, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Fecha";
            // 
            // textBoxAutoDescripcion
            // 
            this.textBoxAutoDescripcion.Enabled = false;
            this.textBoxAutoDescripcion.Location = new System.Drawing.Point(208, 165);
            this.textBoxAutoDescripcion.Name = "textBoxAutoDescripcion";
            this.textBoxAutoDescripcion.Size = new System.Drawing.Size(311, 20);
            this.textBoxAutoDescripcion.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(86, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Auto Descripcion";
            // 
            // textBoxClienteProveedor
            // 
            this.textBoxClienteProveedor.Enabled = false;
            this.textBoxClienteProveedor.Location = new System.Drawing.Point(208, 138);
            this.textBoxClienteProveedor.Name = "textBoxClienteProveedor";
            this.textBoxClienteProveedor.Size = new System.Drawing.Size(178, 20);
            this.textBoxClienteProveedor.TabIndex = 38;
            // 
            // labelClienteProveedor
            // 
            this.labelClienteProveedor.AutoSize = true;
            this.labelClienteProveedor.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClienteProveedor.Image = ((System.Drawing.Image)(resources.GetObject("labelClienteProveedor.Image")));
            this.labelClienteProveedor.Location = new System.Drawing.Point(86, 140);
            this.labelClienteProveedor.Name = "labelClienteProveedor";
            this.labelClienteProveedor.Size = new System.Drawing.Size(103, 16);
            this.labelClienteProveedor.TabIndex = 37;
            this.labelClienteProveedor.Text = "Cliente/Proveedor";
            // 
            // comboBoxClienteProveedor
            // 
            this.comboBoxClienteProveedor.FormattingEnabled = true;
            this.comboBoxClienteProveedor.Location = new System.Drawing.Point(208, 138);
            this.comboBoxClienteProveedor.Name = "comboBoxClienteProveedor";
            this.comboBoxClienteProveedor.Size = new System.Drawing.Size(178, 21);
            this.comboBoxClienteProveedor.Sorted = true;
            this.comboBoxClienteProveedor.TabIndex = 49;
            this.comboBoxClienteProveedor.Visible = false;
            this.comboBoxClienteProveedor.SelectedIndexChanged += new System.EventHandler(this.comboBoxCodigoCliente_SelectedIndexChanged);
            // 
            // timerModificarClientes
            // 
            this.timerModificarClientes.Interval = 1000;
            // 
            // comboBoxAutoDescripcion
            // 
            this.comboBoxAutoDescripcion.FormattingEnabled = true;
            this.comboBoxAutoDescripcion.Location = new System.Drawing.Point(208, 165);
            this.comboBoxAutoDescripcion.Name = "comboBoxAutoDescripcion";
            this.comboBoxAutoDescripcion.Size = new System.Drawing.Size(311, 21);
            this.comboBoxAutoDescripcion.Sorted = true;
            this.comboBoxAutoDescripcion.TabIndex = 54;
            this.comboBoxAutoDescripcion.Visible = false;
            this.comboBoxAutoDescripcion.SelectedIndexChanged += new System.EventHandler(this.comboBoxNombreCliente_SelectedIndexChanged);
            // 
            // textBoxContactoClienteProveedor
            // 
            this.textBoxContactoClienteProveedor.Enabled = false;
            this.textBoxContactoClienteProveedor.Location = new System.Drawing.Point(208, 194);
            this.textBoxContactoClienteProveedor.Name = "textBoxContactoClienteProveedor";
            this.textBoxContactoClienteProveedor.Size = new System.Drawing.Size(178, 20);
            this.textBoxContactoClienteProveedor.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(86, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "Contacto Visita";
            // 
            // TimePickerHora
            // 
            this.TimePickerHora.Enabled = false;
            this.TimePickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TimePickerHora.Location = new System.Drawing.Point(208, 252);
            this.TimePickerHora.Name = "TimePickerHora";
            this.TimePickerHora.Size = new System.Drawing.Size(147, 20);
            this.TimePickerHora.TabIndex = 58;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Enabled = false;
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(208, 226);
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
            this.dataGridViewEmpleadosAuto.Enabled = false;
            this.dataGridViewEmpleadosAuto.Location = new System.Drawing.Point(582, 140);
            this.dataGridViewEmpleadosAuto.Name = "dataGridViewEmpleadosAuto";
            this.dataGridViewEmpleadosAuto.Size = new System.Drawing.Size(343, 146);
            this.dataGridViewEmpleadosAuto.TabIndex = 60;
            this.dataGridViewEmpleadosAuto.Visible = false;
            // 
            // Empleado_nombre
            // 
            this.Empleado_nombre.HeaderText = "Empleado";
            this.Empleado_nombre.Name = "Empleado_nombre";
            this.Empleado_nombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Empleado_nombre.Sorted = true;
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
            // comboBoxContactoClienteProveedor
            // 
            this.comboBoxContactoClienteProveedor.FormattingEnabled = true;
            this.comboBoxContactoClienteProveedor.Location = new System.Drawing.Point(208, 193);
            this.comboBoxContactoClienteProveedor.Name = "comboBoxContactoClienteProveedor";
            this.comboBoxContactoClienteProveedor.Size = new System.Drawing.Size(178, 21);
            this.comboBoxContactoClienteProveedor.Sorted = true;
            this.comboBoxContactoClienteProveedor.TabIndex = 61;
            this.comboBoxContactoClienteProveedor.Visible = false;
            this.comboBoxContactoClienteProveedor.SelectedIndexChanged += new System.EventHandler(this.comboBoxContactoClienteProveedor_SelectedIndexChanged);
            // 
            // dataGridViewMovimientosAutos
            // 
            this.dataGridViewMovimientosAutos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewMovimientosAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovimientosAutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Auto,
            this.Hora_salida,
            this.Fecha_salida,
            this.Hora_entrada,
            this.Fecha_entrada,
            this.Compania,
            this.Contacto,
            this.Estado,
            this.empleados});
            this.dataGridViewMovimientosAutos.Enabled = false;
            this.dataGridViewMovimientosAutos.Location = new System.Drawing.Point(27, 328);
            this.dataGridViewMovimientosAutos.Name = "dataGridViewMovimientosAutos";
            this.dataGridViewMovimientosAutos.Size = new System.Drawing.Size(898, 146);
            this.dataGridViewMovimientosAutos.TabIndex = 62;
            this.dataGridViewMovimientosAutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovimientosAutos_CellClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.Visible = false;
            // 
            // Auto
            // 
            this.Auto.HeaderText = "Auto";
            this.Auto.Name = "Auto";
            this.Auto.Width = 150;
            // 
            // Hora_salida
            // 
            this.Hora_salida.HeaderText = "Hora Salida";
            this.Hora_salida.Name = "Hora_salida";
            this.Hora_salida.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Fecha_salida
            // 
            this.Fecha_salida.HeaderText = "Fecha Salida";
            this.Fecha_salida.Name = "Fecha_salida";
            this.Fecha_salida.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Hora_entrada
            // 
            this.Hora_entrada.HeaderText = "Hora Entrada";
            this.Hora_entrada.Name = "Hora_entrada";
            // 
            // Fecha_entrada
            // 
            this.Fecha_entrada.HeaderText = "Fecha Entrada";
            this.Fecha_entrada.Name = "Fecha_entrada";
            // 
            // Compania
            // 
            this.Compania.HeaderText = "Compañia Visita";
            this.Compania.Name = "Compania";
            this.Compania.Width = 150;
            // 
            // Contacto
            // 
            this.Contacto.HeaderText = "Contacto Visita";
            this.Contacto.Name = "Contacto";
            this.Contacto.Width = 150;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // empleados
            // 
            this.empleados.FillWeight = 200F;
            this.empleados.HeaderText = "Empleado";
            this.empleados.Name = "empleados";
            this.empleados.Width = 200;
            // 
            // comboBoxEmpleado
            // 
            this.comboBoxEmpleado.FormattingEnabled = true;
            this.comboBoxEmpleado.Location = new System.Drawing.Point(208, 113);
            this.comboBoxEmpleado.Name = "comboBoxEmpleado";
            this.comboBoxEmpleado.Size = new System.Drawing.Size(246, 21);
            this.comboBoxEmpleado.Sorted = true;
            this.comboBoxEmpleado.TabIndex = 65;
            this.comboBoxEmpleado.Visible = false;
            this.comboBoxEmpleado.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmpleado_SelectedIndexChanged);
            // 
            // textBoxEmpleado
            // 
            this.textBoxEmpleado.Enabled = false;
            this.textBoxEmpleado.Location = new System.Drawing.Point(208, 113);
            this.textBoxEmpleado.Name = "textBoxEmpleado";
            this.textBoxEmpleado.Size = new System.Drawing.Size(246, 20);
            this.textBoxEmpleado.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(86, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 63;
            this.label3.Text = "Empleado";
            // 
            // buttonExcel
            // 
            this.buttonExcel.AutoSize = true;
            this.buttonExcel.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcel.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcel.Image")));
            this.buttonExcel.Location = new System.Drawing.Point(948, 240);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(79, 74);
            this.buttonExcel.TabIndex = 66;
            this.buttonExcel.Text = "Excel";
            this.buttonExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Visible = false;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // Forma_Movimientos_Autos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 486);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.comboBoxEmpleado);
            this.Controls.Add(this.textBoxEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewMovimientosAutos);
            this.Controls.Add(this.comboBoxContactoClienteProveedor);
            this.Controls.Add(this.dataGridViewEmpleadosAuto);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.TimePickerHora);
            this.Controls.Add(this.textBoxContactoClienteProveedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxAutoDescripcion);
            this.Controls.Add(this.comboBoxClienteProveedor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAutoDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxClienteProveedor);
            this.Controls.Add(this.labelClienteProveedor);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovimientosAutos)).EndInit();
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
        private System.Windows.Forms.Timer timerMovimientosAuto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAutoDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxClienteProveedor;
        private System.Windows.Forms.Label labelClienteProveedor;
        private System.Windows.Forms.ComboBox comboBoxClienteProveedor;
        private System.Windows.Forms.Timer timerModificarClientes;
        private System.Windows.Forms.ComboBox comboBoxAutoDescripcion;
        private System.Windows.Forms.TextBox textBoxContactoClienteProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker TimePickerHora;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.DataGridView dataGridViewEmpleadosAuto;
        private System.Windows.Forms.ComboBox comboBoxContactoClienteProveedor;
        private System.Windows.Forms.DataGridView dataGridViewMovimientosAutos;
        private System.Windows.Forms.DataGridViewComboBoxColumn Empleado_nombre;
        private System.Windows.Forms.DataGridViewComboBoxColumn Responsable;
        private System.Windows.Forms.ComboBox comboBoxEmpleado;
        private System.Windows.Forms.TextBox textBoxEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compania;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleados;
        private System.Windows.Forms.Button buttonExcel;
    }
}