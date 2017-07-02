using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Dominio;

namespace Controladores
{
    public class ControladorBanner
    {
        private UnitOfWork iUnitOfWork;

        /// <summary>
        /// Constructor de la fachada
        /// </summary>
        public ControladorBanner()
        {
            this.iUnitOfWork = new UnitOfWork();
        }

        #region Metodos
        /// <summary>
        /// Metodo para agregar un banner a la base de datos desde la interfaz de usuario
        /// </summary>
        /// <param name="pBanner">Objeto que contiene el banner a ser agregado</param>
        public void AgregarBanner(Banner pBanner)
        {
            this.iUnitOfWork.BannerRepository.Insert(pBanner);
            this.iUnitOfWork.Save();
        }

       /// <summary>
       /// Metodo para modificar un banner existente en la base de datos desde la interfaz de usuario
       /// </summary>
       /// <param name="pBanner">objeto que contiene el banner que va a ser modificado</param>
        public void ModificarBanner(Banner pBanner)
        {
            this.iUnitOfWork.BannerRepository.Update(pBanner);
            this.iUnitOfWork.Save();        
        }

        /// <summary>
        /// Metodo para eliminar un banner de la base de datos desde la interfaz de usuario
        /// </summary>
        /// <param name="pIdBanner">entero que representa la id del banner a eliminar</param>
        public void EliminarBanner(int pIdBanner)
        {
            this.iUnitOfWork.BannerRepository.Delete(pIdBanner);
            this.iUnitOfWork.Save();
        }

        public List<Banner> ObtenerBanners()
        {
            return this.iUnitOfWork.BannerRepository.Queryable.ToList<Banner>();
        }

        public Banner ObtenerBanner(int pIdBanner)
        {
            return this.iUnitOfWork.BannerRepository.GetByID(pIdBanner);
        }  
        #endregion

    }
}
