using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;
using Dominio;
using Excepciones;



namespace WindowsFormsApplication
{
    public partial class AgregarCampaña : Form
    {
        #region Atributos
        private Campaña iCampaña;        
        //Fachadas utilizadas por el formulario
        ControladorImagen iFachadaImagen = new ControladorImagen();
        ControladorCampaña iFachadaCampaña = new ControladorCampaña();
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de la ventana.
        /// </summary>
        public AgregarCampaña()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor de la ventana.
        /// </summary>
        /// <param name="pCampaña">Una campaña existente</param>
        public AgregarCampaña(Campaña pCampaña)
        {
            this.iCampaña = pCampaña;
            InitializeComponent();
        }
        #endregion

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            //Environment.NewLine introduce un salto de linea en la ventana de texto.
            MessageBox.Show("Para agregar una campaña:" + Environment.NewLine + "- Completar HoraInicio y HoraFin" + Environment.NewLine + "- Completar FechaInicio y FechaFin" + Environment.NewLine + "- Agregar al menos una Imagen");            
            
            //MessageBox.Show("Esta ventana contiene todos los datos de una campaña. Debe agregar las fechas en las que quiere que la campaña se muestre, ademas del horario a la que estara la misma. Tambien debe ingresar las imagenes que se mostraran en esta");
        }

