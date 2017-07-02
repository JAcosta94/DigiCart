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
            //this.iModificar = false;
            InitializeComponent();
        }

        public AgregarBanner(Banner pBanner)
        {
            this.iModificar = true;
            this.iFachadaBanner = new ControladorBanner();
            this.iFachadaFuente = new ControladorFuenteBanner();
            this.iBanner = pBanner;
            //this.iModificar = true;    
            InitializeComponent();
        }

 

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void banner_Load(object sender, EventArgs e)        
        {
            //Si se inicializa el formulario con una campaña a modificar
            if (iBanner != null)
            {
                //Cargamos los datos de la campaña en los TextBox
                dtp_fechaInicio.Text = iBanner.iFechaInicio.ToString("dd/MM/yyyy");
                dtp_fechaFin.Text = iBanner.iFechaFin.ToString("dd/MM/yyyy");
                mtxt_horaInicio.Text = Convert.ToString(iBanner.iHoraInicio);
                mtxt_horaFin.Text = Convert.ToString(iBanner.iHoraFin);
                txt_nombre.Text = Convert.ToString(iBanner.iNombre);
                if (this.iBanner is BannerFuenteRSS)
                {
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

                    lbl_ayuda.Text = "Fuente actual: " + (this.iBanner as BannerFuenteRSS).iFuenteRSS.iDescripcion;


                }
                else
                {
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
                TimeSpan tiempoMaximo = new TimeSpan(23, 59, 59);
                

                //if (this.iBanner != null)
                //{
                //    //Si entramos desde modificar banner en Modificar/eliminar banners hacemos esta
                //    //asignacion para que pase el primer if

                //    //if (this.iBanner.TextoFijo == null)
                //    //{
                //    //    this.iTextoFijo = null;
                //    //    this.iFuenteId = this.iBanner.FuenteRSSId;
                //    //}

                //    //else
                //    //{
                //    //    this.iTextoFijo = this.iBanner.TextoFijo;
                //    //    this.iFuenteId = null;
                //    //}
                //}


                if (                         
                            (TimeSpan.Parse(mtxt_horaFin.Text) < tiempoMaximo ||
                                TimeSpan.Parse(mtxt_horaInicio.Text) < tiempoMaximo) &&
                                    (TimeSpan.Parse(mtxt_horaInicio.Text) < TimeSpan.Parse(mtxt_horaFin.Text)) &&
                                        (Convert.ToDateTime(dtp_fechaInicio.Text) < Convert.ToDateTime(dtp_fechaFin.Text))
                        )
                {
                    if (!this.iModificar)
                    {

                        if (rb_fuenteRSS.Checked)
                        {
                            BannerFuenteRSS bannerRSS = new BannerFuenteRSS();
                            FuenteRSS fuenteAsociar = new FuenteRSS
                            {
                                iIdFuenteRSS = Convert.ToInt32(dgv_fuentesRSS.CurrentRow.Cells[0].Value),
                                iDescripcion = Convert.ToString(dgv_fuentesRSS.CurrentRow.Cells[2].Value),
                                iUltimaObtencionDeFeeds = Convert.ToString(dgv_fuentesRSS.CurrentRow.Cells[3].Value),
                                iUrl = Convert.ToString(dgv_fuentesRSS.CurrentRow.Cells[1].Value)
                            };

                            bannerRSS.iFuenteRSS = fuenteAsociar;
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
                        
                        

                        //banner.FuenteRSSId = iFuenteId;
                        //banner.TextoFijo = iTextoFijo;

                        //banner.FuenteRSSId = this.iFuenteId;
                        //banner.TextoFijo = this.iTextoFijo;

                        //if (fachadaBanner.CrearBanner(banner, intervalo))
                        //{
                            MessageBox.Show("El banner fue guardado con exito");
                            this.Close();
                        //}

                        //else
                        //{
                        //    MessageBox.Show("Error, el banner no esta disponible en los rangos de fechas y/o horarios dados");
                        //}

                    }

                    else
                    {
                        if (rb_fuenteRSS.Checked && (this.iBanner is BannerFuenteTextoFijo))
                        {
                            if (MessageBox.Show(@"Advertencia, este banner contiene un texto fijo configurado si continua y configura una fuente RSS para este banner los datos del texto fijo se perderan. 
                                             
                                      ¿Esta seguro de continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                int id = this.iBanner.iIdBanner;
                                this.iFachadaBanner.EliminarBanner(id);


                                BannerFuenteRSS bannerRSS = new BannerFuenteRSS();
                                FuenteRSS fuenteAsociar = new FuenteRSS
                                {
                                    iIdFuenteRSS = Convert.ToInt32(dgv_fuentesRSS.CurrentRow.Cells[0].Value),
                                    iDescripcion = Convert.ToString(dgv_fuentesRSS.CurrentRow.Cells[2].Value),
                                    iUltimaObtencionDeFeeds = Convert.ToString(dgv_fuentesRSS.CurrentRow.Cells[3].Value),
                                    iUrl = Convert.ToString(dgv_fuentesRSS.CurrentRow.Cells[1].Value)
                                };

                                bannerRSS.iFuenteRSS = fuenteAsociar;
                                this.iBanner = bannerRSS;
                                this.iBanner.iHoraFin = TimeSpan.Parse(mtxt_horaFin.Text);
                                this.iBanner.iHoraInicio = TimeSpan.Parse(mtxt_horaInicio.Text);
                                this.iBanner.iNombre = txt_nombre.Text;
                                this.iBanner.iFechaInicio = Convert.ToDateTime(dtp_fechaInicio.Text);
                                this.iBanner.iFechaFin = Convert.ToDateTime(dtp_fechaFin.Text);
                                //this.iBanner.iIdBanner = id;
                                this.iFachadaBanner.AgregarBanner(this.iBanner);

                               // this.iFachadaBanner.ModificarBanner(this.iBanner);
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

                                bannerRSS.iFuenteRSS = fuenteAsociar;
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

                                        //this.iFachadaBanner.ModificarBanner(this.iBanner);
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
                        //if (fachadaBanner.ModificarBanner(iBanner, intervalo))
                        //{
                        //    MessageBox.Show("El banner fue modificado con exito");
                        //    this.Close();
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Error, el banner no esta disponible en los rangos de fechas y/o horarios dados");
                        //}

                
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

                    MessageBox.Show(ErrorString);

                }


            }

            catch (FormatException)
            {
                MessageBox.Show("Error, revise los datos ingresados");
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
            dgv_fuentesRSS.Enabled = true;
            lbl_ayuda.Visible = true;
            dgv_fuentesRSS.DataSource =  this.iFachadaFuente.ObtenerFuentesRSS().ToList();

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
    }
}