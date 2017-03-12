namespace WindowsFormsApplication
{
    partial class AgregarCampaña
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
            this.lbl_horaInicio = new System.Windows.Forms.Label();
            this.lbl_horaFin = new System.Windows.Forms.Label();
            this.btn_buscarImagen = new System.Windows.Forms.Button();
            this.btn_agregarImagen = new System.Windows.Forms.Button();
            this.gb_horarios = new System.Windows.Forms.GroupBox();
            this.dtp_fechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtp_fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txt_nombreCampaña = new System.Windows.Forms.TextBox();
            this.lbl_nombreCampaña = new System.Windows.Forms.Label();
            this.lbl_informacion = new System.Windows.Forms.Label();
            this.lbl_FechaInicio = new System.Windows.Forms.Label();
            this.lbl_FechaFin = new System.Windows.Forms.Label();
            this.mtxt_horaFin = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_horaInicio = new System.Windows.Forms.MaskedTextBox();
            this.gb_imagen = new System.Windows.Forms.GroupBox();
            this.btn_modificarImagen = new System.Windows.Forms.Button();
            this.txt_posicion = new System.Windows.Forms.TextBox();
            this.lbl_posicion = new System.Windows.Forms.Label();
            this.mtxt_duracionImagen = new System.Windows.Forms.MaskedTextBox();
            this.btn_quitarImagen = new System.Windows.Forms.Button();
            this.DGV_imagenes = new System.Windows.Forms.DataGridView();
            this.Ruta_imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posicion_campaña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion_imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_rutaImagen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_guardarCampaña = new System.Windows.Forms.Button();
            this.OFD_buscarImagen = new System.Windows.Forms.OpenFileDialog();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.gb_horarios.SuspendLayout();
            this.gb_imagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_imagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_horaInicio
            // 
            this.lbl_horaInicio.AutoSize = true;
            this.lbl_horaInicio.Location = new System.Drawing.Point(14, 91);
            this.lbl_horaInicio.Name = "lbl_horaInicio";
            this.lbl_horaInicio.Size = new System.Drawing.Size(134, 13);
            this.lbl_horaInicio.TabIndex = 2;
            this.lbl_horaInicio.Text = "Hora de inicio de campaña";
            // 
            // lbl_horaFin
            // 
            this.lbl_horaFin.AutoSize = true;
            this.lbl_horaFin.Location = new System.Drawing.Point(377, 91);
            this.lbl_horaFin.Name = "lbl_horaFin";
            this.lbl_horaFin.Size = new System.Drawing.Size(121, 13);
            this.lbl_horaFin.TabIndex = 3;
            this.lbl_horaFin.Text = "Hora de fin de campaña";
            // 
            // btn_buscarImagen
            // 
            this.btn_buscarImagen.Location = new System.Drawing.Point(447, 26);
            this.btn_buscarImagen.Name = "btn_buscarImagen";
            this.btn_buscarImagen.Size = new System.Drawing.Size(89, 23);
            this.btn_buscarImagen.TabIndex = 5;
            this.btn_buscarImagen.Text = "Buscar imagen";
            this.btn_buscarImagen.UseVisualStyleBackColor = true;
            this.btn_buscarImagen.Click += new System.EventHandler(this.btn_buscarImagen_Click);
            // 
            // btn_agregarImagen
            // 
            this.btn_agregarImagen.Location = new System.Drawing.Point(571, 26);
            this.btn_agregarImagen.Name = "btn_agregarImagen";
            this.btn_agregarImagen.Size = new System.Drawing.Size(98, 23);
            this.btn_agregarImagen.TabIndex = 9;
            this.btn_agregarImagen.Text = "Agregar imagen";
            this.btn_agregarImagen.UseVisualStyleBackColor = true;
            this.btn_agregarImagen.Click += new System.EventHandler(this.btn_agregarImagen_Click);
            // 
            // gb_horarios
            // 
            this.gb_horarios.Controls.Add(this.dtp_fechaFin);
            this.gb_horarios.Controls.Add(this.dtp_fechaInicio);
            this.gb_horarios.Controls.Add(this.txt_nombreCampaña);
            this.gb_horarios.Controls.Add(this.lbl_nombreCampaña);
            this.gb_horarios.Controls.Add(this.lbl_informacion);
            this.gb_horarios.Controls.Add(this.lbl_FechaInicio);
            this.gb_horarios.Controls.Add(this.lbl_FechaFin);
            this.gb_horarios.Controls.Add(this.mtxt_horaFin);
            this.gb_horarios.Controls.Add(this.mtxt_horaInicio);
            this.gb_horarios.Controls.Add(this.lbl_horaFin);
            this.gb_horarios.Controls.Add(this.lbl_horaInicio);
            this.gb_horarios.Location = new System.Drawing.Point(24, 26);
            this.gb_horarios.Name = "gb_horarios";
            this.gb_horarios.Size = new System.Drawing.Size(719, 170);
            this.gb_horarios.TabIndex = 10;
            this.gb_horarios.TabStop = false;
            this.gb_horarios.Text = "Informacion de la campaña";
            // 
            // dtp_fechaFin
            // 
            this.dtp_fechaFin.Location = new System.Drawing.Point(513, 55);
            this.dtp_fechaFin.Name = "dtp_fechaFin";
            this.dtp_fechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtp_fechaFin.TabIndex = 12;
            // 
            // dtp_fechaInicio
            // 
            this.dtp_fechaInicio.Location = new System.Drawing.Point(174, 55);
            this.dtp_fechaInicio.Name = "dtp_fechaInicio";
            this.dtp_fechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtp_fechaInicio.TabIndex = 11;
            // 
            // txt_nombreCampaña
            // 
            this.txt_nombreCampaña.Location = new System.Drawing.Point(174, 24);
            this.txt_nombreCampaña.Name = "txt_nombreCampaña";
            this.txt_nombreCampaña.Size = new System.Drawing.Size(218, 20);
            this.txt_nombreCampaña.TabIndex = 10;
            // 
            // lbl_nombreCampaña
            // 
            this.lbl_nombreCampaña.AutoSize = true;
            this.lbl_nombreCampaña.Location = new System.Drawing.Point(30, 27);
            this.lbl_nombreCampaña.Name = "lbl_nombreCampaña";
            this.lbl_nombreCampaña.Size = new System.Drawing.Size(118, 13);
            this.lbl_nombreCampaña.TabIndex = 9;
            this.lbl_nombreCampaña.Text = "Nombre de la Campaña";
            // 
            // lbl_informacion
            // 
            this.lbl_informacion.AutoSize = true;
            this.lbl_informacion.Enabled = false;
            this.lbl_informacion.Location = new System.Drawing.Point(16, 123);
            this.lbl_informacion.Name = "lbl_informacion";
            this.lbl_informacion.Size = new System.Drawing.Size(0, 13);
            this.lbl_informacion.TabIndex = 8;
            // 
            // lbl_FechaInicio
            // 
            this.lbl_FechaInicio.AutoSize = true;
            this.lbl_FechaInicio.Location = new System.Drawing.Point(79, 61);
            this.lbl_FechaInicio.Name = "lbl_FechaInicio";
            this.lbl_FechaInicio.Size = new System.Drawing.Size(64, 13);
            this.lbl_FechaInicio.TabIndex = 4;
            this.lbl_FechaInicio.Text = "Fecha inicio";
            // 
            // lbl_FechaFin
            // 
            this.lbl_FechaFin.AutoSize = true;
            this.lbl_FechaFin.Location = new System.Drawing.Point(444, 61);
            this.lbl_FechaFin.Name = "lbl_FechaFin";
            this.lbl_FechaFin.Size = new System.Drawing.Size(54, 13);
            this.lbl_FechaFin.TabIndex = 6;
            this.lbl_FechaFin.Text = "Fecha fin ";
            // 
            // mtxt_horaFin
            // 
            this.mtxt_horaFin.Location = new System.Drawing.Point(513, 88);
            this.mtxt_horaFin.Mask = "00:00:00";
            this.mtxt_horaFin.Name = "mtxt_horaFin";
            this.mtxt_horaFin.Size = new System.Drawing.Size(100, 20);
            this.mtxt_horaFin.TabIndex = 3;
            this.mtxt_horaFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt_horaFin.Enter += new System.EventHandler(this.mtxt_horaFin_Enter);
            this.mtxt_horaFin.Leave += new System.EventHandler(this.mtxt_horaFin_Leave);
            // 
            // mtxt_horaInicio
            // 
            this.mtxt_horaInicio.Location = new System.Drawing.Point(174, 88);
            this.mtxt_horaInicio.Mask = "00:00:00";
            this.mtxt_horaInicio.Name = "mtxt_horaInicio";
            this.mtxt_horaInicio.Size = new System.Drawing.Size(100, 20);
            this.mtxt_horaInicio.TabIndex = 2;
            this.mtxt_horaInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt_horaInicio.Enter += new System.EventHandler(this.mtxt_horaInicio_Enter);
            this.mtxt_horaInicio.Leave += new System.EventHandler(this.mtxt_horaInicio_Leave);
            // 
            // gb_imagen
            // 
            this.gb_imagen.Controls.Add(this.btn_limpiar);
            this.gb_imagen.Controls.Add(this.btn_modificarImagen);
            this.gb_imagen.Controls.Add(this.txt_posicion);
            this.gb_imagen.Controls.Add(this.lbl_posicion);
            this.gb_imagen.Controls.Add(this.mtxt_duracionImagen);
            this.gb_imagen.Controls.Add(this.btn_quitarImagen);
            this.gb_imagen.Controls.Add(this.DGV_imagenes);
            this.gb_imagen.Controls.Add(this.label6);
            this.gb_imagen.Controls.Add(this.txt_rutaImagen);
            this.gb_imagen.Controls.Add(this.label5);
            this.gb_imagen.Controls.Add(this.btn_buscarImagen);
            this.gb_imagen.Controls.Add(this.btn_agregarImagen);
            this.gb_imagen.Location = new System.Drawing.Point(24, 202);
            this.gb_imagen.Name = "gb_imagen";
            this.gb_imagen.Size = new System.Drawing.Size(719, 299);
            this.gb_imagen.TabIndex = 11;
            this.gb_imagen.TabStop = false;
            this.gb_imagen.Text = "Imágenes de la campaña";
            // 
            // btn_modificarImagen
            // 
            this.btn_modificarImagen.Enabled = false;
            this.btn_modificarImagen.Location = new System.Drawing.Point(571, 55);
            this.btn_modificarImagen.Name = "btn_modificarImagen";
            this.btn_modificarImagen.Size = new System.Drawing.Size(98, 40);
            this.btn_modificarImagen.TabIndex = 20;
            this.btn_modificarImagen.Text = "Modificar datos imagen";
            this.btn_modificarImagen.UseVisualStyleBackColor = true;
            this.btn_modificarImagen.Click += new System.EventHandler(this.btn_modificarImagen_Click);
            // 
            // txt_posicion
            // 
            this.txt_posicion.Location = new System.Drawing.Point(146, 99);
            this.txt_posicion.Name = "txt_posicion";
            this.txt_posicion.Size = new System.Drawing.Size(100, 20);
            this.txt_posicion.TabIndex = 19;
            // 
            // lbl_posicion
            // 
            this.lbl_posicion.AutoSize = true;
            this.lbl_posicion.Location = new System.Drawing.Point(16, 93);
            this.lbl_posicion.Name = "lbl_posicion";
            this.lbl_posicion.Size = new System.Drawing.Size(113, 26);
            this.lbl_posicion.TabIndex = 18;
            this.lbl_posicion.Text = "Posicion de la imagen \r\n           en la campaña";
            // 
            // mtxt_duracionImagen
            // 
            this.mtxt_duracionImagen.Location = new System.Drawing.Point(146, 63);
            this.mtxt_duracionImagen.Mask = "00:00:00";
            this.mtxt_duracionImagen.Name = "mtxt_duracionImagen";
            this.mtxt_duracionImagen.Size = new System.Drawing.Size(100, 20);
            this.mtxt_duracionImagen.TabIndex = 17;
            this.mtxt_duracionImagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_quitarImagen
            // 
            this.btn_quitarImagen.Enabled = false;
            this.btn_quitarImagen.Location = new System.Drawing.Point(571, 104);
            this.btn_quitarImagen.Name = "btn_quitarImagen";
            this.btn_quitarImagen.Size = new System.Drawing.Size(98, 21);
            this.btn_quitarImagen.TabIndex = 16;
            this.btn_quitarImagen.Text = "Quitar imagen";
            this.btn_quitarImagen.UseVisualStyleBackColor = true;
            this.btn_quitarImagen.Click += new System.EventHandler(this.btn_quitarImagen_Click);
            // 
            // DGV_imagenes
            // 
            this.DGV_imagenes.AllowUserToAddRows = false;
            this.DGV_imagenes.AllowUserToDeleteRows = false;
            this.DGV_imagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_imagenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ruta_imagen,
            this.Posicion_campaña,
            this.Duracion_imagen,
            this.agregar,
            this.modificar,
            this.Id});
            this.DGV_imagenes.Location = new System.Drawing.Point(39, 144);
            this.DGV_imagenes.Name = "DGV_imagenes";
            this.DGV_imagenes.ReadOnly = true;
            this.DGV_imagenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_imagenes.Size = new System.Drawing.Size(630, 140);
            this.DGV_imagenes.TabIndex = 15;
            this.DGV_imagenes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_imagenes_CellClick);
            // 
            // Ruta_imagen
            // 
            this.Ruta_imagen.HeaderText = "Ruta imagen";
            this.Ruta_imagen.Name = "Ruta_imagen";
            this.Ruta_imagen.ReadOnly = true;
            this.Ruta_imagen.Width = 320;
            // 
            // Posicion_campaña
            // 
            this.Posicion_campaña.HeaderText = "Posicion en campaña";
            this.Posicion_campaña.Name = "Posicion_campaña";
            this.Posicion_campaña.ReadOnly = true;
            this.Posicion_campaña.Width = 90;
            // 
            // Duracion_imagen
            // 
            this.Duracion_imagen.HeaderText = "Duracion Imagen";
            this.Duracion_imagen.Name = "Duracion_imagen";
            this.Duracion_imagen.ReadOnly = true;
            this.Duracion_imagen.Width = 110;
            // 
            // agregar
            // 
            this.agregar.HeaderText = "agregar";
            this.agregar.Name = "agregar";
            this.agregar.ReadOnly = true;
            this.agregar.Visible = false;
            // 
            // modificar
            // 
            this.modificar.HeaderText = "modificar";
            this.modificar.Name = "modificar";
            this.modificar.ReadOnly = true;
            this.modificar.Visible = false;
            // 
            // Id
            // 
            this.Id.HeaderText = "IdImagen";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Duración";
            // 
            // txt_rutaImagen
            // 
            this.txt_rutaImagen.Location = new System.Drawing.Point(146, 28);
            this.txt_rutaImagen.Name = "txt_rutaImagen";
            this.txt_rutaImagen.Size = new System.Drawing.Size(237, 20);
            this.txt_rutaImagen.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ruta de la imagen";
            // 
            // btn_guardarCampaña
            // 
            this.btn_guardarCampaña.Location = new System.Drawing.Point(448, 539);
            this.btn_guardarCampaña.Name = "btn_guardarCampaña";
            this.btn_guardarCampaña.Size = new System.Drawing.Size(102, 23);
            this.btn_guardarCampaña.TabIndex = 12;
            this.btn_guardarCampaña.Text = "Guardar campaña";
            this.btn_guardarCampaña.UseVisualStyleBackColor = true;
            this.btn_guardarCampaña.Click += new System.EventHandler(this.btn_guardarCampaña_Click);
            // 
            // OFD_buscarImagen
            // 
            this.OFD_buscarImagen.FileName = "openFileDialog1";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(686, 539);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.Location = new System.Drawing.Point(571, 538);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(98, 24);
            this.btn_ayuda.TabIndex = 4;
            this.btn_ayuda.Text = "Ayuda";
            this.btn_ayuda.UseVisualStyleBackColor = true;
            this.btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(447, 72);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(89, 23);
            this.btn_limpiar.TabIndex = 21;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // AgregarCampaña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 574);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardarCampaña);
            this.Controls.Add(this.gb_imagen);
            this.Controls.Add(this.gb_horarios);
            this.Name = "AgregarCampaña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Campaña";
            this.Load += new System.EventHandler(this.Campañas_Load);
            this.gb_horarios.ResumeLayout(false);
            this.gb_horarios.PerformLayout();
            this.gb_imagen.ResumeLayout(false);
            this.gb_imagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_imagenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_horaInicio;
        private System.Windows.Forms.Label lbl_horaFin;
        private System.Windows.Forms.Button btn_buscarImagen;
        private System.Windows.Forms.Button btn_agregarImagen;
        private System.Windows.Forms.GroupBox gb_horarios;
        private System.Windows.Forms.GroupBox gb_imagen;
        private System.Windows.Forms.DataGridView DGV_imagenes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_rutaImagen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_guardarCampaña;
        private System.Windows.Forms.MaskedTextBox mtxt_horaFin;
        private System.Windows.Forms.MaskedTextBox mtxt_horaInicio;
        private System.Windows.Forms.Button btn_quitarImagen;
        private System.Windows.Forms.MaskedTextBox mtxt_duracionImagen;
        private System.Windows.Forms.OpenFileDialog OFD_buscarImagen;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.Label lbl_posicion;
        private System.Windows.Forms.TextBox txt_posicion;
        private System.Windows.Forms.Button btn_modificarImagen;
        private System.Windows.Forms.Label lbl_FechaInicio;
        private System.Windows.Forms.Label lbl_FechaFin;
        private System.Windows.Forms.Label lbl_informacion;
        private System.Windows.Forms.TextBox txt_nombreCampaña;
        private System.Windows.Forms.Label lbl_nombreCampaña;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta_imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicion_campaña;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion_imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DateTimePicker dtp_fechaFin;
        private System.Windows.Forms.DateTimePicker dtp_fechaInicio;
        private System.Windows.Forms.Button btn_limpiar;
    }
}