        private void btn_guardarCampaña_Click(object sender, EventArgs e)
        {
            
            //DateTime fechaMinima = new DateTime(,,);
            
            try
            {
            //Se establece tiempo
            TimeSpan tiempoMaximo = new TimeSpan(23, 59, 59);
                
            //Controles sobre las fechas y horas 
            if ((DGV_imagenes.Rows.Count > 0) && //Si la cantidad de filas es mayor que 0
                          (TimeSpan.Parse(mtxt_horaFin.Text) < tiempoMaximo ||
                            TimeSpan.Parse(mtxt_horaInicio.Text) < tiempoMaximo) && //HoraInicio y HoraFin deben ser menores a (23,59,59)
                                (TimeSpan.Parse(mtxt_horaInicio.Text) < TimeSpan.Parse(mtxt_horaFin.Text)) && //HoraInicio menor a HoraFin 
                                   (Convert.ToDateTime(dtp_fechaInicio.Text) < Convert.ToDateTime(dtp_fechaFin.Text)))//FechaInicio menor a FechaFin
                {

                    Campaña campaña = new Campaña 
                    { 
                        iNombre = txt_nombreCampaña.Text,
                        iHoraFin = TimeSpan.Parse(mtxt_horaFin.Text),
                        iHoraInicio = TimeSpan.Parse(mtxt_horaInicio.Text),
                        iFechaInicio = Convert.ToDateTime(dtp_fechaInicio.Text),
                        iFechaFin = Convert.ToDateTime(dtp_fechaFin.Text),
                    };
                    
                    //campaña.HoraFin = TimeSpan.Parse(mtxt_horaFin.Text);
                    //campaña.HoraInicio = TimeSpan.Parse(mtxt_horaInicio.Text);

                    
                    //intervalo.FechaInicio = Convert.ToDateTime(mtxt_fechaInicio.Text);
                    //intervalo.FechaFin = Convert.ToDateTime(mtxt_fechaFin.Text);

                    TimeSpan duracionTotalImagenes = new TimeSpan(00, 00, 00);

                   
                    //Variable auxiliar donde guardamos las imagenes de la campaña.
                    IList<Imagen> imagenesCampaña = new List<Imagen>();

                    //Insertamos las imagenes del datagridview a una lista para poder usarlas en los metodos de la fachada,
                    //tanto en el agregar campaña, como en el modificar.
                    for (int i = 0; i < DGV_imagenes.Rows.Count; i++)
                    {

                        string ruta = (DGV_imagenes.Rows[i].Cells[0].Value.ToString());
                        TimeSpan duracion = TimeSpan.Parse(DGV_imagenes.Rows[i].Cells[2].Value.ToString());
                        int posicion = (Convert.ToInt32(DGV_imagenes.Rows[i].Cells[1].Value));

                        //Con la condicion del if controlamos que no se agreguen imagenes con posiciones repetidas
                        if (posicion > 0 &&
                              posicion <= DGV_imagenes.Rows.Count &&
                              (!imagenesCampaña.Any(imagenesActuales => imagenesActuales.iPosicion == posicion)))
                        {
                            Imagen imagen = new Imagen 
                            { 
                            iRuta = ruta,
                            iDuracion = duracion,
                            iPosicion = posicion,
                            };
                            
                            duracionTotalImagenes = duracionTotalImagenes.Add(imagen.iDuracion);
                            imagenesCampaña.Add(imagen);

                        }

                        else
                        {
                            imagenesCampaña = null;
                            throw new PosicionImagenException("Error, alguna o algunas de las posiciones de la imagenes estan mal o repetidas. Por favor reviselas una vez mas");
                        }
                    }


                    if (duracionTotalImagenes > (TimeSpan.Parse(mtxt_horaFin.Text).Subtract(TimeSpan.Parse(mtxt_horaInicio.Text))))
                    {
                        {
                            MessageBox.Show("Error, la duracion total de las imagenes de la campaña excede al tiempo que se mostrara la campaña");
                        }

                    }

                    else
                    {
                        if (iCampaña == null)
                        {

                            //Falta algun metodo de disponibilidad....!!!!!!!!!!!!!!!!!!!!!!!!
                            
                            campaña.iImagenes = imagenesCampaña;
                            iFachadaCampaña.AgregarCampaña(campaña);
                            //foreach (Imagen imagenCampaña in imagenesCampaña)
                            //{
                            //    iFachadaImagen.AgregarImagen(imagenCampaña);
                            //}

                            MessageBox.Show("La campaña fue creada con exito!");
                            this.Close();

                            //if (fachadaCampaña.AgregarCampaña(campaña, intervalo, imagenesCampaña))
                            //{
                            //    MessageBox.Show("Campaña guardada con exito!");
                            //    this.Close();
                            //}

                            //else
                            //{
                            //    MessageBox.Show("Error, la campaña no esta disponible en ese rango de fechas y/o horario");
                            //}

                        }

                        else
                        {
                            //Hacemos esto, ya que para el modificar necesitamos la id y al principio no se la pasamos puesto que
                            //hay codigo que tambien aplica para el agregar, pero en el id difiere ya que este esta dado 
                            //y en el agregar no.
                            campaña.iIdCampaña = iCampaña.iIdCampaña;


                            iFachadaCampaña.ModificarCampaña(campaña);
                            MessageBox.Show("La campaña se ha modificado con exito");
                            this.Close();
         

                            //if (fachadaCampaña.ModificarCampaña(campaña, intervalo, imagenesCampaña))
                            //{
                            //    MessageBox.Show("La campaña se ha modificado con exito");
                            //    this.Close();
                            //}

                            //else
                            //{
                            //    MessageBox.Show("La campaña no esta disponible en el rango de fechas y/o horario dados");
                            //}
                        }
                    }
                }

                else
                {
                    //Aqui se entra si hay errores en los ingresos de datos. A la error string le concatenamos 
                    //los errores segun coincidan en las condiciones de los if. 

                    string ErrorString = "Se han detectado el (o los) siguente(s) error(es): \n";

                    if (DGV_imagenes.Rows.Count == 0)
                    { ErrorString = ErrorString + ("• Faltan ingresar datos de imagenes \n"); }

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

            catch (PosicionImagenException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_buscarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                //Se estabecen los formatos por los cuales filtrar en el cuadro de búsqueda.
                OFD_buscarImagen.Filter = "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|Mapa de bits (*.bmp,*.dib)|*.bmp,*.dib|Todos los archivos (*.*)|*.*";
                OFD_buscarImagen.ShowDialog();
                txt_rutaImagen.Text = OFD_buscarImagen.FileName;
            }
            catch (Exception)
            {

                throw;
            }
        }
                
        private void DGV_imagenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_rutaImagen.Text = (DGV_imagenes.CurrentRow.Cells[0].Value.ToString());
            txt_posicion.Text = (DGV_imagenes.CurrentRow.Cells[1].Value.ToString());
            mtxt_duracionImagen.Text = Convert.ToString(DGV_imagenes.CurrentRow.Cells[2].Value);
            btn_agregarImagen.Enabled = false;
            btn_buscarImagen.Enabled = false;
            btn_modificarImagen.Enabled = true;
            btn_quitarImagen.Enabled = true;
        }

        private void Campañas_Load(object sender, EventArgs e)
        {
            //Aqui entra cuando la ventana ingresa con una campaña a la cual se desea modificar alguno de sus datos.
            if (iCampaña != null)
            {
                //Cargamos los datos de la campaña en los TextBox.
                dtp_fechaInicio.Text = iCampaña.iFechaInicio.ToString("dd/MM/yyyy");
                dtp_fechaFin.Text = iCampaña.iFechaFin.ToString("dd/MM/yyyy");
                mtxt_horaInicio.Text = Convert.ToString(iCampaña.iHoraInicio);
                mtxt_horaFin.Text = Convert.ToString(iCampaña.iHoraFin);
                txt_nombreCampaña.Text = Convert.ToString(iCampaña.iNombre);

                //Obtenemos todas las imagenes de la campaña
                IQueryable<Imagen> imagenes = iFachadaImagen.ObtenerImagenes();
                var imagenesDe = imagenes.Where(p => p.iIdCampaña == iCampaña.iIdCampaña);

                //Cargamos las imagenes de la campaña al datagridview de imagenes de la campaña
                foreach (Imagen imagen in imagenesDe)
                {
                    DGV_imagenes.Rows.Add(imagen.iRuta, imagen.iPosicion, imagen.iDuracion, imagen.iIdImagen);
                }

                //Actualizamos el nombre de la ventana a modificar campaña
                this.Text = "Modificar Campaña";
                this.Refresh();
            }
        }

        private void btn_agregarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txt_posicion.Text) &&
                       !string.IsNullOrWhiteSpace(txt_rutaImagen.Text))
                {
                    TimeSpan duracion = TimeSpan.Parse(Convert.ToString(mtxt_duracionImagen.MaskedTextProvider));
                    DGV_imagenes.Rows.Add((txt_rutaImagen.Text), Convert.ToInt32(txt_posicion.Text), duracion);
                    mtxt_duracionImagen.Text = "__:__:__";
                    txt_posicion.Text = "";
                    txt_rutaImagen.Text = "";

                }

                else
                {
                    MessageBox.Show("Complete los campos faltantes de la imagen ");
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Error, revise los datos ingresados");
            }
        }

        private void btn_modificarImagen_Click(object sender, EventArgs e)
        {
            this.DGV_imagenes.CurrentRow.Cells[1].Value = txt_posicion.Text;
            this.DGV_imagenes.CurrentRow.Cells[2].Value = mtxt_duracionImagen.Text;

            txt_posicion.Text = "";
            txt_rutaImagen.Text = "";
            mtxt_duracionImagen.Text = "__:__:__";
            btn_agregarImagen.Enabled = true;
            btn_buscarImagen.Enabled = true;
            btn_modificarImagen.Enabled = false;
            btn_quitarImagen.Enabled = false;
        }

        private void btn_quitarImagen_Click(object sender, EventArgs e)
        {
           
                //Si se quita una imagen (que no sea la ultima), ajustamos automaticamente a una posicion inferior a las demas. 
                //ademas advertimos al usuario de la situacion.
                if (Convert.ToInt32(this.DGV_imagenes.CurrentRow.Cells[1].Value) != this.DGV_imagenes.Rows.Count)
                {
                    if (MessageBox.Show(@"Advertencia, si quita esta imagen, las posiciones de las imagenes se autoajustaran a una posicion de diferencia de la que estan 
                                 ¿Esta seguro de continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.DGV_imagenes.Rows.Remove(this.DGV_imagenes.CurrentRow);
                        for (int i = 0; i <= this.DGV_imagenes.Rows.Count-1; i++)
                        {
                            if (this.DGV_imagenes.Rows[i].Cells[1].Value.ToString() != "1")
                            {
                                this.DGV_imagenes.Rows[i].Cells[1].Value =
                                                       Convert.ToString(Convert.ToInt32(this.DGV_imagenes.Rows[i].Cells[1].Value) - 1);
                            }
                        }
                    }
                }

                else
                {
                    this.DGV_imagenes.Rows.Remove(this.DGV_imagenes.CurrentRow);
                }

                txt_posicion.Text = "";
                txt_rutaImagen.Text = "";
                mtxt_duracionImagen.Text = "__:__:__";
                btn_agregarImagen.Enabled = true;
                btn_buscarImagen.Enabled = true;
                btn_modificarImagen.Enabled = false;
                btn_quitarImagen.Enabled = false;
        }

        private void mtxt_horaInicio_Enter(object sender, EventArgs e)
        {
            lbl_informacion.Enabled = true;
            lbl_informacion.Text = 
                            "Las campañas solo pueden ser de 00:00:00 a 23:59:00. En caso de querer tener una campaña de por ejemplo: 20:00:00 a 02:00:00 \n (del dia siguiente) debera crear 2 campañas";
            
        }

        private void mtxt_horaInicio_Leave(object sender, EventArgs e)
        {
            lbl_informacion.Enabled = false;
            lbl_informacion.Text = "";
        }

        private void mtxt_horaFin_Enter(object sender, EventArgs e)
        {
            lbl_informacion.Enabled = true;
            lbl_informacion.Text =
                "Las campañas solo pueden ser de 00:00:00 a 23:59:00. En caso de querer tener una campaña de por ejemplo: 20:00:00 a 02:00:00 \n (del dia siguiente) debera crear 2 campañas";
        }

        private void mtxt_horaFin_Leave(object sender, EventArgs e)
        {
            lbl_informacion.Enabled = false;
            lbl_informacion.Text = "";
        }

        private void mtxt_fechaInicio_Leave(object sender, EventArgs e)
        {

        }

        private void mtxt_fechaInicio_Enter(object sender, EventArgs e)
        {

        }

        private void mtxt_fechaFin_Leave(object sender, EventArgs e)
        {

        }

        private void mtxt_fechaFin_Enter(object sender, EventArgs e)
        {

        }


        public void FixEfProviderServicesProblem()
        {
            //The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
            //for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
            //Make sure the provider assembly is available to the running application. 
            //See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.

            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
       

  

        


    }
}
