using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;
using Dominio;
using System.Data.Entity.Infrastructure;
//using Excepciones;

namespace WindowsFormsApplication
{
    public partial class ModificarEliminarFuenteRSS : Form
    {
        private Banner iBanner;
        private ControladorFuenteBanner iFachadaFuente;
        

        public ModificarEliminarFuenteRSS(Banner pBanner)
        {
            this.iBanner = pBanner;
            this.iFachadaFuente = new ControladorFuenteBanner();
            InitializeComponent();
        }

        public ModificarEliminarFuenteRSS()
        {
            this.iFachadaFuente = new ControladorFuenteBanner();
            InitializeComponent();            
        }
        

        private void rb_url_CheckedChanged(object sender, EventArgs e)
        {
            //lbl_indiceBusqueda.Text = "URL";            
            //lbl_indiceBusqueda.Refresh();
        }

        private void rb_descripcion_CheckedChanged(object sender, EventArgs e)
        {
            //lbl_indiceBusqueda.Text = "Descripcion";            
            //lbl_indiceBusqueda.Refresh();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarEliminarFuenteRSS_Load(object sender, EventArgs e)
        {
            DGV_Fuentes.AutoGenerateColumns = false;
            DGV_Fuentes.MultiSelect = false;
            
            IQueryable<FuenteRSS> fuentes = iFachadaFuente.ObtenerFuentesRSS();

            foreach (FuenteRSS fuente in fuentes)
            {
                DGV_Fuentes.Rows.Add(fuente.iIdFuenteRSS, fuente.iDescripcion, fuente.iUrl);

            }

            if (iBanner != null)
            {
                btn_eliminar.Visible = false;
                btn_modificar.Visible = false;
                btn_ayuda.Visible = false;
                this.Size = new Size(613, 485);
                btn_salir.Location = new Point(510, 411);
                //gb_buscar.Size = new Size(570, 127);
                btn_asociar.Visible = true;
                lbl_texto.Text = "Haga click sobre la fuente rss que desee y pulse en asociar para asociar la fuente al banner";
                lbl_texto.Refresh();
                this.Text = "Configurar fuente RSS";
                this.Refresh();
            }            

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            //Obtiene la fuente a modificar a partir del ID de la grilla
            FuenteRSS fuente = iFachadaFuente.ObtenerFuenteRSS(Convert.ToInt32(DGV_Fuentes.CurrentRow.Cells[0].Value));

            // Abre el formulario de alta de fuente tomando los datos de la fuente a modificar
            AgregarFuenteRSS fuenteRSSInterfaz = new AgregarFuenteRSS(fuente);
            fuenteRSSInterfaz.ShowDialog();

            DGV_Fuentes.CurrentRow.Cells[1].Value = fuente.iDescripcion;
            DGV_Fuentes.CurrentRow.Cells[2].Value = fuente.iUrl;            

            DGV_Fuentes.Refresh();


            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;
            //DGV_Fuentes.CurrentRow.Selected = true;
            //FuenteRSSDTO fuenteModificar = new FuenteRSSDTO();
            //fuenteModificar.Url = Convert.ToString(DGV_Fuentes.CurrentRow.Cells[0].Value);
            //fuenteModificar.Descripcion = Convert.ToString(DGV_Fuentes.CurrentRow.Cells[1].Value);
            //fuenteModificar.Id = Convert.ToInt32(DGV_Fuentes.CurrentRow.Cells[2].Value);

            //AgregarFuenteRSS pantallaFuente = new AgregarFuenteRSS(fuenteModificar);
            //pantallaFuente.ShowDialog();
            //DGV_Fuentes.CurrentRow.Cells[0].Value = fuenteModificar.Url;
            //DGV_Fuentes.CurrentRow.Cells[1].Value = fuenteModificar.Descripcion;
            //DGV_Fuentes.Refresh();           
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_asociar_Click(object sender, EventArgs e)
        {
            //this.iBanner = iFachadaFuente.ObtenerFuenteRSS(Convert.ToInt32(DGV_Fuentes.CurrentRow.Cells[0].Value));
            //MessageBox.Show("Fuente asociada con éxito!");
            //string url = DGV_Fuentes.CurrentRow.Cells[0].Value.ToString();
            //string descripcion = DGV_Fuentes.CurrentRow.Cells[1].Value.ToString();
            //FachadaFuenteRSS fachadaFuenteRSS = new FachadaFuenteRSS();

            //this.iBanner.FuenteRSSId = 
            //      fachadaFuenteRSS.ObtenerFuentesRSS().FirstOrDefault
            //                (fuentee => fuentee.Url == url & fuentee.Descripcion == descripcion).Id;
            

            //if (iBanner.TextoFijo != null)
            //{
            //    //Si la fuente rss tenia un texto fijo, y se el desea asociar una fuente 
            //    iBanner.TextoFijo = null;
            //}
            //this.Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idFuenteAEliminar = Convert.ToInt32(DGV_Fuentes.CurrentRow.Cells[0].Value);
                iFachadaFuente.EliminarFuenteRSS(idFuenteAEliminar);

                //Actualizamos el datagridview
                DGV_Fuentes.Rows.Remove((DGV_Fuentes.CurrentRow));
                MessageBox.Show("La fuente fue eliminada con exito!");
                DGV_Fuentes.Refresh();

                btn_modificar.Enabled = false;
                btn_eliminar.Enabled = false;
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("La fuente RSS que se quiere borrar esta asociada a 1 o mas banners");
            }

        }

        private void DGV_Fuentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (iBanner == null)
            {
                btn_eliminar.Enabled = true;
                btn_modificar.Enabled = true;
            }
        }

        

       

        

        
       
       
    }
}
