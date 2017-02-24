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
using Excepciones;

namespace WindowsFormsApplication
{
    public partial class ModificarEliminarFuenteRSS : Form
    {
        private BannerDTO iBanner;
        

        public ModificarEliminarFuenteRSS(BannerDTO pBanner)
        {
            this.iBanner = pBanner;            
            InitializeComponent();
        }

        public ModificarEliminarFuenteRSS()
        {
            InitializeComponent();            
        }
        

        private void rb_url_CheckedChanged(object sender, EventArgs e)
        {
            lbl_indiceBusqueda.Text = "URL";            
            lbl_indiceBusqueda.Refresh();
        }

        private void rb_descripcion_CheckedChanged(object sender, EventArgs e)
        {
            lbl_indiceBusqueda.Text = "Descripcion";            
            lbl_indiceBusqueda.Refresh();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarEliminarFuenteRSS_Load(object sender, EventArgs e)
        {
            DGV_Fuentes.AutoGenerateColumns = false;
            DGV_Fuentes.MultiSelect = false;
            FachadaFuenteRSS fachada = new FachadaFuenteRSS();
            List<FuenteRSSDTO> fuentes = (List<FuenteRSSDTO>)fachada.ObtenerFuentesRSS();

            foreach (FuenteRSSDTO fuente in fuentes)
            {
                DGV_Fuentes.Rows.Add(fuente.Url, fuente.Descripcion,fuente.Id);

            }

            if (iBanner != null)
            {
                btn_eliminar.Visible = false;
                btn_modificar.Visible = false;
                btn_ayuda.Visible = false;
                this.Size = new Size(613, 485);
                btn_salir.Location = new Point(510, 411);
                gb_buscar.Size = new Size(570, 127);
                btn_asociar.Visible = true;
                lbl_texto.Text = "Haga click sobre la fuente rss que desee y pulse en asociar para asociar la fuente al banner";
                lbl_texto.Refresh();
                this.Text = "Configurar fuente RSS";
                this.Refresh();
            }            

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            DGV_Fuentes.CurrentRow.Selected = true;
            FuenteRSSDTO fuenteModificar = new FuenteRSSDTO();
            fuenteModificar.Url = Convert.ToString(DGV_Fuentes.CurrentRow.Cells[0].Value);
            fuenteModificar.Descripcion = Convert.ToString(DGV_Fuentes.CurrentRow.Cells[1].Value);
            fuenteModificar.Id = Convert.ToInt32(DGV_Fuentes.CurrentRow.Cells[2].Value);

            AgregarFuenteRSS pantallaFuente = new AgregarFuenteRSS(fuenteModificar);
            pantallaFuente.ShowDialog();
            DGV_Fuentes.CurrentRow.Cells[0].Value = fuenteModificar.Url;
            DGV_Fuentes.CurrentRow.Cells[1].Value = fuenteModificar.Descripcion;
            DGV_Fuentes.Refresh();           
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            IList<FuenteRSSDTO> fuentes = new List<FuenteRSSDTO>();
            FachadaFuenteRSS fachada = new FachadaFuenteRSS();
            fuentes = fachada.ObtenerFuentesRSS();
            this.DGV_Fuentes.Rows.Clear();


            if (rb_descripcion.Checked)
            {
                var queryDescripcion = from fuente in fuentes
                                       where fuente.Descripcion == txt_busqueda.Text
                                       select fuente;

                if (queryDescripcion != null)
                {
                    for (int i = 0; i <= queryDescripcion.Count() - 1; i++)
                    {
                        string url = queryDescripcion.ElementAt(i).Url;
                        string Descripcion = queryDescripcion.ElementAt(i).Descripcion;
                        int id = queryDescripcion.ElementAt(i).Id;

                        this.DGV_Fuentes.Rows.Add(url, Descripcion, id);
                    }

                    this.DGV_Fuentes.Refresh();
                }

            }

            else
            {
                if (rb_url.Checked)
                {
                    var queryDescripcion = from fuente in fuentes
                                           where fuente.Url == txt_busqueda.Text
                                           select fuente;

                    if (queryDescripcion != null)
                    {
                        for (int i = 0; i <= queryDescripcion.Count() - 1; i++)
                        {
                            string url = queryDescripcion.ElementAt(i).Url;
                            string Descripcion = queryDescripcion.ElementAt(i).Descripcion;
                            int id = queryDescripcion.ElementAt(i).Id;

                            this.DGV_Fuentes.Rows.Add(url, Descripcion, id);
                        }

                        this.DGV_Fuentes.Refresh();
                    }
                }

                else
                { 
                    MessageBox.Show("Seleccione un metodo de busqueda");
                }

            
            }

        }

        private void btn_asociar_Click(object sender, EventArgs e)
        {
            string url = DGV_Fuentes.CurrentRow.Cells[0].Value.ToString();
            string descripcion = DGV_Fuentes.CurrentRow.Cells[1].Value.ToString();
            FachadaFuenteRSS fachadaFuenteRSS = new FachadaFuenteRSS();

            this.iBanner.FuenteRSSId = 
                  fachadaFuenteRSS.ObtenerFuentesRSS().FirstOrDefault
                            (fuentee => fuentee.Url == url & fuentee.Descripcion == descripcion).Id;
            

            if (iBanner.TextoFijo != null)
            {
                //Si la fuente rss tenia un texto fijo, y se el desea asociar una fuente 
                iBanner.TextoFijo = null;
            }

            this.Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                FachadaFuenteRSS fachadaFuenteRSS = new FachadaFuenteRSS();
                FuenteRSSDTO fuenteEliminar = new FuenteRSSDTO();
                fuenteEliminar.Url = Convert.ToString(DGV_Fuentes.CurrentRow.Cells[0].Value);
                fuenteEliminar.Descripcion = Convert.ToString(DGV_Fuentes.CurrentRow.Cells[1].Value);
                fuenteEliminar.Id = Convert.ToInt32(DGV_Fuentes.CurrentRow.Cells[2].Value);
                fachadaFuenteRSS.EliminarFuenteRSS(fuenteEliminar);
                MessageBox.Show("La fuente rss ha sido eliminada correctamente");
                DGV_Fuentes.Rows.Remove(DGV_Fuentes.CurrentRow);
                DGV_Fuentes.Refresh();
                
            }

            catch (DAOException)
            {
                MessageBox.Show("Error, esta fuente rss fuente rss esta siendo utilizada por uno o mas banners por favor elimine los banners que utilicen esta fuente rss primero.");
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
