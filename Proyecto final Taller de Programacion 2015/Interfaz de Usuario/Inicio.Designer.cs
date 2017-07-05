namespace Interfaz_de_Usuario
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.rb_iniciar = new System.Windows.Forms.RadioButton();
            this.rb_administrar = new System.Windows.Forms.RadioButton();
            this.gb_opcion = new System.Windows.Forms.GroupBox();
            this.gb_opcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(457, 239);
            this.btn_iniciar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(105, 59);
            this.btn_iniciar.TabIndex = 1;
            this.btn_iniciar.Text = "      Iniciar         Cartelería";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 124);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 59);
            this.button2.TabIndex = 2;
            this.button2.Text = " Administrar Carteleria";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_salir.Location = new System.Drawing.Point(207, 385);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(104, 27);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.BackColor = System.Drawing.Color.Transparent;
            this.lbl_admin.Enabled = false;
            this.lbl_admin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_admin.Location = new System.Drawing.Point(52, 313);
            this.lbl_admin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(278, 15);
            this.lbl_admin.TabIndex = 4;
            this.lbl_admin.Text = "Por favor, ingrese la contraseña del Administrador";
            this.lbl_admin.Visible = false;
            // 
            // txt_clave
            // 
            this.txt_clave.Enabled = false;
            this.txt_clave.Location = new System.Drawing.Point(35, 348);
            this.txt_clave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.PasswordChar = '*';
            this.txt_clave.Size = new System.Drawing.Size(322, 21);
            this.txt_clave.TabIndex = 7;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_aceptar.Location = new System.Drawing.Point(86, 385);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(104, 27);
            this.btn_aceptar.TabIndex = 8;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // rb_iniciar
            // 
            this.rb_iniciar.AutoSize = true;
            this.rb_iniciar.BackColor = System.Drawing.Color.Transparent;
            this.rb_iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_iniciar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rb_iniciar.Location = new System.Drawing.Point(14, 20);
            this.rb_iniciar.Name = "rb_iniciar";
            this.rb_iniciar.Size = new System.Drawing.Size(132, 19);
            this.rb_iniciar.TabIndex = 9;
            this.rb_iniciar.TabStop = true;
            this.rb_iniciar.Text = "Iniciar Cartelería";
            this.rb_iniciar.UseVisualStyleBackColor = false;
            this.rb_iniciar.CheckedChanged += new System.EventHandler(this.rb_iniciar_CheckedChanged);
            // 
            // rb_administrar
            // 
            this.rb_administrar.AutoSize = true;
            this.rb_administrar.BackColor = System.Drawing.Color.Transparent;
            this.rb_administrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_administrar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rb_administrar.Location = new System.Drawing.Point(152, 20);
            this.rb_administrar.Name = "rb_administrar";
            this.rb_administrar.Size = new System.Drawing.Size(165, 19);
            this.rb_administrar.TabIndex = 10;
            this.rb_administrar.TabStop = true;
            this.rb_administrar.Text = "Administrar Cartelería";
            this.rb_administrar.UseVisualStyleBackColor = false;
            this.rb_administrar.CheckedChanged += new System.EventHandler(this.rb_administrar_CheckedChanged);
            // 
            // gb_opcion
            // 
            this.gb_opcion.BackColor = System.Drawing.Color.Transparent;
            this.gb_opcion.Controls.Add(this.rb_iniciar);
            this.gb_opcion.Controls.Add(this.rb_administrar);
            this.gb_opcion.Location = new System.Drawing.Point(35, 249);
            this.gb_opcion.Name = "gb_opcion";
            this.gb_opcion.Size = new System.Drawing.Size(322, 52);
            this.gb_opcion.TabIndex = 11;
            this.gb_opcion.TabStop = false;
            this.gb_opcion.Text = "Opción";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(382, 442);
            this.Controls.Add(this.gb_opcion);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.lbl_admin);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_iniciar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DigiCart";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.gb_opcion.ResumeLayout(false);
            this.gb_opcion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.RadioButton rb_iniciar;
        private System.Windows.Forms.RadioButton rb_administrar;
        private System.Windows.Forms.GroupBox gb_opcion;
    }
}