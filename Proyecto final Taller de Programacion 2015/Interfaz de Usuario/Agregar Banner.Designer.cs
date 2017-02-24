namespace WindowsFormsApplication
{
    partial class Formulario_Banner
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
            this.gb_horarios = new System.Windows.Forms.GroupBox();
            this.mtxt_horaFin = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_horaInicio = new System.Windows.Forms.MaskedTextBox();
            this.lbl_horaFin = new System.Windows.Forms.Label();
            this.lbl_horaInicio = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.rb_fuenteRSS = new System.Windows.Forms.RadioButton();
            this.rb_textoFijo = new System.Windows.Forms.RadioButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.gb_tipoBanner = new System.Windows.Forms.GroupBox();
            this.btn_configurarBanner = new System.Windows.Forms.Button();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.lbl_FechaInicio = new System.Windows.Forms.Label();
            this.lbl_FechaFin = new System.Windows.Forms.Label();
            this.mtxt_fechaInicio = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_fechaFin = new System.Windows.Forms.MaskedTextBox();
            this.gb_horarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.gb_tipoBanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_horarios
            // 
            this.gb_horarios.Controls.Add(this.lbl_FechaInicio);
            this.gb_horarios.Controls.Add(this.lbl_FechaFin);
            this.gb_horarios.Controls.Add(this.mtxt_fechaInicio);
            this.gb_horarios.Controls.Add(this.mtxt_fechaFin);
            this.gb_horarios.Controls.Add(this.mtxt_horaFin);
            this.gb_horarios.Controls.Add(this.mtxt_horaInicio);
            this.gb_horarios.Controls.Add(this.lbl_horaFin);
            this.gb_horarios.Controls.Add(this.lbl_horaInicio);
            this.gb_horarios.Location = new System.Drawing.Point(12, 12);
            this.gb_horarios.Name = "gb_horarios";
            this.gb_horarios.Size = new System.Drawing.Size(629, 111);
            this.gb_horarios.TabIndex = 11;
            this.gb_horarios.TabStop = false;
            this.gb_horarios.Text = "Horario del banner";
            // 
            // mtxt_horaFin
            // 
            this.mtxt_horaFin.Location = new System.Drawing.Point(493, 27);
            this.mtxt_horaFin.Mask = "00:00:00";
            this.mtxt_horaFin.Name = "mtxt_horaFin";
            this.mtxt_horaFin.Size = new System.Drawing.Size(100, 20);
            this.mtxt_horaFin.TabIndex = 3;
            this.mtxt_horaFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxt_horaInicio
            // 
            this.mtxt_horaInicio.Location = new System.Drawing.Point(172, 23);
            this.mtxt_horaInicio.Mask = "00:00:00";
            this.mtxt_horaInicio.Name = "mtxt_horaInicio";
            this.mtxt_horaInicio.Size = new System.Drawing.Size(100, 20);
            this.mtxt_horaInicio.TabIndex = 2;
            this.mtxt_horaInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_horaFin
            // 
            this.lbl_horaFin.AutoSize = true;
            this.lbl_horaFin.Location = new System.Drawing.Point(354, 30);
            this.lbl_horaFin.Name = "lbl_horaFin";
            this.lbl_horaFin.Size = new System.Drawing.Size(112, 13);
            this.lbl_horaFin.TabIndex = 3;
            this.lbl_horaFin.Text = "Hora de fin del banner";
            // 
            // lbl_horaInicio
            // 
            this.lbl_horaInicio.AutoSize = true;
            this.lbl_horaInicio.Location = new System.Drawing.Point(29, 30);
            this.lbl_horaInicio.Name = "lbl_horaInicio";
            this.lbl_horaInicio.Size = new System.Drawing.Size(125, 13);
            this.lbl_horaInicio.TabIndex = 2;
            this.lbl_horaInicio.Text = "Hora de inicio del banner";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(334, 250);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(98, 24);
            this.btn_guardar.TabIndex = 13;
            this.btn_guardar.Text = "Guardar banner";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(542, 250);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(98, 24);
            this.btn_cancelar.TabIndex = 14;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // rb_fuenteRSS
            // 
            this.rb_fuenteRSS.AutoSize = true;
            this.rb_fuenteRSS.Location = new System.Drawing.Point(32, 39);
            this.rb_fuenteRSS.Name = "rb_fuenteRSS";
            this.rb_fuenteRSS.Size = new System.Drawing.Size(83, 17);
            this.rb_fuenteRSS.TabIndex = 16;
            this.rb_fuenteRSS.TabStop = true;
            this.rb_fuenteRSS.Text = "Fuente RSS";
            this.rb_fuenteRSS.UseVisualStyleBackColor = true;
            // 
            // rb_textoFijo
            // 
            this.rb_textoFijo.AutoSize = true;
            this.rb_textoFijo.Location = new System.Drawing.Point(255, 39);
            this.rb_textoFijo.Name = "rb_textoFijo";
            this.rb_textoFijo.Size = new System.Drawing.Size(68, 17);
            this.rb_textoFijo.TabIndex = 17;
            this.rb_textoFijo.TabStop = true;
            this.rb_textoFijo.Text = "Texto fijo";
            this.rb_textoFijo.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // gb_tipoBanner
            // 
            this.gb_tipoBanner.Controls.Add(this.btn_configurarBanner);
            this.gb_tipoBanner.Controls.Add(this.rb_fuenteRSS);
            this.gb_tipoBanner.Controls.Add(this.rb_textoFijo);
            this.gb_tipoBanner.Location = new System.Drawing.Point(12, 150);
            this.gb_tipoBanner.Name = "gb_tipoBanner";
            this.gb_tipoBanner.Size = new System.Drawing.Size(629, 74);
            this.gb_tipoBanner.TabIndex = 18;
            this.gb_tipoBanner.TabStop = false;
            this.gb_tipoBanner.Text = "Tipo de banner";
            // 
            // btn_configurarBanner
            // 
            this.btn_configurarBanner.Location = new System.Drawing.Point(472, 33);
            this.btn_configurarBanner.Name = "btn_configurarBanner";
            this.btn_configurarBanner.Size = new System.Drawing.Size(121, 23);
            this.btn_configurarBanner.TabIndex = 18;
            this.btn_configurarBanner.Text = "Configurar banner";
            this.btn_configurarBanner.UseVisualStyleBackColor = true;
            this.btn_configurarBanner.Click += new System.EventHandler(this.btn_configurarBanner_Click);
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.Location = new System.Drawing.Point(438, 250);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(98, 23);
            this.btn_ayuda.TabIndex = 11;
            this.btn_ayuda.Text = "Ayuda";
            this.btn_ayuda.UseVisualStyleBackColor = true;
            // 
            // lbl_FechaInicio
            // 
            this.lbl_FechaInicio.AutoSize = true;
            this.lbl_FechaInicio.Location = new System.Drawing.Point(90, 74);
            this.lbl_FechaInicio.Name = "lbl_FechaInicio";
            this.lbl_FechaInicio.Size = new System.Drawing.Size(64, 13);
            this.lbl_FechaInicio.TabIndex = 9;
            this.lbl_FechaInicio.Text = "Fecha inicio";
            // 
            // lbl_FechaFin
            // 
            this.lbl_FechaFin.AutoSize = true;
            this.lbl_FechaFin.Location = new System.Drawing.Point(412, 74);
            this.lbl_FechaFin.Name = "lbl_FechaFin";
            this.lbl_FechaFin.Size = new System.Drawing.Size(54, 13);
            this.lbl_FechaFin.TabIndex = 11;
            this.lbl_FechaFin.Text = "Fecha fin ";
            // 
            // mtxt_fechaInicio
            // 
            this.mtxt_fechaInicio.Location = new System.Drawing.Point(172, 71);
            this.mtxt_fechaInicio.Mask = "00/00/0000";
            this.mtxt_fechaInicio.Name = "mtxt_fechaInicio";
            this.mtxt_fechaInicio.Size = new System.Drawing.Size(100, 20);
            this.mtxt_fechaInicio.TabIndex = 10;
            this.mtxt_fechaInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt_fechaInicio.ValidatingType = typeof(System.DateTime);
            // 
            // mtxt_fechaFin
            // 
            this.mtxt_fechaFin.Location = new System.Drawing.Point(493, 71);
            this.mtxt_fechaFin.Mask = "00/00/0000";
            this.mtxt_fechaFin.Name = "mtxt_fechaFin";
            this.mtxt_fechaFin.Size = new System.Drawing.Size(100, 20);
            this.mtxt_fechaFin.TabIndex = 12;
            this.mtxt_fechaFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt_fechaFin.ValidatingType = typeof(System.DateTime);
            // 
            // Formulario_Banner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 294);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.gb_tipoBanner);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.gb_horarios);
            this.Name = "Formulario_Banner";
            this.Text = "Nuevo Banner";
            this.Load += new System.EventHandler(this.banner_Load);
            this.gb_horarios.ResumeLayout(false);
            this.gb_horarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.gb_tipoBanner.ResumeLayout(false);
            this.gb_tipoBanner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_horarios;
        private System.Windows.Forms.MaskedTextBox mtxt_horaFin;
        private System.Windows.Forms.MaskedTextBox mtxt_horaInicio;
        private System.Windows.Forms.Label lbl_horaFin;
        private System.Windows.Forms.Label lbl_horaInicio;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.RadioButton rb_fuenteRSS;
        private System.Windows.Forms.RadioButton rb_textoFijo;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox gb_tipoBanner;
        private System.Windows.Forms.Button btn_configurarBanner;
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.Label lbl_FechaInicio;
        private System.Windows.Forms.Label lbl_FechaFin;
        private System.Windows.Forms.MaskedTextBox mtxt_fechaInicio;
        private System.Windows.Forms.MaskedTextBox mtxt_fechaFin;

    }
}