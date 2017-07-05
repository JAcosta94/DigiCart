using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication;

namespace Interfaz_de_Usuario
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            PantallaOperativa pantalla = new PantallaOperativa();
            pantalla.Show();
         //   this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!this.lbl_admin.Enabled && !this.txt_clave.Enabled)
            {
                this.txt_clave.Enabled = true;
                this.lbl_admin.Enabled = true;
                this.txt_clave.Visible = true;
                this.lbl_admin.Visible = true;
            }

            else
            {
                if (this.txt_clave.Text == "admin")
                {
                    MenuPrincipal admin = new MenuPrincipal();
                    admin.Show();
                  //  this.Close();
                }

                else 
                {
                    MessageBox.Show("LA CONTRASEÑA ES INCORRECTA. BUSQUE EN SU MANUAL DE USUARIO");
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
