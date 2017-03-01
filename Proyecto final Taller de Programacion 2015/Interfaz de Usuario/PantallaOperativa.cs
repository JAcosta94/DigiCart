using System;
using Microsoft.Practices.Unity;
using Common.Logging;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;


using Controladores;
using Dominio;
//using Servicio_FuenteRSS;


namespace WindowsFormsApplication
{
    public partial class PantallaOperativa : Form
    {
        //private IList<BannerDTO> iBanners;
        //private BannerDTO iBanner;
        //private IList<CampañaDTO> iCampañas;
        //private CampañaDTO iCampaña;
        //private IList<ImagenDTO> iImagenesCampaña;
        //private IList<IntervaloFechasDTO> iFechas;
        //private int iPosicionImagen;

        //private static readonly ILog cLogger = LogManager.GetLogger<PantallaOperativa>();


        public PantallaOperativa()
        {
            InitializeComponent();
        }

        private void PantallaOperativa_Load(object sender, EventArgs e)
        {
            //FachadaCampaña fachadaCampaña = new FachadaCampaña();
            //FachadaIntervaloFechas fachadaFechas = new FachadaIntervaloFechas();
            //FachadaBanner fachadaBanner = new FachadaBanner();
            //this.iFechas = fachadaFechas.ObtenerIntervalos();                       
            //this.iCampañas = fachadaCampaña.ObtenerCampanias();
            //this.iBanners = fachadaBanner.ObtenerBanners();

            //Thread hiloBanner = new Thread(new ThreadStart(timerBanner.Start));
            //Thread hiloCampaña = new Thread(new ThreadStart(timerCampaña.Start));
        
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
            //ImagenDTO imagenActual = iImagenesCampaña[this.iPosicionImagen];
            //timerImagen.Interval = Convert.ToInt32(imagenActual.Duracion.TotalSeconds) * 1000; 
            //pb_imagenes.ImageLocation = @imagenActual.RutaImagen;
            //pb_imagenes.Refresh();
            //pb_imagenes.SizeMode = PictureBoxSizeMode.CenterImage;
            //pb_imagenes.SizeMode = PictureBoxSizeMode.StretchImage;
            //this.iPosicionImagen++; 

            ////Si la posicion de imagen llega a la ultima, la reiniciamos para que vuelva a mostrar las otras.
            //if  (this.iPosicionImagen == (this.iImagenesCampaña.Count))
            //{ 
            //    this.iPosicionImagen = 0; 
            //}                                    
            
        }

