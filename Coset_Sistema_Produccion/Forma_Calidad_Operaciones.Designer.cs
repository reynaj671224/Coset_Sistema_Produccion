namespace Coset_Sistema_Produccion
{
    partial class Forma_Calidad_Operaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma_Calidad_Operaciones));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRetrabajo = new System.Windows.Forms.Button();
            this.buttonDesecho = new System.Windows.Forms.Button();
            this.buttonBuscarDibujo = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonGuardarBasedeDatos = new System.Windows.Forms.Button();
            this.labelEmpleado = new System.Windows.Forms.Label();
            this.textBoxEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombreProceso = new System.Windows.Forms.TextBox();
            this.buttonBorrarBasedeDatos = new System.Windows.Forms.Button();
            this.timerInciarProcesoBusqueda = new System.Windows.Forms.Timer(this.components);
            this.comboBoxEmpleado = new System.Windows.Forms.ComboBox();
            this.timerActualizrempleado = new System.Windows.Forms.Timer(this.components);
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.timerEliminaempleado = new System.Windows.Forms.Timer(this.components);
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.comboBoxNombreProceso = new System.Windows.Forms.ComboBox();
            this.textBoxNumeroDibujo = new System.Windows.Forms.TextBox();
            this.labelNumeroDibujo = new System.Windows.Forms.Label();
            this.textBoxCalidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewSecuenciasCalidad = new System.Windows.Forms.DataGridView();
            this.Numero_Dibujo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBuscarSecuenciaDibujo = new System.Windows.Forms.Button();
            this.textBoxMotivoRechazo = new System.Windows.Forms.TextBox();
            this.labelDescripcionRechazo = new System.Windows.Forms.Label();
            this.labelaccionCorrectiva = new System.Windows.Forms.Label();
            this.textBoxAccionCorrectiva = new System.Windows.Forms.TextBox();
            this.dataGridViewDibujoDimenciones = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecuenciasCalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDibujoDimenciones)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1134, 522);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonRetrabajo
            // 
            this.buttonRetrabajo.AutoSize = true;
            this.buttonRetrabajo.BackColor = System.Drawing.Color.White;
            this.buttonRetrabajo.Enabled = false;
            this.buttonRetrabajo.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetrabajo.Image = ((System.Drawing.Image)(resources.GetObject("buttonRetrabajo.Image")));
            this.buttonRetrabajo.Location = new System.Drawing.Point(462, 12);
            this.buttonRetrabajo.Name = "buttonRetrabajo";
            this.buttonRetrabajo.Size = new System.Drawing.Size(79, 74);
            this.buttonRetrabajo.TabIndex = 1;
            this.buttonRetrabajo.Text = "Re-Trabajo";
            this.buttonRetrabajo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonRetrabajo.UseVisualStyleBackColor = false;
            this.buttonRetrabajo.Click += new System.EventHandler(this.buttonRetrabajo_Click);
            // 
            // buttonDesecho
            // 
            this.buttonDesecho.AutoSize = true;
            this.buttonDesecho.BackColor = System.Drawing.Color.White;
            this.buttonDesecho.Enabled = false;
            this.buttonDesecho.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDesecho.Image = ((System.Drawing.Image)(resources.GetObject("buttonDesecho.Image")));
            this.buttonDesecho.Location = new System.Drawing.Point(547, 12);
            this.buttonDesecho.Name = "buttonDesecho";
            this.buttonDesecho.Size = new System.Drawing.Size(79, 74);
            this.buttonDesecho.TabIndex = 2;
            this.buttonDesecho.Text = "Desecho";
            this.buttonDesecho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDesecho.UseVisualStyleBackColor = false;
            this.buttonDesecho.Click += new System.EventHandler(this.buttonDesecho_Click);
            // 
            // buttonBuscarDibujo
            // 
            this.buttonBuscarDibujo.BackColor = System.Drawing.Color.White;
            this.buttonBuscarDibujo.Enabled = false;
            this.buttonBuscarDibujo.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarDibujo.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarDibujo.Image")));
            this.buttonBuscarDibujo.Location = new System.Drawing.Point(632, 12);
            this.buttonBuscarDibujo.Name = "buttonBuscarDibujo";
            this.buttonBuscarDibujo.Size = new System.Drawing.Size(79, 74);
            this.buttonBuscarDibujo.TabIndex = 3;
            this.buttonBuscarDibujo.Text = "Buscar";
            this.buttonBuscarDibujo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBuscarDibujo.UseVisualStyleBackColor = false;
            this.buttonBuscarDibujo.Visible = false;
            this.buttonBuscarDibujo.Click += new System.EventHandler(this.buttonBuscarDibujo_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.AutoSize = true;
            this.buttonHome.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(1038, 426);
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
            this.buttonGuardarBasedeDatos.Location = new System.Drawing.Point(1038, 266);
            this.buttonGuardarBasedeDatos.Name = "buttonGuardarBasedeDatos";
            this.buttonGuardarBasedeDatos.Size = new System.Drawing.Size(79, 74);
            this.buttonGuardarBasedeDatos.TabIndex = 4;
            this.buttonGuardarBasedeDatos.Text = "Guardar";
            this.buttonGuardarBasedeDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonGuardarBasedeDatos.UseVisualStyleBackColor = true;
            this.buttonGuardarBasedeDatos.Visible = false;
            this.buttonGuardarBasedeDatos.Click += new System.EventHandler(this.buttonGuardarBasedeDatos_Click);
            // 
            // labelEmpleado
            // 
            this.labelEmpleado.AutoSize = true;
            this.labelEmpleado.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("labelEmpleado.Image")));
            this.labelEmpleado.Location = new System.Drawing.Point(43, 122);
            this.labelEmpleado.Name = "labelEmpleado";
            this.labelEmpleado.Size = new System.Drawing.Size(61, 16);
            this.labelEmpleado.TabIndex = 6;
            this.labelEmpleado.Text = "Empleado";
            // 
            // textBoxEmpleado
            // 
            this.textBoxEmpleado.Enabled = false;
            this.textBoxEmpleado.Location = new System.Drawing.Point(171, 121);
            this.textBoxEmpleado.Name = "textBoxEmpleado";
            this.textBoxEmpleado.Size = new System.Drawing.Size(196, 20);
            this.textBoxEmpleado.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(43, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Proceso";
            // 
            // textBoxNombreProceso
            // 
            this.textBoxNombreProceso.Enabled = false;
            this.textBoxNombreProceso.Location = new System.Drawing.Point(171, 174);
            this.textBoxNombreProceso.Name = "textBoxNombreProceso";
            this.textBoxNombreProceso.Size = new System.Drawing.Size(196, 20);
            this.textBoxNombreProceso.TabIndex = 9;
            // 
            // buttonBorrarBasedeDatos
            // 
            this.buttonBorrarBasedeDatos.AutoSize = true;
            this.buttonBorrarBasedeDatos.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrarBasedeDatos.Image = ((System.Drawing.Image)(resources.GetObject("buttonBorrarBasedeDatos.Image")));
            this.buttonBorrarBasedeDatos.Location = new System.Drawing.Point(1038, 252);
            this.buttonBorrarBasedeDatos.Name = "buttonBorrarBasedeDatos";
            this.buttonBorrarBasedeDatos.Size = new System.Drawing.Size(79, 74);
            this.buttonBorrarBasedeDatos.TabIndex = 20;
            this.buttonBorrarBasedeDatos.Text = "Eliminar";
            this.buttonBorrarBasedeDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBorrarBasedeDatos.UseVisualStyleBackColor = true;
            this.buttonBorrarBasedeDatos.Visible = false;
            this.buttonBorrarBasedeDatos.Click += new System.EventHandler(this.buttonBorrarBasedeDatos_Click);
            // 
            // timerInciarProcesoBusqueda
            // 
            this.timerInciarProcesoBusqueda.Interval = 1000;
            this.timerInciarProcesoBusqueda.Tick += new System.EventHandler(this.timerInciarProcesoBusqueda_Tick);
            // 
            // comboBoxEmpleado
            // 
            this.comboBoxEmpleado.FormattingEnabled = true;
            this.comboBoxEmpleado.Location = new System.Drawing.Point(171, 121);
            this.comboBoxEmpleado.Name = "comboBoxEmpleado";
            this.comboBoxEmpleado.Size = new System.Drawing.Size(196, 21);
            this.comboBoxEmpleado.TabIndex = 25;
            this.comboBoxEmpleado.Visible = false;
            this.comboBoxEmpleado.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmpleado_SelectedIndexChanged);
            // 
            // timerActualizrempleado
            // 
            this.timerActualizrempleado.Interval = 1000;
            this.timerActualizrempleado.Tick += new System.EventHandler(this.timerActualizrempleado_Tick);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AutoSize = true;
            this.buttonCancelar.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.Location = new System.Drawing.Point(1038, 346);
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
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.White;
            this.buttonAceptar.Enabled = false;
            this.buttonAceptar.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAceptar.Image")));
            this.buttonAceptar.Location = new System.Drawing.Point(377, 12);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(79, 74);
            this.buttonAceptar.TabIndex = 27;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // comboBoxNombreProceso
            // 
            this.comboBoxNombreProceso.FormattingEnabled = true;
            this.comboBoxNombreProceso.Location = new System.Drawing.Point(171, 173);
            this.comboBoxNombreProceso.Name = "comboBoxNombreProceso";
            this.comboBoxNombreProceso.Size = new System.Drawing.Size(196, 21);
            this.comboBoxNombreProceso.TabIndex = 28;
            this.comboBoxNombreProceso.Visible = false;
            this.comboBoxNombreProceso.SelectedIndexChanged += new System.EventHandler(this.comboBoxNombreEmpleado_SelectedIndexChanged);
            // 
            // textBoxNumeroDibujo
            // 
            this.textBoxNumeroDibujo.Enabled = false;
            this.textBoxNumeroDibujo.Location = new System.Drawing.Point(171, 147);
            this.textBoxNumeroDibujo.Name = "textBoxNumeroDibujo";
            this.textBoxNumeroDibujo.Size = new System.Drawing.Size(196, 20);
            this.textBoxNumeroDibujo.TabIndex = 29;
            // 
            // labelNumeroDibujo
            // 
            this.labelNumeroDibujo.AutoSize = true;
            this.labelNumeroDibujo.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroDibujo.Image = ((System.Drawing.Image)(resources.GetObject("labelNumeroDibujo.Image")));
            this.labelNumeroDibujo.Location = new System.Drawing.Point(43, 149);
            this.labelNumeroDibujo.Name = "labelNumeroDibujo";
            this.labelNumeroDibujo.Size = new System.Drawing.Size(90, 16);
            this.labelNumeroDibujo.TabIndex = 30;
            this.labelNumeroDibujo.Text = "Numero Dibujo";
            // 
            // textBoxCalidad
            // 
            this.textBoxCalidad.Enabled = false;
            this.textBoxCalidad.Location = new System.Drawing.Point(171, 200);
            this.textBoxCalidad.Name = "textBoxCalidad";
            this.textBoxCalidad.Size = new System.Drawing.Size(196, 20);
            this.textBoxCalidad.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(43, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Calidad";
            // 
            // dataGridViewSecuenciasCalidad
            // 
            this.dataGridViewSecuenciasCalidad.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewSecuenciasCalidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSecuenciasCalidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_Dibujo,
            this.Empleado,
            this.Proceso});
            this.dataGridViewSecuenciasCalidad.Location = new System.Drawing.Point(246, 288);
            this.dataGridViewSecuenciasCalidad.Name = "dataGridViewSecuenciasCalidad";
            this.dataGridViewSecuenciasCalidad.Size = new System.Drawing.Size(642, 212);
            this.dataGridViewSecuenciasCalidad.TabIndex = 49;
            this.dataGridViewSecuenciasCalidad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSecuenciasCalidad_CellClick);
            // 
            // Numero_Dibujo
            // 
            this.Numero_Dibujo.HeaderText = "Numero Dibujo";
            this.Numero_Dibujo.Name = "Numero_Dibujo";
            this.Numero_Dibujo.Width = 200;
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            this.Empleado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Empleado.Width = 200;
            // 
            // Proceso
            // 
            this.Proceso.HeaderText = "Proceso";
            this.Proceso.Name = "Proceso";
            this.Proceso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Proceso.Width = 200;
            // 
            // buttonBuscarSecuenciaDibujo
            // 
            this.buttonBuscarSecuenciaDibujo.Enabled = false;
            this.buttonBuscarSecuenciaDibujo.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarSecuenciaDibujo.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarSecuenciaDibujo.Image")));
            this.buttonBuscarSecuenciaDibujo.Location = new System.Drawing.Point(292, 12);
            this.buttonBuscarSecuenciaDibujo.Name = "buttonBuscarSecuenciaDibujo";
            this.buttonBuscarSecuenciaDibujo.Size = new System.Drawing.Size(79, 74);
            this.buttonBuscarSecuenciaDibujo.TabIndex = 54;
            this.buttonBuscarSecuenciaDibujo.Text = "Visualizar";
            this.buttonBuscarSecuenciaDibujo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBuscarSecuenciaDibujo.UseVisualStyleBackColor = true;
            this.buttonBuscarSecuenciaDibujo.Visible = false;
            this.buttonBuscarSecuenciaDibujo.Click += new System.EventHandler(this.buttonBuscarSecuenciaDibujo_Click);
            // 
            // textBoxMotivoRechazo
            // 
            this.textBoxMotivoRechazo.Enabled = false;
            this.textBoxMotivoRechazo.Location = new System.Drawing.Point(547, 120);
            this.textBoxMotivoRechazo.Multiline = true;
            this.textBoxMotivoRechazo.Name = "textBoxMotivoRechazo";
            this.textBoxMotivoRechazo.Size = new System.Drawing.Size(311, 72);
            this.textBoxMotivoRechazo.TabIndex = 56;
            this.textBoxMotivoRechazo.Visible = false;
            // 
            // labelDescripcionRechazo
            // 
            this.labelDescripcionRechazo.AutoSize = true;
            this.labelDescripcionRechazo.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionRechazo.Image = ((System.Drawing.Image)(resources.GetObject("labelDescripcionRechazo.Image")));
            this.labelDescripcionRechazo.Location = new System.Drawing.Point(396, 126);
            this.labelDescripcionRechazo.Name = "labelDescripcionRechazo";
            this.labelDescripcionRechazo.Size = new System.Drawing.Size(145, 16);
            this.labelDescripcionRechazo.TabIndex = 55;
            this.labelDescripcionRechazo.Text = "Motivo Rechazo/Retrabajo";
            this.labelDescripcionRechazo.Visible = false;
            // 
            // labelaccionCorrectiva
            // 
            this.labelaccionCorrectiva.AutoSize = true;
            this.labelaccionCorrectiva.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaccionCorrectiva.Image = ((System.Drawing.Image)(resources.GetObject("labelaccionCorrectiva.Image")));
            this.labelaccionCorrectiva.Location = new System.Drawing.Point(396, 202);
            this.labelaccionCorrectiva.Name = "labelaccionCorrectiva";
            this.labelaccionCorrectiva.Size = new System.Drawing.Size(155, 16);
            this.labelaccionCorrectiva.TabIndex = 57;
            this.labelaccionCorrectiva.Text = "Acciòn Correctiva Retrabajo";
            this.labelaccionCorrectiva.Visible = false;
            // 
            // textBoxAccionCorrectiva
            // 
            this.textBoxAccionCorrectiva.Enabled = false;
            this.textBoxAccionCorrectiva.Location = new System.Drawing.Point(547, 202);
            this.textBoxAccionCorrectiva.Multiline = true;
            this.textBoxAccionCorrectiva.Name = "textBoxAccionCorrectiva";
            this.textBoxAccionCorrectiva.Size = new System.Drawing.Size(311, 72);
            this.textBoxAccionCorrectiva.TabIndex = 58;
            this.textBoxAccionCorrectiva.Visible = false;
            // 
            // dataGridViewDibujoDimenciones
            // 
            this.dataGridViewDibujoDimenciones.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewDibujoDimenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDibujoDimenciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Medida});
            this.dataGridViewDibujoDimenciones.Location = new System.Drawing.Point(246, 288);
            this.dataGridViewDibujoDimenciones.Name = "dataGridViewDibujoDimenciones";
            this.dataGridViewDibujoDimenciones.Size = new System.Drawing.Size(642, 212);
            this.dataGridViewDibujoDimenciones.TabIndex = 59;
            this.dataGridViewDibujoDimenciones.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Dimensión Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Dimensión Definida";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Dimensión Medida";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // Medida
            // 
            this.Medida.HeaderText = "Medida";
            this.Medida.Name = "Medida";
            this.Medida.Width = 150;
            // 
            // Forma_Calidad_Operaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 522);
            this.Controls.Add(this.dataGridViewDibujoDimenciones);
            this.Controls.Add(this.textBoxAccionCorrectiva);
            this.Controls.Add(this.labelaccionCorrectiva);
            this.Controls.Add(this.textBoxMotivoRechazo);
            this.Controls.Add(this.labelDescripcionRechazo);
            this.Controls.Add(this.buttonBuscarSecuenciaDibujo);
            this.Controls.Add(this.dataGridViewSecuenciasCalidad);
            this.Controls.Add(this.textBoxCalidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNumeroDibujo);
            this.Controls.Add(this.textBoxNumeroDibujo);
            this.Controls.Add(this.comboBoxNombreProceso);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.comboBoxEmpleado);
            this.Controls.Add(this.buttonBorrarBasedeDatos);
            this.Controls.Add(this.textBoxNombreProceso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEmpleado);
            this.Controls.Add(this.labelEmpleado);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonGuardarBasedeDatos);
            this.Controls.Add(this.buttonBuscarDibujo);
            this.Controls.Add(this.buttonDesecho);
            this.Controls.Add(this.buttonRetrabajo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Forma_Calidad_Operaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calidad Operaciones";
            this.Load += new System.EventHandler(this.Forma_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecuenciasCalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDibujoDimenciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRetrabajo;
        private System.Windows.Forms.Button buttonDesecho;
        private System.Windows.Forms.Button buttonBuscarDibujo;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonGuardarBasedeDatos;
        private System.Windows.Forms.Label labelEmpleado;
        private System.Windows.Forms.TextBox textBoxEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombreProceso;
        private System.Windows.Forms.Button buttonBorrarBasedeDatos;
        private System.Windows.Forms.Timer timerInciarProcesoBusqueda;
        private System.Windows.Forms.ComboBox comboBoxEmpleado;
        private System.Windows.Forms.Timer timerActualizrempleado;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Timer timerEliminaempleado;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.ComboBox comboBoxNombreProceso;
        private System.Windows.Forms.TextBox textBoxNumeroDibujo;
        private System.Windows.Forms.Label labelNumeroDibujo;
        private System.Windows.Forms.TextBox textBoxCalidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSecuenciasCalidad;
        private System.Windows.Forms.Button buttonBuscarSecuenciaDibujo;
        private System.Windows.Forms.TextBox textBoxMotivoRechazo;
        private System.Windows.Forms.Label labelDescripcionRechazo;
        private System.Windows.Forms.Label labelaccionCorrectiva;
        private System.Windows.Forms.TextBox textBoxAccionCorrectiva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Dibujo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proceso;
        private System.Windows.Forms.DataGridView dataGridViewDibujoDimenciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medida;
    }
}