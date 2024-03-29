﻿using System;
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

        /// <summary>
        /// Lista que contendra todas las imagenes que se eliminen de una campaña cuando estemos modificando una existente.
        /// </summary>
        IList<Imagen> iImagenesEliminadas = new List<Imagen>();

        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de la ventana utilizada para agregar una nueva campaña.
        /// </summary>
        public AgregarCampaña()
        {
            this.iCampaña = null;
            InitializeComponent();
        }

        /// <summary>
        /// Constructor de la ventana utilizada para modificar una campaña existente.
        /// </summary>
        /// <param name="pCampaña">Una campaña existente que deseemos modificar</param>
        public AgregarCampaña(Campaña pCampaña)
        {
            this.iCampaña = pCampaña;
            InitializeComponent();
        }
        #endregion

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (iCampaña != null)
            {
                bool modif = false;
                bool agreg = false;

                for (int i = 0; i <= DGV_imagenes.Rows.Count-1; i++)
                {
                    if (Convert.ToInt32(DGV_imagenes.Rows[i].Cells[4].Value) == 1)
                    {
                        agreg = true;
                        break;
                    }
                    else
                    {
                        if (Convert.ToInt32(DGV_imagenes.Rows[i].Cells[5].Value) ==1)
                        {
                            modif = true;
                            break;
                        }
                    }
                }

                if ((Convert.ToString(mtxt_horaInicio.Text)).CompareTo(Convert.ToString(iCampaña.iHoraInicio)) != 0 
                    || (Convert.ToString(mtxt_horaFin.Text)).CompareTo(Convert.ToString(iCampaña.iHoraFin)) != 0
                    ||  txt_nombreCampaña.Text != iCampaña.iNombre || (agreg) || (modif))
                    /*|| (Convert.ToString(dtp_fechaInicio.Text)).CompareTo(Convert.ToString(iCampaña.iFechaInicio)) != 0
                    || (Convert.ToString(dtp_fechaFin.Text)).CompareTo(Convert.ToString(iCampaña.iFechaFin)) != 0)*/
                {
                    if (MessageBox.Show(@"Advertencia, Los cambios no fueron guardados y seran descartados 
                                 ¿Esta seguro de continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else
                {
                    this.Close();
                }

            }//Fin if iCampaña!=null

            else 
            {
                if (mtxt_horaInicio.Text.CompareTo("  :  :") != 0 || mtxt_horaFin.Text.CompareTo("  :  :") != 0 || 
                    txt_nombreCampaña.Text.CompareTo("") != 0  || DGV_imagenes.Rows.Count > 0) 
                {
                    if (MessageBox.Show(@"Advertencia, Los cambios no fueron guardados y seran descartados 
                                 ¿Esta seguro de continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Close();
                    }                    
                }
                else { this.Close(); }            
            }
            
            
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            //Environment.NewLine introduce un salto de linea en la ventana de texto.
            MessageBox.Show("Para agregar una campaña:" + Environment.NewLine + "- Completar HoraInicio y HoraFin" + Environment.NewLine + "- Completar FechaInicio y FechaFin" + Environment.NewLine + "- Agregar al menos una Imagen");                                    
        }

        private void btn_guardarCampaña_Click(object sender, EventArgs e)
        {
            try
            {
                //Variable auxiliar con tiempo máximo para la hora.
                TimeSpan tiempoMaximo = new TimeSpan(23, 59, 59);

                //Variable auxiliar para controlar la duracion total de todas las imagenes de la campaña.    
                TimeSpan duracionTotalImagenes = new TimeSpan(00, 00, 00);

                //Variable auxiliar donde guardamos las imagenes de la campaña.
                List<Imagen> imagenesCampaña = new List<Imagen>();

                //Controles sobre las fechas y horas 
                if ((DGV_imagenes.Rows.Count > 0) && //Si la cantidad de filas de la grilla es mayor que 0
                              (TimeSpan.Parse(mtxt_horaFin.Text) < tiempoMaximo ||
                                TimeSpan.Parse(mtxt_horaInicio.Text) < tiempoMaximo) && //HoraInicio u HoraFin deben ser menores a (23,59,59)
                                    (TimeSpan.Parse(mtxt_horaInicio.Text) < TimeSpan.Parse(mtxt_horaFin.Text)) && //HoraInicio menor a HoraFin 
                                       (Convert.ToDateTime(dtp_fechaInicio.Text) < Convert.ToDateTime(dtp_fechaFin.Text)) && //FechaInicio menor a FechaFin
                                            (Convert.ToDateTime(dtp_fechaInicio.Text) >= DateTime.Today && Convert.ToDateTime(dtp_fechaFin.Text) > DateTime.Today)) //Fecha de inicio o igual a la fecha actual y fecha de fin mayor a a la fecha actual
                {
                    //Llenamos la campaña nueva con los nuevos atributos ingresados.
                    Campaña campaña = new Campaña
                    {
                        iNombre = txt_nombreCampaña.Text,
                        iHoraFin = TimeSpan.Parse(mtxt_horaFin.Text),
                        iHoraInicio = TimeSpan.Parse(mtxt_horaInicio.Text),
                        iFechaInicio = Convert.ToDateTime(dtp_fechaInicio.Text),
                        iFechaFin = Convert.ToDateTime(dtp_fechaFin.Text),
                    };

                    //Insertamos las imágenes de la grilla a una lista para poder usarlas en los métodos de la fachada,
                    //tanto en agregar campaña, como en modificar.
                    for (int i = 0; i < DGV_imagenes.Rows.Count; i++)
                    {

                        string ruta = (DGV_imagenes.Rows[i].Cells[1].Value.ToString());
                        int posicion = (Convert.ToInt32(DGV_imagenes.Rows[i].Cells[2].Value));
                        TimeSpan duracion = TimeSpan.Parse(DGV_imagenes.Rows[i].Cells[3].Value.ToString());

                        //Controlamos que no se agreguen imágenes con posiciones repetidas o inválidas.
                        if (posicion > 0 &&
                              posicion <= DGV_imagenes.Rows.Count && //Cantidad de imagenes de la campaña.
                              (!imagenesCampaña.Any(imagenesActuales => imagenesActuales.iPosicion == posicion))) //Si ya existe la posición.
                        {
                            Imagen imagen = new Imagen
                            {
                                iRuta = ruta,
                                iDuracion = duracion,
                                iPosicion = posicion,
                            };


                            //Actualizamos el contador de duración total de las imágenes.
                            duracionTotalImagenes = duracionTotalImagenes.Add(imagen.iDuracion);
                            imagenesCampaña.Add(imagen);
                        }
                        else //Si la posición ingresada para la imagen es inválida.
                        {
                            imagenesCampaña = null;
                            throw new PosicionImagenException("Error! Alguna de las posiciones de las imágenes están mal o repetidas. Por favor reviselas nuevamente.");
                        }
                    }//end del for con las imágenes de la grilla.


                    //La suma de duraciones de las imágenes de la campaña debe ser menor a la diferencia de tiempo entre la HoraInicio y HoraFin.     
                    if (duracionTotalImagenes > (TimeSpan.Parse(mtxt_horaFin.Text).Subtract(TimeSpan.Parse(mtxt_horaInicio.Text))))
                    {
                        {
                            MessageBox.Show("Error! La duración total de las imágenes de la campaña excede al tiempo que se mostrará la campaña");
                        }
                    }
                    else //Duración total es menor o igual a la diferencia de tiempo.
                    {
                        if (iCampaña == null)//Es decir que se está agregando NUEVA campaña.
                        {                           
                            campaña.iImagenes = imagenesCampaña;
                            iFachadaCampaña.AgregarCampaña(campaña);
                            MessageBox.Show("La campaña fue creada con éxito!");
                            this.Close();
                        }

                        else//Si la campaña es diferente de nula, es decir que estamos MODIFICANDO una campaña existente.
                        {
                            //Para el modificar necesitamos la id y al principio no se la pasamos puesto que
                            //hay codigo que tambien aplica para el agregar, pero en el id difiere ya que este esta dado 
                            //y en el agregar no.                         
                            
                            Campaña campañaAModificar = iFachadaCampaña.ObtenerCampaña(iCampaña.iIdCampaña);
                            campañaAModificar.iHoraInicio = campaña.iHoraInicio;
                            campañaAModificar.iHoraFin = campaña.iHoraFin;
                            campañaAModificar.iFechaInicio = campaña.iFechaInicio;
                            campañaAModificar.iFechaFin = campaña.iFechaFin;
                            campañaAModificar.iNombre = campaña.iNombre;

                            iFachadaCampaña.ModificarCampaña(campañaAModificar);

                            #region Actualizacion de las imagenes de la campañas
                            //Recorremos todas las imagenes del datagrid view
                            for (int i = 0; i <= this.DGV_imagenes.Rows.Count - 1; i++)
                            {
                                //Si alguna posee un 1 en la columna de agregar, es porque hay que agregarla a la BD
                                if (Convert.ToInt32(DGV_imagenes.Rows[i].Cells[4].Value) == 1)
                                {
                                    Imagen imagenAgregar = new Imagen
                                    {
                                        iIdCampaña = iCampaña.iIdCampaña,
                                        iRuta = Convert.ToString(DGV_imagenes.Rows[i].Cells[1].Value),
                                        iPosicion = Convert.ToInt32(DGV_imagenes.Rows[i].Cells[2].Value),
                                        iDuracion = TimeSpan.Parse(Convert.ToString(DGV_imagenes.Rows[i].Cells[3].Value))
                                    };

                                    iFachadaImagen.AgregarImagen(imagenAgregar);
                                }

                                else
                                {
                                    //Si alguna posee un 1 en la columna de modificar entonces hay que modificar  
                                    //una imagen ya existente en la BD
                                    if (Convert.ToInt32(DGV_imagenes.Rows[i].Cells[5].Value) == 1)
                                    {
                                        //Obtenemos la imagen en cuestion.
                                        Imagen imagenModificar =
                                            iFachadaImagen.ObtenerImagen(Convert.ToInt32(DGV_imagenes.Rows[i].Cells[0].Value));

                                        //Actualizamos los atributos que pueden ser modificados.
                                        imagenModificar.iRuta = Convert.ToString(DGV_imagenes.Rows[i].Cells[1].Value);
                                        imagenModificar.iPosicion = Convert.ToInt32(DGV_imagenes.Rows[i].Cells[2].Value);
                                        imagenModificar.iDuracion = TimeSpan.Parse(Convert.ToString(DGV_imagenes.Rows[i].Cells[3].Value));

                                        //guardamos los cambios.
                                        iFachadaImagen.ModificarImagen(imagenModificar);
                                    }

                                }

                            }

                            //Si se borraron imagenes que ya existian en la base de datos terminan aqui para ser eliminadas de la
                            //base de datos.
                            foreach (Imagen imagenEliminada in iImagenesEliminadas)
                            {
                                iFachadaImagen.EliminarImagen(imagenEliminada.iIdImagen);
                            }

                            #endregion


                            MessageBox.Show("La campaña se ha modificado con éxito!");
                            this.Close();                        
                        }//IF de (iCampaña == null)

                    }//IF de duración total de imágenes.

                }//IF de controles sobre Fechas y Horas.

                else //Si no se cumple alguno de los controles sobre Fechas y Horas. Datos erróneos ingresados.
                {
                    //A la error string le concatenamos los errores segun coincidan en las condiciones de los if. 

                    string ErrorString = "Se han detectado el (o los) siguente(s) error(es): \n";

                    if (DGV_imagenes.Rows.Count == 0) //No hay ninguna imagen cargada.
                    { ErrorString = ErrorString + ("• Faltan ingresar datos de imagenes \n"); }

                    if (TimeSpan.Parse(mtxt_horaFin.Text) > tiempoMaximo ||
                            TimeSpan.Parse(mtxt_horaInicio.Text) > tiempoMaximo) //HoraInicio u HoraFin inválidas.
                    {
                        ErrorString = ErrorString + ("• La hora de inicio y/o de fin estan mal ingresadas. Valores validos desde 00:00:00 hasta 23:59:59 \n");
                    }

                    if ((TimeSpan.Parse(mtxt_horaInicio.Text) >= TimeSpan.Parse(mtxt_horaFin.Text))) //HoraInicio mayor a HoraFin.
                    {
                        ErrorString = ErrorString + ("• La hora de inicio no puede ser mayor o igual a la de fin \n");
                    }

                    if (Convert.ToDateTime(dtp_fechaInicio.Text) > Convert.ToDateTime(dtp_fechaFin.Text)) //FechaInicio mayor a FechaFin.
                    {
                        ErrorString = ErrorString + ("• La fecha de inicio no puede ser mayor que la de fin \n");
                    }

                    if (Convert.ToDateTime(dtp_fechaInicio.Text) <= DateTime.Today || Convert.ToDateTime(dtp_fechaFin.Text) < DateTime.Today)
                        //FechaInicio y fin menores a la actual.
                    {
                        ErrorString = ErrorString + ("• La fecha de inicio y/o fin deben ser mayores a la actual \n");
                    }

                    MessageBox.Show(ErrorString);
                }//ELSE si no se cumplen controles de datos ingresados.

            }//end del try

            catch (FormatException)
            {
                MessageBox.Show("Error, revise los datos ingresados");
            }

            catch (PosicionImagenException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (CampañaNoDisponibleException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_buscarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                //Nombre inicial del archivo.
                OFD_buscarImagen.FileName = txt_rutaImagen.Text;
                //Formatos por los cuales filtrar en el cuadro de búsqueda.
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
            txt_rutaImagen.Text = (DGV_imagenes.CurrentRow.Cells[1].Value.ToString());
            txt_posicion.Text = (DGV_imagenes.CurrentRow.Cells[2].Value.ToString());
            mtxt_duracionImagen.Text = Convert.ToString(DGV_imagenes.CurrentRow.Cells[3].Value);
            btn_agregarImagen.Enabled = false;
            btn_buscarImagen.Enabled = true;
            btn_modificarImagen.Enabled = true;
            btn_quitarImagen.Enabled = true;
        }

        private void Campañas_Load(object sender, EventArgs e)
        {
            //Si se inicializa el formulario con una campaña a modificar
            if (iCampaña != null)
            {
                //Cargamos los datos de la campaña en los TextBox.
                dtp_fechaInicio.Text = iCampaña.iFechaInicio.ToString("dd/MM/yyyy");
                dtp_fechaFin.Text = iCampaña.iFechaFin.ToString("dd/MM/yyyy");
                mtxt_horaInicio.Text = Convert.ToString(iCampaña.iHoraInicio);
                mtxt_horaFin.Text = Convert.ToString(iCampaña.iHoraFin);
                txt_nombreCampaña.Text = Convert.ToString(iCampaña.iNombre);

                //Obtenemos todas las imagenes de la campaña
                IQueryable<Imagen> imagenes = iFachadaImagen.ObtenerImagenes().AsQueryable();
                var imagenesDe = imagenes.Where(p => p.iIdCampaña == iCampaña.iIdCampaña);

                //Cargamos las imagenes de la campaña al datagridview de imagenes de la campaña
                foreach (Imagen imagen in imagenesDe)
                {
                    DGV_imagenes.Rows.Add(imagen.iIdImagen, imagen.iRuta, imagen.iPosicion, imagen.iDuracion, 0, 0);
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
                       !string.IsNullOrWhiteSpace(txt_rutaImagen.Text) && 
                            mtxt_duracionImagen.Text.CompareTo("00:00:00") != 0)
                {
                    TimeSpan duracion = TimeSpan.Parse(Convert.ToString(mtxt_duracionImagen.MaskedTextProvider));
                    DGV_imagenes.Rows.Add(null, (txt_rutaImagen.Text), Convert.ToInt32(txt_posicion.Text), duracion, 1, 0);
                    mtxt_duracionImagen.Text = "__:__:__";
                    txt_posicion.Text = "";
                    txt_rutaImagen.Text = "";

                }

                else
                {
                    if (mtxt_duracionImagen.Text.CompareTo("00:00:00") == 0)
                    {
                        MessageBox.Show("La duracion de una imagen no puede ser 0 segundos");
                    }
                    else
                    {
                        MessageBox.Show("Complete los campos faltantes de la imagen ");
                    }
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Error, revise los datos ingresados");
            }
        }

        private void btn_modificarImagen_Click(object sender, EventArgs e)
        {
            //Si los datos en los Textbox estan iguales a los de la grilla, no se han hecho modificaciones.
            if (txt_rutaImagen.Text == Convert.ToString(DGV_imagenes.CurrentRow.Cells[1].Value) 
                && txt_posicion.Text == Convert.ToString(DGV_imagenes.CurrentRow.Cells[2].Value) 
                && mtxt_duracionImagen.Text == Convert.ToString(DGV_imagenes.CurrentRow.Cells[3].Value))
            {
                MessageBox.Show("No ha modificado ningún dato!");
            }
            else //Si cambió algun dato de algún Textbox, se debe modificar en la grilla.
            {
                if (mtxt_duracionImagen.Text.CompareTo("00:00:00") == 0)
                {
                    MessageBox.Show("Error! La duracion de la imagen en la camapaña no puede ser 00:00:00");
                }
                else
                {
                    this.DGV_imagenes.CurrentRow.Cells[1].Value = txt_rutaImagen.Text;
                    this.DGV_imagenes.CurrentRow.Cells[2].Value = txt_posicion.Text;
                    this.DGV_imagenes.CurrentRow.Cells[3].Value = mtxt_duracionImagen.Text;

                    //Si no hay que agregarlo, le ponemos a la columna de modificar un 1.
                    if (Convert.ToInt32(this.DGV_imagenes.CurrentRow.Cells[4].Value) != 1)
                    {
                        this.DGV_imagenes.CurrentRow.Cells[5].Value = 1;
                    }

                    this.DGV_imagenes.CurrentRow.Cells[3].Value = mtxt_duracionImagen.Text;
                    MessageBox.Show("Imagen modificada! Guarde los cambios en la Campaña para finalizar.");
                    this.ActualizarControles();     
                }
            }                            
        }

        private void btn_quitarImagen_Click(object sender, EventArgs e)
        {

            #region Control para eliminar
            //Agregamos la imagen que se quiere eliminar a una lista para que cuando se pulse en guardar
            //se elimine la imagen. 

            Imagen imagenAEliminar = iFachadaImagen.ObtenerImagen(Convert.ToInt32(DGV_imagenes.CurrentRow.Cells[0].Value));

            //Control para las imagenes que aun no han sido agregadas a la base de datos.
            if (imagenAEliminar != null)
            {
                iImagenesEliminadas.Add(imagenAEliminar);
            }

            #endregion

                //Si se quita una imagen (que no sea la ultima), ajustamos automaticamente a una posicion inferior a las demas. 
                //ademas advertimos al usuario de la situacion.
                if (Convert.ToInt32(this.DGV_imagenes.CurrentRow.Cells[2].Value) != this.DGV_imagenes.Rows.Count)
                {
                    if (MessageBox.Show(@"Advertencia, si quita esta imagen, las posiciones de las imagenes se autoajustaran a una posicion de diferencia de la que estan 
                                 ¿Esta seguro de continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {    
                    
                        #region Control para acomodar automaticamente las posiciones de las imagenes de la campaña
                        
                        //Cargamos la posicion desde donde hay que acomodar el resto de las imagenes.
                        int acomodarDesde = Convert.ToInt32(this.DGV_imagenes.CurrentRow.Cells[2].Value);
                        this.DGV_imagenes.Rows.Remove(this.DGV_imagenes.CurrentRow);
                        for (int i = 0; i <= this.DGV_imagenes.Rows.Count-1; i++)
                        {
                            if ( (this.DGV_imagenes.Rows[i].Cells[2].Value.ToString() != "1") &&  (Convert.ToInt32(this.DGV_imagenes.Rows[i].Cells[2].Value) >= acomodarDesde))
                            {
                                this.DGV_imagenes.Rows[i].Cells[2].Value =
                                                       Convert.ToString(Convert.ToInt32(this.DGV_imagenes.Rows[i].Cells[2].Value) - 1);
                                
                                this.DGV_imagenes.Rows[i].Cells[5].Value = 1;
                                                       
                            }
                        }
                        #endregion

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

        private void limpiarBoxes()
        {
            //Textbox
            txt_rutaImagen.Text = string.Empty;
            mtxt_duracionImagen.Text = string.Empty;
            txt_posicion.Text = string.Empty;            
        }

        private void ActualizarControles()
        {
            //Establecer botones
            btn_agregarImagen.Enabled = true;
            btn_buscarImagen.Enabled = true;
            btn_modificarImagen.Enabled = false;
            btn_quitarImagen.Enabled = false;

            this.limpiarBoxes();
            DGV_imagenes.ClearSelection();
            // TODO: This line of code loads data into the '_Programa_Inti_ContextoDataSet.Productoes' table. You can move, or remove it, as needed.
            //this.productoesTableAdapter.Fill(this._Programa_Inti_ContextoDataSet.Productoes);
            //cargarID();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.ActualizarControles();
        }

        public void FixEfProviderServicesProblem()
        {
            //The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
            //for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
            //Make sure the provider assembly is available to the running application. 
            //See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.

            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        private void mtxt_horaInicio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtxt_duracionImagen_Enter(object sender, EventArgs e)
        {
            lbl_infoDuracion.Enabled = true;
            lbl_infoDuracion.Text =
                "hh:mm:ss";
        }

        private void mtxt_duracionImagen_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtxt_duracionImagen_Leave(object sender, EventArgs e)
        {
            lbl_infoDuracion.Enabled = false;
            lbl_infoDuracion.Text = "";
        }

        private void DGV_imagenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
       

  

        


    }
}
