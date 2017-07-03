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
        /// Constructor de la fachada
        /// </summary>
        public ControladorImagen()
        {
            this.iUnitOfWork = new UnitOfWork();
        }

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

        public Imagen ObtenerImagen(int pIdImagen)
        {
            return this.iUnitOfWork.ImagenRepository.GetByID(pIdImagen);
        }

        public List<Imagen> ObtenerImagenes()
        {
            return this.iUnitOfWork.ImagenRepository.Queryable.ToList<Imagen>();
        }

        public List<Imagen> ObtenerImagenesPorId(int pIdCampaña)
        {
            //Obtenemos todas las imagenes de la campaña
            IQueryable<Imagen> imagenes = this.ObtenerImagenes().AsQueryable();
            return (imagenes.Where(p => p.iIdCampaña == pIdCampaña)).ToList<Imagen>();
            //return campaniasFechas.ToList<Campaña>();
            //return this.iUnitOfWork.ImagenRepository.Queryable;
        }


    }
}
