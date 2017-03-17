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
            this.iUnitOfWork.CampañaRepository.Update(pCampaña);
            this.iUnitOfWork.Save();                                
        }
       

        /// <summary>
        /// Metodo para obtener todas las imagenes de una campaña
        /// </summary>
        /// <param name="pIdCampaña">entero que representa la id de la campaña que se desea obtener</param>
        /// <returns>regresa una campaña</returns>
        public Campaña ObtenerCampaña(int pIdCampaña) 
        {
            return this.iUnitOfWork.CampañaRepository.GetByID(pIdCampaña);            
        }        

        /// <summary>
        /// Metodo para eliminar una campaña de la base de datos desde la interfaz de usuario
        /// </summary>
        /// <param name="pCampañaId">entero que representa la id de la campaña a borrar</param>
        public void EliminarCampaña(int pCampañaId)
        {
            this.iUnitOfWork.CampañaRepository.Delete(pCampañaId);
            this.iUnitOfWork.Save();
        
        }
        
        /// <summary>
        /// Metodo para obtener todas las campañas almacenadas en la base de datos
        /// </summary>
        /// <returns></returns>
        public IQueryable<Campaña> ObtenerCampañas()
        {
            return iUnitOfWork.CampañaRepository.Queryable;
        }

        /// <summary>
        /// Metodo para obtener lista campañas entre fecha de inicio y fecha de fin
        /// </summary>
        /// <param name="pFechaInicio">FechaInicio de las campañas buscadas</param>
        /// <param name="pFechaFin">FechaInicio de las campañas buscadas</param>
        /// <returns>Lista de campañas entre fechas</returns>
        public IQueryable<Campaña> ObtenerCampañas(DateTime pFechaInicio, DateTime pFechaFin)
        {
            //Obtenemos todas las imagenes de la campaña
            IQueryable<Campaña> campanias = this.ObtenerCampañas();
            var campaniasFechas = campanias.Where(p => p.iFechaInicio >= pFechaInicio && p.iFechaFin <= pFechaFin);
            return campaniasFechas;
        }

        /// <summary>
        /// Metodo para obtener lista campañas entre hora de inicio y hora de fin
        /// </summary>
        /// <param name="pHoraInicio">HoraInicio de las campañas buscadas</param>
        /// <param name="pHoraFin">HoraFin de las campañas buscadas</param>
        /// <returns>Lista de campañas entre horas</returns>
        public IQueryable<Campaña> ObtenerCampañas(TimeSpan pHoraInicio, TimeSpan pHoraFin)
        {
            //Obtenemos todas las imagenes de la campaña
            IQueryable<Campaña> campanias = this.ObtenerCampañas();
            var campaniasHoras = campanias.Where(p => p.iHoraInicio >= pHoraInicio && p.iHoraFin <= pHoraFin);
            return campaniasHoras;
        }

    }
}
