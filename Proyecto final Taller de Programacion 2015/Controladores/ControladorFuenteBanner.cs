using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Dominio;

namespace Controladores
{
    public class ControladorFuenteBanner
    {
        private UnitOfWork iUnitOfWork;

        /// <summary>
        /// Metodo para crear el controlador de las fuentes de los banners
        /// </summary>
        public ControladorFuenteBanner()
        {
            this.iUnitOfWork = new UnitOfWork();
        }

        #region Metodos para tratar fuentes rss

        /// <summary>
        /// Metodo para agregar una fuente rss a la base de datos desde la interfaz de usuario
        /// </summary>
        /// <param name="pFuenteRSS">objeto que contiene la fuente rss a agregar</param>
        public void AgregarFuenteRSS(FuenteRSS pFuenteRSS)
        {
            this.iUnitOfWork.FuenteRSSRepository.Insert(pFuenteRSS);
            this.iUnitOfWork.Save();
        }

        /// <summary>
        /// Metodo para modificar una fuente rss de la base de datos desde la interfaz de usuario
        /// </summary>
        /// <param name="pFuenteRSS">objeto que contiene la fuente rss a modificar</param>
        public void ModificarFuenteRSS(FuenteRSS pFuenteRSS)
        {
            this.iUnitOfWork.FuenteRSSRepository.Update(pFuenteRSS);
            this.iUnitOfWork.Save();
        }

        /// <summary>
        /// Metodo para eliminar una fuente rss de la base de datos desde la interfaz de usuario
        /// </summary>
        /// <param name="pFuenteRSSId">entero que contiene la id de la fuente rss a eliminar</param>
        public void EliminarFuenteRSS(int pFuenteRSSId)
        {
            this.iUnitOfWork.FuenteRSSRepository.Delete(pFuenteRSSId);
            this.iUnitOfWork.Save();
        }

        /// <summary>
        /// Metodo para obtener todas las fuentes rss de la base de datos desde la interfaz de usuario
        /// </summary>
        /// <returns></returns>
        public IQueryable<FuenteRSS> ObtenerFuentesRSS()
        {
            return this.iUnitOfWork.FuenteRSSRepository.Queryable;
        }

        /// <summary>
        /// Metodo para obtener una fuentes rss de la base de datos a partir del id desde la interfaz de usuario
        /// </summary>
        /// <param name="pIdFuenteRSS">entero que contiene la id de la fuente rss</param>
        /// <returns></returns>
        public FuenteRSS ObtenerFuenteRSS(int pIdFuenteRSS)
        {
            return this.iUnitOfWork.FuenteRSSRepository.GetByID(pIdFuenteRSS);
        }

        #endregion

    }
}
