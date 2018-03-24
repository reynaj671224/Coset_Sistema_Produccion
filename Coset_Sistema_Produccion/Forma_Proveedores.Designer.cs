namespace Coset_Sistema_Produccion
{
    partial class Forma_Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma_Proveedores));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonBuscarProveedor = new System.Windows.Forms.Button();
            this.buttonEliminarProveedor = new System.Windows.Forms.Button();
            this.buttonAgregarProveedor = new System.Windows.Forms.Button();
            this.buttonModificarProveedor = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonBorrarBasedeDatos = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonGuardarBasedeDatos = new System.Windows.Forms.Button();
            this.timerAgregarProveedor = new System.Windows.Forms.Timer(this.components);
            this.textBoxRfcProveedor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDireccionProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombreProveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigoProveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewContactosProveedor = new System.Windows.Forms.DataGridView();
            this.Codigo_contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamento_contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono_oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ext_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo_electronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxCodigoProveedor = new System.Windows.Forms.ComboBox();
            this.timerModificarProveedor = new System.Windows.Forms.Timer(this.components);
            this.textBoxGiroProveedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCorreoeProveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAgregarContacto = new System.Windows.Forms.Button();
            this.buttonEliminarContacto = new System.Windows.Forms.Button();
            this.buttonContactos = new System.Windows.Forms.Button();
            this.comboBoxNombreProveedor = new System.Windows.Forms.ComboBox();
            this.textBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContactosProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1124, 474);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonBuscarProveedor
            // 
            this.buttonBuscarProveedor.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarProveedor.Image")));
            this.buttonBuscarProveedor.Location = new System.Drawing.Point(367, 22);
            this.buttonBuscarProveedor.Name = "buttonBuscarProveedor";
            this.buttonBuscarProveedor.Size = new System.Drawing.Size(79, 74);
            this.buttonBuscarProveedor.TabIndex = 31;
            this.buttonBuscarProveedor.Text = "Visualizar";
            this.buttonBuscarProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBuscarProveedor.UseVisualStyleBackColor = true;
            this.buttonBuscarProveedor.Click += new System.EventHandler(this.buttonBuscarProveedor_Click);
            // 
            // buttonEliminarProveedor
            // 
            this.buttonEliminarProveedor.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminarProveedor.Image")));
            this.buttonEliminarProveedor.Location = new System.Drawing.Point(622, 22);
            this.buttonEliminarProveedor.Name = "buttonEliminarProveedor";
            this.buttonEliminarProveedor.Size = new System.Drawing.Size(79, 74);
            this.buttonEliminarProveedor.TabIndex = 30;
            this.buttonEliminarProveedor.Text = "Eliminar";
            this.buttonEliminarProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEliminarProveedor.UseVisualStyleBackColor = true;
            this.buttonEliminarProveedor.Click += new System.EventHandler(this.buttonEliminarCliente_Click);
            // 
            // buttonAgregarProveedor
            // 
            this.buttonAgregarProveedor.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregarProveedor.Image")));
            this.buttonAgregarProveedor.Location = new System.Drawing.Point(537, 22);
            this.buttonAgregarProveedor.Name = "buttonAgregarProveedor";
            this.buttonAgregarProveedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAgregarProveedor.Size = new System.Drawing.Size(79, 74);
            this.buttonAgregarProveedor.TabIndex = 29;
            this.buttonAgregarProveedor.Text = "Agregar";
            this.buttonAgregarProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAgregarProveedor.UseVisualStyleBackColor = true;
            this.buttonAgregarProveedor.Click += new System.EventHandler(this.buttonAgregarCliente_Click);
            // 
            // buttonModificarProveedor
            // 
            this.buttonModificarProveedor.AutoSize = true;
            this.buttonModificarProveedor.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("buttonModificarProveedor.Image")));
            this.buttonModificarProveedor.Location = new System.Drawing.Point(452, 22);
            this.buttonModificarProveedor.Name = "buttonModificarProveedor";
            this.buttonModificarProveedor.Size = new System.Drawing.Size(79, 74);
            this.buttonModificarProveedor.TabIndex = 28;
            this.buttonModificarProveedor.Text = "Modificar";
            this.buttonModificarProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonModificarProveedor.UseVisualStyleBackColor = true;
            this.buttonModificarProveedor.Click += new System.EventHandler(this.buttonModificarCliente_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AutoSize = true;
            this.buttonCancelar.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.Location = new System.Drawing.Point(1019, 278);
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
            this.buttonBorrarBasedeDatos.Location = new System.Drawing.Point(1019, 198);
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
            this.buttonHome.Location = new System.Drawing.Point(1019, 360);
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
            this.buttonGuardarBasedeDatos.Location = new System.Drawing.Point(1019, 198);
            this.buttonGuardarBasedeDatos.Name = "buttonGuardarBasedeDatos";
            this.buttonGuardarBasedeDatos.Size = new System.Drawing.Size(79, 74);
            this.buttonGuardarBasedeDatos.TabIndex = 32;
            this.buttonGuardarBasedeDatos.Text = "Guardar";
            this.buttonGuardarBasedeDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonGuardarBasedeDatos.UseVisualStyleBackColor = true;
            this.buttonGuardarBasedeDatos.Visible = false;
            this.buttonGuardarBasedeDatos.Click += new System.EventHandler(this.buttonGuardarBasedeDatos_Click);
            // 
            // timerAgregarProveedor
            // 
            this.timerAgregarProveedor.Interval = 1000;
            this.timerAgregarProveedor.Tick += new System.EventHandler(this.timerAgregarProveedor_Tick);
            // 
            // textBoxRfcProveedor
            // 
            this.textBoxRfcProveedor.Enabled = false;
            this.textBoxRfcProveedor.Location = new System.Drawing.Point(221, 242);
            this.textBoxRfcProveedor.Name = "textBoxRfcProveedor";
            this.textBoxRfcProveedor.Size = new System.Drawing.Size(113, 20);
            this.textBoxRfcProveedor.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(83, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 16);
            this.label12.TabIndex = 45;
            this.label12.Text = "RFC Proveedor";
            // 
            // textBoxTelefonoProveedor
            // 
            this.textBoxTelefonoProveedor.Enabled = false;
            this.textBoxTelefonoProveedor.Location = new System.Drawing.Point(221, 268);
            this.textBoxTelefonoProveedor.Name = "textBoxTelefonoProveedor";
            this.textBoxTelefonoProveedor.Size = new System.Drawing.Size(113, 20);
            this.textBoxTelefonoProveedor.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(83, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Telefono Proveedor";
            // 
            // textBoxDireccionProveedor
            // 
            this.textBoxDireccionProveedor.Enabled = false;
            this.textBoxDireccionProveedor.Location = new System.Drawing.Point(221, 203);
            this.textBoxDireccionProveedor.Multiline = true;
            this.textBoxDireccionProveedor.Name = "textBoxDireccionProveedor";
            this.textBoxDireccionProveedor.Size = new System.Drawing.Size(438, 32);
            this.textBoxDireccionProveedor.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(83, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Direccion Proveedor";
            // 
            // textBoxNombreProveedor
            // 
            this.textBoxNombreProveedor.Enabled = false;
            this.textBoxNombreProveedor.Location = new System.Drawing.Point(221, 141);
            this.textBoxNombreProveedor.Name = "textBoxNombreProveedor";
            this.textBoxNombreProveedor.Size = new System.Drawing.Size(438, 20);
            this.textBoxNombreProveedor.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(83, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nombre Proveedor";
            // 
            // textBoxCodigoProveedor
            // 
            this.textBoxCodigoProveedor.Enabled = false;
            this.textBoxCodigoProveedor.Location = new System.Drawing.Point(221, 115);
            this.textBoxCodigoProveedor.Name = "textBoxCodigoProveedor";
            this.textBoxCodigoProveedor.Size = new System.Drawing.Size(121, 20);
            this.textBoxCodigoProveedor.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(83, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Codigo Proveedor";
            // 
            // dataGridViewContactosProveedor
            // 
            this.dataGridViewContactosProveedor.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewContactosProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContactosProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_contacto,
            this.nombre_contacto,
            this.departamento_contacto,
            this.telefono_oficina,
            this.ext_telefono,
            this.tel_celular,
            this.correo_electronico});
            this.dataGridViewContactosProveedor.Enabled = false;
            this.dataGridViewContactosProveedor.Location = new System.Drawing.Point(97, 304);
            this.dataGridViewContactosProveedor.Name = "dataGridViewContactosProveedor";
            this.dataGridViewContactosProveedor.Size = new System.Drawing.Size(894, 158);
            this.dataGridViewContactosProveedor.TabIndex = 48;
            this.dataGridViewContactosProveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContactosProveedor_CellClick);
            // 
            // Codigo_contacto
            // 
            this.Codigo_contacto.HeaderText = "Codigo";
            this.Codigo_contacto.Name = "Codigo_contacto";
            this.Codigo_contacto.Width = 50;
            // 
            // nombre_contacto
            // 
            this.nombre_contacto.HeaderText = "Nombre Contacto";
            this.nombre_contacto.Name = "nombre_contacto";
            this.nombre_contacto.Width = 250;
            // 
            // departamento_contacto
            // 
            this.departamento_contacto.HeaderText = "Departamento";
            this.departamento_contacto.Name = "departamento_contacto";
            // 
            // telefono_oficina
            // 
            this.telefono_oficina.HeaderText = "Telefono Oficina";
            this.telefono_oficina.Name = "telefono_oficina";
            // 
            // ext_telefono
            // 
            this.ext_telefono.HeaderText = "Ext";
            this.ext_telefono.Name = "ext_telefono";
            this.ext_telefono.Width = 50;
            // 
            // tel_celular
            // 
            this.tel_celular.HeaderText = "Telefono Celular";
            this.tel_celular.Name = "tel_celular";
            // 
            // correo_electronico
            // 
            this.correo_electronico.HeaderText = "Correo Electronico";
            this.correo_electronico.Name = "correo_electronico";
            this.correo_electronico.Width = 250;
            // 
            // comboBoxCodigoProveedor
            // 
            this.comboBoxCodigoProveedor.FormattingEnabled = true;
            this.comboBoxCodigoProveedor.Location = new System.Drawing.Point(221, 113);
            this.comboBoxCodigoProveedor.Name = "comboBoxCodigoProveedor";
            this.comboBoxCodigoProveedor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCodigoProveedor.TabIndex = 49;
            this.comboBoxCodigoProveedor.Visible = false;
            this.comboBoxCodigoProveedor.SelectedIndexChanged += new System.EventHandler(this.comboBoxCodigoCliente_SelectedIndexChanged);
            // 
            // timerModificarProveedor
            // 
            this.timerModificarProveedor.Interval = 1000;
            this.timerModificarProveedor.Tick += new System.EventHandler(this.timerModificarProveedor_Tick);
            // 
            // textBoxGiroProveedor
            // 
            this.textBoxGiroProveedor.Enabled = false;
            this.textBoxGiroProveedor.Location = new System.Drawing.Point(480, 242);
            this.textBoxGiroProveedor.Name = "textBoxGiroProveedor";
            this.textBoxGiroProveedor.Size = new System.Drawing.Size(133, 20);
            this.textBoxGiroProveedor.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(364, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 52;
            this.label5.Text = "Giro Proveedor";
            // 
            // textBoxCorreoeProveedor
            // 
            this.textBoxCorreoeProveedor.Enabled = false;
            this.textBoxCorreoeProveedor.Location = new System.Drawing.Point(480, 268);
            this.textBoxCorreoeProveedor.Name = "textBoxCorreoeProveedor";
            this.textBoxCorreoeProveedor.Size = new System.Drawing.Size(179, 20);
            this.textBoxCorreoeProveedor.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(364, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "Correo E Proveedor";
            // 
            // buttonAgregarContacto
            // 
            this.buttonAgregarContacto.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarContacto.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregarContacto.Image")));
            this.buttonAgregarContacto.Location = new System.Drawing.Point(12, 304);
            this.buttonAgregarContacto.Name = "buttonAgregarContacto";
            this.buttonAgregarContacto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAgregarContacto.Size = new System.Drawing.Size(79, 74);
            this.buttonAgregarContacto.TabIndex = 56;
            this.buttonAgregarContacto.Text = "Agregar";
            this.buttonAgregarContacto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAgregarContacto.UseVisualStyleBackColor = true;
            this.buttonAgregarContacto.Visible = false;
            this.buttonAgregarContacto.Click += new System.EventHandler(this.buttonAgregarContacto_Click);
            // 
            // buttonEliminarContacto
            // 
            this.buttonEliminarContacto.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarContacto.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminarContacto.Image")));
            this.buttonEliminarContacto.Location = new System.Drawing.Point(12, 388);
            this.buttonEliminarContacto.Name = "buttonEliminarContacto";
            this.buttonEliminarContacto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonEliminarContacto.Size = new System.Drawing.Size(79, 74);
            this.buttonEliminarContacto.TabIndex = 55;
            this.buttonEliminarContacto.Text = "Eliminar";
            this.buttonEliminarContacto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEliminarContacto.UseVisualStyleBackColor = true;
            this.buttonEliminarContacto.Visible = false;
            this.buttonEliminarContacto.Click += new System.EventHandler(this.buttonEliminarContacto_Click);
            // 
            // buttonContactos
            // 
            this.buttonContactos.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContactos.Image = ((System.Drawing.Image)(resources.GetObject("buttonContactos.Image")));
            this.buttonContactos.Location = new System.Drawing.Point(707, 22);
            this.buttonContactos.Name = "buttonContactos";
            this.buttonContactos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonContactos.Size = new System.Drawing.Size(79, 74);
            this.buttonContactos.TabIndex = 57;
            this.buttonContactos.Text = "Contactos";
            this.buttonContactos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonContactos.UseVisualStyleBackColor = true;
            this.buttonContactos.Click += new System.EventHandler(this.buttonContactos_Click);
            // 
            // comboBoxNombreProveedor
            // 
            this.comboBoxNombreProveedor.FormattingEnabled = true;
            this.comboBoxNombreProveedor.Location = new System.Drawing.Point(221, 139);
            this.comboBoxNombreProveedor.Name = "comboBoxNombreProveedor";
            this.comboBoxNombreProveedor.Size = new System.Drawing.Size(438, 21);
            this.comboBoxNombreProveedor.TabIndex = 58;
            this.comboBoxNombreProveedor.Visible = false;
            this.comboBoxNombreProveedor.SelectedIndexChanged += new System.EventHandler(this.comboBoxNombreProveedor_SelectedIndexChanged);
            // 
            // textBoxRazonSocial
            // 
            this.textBoxRazonSocial.Enabled = false;
            this.textBoxRazonSocial.Location = new System.Drawing.Point(221, 165);
            this.textBoxRazonSocial.Multiline = true;
            this.textBoxRazonSocial.Name = "textBoxRazonSocial";
            this.textBoxRazonSocial.Size = new System.Drawing.Size(438, 32);
            this.textBoxRazonSocial.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(83, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 16);
            this.label7.TabIndex = 59;
            this.label7.Text = "Razón Social Proveedor";
            // 
            // Forma_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 474);
            this.Controls.Add(this.textBoxRazonSocial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxNombreProveedor);
            this.Controls.Add(this.buttonContactos);
            this.Controls.Add(this.buttonAgregarContacto);
            this.Controls.Add(this.buttonEliminarContacto);
            this.Controls.Add(this.textBoxCorreoeProveedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxGiroProveedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxCodigoProveedor);
            this.Controls.Add(this.dataGridViewContactosProveedor);
            this.Controls.Add(this.textBoxRfcProveedor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxTelefonoProveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDireccionProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombreProveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCodigoProveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonBorrarBasedeDatos);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonGuardarBasedeDatos);
            this.Controls.Add(this.buttonBuscarProveedor);
            this.Controls.Add(this.buttonEliminarProveedor);
            this.Controls.Add(this.buttonAgregarProveedor);
            this.Controls.Add(this.buttonModificarProveedor);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Forma_Proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Forma_Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContactosProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBuscarProveedor;
        private System.Windows.Forms.Button buttonEliminarProveedor;
        private System.Windows.Forms.Button buttonAgregarProveedor;
        private System.Windows.Forms.Button buttonModificarProveedor;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonBorrarBasedeDatos;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonGuardarBasedeDatos;
        private System.Windows.Forms.Timer timerAgregarProveedor;
        private System.Windows.Forms.TextBox textBoxRfcProveedor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxTelefonoProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDireccionProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombreProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodigoProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewContactosProveedor;
        private System.Windows.Forms.ComboBox comboBoxCodigoProveedor;
        private System.Windows.Forms.Timer timerModificarProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamento_contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono_oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn ext_telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo_electronico;
        private System.Windows.Forms.TextBox textBoxGiroProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCorreoeProveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAgregarContacto;
        private System.Windows.Forms.Button buttonEliminarContacto;
        private System.Windows.Forms.Button buttonContactos;
        private System.Windows.Forms.ComboBox comboBoxNombreProveedor;
        private System.Windows.Forms.TextBox textBoxRazonSocial;
        private System.Windows.Forms.Label label7;
    }
}