using Common.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Practices.Unity;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Controladores;
using Dominio;
using Servicio_FuenteRSS;


namespace WindowsFormsApplication
{
    public partial class PantallaOperativa : Form
    {
        List<Imagen> listaImagenesVieja = new List<Imagen>();
        List<Imagen> listaImagenesNueva = new List<Imagen>();
        
        ControladorCampaña iControladorCampaña = new ControladorCampaña();
        ControladorBanner iControladorBanner = new ControladorBanner();
        ControladorFuenteBanner iControladorFuente;
        ControladorImagen iControladorImagen = new ControladorImagen();       


        public PantallaOperativa()
        {
            InitializeComponent();
        }
        
        /*
        public PantallaOperativa(ControladorCampaña pCampaña, ControladorBanner pBanner)
        {
            this.iControladorCampaña = pCampaña;
            this.iControladorBanner = pBanner;
            InitializeComponent();
        }*/

        private void PantallaOperativa_Load(object sender, EventArgs e)
        {            
            
            //Activacion de Timers
            //Control de campaña
            timerCampaña.Enabled = true;
            timerCampaña.Interval = 1000;
            //Control de RSS:
            timerImagen.Enabled = true;
            timerImagen.Interval = 1000;            
            //Control de movimiento de texto:
            timerTexto.Enabled = true;
            timerTexto.Interval = 100;
            //Control de banners
            timerBanner.Enabled = true;
            timerBanner.Interval = 1000;

            //Obtiene la lista de imagenes de la campaña correspondiente a la fecha y horario
            listaImagenesNueva = iControladorCampaña.campañaActiva().iImagenes;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();

            lbl_banner.Left -= 15;

            if (lbl_banner.Right < 0)
                lbl_banner.Left = this.Width;
        }

        private void timerImagen_Tick(object sender, EventArgs e)
        {           
            
        }

        private void timerCampaña_Tick(object sender, EventArgs e)
        {
            //Se obtiene campaña activa
            Campaña c = iControladorCampaña.campañaActiva();
            c.iImagenes = iControladorImagen.ObtenerImagenesPorId(c.iIdCampaña);
            //Si la campaña activa tiene imagenes
            if (c.iImagenes != null)
            {
                timerCampaña.Interval = (1000 * 60000);  //intervalo elegido por el usuario
                
                //Si la lista vieja no tiene mas imagenes para mostrar
                if (listaImagenesVieja.Count == 0)
                {
                    //Se obtiene la nueva lista de imagenes de la campaña activa correspondiente
                    //listaImagenesNueva = iControladorCampaña.campañaActiva().iImagenes;
                    listaImagenesNueva = c.iImagenes;
                    //Se asignan como viejas a la lista de imagenes que se utilizaran
                    listaImagenesVieja = listaImagenesNueva;
                }

                //byte[] bytes = listaImagenesVieja[0].ImagenByte;
                Imagen imgVista = listaImagenesVieja[0];

                //Image img = Utilidades.byteArrayToImage(bytes);
                
                //Se muestra la imagen que se encuentra en la ruta especificada
                pb_imagenes.Image = Image.FromFile(imgVista.iRuta);

                //Se agrega la imagen que ya se paso a la lista de nuevas
                listaImagenesNueva.Add(imgVista);
                //Se elimina la imagen que ya se paso de la lista de viejas
                listaImagenesVieja.Remove(imgVista);
                
            }
            else //Si no hay campaña activa
            {
                pb_imagenes.Image = null;
            }                                                                                         
        }

        private void timerBanner_Tick(object sender, EventArgs e)
        {
            //PARTE DE BANNER
            //Preguntar si bannerTextoActivo es null o si bannerRSSActivo es null
            /*Banner b = iControladorBanner.bannerActivo();
            if (b != null)
            {

            }
            if (b.iFuente.Tipo == "Texto" && b.fechaInicio != null) //Si la fuente es tipo texto
            {
                timerBanner.Enabled = false; //Desactiva el control de RSS
                List<Banner> eLista = new List<Banner>();
                eLista.Add(b);
                for (int i = 0; i < 1; i++)
                {
                    textBox1.Text = textBox1.Text + (eLista[0].iFuente.Texto);
                }
            }
            else //La fuente es tipo RSS
            {
                if (b.iFuente.Tipo == "RSS" && b.fechaInicio != null) //Si la campaña tiene en cambio RSS como banner:
                {
                    textBox2.Text = b.iFuente.Texto;
                }


            }*/
        }
    
        
        private void bwRssReader_DoWork(Object pSender, DoWorkEventArgs pEventArgs)
        {
            try
            {
                IRssReader mRssReader = IoCContainerLocator.Container.Resolve<IRssReader>();
                pEventArgs.Result = mRssReader.Read((Uri)pEventArgs.Argument);
            }
            catch (System.Net.WebException) { }
        }

        
        private void bwRssReader_RunWorkerCompleted(Object pSender, RunWorkerCompletedEventArgs pEventArgs)
        {
            
            List<RssItem> listaVieja = new List<RssItem>();
            //Si existe un error
            if (pEventArgs.Error != null)
            {

                MessageBox.Show(String.Format("No se han podido obtener datos de la fuente RSS: {0}", pEventArgs.Error.Message),
                                              "Ha ocurrido un error",
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Error);
            }
            else if (!pEventArgs.Cancelled)
            {
                IEnumerable<RssItem> mItems = (IEnumerable<RssItem>)pEventArgs.Result;
                if (mItems == null) //Si se quedo sin conexion muestra la ultima lista actualizada
                {
                    if (listaVieja.Count == 0)//Si nunca hubo conexion
                    { 
                        txt_banner.Text = "Sin conexion"; 
                    } 
                    else //Si hubo conexion y fue interrumpida (se muestra la ultima actualizada)
                    {
                        for (int i = 0; i < listaVieja.Count; i++)
                        {
                            txt_banner.Text = txt_banner.Text + (listaVieja[i].Title + ": " + listaVieja[i].Description + " ");

                        }
                    }
                }
                else//Si no se quedo sin conexion
                {
                    List<RssItem> lista = mItems.ToList();
                    if (lista.Count > 0)
                    {
                        {
                            //Adjuntando todas las noticias:
                            for (int i = 0; i < lista.Count; i++)
                            {
                                txt_banner.Text = txt_banner.Text + (lista[i].Title + ": " + lista[i].Description + " ");
                                //Asignando lista vieja por si se interrumpe la conexion (ultima lista actualizada)
                                listaVieja = lista;
                            }
                        }
                    }
                    else 
                    { 
                        txt_banner.Text = "0 elementos"; 
                    }
                }
                this.Cursor = Cursors.Default;
            }
        }

        private void PantallaOperativa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.timerTexto.Enabled = false;
            this.timerImagen.Enabled = false;
            this.timerCampaña.Enabled = false;
            this.timerBanner.Enabled = false;
        }

        

     
    }
}