        private void timerCampaña_Tick(object sender, EventArgs e)
        {
           //this.iImagenesCampaña = null;
           //this.timerImagen.Enabled = false;
           
           //var joinQuery = from Campaña in this.iCampañas
           //                 join IntervaloFecha in this.iFechas on Campaña.IntervaloFechaId equals IntervaloFecha.Id
           //                 orderby IntervaloFecha.FechaInicio ascending
           //                 select new
           //                 {
           //                     FechaInicio = IntervaloFecha.FechaInicio,
           //                     FechaFin = IntervaloFecha.FechaFin,
           //                     IdIntervalo = IntervaloFecha.Id,
           //                     IdCampaña = Campaña.Id,
           //                     HoraInicio = Campaña.HoraInicio,
           //                     HoraFin = Campaña.HoraFin
           //                 };
            
           // TimeSpan ahora = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

           // foreach (var campaña in joinQuery)
           // {       
           //     //Vemos si hay alguna campaña que contenga al dia de hoy dentro de su rango de fechas
           //     if (campaña.FechaInicio <= DateTime.Now.Date && DateTime.Now.Date <= campaña.FechaFin)
           //     {
                    
           //         if (campaña.HoraInicio <= ahora && ahora < campaña.HoraFin)
           //         {
           //             //Si la campaña contiene al momento actual dentro del rango horario 
           //             //entonces esta sera la campaña que se mostrara en la pantalla operativa por lo que quede
           //             //de tiempo de la misma
           //             this.iCampaña = new CampañaDTO();
           //             this.iCampaña.HoraInicio = campaña.HoraInicio;
           //             this.iCampaña.HoraFin = campaña.HoraFin;
           //             this.iCampaña.Id = campaña.IdCampaña;
           //             this.iCampaña.IntervaloFechaId = campaña.IdIntervalo;
           //         }
           //     }            
           // }

           // //Si no se encontro una campaña que tenga al momento actual entre sus rangos de fecha y horario
           // //buscamos si hay alguna campaña que este proxima en lo que queda del dia.
           // if (this.iCampaña == null)
           // {
           //     foreach (var campaña in joinQuery)
           //     {
           //         if (campaña.FechaInicio <= DateTime.Now.Date && DateTime.Now.Date <= campaña.FechaFin)
           //         {
           //             //Esta es una primera asignacion para poder encontrar al minimo ya que vamos recorriendo la lista
           //             if (this.iCampaña == null && ahora <= campaña.HoraInicio)
           //             {
           //                 this.iCampaña = new CampañaDTO();
           //                 this.iCampaña.HoraInicio = campaña.HoraInicio;
           //                 this.iCampaña.HoraFin = campaña.HoraFin;
           //                 this.iCampaña.Id = campaña.IdCampaña;
           //                 this.iCampaña.Id = campaña.IdCampaña;
           //                 this.iCampaña.IntervaloFechaId = campaña.IdIntervalo;
           //             }

           //             else
           //             {
           //                 if (this.iCampaña != null &&
           //                     this.iCampaña.HoraInicio > ahora &&
           //                       campaña.HoraInicio <= this.iCampaña.HoraInicio)
           //                 {
           //                     this.iCampaña.HoraInicio = campaña.HoraInicio;
           //                     this.iCampaña.HoraFin = campaña.HoraFin;
           //                     this.iCampaña.Id = campaña.IdCampaña;
           //                     this.iCampaña.IntervaloFechaId = campaña.IdIntervalo;
           //                 }

           //             }
           //         }
           //     }
           // }
    
           // TimeSpan tiempoEspera;

           // if (this.iCampaña!= null &&
           //         this.iCampaña.HoraInicio > ahora && 
           //             this.iCampaña.HoraFin > ahora)
           // {
           //     //Calculamos el tiempo de espera para la proxima campaña del dia
           //     //si la campaña no tiene un rango horario en el que entre la hora actual.
           //     tiempoEspera = this.iCampaña.HoraInicio.Subtract(ahora);
           //     this.timerCampaña.Interval = (Convert.ToInt32(tiempoEspera.TotalSeconds) * 1000)+1;
           //     this.pb_imagenes.ImageLocation = null;
           //     this.iCampaña = null;
           // }

           // else
           // {
           //     if (this.iCampaña != null &&
           //             this.iCampaña.HoraInicio <= ahora &&
           //                 this.iCampaña.HoraFin >= ahora)
           //     {
           //         //Calculamos el tiempo en el que se ejecutara la campaña 
           //         //si esta se encuentra dentro de los rangos horarios
           //         tiempoEspera = this.iCampaña.HoraFin.Subtract(ahora);
           //         this.timerCampaña.Interval = (Convert.ToInt32(tiempoEspera.TotalSeconds) * 1000)+1;
           //         this.iPosicionImagen = 0;
           //         this.pb_imagenes.ImageLocation = null;
           //         this.timerImagen.Enabled = true;
           //         this.iImagenesCampaña = (new FachadaImagen().ObtenerImagenesDe(this.iCampaña));


           //         this.iImagenesCampaña = this.iImagenesCampaña.OrderBy(imagen => imagen.Posicion ).ToList();
           //         this.iCampaña = null;
           //     }

           //     else
           //     {
           //         TimeSpan finDelDia = new TimeSpan(23, 59, 59);

           //         if (joinQuery.FirstOrDefault(campaña => campaña.FechaInicio.Date <= DateTime.Now.Date && DateTime.Now.Date < campaña.FechaFin) != null)
           //         {
           //             //Buscamos a ver si no hay una campaña que contenga todavia al dia de mañana
           //             //para ajustar el intervalo del timer entre la diferencia de ahora y el fin del dia, es decir,
           //             //lo que falta para que termine el dia.

           //             //revisarme
           //             tiempoEspera = finDelDia.Subtract(ahora);
           //             this.iCampaña = null;
           //             this.pb_imagenes.ImageLocation = null;
           //             this.timerCampaña.Interval = Convert.ToInt32(tiempoEspera.TotalSeconds)*1000;
           //         }


           //         else
           //         {

           //             if (joinQuery.FirstOrDefault(campaña => campaña.FechaInicio.Date > DateTime.Now.Date) != null)
           //             {
           //                 //Si no hay una campaña que tenga al dia actual entre su rango de fechas
           //                 //buscamos la campaña que contenga el dia de inicio mas proximo     
           //                 tiempoEspera = joinQuery.FirstOrDefault
           //                      (campaña => campaña.FechaInicio.Date > DateTime.Now.Date).FechaInicio.Subtract(DateTime.Now);


           //                 tiempoEspera = tiempoEspera.Add(finDelDia.Subtract(ahora));
           //                 this.iCampaña = null;
           //                 this.pb_imagenes.ImageLocation = null;
           //                 this.timerCampaña.Interval = Convert.ToInt32(tiempoEspera.TotalSeconds)*1000;
           //             }

           //             else
           //             {
           //                 //Si no se encontro ninguna campaña, es porque no hay mas. Entonces apagamos el timer para ahorrar
           //                 //recursos.
           //                 this.timerBanner.Enabled = false;
           //             }
           //         }
                    
           //     }

           // }
                                                                                         
        }

