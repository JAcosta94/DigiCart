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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            rb_iniciar.Checked = true;           
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (rb_administrar.Checked == true)
            {
                if (this.txt_clave.Text == "admin")
                {                    
                    MenuPrincipal admin = new MenuPrincipal(this);
                    admin.Show();                    
                    txt_clave.Focus();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error! Contraseña INCORRECTA. Verifique su licencia.");
                    txt_clave.Focus();                    
                }                
                txt_clave.Text = string.Empty;
            }
            else
            {
                PantallaOperativa pantalla = new PantallaOperativa(this);
                pantalla.Show();
                this.Hide();
            }
        }

        private void rb_iniciar_CheckedChanged(object sender, EventArgs e)
        {
            btn_aceptar.Text = "Iniciar";
            txt_clave.Enabled = false;
            lbl_admin.Visible = false;
        }

        private void rb_administrar_CheckedChanged(object sender, EventArgs e)
        {
            btn_aceptar.Text = "Aceptar";
            txt_clave.Enabled = true;
            lbl_admin.Visible = true;            
            txt_clave.Focus();
        }
    }
}
