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
    public partial class ModificarEliminarCampaña : Form
    {
        public ModificarEliminarCampaña()
        {
            InitializeComponent();
        }
       
        private void rb_intervaloFechas_CheckedChanged(object sender, EventArgs e)
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
            mtxt_inicio.Mask = "00:00:00";
            mtxt_inicio.Refresh();
            mtxt_fin.Mask = "00:00:00";
            mtxt_fin.Refresh();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarEliminarCampaña_Load(object sender, EventArgs e)
        {
            FachadaCampaña fachadaCampaña = new FachadaCampaña();
            FachadaIntervaloFechas fachadaFechas = new FachadaIntervaloFechas();

            IList<CampañaDTO> campañas = fachadaCampaña.ObtenerCampanias();

            IList<IntervaloFechasDTO> fechas = (new FachadaIntervaloFechas()).ObtenerIntervalos();

            foreach (CampañaDTO campaña in campañas)
            {
                IntervaloFechasDTO intervaloCam = fechas.FirstOrDefault(intervalo =>
                                                      intervalo.Id == campaña.IntervaloFechaId);                
                
                DGV_Campañas.Rows.Add(campaña.HoraInicio, campaña.HoraFin, campaña.Id,
                                        intervaloCam.FechaInicio.ToString("dd/MM/yyyy"),
                                        intervaloCam.FechaFin.ToString("dd/MM/yyyy"), intervaloCam.Id);                
            }

                                

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            FachadaCampaña fachadaCampaña = new FachadaCampaña();
            CampañaDTO campaña = new CampañaDTO();
            campaña.Id = Convert.ToInt32(DGV_Campañas.CurrentRow.Cells[2].Value);
            campaña.HoraInicio = TimeSpan.Parse(Convert.ToString(DGV_Campañas.CurrentRow.Cells[0].Value));
            campaña.HoraFin = TimeSpan.Parse(Convert.ToString(DGV_Campañas.CurrentRow.Cells[1].Value));
            fachadaCampaña.EliminarCampaña(campaña);
            DGV_Campañas.Rows.Remove((DGV_Campañas.CurrentRow));
            MessageBox.Show("La campaña fue eliminada con exito!");
            DGV_Campañas.Refresh();
            btn_modificar.Enabled = false;
            btn_eliminar.Enabled = false;


        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            CampañaDTO campania = new CampañaDTO();
            campania.HoraInicio = TimeSpan.Parse(Convert.ToString(DGV_Campañas.CurrentRow.Cells[0].Value));
            campania.HoraFin = TimeSpan.Parse(Convert.ToString(DGV_Campañas.CurrentRow.Cells[1].Value));
            campania.Id = (Convert.ToInt32(DGV_Campañas.CurrentRow.Cells[2].Value));
            campania.IntervaloFechaId = (Convert.ToInt32(DGV_Campañas.CurrentRow.Cells[5].Value));
            Campañas campaniaInterfaz = new Campañas(campania);
            campaniaInterfaz.ShowDialog();
            //DGV_Campañas.CurrentRow.Cells[0].Value = campania.HoraInicio;
            //DGV_Campañas.CurrentRow.Cells[1].Value = campania.HoraFin;

            //IntervaloFechasDTO intervaloCamp = (new FachadaIntervaloFechas()).ObtenerIntervalos().
            //                                        FirstOrDefault(intervalo =>
            //                                            intervalo.Id == campania.IntervaloFechaId);
            //DGV_Campañas.CurrentRow.Cells[3].Value = intervaloCamp.FechaInicio.ToString("dd/MM/yyyy");
            //DGV_Campañas.CurrentRow.Cells[4].Value = intervaloCamp.FechaFin.ToString("dd/MM/yyyy");




            
            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;
        }

        private void DGV_Campañas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_eliminar.Enabled = true;
            btn_modificar.Enabled = true;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            FachadaCampaña fachadaCampaña = new FachadaCampaña();
            IList<CampañaDTO> campañas = new List<CampañaDTO>();
            campañas = fachadaCampaña.ObtenerCampanias();

            this.DGV_Campañas.Rows.Clear();

            if (rb_intervaloHorario.Checked)
            {
                var queryDescripcion = from campania in campañas
                                       where campania.HoraInicio <= TimeSpan.Parse(mtxt_inicio.Text) && 
                                                campania.HoraFin >= TimeSpan.Parse(mtxt_fin.Text) 
                                       select campania;

                if (queryDescripcion != null)
                {
                    for (int i = 0; i <= queryDescripcion.Count() - 1; i++)
                    {
                        TimeSpan inicio = queryDescripcion.ElementAt(i).HoraInicio;
                        TimeSpan fin = queryDescripcion.ElementAt(i).HoraFin;
                        int id = queryDescripcion.ElementAt(i).Id;

                        IntervaloFechasDTO intervaloFecha = (new FachadaIntervaloFechas()).ObtenerIntervalos().FirstOrDefault
                                                  (intervalo => intervalo.Id == queryDescripcion.ElementAt(i).IntervaloFechaId);


                        this.DGV_Campañas.Rows.Add(inicio, fin, id, intervaloFecha.FechaInicio.Date, intervaloFecha.FechaFin.Date, intervaloFecha.Id);
                    }

                    this.DGV_Campañas.Refresh();
                }

            }

            else
            {
                if (rb_intervaloFechas.Checked)
                {
                    //var queryDescripcion = from campania in campañas
                    //                       where campania. == txt_busqueda.Text
                    //                       select campania;

                    //if (queryDescripcion != null)
                    //{
                    //    for (int i = 0; i <= queryDescripcion.Count() - 1; i++)
                    //    {
                    //        string url = queryDescripcion.ElementAt(i).Url;
                    //        string Descripcion = queryDescripcion.ElementAt(i).Descripcion;
                    //        int id = queryDescripcion.ElementAt(i).Id;

                    //        this.DGV_Campañas.Rows.Add(url, Descripcion, id);
                    //    }

                    //    this.DGV_Campañas.Refresh();
                    //}
                }

                else
                {
                    MessageBox.Show("Seleccione un metodo de busqueda");
                }


            }

        }
                            
    }
}