        private void timerBanner_Tick(object sender, EventArgs e)
        {
            //this.lbl_fuenteRSS.Enabled = false;
            //this.lbl_fuenteRSS.Text = "";

            //var joinQuery = from Banner in this.iBanners
            //                join IntervaloFecha in this.iFechas on Banner.IntervaloFechaId equals IntervaloFecha.Id
            //                orderby IntervaloFecha.FechaInicio ascending
            //                select new
            //                {
            //                    FechaInicio = IntervaloFecha.FechaInicio,
            //                    FechaFin = IntervaloFecha.FechaFin,
            //                    IdIntervalo = IntervaloFecha.Id,
            //                    IdBanner = Banner.Id,
            //                    HoraInicio = Banner.HoraInicio,
            //                    HoraFin = Banner.HoraFin,
            //                    TextoFijo = Banner.TextoFijo,
            //                    IdFuenteRSS = Banner.FuenteRSSId
            //                };

            //TimeSpan ahora = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

            //foreach (var banner in joinQuery)
            //{
            //    if (banner.FechaInicio <= DateTime.Now.Date && DateTime.Now.Date <= banner.FechaFin)
            //    {

            //        if (banner.HoraInicio <= ahora && ahora < banner.HoraFin)
            //        {
            //            //Buscamos el banner que tenga la hora de inicio mas proxima a la actual.
            //            this.iBanner = new BannerDTO();
            //            this.iBanner.HoraInicio = banner.HoraInicio;
            //            this.iBanner.HoraFin = banner.HoraFin;
            //            this.iBanner.Id = banner.IdBanner;
            //            this.iBanner.IntervaloFechaId = banner.IdIntervalo;
            //            this.iBanner.FuenteRSSId = banner.IdFuenteRSS;
            //            this.iBanner.TextoFijo = banner.TextoFijo;
            //            break;
            //        }
            //    }
            //}

            //TimeSpan tiempoEspera = new TimeSpan();

            //if (this.iBanner == null)
            //{
            //    //Si no hay un banner en el que la hora actual se encuentre en el rango horario del banner
            //    //buscamos si es que hay algun banner que tenga un rango de fechas en el que entre la del dia de la fecha
            //    //y que tenga la hora de inicio mas proximo a la hora actual. Y ajustamos el 
            //    //intervalo del timerBanner para que la proxima vez que haga un tick sea en el momento de
            //    //que inicie el banner.
            //    foreach (var banner in joinQuery)
            //    {
            //        if (banner.FechaInicio <= DateTime.Now && DateTime.Now <= banner.FechaFin)
            //        {

            //            if (this.iBanner == null && ahora <= banner.HoraInicio)
            //            {
            //                this.iBanner = new BannerDTO();
            //                this.iBanner.HoraInicio = banner.HoraInicio;
            //                this.iBanner.HoraFin = banner.HoraFin;
            //                this.iBanner.Id = banner.IdBanner;
            //                this.iBanner.IntervaloFechaId = banner.IdIntervalo;
            //                this.iBanner.FuenteRSSId = banner.IdFuenteRSS;
            //                this.iBanner.TextoFijo = banner.TextoFijo;
            //            }

            //            else
            //            {
            //                if (iBanner!= null && 
            //                    this.iBanner.HoraInicio > ahora &&
            //                      banner.HoraInicio <= this.iBanner.HoraInicio)
            //                {
            //                    this.iBanner.HoraInicio = banner.HoraInicio;
            //                    this.iBanner.HoraFin = banner.HoraFin;
            //                    this.iBanner.Id = banner.IdBanner;
            //                    this.iBanner.IntervaloFechaId = banner.IdIntervalo;
            //                    this.iBanner.FuenteRSSId = banner.IdFuenteRSS;
            //                    this.iBanner.TextoFijo = banner.TextoFijo;

            //                }

            //            }
            //        }
            //    }


            //    if (this.iBanner != null && this.iBanner.HoraInicio > ahora && this.iBanner.HoraFin > ahora)
            //    {
            //        tiempoEspera = this.iBanner.HoraInicio.Subtract(ahora);
            //        this.timerBanner.Interval = Convert.ToInt32(tiempoEspera.TotalSeconds * 1000);
            //        this.lbl_banner.Text = "NO HAY BANNERS DISPONIBLES POR EL MOMENTO";
            //        this.lbl_banner.Refresh();
            //    }

            //    else
            //    {
            //        TimeSpan finDelDia = new TimeSpan(23, 59, 59);
                    

            //        if (joinQuery.FirstOrDefault(banner => banner.FechaInicio.Date <= DateTime.Now.Date && DateTime.Now.Date < banner.FechaFin.Date) != null)
            //        {
            //            //Si no hay mas banners en el dia, pero si hay al dia siguiente ajustamos el intervalo del timer para que vuelva a hacer un tick al dia
            //            //siguiente.
            //            tiempoEspera = finDelDia.Subtract(ahora);
            //            this.timerBanner.Interval = Convert.ToInt32(tiempoEspera.TotalSeconds)*1000;
            //        }

            //        else
            //        {
            //            if (joinQuery.FirstOrDefault(banner => banner.FechaInicio.Date > DateTime.Now.Date) != null)
            //            {    
            //                //Si no hay banners al dia siguiente y hay alguno dentro de varios dias, ajustamos el timer para que 
            //                //haga un tick despues de todos los dias q tienen que pasar para que se ejecute el banner
            //                 tiempoEspera =joinQuery.FirstOrDefault
            //                     (banner => banner.FechaInicio.Date > DateTime.Now.Date).FechaInicio.Subtract(DateTime.Now);


            //                tiempoEspera = tiempoEspera.Add(finDelDia.Subtract(ahora));
            //                this.timerBanner.Interval = Convert.ToInt32(tiempoEspera.TotalSeconds)*1000;
            //            }

            //            else
            //            {
            //                //Si no hay mas banners, apagamos el timer para ahorrar recursos.
            //                this.timerBanner.Enabled = false;
            //            }

            //        }
            //        this.lbl_banner.Text = "NO HAY BANNERS DISPONIBLES POR EL MOMENTO";
            //        this.lbl_banner.Refresh();
            //    }

                    
            //}

            //else
            //{
            //    //Si encontramos un banner en el que la hora actual este en un rango horario de algun banner
            //    //Ajustamos el label del banner para ver la informacion dependiendo del tipo de banner
            //    //que sea con el que estemos trabajando

            //    tiempoEspera = this.iBanner.HoraFin.Subtract(ahora);
            //    timerBanner.Interval = Convert.ToInt32(tiempoEspera.TotalSeconds) * 1000;

            //    if (this.iBanner.TextoFijo != null)
            //    {
            //        this.lbl_banner.Text = this.iBanner.TextoFijo;
            //    }

            //    else
            //    {
            //        //Si es una fuente rss convertimos el string donde esta la url en URL.
            //        FachadaFuenteRSS fachadaFuenteRSS = new FachadaFuenteRSS();
            //        FuenteRSSDTO FuenteRSS = fachadaFuenteRSS.ObtenerFuentesRSS().FirstOrDefault(fuente => fuente.Id == iBanner.FuenteRSSId);

            //        string urlFuente = FuenteRSS.Url;
            //        string descripcion = FuenteRSS.Descripcion;

            //        this.lbl_fuenteRSS.Text = descripcion;
            //        this.lbl_fuenteRSS.Enabled = true;
            //        this.lbl_fuenteRSS.Refresh();

            //        try
            //        {
            //            if (!this.bwRssReader.IsBusy)
            //            {
            //                Uri mUrl;

            //                if (!Uri.TryCreate(urlFuente.Trim(), UriKind.Absolute, out mUrl))
            //                {
            //                    throw new ArgumentException("La URL que se ingreso no es válida.");
            //                }
                            
            //                this.Cursor = Cursors.WaitCursor;                            
            //                this.bwRssReader.RunWorkerAsync(mUrl);
            //            }
            //        }

            //        catch (Exception bEx)
            //        {
            //            cLogger.Error("Se ha producido un error al intentar actualizar los feeds.", bEx);
            //            //MessageBox.Show(bEx.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            lbl_banner.Text = "LA FUENTE RSS CONFIGURADA NO ES VALIDA";
            //            lbl_banner.Refresh();
            //        }

            //    }
             
            //    //Ajustamos el timerBanner para que el banner se deje de mostrar cuando llegue la hora
            //    //de fin del rango horario del banner.
            //    this.iBanner = null;
                    

            //}
               

        }
    
        
        private void bwRssReader_DoWork(Object pSender, DoWorkEventArgs pEventArgs)
        {
            //cLogger.Info("Resolviendo instancia de IRssReader...");
            //IRssReader mRssReader = IoCContainerLocator.Container.Resolve<IRssReader>();

            //cLogger.Info("Obteniendo feeds...");
            //pEventArgs.Result = mRssReader.Read((Uri)pEventArgs.Argument);
        }

