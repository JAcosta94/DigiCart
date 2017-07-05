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

            rb_intervaloFechas.Checked = true;
            List<Banner> banners = this.iFachadaBanner.ObtenerBanners();

            foreach (Banner banner in banners)
            {                
                if (banner is BannerFuenteTextoFijo)
                {
                    DGV_Banners.Rows.Add(banner.iIdBanner, banner.iNombre, banner.iHoraInicio, banner.iHoraFin,
                                        banner.iFechaInicio.ToString("dd/MM/yyyy"), banner.iFechaFin.ToString("dd/MM/yyyy"),
                                        "Texto Fijo");
                }
                else
                {
                    DGV_Banners.Rows.Add(banner.iIdBanner, banner.iNombre, banner.iHoraInicio, banner.iHoraFin, 
                                        banner.iFechaInicio.ToString("dd/MM/yyyy"),
                                        banner.iFechaFin.ToString("dd/MM/yyyy"),
                                        "Fuente RSS");
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            int idBannerAEliminar = Convert.ToInt32(DGV_Banners.CurrentRow.Cells[0].Value);
            iFachadaBanner.EliminarBanner(idBannerAEliminar);

            //Actualizamos la grilla
            DGV_Banners.Rows.Remove((DGV_Banners.CurrentRow));
            MessageBox.Show("El banner fue eliminado con exito!");
            DGV_Banners.Refresh();

            btn_modificar.Enabled = false;
            btn_eliminar.Enabled = false;

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            //Obtiene la campaña a modificar a partir del ID de la grilla
            Banner banner = iFachadaBanner.ObtenerBanner(Convert.ToInt32(DGV_Banners.CurrentRow.Cells[0].Value));

            // Abre el formulario de alta de campañas tomando los datos de la campaña a modificar
            AgregarBanner bannerInterfaz = new AgregarBanner(banner);
            bannerInterfaz.ShowDialog();            
            

            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;

            this.Close();

        }

        private void DGV_Banners_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btn_eliminar.Enabled = true;
            this.btn_modificar.Enabled = true;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            List<Banner> listaFiltrada = null;
            //Si se completaron los dos Masked con datos para filtrar
            if (mtxt_inicio.MaskCompleted && mtxt_fin.MaskCompleted)
            {
                if (rb_intervaloFechas.Checked)//Se filtra por fechas
                {
                    //Obtenemos lista entre FechaInicio y FechaFin                    
                    listaFiltrada = iFachadaBanner.ObtenerBanners(Convert.ToDateTime(mtxt_inicio.Text), Convert.ToDateTime(mtxt_fin.Text));
                }
                else//No se filtra por fechas
                {
                    if (rb_intervaloHorario.Checked)//Se filtra por horas
                    {
                        //Obtenemos lista entre HoraInicio y HoraFin 
                        listaFiltrada = iFachadaBanner.ObtenerBanners(TimeSpan.Parse(mtxt_inicio.Text), TimeSpan.Parse(mtxt_fin.Text));
                    }
                }
                if (listaFiltrada.Any())//Si encontramos resultado al filtrar
                {
                    this.DGV_Banners.Rows.Clear();
                    foreach (Banner banner in listaFiltrada)//Recorremos la lista y llenamos la grilla
                    {
                        if (banner is BannerFuenteRSS)
                        {
                            DGV_Banners.Rows.Add(banner.iIdBanner, banner.iNombre, banner.iHoraInicio, banner.iHoraFin, banner.iFechaInicio.ToString("dd/MM/yyyy"), banner.iFechaFin.ToString("dd/MM/yyyy"), "FUENTE RSS");
                        }
                        else
                        {
                            DGV_Banners.Rows.Add(banner.iIdBanner, banner.iNombre, banner.iHoraInicio, banner.iHoraFin, banner.iFechaInicio.ToString("dd/MM/yyyy"), banner.iFechaFin.ToString("dd/MM/yyyy"), "TEXTO FIJO");
                        }                        
                    }
                }
                else//No encontramos resultado al filtrar
                {
                    this.DGV_Banners.Rows.Clear();
                    MessageBox.Show("No se encontraron resultados!");
                }
            }//end if de masked vacios
            else
            {
                MessageBox.Show("Debe ingresar datos para filtrar!");
            }
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {

        }
        
    }
}
