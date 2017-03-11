using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Dominio;

namespace Controladores
{
    public class ControladorCampaña
    {
        private UnitOfWork iUnitOfWork;

        /// <summary>
        /// Constructor de la fachada
        /// </summary>
        public ControladorCampaña()
        {
            this.iUnitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// Metodo para agregar una campaña a la base de datos desde la interfaz de usuario
        /// </summary>
        /// <param name="pCampaña">Campaña a agregar</param>
        public void AgregarCampaña(Campaña pCampaña)
        {   
            iUnitOfWork.CampañaRepository.Insert(pCampaña);
            iUnitOfWork.Save();                              
        }


        /// <summary>
        /// Metodo para modificar una campaña en la base de datos desde la interfaz de usuario
        /// </summary>
        /// <param name="pCampaña">campaña a modificar</param>
        public void ModificarCampaña(Campaña pCampaña)
        {                                     
            iUnitOfWork.CampañaRepository.Update(pCampaña);
            iUnitOfWork.Save();                                
        }

       
        /// <summary>
        /// Metodo para obtener todas las imagenes de una campaña
        /// </summary>
        /// <param name="pIdCampaña">id de la campaña que se desea obtener todas las imagenes</param>
        /// <returns></returns>
        public IList<Imagen> obtenerImagenesCampaña(int pIdCampaña) 
        {
            return iUnitOfWork.CampañaRepository.GetByID(pIdCampaña).iImagenes;
        }

        
        /// <summary>
        /// Metodo para obtener todas las campañas almacenadas en la base de datos
        /// </summary>
        /// <returns></returns>
        public IQueryable<Campaña> ObtenerCampañas()
        {
            return iUnitOfWork.CampañaRepository.Queryable;
        }

    }
}
