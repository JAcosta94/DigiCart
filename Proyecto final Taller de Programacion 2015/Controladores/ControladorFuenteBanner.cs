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

        public ControladorFuenteBanner()
        {
            this.iUnitOfWork = new UnitOfWork();
        }

        #region Metodos para tratar fuentes rss
        public void AgregarFuenteRSS(FuenteRSS pFuenteRSS)
        {
            this.iUnitOfWork.FuenteRSSRepository.Insert(pFuenteRSS);
            this.iUnitOfWork.Save();
        }

        public void ModificarFuenteRSS(FuenteRSS pFuenteRSS)
        {
            this.iUnitOfWork.FuenteRSSRepository.Update(pFuenteRSS);
            this.iUnitOfWork.Save();
        }

        public void EliminarFuenteRSS(int pFuenteRSSId)
        {
            this.iUnitOfWork.FuenteRSSRepository.Delete(pFuenteRSSId);
            this.iUnitOfWork.Save();
        }

        public IQueryable<FuenteRSS> ObtenerFuentesRSS()
        {
            return this.iUnitOfWork.FuenteRSSRepository.Queryable;
        }

        public FuenteRSS ObtenerFuenteRSS(int pIdFuenteRSS)
        {
            return this.iUnitOfWork.FuenteRSSRepository.GetByID(pIdFuenteRSS);
        }

        public void ActualizarUltimaObtencionDeFeeds(FuenteRSS pFuenteRSS)
        {
            this.iUnitOfWork.FuenteRSSRepository.Update(pFuenteRSS);
        }

        #endregion



        //#region Metodos para tratar texto fijo

        //public void AgregarTextoFijo(BannerFuenteTextoFijo pTextoFijo)
        //{
        //    this.iUnitOfWork.FuenteTextoFijoRepository.Insert(pTextoFijo);
        //    this.iUnitOfWork.Save();
        //}

        //public void ModificarTextoFijo(BannerFuenteTextoFijo pTextoFijo)
        //{
        //    this.iUnitOfWork.FuenteTextoFijoRepository.Update(pTextoFijo);
        //    this.iUnitOfWork.Save();
        //}

        //public void EliminarTextoFijo(int pTextoFijoId)
        //{
        //    this.iUnitOfWork.FuenteTextoFijoRepository.Delete(pTextoFijoId);
        //    this.iUnitOfWork.Save();
        //}
        //#endregion

    }
}
