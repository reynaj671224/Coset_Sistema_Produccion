﻿namespace Coset_Sistema_Produccion
{
    partial class Forma_Actividades_Procesos_Electricos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma_Actividades_Procesos_Electricos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonModificarProceso = new System.Windows.Forms.Button();
            this.buttonAgregarProceso = new System.Windows.Forms.Button();
            this.buttonEliminarProceso = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonGuardarBasedeDatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigoProceso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombreProceso = new System.Windows.Forms.TextBox();
            this.buttonBorrarBasedeDatos = new System.Windows.Forms.Button();
            this.timerAgregarProceso = new System.Windows.Forms.Timer(this.components);
            this.comboBoxCodigoProceso = new System.Windows.Forms.ComboBox();
            this.timerActualizarActividadesProceso = new System.Windows.Forms.Timer(this.components);
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.timerEliminarActividadProceso = new System.Windows.Forms.Timer(this.components);
            this.buttonBuscarProceso = new System.Windows.Forms.Button();
            this.comboBoxNombreProceso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxActividadProcesoElectrico = new System.Windows.Forms.ComboBox();
            this.textBoxActividadProcesoElectrico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNotasActividad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(795, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonModificarProceso
            // 
            this.buttonModificarProceso.AutoSize = true;
            this.buttonModificarProceso.BackColor = System.Drawing.Color.White;
            this.buttonModificarProceso.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarProceso.Image = ((System.Drawing.Image)(resources.GetObject("buttonModificarProceso.Image")));
            this.buttonModificarProceso.Location = new System.Drawing.Point(314, 12);
            this.buttonModificarProceso.Name = "buttonModificarProceso";
            this.buttonModificarProceso.Size = new System.Drawing.Size(79, 74);
            this.buttonModificarProceso.TabIndex = 1;
            this.buttonModificarProceso.Text = "Modificar";
            this.buttonModificarProceso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonModificarProceso.UseVisualStyleBackColor = false;
            this.buttonModificarProceso.Click += new System.EventHandler(this.buttonModificarUsuario_Click);
            // 
            // buttonAgregarProceso
            // 
            this.buttonAgregarProceso.AutoSize = true;
            this.buttonAgregarProceso.BackColor = System.Drawing.Color.White;
            this.buttonAgregarProceso.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarProceso.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregarProceso.Image")));
            this.buttonAgregarProceso.Location = new System.Drawing.Point(399, 12);
            this.buttonAgregarProceso.Name = "buttonAgregarProceso";
            this.buttonAgregarProceso.Size = new System.Drawing.Size(79, 74);
            this.buttonAgregarProceso.TabIndex = 2;
            this.buttonAgregarProceso.Text = "Agregar";
            this.buttonAgregarProceso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAgregarProceso.UseVisualStyleBackColor = false;
            this.buttonAgregarProceso.Click += new System.EventHandler(this.buttonAgregarUsuario_Click);
            // 
            // buttonEliminarProceso
            // 
            this.buttonEliminarProceso.BackColor = System.Drawing.Color.White;
            this.buttonEliminarProceso.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarProceso.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminarProceso.Image")));
            this.buttonEliminarProceso.Location = new System.Drawing.Point(484, 12);
            this.buttonEliminarProceso.Name = "buttonEliminarProceso";
            this.buttonEliminarProceso.Size = new System.Drawing.Size(79, 74);
            this.buttonEliminarProceso.TabIndex = 3;
            this.buttonEliminarProceso.Text = "Eliminar";
            this.buttonEliminarProceso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEliminarProceso.UseVisualStyleBackColor = false;
            this.buttonEliminarProceso.Click += new System.EventHandler(this.buttonEliminarUsuario_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.AutoSize = true;
            this.buttonHome.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(691, 251);
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
            this.buttonGuardarBasedeDatos.Location = new System.Drawing.Point(691, 93);
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
            this.label1.Image = global::Coset_Sistema_Produccion.Properties.Resources.fabulous_page_background_color_web_for_html_coloring_pages_671x419__1_;
            this.label1.Location = new System.Drawing.Point(14, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo Proceso Electrico";
            this.label1.Visible = false;
            // 
            // textBoxCodigoProceso
            // 
            this.textBoxCodigoProceso.Enabled = false;
            this.textBoxCodigoProceso.Location = new System.Drawing.Point(173, 110);
            this.textBoxCodigoProceso.Name = "textBoxCodigoProceso";
            this.textBoxCodigoProceso.Size = new System.Drawing.Size(388, 20);
            this.textBoxCodigoProceso.TabIndex = 7;
            this.textBoxCodigoProceso.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(14, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre Proceso Electrico";
            // 
            // textBoxNombreProceso
            // 
            this.textBoxNombreProceso.Enabled = false;
            this.textBoxNombreProceso.Location = new System.Drawing.Point(171, 143);
            this.textBoxNombreProceso.Name = "textBoxNombreProceso";
            this.textBoxNombreProceso.Size = new System.Drawing.Size(465, 20);
            this.textBoxNombreProceso.TabIndex = 9;
            // 
            // buttonBorrarBasedeDatos
            // 
            this.buttonBorrarBasedeDatos.AutoSize = true;
            this.buttonBorrarBasedeDatos.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrarBasedeDatos.Image = ((System.Drawing.Image)(resources.GetObject("buttonBorrarBasedeDatos.Image")));
            this.buttonBorrarBasedeDatos.Location = new System.Drawing.Point(691, 81);
            this.buttonBorrarBasedeDatos.Name = "buttonBorrarBasedeDatos";
            this.buttonBorrarBasedeDatos.Size = new System.Drawing.Size(79, 74);
            this.buttonBorrarBasedeDatos.TabIndex = 20;
            this.buttonBorrarBasedeDatos.Text = "Eliminar";
            this.buttonBorrarBasedeDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBorrarBasedeDatos.UseVisualStyleBackColor = true;
            this.buttonBorrarBasedeDatos.Visible = false;
            this.buttonBorrarBasedeDatos.Click += new System.EventHandler(this.buttonBorrarBasedeDatos_Click);
            // 
            // timerAgregarProceso
            // 
            this.timerAgregarProceso.Interval = 1000;
            this.timerAgregarProceso.Tick += new System.EventHandler(this.TimerAgregarUsuario_Tick);
            // 
            // comboBoxCodigoProceso
            // 
            this.comboBoxCodigoProceso.FormattingEnabled = true;
            this.comboBoxCodigoProceso.Location = new System.Drawing.Point(171, 110);
            this.comboBoxCodigoProceso.Name = "comboBoxCodigoProceso";
            this.comboBoxCodigoProceso.Size = new System.Drawing.Size(390, 21);
            this.comboBoxCodigoProceso.TabIndex = 25;
            this.comboBoxCodigoProceso.Visible = false;
            this.comboBoxCodigoProceso.SelectedIndexChanged += new System.EventHandler(this.comboBoxCodigoempleado_SelectedIndexChanged);
            // 
            // timerActualizarActividadesProceso
            // 
            this.timerActualizarActividadesProceso.Interval = 1000;
            this.timerActualizarActividadesProceso.Tick += new System.EventHandler(this.timerActualizarActividadesProceso_Tick);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AutoSize = true;
            this.buttonCancelar.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.Location = new System.Drawing.Point(691, 173);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(79, 74);
            this.buttonCancelar.TabIndex = 26;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Visible = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // timerEliminarActividadProceso
            // 
            this.timerEliminarActividadProceso.Interval = 1000;
            this.timerEliminarActividadProceso.Tick += new System.EventHandler(this.timerEliminarActividadProceso_Tick);
            // 
            // buttonBuscarProceso
            // 
            this.buttonBuscarProceso.BackColor = System.Drawing.Color.White;
            this.buttonBuscarProceso.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarProceso.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarProceso.Image")));
            this.buttonBuscarProceso.Location = new System.Drawing.Point(229, 12);
            this.buttonBuscarProceso.Name = "buttonBuscarProceso";
            this.buttonBuscarProceso.Size = new System.Drawing.Size(79, 74);
            this.buttonBuscarProceso.TabIndex = 27;
            this.buttonBuscarProceso.Text = "Visualizar";
            this.buttonBuscarProceso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBuscarProceso.UseVisualStyleBackColor = false;
            this.buttonBuscarProceso.Click += new System.EventHandler(this.buttonBuscarempleado_Click);
            // 
            // comboBoxNombreProceso
            // 
            this.comboBoxNombreProceso.FormattingEnabled = true;
            this.comboBoxNombreProceso.Location = new System.Drawing.Point(171, 143);
            this.comboBoxNombreProceso.Name = "comboBoxNombreProceso";
            this.comboBoxNombreProceso.Size = new System.Drawing.Size(465, 21);
            this.comboBoxNombreProceso.TabIndex = 28;
            this.comboBoxNombreProceso.Visible = false;
            this.comboBoxNombreProceso.SelectedIndexChanged += new System.EventHandler(this.comboBoxNombreEmpleado_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(14, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Actividad Proceso Electrico";
            // 
            // comboBoxActividadProcesoElectrico
            // 
            this.comboBoxActividadProcesoElectrico.FormattingEnabled = true;
            this.comboBoxActividadProcesoElectrico.Location = new System.Drawing.Point(171, 173);
            this.comboBoxActividadProcesoElectrico.Name = "comboBoxActividadProcesoElectrico";
            this.comboBoxActividadProcesoElectrico.Size = new System.Drawing.Size(465, 21);
            this.comboBoxActividadProcesoElectrico.TabIndex = 31;
            this.comboBoxActividadProcesoElectrico.Visible = false;
            this.comboBoxActividadProcesoElectrico.SelectedIndexChanged += new System.EventHandler(this.comboBoxActividadProcesoElectrico_SelectedIndexChanged);
            // 
            // textBoxActividadProcesoElectrico
            // 
            this.textBoxActividadProcesoElectrico.Enabled = false;
            this.textBoxActividadProcesoElectrico.Location = new System.Drawing.Point(173, 173);
            this.textBoxActividadProcesoElectrico.Name = "textBoxActividadProcesoElectrico";
            this.textBoxActividadProcesoElectrico.Size = new System.Drawing.Size(463, 20);
            this.textBoxActividadProcesoElectrico.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(14, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Notas Actividad";
            // 
            // textBoxNotasActividad
            // 
            this.textBoxNotasActividad.Enabled = false;
            this.textBoxNotasActividad.Location = new System.Drawing.Point(171, 212);
            this.textBoxNotasActividad.Multiline = true;
            this.textBoxNotasActividad.Name = "textBoxNotasActividad";
            this.textBoxNotasActividad.Size = new System.Drawing.Size(467, 57);
            this.textBoxNotasActividad.TabIndex = 33;
            // 
            // Forma_Actividades_Procesos_Electricos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 346);
            this.Controls.Add(this.textBoxNotasActividad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxActividadProcesoElectrico);
            this.Controls.Add(this.textBoxActividadProcesoElectrico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxNombreProceso);
            this.Controls.Add(this.buttonBuscarProceso);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.comboBoxCodigoProceso);
            this.Controls.Add(this.buttonBorrarBasedeDatos);
            this.Controls.Add(this.textBoxNombreProceso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCodigoProceso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonGuardarBasedeDatos);
            this.Controls.Add(this.buttonEliminarProceso);
            this.Controls.Add(this.buttonAgregarProceso);
            this.Controls.Add(this.buttonModificarProceso);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Forma_Actividades_Procesos_Electricos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actividades Procesos Electricos";
            this.Load += new System.EventHandler(this.Forma_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonModificarProceso;
        private System.Windows.Forms.Button buttonAgregarProceso;
        private System.Windows.Forms.Button buttonEliminarProceso;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonGuardarBasedeDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodigoProceso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombreProceso;
        private System.Windows.Forms.Button buttonBorrarBasedeDatos;
        private System.Windows.Forms.Timer timerAgregarProceso;
        private System.Windows.Forms.ComboBox comboBoxCodigoProceso;
        private System.Windows.Forms.Timer timerActualizarActividadesProceso;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Timer timerEliminarActividadProceso;
        private System.Windows.Forms.Button buttonBuscarProceso;
        private System.Windows.Forms.ComboBox comboBoxNombreProceso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxActividadProcesoElectrico;
        private System.Windows.Forms.TextBox textBoxActividadProcesoElectrico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNotasActividad;
    }
}