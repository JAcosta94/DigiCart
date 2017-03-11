using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public class UnitOfWork : IDisposable
    {
        private bool iDisposed = false;
        
        /// <summary>
        /// Contexto en el que almacenamos la informacion
        /// </summary>
        private CarteleriaContext context = new CarteleriaContext();

        //Repositorios en donde se guardara la informacion de cada una de las clases de dominio.
        #region Repositorios
        /// <summary>
        /// Repositorio generico de campañas
        /// </summary>
        private GenericRepository<Campaña> iCampañaRepository;
        
        /// <summary>
        /// Repositorio generico de banners
        /// </summary>
        private GenericRepository<Banner> iBannerRepository;

        /// <summary>
        /// Repositorio generico de las imagenes
        /// </summary>
        private GenericRepository<Imagen> iImagenRepository;
        #endregion

        
        /// <summary>
        /// Metodo para guardar los cambios en el repositorio generico. Se ejecuta la transaccion.
        /// </summary>
        public void Save()
        {
            context.SaveChanges();       
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pDisposed"></param>
        protected void Dispose(bool pDisposed)
        {
            if (!this.iDisposed)
            {
                if (pDisposed)
                {
                    context.Dispose();
                }
            }
            this.iDisposed = true;
        }

       /// <summary>
       /// 
       /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

       /// <summary>
       /// 
       /// </summary>
        public GenericRepository<Campaña> CampañaRepository
        {
            get
            {
                if (this.iCampañaRepository == null)
                {
                    this.iCampañaRepository = new GenericRepository<Campaña>(context);
                }
                return iCampañaRepository;
            }
        }
       
        public GenericRepository<Banner> BannerRepository
        {
            get
            {
                if (this.iBannerRepository == null)
                {
                    this.iBannerRepository = new GenericRepository<Banner>(context);
                }
                return iBannerRepository;
            }
        }

        public GenericRepository<Imagen> ImagenRepository
        {
            get
            {
                if (this.iImagenRepository == null)
                {
                    this.iImagenRepository = new GenericRepository<Imagen>(context);
                }
                return iImagenRepository;
            }
        }



    }
}
