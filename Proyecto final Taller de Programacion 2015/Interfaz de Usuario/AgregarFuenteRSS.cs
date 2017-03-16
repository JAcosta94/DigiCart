using System;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Logging;
using Servicio_FuenteRSS;
using Controladores;
using Dominio;


namespace WindowsFormsApplication
{
    public partial class AgregarFuenteRSS : Form
    {
        private FuenteRSS iFuente;
       // private static readonly ILog cLogger = LogManager.GetLogger<AgregarFuenteRSS>();

        public AgregarFuenteRSS()
        {
            InitializeComponent();
        }

        //public AgregarFuenteRSS(FuenteRSS pFuente)
        //{
        //    this.iFuente = pFuente;
        //    InitializeComponent();        
        //}

        private void AgregarFuenteRSS_Load(object sender, EventArgs e)
        {
            //if (iFuente != null)
            //{
            //    txt_nombreFuente.Text = iFuente.Descripcion;
            //    txt_url.Text = iFuente.Url;
            //    btn_guardarFuente.Text = "Actualizar Fuente";
            //    btn_guardarFuente.Refresh();
            //    this.Text = "Modificar Fuente RSS";
            //}

            //else
            //{
            //    btn_guardarFuente.Name = "Guardar Fuente";
            //    btn_guardarFuente.Refresh();
            //}

        }
       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardarFuente_Click(object sender, EventArgs e)
        {

            try
            {
                if (!this.bwRssReader.IsBusy)
                {
                    Uri mUrl;

                    if (!string.IsNullOrWhiteSpace(txt_nombreFuente.Text) && !string.IsNullOrWhiteSpace(txt_url.Text))
                    {
                        FuenteRSS fuente = new FuenteRSS
                        {
                            iDescripcion = txt_nombreFuente.Text,
                            iUrl = txt_url.Text
                        };  


                        ControladorFuenteBanner fachada = new ControladorFuenteBanner();

                        if (btn_guardarFuente.Text == "Guardar Fuente")
                        {
                            if (!Uri.TryCreate(fuente.iUrl.Trim(), UriKind.Absolute, out mUrl))
                            {
                                throw new ArgumentException("La URL que se ingreso no es válida.");
                            }

                            //    cLogger.Info("Cambiando a cursor de espera...");
                            this.Cursor = Cursors.WaitCursor;

                            //   cLogger.Info("Iniciando operación en worker thread...");
                            this.bwRssReader.RunWorkerAsync(mUrl);

                            fachada.AgregarFuenteRSS(fuente);
                            MessageBox.Show("Fuente RSS guardada con exito!");
                        }

                        else
                        {

                            if (!Uri.TryCreate(txt_nombreFuente.Text.Trim(), UriKind.Absolute, out mUrl))
                            {
                                throw new ArgumentException("La URL que se ingreso no es válida.");
                            }

                            //    cLogger.Info("Cambiando a cursor de espera...");
                            this.Cursor = Cursors.WaitCursor;

                            //   cLogger.Info("Iniciando operación en worker thread...");
                            this.bwRssReader.RunWorkerAsync(mUrl);

                            iFuente.iDescripcion = txt_nombreFuente.Text;
                            iFuente.iUrl = txt_url.Text;
                            fachada.ModificarFuenteRSS(iFuente);
                            MessageBox.Show("Fuente RSS modificada con exito!");
                            this.Close();
                        }

                        txt_nombreFuente.Text = "";
                        txt_nombreFuente.Refresh();
                        txt_url.Text = "";
                        txt_url.Refresh();
                    }

                    else
                    { MessageBox.Show("Complete los campos faltantes"); }



                }
            }

            catch (Exception bEx)
            {
               // cLogger.Error("Se ha producido un error al intentar actualizar los feeds.", bEx);
                MessageBox.Show(bEx.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
            

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bwRssReader_DoWork(Object pSender, DoWorkEventArgs pEventArgs)
        {
            //cLogger.Info("Resolviendo instancia de IRssReader...");
           // IoCContainerLocator.Container.RegisterType<IRssReader, RssReader>();    
            IRssReader reRssReader = IoCContainerLocator.Container.Resolve<IRssReader>();

           // cLogger.Info("Obteniendo feeds...");
            
            
            pEventArgs.Result = reRssReader.Read((Uri)pEventArgs.Argument);
        }

        private void bwRssReader_RunWorkerCompleted(Object pSender, RunWorkerCompletedEventArgs pEventArgs)
        {
            if (pEventArgs.Error != null)
            {                
                MessageBox.Show(String.Format("No se han podido crear la fuente RSS: {0}", pEventArgs.Error.Message),
                                              "Ha ocurrido un error",
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Error);
            }

            else if (!pEventArgs.Cancelled)
            {                                
                MessageBox.Show("La fuente rss fue creada con exito");                
            }            
            this.Cursor = Cursors.Default;
        }

        private void btn_vistaPrevia_Click(object sender, EventArgs e)
        {
            string urlFuente = txt_url.Text;
            timer1.Enabled = true;
            this.lbl_vistaPrevia.Enabled = true;
            this.lbl_vistaPrevia.Refresh();

            try
            {
                if (!this.bwRssReaderPrueba.IsBusy)
                {
                    Uri mUrl;

                    if (!Uri.TryCreate(urlFuente.Trim(), UriKind.Absolute, out mUrl))
                    {
                        throw new ArgumentException("La URL que se ingreso no es válida.");
                    }

                    this.Cursor = Cursors.WaitCursor;
                    this.bwRssReaderPrueba.RunWorkerAsync(mUrl);
                }
            }

            catch (Exception bEx)
            {
                //cLogger.Error("Se ha producido un error al intentar actualizar los feeds.", bEx);
                MessageBox.Show(bEx.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl_vistaPrevia.Text = "LA FUENTE RSS CONFIGURADA NO ES VALIDA";
                lbl_vistaPrevia.Refresh();
            }
        }

        private void bwRssReaderPrueba_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs pEventArgs)
        {
            if (pEventArgs.Error != null)
            {
               // cLogger.Error("La obtención de feeds ha fallado.", pEventArgs.Error);

                MessageBox.Show(String.Format("No se han podido obtener datos de la fuente RSS: {0}", pEventArgs.Error.Message),
                                              "Ha ocurrido un error",
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Error);
            }

            else if (!pEventArgs.Cancelled)
            {
                //cLogger.Info("La obtención de feeds ha finalizado exitosamente.");
                IEnumerable<RssItem> mItems = (IEnumerable<RssItem>)pEventArgs.Result;
                this.lbl_vistaPrevia.Text = "";
                this.lbl_vistaPrevia.Refresh();

                if (mItems != null)
                {
                    foreach (RssItem itemRss in mItems)
                    {
                        this.lbl_vistaPrevia.Text = this.lbl_vistaPrevia.Text + itemRss.Title + " - ";
                    }



                    //fachadaFuentes.ActualizarUltimaObtencionDeFeeds()

                    //cLogger.Debug(pLogger => pLogger("Se ha(n) obtenido {0} feeds.", mItems.Count()));

                }

                else
                {



                }
            }

            this.lbl_vistaPrevia.Refresh();
            this.lbl_vistaPrevia.Visible = true;
            //cLogger.Info("Volviendo cursor a la normalidad...");
            this.Cursor = Cursors.Default;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           this.Refresh();

            lbl_vistaPrevia.Left -= 15;

            if (lbl_vistaPrevia.Right < 0)
                lbl_vistaPrevia.Left = this.Width;
        
        }

        private void bwRssReaderPrueba_DoWork(object sender, DoWorkEventArgs pEventArgs)
        {
                      // IoCContainerLocator.Container.RegisterType<IRssReader, RssReader>();    
            IRssReader reRssReader = IoCContainerLocator.Container.Resolve<IRssReader>();

           // cLogger.Info("Obteniendo feeds...");
            
            
            pEventArgs.Result = reRssReader.Read((Uri)pEventArgs.Argument);
        }

     



    }
}
