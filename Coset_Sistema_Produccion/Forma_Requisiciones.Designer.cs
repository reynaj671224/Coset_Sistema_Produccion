namespace Coset_Sistema_Produccion
{
    partial class Forma_Requisiciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma_Requisiciones));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonBuscarRequisicion = new System.Windows.Forms.Button();
            this.buttonAgregarCotizacion = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonGuardarBasedeDatos = new System.Windows.Forms.Button();
            this.timerAgregarRequisicion = new System.Windows.Forms.Timer(this.components);
            this.textBoxRequsitor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCodigoRequisiciones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewPartidasRequisiciones = new System.Windows.Forms.DataGridView();
            this.comboBoxCodigoRequisiciones = new System.Windows.Forms.ComboBox();
            this.timerModificarClientes = new System.Windows.Forms.Timer(this.components);
            this.textBoxDirigido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaActual = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxRequsitor = new System.Windows.Forms.ComboBox();
            this.comboBoxDirigido = new System.Windows.Forms.ComboBox();
            this.buttonWordPrevio = new System.Windows.Forms.Button();
            this.groupBoxPrevio = new System.Windows.Forms.GroupBox();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.comboBoxProveedoresPrevio = new System.Windows.Forms.ComboBox();
            this.buttonModificarRequisicion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Codigo_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parte_requisicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrpcion_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad_medida_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proyecto_partida = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Proveedor_requisicion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Busqueda_requisicion = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartidasRequisiciones)).BeginInit();
            this.groupBoxPrevio.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1182, 461);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonBuscarRequisicion
            // 
            this.buttonBuscarRequisicion.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarRequisicion.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarRequisicion.Image")));
            this.buttonBuscarRequisicion.Location = new System.Drawing.Point(509, 33);
            this.buttonBuscarRequisicion.Name = "buttonBuscarRequisicion";
            this.buttonBuscarRequisicion.Size = new System.Drawing.Size(79, 74);
            this.buttonBuscarRequisicion.TabIndex = 31;
            this.buttonBuscarRequisicion.Text = "Visualizar";
            this.buttonBuscarRequisicion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBuscarRequisicion.UseVisualStyleBackColor = true;
            this.buttonBuscarRequisicion.Visible = false;
            this.buttonBuscarRequisicion.Click += new System.EventHandler(this.buttonBuscarempleado_Click);
            // 
            // buttonAgregarCotizacion
            // 
            this.buttonAgregarCotizacion.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarCotizacion.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregarCotizacion.Image")));
            this.buttonAgregarCotizacion.Location = new System.Drawing.Point(594, 33);
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
            this.buttonCancelar.Location = new System.Drawing.Point(1091, 293);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(79, 74);
            this.buttonCancelar.TabIndex = 35;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Visible = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.AutoSize = true;
            this.buttonHome.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(1091, 373);
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
            this.buttonGuardarBasedeDatos.Location = new System.Drawing.Point(1091, 216);
            this.buttonGuardarBasedeDatos.Name = "buttonGuardarBasedeDatos";
            this.buttonGuardarBasedeDatos.Size = new System.Drawing.Size(79, 74);
            this.buttonGuardarBasedeDatos.TabIndex = 32;
            this.buttonGuardarBasedeDatos.Text = "Guardar";
            this.buttonGuardarBasedeDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonGuardarBasedeDatos.UseVisualStyleBackColor = true;
            this.buttonGuardarBasedeDatos.Visible = false;
            this.buttonGuardarBasedeDatos.Click += new System.EventHandler(this.buttonGuardarBasedeDatos_Click);
            // 
            // timerAgregarRequisicion
            // 
            this.timerAgregarRequisicion.Interval = 1000;
            this.timerAgregarRequisicion.Tick += new System.EventHandler(this.timerAgregarRequisicion_Tick);
            // 
            // textBoxRequsitor
            // 
            this.textBoxRequsitor.Enabled = false;
            this.textBoxRequsitor.Location = new System.Drawing.Point(220, 183);
            this.textBoxRequsitor.Name = "textBoxRequsitor";
            this.textBoxRequsitor.Size = new System.Drawing.Size(229, 20);
            this.textBoxRequsitor.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(32, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Proveedor";
            // 
            // textBoxCodigoRequisiciones
            // 
            this.textBoxCodigoRequisiciones.Enabled = false;
            this.textBoxCodigoRequisiciones.Location = new System.Drawing.Point(220, 156);
            this.textBoxCodigoRequisiciones.Name = "textBoxCodigoRequisiciones";
            this.textBoxCodigoRequisiciones.Size = new System.Drawing.Size(121, 20);
            this.textBoxCodigoRequisiciones.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(101, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Codigo Requisicion";
            // 
            // dataGridViewPartidasRequisiciones
            // 
            this.dataGridViewPartidasRequisiciones.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewPartidasRequisiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPartidasRequisiciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_partida,
            this.Numero_partida,
            this.Cantidad_partida,
            this.Parte_requisicion,
            this.Descrpcion_partida,
            this.Unidad_medida_partida,
            this.Proyecto_partida,
            this.Proveedor_requisicion,
            this.Busqueda_requisicion});
            this.dataGridViewPartidasRequisiciones.Enabled = false;
            this.dataGridViewPartidasRequisiciones.Location = new System.Drawing.Point(12, 293);
            this.dataGridViewPartidasRequisiciones.Name = "dataGridViewPartidasRequisiciones";
            this.dataGridViewPartidasRequisiciones.Size = new System.Drawing.Size(1054, 156);
            this.dataGridViewPartidasRequisiciones.TabIndex = 48;
            this.dataGridViewPartidasRequisiciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContactosClientes_CellClick);
            this.dataGridViewPartidasRequisiciones.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPartidasCotizacion_CellEndEdit);
            this.dataGridViewPartidasRequisiciones.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewPartidasRequisiciones_RowsAdded);
            // 
            // comboBoxCodigoRequisiciones
            // 
            this.comboBoxCodigoRequisiciones.FormattingEnabled = true;
            this.comboBoxCodigoRequisiciones.Location = new System.Drawing.Point(220, 156);
            this.comboBoxCodigoRequisiciones.Name = "comboBoxCodigoRequisiciones";
            this.comboBoxCodigoRequisiciones.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCodigoRequisiciones.TabIndex = 49;
            this.comboBoxCodigoRequisiciones.Visible = false;
            this.comboBoxCodigoRequisiciones.SelectedIndexChanged += new System.EventHandler(this.comboBoxCodigoCliente_SelectedIndexChanged);
            // 
            // timerModificarClientes
            // 
            this.timerModificarClientes.Interval = 1000;
            this.timerModificarClientes.Tick += new System.EventHandler(this.timerModificarClientes_Tick);
            // 
            // textBoxDirigido
            // 
            this.textBoxDirigido.Enabled = false;
            this.textBoxDirigido.Location = new System.Drawing.Point(221, 214);
            this.textBoxDirigido.Name = "textBoxDirigido";
            this.textBoxDirigido.Size = new System.Drawing.Size(229, 20);
            this.textBoxDirigido.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(101, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 54;
            this.label5.Text = "Dirigido A";
            // 
            // dateTimePickerFechaActual
            // 
            this.dateTimePickerFechaActual.Enabled = false;
            this.dateTimePickerFechaActual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaActual.Location = new System.Drawing.Point(221, 240);
            this.dateTimePickerFechaActual.Name = "dateTimePickerFechaActual";
            this.dateTimePickerFechaActual.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerFechaActual.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(101, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "Fecha Actual";
            // 
            // comboBoxRequsitor
            // 
            this.comboBoxRequsitor.FormattingEnabled = true;
            this.comboBoxRequsitor.Location = new System.Drawing.Point(221, 183);
            this.comboBoxRequsitor.Name = "comboBoxRequsitor";
            this.comboBoxRequsitor.Size = new System.Drawing.Size(229, 21);
            this.comboBoxRequsitor.TabIndex = 60;
            this.comboBoxRequsitor.Visible = false;
            // 
            // comboBoxDirigido
            // 
            this.comboBoxDirigido.FormattingEnabled = true;
            this.comboBoxDirigido.Location = new System.Drawing.Point(221, 213);
            this.comboBoxDirigido.Name = "comboBoxDirigido";
            this.comboBoxDirigido.Size = new System.Drawing.Size(229, 21);
            this.comboBoxDirigido.TabIndex = 61;
            this.comboBoxDirigido.Visible = false;
            // 
            // buttonWordPrevio
            // 
            this.buttonWordPrevio.Enabled = false;
            this.buttonWordPrevio.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWordPrevio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonWordPrevio.Image = ((System.Drawing.Image)(resources.GetObject("buttonWordPrevio.Image")));
            this.buttonWordPrevio.Location = new System.Drawing.Point(245, 15);
            this.buttonWordPrevio.Name = "buttonWordPrevio";
            this.buttonWordPrevio.Size = new System.Drawing.Size(79, 74);
            this.buttonWordPrevio.TabIndex = 64;
            this.buttonWordPrevio.Text = "Previo";
            this.buttonWordPrevio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonWordPrevio.UseVisualStyleBackColor = true;
            this.buttonWordPrevio.Click += new System.EventHandler(this.buttonWordPrevio_Click);
            // 
            // groupBoxPrevio
            // 
            this.groupBoxPrevio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxPrevio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxPrevio.BackgroundImage")));
            this.groupBoxPrevio.Controls.Add(this.buttonSaveFile);
            this.groupBoxPrevio.Controls.Add(this.comboBoxProveedoresPrevio);
            this.groupBoxPrevio.Controls.Add(this.buttonWordPrevio);
            this.groupBoxPrevio.Controls.Add(this.label2);
            this.groupBoxPrevio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxPrevio.Location = new System.Drawing.Point(104, 14);
            this.groupBoxPrevio.Name = "groupBoxPrevio";
            this.groupBoxPrevio.Size = new System.Drawing.Size(383, 125);
            this.groupBoxPrevio.TabIndex = 65;
            this.groupBoxPrevio.TabStop = false;
            this.groupBoxPrevio.Text = "Previo Ajuste";
            this.groupBoxPrevio.Visible = false;
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Enabled = false;
            this.buttonSaveFile.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile.Image")));
            this.buttonSaveFile.Location = new System.Drawing.Point(151, 15);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(79, 74);
            this.buttonSaveFile.TabIndex = 68;
            this.buttonSaveFile.Text = "Guardar";
            this.buttonSaveFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // comboBoxProveedoresPrevio
            // 
            this.comboBoxProveedoresPrevio.FormattingEnabled = true;
            this.comboBoxProveedoresPrevio.Location = new System.Drawing.Point(117, 95);
            this.comboBoxProveedoresPrevio.Name = "comboBoxProveedoresPrevio";
            this.comboBoxProveedoresPrevio.Size = new System.Drawing.Size(229, 21);
            this.comboBoxProveedoresPrevio.TabIndex = 67;
            this.comboBoxProveedoresPrevio.SelectedIndexChanged += new System.EventHandler(this.comboBoxProveedoresPrevio_SelectedIndexChanged);
            // 
            // buttonModificarRequisicion
            // 
            this.buttonModificarRequisicion.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarRequisicion.Image = ((System.Drawing.Image)(resources.GetObject("buttonModificarRequisicion.Image")));
            this.buttonModificarRequisicion.Location = new System.Drawing.Point(679, 33);
            this.buttonModificarRequisicion.Name = "buttonModificarRequisicion";
            this.buttonModificarRequisicion.Size = new System.Drawing.Size(79, 74);
            this.buttonModificarRequisicion.TabIndex = 66;
            this.buttonModificarRequisicion.Text = "Modificar";
            this.buttonModificarRequisicion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonModificarRequisicion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonModificarRequisicion.UseVisualStyleBackColor = true;
            this.buttonModificarRequisicion.Visible = false;
            this.buttonModificarRequisicion.Click += new System.EventHandler(this.buttonModificarRequisicion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(101, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 67;
            this.label1.Text = "Requisitor";
            // 
            // Codigo_partida
            // 
            this.Codigo_partida.HeaderText = "Codigo";
            this.Codigo_partida.Name = "Codigo_partida";
            this.Codigo_partida.Width = 50;
            // 
            // Numero_partida
            // 
            this.Numero_partida.HeaderText = "Partida";
            this.Numero_partida.Name = "Numero_partida";
            this.Numero_partida.ReadOnly = true;
            this.Numero_partida.Width = 50;
            // 
            // Cantidad_partida
            // 
            this.Cantidad_partida.HeaderText = "Cantidad";
            this.Cantidad_partida.Name = "Cantidad_partida";
            this.Cantidad_partida.Width = 50;
            // 
            // Parte_requisicion
            // 
            this.Parte_requisicion.HeaderText = "No. Parte";
            this.Parte_requisicion.Name = "Parte_requisicion";
            // 
            // Descrpcion_partida
            // 
            this.Descrpcion_partida.HeaderText = "Descripcion";
            this.Descrpcion_partida.Name = "Descrpcion_partida";
            this.Descrpcion_partida.Width = 400;
            // 
            // Unidad_medida_partida
            // 
            this.Unidad_medida_partida.HeaderText = "Unidad Medida";
            this.Unidad_medida_partida.Name = "Unidad_medida_partida";
            this.Unidad_medida_partida.Width = 50;
            // 
            // Proyecto_partida
            // 
            this.Proyecto_partida.HeaderText = "Proyecto";
            this.Proyecto_partida.Name = "Proyecto_partida";
            this.Proyecto_partida.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Proyecto_partida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Proveedor_requisicion
            // 
            this.Proveedor_requisicion.HeaderText = "Proveedor";
            this.Proveedor_requisicion.Name = "Proveedor_requisicion";
            this.Proveedor_requisicion.ReadOnly = true;
            this.Proveedor_requisicion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Proveedor_requisicion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Proveedor_requisicion.Width = 200;
            // 
            // Busqueda_requisicion
            // 
            this.Busqueda_requisicion.HeaderText = "Busqueda";
            this.Busqueda_requisicion.Name = "Busqueda_requisicion";
            this.Busqueda_requisicion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Busqueda_requisicion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Busqueda_requisicion.Text = "Busqeuda";
            this.Busqueda_requisicion.Width = 60;
            // 
            // Forma_Requisiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonModificarRequisicion);
            this.Controls.Add(this.groupBoxPrevio);
            this.Controls.Add(this.comboBoxDirigido);
            this.Controls.Add(this.comboBoxRequsitor);
            this.Controls.Add(this.dateTimePickerFechaActual);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDirigido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxCodigoRequisiciones);
            this.Controls.Add(this.dataGridViewPartidasRequisiciones);
            this.Controls.Add(this.textBoxRequsitor);
            this.Controls.Add(this.textBoxCodigoRequisiciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonGuardarBasedeDatos);
            this.Controls.Add(this.buttonBuscarRequisicion);
            this.Controls.Add(this.buttonAgregarCotizacion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Forma_Requisiciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requisiciones";
            this.Load += new System.EventHandler(this.Forma_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartidasRequisiciones)).EndInit();
            this.groupBoxPrevio.ResumeLayout(false);
            this.groupBoxPrevio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBuscarRequisicion;
        private System.Windows.Forms.Button buttonAgregarCotizacion;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonGuardarBasedeDatos;
        private System.Windows.Forms.Timer timerAgregarRequisicion;
        private System.Windows.Forms.TextBox textBoxRequsitor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodigoRequisiciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewPartidasRequisiciones;
        private System.Windows.Forms.ComboBox comboBoxCodigoRequisiciones;
        private System.Windows.Forms.Timer timerModificarClientes;
        private System.Windows.Forms.TextBox textBoxDirigido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaActual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxRequsitor;
        private System.Windows.Forms.ComboBox comboBoxDirigido;
        private System.Windows.Forms.Button buttonWordPrevio;
        private System.Windows.Forms.GroupBox groupBoxPrevio;
        private System.Windows.Forms.Button buttonModificarRequisicion;
        private System.Windows.Forms.ComboBox comboBoxProveedoresPrevio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parte_requisicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrpcion_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad_medida_partida;
        private System.Windows.Forms.DataGridViewComboBoxColumn Proyecto_partida;
        private System.Windows.Forms.DataGridViewComboBoxColumn Proveedor_requisicion;
        private System.Windows.Forms.DataGridViewButtonColumn Busqueda_requisicion;
    }
}