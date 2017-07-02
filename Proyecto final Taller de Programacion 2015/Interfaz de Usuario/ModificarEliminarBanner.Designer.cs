﻿namespace WindowsFormsApplication
{
    partial class ModificarEliminarBanner
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
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.lbl_texto = new System.Windows.Forms.Label();
            this.gb_buscar = new System.Windows.Forms.GroupBox();
            this.mtxt_fin = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_inicio = new System.Windows.Forms.MaskedTextBox();
            this.lbl_fin = new System.Windows.Forms.Label();
            this.rb_intervaloHorario = new System.Windows.Forms.RadioButton();
            this.rb_intervaloDias = new System.Windows.Forms.RadioButton();
            this.lbl_inicio = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.DGV_Banners = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Banner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.gb_buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Banners)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.Location = new System.Drawing.Point(660, 118);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(94, 23);
            this.btn_ayuda.TabIndex = 16;
            this.btn_ayuda.Text = "Ayuda";
            this.btn_ayuda.UseVisualStyleBackColor = true;
            // 
            // lbl_texto
            // 
            this.lbl_texto.AutoSize = true;
            this.lbl_texto.Location = new System.Drawing.Point(12, 9);
            this.lbl_texto.Name = "lbl_texto";
            this.lbl_texto.Size = new System.Drawing.Size(299, 13);
            this.lbl_texto.TabIndex = 15;
            this.lbl_texto.Text = "Seleccione un banner y luego clickee en la opcion que desee";
            // 
            // gb_buscar
            // 
            this.gb_buscar.Controls.Add(this.btn_limpiar);
            this.gb_buscar.Controls.Add(this.mtxt_fin);
            this.gb_buscar.Controls.Add(this.mtxt_inicio);
            this.gb_buscar.Controls.Add(this.lbl_fin);
            this.gb_buscar.Controls.Add(this.rb_intervaloHorario);
            this.gb_buscar.Controls.Add(this.rb_intervaloDias);
            this.gb_buscar.Controls.Add(this.lbl_inicio);
            this.gb_buscar.Controls.Add(this.btn_buscar);
            this.gb_buscar.Location = new System.Drawing.Point(15, 256);
            this.gb_buscar.Name = "gb_buscar";
            this.gb_buscar.Size = new System.Drawing.Size(739, 124);
            this.gb_buscar.TabIndex = 14;
            this.gb_buscar.TabStop = false;
            this.gb_buscar.Text = "Buscar banner";
            // 
            // mtxt_fin
            // 
            this.mtxt_fin.Location = new System.Drawing.Point(300, 51);
            this.mtxt_fin.Mask = "00/00/0000";
            this.mtxt_fin.Name = "mtxt_fin";
            this.mtxt_fin.Size = new System.Drawing.Size(123, 20);
            this.mtxt_fin.TabIndex = 7;
            this.mtxt_fin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt_fin.ValidatingType = typeof(System.DateTime);
            // 
            // mtxt_inicio
            // 
            this.mtxt_inicio.Location = new System.Drawing.Point(300, 19);
            this.mtxt_inicio.Mask = "00/00/0000";
            this.mtxt_inicio.Name = "mtxt_inicio";
            this.mtxt_inicio.Size = new System.Drawing.Size(123, 20);
            this.mtxt_inicio.TabIndex = 6;
            this.mtxt_inicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt_inicio.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_fin
            // 
            this.lbl_fin.AutoSize = true;
            this.lbl_fin.Location = new System.Drawing.Point(213, 54);
            this.lbl_fin.Name = "lbl_fin";
            this.lbl_fin.Size = new System.Drawing.Size(21, 13);
            this.lbl_fin.TabIndex = 5;
            this.lbl_fin.Text = "Fin";
            // 
            // rb_intervaloHorario
            // 
            this.rb_intervaloHorario.AutoSize = true;
            this.rb_intervaloHorario.Location = new System.Drawing.Point(384, 90);
            this.rb_intervaloHorario.Name = "rb_intervaloHorario";
            this.rb_intervaloHorario.Size = new System.Drawing.Size(169, 17);
            this.rb_intervaloHorario.TabIndex = 3;
            this.rb_intervaloHorario.TabStop = true;
            this.rb_intervaloHorario.Text = "Busqueda por intervalo horario";
            this.rb_intervaloHorario.UseVisualStyleBackColor = true;
            this.rb_intervaloHorario.CheckedChanged += new System.EventHandler(this.rb_intervaloHorario_CheckedChanged);
            // 
            // rb_intervaloDias
            // 
            this.rb_intervaloDias.AutoSize = true;
            this.rb_intervaloDias.Location = new System.Drawing.Point(183, 90);
            this.rb_intervaloDias.Name = "rb_intervaloDias";
            this.rb_intervaloDias.Size = new System.Drawing.Size(171, 17);
            this.rb_intervaloDias.TabIndex = 2;
            this.rb_intervaloDias.TabStop = true;
            this.rb_intervaloDias.Text = "Busqueda por intervalo de dias";
            this.rb_intervaloDias.UseVisualStyleBackColor = true;
            this.rb_intervaloDias.CheckedChanged += new System.EventHandler(this.rb_intervaloDias_CheckedChanged);
            // 
            // lbl_inicio
            // 
            this.lbl_inicio.AutoSize = true;
            this.lbl_inicio.Location = new System.Drawing.Point(202, 22);
            this.lbl_inicio.Name = "lbl_inicio";
            this.lbl_inicio.Size = new System.Drawing.Size(32, 13);
            this.lbl_inicio.TabIndex = 1;
            this.lbl_inicio.Text = "Inicio";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(482, 16);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(89, 24);
            this.btn_buscar.TabIndex = 0;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(658, 400);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 13;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Enabled = false;
            this.btn_eliminar.Location = new System.Drawing.Point(660, 72);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(94, 23);
            this.btn_eliminar.TabIndex = 12;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Enabled = false;
            this.btn_modificar.Location = new System.Drawing.Point(660, 25);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(94, 23);
            this.btn_modificar.TabIndex = 11;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // DGV_Banners
            // 
            this.DGV_Banners.AllowUserToAddRows = false;
            this.DGV_Banners.AllowUserToDeleteRows = false;
            this.DGV_Banners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Banners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Hora_inicio,
            this.Hora_fin,
            this.Fecha_inicio,
            this.Fecha_fin,
            this.Tipo_Banner});
            this.DGV_Banners.Location = new System.Drawing.Point(15, 25);
            this.DGV_Banners.Name = "DGV_Banners";
            this.DGV_Banners.ReadOnly = true;
            this.DGV_Banners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Banners.Size = new System.Drawing.Size(622, 215);
            this.DGV_Banners.TabIndex = 10;
            this.DGV_Banners.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Banners_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "bannerId";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Hora_inicio
            // 
            this.Hora_inicio.DataPropertyName = "horaInicio";
            this.Hora_inicio.HeaderText = "Hora incio";
            this.Hora_inicio.Name = "Hora_inicio";
            this.Hora_inicio.ReadOnly = true;
            this.Hora_inicio.Width = 115;
            // 
            // Hora_fin
            // 
            this.Hora_fin.DataPropertyName = "horaFin";
            this.Hora_fin.HeaderText = "Hora fin";
            this.Hora_fin.Name = "Hora_fin";
            this.Hora_fin.ReadOnly = true;
            this.Hora_fin.Width = 115;
            // 
            // Fecha_inicio
            // 
            this.Fecha_inicio.DataPropertyName = "fechaInicio";
            this.Fecha_inicio.HeaderText = "Fecha inicio";
            this.Fecha_inicio.Name = "Fecha_inicio";
            this.Fecha_inicio.ReadOnly = true;
            this.Fecha_inicio.Width = 113;
            // 
            // Fecha_fin
            // 
            this.Fecha_fin.DataPropertyName = "fechaFin";
            this.Fecha_fin.HeaderText = "Fecha fin";
            this.Fecha_fin.Name = "Fecha_fin";
            this.Fecha_fin.ReadOnly = true;
            this.Fecha_fin.Width = 115;
            // 
            // Tipo_Banner
            // 
            this.Tipo_Banner.HeaderText = "Tipo Banner";
            this.Tipo_Banner.Name = "Tipo_Banner";
            this.Tipo_Banner.ReadOnly = true;
            this.Tipo_Banner.Width = 120;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(482, 51);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(89, 24);
            this.btn_limpiar.TabIndex = 8;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // ModificarEliminarBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 432);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.lbl_texto);
            this.Controls.Add(this.gb_buscar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.DGV_Banners);
            this.Name = "ModificarEliminarBanner";
            this.Text = "Modificar/Eliminar Banner(s)";
            this.Load += new System.EventHandler(this.ModificarEliminarBanner_Load);
            this.gb_buscar.ResumeLayout(false);
            this.gb_buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Banners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.Label lbl_texto;
        private System.Windows.Forms.GroupBox gb_buscar;
        private System.Windows.Forms.Label lbl_fin;
        private System.Windows.Forms.RadioButton rb_intervaloHorario;
        private System.Windows.Forms.RadioButton rb_intervaloDias;
        private System.Windows.Forms.Label lbl_inicio;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.DataGridView DGV_Banners;
        private System.Windows.Forms.MaskedTextBox mtxt_inicio;
        private System.Windows.Forms.MaskedTextBox mtxt_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Banner;
        private System.Windows.Forms.Button btn_limpiar;

    }
}