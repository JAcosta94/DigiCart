﻿namespace WindowsFormsApplication
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
            this.pb_imagenes = new System.Windows.Forms.PictureBox();
            this.lbl_banner = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerImagen = new System.Windows.Forms.Timer(this.components);
            this.timerCampaña = new System.Windows.Forms.Timer(this.components);
            this.timerBanner = new System.Windows.Forms.Timer(this.components);
            this.bwRssReader = new System.ComponentModel.BackgroundWorker();
            this.lbl_fuenteRSS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_imagenes
            // 
            this.pb_imagenes.Location = new System.Drawing.Point(41, 22);
            this.pb_imagenes.Name = "pb_imagenes";
            this.pb_imagenes.Size = new System.Drawing.Size(628, 345);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // PantallaOperativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(714, 461);
            this.Controls.Add(this.lbl_fuenteRSS);
            this.Controls.Add(this.lbl_banner);
            this.Controls.Add(this.pb_imagenes);
            this.Name = "PantallaOperativa";
            this.Text = "PantallaOperativa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaOperativa_FormClosed);
            this.Load += new System.EventHandler(this.PantallaOperativa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_imagenes;
        private System.Windows.Forms.Label lbl_banner;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerImagen;
        private System.Windows.Forms.Timer timerCampaña;
        private System.Windows.Forms.Timer timerBanner;
        private System.ComponentModel.BackgroundWorker bwRssReader;
        private System.Windows.Forms.Label lbl_fuenteRSS;
    }
}