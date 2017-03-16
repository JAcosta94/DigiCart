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
using System.Data.SqlClient;
using Controladores;

namespace WindowsFormsApplication
{
    public partial class ModificarEliminarBanner : Form
    {
        private ControladorBanner iFachadaBanner;

        public ModificarEliminarBanner()
        {
            this.iFachadaBanner = new ControladorBanner();
            InitializeComponent();
        }

        private void rb_intervaloDias_CheckedChanged(object sender, EventArgs e)
        {
            lbl_inicio.Text = "Fecha Inicio";
            lbl_inicio.Refresh();
            lbl_fin.Text = "Fecha Fin";
            lbl_fin.Refresh();
            mtxt_inicio.Mask = "00/00/0000";
            mtxt_inicio.Refresh();
            mtxt_fin.Mask = "00/00/0000";
            mtxt_fin.Refresh();
            
        }

        private void rb_intervaloHorario_CheckedChanged(object sender, EventArgs e)
        {
            lbl_inicio.Text = "Hora Inicio";
            lbl_inicio.Refresh();
            lbl_fin.Text = "Hora Fin";
            lbl_fin.Refresh();
            mtxt_fin.Modified = true;
            mtxt_inicio.Mask = "00:00:00";
            mtxt_inicio.Refresh();
            mtxt_fin.Mask = "00:00:00";
            mtxt_fin.Refresh();
            
           
            
            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarEliminarBanner_Load(object sender, EventArgs e)
        {

            
            IQueryable<Banner> banners = this.iFachadaBanner.ObtenerBanners();

            

            foreach (Banner banner in banners)
            {

                if (banner.iTipoBanner is FuenteTextoFijo)
                {
                    DGV_Banners.Rows.Add(banner.iHoraInicio, banner.iHoraFin, banner.iIdBanner,
                                        banner.iFechaInicio.ToString("dd/MM/yyyy"),
                                        banner.iFechaFin.ToString("dd/MM/yyyy"),
                                        "Texto Fijo");
                }
                else
                {
                    DGV_Banners.Rows.Add(banner.iHoraInicio, banner.iHoraFin, banner.iIdBanner,
                                        banner.iFechaInicio.ToString("dd/MM/yyyy"),
                                        banner.iFechaFin.ToString("dd/MM/yyyy"),
                                        "Fuente RSS");
                }

            }

      

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            //FachadaBanner fachadaBanner = new FachadaBanner();
            //BannerDTO banner = new BannerDTO();
            //banner.Id= Convert.ToInt32(this.DGV_Banners.CurrentRow.Cells[2].Value);
            //banner.HoraInicio = TimeSpan.Parse(Convert.ToString(this.DGV_Banners.CurrentRow.Cells[0].Value));
            //banner.HoraFin = TimeSpan.Parse(Convert.ToString(this.DGV_Banners.CurrentRow.Cells[1].Value));
            //fachadaBanner.EliminarBanner(banner);
            //this.DGV_Banners.Rows.Remove((this.DGV_Banners.CurrentRow));
            //MessageBox.Show("El banner fue eliminado con exito!");
            //this.DGV_Banners.Refresh();
            //btn_eliminar.Enabled = false;
            //btn_modificar.Enabled = false;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            //BannerDTO banner = new BannerDTO();
            //banner.HoraInicio = TimeSpan.Parse(this.DGV_Banners.CurrentRow.Cells[0].Value.ToString());
            //banner.HoraFin = TimeSpan.Parse(this.DGV_Banners.CurrentRow.Cells[1].Value.ToString());
            //banner.Id = Convert.ToInt32(this.DGV_Banners.CurrentRow.Cells[2].Value);
            //banner.IntervaloFechaId = Convert.ToInt32(this.DGV_Banners.CurrentRow.Cells[6].Value);
            //FachadaBanner fachada = new FachadaBanner(); 

            //if ( DGV_Banners.CurrentRow.Cells[5].Value.ToString() == "Texto Fijo")
            //{
            //    banner.TextoFijo = fachada.ObtenerBanners().FirstOrDefault(banners => banner.Id == banners.Id).TextoFijo;
            //    banner.FuenteRSSId = null;
            //}

            //else
            //{
            //    banner.TextoFijo = null;
            //    banner.FuenteRSSId = fachada.ObtenerBanners().FirstOrDefault(banners => banner.Id == banners.Id).FuenteRSSId;
            //}

            //Formulario_Banner bannerInterfaz = new Formulario_Banner(banner);
            //bannerInterfaz.ShowDialog();

            ////DGV_Banners.DataSource = fachada.ObtenerBanners();

            //this.DGV_Banners.CurrentRow.Cells[0].Value = banner.HoraInicio;
            //this.DGV_Banners.CurrentRow.Cells[1].Value = banner.HoraFin;
            //this.DGV_Banners.CurrentRow.Cells[2].Value = banner.Id;
            //IntervaloFechasDTO intervaloFecha = new FachadaIntervaloFechas().ObtenerIntervalos().FirstOrDefault(intervalo => intervalo.Id == banner.IntervaloFechaId);
            //this.DGV_Banners.CurrentRow.Cells[3].Value = (intervaloFecha.FechaInicio.ToString("dd/MM/yyyy"));
            //this.DGV_Banners.CurrentRow.Cells[4].Value = (intervaloFecha.FechaFin.ToString("dd/MM/yyyy"));
            //if (banner.FuenteRSSId != null)
            //{ this.DGV_Banners.CurrentRow.Cells[5].Value = "Fuente RSS"; }
            //else
            //{ this.DGV_Banners.CurrentRow.Cells[5].Value = "Texto Fijo"; }
            //this.DGV_Banners.CurrentRow.Cells[6].Value = (intervaloFecha.Id);



        }

        private void DGV_Banners_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btn_eliminar.Enabled = true;
            this.btn_modificar.Enabled = true;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            //FachadaBanner fachadaBanner = new FachadaBanner();
            //IList<BannerDTO> banners = new List<BannerDTO>();
            //banners = fachadaBanner.ObtenerBanners();
            //this.DGV_Banners.Rows.Clear();

            //if (rb_intervaloHorario.Checked)
            //{
            //    var queryDescripcion = from banner in banners
            //                           where banner.HoraInicio >= TimeSpan.Parse(mtxt_inicio.Text) &&
            //                                    banner.HoraFin <= TimeSpan.Parse(mtxt_fin.Text)
            //                           select banner;

            //    if (queryDescripcion != null)
            //    {
            //        for (int i = 0; i <= queryDescripcion.Count() - 1; i++)
            //        {
            //            TimeSpan inicio = queryDescripcion.ElementAt(i).HoraInicio;
            //            TimeSpan fin = queryDescripcion.ElementAt(i).HoraFin;
            //            int id = queryDescripcion.ElementAt(i).Id;

            //            IntervaloFechasDTO intervaloFecha = (new FachadaIntervaloFechas()).ObtenerIntervalos().FirstOrDefault
            //                                      (intervalo => intervalo.Id == queryDescripcion.ElementAt(i).IntervaloFechaId);

            //            string Tipo;
            //            if (queryDescripcion.ElementAt(i).TextoFijo != null)
            //            {
            //                Tipo = "Texto Fijo";
            //            }
            //            else
            //            {
            //                Tipo = "Fuente RSS";
            //            }

            //            this.DGV_Banners.Rows.Add(inicio, fin, id, intervaloFecha.FechaInicio.Date, intervaloFecha.FechaFin.Date, Tipo ,intervaloFecha.Id);
            //        }

            //        this.DGV_Banners.Refresh();
            //    }

            //}

            //else
            //{
            //    if (rb_intervaloDias.Checked)
            //    {
            //        //var queryDescripcion = from campania in campañas
            //        //                       where campania. == txt_busqueda.Text
            //        //                       select campania;

            //        //if (queryDescripcion != null)
            //        //{
            //        //    for (int i = 0; i <= queryDescripcion.Count() - 1; i++)
            //        //    {
            //        //        string url = queryDescripcion.ElementAt(i).Url;
            //        //        string Descripcion = queryDescripcion.ElementAt(i).Descripcion;
            //        //        int id = queryDescripcion.ElementAt(i).Id;

            //        //        this.DGV_Campañas.Rows.Add(url, Descripcion, id);
            //        //    }

            //        //    this.DGV_Campañas.Refresh();
            //        //}
            //    }

            //    else
            //    {
            //        MessageBox.Show("Seleccione un metodo de busqueda");
            //    }


            //}
        }

        
    }
}
