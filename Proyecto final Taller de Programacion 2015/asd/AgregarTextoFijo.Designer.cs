namespace WindowsFormsApplication
{
    partial class AgregarTextoFijo
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
            this.btn_vistaPrevia = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_textoFijo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_vistaPrevia = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_vistaPrevia
            // 
            this.btn_vistaPrevia.Location = new System.Drawing.Point(267, 16);
            this.btn_vistaPrevia.Name = "btn_vistaPrevia";
            this.btn_vistaPrevia.Size = new System.Drawing.Size(105, 23);
            this.btn_vistaPrevia.TabIndex = 1;
            this.btn_vistaPrevia.Text = "Vista Previa";
            this.btn_vistaPrevia.UseVisualStyleBackColor = true;
            this.btn_vistaPrevia.Click += new System.EventHandler(this.btn_vistaPrevia_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(176, 99);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(111, 23);
            this.btn_guardar.TabIndex = 3;
            this.btn_guardar.Text = "Guardar Texto Fijo";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(295, 99);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_textoFijo
            // 
            this.txt_textoFijo.Location = new System.Drawing.Point(89, 18);
            this.txt_textoFijo.Name = "txt_textoFijo";
            this.txt_textoFijo.Size = new System.Drawing.Size(139, 20);
            this.txt_textoFijo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Texto";
            // 
            // lbl_vistaPrevia
            // 
            this.lbl_vistaPrevia.AutoSize = true;
            this.lbl_vistaPrevia.Location = new System.Drawing.Point(135, 64);
            this.lbl_vistaPrevia.Name = "lbl_vistaPrevia";
            this.lbl_vistaPrevia.Size = new System.Drawing.Size(35, 13);
            this.lbl_vistaPrevia.TabIndex = 9;
            this.lbl_vistaPrevia.Text = "label1";
            this.lbl_vistaPrevia.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AgregarTextoFijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 135);
            this.Controls.Add(this.lbl_vistaPrevia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_textoFijo);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_vistaPrevia);
            this.Name = "AgregarTextoFijo";
            this.Text = "Configurar Texto Fijo";
            this.Load += new System.EventHandler(this.AgregarTextoFijo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_vistaPrevia;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_textoFijo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_vistaPrevia;
        private System.Windows.Forms.Timer timer1;
    }
}