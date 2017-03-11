using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class MenuPrincipal : Form
    {
        private int childFormNumber = 0;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void configuracionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearCampañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarCampaña Campañas = new AgregarCampaña();
            Campañas.ShowDialog();
        }

        private void modificarFuenteRSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarEliminarFuenteRSS fuentes = new ModificarEliminarFuenteRSS();
            fuentes.ShowDialog();
        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AcercaDe acerca = new AcercaDe();
            //acerca.ShowDialog();
        }

        private void nuevoBannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario_Banner banner = new Formulario_Banner();
            banner.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevaFuenteRSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarFuenteRSS fuenterss = new AgregarFuenteRSS();
            fuenterss.ShowDialog();
        }

        private void modificarCampañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarEliminarCampaña campañas = new ModificarEliminarCampaña();
            campañas.ShowDialog();
        }

        private void modificar_eliminarBannerMenuItem_Click(object sender, EventArgs e)
        {
            ModificarEliminarBanner banners = new ModificarEliminarBanner();
            banners.ShowDialog();
        }

        private void empezarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaOperativa operativa = new PantallaOperativa();
            operativa.ShowDialog();
        }

       

        
    }
}
