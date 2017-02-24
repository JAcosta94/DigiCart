namespace WindowsFormsApplication
{
    partial class ModificarEliminarFuenteRSS
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
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.lbl_indiceBusqueda = new System.Windows.Forms.Label();
            this.rb_descripcion = new System.Windows.Forms.RadioButton();
            this.rb_url = new System.Windows.Forms.RadioButton();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.DGV_Fuentes = new System.Windows.Forms.DataGridView();
            this.Url_fuente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_fuente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_asociar = new System.Windows.Forms.Button();
            this.gb_buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Fuentes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.Location = new System.Drawing.Point(602, 121);
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
            this.lbl_texto.Size = new System.Drawing.Size(330, 13);
            this.lbl_texto.TabIndex = 15;
            this.lbl_texto.Text = "Seleccione una Fuente RSS y luego clickee en la opcion que desee";
            // 
            // gb_buscar
            // 
            this.gb_buscar.Controls.Add(this.txt_busqueda);
            this.gb_buscar.Controls.Add(this.lbl_indiceBusqueda);
            this.gb_buscar.Controls.Add(this.rb_descripcion);
            this.gb_buscar.Controls.Add(this.rb_url);
            this.gb_buscar.Controls.Add(this.btn_buscar);
            this.gb_buscar.Location = new System.Drawing.Point(15, 267);
            this.gb_buscar.Name = "gb_buscar";
            this.gb_buscar.Size = new System.Drawing.Size(681, 127);
            this.gb_buscar.TabIndex = 14;
            this.gb_buscar.TabStop = false;
            this.gb_buscar.Text = "Buscar Fuente RSS";
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Location = new System.Drawing.Point(270, 40);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(146, 20);
            this.txt_busqueda.TabIndex = 6;
            // 
            // lbl_indiceBusqueda
            // 
            this.lbl_indiceBusqueda.AutoSize = true;
            this.lbl_indiceBusqueda.Location = new System.Drawing.Point(169, 40);
            this.lbl_indiceBusqueda.Name = "lbl_indiceBusqueda";
            this.lbl_indiceBusqueda.Size = new System.Drawing.Size(95, 26);
            this.lbl_indiceBusqueda.TabIndex = 5;
            this.lbl_indiceBusqueda.Text = "Seleccione un tipo\r\n de busqueda";
            // 
            // rb_descripcion
            // 
            this.rb_descripcion.AutoSize = true;
            this.rb_descripcion.Location = new System.Drawing.Point(369, 91);
            this.rb_descripcion.Name = "rb_descripcion";
            this.rb_descripcion.Size = new System.Drawing.Size(148, 17);
            this.rb_descripcion.TabIndex = 3;
            this.rb_descripcion.TabStop = true;
            this.rb_descripcion.Text = "Busqueda por descripcion";
            this.rb_descripcion.UseVisualStyleBackColor = true;
            this.rb_descripcion.CheckedChanged += new System.EventHandler(this.rb_descripcion_CheckedChanged);
            // 
            // rb_url
            // 
            this.rb_url.AutoSize = true;
            this.rb_url.Location = new System.Drawing.Point(211, 91);
            this.rb_url.Name = "rb_url";
            this.rb_url.Size = new System.Drawing.Size(116, 17);
            this.rb_url.TabIndex = 2;
            this.rb_url.TabStop = true;
            this.rb_url.Text = "Busqueda por URL";
            this.rb_url.UseVisualStyleBackColor = true;
            this.rb_url.CheckedChanged += new System.EventHandler(this.rb_url_CheckedChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(441, 40);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(89, 24);
            this.btn_buscar.TabIndex = 0;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(621, 411);
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
            this.btn_eliminar.Location = new System.Drawing.Point(602, 74);
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
            this.btn_modificar.Location = new System.Drawing.Point(602, 25);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(94, 23);
            this.btn_modificar.TabIndex = 11;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // DGV_Fuentes
            // 
            this.DGV_Fuentes.AllowUserToAddRows = false;
            this.DGV_Fuentes.AllowUserToDeleteRows = false;
            this.DGV_Fuentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Fuentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Url_fuente,
            this.Descripcion_fuente,
            this.Id});
            this.DGV_Fuentes.Location = new System.Drawing.Point(15, 25);
            this.DGV_Fuentes.Name = "DGV_Fuentes";
            this.DGV_Fuentes.ReadOnly = true;
            this.DGV_Fuentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Fuentes.Size = new System.Drawing.Size(553, 215);
            this.DGV_Fuentes.TabIndex = 10;
            this.DGV_Fuentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Fuentes_CellClick);
            // 
            // Url_fuente
            // 
            this.Url_fuente.HeaderText = "URL fuente";
            this.Url_fuente.Name = "Url_fuente";
            this.Url_fuente.ReadOnly = true;
            this.Url_fuente.Width = 350;
            // 
            // Descripcion_fuente
            // 
            this.Descripcion_fuente.HeaderText = "Descripcion fuente";
            this.Descripcion_fuente.Name = "Descripcion_fuente";
            this.Descripcion_fuente.ReadOnly = true;
            this.Descripcion_fuente.Width = 159;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // btn_asociar
            // 
            this.btn_asociar.Location = new System.Drawing.Point(384, 411);
            this.btn_asociar.Name = "btn_asociar";
            this.btn_asociar.Size = new System.Drawing.Size(90, 23);
            this.btn_asociar.TabIndex = 17;
            this.btn_asociar.Text = "Asociar fuente";
            this.btn_asociar.UseVisualStyleBackColor = true;
            this.btn_asociar.Visible = false;
            this.btn_asociar.Click += new System.EventHandler(this.btn_asociar_Click);
            // 
            // ModificarEliminarFuenteRSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 446);
            this.Controls.Add(this.btn_asociar);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.lbl_texto);
            this.Controls.Add(this.gb_buscar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.DGV_Fuentes);
            this.Name = "ModificarEliminarFuenteRSS";
            this.Text = "ModificarEliminarFuenteRSS";
            this.Load += new System.EventHandler(this.ModificarEliminarFuenteRSS_Load);
            this.gb_buscar.ResumeLayout(false);
            this.gb_buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Fuentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.Label lbl_texto;
        private System.Windows.Forms.GroupBox gb_buscar;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Label lbl_indiceBusqueda;
        private System.Windows.Forms.RadioButton rb_descripcion;
        private System.Windows.Forms.RadioButton rb_url;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.DataGridView DGV_Fuentes;
        private System.Windows.Forms.Button btn_asociar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Url_fuente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_fuente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;

    }
}