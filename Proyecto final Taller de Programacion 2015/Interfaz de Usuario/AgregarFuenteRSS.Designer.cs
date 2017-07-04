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
            this.components = new System.ComponentModel.Container();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardarFuente = new System.Windows.Forms.Button();
            this.lbl_url = new System.Windows.Forms.Label();
            this.lbl_nombreFuente = new System.Windows.Forms.Label();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.txt_nombreFuente = new System.Windows.Forms.TextBox();
            this.bwRssReader = new System.ComponentModel.BackgroundWorker();
            this.btn_vistaPrevia = new System.Windows.Forms.Button();
            this.lbl_vistaPrevia = new System.Windows.Forms.Label();
            this.bwRssReaderPrueba = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(269, 139);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(98, 23);
            this.btn_cancelar.TabIndex = 0;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardarFuente
            // 
            this.btn_guardarFuente.Location = new System.Drawing.Point(149, 139);
            this.btn_guardarFuente.Name = "btn_guardarFuente";
            this.btn_guardarFuente.Size = new System.Drawing.Size(98, 23);
            this.btn_guardarFuente.TabIndex = 1;
            this.btn_guardarFuente.Text = "Guardar ";
            this.btn_guardarFuente.UseVisualStyleBackColor = true;
            this.btn_guardarFuente.Click += new System.EventHandler(this.btn_guardarFuente_Click);
            // 
            // lbl_url
            // 
            this.lbl_url.AutoSize = true;
            this.lbl_url.Location = new System.Drawing.Point(12, 63);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(32, 13);
            this.lbl_url.TabIndex = 2;
            this.lbl_url.Text = "URL:";
            // 
            // lbl_nombreFuente
            // 
            this.lbl_nombreFuente.AutoSize = true;
            this.lbl_nombreFuente.Location = new System.Drawing.Point(12, 33);
            this.lbl_nombreFuente.Name = "lbl_nombreFuente";
            this.lbl_nombreFuente.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombreFuente.TabIndex = 3;
            this.lbl_nombreFuente.Text = "Nombre:";
            this.lbl_nombreFuente.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(138, 56);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(302, 20);
            this.txt_url.TabIndex = 4;
            // 
            // txt_nombreFuente
            // 
            this.txt_nombreFuente.Location = new System.Drawing.Point(138, 26);
            this.txt_nombreFuente.Name = "txt_nombreFuente";
            this.txt_nombreFuente.Size = new System.Drawing.Size(302, 20);
            this.txt_nombreFuente.TabIndex = 5;
            // 
            // bwRssReader
            // 
            this.bwRssReader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwRssReader_DoWork);
            this.bwRssReader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwRssReader_RunWorkerCompleted);
            // 
            // btn_vistaPrevia
            // 
            this.btn_vistaPrevia.Location = new System.Drawing.Point(456, 26);
            this.btn_vistaPrevia.Name = "btn_vistaPrevia";
            this.btn_vistaPrevia.Size = new System.Drawing.Size(75, 50);
            this.btn_vistaPrevia.TabIndex = 6;
            this.btn_vistaPrevia.Text = "Vista Previa";
            this.btn_vistaPrevia.UseVisualStyleBackColor = true;
            this.btn_vistaPrevia.Click += new System.EventHandler(this.btn_vistaPrevia_Click);
            // 
            // lbl_vistaPrevia
            // 
            this.lbl_vistaPrevia.AutoSize = true;
            this.lbl_vistaPrevia.Location = new System.Drawing.Point(472, 106);
            this.lbl_vistaPrevia.Name = "lbl_vistaPrevia";
            this.lbl_vistaPrevia.Size = new System.Drawing.Size(59, 13);
            this.lbl_vistaPrevia.TabIndex = 7;
            this.lbl_vistaPrevia.Text = "vistaPrevia";
            this.lbl_vistaPrevia.Visible = false;
            // 
            // bwRssReaderPrueba
            // 
            this.bwRssReaderPrueba.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwRssReaderPrueba_DoWork);
            this.bwRssReaderPrueba.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwRssReaderPrueba_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AgregarFuenteRSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 174);
            this.Controls.Add(this.lbl_vistaPrevia);
            this.Controls.Add(this.btn_vistaPrevia);
            this.Controls.Add(this.txt_nombreFuente);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.lbl_nombreFuente);
            this.Controls.Add(this.lbl_url);
            this.Controls.Add(this.btn_guardarFuente);
            this.Controls.Add(this.btn_cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Button btn_vistaPrevia;
        private System.Windows.Forms.Label lbl_vistaPrevia;
        private System.ComponentModel.BackgroundWorker bwRssReaderPrueba;
        private System.Windows.Forms.Timer timer1;
    }
}