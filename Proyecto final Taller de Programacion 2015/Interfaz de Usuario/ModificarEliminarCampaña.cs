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
        private ControladorCampaña iFachadaCampaña;

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
            this.iFachadaCampaña = new ControladorCampaña();            
            
            //Obtenemos todas las campañas almacenadas en la BD.
            IQueryable<Campaña> campañas = this.iFachadaCampaña.ObtenerCampañas();
            
            //Cargamos la informacion de las campañas al datagridview de campañas.
            foreach (Campaña campaña in campañas)
            {
                DGV_Campañas.Rows.Add(campaña.iIdCampaña, campaña.iNombre,campaña.iHoraInicio, campaña.iHoraFin, campaña.iFechaInicio.ToString("dd/MM/yyyy"), campaña.iFechaFin.ToString("dd/MM/yyyy"));
            }

                                

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            
            int idCampañaAEliminar = Convert.ToInt32(DGV_Campañas.CurrentRow.Cells[0].Value);
            iFachadaCampaña.EliminarCampaña(idCampañaAEliminar);
            
            //Actualizamos el datagridview
            DGV_Campañas.Rows.Remove((DGV_Campañas.CurrentRow));
            MessageBox.Show("La campaña fue eliminada con exito!");
            DGV_Campañas.Refresh();

            btn_modificar.Enabled = false;
            btn_eliminar.Enabled = false;


        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {           
            /*Campaña campania = new Campaña();                   
            campania.iIdCampaña = (Convert.ToInt32(DGV_Campañas.CurrentRow.Cells[0].Value));
            campania.iNombre = Convert.ToString(DGV_Campañas.CurrentRow.Cells[1].Value);                                
            campania.iHoraInicio = TimeSpan.Parse(Convert.ToString(DGV_Campañas.CurrentRow.Cells[2].Value));
            campania.iHoraFin = TimeSpan.Parse(Convert.ToString(DGV_Campañas.CurrentRow.Cells[3].Value));
            campania.iFechaInicio = Convert.ToDateTime(DGV_Campañas.CurrentRow.Cells[4].Value);
            campania.iFechaFin = Convert.ToDateTime(DGV_Campañas.CurrentRow.Cells[4].Value);*/

            //Campaña campania = new Campaña
            //{
            //    iIdCampaña = (Convert.ToInt32(DGV_Campañas.CurrentRow.Cells[0].Value)),
            //    iNombre = Convert.ToString(DGV_Campañas.CurrentRow.Cells[1].Value),
            //    iHoraInicio = TimeSpan.Parse(Convert.ToString(DGV_Campañas.CurrentRow.Cells[2].Value)),
            //    iHoraFin = TimeSpan.Parse(Convert.ToString(DGV_Campañas.CurrentRow.Cells[3].Value)),                
            //    iFechaInicio = Convert.ToDateTime(DGV_Campañas.CurrentRow.Cells[4].Value),
            //    iFechaFin = Convert.ToDateTime(DGV_Campañas.CurrentRow.Cells[5].Value)                
            //};

            Campaña campania = iFachadaCampaña.ObtenerCampaña(Convert.ToInt32(DGV_Campañas.CurrentRow.Cells[0].Value));
            AgregarCampaña campaniaInterfaz = new AgregarCampaña(campania);
            campaniaInterfaz.ShowDialog();

            DGV_Campañas.CurrentRow.Cells[1].Value = campania.iNombre;
            DGV_Campañas.CurrentRow.Cells[2].Value = campania.iHoraInicio;
            DGV_Campañas.CurrentRow.Cells[3].Value = campania.iHoraFin;
            DGV_Campañas.CurrentRow.Cells[4].Value = campania.iFechaInicio.ToString("dd/MM/yyyy");
            DGV_Campañas.CurrentRow.Cells[5].Value = campania.iFechaFin.ToString("dd/MM/yyyy");

            DGV_Campañas.Refresh();
            /*DGV_Campañas.CurrentRow.Cells[0].Value = campania.iIdCampaña;
            DGV_Campañas.CurrentRow.Cells[1].Value = campania.iNombre;
            DGV_Campañas.CurrentRow.Cells[2].Value = campania.iHoraInicio;
            DGV_Campañas.CurrentRow.Cells[3].Value = campania.iHoraFin;
            DGV_Campañas.CurrentRow.Cells[4].Value = campania.iFechaInicio.ToString("dd/MM/yyyy");
            DGV_Campañas.CurrentRow.Cells[5].Value = campania.iFechaFin.ToString("dd/MM/yyyy");*/


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
            //FachadaCampaña fachadaCampaña = new FachadaCampaña();
            //IList<CampañaDTO> campañas = new List<CampañaDTO>();
            //campañas = fachadaCampaña.ObtenerCampanias();

            //this.DGV_Campañas.Rows.Clear();

            //if (rb_intervaloHorario.Checked)
            //{
            //    var queryDescripcion = from campania in campañas
            //                           where campania.HoraInicio <= TimeSpan.Parse(mtxt_inicio.Text) && 
            //                                    campania.HoraFin >= TimeSpan.Parse(mtxt_fin.Text) 
            //                           select campania;

            //    if (queryDescripcion != null)
            //    {
            //        for (int i = 0; i <= queryDescripcion.Count() - 1; i++)
            //        {
            //            TimeSpan inicio = queryDescripcion.ElementAt(i).HoraInicio;
            //            TimeSpan fin = queryDescripcion.ElementAt(i).HoraFin;
            //            int id = queryDescripcion.ElementAt(i).Id;

            //            IntervaloFechasDTO intervaloFecha = (new FachadaIntervaloFechas()).ObtenerIntervalos().FirstOrDefault
            //                                      (intervalo => intervalo.Id == queryDescripcion.ElementAt(i).IntervaloFechaId);


            //            this.DGV_Campañas.Rows.Add(inicio, fin, id, intervaloFecha.FechaInicio.Date, intervaloFecha.FechaFin.Date, intervaloFecha.Id);
            //        }

            //        this.DGV_Campañas.Refresh();
            //    }

            //}

            //else
            //{
            //    if (rb_intervaloFechas.Checked)
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

        private void DGV_Campañas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
                            
    }
}
