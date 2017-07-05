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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarEliminarFuenteRSS));
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.DGV_Fuentes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_fuente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Url_fuente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_RSS = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Fuentes)).BeginInit();
            this.gb_RSS.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.Location = new System.Drawing.Point(496, 348);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(87, 27);
            this.btn_ayuda.TabIndex = 16;
            this.btn_ayuda.Text = "Ayuda";
            this.btn_ayuda.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(588, 348);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(87, 27);
            this.btn_salir.TabIndex = 13;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Enabled = false;
            this.btn_eliminar.Location = new System.Drawing.Point(340, 240);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(110, 27);
            this.btn_eliminar.TabIndex = 12;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Enabled = false;
            this.btn_modificar.Location = new System.Drawing.Point(205, 240);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(110, 27);
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
            this.Id,
            this.Descripcion_fuente,
            this.Url_fuente});
            this.DGV_Fuentes.Location = new System.Drawing.Point(20, 29);
            this.DGV_Fuentes.Name = "DGV_Fuentes";
            this.DGV_Fuentes.ReadOnly = true;
            this.DGV_Fuentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Fuentes.Size = new System.Drawing.Size(599, 205);
            this.DGV_Fuentes.TabIndex = 10;
            this.DGV_Fuentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Fuentes_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Descripcion_fuente
            // 
            this.Descripcion_fuente.HeaderText = "Descripcion fuente";
            this.Descripcion_fuente.Name = "Descripcion_fuente";
            this.Descripcion_fuente.ReadOnly = true;
            this.Descripcion_fuente.Width = 159;
            // 
            // Url_fuente
            // 
            this.Url_fuente.HeaderText = "URL fuente";
            this.Url_fuente.Name = "Url_fuente";
            this.Url_fuente.ReadOnly = true;
            this.Url_fuente.Width = 350;
            // 
            // gb_RSS
            // 
            this.gb_RSS.Controls.Add(this.DGV_Fuentes);
            this.gb_RSS.Controls.Add(this.btn_modificar);
            this.gb_RSS.Controls.Add(this.btn_eliminar);
            this.gb_RSS.Location = new System.Drawing.Point(24, 12);
            this.gb_RSS.Name = "gb_RSS";
            this.gb_RSS.Size = new System.Drawing.Size(651, 288);
            this.gb_RSS.TabIndex = 17;
            this.gb_RSS.TabStop = false;
            this.gb_RSS.Text = "Seleccione una Fuente RSS y haga clic en la opción que desee";
            // 
            // ModificarEliminarFuenteRSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(692, 390);
            this.Controls.Add(this.gb_RSS);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.btn_salir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarEliminarFuenteRSS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ModificarEliminarFuenteRSS";
            this.Load += new System.EventHandler(this.ModificarEliminarFuenteRSS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Fuentes)).EndInit();
            this.gb_RSS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.DataGridView DGV_Fuentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_fuente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Url_fuente;
        private System.Windows.Forms.GroupBox gb_RSS;

    }
}