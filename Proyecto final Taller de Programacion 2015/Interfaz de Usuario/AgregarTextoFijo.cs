using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Controladores;

namespace WindowsFormsApplication
{
    public partial class AgregarTextoFijo : Form
    {
        private BannerFuenteTextoFijo iBanner;
        private ControladorFuenteBanner iFachadaFuente;

        public AgregarTextoFijo(BannerFuenteTextoFijo pBanner)
        {
            this.iFachadaFuente = new ControladorFuenteBanner();
            this.iBanner = pBanner;
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            
            lbl_vistaPrevia.Left -= 15;

            if (lbl_vistaPrevia.Right < 0)
                lbl_vistaPrevia.Left = this.Width;
        }

        private void btn_vistaPrevia_Click(object sender, EventArgs e)
        {            
            lbl_vistaPrevia.Visible= true;
            lbl_vistaPrevia.Text = txt_textoFijo.Text;
            lbl_vistaPrevia.Refresh();
            timer1.Enabled = true;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.iBanner = new BannerFuenteTextoFijo
            {
                TextoFijo = txt_textoFijo.Text,
            };


           // this.iFachadaFuente.AgregarTextoFijo(textoFijo);
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
            }

            this.Close();
        }

        private void AgregarTextoFijo_Load(object sender, EventArgs e)
        {
            if (this.iBanner != null)
            {
                txt_textoFijo.Text =  this.iBanner.TextoFijo;            
            }
        }

        

      
    }
}
