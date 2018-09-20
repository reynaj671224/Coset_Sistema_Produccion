namespace Coset_Sistema_Produccion
{
    partial class Forma_Materiales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma_Materiales));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonModificarMaterial = new System.Windows.Forms.Button();
            this.buttonAgregarMaterial = new System.Windows.Forms.Button();
            this.buttonBusquedaBaseDatos = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonGuardarBasedeDatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigoMaterial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCodigoProveedor = new System.Windows.Forms.TextBox();
            this.buttonBorrarBasedeDatos = new System.Windows.Forms.Button();
            this.timerAgregarMaterial = new System.Windows.Forms.Timer(this.components);
            this.comboBoxCodigoMaterial = new System.Windows.Forms.ComboBox();
            this.timerBusquedaAgregar = new System.Windows.Forms.Timer(this.components);
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.timerEliminaempleado = new System.Windows.Forms.Timer(this.components);
            this.buttonBuscarMaterial = new System.Windows.Forms.Button();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUnidadMedida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMinimo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMaximo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNombreFoto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBoxMaterial = new System.Windows.Forms.PictureBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxUbicacion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.groupBoxModeda = new System.Windows.Forms.GroupBox();
            this.radioButtonDolares = new System.Windows.Forms.RadioButton();
            this.radioButtonPesos = new System.Windows.Forms.RadioButton();
            this.groupBoxGenericos = new System.Windows.Forms.GroupBox();
            this.radioButtonNoGenericoMaterial = new System.Windows.Forms.RadioButton();
            this.radioButtonGenericoMaterial = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaterial)).BeginInit();
            this.groupBoxModeda.SuspendLayout();
            this.groupBoxGenericos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(782, 645);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonModificarMaterial
            // 
            this.buttonModificarMaterial.AutoSize = true;
            this.buttonModificarMaterial.BackColor = System.Drawing.Color.White;
            this.buttonModificarMaterial.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarMaterial.Image = ((System.Drawing.Image)(resources.GetObject("buttonModificarMaterial.Image")));
            this.buttonModificarMaterial.Location = new System.Drawing.Point(314, 12);
            this.buttonModificarMaterial.Name = "buttonModificarMaterial";
            this.buttonModificarMaterial.Size = new System.Drawing.Size(79, 74);
            this.buttonModificarMaterial.TabIndex = 1;
            this.buttonModificarMaterial.Text = "Modificar";
            this.buttonModificarMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonModificarMaterial.UseVisualStyleBackColor = false;
            this.buttonModificarMaterial.Click += new System.EventHandler(this.buttonModificarMaterial_Click);
            // 
            // buttonAgregarMaterial
            // 
            this.buttonAgregarMaterial.AutoSize = true;
            this.buttonAgregarMaterial.BackColor = System.Drawing.Color.White;
            this.buttonAgregarMaterial.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarMaterial.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregarMaterial.Image")));
            this.buttonAgregarMaterial.Location = new System.Drawing.Point(399, 12);
            this.buttonAgregarMaterial.Name = "buttonAgregarMaterial";
            this.buttonAgregarMaterial.Size = new System.Drawing.Size(79, 74);
            this.buttonAgregarMaterial.TabIndex = 2;
            this.buttonAgregarMaterial.Text = "Agregar";
            this.buttonAgregarMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAgregarMaterial.UseVisualStyleBackColor = false;
            this.buttonAgregarMaterial.Click += new System.EventHandler(this.buttonAgregarMaterial_Click);
            // 
            // buttonBusquedaBaseDatos
            // 
            this.buttonBusquedaBaseDatos.BackColor = System.Drawing.Color.White;
            this.buttonBusquedaBaseDatos.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBusquedaBaseDatos.Image = ((System.Drawing.Image)(resources.GetObject("buttonBusquedaBaseDatos.Image")));
            this.buttonBusquedaBaseDatos.Location = new System.Drawing.Point(484, 12);
            this.buttonBusquedaBaseDatos.Name = "buttonBusquedaBaseDatos";
            this.buttonBusquedaBaseDatos.Size = new System.Drawing.Size(79, 74);
            this.buttonBusquedaBaseDatos.TabIndex = 3;
            this.buttonBusquedaBaseDatos.Text = "Buscar";
            this.buttonBusquedaBaseDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBusquedaBaseDatos.UseVisualStyleBackColor = false;
            this.buttonBusquedaBaseDatos.Visible = false;
            this.buttonBusquedaBaseDatos.Click += new System.EventHandler(this.buttonBusquedaBaseDatos_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.AutoSize = true;
            this.buttonHome.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(668, 537);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(79, 74);
            this.buttonHome.TabIndex = 5;
            this.buttonHome.Text = "Regresar";
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // buttonGuardarBasedeDatos
            // 
            this.buttonGuardarBasedeDatos.AutoSize = true;
            this.buttonGuardarBasedeDatos.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarBasedeDatos.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardarBasedeDatos.Image")));
            this.buttonGuardarBasedeDatos.Location = new System.Drawing.Point(668, 377);
            this.buttonGuardarBasedeDatos.Name = "buttonGuardarBasedeDatos";
            this.buttonGuardarBasedeDatos.Size = new System.Drawing.Size(79, 74);
            this.buttonGuardarBasedeDatos.TabIndex = 4;
            this.buttonGuardarBasedeDatos.Text = "Guardar";
            this.buttonGuardarBasedeDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonGuardarBasedeDatos.UseVisualStyleBackColor = true;
            this.buttonGuardarBasedeDatos.Visible = false;
            this.buttonGuardarBasedeDatos.Click += new System.EventHandler(this.buttonGuardarBasedeDatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(43, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo Material";
            // 
            // textBoxCodigoMaterial
            // 
            this.textBoxCodigoMaterial.Enabled = false;
            this.textBoxCodigoMaterial.Location = new System.Drawing.Point(173, 110);
            this.textBoxCodigoMaterial.Name = "textBoxCodigoMaterial";
            this.textBoxCodigoMaterial.Size = new System.Drawing.Size(149, 20);
            this.textBoxCodigoMaterial.TabIndex = 7;
            this.textBoxCodigoMaterial.TextChanged += new System.EventHandler(this.textBoxCodigoMaterial_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(43, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Codigo Proveedor";
            // 
            // textBoxCodigoProveedor
            // 
            this.textBoxCodigoProveedor.Enabled = false;
            this.textBoxCodigoProveedor.Location = new System.Drawing.Point(172, 139);
            this.textBoxCodigoProveedor.Name = "textBoxCodigoProveedor";
            this.textBoxCodigoProveedor.Size = new System.Drawing.Size(149, 20);
            this.textBoxCodigoProveedor.TabIndex = 9;
            this.textBoxCodigoProveedor.TextChanged += new System.EventHandler(this.textBoxCodigoProveedor_TextChanged);
            // 
            // buttonBorrarBasedeDatos
            // 
            this.buttonBorrarBasedeDatos.AutoSize = true;
            this.buttonBorrarBasedeDatos.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrarBasedeDatos.Image = ((System.Drawing.Image)(resources.GetObject("buttonBorrarBasedeDatos.Image")));
            this.buttonBorrarBasedeDatos.Location = new System.Drawing.Point(668, 361);
            this.buttonBorrarBasedeDatos.Name = "buttonBorrarBasedeDatos";
            this.buttonBorrarBasedeDatos.Size = new System.Drawing.Size(79, 74);
            this.buttonBorrarBasedeDatos.TabIndex = 20;
            this.buttonBorrarBasedeDatos.Text = "Eliminar";
            this.buttonBorrarBasedeDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBorrarBasedeDatos.UseVisualStyleBackColor = true;
            this.buttonBorrarBasedeDatos.Visible = false;
            this.buttonBorrarBasedeDatos.Click += new System.EventHandler(this.buttonBorrarBasedeDatos_Click);
            // 
            // timerAgregarMaterial
            // 
            this.timerAgregarMaterial.Interval = 1000;
            this.timerAgregarMaterial.Tick += new System.EventHandler(this.timerAgregarMaterial_Tick);
            // 
            // comboBoxCodigoMaterial
            // 
            this.comboBoxCodigoMaterial.FormattingEnabled = true;
            this.comboBoxCodigoMaterial.Location = new System.Drawing.Point(172, 108);
            this.comboBoxCodigoMaterial.Name = "comboBoxCodigoMaterial";
            this.comboBoxCodigoMaterial.Size = new System.Drawing.Size(150, 21);
            this.comboBoxCodigoMaterial.TabIndex = 25;
            this.comboBoxCodigoMaterial.Visible = false;
            // 
            // timerBusquedaAgregar
            // 
            this.timerBusquedaAgregar.Interval = 1000;
            this.timerBusquedaAgregar.Tick += new System.EventHandler(this.timerBusquedaAgregar_Tick);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AutoSize = true;
            this.buttonCancelar.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.Location = new System.Drawing.Point(668, 457);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(79, 74);
            this.buttonCancelar.TabIndex = 26;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Visible = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // timerEliminaempleado
            // 
            this.timerEliminaempleado.Interval = 1000;
            this.timerEliminaempleado.Tick += new System.EventHandler(this.timerEliminaempleado_Tick);
            // 
            // buttonBuscarMaterial
            // 
            this.buttonBuscarMaterial.BackColor = System.Drawing.Color.White;
            this.buttonBuscarMaterial.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarMaterial.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarMaterial.Image")));
            this.buttonBuscarMaterial.Location = new System.Drawing.Point(229, 12);
            this.buttonBuscarMaterial.Name = "buttonBuscarMaterial";
            this.buttonBuscarMaterial.Size = new System.Drawing.Size(79, 74);
            this.buttonBuscarMaterial.TabIndex = 27;
            this.buttonBuscarMaterial.Text = "Visualizar";
            this.buttonBuscarMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBuscarMaterial.UseVisualStyleBackColor = false;
            this.buttonBuscarMaterial.Click += new System.EventHandler(this.buttonBuscarempleado_Click);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Enabled = false;
            this.textBoxDescripcion.Location = new System.Drawing.Point(172, 168);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(446, 20);
            this.textBoxDescripcion.TabIndex = 29;
            this.textBoxDescripcion.TextChanged += new System.EventHandler(this.textBoxDescripcion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(43, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Descripcion";
            // 
            // textBoxUnidadMedida
            // 
            this.textBoxUnidadMedida.Enabled = false;
            this.textBoxUnidadMedida.Location = new System.Drawing.Point(458, 116);
            this.textBoxUnidadMedida.Name = "textBoxUnidadMedida";
            this.textBoxUnidadMedida.Size = new System.Drawing.Size(160, 20);
            this.textBoxUnidadMedida.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(344, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Unidad de Medida";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Enabled = false;
            this.textBoxCantidad.Location = new System.Drawing.Point(458, 142);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(160, 20);
            this.textBoxCantidad.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(344, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Cantidad";
            // 
            // textBoxMinimo
            // 
            this.textBoxMinimo.Enabled = false;
            this.textBoxMinimo.Location = new System.Drawing.Point(172, 197);
            this.textBoxMinimo.Name = "textBoxMinimo";
            this.textBoxMinimo.Size = new System.Drawing.Size(149, 20);
            this.textBoxMinimo.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(43, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Minima Cantidad";
            // 
            // textBoxMaximo
            // 
            this.textBoxMaximo.Enabled = false;
            this.textBoxMaximo.Location = new System.Drawing.Point(172, 226);
            this.textBoxMaximo.Name = "textBoxMaximo";
            this.textBoxMaximo.Size = new System.Drawing.Size(150, 20);
            this.textBoxMaximo.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(43, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Maxima Cantidad";
            // 
            // textBoxNombreFoto
            // 
            this.textBoxNombreFoto.Enabled = false;
            this.textBoxNombreFoto.Location = new System.Drawing.Point(172, 285);
            this.textBoxNombreFoto.Name = "textBoxNombreFoto";
            this.textBoxNombreFoto.Size = new System.Drawing.Size(150, 20);
            this.textBoxNombreFoto.TabIndex = 39;
            this.textBoxNombreFoto.Click += new System.EventHandler(this.textBoxNombreFoto_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(43, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Nombre Foto";
            // 
            // pictureBoxMaterial
            // 
            this.pictureBoxMaterial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxMaterial.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMaterial.Image")));
            this.pictureBoxMaterial.Location = new System.Drawing.Point(173, 411);
            this.pictureBoxMaterial.Name = "pictureBoxMaterial";
            this.pictureBoxMaterial.Size = new System.Drawing.Size(379, 222);
            this.pictureBoxMaterial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMaterial.TabIndex = 40;
            this.pictureBoxMaterial.TabStop = false;
            this.pictureBoxMaterial.Visible = false;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Enabled = false;
            this.textBoxMarca.Location = new System.Drawing.Point(458, 202);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(160, 20);
            this.textBoxMarca.TabIndex = 42;
            this.textBoxMarca.TextChanged += new System.EventHandler(this.textBoxMarca_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(344, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Marca";
            // 
            // textBoxUbicacion
            // 
            this.textBoxUbicacion.Enabled = false;
            this.textBoxUbicacion.Location = new System.Drawing.Point(172, 255);
            this.textBoxUbicacion.Name = "textBoxUbicacion";
            this.textBoxUbicacion.Size = new System.Drawing.Size(150, 20);
            this.textBoxUbicacion.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(43, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 43;
            this.label10.Text = "Ubicacion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(344, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 45;
            this.label11.Text = "Precio";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Enabled = false;
            this.textBoxPrecio.Location = new System.Drawing.Point(458, 228);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(160, 20);
            this.textBoxPrecio.TabIndex = 46;
            // 
            // groupBoxModeda
            // 
            this.groupBoxModeda.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxModeda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxModeda.BackgroundImage")));
            this.groupBoxModeda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxModeda.Controls.Add(this.radioButtonDolares);
            this.groupBoxModeda.Controls.Add(this.radioButtonPesos);
            this.groupBoxModeda.Enabled = false;
            this.groupBoxModeda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxModeda.Location = new System.Drawing.Point(460, 255);
            this.groupBoxModeda.Name = "groupBoxModeda";
            this.groupBoxModeda.Size = new System.Drawing.Size(160, 65);
            this.groupBoxModeda.TabIndex = 71;
            this.groupBoxModeda.TabStop = false;
            this.groupBoxModeda.Text = "Tipo Moneda";
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
            // 
            // groupBoxGenericos
            // 
            this.groupBoxGenericos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxGenericos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxGenericos.BackgroundImage")));
            this.groupBoxGenericos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxGenericos.Controls.Add(this.radioButtonNoGenericoMaterial);
            this.groupBoxGenericos.Controls.Add(this.radioButtonGenericoMaterial);
            this.groupBoxGenericos.Enabled = false;
            this.groupBoxGenericos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxGenericos.Location = new System.Drawing.Point(460, 330);
            this.groupBoxGenericos.Name = "groupBoxGenericos";
            this.groupBoxGenericos.Size = new System.Drawing.Size(160, 65);
            this.groupBoxGenericos.TabIndex = 72;
            this.groupBoxGenericos.TabStop = false;
            this.groupBoxGenericos.Text = "Material Generico";
            // 
            // radioButtonNoGenericoMaterial
            // 
            this.radioButtonNoGenericoMaterial.AutoSize = true;
            this.radioButtonNoGenericoMaterial.BackColor = System.Drawing.SystemColors.Highlight;
            this.radioButtonNoGenericoMaterial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButtonNoGenericoMaterial.BackgroundImage")));
            this.radioButtonNoGenericoMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonNoGenericoMaterial.Checked = true;
            this.radioButtonNoGenericoMaterial.ForeColor = System.Drawing.Color.White;
            this.radioButtonNoGenericoMaterial.Location = new System.Drawing.Point(7, 19);
            this.radioButtonNoGenericoMaterial.Name = "radioButtonNoGenericoMaterial";
            this.radioButtonNoGenericoMaterial.Size = new System.Drawing.Size(85, 17);
            this.radioButtonNoGenericoMaterial.TabIndex = 66;
            this.radioButtonNoGenericoMaterial.TabStop = true;
            this.radioButtonNoGenericoMaterial.Text = "No Generico";
            this.radioButtonNoGenericoMaterial.UseVisualStyleBackColor = false;
            // 
            // radioButtonGenericoMaterial
            // 
            this.radioButtonGenericoMaterial.AutoSize = true;
            this.radioButtonGenericoMaterial.BackColor = System.Drawing.Color.White;
            this.radioButtonGenericoMaterial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButtonGenericoMaterial.BackgroundImage")));
            this.radioButtonGenericoMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonGenericoMaterial.ForeColor = System.Drawing.Color.White;
            this.radioButtonGenericoMaterial.Location = new System.Drawing.Point(6, 42);
            this.radioButtonGenericoMaterial.Name = "radioButtonGenericoMaterial";
            this.radioButtonGenericoMaterial.Size = new System.Drawing.Size(68, 17);
            this.radioButtonGenericoMaterial.TabIndex = 65;
            this.radioButtonGenericoMaterial.Text = "Generico";
            this.radioButtonGenericoMaterial.UseVisualStyleBackColor = false;
            // 
            // Forma_Materiales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 645);
            this.Controls.Add(this.groupBoxGenericos);
            this.Controls.Add(this.groupBoxModeda);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxUbicacion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBoxMaterial);
            this.Controls.Add(this.textBoxNombreFoto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxMaximo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxMinimo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxUnidadMedida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonBuscarMaterial);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.comboBoxCodigoMaterial);
            this.Controls.Add(this.buttonBorrarBasedeDatos);
            this.Controls.Add(this.textBoxCodigoProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCodigoMaterial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonGuardarBasedeDatos);
            this.Controls.Add(this.buttonBusquedaBaseDatos);
            this.Controls.Add(this.buttonAgregarMaterial);
            this.Controls.Add(this.buttonModificarMaterial);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Forma_Materiales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materiales";
            this.Load += new System.EventHandler(this.Forma_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaterial)).EndInit();
            this.groupBoxModeda.ResumeLayout(false);
            this.groupBoxModeda.PerformLayout();
            this.groupBoxGenericos.ResumeLayout(false);
            this.groupBoxGenericos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonModificarMaterial;
        private System.Windows.Forms.Button buttonAgregarMaterial;
        private System.Windows.Forms.Button buttonBusquedaBaseDatos;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonGuardarBasedeDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodigoMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodigoProveedor;
        private System.Windows.Forms.Button buttonBorrarBasedeDatos;
        private System.Windows.Forms.Timer timerAgregarMaterial;
        private System.Windows.Forms.ComboBox comboBoxCodigoMaterial;
        private System.Windows.Forms.Timer timerBusquedaAgregar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Timer timerEliminaempleado;
        private System.Windows.Forms.Button buttonBuscarMaterial;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUnidadMedida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMinimo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMaximo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNombreFoto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBoxMaterial;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxUbicacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.GroupBox groupBoxModeda;
        private System.Windows.Forms.RadioButton radioButtonDolares;
        private System.Windows.Forms.RadioButton radioButtonPesos;
        private System.Windows.Forms.GroupBox groupBoxGenericos;
        private System.Windows.Forms.RadioButton radioButtonNoGenericoMaterial;
        private System.Windows.Forms.RadioButton radioButtonGenericoMaterial;
    }
}