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
using Dominio;
using Controladores;
using Common.Logging;
//using Servicio_FuenteRSS;


namespace WindowsFormsApplication
{
    public partial class AgregarFuenteRSS : Form
    {
        private FuenteRSS iFuente;
        private static readonly ILog cLogger = LogManager.GetLogger<AgregarFuenteRSS>();

        public AgregarFuenteRSS()
        {
            InitializeComponent();
        }

        public AgregarFuenteRSS(FuenteRSSDTO pFuente)
        {
            this.iFuente = pFuente;
            InitializeComponent();        
        }

        private void AgregarFuenteRSS_Load(object sender, EventArgs e)
        {
            if (iFuente != null)
            {
                txt_nombreFuente.Text = iFuente.Descripcion;
                txt_url.Text = iFuente.Url;
                btn_guardarFuente.Text = "Actualizar Fuente";
                btn_guardarFuente.Refresh();
                this.Text = "Modificar Fuente RSS";
            }

            else
            {
                btn_guardarFuente.Name = "Guardar Fuente";
                btn_guardarFuente.Refresh();
            }

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
                        FuenteRSSDTO fuente = new FuenteRSSDTO();
                        fuente.Descripcion = txt_nombreFuente.Text;
                        fuente.Url = txt_url.Text;


                        FachadaFuenteRSS fachada = new FachadaFuenteRSS();

                        if (btn_guardarFuente.Name == "Guardar Fuente")
                        {
                            if (!Uri.TryCreate(fuente.Url.Trim(), UriKind.Absolute, out mUrl))
                            {
                                throw new ArgumentException("La URL que se ingreso no es válida.");
                            }

                            //    cLogger.Info("Cambiando a cursor de espera...");
                            this.Cursor = Cursors.WaitCursor;

                            //   cLogger.Info("Iniciando operación en worker thread...");
                            this.bwRssReader.RunWorkerAsync(mUrl);
                            
                            fachada.CrearFuenteRSS(fuente);
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
                            
                            iFuente.Descripcion = txt_nombreFuente.Text;
                            iFuente.Url = txt_url.Text;
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
                cLogger.Error("Se ha producido un error al intentar actualizar los feeds.", bEx);
                MessageBox.Show(bEx.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
            

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bwRssReader_DoWork(Object pSender, DoWorkEventArgs pEventArgs)
        {
            cLogger.Info("Resolviendo instancia de IRssReader...");
            IRssReader mRssReader = IoCContainerLocator.Container.Resolve<IRssReader>();

            cLogger.Info("Obteniendo feeds...");
            pEventArgs.Result = mRssReader.Read((Uri)pEventArgs.Argument);
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

    }
}
