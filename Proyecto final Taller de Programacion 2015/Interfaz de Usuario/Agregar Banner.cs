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
using Excepciones;

namespace WindowsFormsApplication
{
    public partial class AgregarBanner : Form
    {
        private Banner iBanner;
        private ControladorBanner iFachadaBanner;
        private ControladorFuenteBanner iFachadaFuente;
        private bool iModificar;

       
        public AgregarBanner()
        {
            this.iModificar = false;
            this.iFachadaBanner = new ControladorBanner();
            this.iFachadaFuente = new ControladorFuenteBanner();            
            InitializeComponent();
        }

        public AgregarBanner(Banner pBanner)
        {
            this.iModificar = true;
            this.iFachadaBanner = new ControladorBanner();
            this.iFachadaFuente = new ControladorFuenteBanner();
            this.iBanner = pBanner;            
            InitializeComponent();
        }

 

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void banner_Load(object sender, EventArgs e)        
        {
            //Si se inicializa el formulario con una campaña a modificar
            if (iBanner != null) //Entramos aqui si entramos queriendo modificar un banner
            {
                //Cargamos los datos de la campaña en los TextBox
                dtp_fechaInicio.Text = iBanner.iFechaInicio.ToString("dd/MM/yyyy");
                dtp_fechaFin.Text = iBanner.iFechaFin.ToString("dd/MM/yyyy");
                mtxt_horaInicio.Text = Convert.ToString(iBanner.iHoraInicio);
                mtxt_horaFin.Text = Convert.ToString(iBanner.iHoraFin);
                txt_nombre.Text = Convert.ToString(iBanner.iNombre);
              
                if (this.iBanner is BannerFuenteRSS)
                {   //Este es un control que acomoda la pantalla cuando queremos modificar un banner fuente rss

                    rb_fuenteRSS.Checked = true;
                    dgv_fuentesRSS.Enabled = true;
                    txt_textoFijo.Enabled = false;
                    lbl_ayuda.Enabled = true;
                    dgv_fuentesRSS.DataSource = this.iFachadaFuente.ObtenerFuentesRSS().ToList();
                    #region Acomodando DGV.
                    dgv_fuentesRSS.Columns["iIdFuenteRSS"].Visible = false;
                    dgv_fuentesRSS.Columns["iUltimaObtencionDeFeeds"].Visible = false;
                    dgv_fuentesRSS.Columns["iDescripcion"].HeaderText = "Nombre Fuente";
                    dgv_fuentesRSS.Columns["iUrl"].HeaderText = "URL fuente";
                    dgv_fuentesRSS.Columns["iUrl"].FillWeight = 70;
                    dgv_fuentesRSS.Columns["iDescripcion"].FillWeight = 30;

                    #endregion

                    lbl_ayuda.Text = "Fuente actual: " + 
                        iFachadaFuente.ObtenerFuenteRSS((this.iBanner as BannerFuenteRSS).iIdFuenteRSS).iDescripcion;


                }
                else
                {  //Este es un control que acomoda la pantalla cuando queremos modificar un banner texto fijo

                    rb_textoFijo.Checked = true;
                    dgv_fuentesRSS.Enabled = false;
                    txt_textoFijo.Enabled = true;
                    lbl_ayuda.Enabled = false;
                    this.dgv_fuentesRSS.DataSource = null;
                    
                    txt_textoFijo.Text = (this.iBanner as BannerFuenteTextoFijo).TextoFijo;
                }

                //Actualizamos el nombre de la ventana a modificar campaña
                this.Text = "Modificar Campaña";
                this.Refresh();
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {   
                //Variable auxiliar, para controlar que la hora de fin no supere la que se almacena aqui.
                TimeSpan tiempoMaximo = new TimeSpan(23, 59, 59);               

                if (                         
                            (TimeSpan.Parse(mtxt_horaFin.Text) < tiempoMaximo ||
                                TimeSpan.Parse(mtxt_horaInicio.Text) < tiempoMaximo) &&
                                    (TimeSpan.Parse(mtxt_horaInicio.Text) < TimeSpan.Parse(mtxt_horaFin.Text)) &&
                                        (Convert.ToDateTime(dtp_fechaInicio.Text) < Convert.ToDateTime(dtp_fechaFin.Text)) &&
                                            (Convert.ToDateTime(dtp_fechaInicio.Text) >= DateTime.Today && Convert.ToDateTime(dtp_fechaFin.Text) > DateTime.Today))
                {

                    if (!this.iModificar)    //Agregando un NUEVO banner
                    {

                        if (rb_fuenteRSS.Checked)
                        {
                            BannerFuenteRSS bannerRSS = new BannerFuenteRSS();                                                                                   
                            bannerRSS.iIdFuenteRSS = Convert.ToInt32(dgv_fuentesRSS.CurrentRow.Cells[0].Value);
                            this.iBanner = bannerRSS;
                        }

                        else 
                        {
                            BannerFuenteTextoFijo bannerTextoFijo = new BannerFuenteTextoFijo();
                            bannerTextoFijo.TextoFijo = txt_textoFijo.Text;
                            this.iBanner = bannerTextoFijo;
                        }

                        this.iBanner.iHoraFin = TimeSpan.Parse(mtxt_horaFin.Text);
                        this.iBanner.iHoraInicio = TimeSpan.Parse(mtxt_horaInicio.Text);
                        this.iBanner.iFechaInicio = Convert.ToDateTime(dtp_fechaInicio.Text);
                        this.iBanner.iFechaFin = Convert.ToDateTime(dtp_fechaFin.Text);
                        this.iBanner.iNombre = txt_nombre.Text;
                        this.iFachadaBanner.AgregarBanner(this.iBanner);                                              
                        
                        MessageBox.Show("El banner fue guardado con exito");
                        this.Close();                        
                    }

                    else//MODIFICACION de banner
                    {
                        if (rb_fuenteRSS.Checked && (this.iBanner is BannerFuenteTextoFijo))
                        {
                            if (MessageBox.Show(@"Advertencia, este banner contiene un texto fijo configurado si continua y configura una fuente RSS para este banner los datos del texto fijo se perderan. 
                                             
                                      ¿Esta seguro de continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                //En caso de modificar un banner fuente texto fijo para convertirlo en un banner rss, lo que
                                //hacemos es borrarlo y agregarlo nuevamente pero como texto fijo
                                int id = this.iBanner.iIdBanner;
                                this.iFachadaBanner.EliminarBanner(id);
                                
                                BannerFuenteRSS bannerRSS = new BannerFuenteRSS();
                                bannerRSS.iIdFuenteRSS = Convert.ToInt32(dgv_fuentesRSS.CurrentRow.Cells[0].Value);
                                this.iBanner = bannerRSS;
                                this.iBanner.iHoraFin = TimeSpan.Parse(mtxt_horaFin.Text);
                                this.iBanner.iHoraInicio = TimeSpan.Parse(mtxt_horaInicio.Text);
                                this.iBanner.iNombre = txt_nombre.Text;
                                this.iBanner.iFechaInicio = Convert.ToDateTime(dtp_fechaInicio.Text);
                                this.iBanner.iFechaFin = Convert.ToDateTime(dtp_fechaFin.Text);                                
                                
                                this.iFachadaBanner.AgregarBanner(this.iBanner);                               
                                MessageBox.Show("El banner fue modificado con exito");
                                this.Close();

                            }

                        }

                        else
                        {
                            if (rb_fuenteRSS.Checked && this.iBanner is BannerFuenteRSS)
                            {

                                int id = this.iBanner.iIdBanner;
                                BannerFuenteRSS bannerRSS = new BannerFuenteRSS();
                                FuenteRSS fuenteAsociar = new FuenteRSS
                                {
                                    iIdFuenteRSS = Convert.ToInt32(dgv_fuentesRSS.CurrentRow.Cells[0].Value),
                                    iDescripcion = Convert.ToString(dgv_fuentesRSS.CurrentRow.Cells[2].Value),
                                    iUltimaObtencionDeFeeds = Convert.ToString(dgv_fuentesRSS.CurrentRow.Cells[3].Value),
                                    iUrl = Convert.ToString(dgv_fuentesRSS.CurrentRow.Cells[1].Value)
                                };

                                bannerRSS.iIdFuenteRSS = Convert.ToInt32(dgv_fuentesRSS.CurrentRow.Cells[0].Value);
                                this.iBanner = bannerRSS;
                                this.iBanner.iHoraFin = TimeSpan.Parse(mtxt_horaFin.Text);
                                this.iBanner.iHoraInicio = TimeSpan.Parse(mtxt_horaInicio.Text);
                                this.iBanner.iNombre = txt_nombre.Text;
                                this.iBanner.iFechaInicio = Convert.ToDateTime(dtp_fechaInicio.Text);
                                this.iBanner.iFechaFin = Convert.ToDateTime(dtp_fechaFin.Text);
                                this.iBanner.iIdBanner = id;

                                this.iFachadaBanner.ModificarBanner(this.iBanner);
                                MessageBox.Show("El banner fue modificado con exito");
                                this.Close();

                            }

                            else
                            {
                                if (rb_textoFijo.Checked && this.iBanner is BannerFuenteRSS)
                                {
                                    if (MessageBox.Show(@"Advertencia, este banner contiene un fuente RSS configurada si continua y configura un texto fijo para este banner los datos de la fuente rss se perderan. 
                                             
                                      ¿Esta seguro de continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        //En caso de modificar un banner rss para convertirlo en un banner texto fijo, lo que
                                        //hacemos es borrarlo y agregarlo nuevamente pero como texto fijo
                                        int id = this.iBanner.iIdBanner;
                                        this.iFachadaBanner.EliminarBanner(id);

                                        BannerFuenteTextoFijo bannerTextoFijo = new BannerFuenteTextoFijo();
                                        bannerTextoFijo.TextoFijo = txt_textoFijo.Text;
                                        this.iBanner = bannerTextoFijo;
                                        this.iBanner.iHoraFin = TimeSpan.Parse(mtxt_horaFin.Text);
                                        this.iBanner.iHoraInicio = TimeSpan.Parse(mtxt_horaInicio.Text);
                                        this.iBanner.iNombre = txt_nombre.Text;
                                        this.iBanner.iFechaInicio = Convert.ToDateTime(dtp_fechaInicio.Text);
                                        this.iBanner.iFechaFin = Convert.ToDateTime(dtp_fechaFin.Text);
                                        this.iBanner.iIdBanner = id;

                                        this.iFachadaBanner.AgregarBanner(this.iBanner);                                        
                                        MessageBox.Show("El banner fue modificado con exito");
                                        this.Close();

                                    }
                                }

                                    else
                                    {
                                        if (rb_textoFijo.Checked && this.iBanner is BannerFuenteTextoFijo)
                                        {
                                            int id = this.iBanner.iIdBanner;
                                            BannerFuenteTextoFijo bannerTextoFijo = new BannerFuenteTextoFijo();
                                            bannerTextoFijo.TextoFijo = txt_textoFijo.Text;
                                            this.iBanner = bannerTextoFijo;
                                            this.iBanner.iHoraFin = TimeSpan.Parse(mtxt_horaFin.Text);
                                            this.iBanner.iHoraInicio = TimeSpan.Parse(mtxt_horaInicio.Text);
                                            this.iBanner.iNombre = txt_nombre.Text;
                                            this.iBanner.iFechaInicio = Convert.ToDateTime(dtp_fechaInicio.Text);
                                            this.iBanner.iFechaFin = Convert.ToDateTime(dtp_fechaFin.Text);
                                            this.iBanner.iIdBanner = id;

                                            this.iFachadaBanner.ModificarBanner(this.iBanner);
                                            MessageBox.Show("El banner fue modificado con exito");
                                            this.Close();
                                        }                                    
                                    }
                                }                            
                            }                                                
                        }
                }
                
                else
                {
                    //Aqui se entra si hay errores en los ingresos de datos. A la error string le concatenamos 
                    //los errores segun coincidan en las condiciones de los if. 

                    string ErrorString = "Se han detectado el (o los) siguente(s) error(es): \n";

                    /*
                     if (this.iBanner == null)
                    {
                        ErrorString = ErrorString + ("• El banner no fue configurado con ninguna fuente rss o texto fijo \n");
                    } 
                    */

                    if (TimeSpan.Parse(mtxt_horaFin.Text) > tiempoMaximo ||
                            TimeSpan.Parse(mtxt_horaInicio.Text) > tiempoMaximo)
                    {
                        ErrorString = ErrorString + ("• La hora de inicio y/o de fin estan mal ingresadas. Valores validos desde 00:00:00 hasta 23:59:59 \n");
                    }

                    if ((TimeSpan.Parse(mtxt_horaInicio.Text) >= TimeSpan.Parse(mtxt_horaFin.Text)))
                    {
                        ErrorString = ErrorString + ("• La hora de inicio no puede ser mayor o igual a la de fin \n");
                    }

                    if (Convert.ToDateTime(dtp_fechaInicio.Text) >= Convert.ToDateTime(dtp_fechaFin.Text))
                    {
                        ErrorString = ErrorString + ("• La fecha de inicio no puede ser mayor que la de fin \n");
                    }

                    if ((Convert.ToDateTime(dtp_fechaInicio.Text) <= DateTime.Today || Convert.ToDateTime(dtp_fechaFin.Text) < DateTime.Today))
                    {
                        ErrorString = ErrorString + ("• La fecha de inicio y/o fin deben ser mayores a la actual \n");
                    }

                    MessageBox.Show(ErrorString);

                }


            }

            catch (FormatException)
            {
                MessageBox.Show("Error, revise los datos ingresados");
            }
            catch (BannerNoDisponibleException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {

        }

        private void rb_textoFijo_CheckedChanged(object sender, EventArgs e)
        {
            txt_textoFijo.Enabled = true;
            dgv_fuentesRSS.Enabled = false;
            dgv_fuentesRSS.DataSource = null;
            lbl_ayuda.Visible = false;
        }

        private void rb_fuenteRSS_CheckedChanged(object sender, EventArgs e)
        {
            txt_textoFijo.Text = "";
            dgv_fuentesRSS.Enabled = true;
            lbl_ayuda.Visible = true;
            dgv_fuentesRSS.DataSource =  this.iFachadaFuente.ObtenerFuentesRSS().ToList();

            if (this.iFachadaFuente.ObtenerFuentesRSS().ToList().Count == 0)
            {
                //Si no hay fuentes rss almacenadas, despliega un mensaje de ayuda para el usuario.
                this.lbl_ayuda.Text = "No hay ninguna Fuente RSS cargada, por favor salga y vaya a Fuente RSS --> Agregar Fuente RSS";
            }

            #region Acomodando DGV.
            dgv_fuentesRSS.Columns["iIdFuenteRSS"].Visible = false;
            dgv_fuentesRSS.Columns["iUltimaObtencionDeFeeds"].Visible = false;
            dgv_fuentesRSS.Columns["iDescripcion"].HeaderText = "Nombre Fuente";
            dgv_fuentesRSS.Columns["iUrl"].HeaderText = "URL fuente";
            dgv_fuentesRSS.Columns["iUrl"].FillWeight = 70;
            dgv_fuentesRSS.Columns["iDescripcion"].FillWeight = 30;

            #endregion
            
            txt_textoFijo.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtp_fechaFin_ValueChanged(object sender, EventArgs e)
        {

        }        
    }
}