using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Persistencia;

namespace Controladores
{
    public class ControladorImagen
    {       
        private UnitOfWork iUnitOfWork;

        /// <summary>
        /// Constructor del controlador de imagenes
        /// </summary>
        public ControladorImagen()
        {
            this.iUnitOfWork = new UnitOfWork();
        }


        #region Metodos controlador

        /// <summary>
        /// Metodo para agregar una Imagen a la base de datos desde la interfaz de usuario
        /// </summary>
        /// <param name="pImagen">Imagen a agregar</param>
        public void AgregarImagen(Imagen pImagen)
        {  
            this.iUnitOfWork.ImagenRepository.Insert(pImagen);
            this.iUnitOfWork.Save();                        
        }

        /// <summary>
        /// Metodo para modificar una imagen en la base de datos desde la interfaz de usuario
        /// </summary>
        /// <param name="pImagen">Imagen a modificar</param>
        public void ModificarImagen(Imagen pImagen)
        {                      
            this.iUnitOfWork.ImagenRepository.Update(pImagen);
            this.iUnitOfWork.Save();         
        }

        /// <summary>
        /// Metodo para eliminar una imagen de la base de datos desde la interfaz de usuario
        /// </summary>
        /// <param name="pImagen">Imagen a eliminar</param>
        public void EliminarImagen(int pIdImagen)
        {
            this.iUnitOfWork.ImagenRepository.Delete(pIdImagen);
            this.iUnitOfWork.Save();
        }

        /// <summary>
        /// Metodo para obtener una imagen almacenada en la bd a partir de su id desde la interfaz de usuario
        /// </summary>
        /// <param name="pIdImagen">entero que contiene la id de la imagen</param>
        /// <returns></returns>
        public Imagen ObtenerImagen(int pIdImagen)
        {
            return this.iUnitOfWork.ImagenRepository.GetByID(pIdImagen);
        }

        /// <summary>
        /// Metodo para obtener todas las imagenes almacenadas en la base de datos, desde la interfaz de usuario
        /// </summary>
        /// <returns></returns>
        public List<Imagen> ObtenerImagenes()
        {
            return this.iUnitOfWork.ImagenRepository.Queryable.ToList<Imagen>();
        }

        /// <summary>
        /// Metodo para obtener desde la interfaz de usuario 
        /// todas las imagenes de una campaña en particular que este almacenada en la BD a partir de su id        
        /// </summary>
        /// <param name="pIdCampaña">entero que contiene la id de la campaña de la cual se desea obtener todas las imagenes</param>
        /// <returns></returns>
        public List<Imagen> ObtenerImagenesPorId(int pIdCampaña)
        {
            //Obtenemos todas las imagenes de la campaña
            IQueryable<Imagen> imagenes = this.ObtenerImagenes().AsQueryable();
            
            //Lo convertimos a list y lo devolvemos.
            return (imagenes.Where(p => p.iIdCampaña == pIdCampaña)).ToList<Imagen>();
        }

        #endregion 
    }
}
