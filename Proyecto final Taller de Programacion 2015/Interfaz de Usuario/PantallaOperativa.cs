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
        //Listas utilizadas para mostrar las imagenes de la campaña correspondiente
        List<Imagen> listaImagenesVieja = new List<Imagen>();
        List<Imagen> listaImagenesNueva = new List<Imagen>();
        
        ControladorCampaña iControladorCampaña = new ControladorCampaña();
        ControladorBanner iControladorBanner = new ControladorBanner();
        ControladorFuenteBanner iControladorFuente = new ControladorFuenteBanner();
        ControladorImagen iControladorImagen = new ControladorImagen();       


        public PantallaOperativa()
        {
            InitializeComponent();
        }        

        private void PantallaOperativa_Load(object sender, EventArgs e)
        {
            //Label utilizado para el texto deslizante del banner
            label1.Text = string.Empty;
            
            //Activacion de Timers           
            //Actualizacion de campaña
            timerCampaña.Enabled = true;
            timerCampaña.Interval = 2000;
            
            //Actualización de banners
            timerBanner.Enabled = true;
            timerBanner.Interval = 2000;                        
            
            //Control de movimiento de texto:
            timerTexto.Enabled = true;
            timerTexto.Interval = 100;                      
        }

        private void timer1_Tick(object sender, EventArgs e)
        {           
           //Movimiento de texto de banner
            this.label1.Left -= 3;
            if (this.label1.Left + this.label1.Width < this.Left)
            {
                this.label1.Left = this.Width + this.Location.X;
            }
        }

        private void timerImagen_Tick(object sender, EventArgs e)
        {           
            
        }

        /// <summary>
        /// Timer que consulta con cada tick la campaña y las imagenes correspondientes a mostrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCampaña_Tick(object sender, EventArgs e)
        {
            //Se obtiene campaña activa para la fecha y horario actual
            Campaña c = iControladorCampaña.campañaActiva();                       
            
            //Si la campaña activa tiene imagenes
            if ((c.iImagenes = iControladorImagen.ObtenerImagenesPorId(c.iIdCampaña)) != null)
            {
                //Se ordenan las imagenes segun la posicion configurada por el usuario
                c.iImagenes = c.iImagenes.OrderBy(o => o.iPosicion).ToList<Imagen>();
               
                //Si la lista vieja no tiene imagenes para mostrar
                if (listaImagenesVieja.Count == 0)
                {
                    //Se obtiene la nueva lista de imagenes de la campaña activa 
                    listaImagenesNueva = c.iImagenes;
                    //Se asignan como viejas a la lista de imagenes que se utilizaran
                    listaImagenesVieja = listaImagenesNueva;
                }

                //La imagen a mostrar sera la primera en la listaImagenesVieja
                Imagen imgVista = listaImagenesVieja[0];
                
                //Asignamos como intervalo del timer 
                //la duracion de la proxima imagen a mostrar.
                timerCampaña.Interval = Convert.ToInt32(imgVista.iDuracion.TotalMilliseconds);
     
                //Se muestra la imagen segun la ruta especificada
                pb_imagenes.Image = Image.FromFile(imgVista.iRuta);

                //Se agrega la imagen que ya se paso a la lista de nuevas
                listaImagenesNueva.Add(imgVista);
                
                //Se elimina la imagen que ya se paso de la lista de viejas
                //quedando primera la proxima imagen a pasar, o quedando vacia la lista
                listaImagenesVieja.Remove(imgVista);
                
            }
            else //Si la campaña activa es nula y no hay imagenes para mostrar
            {
                pb_imagenes.Image = null;
            }                                                                                         
        }

        /// <summary>
        /// Timer que consulta con cada tick el banner y su fuente a mostrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerBanner_Tick(object sender, EventArgs e)
        {
            //Se obtiene el banner activo para la fecha y horario actual
            Banner bActivo = iControladorBanner.bannerActivo();
            
            //Si existe un banner activo y no es nulo 
            if (bActivo != null)
            {
                //Si el banner posee una FuenteRSS para mostrar
                if (bActivo is BannerFuenteRSS)
                {                                                           
                    //Se obtiene el URL de la FuenteRSS
                    string url = iControladorFuente.ObtenerFuenteRSS((bActivo as BannerFuenteRSS).iIdFuenteRSS).iUrl;
                    
                    //Se comprueba que el servicio no este ocupado
                    if (!this.bwRssReader.IsBusy)
                    {
                        Uri mUrl;
                        
                        //Se comprueba que la URL sea valida
                        if (!Uri.TryCreate(url.Trim(), UriKind.Absolute, out mUrl))
                        {
                            label1.Text = "URL no valida";
                        }

                        this.bwRssReader.RunWorkerAsync(mUrl);
                    }
                }
                else//Si el banner posee una FuenteTextoFijo para mostrar
                {                                        
                   //Se utiliza una lista auxiliar para la muestra repetida del texto deslizante
                    List<BannerFuenteTextoFijo> listaTextoFijo = new List<BannerFuenteTextoFijo>();
                    listaTextoFijo.Add(bActivo as BannerFuenteTextoFijo);
                    
                    //Se va concatenando la cadena ingresada de texto
                    //a medida que el texto se desliza, para que no se deje de mostrar
                    label1.Text = label1.Text + (listaTextoFijo[0].TextoFijo) + "       ";
                } 
            }
            else//Si el banner activo es nulo y no hay nada para mostrar
            {
                label1.Text = String.Empty;
            }            
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
                        label1.Text = "Sin conexion"; 
                    } 
                    else //Si hubo conexion y fue interrumpida (se muestra la ultima actualizada)
                    {
                        for (int i = 0; i < listaVieja.Count; i++)
                        {
                            label1.Text = label1.Text + (listaVieja[i].Title + ": " + listaVieja[i].Description + " ");
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
                                //Se adjunta al texto deslizante el titulo de la noticia y su descripcion
                                label1.Text = label1.Text + (lista[i].Title + ": " + lista[i].Description + "   ");
                                
                                //Asignando lista vieja por si se interrumpe la conexion (ultima lista actualizada)
                                listaVieja = lista;
                            }
                        }
                    }
                    else 
                    {
                        label1.Text = "0 elementos"; 
                    }
                }
                this.Cursor = Cursors.Default;
            }
        }

        private void PantallaOperativa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.timerTexto.Enabled = false;            
            this.timerCampaña.Enabled = false;
            this.timerBanner.Enabled = false;
        }


    }
}
