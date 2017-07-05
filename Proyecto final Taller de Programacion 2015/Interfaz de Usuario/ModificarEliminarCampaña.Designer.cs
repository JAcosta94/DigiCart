namespace WindowsFormsApplication
{
    partial class ModificarEliminarCampaña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarEliminarCampaña));
            this.DGV_Campañas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.gb_buscar = new System.Windows.Forms.GroupBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.mtxt_inicio = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_fin = new System.Windows.Forms.MaskedTextBox();
            this.lbl_fin = new System.Windows.Forms.Label();
            this.rb_intervaloHorario = new System.Windows.Forms.RadioButton();
            this.rb_intervaloFechas = new System.Windows.Forms.RadioButton();
            this.lbl_inicio = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Campañas)).BeginInit();
            this.gb_buscar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Campañas
            // 
            this.DGV_Campañas.AllowUserToAddRows = false;
            this.DGV_Campañas.AllowUserToDeleteRows = false;
            this.DGV_Campañas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Campañas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.iNombre,
            this.Hora_inicio,
            this.Hora_fin,
            this.Fecha_inicio,
            this.Fecha_fin});
            this.DGV_Campañas.Location = new System.Drawing.Point(15, 20);
            this.DGV_Campañas.Name = "DGV_Campañas";
            this.DGV_Campañas.ReadOnly = true;
            this.DGV_Campañas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Campañas.Size = new System.Drawing.Size(723, 193);
            this.DGV_Campañas.TabIndex = 1;
            this.DGV_Campañas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Campañas_CellClick);
            this.DGV_Campañas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Campañas_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "campaniaId";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // iNombre
            // 
            this.iNombre.DataPropertyName = "iNombre";
            this.iNombre.HeaderText = "Nombre";
            this.iNombre.Name = "iNombre";
            this.iNombre.ReadOnly = true;
            // 
            // Hora_inicio
            // 
            this.Hora_inicio.DataPropertyName = "HoraInicio";
            this.Hora_inicio.HeaderText = "Hora inicio";
            this.Hora_inicio.Name = "Hora_inicio";
            this.Hora_inicio.ReadOnly = true;
            this.Hora_inicio.Width = 130;
            // 
            // Hora_fin
            // 
            this.Hora_fin.DataPropertyName = "HoraFin";
            this.Hora_fin.HeaderText = "Hora fin";
            this.Hora_fin.Name = "Hora_fin";
            this.Hora_fin.ReadOnly = true;
            this.Hora_fin.Width = 130;
            // 
            // Fecha_inicio
            // 
            this.Fecha_inicio.DataPropertyName = "FechaInicio";
            this.Fecha_inicio.HeaderText = "Fecha inicio";
            this.Fecha_inicio.Name = "Fecha_inicio";
            this.Fecha_inicio.ReadOnly = true;
            this.Fecha_inicio.Width = 158;
            // 
            // Fecha_fin
            // 
            this.Fecha_fin.DataPropertyName = "FechaFin";
            this.Fecha_fin.HeaderText = "Fecha fin";
            this.Fecha_fin.Name = "Fecha_fin";
            this.Fecha_fin.ReadOnly = true;
            this.Fecha_fin.Width = 160;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Enabled = false;
            this.btn_modificar.Location = new System.Drawing.Point(246, 219);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(110, 27);
            this.btn_modificar.TabIndex = 2;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Enabled = false;
            this.btn_eliminar.Location = new System.Drawing.Point(373, 219);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(110, 27);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(681, 434);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(87, 27);
            this.btn_salir.TabIndex = 11;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // gb_buscar
            // 
            this.gb_buscar.Controls.Add(this.btn_limpiar);
            this.gb_buscar.Controls.Add(this.rb_intervaloHorario);
            this.gb_buscar.Controls.Add(this.lbl_fin);
            this.gb_buscar.Controls.Add(this.mtxt_fin);
            this.gb_buscar.Controls.Add(this.rb_intervaloFechas);
            this.gb_buscar.Controls.Add(this.btn_buscar);
            this.gb_buscar.Controls.Add(this.mtxt_inicio);
            this.gb_buscar.Controls.Add(this.lbl_inicio);
            this.gb_buscar.Location = new System.Drawing.Point(12, 12);
            this.gb_buscar.Name = "gb_buscar";
            this.gb_buscar.Size = new System.Drawing.Size(756, 122);
            this.gb_buscar.TabIndex = 7;
            this.gb_buscar.TabStop = false;
            this.gb_buscar.Text = "Filtrar listado";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(618, 72);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(104, 28);
            this.btn_limpiar.TabIndex = 10;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // mtxt_inicio
            // 
            this.mtxt_inicio.Location = new System.Drawing.Point(161, 76);
            this.mtxt_inicio.Mask = "00/00/0000";
            this.mtxt_inicio.Name = "mtxt_inicio";
            this.mtxt_inicio.Size = new System.Drawing.Size(132, 21);
            this.mtxt_inicio.TabIndex = 7;
            this.mtxt_inicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt_inicio.ValidatingType = typeof(System.DateTime);
            // 
            // mtxt_fin
            // 
            this.mtxt_fin.Location = new System.Drawing.Point(415, 76);
            this.mtxt_fin.Mask = "00/00/0000";
            this.mtxt_fin.Name = "mtxt_fin";
            this.mtxt_fin.Size = new System.Drawing.Size(132, 21);
            this.mtxt_fin.TabIndex = 8;
            this.mtxt_fin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt_fin.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_fin
            // 
            this.lbl_fin.AutoSize = true;
            this.lbl_fin.Location = new System.Drawing.Point(336, 79);
            this.lbl_fin.Name = "lbl_fin";
            this.lbl_fin.Size = new System.Drawing.Size(61, 15);
            this.lbl_fin.TabIndex = 5;
            this.lbl_fin.Text = "Fecha Fin";
            // 
            // rb_intervaloHorario
            // 
            this.rb_intervaloHorario.AutoSize = true;
            this.rb_intervaloHorario.Location = new System.Drawing.Point(373, 28);
            this.rb_intervaloHorario.Name = "rb_intervaloHorario";
            this.rb_intervaloHorario.Size = new System.Drawing.Size(78, 19);
            this.rb_intervaloHorario.TabIndex = 6;
            this.rb_intervaloHorario.Text = "Por horas";
            this.rb_intervaloHorario.UseVisualStyleBackColor = true;
            this.rb_intervaloHorario.CheckedChanged += new System.EventHandler(this.rb_intervaloHorario_CheckedChanged);
            // 
            // rb_intervaloFechas
            // 
            this.rb_intervaloFechas.AutoSize = true;
            this.rb_intervaloFechas.Checked = true;
            this.rb_intervaloFechas.Location = new System.Drawing.Point(165, 28);
            this.rb_intervaloFechas.Name = "rb_intervaloFechas";
            this.rb_intervaloFechas.Size = new System.Drawing.Size(83, 19);
            this.rb_intervaloFechas.TabIndex = 5;
            this.rb_intervaloFechas.TabStop = true;
            this.rb_intervaloFechas.Text = "Por fechas";
            this.rb_intervaloFechas.UseVisualStyleBackColor = true;
            this.rb_intervaloFechas.CheckedChanged += new System.EventHandler(this.rb_intervaloFechas_CheckedChanged);
            // 
            // lbl_inicio
            // 
            this.lbl_inicio.AutoSize = true;
            this.lbl_inicio.Location = new System.Drawing.Point(64, 79);
            this.lbl_inicio.Name = "lbl_inicio";
            this.lbl_inicio.Size = new System.Drawing.Size(73, 15);
            this.lbl_inicio.TabIndex = 1;
            this.lbl_inicio.Text = "Fecha Inicio";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(618, 28);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(104, 28);
            this.btn_buscar.TabIndex = 9;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.Location = new System.Drawing.Point(574, 434);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(87, 27);
            this.btn_ayuda.TabIndex = 4;
            this.btn_ayuda.Text = "Ayuda";
            this.btn_ayuda.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_Campañas);
            this.groupBox1.Controls.Add(this.btn_modificar);
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Location = new System.Drawing.Point(12, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 258);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una Campaña y haga clic en la opción que desee";
            // 
            // ModificarEliminarCampaña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(793, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.gb_buscar);
            this.Controls.Add(this.btn_salir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarEliminarCampaña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Modificar/Eliminar Campaña(s)";
            this.Load += new System.EventHandler(this.ModificarEliminarCampaña_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Campañas)).EndInit();
            this.gb_buscar.ResumeLayout(false);
            this.gb_buscar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Campañas;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.GroupBox gb_buscar;
        private System.Windows.Forms.Label lbl_fin;
        private System.Windows.Forms.RadioButton rb_intervaloHorario;
        private System.Windows.Forms.RadioButton rb_intervaloFechas;
        private System.Windows.Forms.Label lbl_inicio;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.MaskedTextBox mtxt_fin;
        private System.Windows.Forms.MaskedTextBox mtxt_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_fin;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}