        private void bwRssReader_RunWorkerCompleted(Object pSender, RunWorkerCompletedEventArgs pEventArgs)
        {
            //if (pEventArgs.Error != null)
            //{
            //    cLogger.Error("La obtención de feeds ha fallado.", pEventArgs.Error);

            //    MessageBox.Show(String.Format("No se han podido obtener datos de la fuente RSS: {0}", pEventArgs.Error.Message),
            //                                  "Ha ocurrido un error",
            //                                  MessageBoxButtons.OK,
            //                                  MessageBoxIcon.Error);
            //}

            //else if (!pEventArgs.Cancelled)
            //{
            //    cLogger.Info("La obtención de feeds ha finalizado exitosamente.");    
            //    IEnumerable<RssItem> mItems = (IEnumerable<RssItem>)pEventArgs.Result;
            //    this.lbl_banner.Text = "";
            //    this.lbl_banner.Refresh();

            //    if (mItems != null)
            //    {
            //        foreach (RssItem itemRss in mItems)
            //        {
            //            this.lbl_banner.Text = this.lbl_banner.Text + itemRss.Title + " - ";
            //        }

                    

            //        //fachadaFuentes.ActualizarUltimaObtencionDeFeeds()

            //        cLogger.Debug(pLogger => pLogger("Se ha(n) obtenido {0} feeds.", mItems.Count()));
                  
            //    }

            //    else
            //    {
                    


            //    }
            //}
       
            //cLogger.Info("Volviendo cursor a la normalidad...");
            //this.Cursor = Cursors.Default;
            
        }

        private void PantallaOperativa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.timer1.Enabled = false;
            this.timerImagen.Enabled = false;
            this.timerCampaña.Enabled = false;
            this.timerBanner.Enabled = false;
        }

        

     
    }
}
