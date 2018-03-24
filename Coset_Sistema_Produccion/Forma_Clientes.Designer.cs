namespace Coset_Sistema_Produccion
{
    partial class Forma_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma_Clientes));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonBuscarCliente = new System.Windows.Forms.Button();
            this.buttonEliminarCliente = new System.Windows.Forms.Button();
            this.buttonAgregarCliente = new System.Windows.Forms.Button();
            this.buttonModificarCliente = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonBorrarBasedeDatos = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonGuardarBasedeDatos = new System.Windows.Forms.Button();
            this.timerAgregarCliente = new System.Windows.Forms.Timer(this.components);
            this.textBoxRfcCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxTelefonoCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDireccionCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigoCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewContactosClientes = new System.Windows.Forms.DataGridView();
            this.Codigo_contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamento_contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono_oficina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ext_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo_electronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxCodigoCliente = new System.Windows.Forms.ComboBox();
            this.timerModificarClientes = new System.Windows.Forms.Timer(this.components);
            this.buttonContactos = new System.Windows.Forms.Button();
            this.buttonEliminarContacto = new System.Windows.Forms.Button();
            this.buttonAgregarContacto = new System.Windows.Forms.Button();
            this.comboBoxNombreCliente = new System.Windows.Forms.ComboBox();
            this.textBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContactosClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1124, 486);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonBuscarCliente
            // 
            this.buttonBuscarCliente.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarCliente.Image")));
            this.buttonBuscarCliente.Location = new System.Drawing.Point(367, 22);
            this.buttonBuscarCliente.Name = "buttonBuscarCliente";
            this.buttonBuscarCliente.Size = new System.Drawing.Size(79, 74);
            this.buttonBuscarCliente.TabIndex = 31;
            this.buttonBuscarCliente.Text = "Visualizar";
            this.buttonBuscarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBuscarCliente.UseVisualStyleBackColor = true;
            this.buttonBuscarCliente.Click += new System.EventHandler(this.buttonBuscarempleado_Click);
            // 
            // buttonEliminarCliente
            // 
            this.buttonEliminarCliente.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminarCliente.Image")));
            this.buttonEliminarCliente.Location = new System.Drawing.Point(622, 22);
            this.buttonEliminarCliente.Name = "buttonEliminarCliente";
            this.buttonEliminarCliente.Size = new System.Drawing.Size(79, 74);
            this.buttonEliminarCliente.TabIndex = 30;
            this.buttonEliminarCliente.Text = "Eliminar";
            this.buttonEliminarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEliminarCliente.UseVisualStyleBackColor = true;
            this.buttonEliminarCliente.Click += new System.EventHandler(this.buttonEliminarCliente_Click);
            // 
            // buttonAgregarCliente
            // 
            this.buttonAgregarCliente.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregarCliente.Image")));
            this.buttonAgregarCliente.Location = new System.Drawing.Point(537, 22);
            this.buttonAgregarCliente.Name = "buttonAgregarCliente";
            this.buttonAgregarCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAgregarCliente.Size = new System.Drawing.Size(79, 74);
            this.buttonAgregarCliente.TabIndex = 29;
            this.buttonAgregarCliente.Text = "Agregar";
            this.buttonAgregarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAgregarCliente.UseVisualStyleBackColor = true;
            this.buttonAgregarCliente.Click += new System.EventHandler(this.buttonAgregarCliente_Click);
            // 
            // buttonModificarCliente
            // 
            this.buttonModificarCliente.AutoSize = true;
            this.buttonModificarCliente.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonModificarCliente.Image")));
            this.buttonModificarCliente.Location = new System.Drawing.Point(452, 22);
            this.buttonModificarCliente.Name = "buttonModificarCliente";
            this.buttonModificarCliente.Size = new System.Drawing.Size(79, 74);
            this.buttonModificarCliente.TabIndex = 28;
            this.buttonModificarCliente.Text = "Modificar";
            this.buttonModificarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonModificarCliente.UseVisualStyleBackColor = true;
            this.buttonModificarCliente.Click += new System.EventHandler(this.buttonModificarCliente_Click);
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
            this.buttonBorrarBasedeDatos.Location = new System.Drawing.Point(1019, 191);
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
            // timerAgregarCliente
            // 
            this.timerAgregarCliente.Interval = 1000;
            this.timerAgregarCliente.Tick += new System.EventHandler(this.timerAgregarCliente_Tick);
            // 
            // textBoxRfcCliente
            // 
            this.textBoxRfcCliente.Enabled = false;
            this.textBoxRfcCliente.Location = new System.Drawing.Point(207, 245);
            this.textBoxRfcCliente.Name = "textBoxRfcCliente";
            this.textBoxRfcCliente.Size = new System.Drawing.Size(113, 20);
            this.textBoxRfcCliente.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(85, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 45;
            this.label12.Text = "RFC Cliente";
            // 
            // textBoxTelefonoCliente
            // 
            this.textBoxTelefonoCliente.Enabled = false;
            this.textBoxTelefonoCliente.Location = new System.Drawing.Point(207, 271);
            this.textBoxTelefonoCliente.Name = "textBoxTelefonoCliente";
            this.textBoxTelefonoCliente.Size = new System.Drawing.Size(113, 20);
            this.textBoxTelefonoCliente.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(85, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Telefono Cliente";
            // 
            // textBoxDireccionCliente
            // 
            this.textBoxDireccionCliente.Enabled = false;
            this.textBoxDireccionCliente.Location = new System.Drawing.Point(207, 202);
            this.textBoxDireccionCliente.Multiline = true;
            this.textBoxDireccionCliente.Name = "textBoxDireccionCliente";
            this.textBoxDireccionCliente.Size = new System.Drawing.Size(438, 32);
            this.textBoxDireccionCliente.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(85, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Direccion Cliente";
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Enabled = false;
            this.textBoxNombreCliente.Location = new System.Drawing.Point(207, 137);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.Size = new System.Drawing.Size(438, 20);
            this.textBoxNombreCliente.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(85, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nombre Cliente";
            // 
            // textBoxCodigoCliente
            // 
            this.textBoxCodigoCliente.Enabled = false;
            this.textBoxCodigoCliente.Location = new System.Drawing.Point(207, 113);
            this.textBoxCodigoCliente.Name = "textBoxCodigoCliente";
            this.textBoxCodigoCliente.Size = new System.Drawing.Size(121, 20);
            this.textBoxCodigoCliente.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(85, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Codigo Cliente";
            // 
            // dataGridViewContactosClientes
            // 
            this.dataGridViewContactosClientes.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewContactosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContactosClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_contacto,
            this.nombre_contacto,
            this.departamento_contacto,
            this.telefono_oficina,
            this.ext_telefono,
            this.tel_celular,
            this.correo_electronico});
            this.dataGridViewContactosClientes.Enabled = false;
            this.dataGridViewContactosClientes.Location = new System.Drawing.Point(97, 318);
            this.dataGridViewContactosClientes.Name = "dataGridViewContactosClientes";
            this.dataGridViewContactosClientes.Size = new System.Drawing.Size(894, 156);
            this.dataGridViewContactosClientes.TabIndex = 48;
            this.dataGridViewContactosClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContactosClientes_CellClick);
            this.dataGridViewContactosClientes.SelectionChanged += new System.EventHandler(this.dataGridViewContactosClientes_SelectionChanged);
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
            // comboBoxCodigoCliente
            // 
            this.comboBoxCodigoCliente.FormattingEnabled = true;
            this.comboBoxCodigoCliente.Location = new System.Drawing.Point(207, 112);
            this.comboBoxCodigoCliente.Name = "comboBoxCodigoCliente";
            this.comboBoxCodigoCliente.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCodigoCliente.TabIndex = 49;
            this.comboBoxCodigoCliente.Visible = false;
            this.comboBoxCodigoCliente.SelectedIndexChanged += new System.EventHandler(this.comboBoxCodigoCliente_SelectedIndexChanged);
            // 
            // timerModificarClientes
            // 
            this.timerModificarClientes.Interval = 1000;
            this.timerModificarClientes.Tick += new System.EventHandler(this.timerModificarClientes_Tick);
            // 
            // buttonContactos
            // 
            this.buttonContactos.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContactos.Image = ((System.Drawing.Image)(resources.GetObject("buttonContactos.Image")));
            this.buttonContactos.Location = new System.Drawing.Point(707, 22);
            this.buttonContactos.Name = "buttonContactos";
            this.buttonContactos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonContactos.Size = new System.Drawing.Size(79, 74);
            this.buttonContactos.TabIndex = 51;
            this.buttonContactos.Text = "Contactos";
            this.buttonContactos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonContactos.UseVisualStyleBackColor = true;
            this.buttonContactos.Click += new System.EventHandler(this.buttonContactos_Click);
            // 
            // buttonEliminarContacto
            // 
            this.buttonEliminarContacto.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarContacto.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminarContacto.Image")));
            this.buttonEliminarContacto.Location = new System.Drawing.Point(12, 400);
            this.buttonEliminarContacto.Name = "buttonEliminarContacto";
            this.buttonEliminarContacto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonEliminarContacto.Size = new System.Drawing.Size(79, 74);
            this.buttonEliminarContacto.TabIndex = 52;
            this.buttonEliminarContacto.Text = "Eliminar";
            this.buttonEliminarContacto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEliminarContacto.UseVisualStyleBackColor = true;
            this.buttonEliminarContacto.Visible = false;
            this.buttonEliminarContacto.Click += new System.EventHandler(this.buttonEliminarContacto_Click);
            // 
            // buttonAgregarContacto
            // 
            this.buttonAgregarContacto.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarContacto.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregarContacto.Image")));
            this.buttonAgregarContacto.Location = new System.Drawing.Point(12, 318);
            this.buttonAgregarContacto.Name = "buttonAgregarContacto";
            this.buttonAgregarContacto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAgregarContacto.Size = new System.Drawing.Size(79, 74);
            this.buttonAgregarContacto.TabIndex = 53;
            this.buttonAgregarContacto.Text = "Agregar";
            this.buttonAgregarContacto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAgregarContacto.UseVisualStyleBackColor = true;
            this.buttonAgregarContacto.Visible = false;
            this.buttonAgregarContacto.Click += new System.EventHandler(this.buttonAgregarContacto_Click);
            // 
            // comboBoxNombreCliente
            // 
            this.comboBoxNombreCliente.FormattingEnabled = true;
            this.comboBoxNombreCliente.Location = new System.Drawing.Point(207, 137);
            this.comboBoxNombreCliente.Name = "comboBoxNombreCliente";
            this.comboBoxNombreCliente.Size = new System.Drawing.Size(438, 21);
            this.comboBoxNombreCliente.TabIndex = 54;
            this.comboBoxNombreCliente.Visible = false;
            this.comboBoxNombreCliente.SelectedIndexChanged += new System.EventHandler(this.comboBoxNombreCliente_SelectedIndexChanged);
            // 
            // textBoxRazonSocial
            // 
            this.textBoxRazonSocial.Enabled = false;
            this.textBoxRazonSocial.Location = new System.Drawing.Point(207, 164);
            this.textBoxRazonSocial.Multiline = true;
            this.textBoxRazonSocial.Name = "textBoxRazonSocial";
            this.textBoxRazonSocial.Size = new System.Drawing.Size(438, 32);
            this.textBoxRazonSocial.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(85, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "Razón Social Cliente";
            // 
            // Forma_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 486);
            this.Controls.Add(this.textBoxRazonSocial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxNombreCliente);
            this.Controls.Add(this.buttonAgregarContacto);
            this.Controls.Add(this.buttonEliminarContacto);
            this.Controls.Add(this.buttonContactos);
            this.Controls.Add(this.comboBoxCodigoCliente);
            this.Controls.Add(this.dataGridViewContactosClientes);
            this.Controls.Add(this.textBoxRfcCliente);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxTelefonoCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDireccionCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombreCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCodigoCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonBorrarBasedeDatos);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonGuardarBasedeDatos);
            this.Controls.Add(this.buttonBuscarCliente);
            this.Controls.Add(this.buttonEliminarCliente);
            this.Controls.Add(this.buttonAgregarCliente);
            this.Controls.Add(this.buttonModificarCliente);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Forma_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Forma_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContactosClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBuscarCliente;
        private System.Windows.Forms.Button buttonEliminarCliente;
        private System.Windows.Forms.Button buttonAgregarCliente;
        private System.Windows.Forms.Button buttonModificarCliente;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonBorrarBasedeDatos;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonGuardarBasedeDatos;
        private System.Windows.Forms.Timer timerAgregarCliente;
        private System.Windows.Forms.TextBox textBoxRfcCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxTelefonoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDireccionCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodigoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewContactosClientes;
        private System.Windows.Forms.ComboBox comboBoxCodigoCliente;
        private System.Windows.Forms.Timer timerModificarClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamento_contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono_oficina;
        private System.Windows.Forms.DataGridViewTextBoxColumn ext_telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo_electronico;
        private System.Windows.Forms.Button buttonContactos;
        private System.Windows.Forms.Button buttonEliminarContacto;
        private System.Windows.Forms.Button buttonAgregarContacto;
        private System.Windows.Forms.ComboBox comboBoxNombreCliente;
        private System.Windows.Forms.TextBox textBoxRazonSocial;
        private System.Windows.Forms.Label label5;
    }
}