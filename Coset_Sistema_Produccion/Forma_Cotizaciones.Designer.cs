namespace Coset_Sistema_Produccion
{
    partial class Forma_Cotizaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma_Cotizaciones));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonBuscarCotizacion = new System.Windows.Forms.Button();
            this.buttonEliminarCotizacion = new System.Windows.Forms.Button();
            this.buttonAgregarCotizacion = new System.Windows.Forms.Button();
            this.buttonModificarCotizacion = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonBorrarBasedeDatos = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonGuardarBasedeDatos = new System.Windows.Forms.Button();
            this.timerAgregarCotizacion = new System.Windows.Forms.Timer(this.components);
            this.textBoxOrdenTrabajo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxProyecto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAtencion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigoCotizaciones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewPartidasCotizacion = new System.Windows.Forms.DataGridView();
            this.Codigo_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parte_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrpcion_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxCodigoCotizaciones = new System.Windows.Forms.ComboBox();
            this.timerModificarClientes = new System.Windows.Forms.Timer(this.components);
            this.buttonPartidas = new System.Windows.Forms.Button();
            this.buttonEliminarPartida = new System.Windows.Forms.Button();
            this.buttonAgregarPartida = new System.Windows.Forms.Button();
            this.textBoxAtencionCopia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaActual = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxAtencion = new System.Windows.Forms.ComboBox();
            this.comboBoxAtencionCopia = new System.Windows.Forms.ComboBox();
            this.comboBoxNombreCliente = new System.Windows.Forms.ComboBox();
            this.buttonCopiarCotizacion = new System.Windows.Forms.Button();
            this.buttonWordPrevio = new System.Windows.Forms.Button();
            this.groupBoxPrevio = new System.Windows.Forms.GroupBox();
            this.radioButtonPrevioIngles = new System.Windows.Forms.RadioButton();
            this.radioButtonPrevioEspanol = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartidasCotizacion)).BeginInit();
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
            this.pictureBox1.Size = new System.Drawing.Size(1124, 461);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonBuscarCotizacion
            // 
            this.buttonBuscarCotizacion.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarCotizacion.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarCotizacion.Image")));
            this.buttonBuscarCotizacion.Location = new System.Drawing.Point(324, 22);
            this.buttonBuscarCotizacion.Name = "buttonBuscarCotizacion";
            this.buttonBuscarCotizacion.Size = new System.Drawing.Size(79, 74);
            this.buttonBuscarCotizacion.TabIndex = 31;
            this.buttonBuscarCotizacion.Text = "Visualizar";
            this.buttonBuscarCotizacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBuscarCotizacion.UseVisualStyleBackColor = true;
            this.buttonBuscarCotizacion.Click += new System.EventHandler(this.buttonBuscarempleado_Click);
            // 
            // buttonEliminarCotizacion
            // 
            this.buttonEliminarCotizacion.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarCotizacion.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminarCotizacion.Image")));
            this.buttonEliminarCotizacion.Location = new System.Drawing.Point(664, 22);
            this.buttonEliminarCotizacion.Name = "buttonEliminarCotizacion";
            this.buttonEliminarCotizacion.Size = new System.Drawing.Size(79, 74);
            this.buttonEliminarCotizacion.TabIndex = 30;
            this.buttonEliminarCotizacion.Text = "Eliminar";
            this.buttonEliminarCotizacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEliminarCotizacion.UseVisualStyleBackColor = true;
            this.buttonEliminarCotizacion.Click += new System.EventHandler(this.buttonEliminarCliente_Click);
            // 
            // buttonAgregarCotizacion
            // 
            this.buttonAgregarCotizacion.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarCotizacion.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregarCotizacion.Image")));
            this.buttonAgregarCotizacion.Location = new System.Drawing.Point(494, 22);
            this.buttonAgregarCotizacion.Name = "buttonAgregarCotizacion";
            this.buttonAgregarCotizacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAgregarCotizacion.Size = new System.Drawing.Size(79, 74);
            this.buttonAgregarCotizacion.TabIndex = 29;
            this.buttonAgregarCotizacion.Text = "Agregar";
            this.buttonAgregarCotizacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAgregarCotizacion.UseVisualStyleBackColor = true;
            this.buttonAgregarCotizacion.Click += new System.EventHandler(this.buttonAgregarCotizacion_Click);
            // 
            // buttonModificarCotizacion
            // 
            this.buttonModificarCotizacion.AutoSize = true;
            this.buttonModificarCotizacion.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarCotizacion.Image = ((System.Drawing.Image)(resources.GetObject("buttonModificarCotizacion.Image")));
            this.buttonModificarCotizacion.Location = new System.Drawing.Point(409, 22);
            this.buttonModificarCotizacion.Name = "buttonModificarCotizacion";
            this.buttonModificarCotizacion.Size = new System.Drawing.Size(79, 74);
            this.buttonModificarCotizacion.TabIndex = 28;
            this.buttonModificarCotizacion.Text = "Modificar";
            this.buttonModificarCotizacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonModificarCotizacion.UseVisualStyleBackColor = true;
            this.buttonModificarCotizacion.Click += new System.EventHandler(this.buttonModificarCliente_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AutoSize = true;
            this.buttonCancelar.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.Location = new System.Drawing.Point(1019, 282);
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
            this.buttonBorrarBasedeDatos.Location = new System.Drawing.Point(1019, 190);
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
            this.buttonHome.Location = new System.Drawing.Point(1019, 364);
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
            this.buttonGuardarBasedeDatos.Location = new System.Drawing.Point(1019, 202);
            this.buttonGuardarBasedeDatos.Name = "buttonGuardarBasedeDatos";
            this.buttonGuardarBasedeDatos.Size = new System.Drawing.Size(79, 74);
            this.buttonGuardarBasedeDatos.TabIndex = 32;
            this.buttonGuardarBasedeDatos.Text = "Guardar";
            this.buttonGuardarBasedeDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonGuardarBasedeDatos.UseVisualStyleBackColor = true;
            this.buttonGuardarBasedeDatos.Visible = false;
            this.buttonGuardarBasedeDatos.Click += new System.EventHandler(this.buttonGuardarBasedeDatos_Click);
            // 
            // timerAgregarCotizacion
            // 
            this.timerAgregarCotizacion.Interval = 1000;
            this.timerAgregarCotizacion.Tick += new System.EventHandler(this.timerAgregarCliente_Tick);
            // 
            // textBoxOrdenTrabajo
            // 
            this.textBoxOrdenTrabajo.Enabled = false;
            this.textBoxOrdenTrabajo.Location = new System.Drawing.Point(220, 214);
            this.textBoxOrdenTrabajo.Name = "textBoxOrdenTrabajo";
            this.textBoxOrdenTrabajo.Size = new System.Drawing.Size(113, 20);
            this.textBoxOrdenTrabajo.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(100, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 16);
            this.label12.TabIndex = 45;
            this.label12.Text = "Orden Compra";
            // 
            // textBoxProyecto
            // 
            this.textBoxProyecto.Enabled = false;
            this.textBoxProyecto.Location = new System.Drawing.Point(220, 240);
            this.textBoxProyecto.Name = "textBoxProyecto";
            this.textBoxProyecto.Size = new System.Drawing.Size(113, 20);
            this.textBoxProyecto.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(100, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Proyecto";
            // 
            // textBoxAtencion
            // 
            this.textBoxAtencion.Enabled = false;
            this.textBoxAtencion.Location = new System.Drawing.Point(220, 159);
            this.textBoxAtencion.Name = "textBoxAtencion";
            this.textBoxAtencion.Size = new System.Drawing.Size(229, 20);
            this.textBoxAtencion.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(100, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Atención";
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Enabled = false;
            this.textBoxNombreCliente.Location = new System.Drawing.Point(452, 132);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.Size = new System.Drawing.Size(246, 20);
            this.textBoxNombreCliente.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(354, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nombre Cliente";
            // 
            // textBoxCodigoCotizaciones
            // 
            this.textBoxCodigoCotizaciones.Enabled = false;
            this.textBoxCodigoCotizaciones.Location = new System.Drawing.Point(220, 130);
            this.textBoxCodigoCotizaciones.Name = "textBoxCodigoCotizaciones";
            this.textBoxCodigoCotizaciones.Size = new System.Drawing.Size(121, 20);
            this.textBoxCodigoCotizaciones.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(100, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Codigo Cotizacion";
            // 
            // dataGridViewPartidasCotizacion
            // 
            this.dataGridViewPartidasCotizacion.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewPartidasCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPartidasCotizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_partida,
            this.Numero_partida,
            this.Cantidad_partida,
            this.Parte_partida,
            this.Descrpcion_partida,
            this.Precio_partida,
            this.Importe_partida});
            this.dataGridViewPartidasCotizacion.Enabled = false;
            this.dataGridViewPartidasCotizacion.Location = new System.Drawing.Point(100, 293);
            this.dataGridViewPartidasCotizacion.Name = "dataGridViewPartidasCotizacion";
            this.dataGridViewPartidasCotizacion.Size = new System.Drawing.Size(894, 156);
            this.dataGridViewPartidasCotizacion.TabIndex = 48;
            this.dataGridViewPartidasCotizacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContactosClientes_CellClick);
            this.dataGridViewPartidasCotizacion.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPartidasCotizacion_CellEndEdit);            // 
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
            this.Numero_partida.Width = 50;
            // 
            // Cantidad_partida
            // 
            this.Cantidad_partida.HeaderText = "Cantidad";
            this.Cantidad_partida.Name = "Cantidad_partida";
            this.Cantidad_partida.Width = 50;
            // 
            // Parte_partida
            // 
            this.Parte_partida.HeaderText = "Parte";
            this.Parte_partida.Name = "Parte_partida";
            // 
            // Descrpcion_partida
            // 
            this.Descrpcion_partida.HeaderText = "Descripcion";
            this.Descrpcion_partida.Name = "Descrpcion_partida";
            this.Descrpcion_partida.Width = 450;
            // 
            // Precio_partida
            // 
            this.Precio_partida.HeaderText = "Precio";
            this.Precio_partida.Name = "Precio_partida";
            // 
            // Importe_partida
            // 
            this.Importe_partida.HeaderText = "Importe";
            this.Importe_partida.Name = "Importe_partida";
            this.Importe_partida.ReadOnly = true;
            // 
            // comboBoxCodigoCotizaciones
            // 
            this.comboBoxCodigoCotizaciones.FormattingEnabled = true;
            this.comboBoxCodigoCotizaciones.Location = new System.Drawing.Point(220, 129);
            this.comboBoxCodigoCotizaciones.Name = "comboBoxCodigoCotizaciones";
            this.comboBoxCodigoCotizaciones.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCodigoCotizaciones.Sorted = true;
            this.comboBoxCodigoCotizaciones.TabIndex = 49;
            this.comboBoxCodigoCotizaciones.Visible = false;
            this.comboBoxCodigoCotizaciones.SelectedIndexChanged += new System.EventHandler(this.comboBoxCodigoCliente_SelectedIndexChanged);
            // 
            // timerModificarClientes
            // 
            this.timerModificarClientes.Interval = 1000;
            this.timerModificarClientes.Tick += new System.EventHandler(this.timerModificarClientes_Tick);
            // 
            // buttonPartidas
            // 
            this.buttonPartidas.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPartidas.Image = ((System.Drawing.Image)(resources.GetObject("buttonPartidas.Image")));
            this.buttonPartidas.Location = new System.Drawing.Point(749, 22);
            this.buttonPartidas.Name = "buttonPartidas";
            this.buttonPartidas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonPartidas.Size = new System.Drawing.Size(79, 74);
            this.buttonPartidas.TabIndex = 51;
            this.buttonPartidas.Text = "Partidas";
            this.buttonPartidas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPartidas.UseVisualStyleBackColor = true;
            this.buttonPartidas.Click += new System.EventHandler(this.buttonContactos_Click);
            // 
            // buttonEliminarPartida
            // 
            this.buttonEliminarPartida.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarPartida.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminarPartida.Image")));
            this.buttonEliminarPartida.Location = new System.Drawing.Point(12, 375);
            this.buttonEliminarPartida.Name = "buttonEliminarPartida";
            this.buttonEliminarPartida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonEliminarPartida.Size = new System.Drawing.Size(79, 74);
            this.buttonEliminarPartida.TabIndex = 52;
            this.buttonEliminarPartida.Text = "Eliminar";
            this.buttonEliminarPartida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEliminarPartida.UseVisualStyleBackColor = true;
            this.buttonEliminarPartida.Visible = false;
            this.buttonEliminarPartida.Click += new System.EventHandler(this.buttonEliminarContacto_Click);
            // 
            // buttonAgregarPartida
            // 
            this.buttonAgregarPartida.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarPartida.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregarPartida.Image")));
            this.buttonAgregarPartida.Location = new System.Drawing.Point(12, 293);
            this.buttonAgregarPartida.Name = "buttonAgregarPartida";
            this.buttonAgregarPartida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAgregarPartida.Size = new System.Drawing.Size(79, 74);
            this.buttonAgregarPartida.TabIndex = 53;
            this.buttonAgregarPartida.Text = "Agregar";
            this.buttonAgregarPartida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAgregarPartida.UseVisualStyleBackColor = true;
            this.buttonAgregarPartida.Visible = false;
            this.buttonAgregarPartida.Click += new System.EventHandler(this.buttonAgregarContacto_Click);
            // 
            // textBoxAtencionCopia
            // 
            this.textBoxAtencionCopia.Enabled = false;
            this.textBoxAtencionCopia.Location = new System.Drawing.Point(220, 185);
            this.textBoxAtencionCopia.Name = "textBoxAtencionCopia";
            this.textBoxAtencionCopia.Size = new System.Drawing.Size(229, 20);
            this.textBoxAtencionCopia.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(100, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 54;
            this.label5.Text = "Atención Copia";
            // 
            // dateTimePickerFechaActual
            // 
            this.dateTimePickerFechaActual.Enabled = false;
            this.dateTimePickerFechaActual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaActual.Location = new System.Drawing.Point(578, 159);
            this.dateTimePickerFechaActual.Name = "dateTimePickerFechaActual";
            this.dateTimePickerFechaActual.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerFechaActual.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(490, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "Fecha Actual";
            // 
            // dateTimePickerFechaEntrega
            // 
            this.dateTimePickerFechaEntrega.Enabled = false;
            this.dateTimePickerFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaEntrega.Location = new System.Drawing.Point(578, 185);
            this.dateTimePickerFechaEntrega.Name = "dateTimePickerFechaEntrega";
            this.dateTimePickerFechaEntrega.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerFechaEntrega.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(490, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 58;
            this.label7.Text = "Fecha Entrega";
            // 
            // comboBoxAtencion
            // 
            this.comboBoxAtencion.FormattingEnabled = true;
            this.comboBoxAtencion.Location = new System.Drawing.Point(220, 159);
            this.comboBoxAtencion.Name = "comboBoxAtencion";
            this.comboBoxAtencion.Size = new System.Drawing.Size(229, 21);
            this.comboBoxAtencion.Sorted = true;
            this.comboBoxAtencion.TabIndex = 60;
            this.comboBoxAtencion.Visible = false;
            // 
            // comboBoxAtencionCopia
            // 
            this.comboBoxAtencionCopia.FormattingEnabled = true;
            this.comboBoxAtencionCopia.Location = new System.Drawing.Point(220, 186);
            this.comboBoxAtencionCopia.Name = "comboBoxAtencionCopia";
            this.comboBoxAtencionCopia.Size = new System.Drawing.Size(229, 21);
            this.comboBoxAtencionCopia.Sorted = true;
            this.comboBoxAtencionCopia.TabIndex = 61;
            this.comboBoxAtencionCopia.Visible = false;
            // 
            // comboBoxNombreCliente
            // 
            this.comboBoxNombreCliente.FormattingEnabled = true;
            this.comboBoxNombreCliente.Location = new System.Drawing.Point(452, 132);
            this.comboBoxNombreCliente.Name = "comboBoxNombreCliente";
            this.comboBoxNombreCliente.Size = new System.Drawing.Size(246, 21);
            this.comboBoxNombreCliente.Sorted = true;
            this.comboBoxNombreCliente.TabIndex = 62;
            this.comboBoxNombreCliente.Visible = false;
            this.comboBoxNombreCliente.SelectedIndexChanged += new System.EventHandler(this.comboBoxNombreCliente_SelectedIndexChanged);
            // 
            // buttonCopiarCotizacion
            // 
            this.buttonCopiarCotizacion.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopiarCotizacion.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopiarCotizacion.Image")));
            this.buttonCopiarCotizacion.Location = new System.Drawing.Point(579, 22);
            this.buttonCopiarCotizacion.Name = "buttonCopiarCotizacion";
            this.buttonCopiarCotizacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonCopiarCotizacion.Size = new System.Drawing.Size(79, 74);
            this.buttonCopiarCotizacion.TabIndex = 63;
            this.buttonCopiarCotizacion.Text = "Copiar";
            this.buttonCopiarCotizacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCopiarCotizacion.UseVisualStyleBackColor = true;
            this.buttonCopiarCotizacion.Click += new System.EventHandler(this.buttonCopiarCotizacion_Click);
            // 
            // buttonWordPrevio
            // 
            this.buttonWordPrevio.Enabled = false;
            this.buttonWordPrevio.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWordPrevio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonWordPrevio.Image = ((System.Drawing.Image)(resources.GetObject("buttonWordPrevio.Image")));
            this.buttonWordPrevio.Location = new System.Drawing.Point(115, 10);
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
            this.groupBoxPrevio.Controls.Add(this.radioButtonPrevioIngles);
            this.groupBoxPrevio.Controls.Add(this.radioButtonPrevioEspanol);
            this.groupBoxPrevio.Controls.Add(this.buttonWordPrevio);
            this.groupBoxPrevio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxPrevio.Location = new System.Drawing.Point(118, 12);
            this.groupBoxPrevio.Name = "groupBoxPrevio";
            this.groupBoxPrevio.Size = new System.Drawing.Size(200, 93);
            this.groupBoxPrevio.TabIndex = 65;
            this.groupBoxPrevio.TabStop = false;
            this.groupBoxPrevio.Text = "Previo Ajuste";
            this.groupBoxPrevio.Visible = false;
            // 
            // radioButtonPrevioIngles
            // 
            this.radioButtonPrevioIngles.AutoSize = true;
            this.radioButtonPrevioIngles.BackColor = System.Drawing.SystemColors.Highlight;
            this.radioButtonPrevioIngles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonPrevioIngles.Location = new System.Drawing.Point(7, 55);
            this.radioButtonPrevioIngles.Name = "radioButtonPrevioIngles";
            this.radioButtonPrevioIngles.Size = new System.Drawing.Size(53, 17);
            this.radioButtonPrevioIngles.TabIndex = 66;
            this.radioButtonPrevioIngles.TabStop = true;
            this.radioButtonPrevioIngles.Text = "Ingles";
            this.radioButtonPrevioIngles.UseVisualStyleBackColor = false;
            this.radioButtonPrevioIngles.CheckedChanged += new System.EventHandler(this.radioButtonPrevioIngles_CheckedChanged);
            // 
            // radioButtonPrevioEspanol
            // 
            this.radioButtonPrevioEspanol.AutoSize = true;
            this.radioButtonPrevioEspanol.BackColor = System.Drawing.SystemColors.Highlight;
            this.radioButtonPrevioEspanol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonPrevioEspanol.Location = new System.Drawing.Point(7, 20);
            this.radioButtonPrevioEspanol.Name = "radioButtonPrevioEspanol";
            this.radioButtonPrevioEspanol.Size = new System.Drawing.Size(63, 17);
            this.radioButtonPrevioEspanol.TabIndex = 65;
            this.radioButtonPrevioEspanol.TabStop = true;
            this.radioButtonPrevioEspanol.Text = "Español";
            this.radioButtonPrevioEspanol.UseVisualStyleBackColor = false;
            this.radioButtonPrevioEspanol.CheckedChanged += new System.EventHandler(this.radioButtonPrevioEspanol_CheckedChanged);
            // 
            // Forma_Cotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 461);
            this.Controls.Add(this.groupBoxPrevio);
            this.Controls.Add(this.buttonCopiarCotizacion);
            this.Controls.Add(this.comboBoxNombreCliente);
            this.Controls.Add(this.comboBoxAtencionCopia);
            this.Controls.Add(this.comboBoxAtencion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOrdenTrabajo);
            this.Controls.Add(this.textBoxProyecto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePickerFechaEntrega);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerFechaActual);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxAtencionCopia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAgregarPartida);
            this.Controls.Add(this.buttonEliminarPartida);
            this.Controls.Add(this.buttonPartidas);
            this.Controls.Add(this.comboBoxCodigoCotizaciones);
            this.Controls.Add(this.dataGridViewPartidasCotizacion);
            this.Controls.Add(this.textBoxAtencion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombreCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCodigoCotizaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonBorrarBasedeDatos);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonGuardarBasedeDatos);
            this.Controls.Add(this.buttonBuscarCotizacion);
            this.Controls.Add(this.buttonEliminarCotizacion);
            this.Controls.Add(this.buttonAgregarCotizacion);
            this.Controls.Add(this.buttonModificarCotizacion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Forma_Cotizaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotizaciones";
            this.Load += new System.EventHandler(this.Forma_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartidasCotizacion)).EndInit();
            this.groupBoxPrevio.ResumeLayout(false);
            this.groupBoxPrevio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBuscarCotizacion;
        private System.Windows.Forms.Button buttonEliminarCotizacion;
        private System.Windows.Forms.Button buttonAgregarCotizacion;
        private System.Windows.Forms.Button buttonModificarCotizacion;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonBorrarBasedeDatos;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonGuardarBasedeDatos;
        private System.Windows.Forms.Timer timerAgregarCotizacion;
        private System.Windows.Forms.TextBox textBoxOrdenTrabajo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxProyecto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAtencion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodigoCotizaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewPartidasCotizacion;
        private System.Windows.Forms.ComboBox comboBoxCodigoCotizaciones;
        private System.Windows.Forms.Timer timerModificarClientes;
        private System.Windows.Forms.Button buttonPartidas;
        private System.Windows.Forms.Button buttonEliminarPartida;
        private System.Windows.Forms.Button buttonAgregarPartida;
        private System.Windows.Forms.TextBox textBoxAtencionCopia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaActual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaEntrega;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxAtencion;
        private System.Windows.Forms.ComboBox comboBoxAtencionCopia;
        private System.Windows.Forms.ComboBox comboBoxNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parte_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrpcion_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe_partida;
        private System.Windows.Forms.Button buttonCopiarCotizacion;
        private System.Windows.Forms.Button buttonWordPrevio;
        private System.Windows.Forms.GroupBox groupBoxPrevio;
        private System.Windows.Forms.RadioButton radioButtonPrevioIngles;
        private System.Windows.Forms.RadioButton radioButtonPrevioEspanol;
    }
}