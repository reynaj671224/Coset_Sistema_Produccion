namespace Coset_Sistema_Produccion
{
    partial class Forma_Dibujos_Cnc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma_Dibujos_Cnc));
            this.textBoxEmpleado = new System.Windows.Forms.TextBox();
            this.textBoxNombreProceso = new System.Windows.Forms.TextBox();
            this.timerInciarProcesoBusqueda = new System.Windows.Forms.Timer(this.components);
            this.comboBoxEmpleado = new System.Windows.Forms.ComboBox();
            this.timerActualizrempleado = new System.Windows.Forms.Timer(this.components);
            this.timerEliminaempleado = new System.Windows.Forms.Timer(this.components);
            this.comboBoxNombreProceso = new System.Windows.Forms.ComboBox();
            this.textBoxNumeroDibujo = new System.Windows.Forms.TextBox();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.textBoxProyecto = new System.Windows.Forms.TextBox();
            this.dataGridViewSecuenciasProduccion = new System.Windows.Forms.DataGridView();
            this.Codigo_partida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Dibujo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inicio_Proceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Final_Proceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxHorasProceso = new System.Windows.Forms.TextBox();
            this.textBoxHorasRetrabajo = new System.Windows.Forms.TextBox();
            this.textBoxUnidades = new System.Windows.Forms.TextBox();
            this.dataGridViewProduccionDibujos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calidad_dibujo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proyecto_dibujo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonBuscarSecuenciaDibujo = new System.Windows.Forms.Button();
            this.labelFechaFinal = new System.Windows.Forms.Label();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelProyecto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNumeroDibujo = new System.Windows.Forms.Label();
            this.buttonIncioProceso = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonBorrarBasedeDatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEmpleado = new System.Windows.Forms.Label();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonGuardarBasedeDatos = new System.Windows.Forms.Button();
            this.buttonBuscarDibujo = new System.Windows.Forms.Button();
            this.buttonTerminarProceso = new System.Windows.Forms.Button();
            this.buttonPausaProceso = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecuenciasProduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduccionDibujos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxEmpleado
            // 
            this.textBoxEmpleado.Enabled = false;
            this.textBoxEmpleado.Location = new System.Drawing.Point(171, 121);
            this.textBoxEmpleado.Name = "textBoxEmpleado";
            this.textBoxEmpleado.Size = new System.Drawing.Size(196, 20);
            this.textBoxEmpleado.TabIndex = 7;
            // 
            // textBoxNombreProceso
            // 
            this.textBoxNombreProceso.Enabled = false;
            this.textBoxNombreProceso.Location = new System.Drawing.Point(171, 174);
            this.textBoxNombreProceso.Name = "textBoxNombreProceso";
            this.textBoxNombreProceso.Size = new System.Drawing.Size(196, 20);
            this.textBoxNombreProceso.TabIndex = 9;
            // 
            // timerInciarProcesoBusqueda
            // 
            this.timerInciarProcesoBusqueda.Interval = 1000;
            this.timerInciarProcesoBusqueda.Tick += new System.EventHandler(this.timerInciarProcesoBusqueda_Tick);
            // 
            // comboBoxEmpleado
            // 
            this.comboBoxEmpleado.FormattingEnabled = true;
            this.comboBoxEmpleado.Location = new System.Drawing.Point(171, 122);
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
            // timerEliminaempleado
            // 
            this.timerEliminaempleado.Interval = 1000;
            this.timerEliminaempleado.Tick += new System.EventHandler(this.timerEliminaempleado_Tick);
            // 
            // comboBoxNombreProceso
            // 
            this.comboBoxNombreProceso.FormattingEnabled = true;
            this.comboBoxNombreProceso.Location = new System.Drawing.Point(171, 174);
            this.comboBoxNombreProceso.Name = "comboBoxNombreProceso";
            this.comboBoxNombreProceso.Size = new System.Drawing.Size(196, 21);
            this.comboBoxNombreProceso.TabIndex = 28;
            this.comboBoxNombreProceso.Visible = false;
            this.comboBoxNombreProceso.SelectedIndexChanged += new System.EventHandler(this.comboBoxNombreEmpleado_SelectedIndexChanged);
            // 
            // textBoxNumeroDibujo
            // 
            this.textBoxNumeroDibujo.Location = new System.Drawing.Point(171, 147);
            this.textBoxNumeroDibujo.Name = "textBoxNumeroDibujo";
            this.textBoxNumeroDibujo.Size = new System.Drawing.Size(196, 20);
            this.textBoxNumeroDibujo.TabIndex = 29;
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Enabled = false;
            this.textBoxEstado.Location = new System.Drawing.Point(171, 200);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(196, 20);
            this.textBoxEstado.TabIndex = 32;
            // 
            // textBoxProyecto
            // 
            this.textBoxProyecto.Enabled = false;
            this.textBoxProyecto.Location = new System.Drawing.Point(171, 225);
            this.textBoxProyecto.Name = "textBoxProyecto";
            this.textBoxProyecto.Size = new System.Drawing.Size(196, 20);
            this.textBoxProyecto.TabIndex = 34;
            // 
            // dataGridViewSecuenciasProduccion
            // 
            this.dataGridViewSecuenciasProduccion.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewSecuenciasProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSecuenciasProduccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_partida,
            this.Numero_Dibujo,
            this.Empleado,
            this.Inicio_Proceso,
            this.Final_Proceso,
            this.Proceso,
            this.Estado,
            this.Calidad,
            this.Tiempo});
            this.dataGridViewSecuenciasProduccion.Location = new System.Drawing.Point(22, 298);
            this.dataGridViewSecuenciasProduccion.Name = "dataGridViewSecuenciasProduccion";
            this.dataGridViewSecuenciasProduccion.Size = new System.Drawing.Size(994, 202);
            this.dataGridViewSecuenciasProduccion.TabIndex = 49;
            this.dataGridViewSecuenciasProduccion.Visible = false;
            // 
            // Codigo_partida
            // 
            this.Codigo_partida.HeaderText = "Codigo";
            this.Codigo_partida.Name = "Codigo_partida";
            this.Codigo_partida.Visible = false;
            this.Codigo_partida.Width = 50;
            // 
            // Numero_Dibujo
            // 
            this.Numero_Dibujo.HeaderText = "Numero Dibujo";
            this.Numero_Dibujo.Name = "Numero_Dibujo";
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            this.Empleado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Empleado.Width = 150;
            // 
            // Inicio_Proceso
            // 
            this.Inicio_Proceso.HeaderText = "Inicio Proceso";
            this.Inicio_Proceso.Name = "Inicio_Proceso";
            this.Inicio_Proceso.Width = 150;
            // 
            // Final_Proceso
            // 
            this.Final_Proceso.HeaderText = "Final Proceso";
            this.Final_Proceso.Name = "Final_Proceso";
            this.Final_Proceso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Final_Proceso.Width = 150;
            // 
            // Proceso
            // 
            this.Proceso.HeaderText = "Proceso";
            this.Proceso.Name = "Proceso";
            this.Proceso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Calidad
            // 
            this.Calidad.HeaderText = "Calidad";
            this.Calidad.Name = "Calidad";
            // 
            // Tiempo
            // 
            this.Tiempo.HeaderText = "Tiempo";
            this.Tiempo.Name = "Tiempo";
            // 
            // textBoxHorasProceso
            // 
            this.textBoxHorasProceso.Enabled = false;
            this.textBoxHorasProceso.Location = new System.Drawing.Point(532, 145);
            this.textBoxHorasProceso.Name = "textBoxHorasProceso";
            this.textBoxHorasProceso.Size = new System.Drawing.Size(124, 20);
            this.textBoxHorasProceso.TabIndex = 51;
            // 
            // textBoxHorasRetrabajo
            // 
            this.textBoxHorasRetrabajo.Enabled = false;
            this.textBoxHorasRetrabajo.Location = new System.Drawing.Point(532, 171);
            this.textBoxHorasRetrabajo.Name = "textBoxHorasRetrabajo";
            this.textBoxHorasRetrabajo.Size = new System.Drawing.Size(124, 20);
            this.textBoxHorasRetrabajo.TabIndex = 53;
            // 
            // textBoxUnidades
            // 
            this.textBoxUnidades.Enabled = false;
            this.textBoxUnidades.Location = new System.Drawing.Point(171, 250);
            this.textBoxUnidades.Name = "textBoxUnidades";
            this.textBoxUnidades.Size = new System.Drawing.Size(94, 20);
            this.textBoxUnidades.TabIndex = 56;
            // 
            // dataGridViewProduccionDibujos
            // 
            this.dataGridViewProduccionDibujos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewProduccionDibujos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduccionDibujos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Calidad_dibujo,
            this.Proyecto_dibujo});
            this.dataGridViewProduccionDibujos.Location = new System.Drawing.Point(135, 298);
            this.dataGridViewProduccionDibujos.Name = "dataGridViewProduccionDibujos";
            this.dataGridViewProduccionDibujos.Size = new System.Drawing.Size(699, 202);
            this.dataGridViewProduccionDibujos.TabIndex = 57;
            this.dataGridViewProduccionDibujos.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Numero Dibujo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Empleado";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Proceso";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Calidad_dibujo
            // 
            this.Calidad_dibujo.HeaderText = "Calidad Dibujo";
            this.Calidad_dibujo.Name = "Calidad_dibujo";
            // 
            // Proyecto_dibujo
            // 
            this.Proyecto_dibujo.HeaderText = "Proyecto";
            this.Proyecto_dibujo.Name = "Proyecto_dibujo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(43, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "Unidades";
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
            this.buttonBuscarSecuenciaDibujo.Click += new System.EventHandler(this.buttonBuscarSecuenciaDibujo_Click);
            // 
            // labelFechaFinal
            // 
            this.labelFechaFinal.AutoSize = true;
            this.labelFechaFinal.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaFinal.Image = ((System.Drawing.Image)(resources.GetObject("labelFechaFinal.Image")));
            this.labelFechaFinal.Location = new System.Drawing.Point(404, 173);
            this.labelFechaFinal.Name = "labelFechaFinal";
            this.labelFechaFinal.Size = new System.Drawing.Size(68, 16);
            this.labelFechaFinal.TabIndex = 52;
            this.labelFechaFinal.Text = "Fecha Final";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaInicio.Image = ((System.Drawing.Image)(resources.GetObject("labelFechaInicio.Image")));
            this.labelFechaInicio.Location = new System.Drawing.Point(404, 147);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(67, 16);
            this.labelFechaInicio.TabIndex = 50;
            this.labelFechaInicio.Text = "Fecha Incio";
            // 
            // labelProyecto
            // 
            this.labelProyecto.AutoSize = true;
            this.labelProyecto.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProyecto.Image = ((System.Drawing.Image)(resources.GetObject("labelProyecto.Image")));
            this.labelProyecto.Location = new System.Drawing.Point(43, 227);
            this.labelProyecto.Name = "labelProyecto";
            this.labelProyecto.Size = new System.Drawing.Size(53, 16);
            this.labelProyecto.TabIndex = 33;
            this.labelProyecto.Text = "Proyecto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(43, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Estado";
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
            // buttonIncioProceso
            // 
            this.buttonIncioProceso.BackColor = System.Drawing.Color.White;
            this.buttonIncioProceso.Enabled = false;
            this.buttonIncioProceso.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIncioProceso.Image = ((System.Drawing.Image)(resources.GetObject("buttonIncioProceso.Image")));
            this.buttonIncioProceso.Location = new System.Drawing.Point(377, 12);
            this.buttonIncioProceso.Name = "buttonIncioProceso";
            this.buttonIncioProceso.Size = new System.Drawing.Size(79, 74);
            this.buttonIncioProceso.TabIndex = 27;
            this.buttonIncioProceso.Text = "Inicio";
            this.buttonIncioProceso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonIncioProceso.UseVisualStyleBackColor = false;
            this.buttonIncioProceso.Click += new System.EventHandler(this.buttonIncioProceso_Click);
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
            // buttonBuscarDibujo
            // 
            this.buttonBuscarDibujo.BackColor = System.Drawing.Color.White;
            this.buttonBuscarDibujo.Enabled = false;
            this.buttonBuscarDibujo.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarDibujo.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarDibujo.Image")));
            this.buttonBuscarDibujo.Location = new System.Drawing.Point(547, 12);
            this.buttonBuscarDibujo.Name = "buttonBuscarDibujo";
            this.buttonBuscarDibujo.Size = new System.Drawing.Size(79, 74);
            this.buttonBuscarDibujo.TabIndex = 3;
            this.buttonBuscarDibujo.Text = "Buscar";
            this.buttonBuscarDibujo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBuscarDibujo.UseVisualStyleBackColor = false;
            this.buttonBuscarDibujo.Click += new System.EventHandler(this.buttonBuscarDibujo_Click);
            // 
            // buttonTerminarProceso
            // 
            this.buttonTerminarProceso.AutoSize = true;
            this.buttonTerminarProceso.BackColor = System.Drawing.Color.White;
            this.buttonTerminarProceso.Enabled = false;
            this.buttonTerminarProceso.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTerminarProceso.Image = ((System.Drawing.Image)(resources.GetObject("buttonTerminarProceso.Image")));
            this.buttonTerminarProceso.Location = new System.Drawing.Point(462, 12);
            this.buttonTerminarProceso.Name = "buttonTerminarProceso";
            this.buttonTerminarProceso.Size = new System.Drawing.Size(79, 74);
            this.buttonTerminarProceso.TabIndex = 2;
            this.buttonTerminarProceso.Text = "Terminar";
            this.buttonTerminarProceso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonTerminarProceso.UseVisualStyleBackColor = false;
            this.buttonTerminarProceso.Click += new System.EventHandler(this.buttonTerminarProceso_Click);
            // 
            // buttonPausaProceso
            // 
            this.buttonPausaProceso.AutoSize = true;
            this.buttonPausaProceso.BackColor = System.Drawing.Color.White;
            this.buttonPausaProceso.Enabled = false;
            this.buttonPausaProceso.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPausaProceso.Image = ((System.Drawing.Image)(resources.GetObject("buttonPausaProceso.Image")));
            this.buttonPausaProceso.Location = new System.Drawing.Point(632, 12);
            this.buttonPausaProceso.Name = "buttonPausaProceso";
            this.buttonPausaProceso.Size = new System.Drawing.Size(79, 74);
            this.buttonPausaProceso.TabIndex = 1;
            this.buttonPausaProceso.Text = "Pausa";
            this.buttonPausaProceso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPausaProceso.UseVisualStyleBackColor = false;
            this.buttonPausaProceso.Visible = false;
            this.buttonPausaProceso.Click += new System.EventHandler(this.buttonPausaProceso_Click);
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
            // Forma_Dibujos_Cnc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 522);
            this.Controls.Add(this.dataGridViewProduccionDibujos);
            this.Controls.Add(this.textBoxUnidades);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonBuscarSecuenciaDibujo);
            this.Controls.Add(this.textBoxHorasRetrabajo);
            this.Controls.Add(this.labelFechaFinal);
            this.Controls.Add(this.textBoxHorasProceso);
            this.Controls.Add(this.labelFechaInicio);
            this.Controls.Add(this.dataGridViewSecuenciasProduccion);
            this.Controls.Add(this.textBoxProyecto);
            this.Controls.Add(this.labelProyecto);
            this.Controls.Add(this.textBoxEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNumeroDibujo);
            this.Controls.Add(this.textBoxNumeroDibujo);
            this.Controls.Add(this.comboBoxNombreProceso);
            this.Controls.Add(this.buttonIncioProceso);
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
            this.Controls.Add(this.buttonTerminarProceso);
            this.Controls.Add(this.buttonPausaProceso);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Forma_Dibujos_Cnc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dibujos CNC";
            this.Load += new System.EventHandler(this.Forma_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecuenciasProduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduccionDibujos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPausaProceso;
        private System.Windows.Forms.Button buttonTerminarProceso;
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
        private System.Windows.Forms.Button buttonIncioProceso;
        private System.Windows.Forms.ComboBox comboBoxNombreProceso;
        private System.Windows.Forms.TextBox textBoxNumeroDibujo;
        private System.Windows.Forms.Label labelNumeroDibujo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.TextBox textBoxProyecto;
        private System.Windows.Forms.Label labelProyecto;
        private System.Windows.Forms.DataGridView dataGridViewSecuenciasProduccion;
        private System.Windows.Forms.TextBox textBoxHorasProceso;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.TextBox textBoxHorasRetrabajo;
        private System.Windows.Forms.Label labelFechaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Dibujo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicio_Proceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Final_Proceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
        private System.Windows.Forms.Button buttonBuscarSecuenciaDibujo;
        private System.Windows.Forms.TextBox textBoxUnidades;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewProduccionDibujos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calidad_dibujo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proyecto_dibujo;
    }
}