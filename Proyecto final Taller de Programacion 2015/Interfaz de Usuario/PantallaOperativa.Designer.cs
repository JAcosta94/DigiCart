namespace WindowsFormsApplication
{
    partial class PantallaOperativa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaOperativa));
            this.pb_imagenes = new System.Windows.Forms.PictureBox();
            this.lbl_banner = new System.Windows.Forms.Label();
            this.timerImagen = new System.Windows.Forms.Timer(this.components);
            this.timerCampaña = new System.Windows.Forms.Timer(this.components);
            this.timerBanner = new System.Windows.Forms.Timer(this.components);
            this.bwRssReader = new System.ComponentModel.BackgroundWorker();
            this.lbl_fuenteRSS = new System.Windows.Forms.Label();
            this.txt_banner = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_imagenes
            // 
            this.pb_imagenes.BackColor = System.Drawing.Color.Transparent;
            this.pb_imagenes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_imagenes.Location = new System.Drawing.Point(77, 12);
            this.pb_imagenes.Name = "pb_imagenes";
            this.pb_imagenes.Size = new System.Drawing.Size(548, 308);
            this.pb_imagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_imagenes.TabIndex = 2;
            this.pb_imagenes.TabStop = false;
            // 
            // lbl_banner
            // 
            this.lbl_banner.AutoSize = true;
            this.lbl_banner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_banner.Location = new System.Drawing.Point(678, 416);
            this.lbl_banner.Name = "lbl_banner";
            this.lbl_banner.Size = new System.Drawing.Size(0, 24);
            this.lbl_banner.TabIndex = 3;
            // 
            // timerImagen
            // 
            this.timerImagen.Tick += new System.EventHandler(this.timerImagen_Tick);
            // 
            // timerCampaña
            // 
            this.timerCampaña.Enabled = true;
            this.timerCampaña.Tick += new System.EventHandler(this.timerCampaña_Tick);
            // 
            // timerBanner
            // 
            this.timerBanner.Enabled = true;
            this.timerBanner.Tick += new System.EventHandler(this.timerBanner_Tick);
            // 
            // bwRssReader
            // 
            this.bwRssReader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwRssReader_DoWork);
            this.bwRssReader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwRssReader_RunWorkerCompleted);
            // 
            // lbl_fuenteRSS
            // 
            this.lbl_fuenteRSS.AutoSize = true;
            this.lbl_fuenteRSS.Enabled = false;
            this.lbl_fuenteRSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fuenteRSS.Location = new System.Drawing.Point(37, 385);
            this.lbl_fuenteRSS.Name = "lbl_fuenteRSS";
            this.lbl_fuenteRSS.Size = new System.Drawing.Size(0, 20);
            this.lbl_fuenteRSS.TabIndex = 4;
            // 
            // txt_banner
            // 
            this.txt_banner.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_banner.Location = new System.Drawing.Point(-3, 339);
            this.txt_banner.Multiline = true;
            this.txt_banner.Name = "txt_banner";
            this.txt_banner.ReadOnly = true;
            this.txt_banner.Size = new System.Drawing.Size(705, 34);
            this.txt_banner.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(636, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // PantallaOperativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_banner);
            this.Controls.Add(this.lbl_fuenteRSS);
            this.Controls.Add(this.lbl_banner);
            this.Controls.Add(this.pb_imagenes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaOperativa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Pantalla Operativa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaOperativa_FormClosed);
            this.Load += new System.EventHandler(this.PantallaOperativa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_imagenes;
        private System.Windows.Forms.Label lbl_banner;
        private System.Windows.Forms.Timer timerImagen;
        private System.Windows.Forms.Timer timerCampaña;
        private System.Windows.Forms.Timer timerBanner;
        private System.ComponentModel.BackgroundWorker bwRssReader;
        private System.Windows.Forms.Label lbl_fuenteRSS;
        private System.Windows.Forms.TextBox txt_banner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}