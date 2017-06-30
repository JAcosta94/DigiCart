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
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.DGV_Fuentes = new System.Windows.Forms.DataGridView();
            this.btn_asociar = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_fuente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Url_fuente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Fuentes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.Location = new System.Drawing.Point(602, 217);
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
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(338, 266);
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
            this.btn_eliminar.Location = new System.Drawing.Point(602, 146);
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
            this.btn_modificar.Location = new System.Drawing.Point(602, 86);
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
            this.Id,
            this.Descripcion_fuente,
            this.Url_fuente});
            this.DGV_Fuentes.Location = new System.Drawing.Point(15, 25);
            this.DGV_Fuentes.Name = "DGV_Fuentes";
            this.DGV_Fuentes.ReadOnly = true;
            this.DGV_Fuentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Fuentes.Size = new System.Drawing.Size(553, 215);
            this.DGV_Fuentes.TabIndex = 10;
            this.DGV_Fuentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Fuentes_CellClick);
            // 
            // btn_asociar
            // 
            this.btn_asociar.Location = new System.Drawing.Point(181, 266);
            this.btn_asociar.Name = "btn_asociar";
            this.btn_asociar.Size = new System.Drawing.Size(90, 23);
            this.btn_asociar.TabIndex = 17;
            this.btn_asociar.Text = "Asociar fuente";
            this.btn_asociar.UseVisualStyleBackColor = true;
            this.btn_asociar.Visible = false;
            this.btn_asociar.Click += new System.EventHandler(this.btn_asociar_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
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
            // ModificarEliminarFuenteRSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 326);
            this.Controls.Add(this.btn_asociar);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.lbl_texto);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.DGV_Fuentes);
            this.Name = "ModificarEliminarFuenteRSS";
            this.Text = "ModificarEliminarFuenteRSS";
            this.Load += new System.EventHandler(this.ModificarEliminarFuenteRSS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Fuentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.Label lbl_texto;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.DataGridView DGV_Fuentes;
        private System.Windows.Forms.Button btn_asociar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_fuente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Url_fuente;

    }
}