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
    public partial class Formulario_Banner : Form
    {
        private Banner iBanner;
        private string iTextoFijo;
        private int? iFuenteId;
        private bool iModificar;

        public Formulario_Banner()
        {
            this.iModificar = false;
            InitializeComponent();
        }

        public Formulario_Banner(Banner pBanner)
        {
            this.iBanner = pBanner;
            this.iModificar = true;    
            InitializeComponent();
        }

       
        private void btn_configurarBanner_Click(object sender, EventArgs e)
        {
//            try
//            {
//                if (iBanner == null)
//                {
//                    this.iBanner = new Banner();
//                }
                            
//                if (rb_fuenteRSS.Checked)
//                {
//                    //Obtenemos la fuente rss y la almacenamos en el atributo fuenteRssId del
//                    //iBanner
//                    if (this.iBanner.TextoFijo != null)
//                    {
//                        if (MessageBox.Show(@"Advertencia, este banner contiene un texto fijo configurado si continua y asocia una fuente rss los datos del texto fijo se perderan. 
//                                        
//                                  ¿Esta seguro de continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
//                        {
//                            ModificarEliminarFuenteRSS fuenteRSS = new ModificarEliminarFuenteRSS(this.iBanner);
//                            fuenteRSS.ShowDialog();
//                            this.iFuenteId = iBanner.FuenteRSSId;

//                            //el iModificar nos dice si estamos modificando o no, si no estamos modificando 
//                            //debemos dejar a banner en null para que pueda agregarlo despues en el boton de guardar.
//                            if (!iModificar)
//                            { iBanner = null; }
//                        }

//                    }

//                    else
//                    {
//                        ModificarEliminarFuenteRSS fuenteRSS = new ModificarEliminarFuenteRSS(this.iBanner);
//                        fuenteRSS.ShowDialog();
//                        this.iFuenteId = iBanner.FuenteRSSId;

//                        //el iModificar nos dice si estamos modificando o no, si no estamos modificando 
//                        //debemos dejar a banner en null para que pueda agregarlo despues en el boton de guardar.
//                        if (!iModificar)
//                        { iBanner = null; }
                        
//                    }
//                }

//                else
//                {
//                    if (rb_textoFijo.Checked)
//                    {
//                        if (this.iBanner.FuenteRSSId != null)
//                        {
//                            if (MessageBox.Show(@"Advertencia, este banner contiene un fuente rss configurada si continua y configura un texto fijo para este banner los datos de la fuente rss se perderan. 
//                                             
//                                      ¿Esta seguro de continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
//                            {
//                                AgregarTextoFijo textoFijo = new AgregarTextoFijo(this.iBanner);
//                                textoFijo.ShowDialog();
//                                this.iTextoFijo = this.iBanner.TextoFijo;
                                
//                                //el iModificar nos dice si estamos modificando o no, si no estamos modificando 
//                                //debemos dejar a banner en null para que pueda agregarlo despues en el boton de guardar.
//                                if (!iModificar)
//                                { iBanner = null; }
//                            }

//                        }

//                        else
//                        {
//                            AgregarTextoFijo textoFijo = new AgregarTextoFijo(this.iBanner);
//                            textoFijo.ShowDialog();
//                            this.iTextoFijo = this.iBanner.TextoFijo;
                            
//                            //el iModificar nos dice si estamos modificando o no, si no estamos modificando 
//                            //debemos dejar a banner en null para que pueda agregarlo despues en el boton de guardar.
//                            if (!iModificar)
//                            { iBanner = null; }
                            
//                        }
//                    }
//                    else
//                    {
//                        MessageBox.Show("Seleccione un tipo de banner");
//                    }
//                }
//            }

//            catch (FormatException)
//            {
//                MessageBox.Show("Error, revise los datos ingresados");
//            }
            

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void banner_Load(object sender, EventArgs e)        
        {
            //if (iBanner != null)
            //{
            //    IntervaloFechasDTO intervaloCampaña = (new FachadaIntervaloFechas()).ObtenerIntervalos().FirstOrDefault(intervalo =>
            //                                                intervalo.Id == iBanner.IntervaloFechaId);

            //    mtxt_fechaInicio.Text = (intervaloCampaña.FechaInicio).ToString("dd/MM/yyyy");
            //    mtxt_fechaFin.Text = (intervaloCampaña.FechaFin).ToString("dd/MM/yyyy"); 

            //    mtxt_horaInicio.Text = Convert.ToString(iBanner.HoraInicio);
            //    mtxt_horaFin.Text = Convert.ToString(iBanner.HoraFin);

            //    if (iBanner.FuenteRSSId == null)
            //    { rb_textoFijo.Checked = true; }
            //    else
            //    { rb_fuenteRSS.Checked = true; }

            //    this.Text= "Modificar Banner";

            //}
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    TimeSpan tiempoMaximo = new TimeSpan(23, 59, 59);
            //    FachadaBanner fachadaBanner = new FachadaBanner();

            //    if (this.iBanner != null)
            //    {
            //        //Si entramos desde modificar banner en Modificar/eliminar banners hacemos esta
            //        //asignacion para que pase el primer if

            //        if (this.iBanner.TextoFijo == null)
            //        {
            //            this.iTextoFijo = null;
            //            this.iFuenteId = this.iBanner.FuenteRSSId;
            //        }

            //        else
            //        {
            //            this.iTextoFijo = this.iBanner.TextoFijo;
            //            this.iFuenteId = null;
            //        }
            //    }


            //    if (
            //             (this.iTextoFijo != null || this.iFuenteId != null) &&
            //                (TimeSpan.Parse(mtxt_horaFin.Text) < tiempoMaximo ||
            //                    TimeSpan.Parse(mtxt_horaInicio.Text) < tiempoMaximo) &&
            //                        (TimeSpan.Parse(mtxt_horaInicio.Text) < TimeSpan.Parse(mtxt_horaFin.Text)) &&
            //                            (Convert.ToDateTime(mtxt_fechaInicio.Text) < Convert.ToDateTime(mtxt_fechaFin.Text))
            //            )
            //    {
            //        if (iBanner == null)
            //        {


            //            BannerDTO banner = new BannerDTO();
            //            banner.HoraFin = TimeSpan.Parse(mtxt_horaFin.Text);
            //            banner.HoraInicio = TimeSpan.Parse(mtxt_horaInicio.Text);

            //            IntervaloFechasDTO intervalo = new IntervaloFechasDTO();
            //            intervalo.FechaInicio = Convert.ToDateTime(mtxt_fechaInicio.Text);
            //            intervalo.FechaFin = Convert.ToDateTime(mtxt_fechaFin.Text);

            //            banner.FuenteRSSId = iFuenteId;
            //            banner.TextoFijo = iTextoFijo;

            //            banner.FuenteRSSId = this.iFuenteId;
            //            banner.TextoFijo = this.iTextoFijo;

            //            if (fachadaBanner.CrearBanner(banner, intervalo))
            //            {
            //                MessageBox.Show("El banner fue guardado con exito");
            //                this.Close();
            //            }

            //            else
            //            {
            //                MessageBox.Show("Error, el banner no esta disponible en los rangos de fechas y/o horarios dados");
            //            }

            //        }

            //        else
            //        {
            //            iBanner.HoraFin = TimeSpan.Parse(mtxt_horaFin.Text);
            //            iBanner.HoraInicio = TimeSpan.Parse(mtxt_horaInicio.Text);
            //            iBanner.FuenteRSSId = this.iBanner.FuenteRSSId;
            //            iBanner.TextoFijo = this.iBanner.TextoFijo;

            //            IntervaloFechasDTO intervalo = new IntervaloFechasDTO();
            //            intervalo.FechaInicio = Convert.ToDateTime(mtxt_fechaInicio.Text);
            //            intervalo.FechaFin = Convert.ToDateTime(mtxt_fechaFin.Text);
            //            if (fachadaBanner.ModificarBanner(iBanner, intervalo))
            //            {
            //                MessageBox.Show("El banner fue modificado con exito");
            //                this.Close();
            //            }
            //            else
            //            {
            //                MessageBox.Show("Error, el banner no esta disponible en los rangos de fechas y/o horarios dados");
            //            }
            //        }
            //    }

            //    else
            //    {
            //        //Aqui se entra si hay errores en los ingresos de datos. A la error string le concatenamos 
            //        //los errores segun coincidan en las condiciones de los if. 

            //        string ErrorString = "Se han detectado el (o los) siguente(s) error(es): \n";

            //        if (this.iTextoFijo == null && this.iFuenteId == null)
            //        {
            //            ErrorString = ErrorString + ("• El banner no fue configurado con ninguna fuente rss o texto fijo \n");
            //        }

            //        if (TimeSpan.Parse(mtxt_horaFin.Text) > tiempoMaximo ||
            //                TimeSpan.Parse(mtxt_horaInicio.Text) > tiempoMaximo)
            //        {
            //            ErrorString = ErrorString + ("• La hora de inicio y/o de fin estan mal ingresadas. Valores validos desde 00:00:00 hasta 23:59:59 \n");
            //        }

            //        if ((TimeSpan.Parse(mtxt_horaInicio.Text) >= TimeSpan.Parse(mtxt_horaFin.Text)))
            //        {
            //            ErrorString = ErrorString + ("• La hora de inicio no puede ser mayor o igual a la de fin \n");
            //        }

            //        if (Convert.ToDateTime(mtxt_fechaInicio.Text) >= Convert.ToDateTime(mtxt_fechaFin.Text))
            //        {
            //            ErrorString = ErrorString + ("• La fecha de inicio no puede ser mayor que la de fin \n");
            //        }

            //        MessageBox.Show(ErrorString);

            //    }


            //}

            //catch (FormatException)
            //{
            //    MessageBox.Show("Error, revise los datos ingresados");
            //}

        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {

        }        
    }
}
