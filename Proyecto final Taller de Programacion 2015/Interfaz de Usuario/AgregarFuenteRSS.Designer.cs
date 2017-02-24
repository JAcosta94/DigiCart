namespace WindowsFormsApplication
{
    partial class AgregarFuenteRSS
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardarFuente = new System.Windows.Forms.Button();
            this.lbl_url = new System.Windows.Forms.Label();
            this.lbl_nombreFuente = new System.Windows.Forms.Label();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.txt_nombreFuente = new System.Windows.Forms.TextBox();
            this.bwRssReader = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_vistaPrevia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(234, 139);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 0;
            this.btn_cancelar.Text = "Salir";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardarFuente
            // 
            this.btn_guardarFuente.Location = new System.Drawing.Point(73, 139);
            this.btn_guardarFuente.Name = "btn_guardarFuente";
            this.btn_guardarFuente.Size = new System.Drawing.Size(98, 23);
            this.btn_guardarFuente.TabIndex = 1;
            this.btn_guardarFuente.Text = "Guardar Fuente";
            this.btn_guardarFuente.UseVisualStyleBackColor = true;
            this.btn_guardarFuente.Click += new System.EventHandler(this.btn_guardarFuente_Click);
            // 
            // lbl_url
            // 
            this.lbl_url.AutoSize = true;
            this.lbl_url.Location = new System.Drawing.Point(12, 26);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(91, 13);
            this.lbl_url.TabIndex = 2;
            this.lbl_url.Text = "URL de la Fuente";
            // 
            // lbl_nombreFuente
            // 
            this.lbl_nombreFuente.AutoSize = true;
            this.lbl_nombreFuente.Location = new System.Drawing.Point(12, 63);
            this.lbl_nombreFuente.Name = "lbl_nombreFuente";
            this.lbl_nombreFuente.Size = new System.Drawing.Size(103, 13);
            this.lbl_nombreFuente.TabIndex = 3;
            this.lbl_nombreFuente.Text = "Nombre de la fuente";
            this.lbl_nombreFuente.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(138, 26);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(302, 20);
            this.txt_url.TabIndex = 4;
            // 
            // txt_nombreFuente
            // 
            this.txt_nombreFuente.Location = new System.Drawing.Point(138, 56);
            this.txt_nombreFuente.Name = "txt_nombreFuente";
            this.txt_nombreFuente.Size = new System.Drawing.Size(302, 20);
            this.txt_nombreFuente.TabIndex = 5;
            // 
            // bwRssReader
            // 
            this.bwRssReader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwRssReader_DoWork);
            this.bwRssReader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwRssReader_RunWorkerCompleted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Vista Previa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_vistaPrevia
            // 
            this.lbl_vistaPrevia.AutoSize = true;
            this.lbl_vistaPrevia.Location = new System.Drawing.Point(68, 100);
            this.lbl_vistaPrevia.Name = "lbl_vistaPrevia";
            this.lbl_vistaPrevia.Size = new System.Drawing.Size(59, 13);
            this.lbl_vistaPrevia.TabIndex = 7;
            this.lbl_vistaPrevia.Text = "vistaPrevia";
            // 
            // AgregarFuenteRSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 174);
            this.Controls.Add(this.lbl_vistaPrevia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_nombreFuente);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.lbl_nombreFuente);
            this.Controls.Add(this.lbl_url);
            this.Controls.Add(this.btn_guardarFuente);
            this.Controls.Add(this.btn_cancelar);
            this.Name = "AgregarFuenteRSS";
            this.Text = "Nueva Fuente RSS";
            this.Load += new System.EventHandler(this.AgregarFuenteRSS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardarFuente;
        private System.Windows.Forms.Label lbl_url;
        private System.Windows.Forms.Label lbl_nombreFuente;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.TextBox txt_nombreFuente;
        private System.ComponentModel.BackgroundWorker bwRssReader;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_vistaPrevia;
    }
}