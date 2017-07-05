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
        private bool vistaPrevia = false;       

        public AgregarFuenteRSS()
        {
            InitializeComponent();
        }

        public AgregarFuenteRSS(FuenteRSS pFuente)
        {
            this.iFuente = pFuente;
            InitializeComponent();        
        }

        private void AgregarFuenteRSS_Load(object sender, EventArgs e)
        {
            //MODIFICAR fuente
            if (iFuente != null)
            {
                txt_nombreFuente.Text = iFuente.iDescripcion;
                txt_url.Text = iFuente.iUrl;
                btn_guardarFuente.Text = "Actualizar";
                btn_guardarFuente.Refresh();
                this.Text = "Modificar Fuente RSS";
            }

            else//AGREGAR fuente
            {
                btn_guardarFuente.Name = "Agregar Fuente RSS";
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
                vistaPrevia = false;
                if (!this.bwRssReader.IsBusy)
                {
                    Uri mUrl;

                    if (!string.IsNullOrWhiteSpace(txt_nombreFuente.Text) && !string.IsNullOrWhiteSpace(txt_url.Text))
                    {
                        FuenteRSS fuente = new FuenteRSS
                        {
                            iDescripcion = txt_nombreFuente.Text,
                            iUrl = txt_url.Text,                            
                        };  

                        ControladorFuenteBanner fachada = new ControladorFuenteBanner();

                        //NUEVA FuenteRSS
                        if (btn_guardarFuente.Text == "Guardar ")
                        {
                            if (!Uri.TryCreate(fuente.iUrl.Trim(), UriKind.Absolute, out mUrl))
                            {
                                throw new ArgumentException("La URL que se ingreso no es válida.");
                            }                            
                            
                            this.Cursor = Cursors.WaitCursor;                            
                            this.bwRssReader.RunWorkerAsync(mUrl);

                            fachada.AgregarFuenteRSS(fuente);
                            MessageBox.Show("Fuente RSS guardada con exito!");
                            lbl_vistaPrevia.Text = string.Empty;
                            lbl_vistaPrevia.Visible = false;
                        }

                        else//MODIFICAR FuenteRSS
                        {

                            if (!Uri.TryCreate(txt_url.Text.Trim(), UriKind.Absolute, out mUrl))
                            {
                                throw new ArgumentException("La URL que se ingreso no es válida.");
                            }
                            
                            this.Cursor = Cursors.WaitCursor;
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
                    { 
                        MessageBox.Show("Complete los campos faltantes"); 
                    }
                }
            }

            catch (Exception bEx)
            {               
                MessageBox.Show(bEx.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                       
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bwRssReader_DoWork(Object pSender, DoWorkEventArgs pEventArgs)
        {  
            IRssReader reRssReader = IoCContainerLocator.Container.Resolve<IRssReader>();                      
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
                
                if (vistaPrevia)
                { 
                    //Si es una vista previa cargamos el label de vista previa para deslizarlo
                    IEnumerable<RssItem> mItems = (IEnumerable<RssItem>)pEventArgs.Result;
                    this.lbl_vistaPrevia.Text = "";
                    this.lbl_vistaPrevia.Refresh();

                    if (mItems != null)
                    {
                        foreach (RssItem itemRss in mItems)
                        {
                            this.lbl_vistaPrevia.Text = this.lbl_vistaPrevia.Text + itemRss.Title + " - ";
                        }
                        this.lbl_vistaPrevia.Visible = true;
                    }
                }

            }            
            this.Cursor = Cursors.Default;
        }

        private void btn_vistaPrevia_Click(object sender, EventArgs e)
        {
            string urlFuente = txt_url.Text;
            timer1.Enabled = true;
            this.lbl_vistaPrevia.Enabled = true;
            this.lbl_vistaPrevia.Refresh();
            this.vistaPrevia = true;

            try
            {
                if (!this.bwRssReader.IsBusy)
                {
                    Uri mUrl;

                    if (!Uri.TryCreate(urlFuente.Trim(), UriKind.Absolute, out mUrl))
                    {
                        throw new ArgumentException("La URL que se ingreso no es válida.");
                    }

                    this.Cursor = Cursors.WaitCursor;
                    this.bwRssReader.RunWorkerAsync(mUrl);
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
     
        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer para que se deslice el texto de la vista previa
            this.lbl_vistaPrevia.Left -= 15;
            if (this.lbl_vistaPrevia.Left + this.lbl_vistaPrevia.Width < this.Left)
            {
                this.lbl_vistaPrevia.Left = this.Width + this.Location.X;
            }
        }        
    }
}
