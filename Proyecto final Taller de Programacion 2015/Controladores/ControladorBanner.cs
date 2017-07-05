using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Dominio;
using Servicio_FuenteRSS;
using Excepciones;

namespace Controladores
{
    public class ControladorBanner
    {
        private UnitOfWork iUnitOfWork;
        private ServicioDisponibilidad iServicio;

        /// <summary>
        /// Constructor de la fachada
        /// </summary>
        public ControladorBanner()
        {
            this.iServicio = new ServicioDisponibilidad();
            this.iUnitOfWork = new UnitOfWork();
        }

        #region Metodos

        /// <summary>
        /// Metodo para agregar un banner a la base de datos desde la interfaz de usuario
        /// </summary>
        /// <param name="pBanner">Objeto que contiene el banner a ser agregado</param>
        public void AgregarBanner(Banner pBanner)
        {
            if (iServicio.BannerDisponible(pBanner, this.ObtenerBanners()))
            {
                this.iUnitOfWork.BannerRepository.Insert(pBanner);
                this.iUnitOfWork.Save();
            }
            else
            {
                throw new BannerNoDisponibleException("El banner no esta disponible en el rango horario especificado durante el rango de fechas dado");
            }            
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

        /// <summary>
        /// Metodo para obtener desde la interfaz de usuario, todos los banners almacenados en la BD
        /// </summary>
        /// <returns></returns>       
        public List<Banner> ObtenerBanners()
        {
            return this.iUnitOfWork.BannerRepository.Queryable.ToList<Banner>();
        }

        /// <summary>
        /// Metodo para obtener un banner en particular desde la BD
        /// </summary>
        /// <param name="pIdBanner">entero que contiene la id del banner a obtener</param>
        /// <returns></returns>
        public Banner ObtenerBanner(int pIdBanner)
        {
            return this.iUnitOfWork.BannerRepository.GetByID(pIdBanner);
        }

        /// <summary>
        /// Metodo para obtener lista banners entre fecha de inicio y fecha de fin
        /// </summary>
        /// <param name="pFechaInicio">FechaInicio de los banners buscadas</param>
        /// <param name="pFechaFin">FechaInicio de los banners buscadas</param>
        /// <returns>Lista de banners entre fechas</returns>
        public List<Banner> ObtenerBanners(DateTime pFechaInicio, DateTime pFechaFin)
        {
            //Obtenemos todas las imagenes de la campaña
            IQueryable<Banner> banners = this.ObtenerBanners().AsQueryable<Banner>();
            var bannersFechas = banners.Where(p => p.iFechaInicio >= pFechaInicio && p.iFechaFin <= pFechaFin);
            return bannersFechas.ToList<Banner>();
        }

        /// <summary>
        /// Metodo para obtener lista banners entre hora de inicio y hora de fin
        /// </summary>
        /// <param name="pHoraInicio">HoraInicio de las banners buscadas</param>
        /// <param name="pHoraFin">HoraFin de las banners buscadas</param>
        /// <returns>Lista de banners entre horas</returns>
        public List<Banner> ObtenerBanners(TimeSpan pHoraInicio, TimeSpan pHoraFin)
        {
            //Obtenemos todos los banners 
            IQueryable<Banner> banners = this.ObtenerBanners().AsQueryable<Banner>();

            //Buscamos los banners que posean su intervalo horario dentro el intervalo de busqueda
            var bannersHoras = banners.Where(p => p.iHoraInicio >= pHoraInicio && p.iHoraFin <= pHoraFin);

            //Buscamos las campañas que posean al menos la hora de inicio entre el intervalo de busqueda
            var bannersHoras2 = banners.Where(p => p.iHoraInicio <= pHoraInicio && p.iHoraFin >= pHoraInicio);

            //Buscamos las campañas que posean al menos la hora de fin entre el intervalo de busqueda
            var bannersHoras3 = banners.Where(p => p.iHoraInicio <= pHoraFin && p.iHoraFin >= pHoraFin);

            //Concatenamos todos los resultados en una unica lista.
            bannersHoras = bannersHoras.Concat(bannersHoras2);
            bannersHoras = bannersHoras.Concat(bannersHoras3);

            //eliminamos resultados repetidos
            IQueryable<Banner> bannersResultado = (from banner in bannersHoras select banner).Distinct();

            return bannersResultado.ToList<Banner>();
        }

        /// <summary>
        /// Devuelve el banner activo para la pantalla seleccionada. Si no existe un banner activo devuelve un banner vacio
        /// </summary>
        /// <returns></returns>
        public Banner bannerActivo()
        {            
            Banner Bann = null;
            List<Banner> lista = iUnitOfWork.BannerRepository.Queryable.Where(b => b.iFechaInicio != null).ToList();
            foreach (Banner b in lista)
            {
                if (b.iFechaInicio <= DateTime.Now.Date && b.iFechaFin >= DateTime.Now.Date)
                {
                    if (b.iHoraInicio <= DateTime.Now.TimeOfDay && b.iHoraFin >= DateTime.Now.TimeOfDay)
                    {
                       return Bann = b;
                    }
                }
            }
            return Bann;            
        }

        #endregion

    }
}
