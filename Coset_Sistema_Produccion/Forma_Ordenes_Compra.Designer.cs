namespace Coset_Sistema_Produccion
{
    partial class Forma_Ordenes_Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma_Ordenes_Compra));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonBuscarOrdenCompra = new System.Windows.Forms.Button();
            this.buttonEliminarCotizacion = new System.Windows.Forms.Button();
            this.buttonAgregarCotizacion = new System.Windows.Forms.Button();
            this.buttonModificarCotizacion = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonBorrarBasedeDatos = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonGuardarBasedeDatos = new System.Windows.Forms.Button();
            this.timerAgregarOrdenCompra = new System.Windows.Forms.Timer(this.components);
            this.textBoxRazonSocialProveedor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxCorreoContacto = new System.Windows.Forms.TextBox();
            this.textBoxNombreProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRequisitor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigoOrdenCompra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewPartidasOrdenCompra = new System.Windows.Forms.DataGridView();
            this.comboBoxCodigoOrdenCompra = new System.Windows.Forms.ComboBox();
            this.timerModificarClientes = new System.Windows.Forms.Timer(this.components);
            this.buttonPartidas = new System.Windows.Forms.Button();
            this.buttonEliminarPartida = new System.Windows.Forms.Button();
            this.buttonAgregarPartida = new System.Windows.Forms.Button();
            this.textBoxCotizado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaActual = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxNombreProveedor = new System.Windows.Forms.ComboBox();
            this.comboBoxCotizado = new System.Windows.Forms.ComboBox();
            this.comboBoxRealizado = new System.Windows.Forms.ComboBox();
            this.buttonWordPrevio = new System.Windows.Forms.Button();
            this.textBoxCotizacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDolares = new System.Windows.Forms.RadioButton();
            this.radioButtonPesos = new System.Windows.Forms.RadioButton();
            this.labeldivisa = new System.Windows.Forms.Label();
            this.textBoxDivisa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCondicionPago = new System.Windows.Forms.ComboBox();
            this.textBoxCondicionPago = new System.Windows.Forms.TextBox();
            this.Codigo_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requisicion_compra = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Cantidad_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parte_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrpcion_partida = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UnidadMedida_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proyecto_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartidasOrdenCompra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1334, 582);
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
            // buttonEliminarCotizacion
            // 
            this.buttonEliminarCotizacion.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarCotizacion.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminarCotizacion.Image")));
            this.buttonEliminarCotizacion.Location = new System.Drawing.Point(671, 24);
            this.buttonEliminarCotizacion.Name = "buttonEliminarCotizacion";
            this.buttonEliminarCotizacion.Size = new System.Drawing.Size(79, 74);
            this.buttonEliminarCotizacion.TabIndex = 30;
            this.buttonEliminarCotizacion.Text = "Eliminar";
            this.buttonEliminarCotizacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEliminarCotizacion.UseVisualStyleBackColor = true;
            this.buttonEliminarCotizacion.Click += new System.EventHandler(this.buttonEliminarCotizacion_Click);
            // 
            // buttonAgregarCotizacion
            // 
            this.buttonAgregarCotizacion.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarCotizacion.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregarCotizacion.Image")));
            this.buttonAgregarCotizacion.Location = new System.Drawing.Point(586, 24);
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
            this.buttonModificarCotizacion.Location = new System.Drawing.Point(501, 24);
            this.buttonModificarCotizacion.Name = "buttonModificarCotizacion";
            this.buttonModificarCotizacion.Size = new System.Drawing.Size(79, 74);
            this.buttonModificarCotizacion.TabIndex = 28;
            this.buttonModificarCotizacion.Text = "Modificar";
            this.buttonModificarCotizacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonModificarCotizacion.UseVisualStyleBackColor = true;
            this.buttonModificarCotizacion.Click += new System.EventHandler(this.buttonModificarCotizacion_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AutoSize = true;
            this.buttonCancelar.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.Location = new System.Drawing.Point(1249, 347);
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
            this.buttonBorrarBasedeDatos.Location = new System.Drawing.Point(1249, 259);
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
            this.buttonHome.Location = new System.Drawing.Point(1249, 427);
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
            this.buttonGuardarBasedeDatos.Location = new System.Drawing.Point(1249, 267);
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
            this.timerAgregarOrdenCompra.Tick += new System.EventHandler(this.timerAgregarCliente_Tick);
            // 
            // textBoxRazonSocialProveedor
            // 
            this.textBoxRazonSocialProveedor.Enabled = false;
            this.textBoxRazonSocialProveedor.Location = new System.Drawing.Point(691, 255);
            this.textBoxRazonSocialProveedor.Multiline = true;
            this.textBoxRazonSocialProveedor.Name = "textBoxRazonSocialProveedor";
            this.textBoxRazonSocialProveedor.Size = new System.Drawing.Size(310, 33);
            this.textBoxRazonSocialProveedor.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(106, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 16);
            this.label12.TabIndex = 45;
            this.label12.Text = "Codigo Cotizacion";
            // 
            // textBoxCorreoContacto
            // 
            this.textBoxCorreoContacto.Enabled = false;
            this.textBoxCorreoContacto.Location = new System.Drawing.Point(691, 299);
            this.textBoxCorreoContacto.Name = "textBoxCorreoContacto";
            this.textBoxCorreoContacto.Size = new System.Drawing.Size(310, 20);
            this.textBoxCorreoContacto.TabIndex = 46;
            // 
            // textBoxNombreProveedor
            // 
            this.textBoxNombreProveedor.Enabled = false;
            this.textBoxNombreProveedor.Location = new System.Drawing.Point(239, 189);
            this.textBoxNombreProveedor.Name = "textBoxNombreProveedor";
            this.textBoxNombreProveedor.Size = new System.Drawing.Size(246, 20);
            this.textBoxNombreProveedor.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(106, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Nombre Proveedor";
            // 
            // textBoxRequisitor
            // 
            this.textBoxRequisitor.Enabled = false;
            this.textBoxRequisitor.Location = new System.Drawing.Point(239, 244);
            this.textBoxRequisitor.Name = "textBoxRequisitor";
            this.textBoxRequisitor.Size = new System.Drawing.Size(246, 20);
            this.textBoxRequisitor.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(106, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Realizado Por";
            // 
            // textBoxCodigoOrdenCompra
            // 
            this.textBoxCodigoOrdenCompra.Enabled = false;
            this.textBoxCodigoOrdenCompra.Location = new System.Drawing.Point(239, 134);
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
            this.Numero_partida,
            this.Requisicion_compra,
            this.Cantidad_partida,
            this.Parte_partida,
            this.Descrpcion_partida,
            this.UnidadMedida_compra,
            this.Proyecto_compra,
            this.Precio_partida,
            this.Importe_partida});
            this.dataGridViewPartidasOrdenCompra.Enabled = false;
            this.dataGridViewPartidasOrdenCompra.Location = new System.Drawing.Point(97, 347);
            this.dataGridViewPartidasOrdenCompra.Name = "dataGridViewPartidasOrdenCompra";
            this.dataGridViewPartidasOrdenCompra.Size = new System.Drawing.Size(1146, 202);
            this.dataGridViewPartidasOrdenCompra.TabIndex = 48;
            this.dataGridViewPartidasOrdenCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPartidasOrdenCompra_CellClick);
            this.dataGridViewPartidasOrdenCompra.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPartidasOrdenCompra_CellEndEdit);
            // 
            // comboBoxCodigoOrdenCompra
            // 
            this.comboBoxCodigoOrdenCompra.FormattingEnabled = true;
            this.comboBoxCodigoOrdenCompra.Location = new System.Drawing.Point(239, 135);
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
            // buttonPartidas
            // 
            this.buttonPartidas.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPartidas.Image = ((System.Drawing.Image)(resources.GetObject("buttonPartidas.Image")));
            this.buttonPartidas.Location = new System.Drawing.Point(756, 24);
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
            this.buttonEliminarPartida.Location = new System.Drawing.Point(12, 427);
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
            this.buttonAgregarPartida.Location = new System.Drawing.Point(12, 347);
            this.buttonAgregarPartida.Name = "buttonAgregarPartida";
            this.buttonAgregarPartida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAgregarPartida.Size = new System.Drawing.Size(79, 74);
            this.buttonAgregarPartida.TabIndex = 53;
            this.buttonAgregarPartida.Text = "Agregar";
            this.buttonAgregarPartida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAgregarPartida.UseVisualStyleBackColor = true;
            this.buttonAgregarPartida.Visible = false;
            this.buttonAgregarPartida.Click += new System.EventHandler(this.buttonAgregarPartida_Click);
            // 
            // textBoxCotizado
            // 
            this.textBoxCotizado.Enabled = false;
            this.textBoxCotizado.Location = new System.Drawing.Point(239, 219);
            this.textBoxCotizado.Name = "textBoxCotizado";
            this.textBoxCotizado.Size = new System.Drawing.Size(246, 20);
            this.textBoxCotizado.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(106, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 54;
            this.label5.Text = "Cotizado Por";
            // 
            // dateTimePickerFechaActual
            // 
            this.dateTimePickerFechaActual.Enabled = false;
            this.dateTimePickerFechaActual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaActual.Location = new System.Drawing.Point(239, 273);
            this.dateTimePickerFechaActual.Name = "dateTimePickerFechaActual";
            this.dateTimePickerFechaActual.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerFechaActual.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(106, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "Fecha Actual";
            // 
            // comboBoxNombreProveedor
            // 
            this.comboBoxNombreProveedor.FormattingEnabled = true;
            this.comboBoxNombreProveedor.Location = new System.Drawing.Point(239, 188);
            this.comboBoxNombreProveedor.Name = "comboBoxNombreProveedor";
            this.comboBoxNombreProveedor.Size = new System.Drawing.Size(246, 21);
            this.comboBoxNombreProveedor.TabIndex = 60;
            this.comboBoxNombreProveedor.Visible = false;
            this.comboBoxNombreProveedor.SelectedIndexChanged += new System.EventHandler(this.comboBoxNombreProveedor_SelectedIndexChanged);
            // 
            // comboBoxCotizado
            // 
            this.comboBoxCotizado.FormattingEnabled = true;
            this.comboBoxCotizado.Location = new System.Drawing.Point(239, 218);
            this.comboBoxCotizado.Name = "comboBoxCotizado";
            this.comboBoxCotizado.Size = new System.Drawing.Size(246, 21);
            this.comboBoxCotizado.TabIndex = 61;
            this.comboBoxCotizado.Visible = false;
            this.comboBoxCotizado.SelectedIndexChanged += new System.EventHandler(this.comboBoxCotizado_SelectedIndexChanged);
            // 
            // comboBoxRealizado
            // 
            this.comboBoxRealizado.FormattingEnabled = true;
            this.comboBoxRealizado.Location = new System.Drawing.Point(239, 244);
            this.comboBoxRealizado.Name = "comboBoxRealizado";
            this.comboBoxRealizado.Size = new System.Drawing.Size(246, 21);
            this.comboBoxRealizado.TabIndex = 62;
            this.comboBoxRealizado.Visible = false;
            // 
            // buttonWordPrevio
            // 
            this.buttonWordPrevio.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWordPrevio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonWordPrevio.Image = ((System.Drawing.Image)(resources.GetObject("buttonWordPrevio.Image")));
            this.buttonWordPrevio.Location = new System.Drawing.Point(331, 24);
            this.buttonWordPrevio.Name = "buttonWordPrevio";
            this.buttonWordPrevio.Size = new System.Drawing.Size(79, 74);
            this.buttonWordPrevio.TabIndex = 64;
            this.buttonWordPrevio.Text = "Previo";
            this.buttonWordPrevio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonWordPrevio.UseVisualStyleBackColor = true;
            this.buttonWordPrevio.Visible = false;
            this.buttonWordPrevio.Click += new System.EventHandler(this.buttonWordPrevio_Click);
            // 
            // textBoxCotizacion
            // 
            this.textBoxCotizacion.Enabled = false;
            this.textBoxCotizacion.Location = new System.Drawing.Point(239, 162);
            this.textBoxCotizacion.Name = "textBoxCotizacion";
            this.textBoxCotizacion.Size = new System.Drawing.Size(121, 20);
            this.textBoxCotizacion.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(523, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 68;
            this.label3.Text = "Razón Social Proveedor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(523, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 16);
            this.label8.TabIndex = 69;
            this.label8.Text = "Correo Electronico Contacto";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.radioButtonDolares);
            this.groupBox1.Controls.Add(this.radioButtonPesos);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(691, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 65);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Moneda";
            // 
            // radioButtonDolares
            // 
            this.radioButtonDolares.AutoSize = true;
            this.radioButtonDolares.BackColor = System.Drawing.SystemColors.Highlight;
            this.radioButtonDolares.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButtonDolares.BackgroundImage")));
            this.radioButtonDolares.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonDolares.ForeColor = System.Drawing.Color.White;
            this.radioButtonDolares.Location = new System.Drawing.Point(7, 42);
            this.radioButtonDolares.Name = "radioButtonDolares";
            this.radioButtonDolares.Size = new System.Drawing.Size(61, 17);
            this.radioButtonDolares.TabIndex = 66;
            this.radioButtonDolares.Text = "Dolares";
            this.radioButtonDolares.UseVisualStyleBackColor = false;
            this.radioButtonDolares.CheckedChanged += new System.EventHandler(this.radioButtonDolares_CheckedChanged);
            // 
            // radioButtonPesos
            // 
            this.radioButtonPesos.AutoSize = true;
            this.radioButtonPesos.BackColor = System.Drawing.Color.White;
            this.radioButtonPesos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButtonPesos.BackgroundImage")));
            this.radioButtonPesos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonPesos.Checked = true;
            this.radioButtonPesos.ForeColor = System.Drawing.Color.White;
            this.radioButtonPesos.Location = new System.Drawing.Point(7, 19);
            this.radioButtonPesos.Name = "radioButtonPesos";
            this.radioButtonPesos.Size = new System.Drawing.Size(54, 17);
            this.radioButtonPesos.TabIndex = 65;
            this.radioButtonPesos.TabStop = true;
            this.radioButtonPesos.Text = "Pesos";
            this.radioButtonPesos.UseVisualStyleBackColor = false;
            this.radioButtonPesos.CheckedChanged += new System.EventHandler(this.radioButtonPesos_CheckedChanged);
            // 
            // labeldivisa
            // 
            this.labeldivisa.AutoSize = true;
            this.labeldivisa.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldivisa.Image = ((System.Drawing.Image)(resources.GetObject("labeldivisa.Image")));
            this.labeldivisa.Location = new System.Drawing.Point(523, 223);
            this.labeldivisa.Name = "labeldivisa";
            this.labeldivisa.Size = new System.Drawing.Size(41, 16);
            this.labeldivisa.TabIndex = 71;
            this.labeldivisa.Text = "Divisa";
            this.labeldivisa.Visible = false;
            // 
            // textBoxDivisa
            // 
            this.textBoxDivisa.Enabled = false;
            this.textBoxDivisa.Location = new System.Drawing.Point(691, 223);
            this.textBoxDivisa.Name = "textBoxDivisa";
            this.textBoxDivisa.Size = new System.Drawing.Size(124, 20);
            this.textBoxDivisa.TabIndex = 72;
            this.textBoxDivisa.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(106, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 73;
            this.label7.Text = "Condicion Pago";
            // 
            // comboBoxCondicionPago
            // 
            this.comboBoxCondicionPago.AutoCompleteCustomSource.AddRange(new string[] {
            "Credito",
            "Efectivo"});
            this.comboBoxCondicionPago.FormattingEnabled = true;
            this.comboBoxCondicionPago.Items.AddRange(new object[] {
            "Credito",
            "Contado"});
            this.comboBoxCondicionPago.Location = new System.Drawing.Point(239, 299);
            this.comboBoxCondicionPago.Name = "comboBoxCondicionPago";
            this.comboBoxCondicionPago.Size = new System.Drawing.Size(246, 21);
            this.comboBoxCondicionPago.TabIndex = 75;
            this.comboBoxCondicionPago.Visible = false;
            // 
            // textBoxCondicionPago
            // 
            this.textBoxCondicionPago.Enabled = false;
            this.textBoxCondicionPago.Location = new System.Drawing.Point(239, 299);
            this.textBoxCondicionPago.Name = "textBoxCondicionPago";
            this.textBoxCondicionPago.Size = new System.Drawing.Size(246, 20);
            this.textBoxCondicionPago.TabIndex = 74;
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
            this.Numero_partida.Width = 50;
            // 
            // Requisicion_compra
            // 
            this.Requisicion_compra.HeaderText = "Requisicion";
            this.Requisicion_compra.Name = "Requisicion_compra";
            this.Requisicion_compra.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Requisicion_compra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.Parte_partida.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Descrpcion_partida
            // 
            this.Descrpcion_partida.HeaderText = "Descripcion";
            this.Descrpcion_partida.Name = "Descrpcion_partida";
            this.Descrpcion_partida.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Descrpcion_partida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Descrpcion_partida.Width = 400;
            // 
            // UnidadMedida_compra
            // 
            this.UnidadMedida_compra.HeaderText = "Unidad Medida";
            this.UnidadMedida_compra.Name = "UnidadMedida_compra";
            // 
            // Proyecto_compra
            // 
            this.Proyecto_compra.HeaderText = "Proyecto";
            this.Proyecto_compra.Name = "Proyecto_compra";
            // 
            // Precio_partida
            // 
            this.Precio_partida.HeaderText = "Precio";
            this.Precio_partida.Name = "Precio_partida";
            // 
            // Importe_partida
            // 
            this.Importe_partida.HeaderText = "Total";
            this.Importe_partida.Name = "Importe_partida";
            this.Importe_partida.ReadOnly = true;
            // 
            // Forma_Ordenes_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 582);
            this.Controls.Add(this.comboBoxCondicionPago);
            this.Controls.Add(this.textBoxCondicionPago);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDivisa);
            this.Controls.Add(this.labeldivisa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonWordPrevio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCotizacion);
            this.Controls.Add(this.comboBoxRealizado);
            this.Controls.Add(this.comboBoxCotizado);
            this.Controls.Add(this.comboBoxNombreProveedor);
            this.Controls.Add(this.textBoxRazonSocialProveedor);
            this.Controls.Add(this.textBoxCorreoContacto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePickerFechaActual);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCotizado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAgregarPartida);
            this.Controls.Add(this.buttonEliminarPartida);
            this.Controls.Add(this.buttonPartidas);
            this.Controls.Add(this.comboBoxCodigoOrdenCompra);
            this.Controls.Add(this.dataGridViewPartidasOrdenCompra);
            this.Controls.Add(this.textBoxNombreProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRequisitor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCodigoOrdenCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonBorrarBasedeDatos);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonGuardarBasedeDatos);
            this.Controls.Add(this.buttonBuscarOrdenCompra);
            this.Controls.Add(this.buttonEliminarCotizacion);
            this.Controls.Add(this.buttonAgregarCotizacion);
            this.Controls.Add(this.buttonModificarCotizacion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Forma_Ordenes_Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes De Compra";
            this.Load += new System.EventHandler(this.Forma_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartidasOrdenCompra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBuscarOrdenCompra;
        private System.Windows.Forms.Button buttonEliminarCotizacion;
        private System.Windows.Forms.Button buttonAgregarCotizacion;
        private System.Windows.Forms.Button buttonModificarCotizacion;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonBorrarBasedeDatos;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonGuardarBasedeDatos;
        private System.Windows.Forms.Timer timerAgregarOrdenCompra;
        private System.Windows.Forms.TextBox textBoxRazonSocialProveedor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxCorreoContacto;
        private System.Windows.Forms.TextBox textBoxNombreProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRequisitor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodigoOrdenCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewPartidasOrdenCompra;
        private System.Windows.Forms.ComboBox comboBoxCodigoOrdenCompra;
        private System.Windows.Forms.Timer timerModificarClientes;
        private System.Windows.Forms.Button buttonPartidas;
        private System.Windows.Forms.Button buttonEliminarPartida;
        private System.Windows.Forms.Button buttonAgregarPartida;
        private System.Windows.Forms.TextBox textBoxCotizado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaActual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxNombreProveedor;
        private System.Windows.Forms.ComboBox comboBoxCotizado;
        private System.Windows.Forms.ComboBox comboBoxRealizado;
        private System.Windows.Forms.Button buttonWordPrevio;
        private System.Windows.Forms.TextBox textBoxCotizacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDolares;
        private System.Windows.Forms.RadioButton radioButtonPesos;
        private System.Windows.Forms.Label labeldivisa;
        private System.Windows.Forms.TextBox textBoxDivisa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxCondicionPago;
        private System.Windows.Forms.TextBox textBoxCondicionPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_partida;
        private System.Windows.Forms.DataGridViewComboBoxColumn Requisicion_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parte_partida;
        private System.Windows.Forms.DataGridViewComboBoxColumn Descrpcion_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadMedida_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proyecto_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe_partida;
    }
}