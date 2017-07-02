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
        private ControladorCampaña iFachadaCampaña = new ControladorCampaña();

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
            //Obtenemos todas las campañas almacenadas en la BD.
            IQueryable<Campaña> campañas = this.iFachadaCampaña.ObtenerCampañas().AsQueryable<Campaña>();
            
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
            //Obtiene la campaña a modificar a partir del ID de la grilla
            Campaña campania = iFachadaCampaña.ObtenerCampaña(Convert.ToInt32(DGV_Campañas.CurrentRow.Cells[0].Value));
            
            // Abre el formulario de alta de campañas tomando los datos de la campaña a modificar
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
            List<Campaña> listaFiltrada = null;
            //Si se completaron los dos Masked con datos para filtrar
            if (mtxt_inicio.MaskCompleted && mtxt_fin.MaskCompleted)
            {
                if (rb_intervaloFechas.Checked)//Se filtra por fechas
                {
                    //Obtenemos lista entre FechaInicio y FechaFin                    
                    listaFiltrada = iFachadaCampaña.ObtenerCampañas(Convert.ToDateTime(mtxt_inicio.Text), Convert.ToDateTime(mtxt_fin.Text));                                        
                }
                else//No se filtra por fechas
                {
                    if (rb_intervaloHorario.Checked)//Se filtra por horas
                    {
                        //Obtenemos lista entre HoraInicio y HoraFin 
                        listaFiltrada = iFachadaCampaña.ObtenerCampañas(TimeSpan.Parse(mtxt_inicio.Text), TimeSpan.Parse(mtxt_fin.Text));                        
                    }
                }                
                if (listaFiltrada.Any())//Si encontramos resultado al filtrar
                {
                    this.DGV_Campañas.Rows.Clear();
                    foreach (Campaña campania in listaFiltrada)//Recorremos la lista y llenamos la grilla
                    {
                        DGV_Campañas.Rows.Add(campania.iIdCampaña, campania.iNombre, campania.iHoraInicio, campania.iHoraFin, campania.iFechaInicio.ToString("dd/MM/yyyy"), campania.iFechaFin.ToString("dd/MM/yyyy"));
                    }
                }
                else//No encontramos resultado al filtrar
                {
                    this.DGV_Campañas.Rows.Clear();
                    MessageBox.Show("No se encontraron resultados!");
                }               
            }//end if de masked vacios
            else
            {
                MessageBox.Show("Debe ingresar datos para filtrar!");
            }

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

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            //Limpiamos textbox
            mtxt_inicio.Clear();
            mtxt_fin.Clear();
            //RadioButton por defecto en filtrado de fechas
            rb_intervaloFechas.Checked = true;
            //Configuramos la grilla
            DGV_Campañas.Rows.Clear();               

            //Obtenemos todas las campañas almacenadas en la BD.
            List<Campaña> campañas = this.iFachadaCampaña.ObtenerCampañas();
                    
            
            //Cargamos la informacion de las campañas en la grilla.
            foreach (Campaña campaña in campañas)
            {
                DGV_Campañas.Rows.Add(campaña.iIdCampaña, campaña.iNombre, campaña.iHoraInicio, campaña.iHoraFin, campaña.iFechaInicio.ToString("dd/MM/yyyy"), campaña.iFechaFin.ToString("dd/MM/yyyy"));
            }

            
            this.DGV_Campañas.Update();
            this.DGV_Campañas.Refresh();

        }

                            
    }
}
