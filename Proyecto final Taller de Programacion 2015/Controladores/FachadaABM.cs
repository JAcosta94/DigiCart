using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Dominio;

namespace Controladores
{
    public class FachadaABM
    {
        private UnitOfWork iUnitOfWork;

        /// <summary>
        /// Constructor de la fachada
        /// </summary>
        public FachadaABM()
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
        /// Metodo para agregar una Imagen a la base de datos desde la interfaz de usuario
        /// </summary>
        /// <param name="pImagen">Imagen a agregar</param>
        public void AgregarImagen(Imagen pImagen)
        {
            iUnitOfWork.ImagenRepository.Insert(pImagen);
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
        /// Metodo para modificar una imagen en la base de datos desde la interfaz de usuario
        /// </summary>
        /// <param name="pImagen">Imagen a modificar</param>
        public void ModificarImagen(Imagen pImagen)
        {
            iUnitOfWork.ImagenRepository.Update(pImagen);
            iUnitOfWork.Save();        
        }

    }
}
