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
    public class ControladorCampaña
    {
        private UnitOfWork iUnitOfWork;
        private ServicioDisponibilidad iServicio;

        #region Metodos controlador

        /// <summary>
        /// Constructor del controlador de campañas
        /// </summary>
        public ControladorCampaña()
        {
            this.iServicio = new ServicioDisponibilidad();
            this.iUnitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// Metodo para agregar una campaña a la base de datos desde la interfaz de usuario
        /// </summary>
        /// <param name="pCampaña">Campaña a agregar</param>
        public void AgregarCampaña(Campaña pCampaña)
        {

            if (iServicio.CampañaDisponible(pCampaña, this.ObtenerCampañas()))
            {
                iUnitOfWork.CampañaRepository.Insert(pCampaña);
                iUnitOfWork.Save();
            }
            else
            {
                throw new CampañaNoDisponibleException("La campaña no esta disponible en el rango horario especificado durante el rango de fechas dado");
            }
        }

        /// <summary>
        /// Metodo para modificar una campaña en la base de datos desde la interfaz de usuario
        /// </summary>
        /// <param name="pCampaña">campaña a modificar</param>
        public void ModificarCampaña(Campaña pCampaña)
        {
            if (iServicio.CampañaDisponible(pCampaña, this.ObtenerCampañas()))
            {
                this.iUnitOfWork.CampañaRepository.Update(pCampaña);
                this.iUnitOfWork.Save();
            }

            else
            {
                throw new CampañaNoDisponibleException("La campaña no esta disponible en el rango horario especificado durante el rango de fechas dado");
            }

        }      

        /// <summary>
        /// Metodo para obtener una campaña a partir de su id
        /// /// </summary>
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
        public List<Campaña> ObtenerCampañas()
        {
            return iUnitOfWork.CampañaRepository.Queryable.ToList<Campaña>();
        }

        /// <summary>
        /// Metodo para obtener lista campañas entre fecha de inicio y fecha de fin
        /// </summary>
        /// <param name="pFechaInicio">FechaInicio de las campañas buscadas</param>
        /// <param name="pFechaFin">FechaInicio de las campañas buscadas</param>
        /// <returns>Lista de campañas entre fechas</returns>
        public List<Campaña> ObtenerCampañas(DateTime pFechaInicio, DateTime pFechaFin)
        {
            //Obtenemos todas las imagenes de la campaña
            IQueryable<Campaña> campanias = this.ObtenerCampañas().AsQueryable<Campaña>();
            var campaniasFechas = campanias.Where(p => p.iFechaInicio >= pFechaInicio && p.iFechaFin <= pFechaFin);
            return campaniasFechas.ToList<Campaña>();
        }

        /// <summary>
        /// Metodo para obtener lista campañas entre hora de inicio y hora de fin
        /// </summary>
        /// <param name="pHoraInicio">HoraInicio de las campañas buscadas</param>
        /// <param name="pHoraFin">HoraFin de las campañas buscadas</param>
        /// <returns>Lista de campañas entre horas</returns>
        public List<Campaña> ObtenerCampañas(TimeSpan pHoraInicio, TimeSpan pHoraFin)
        {
            //Obtenemos todas las imagenes de la campaña
            IQueryable<Campaña> campanias = this.ObtenerCampañas().AsQueryable<Campaña>();
            
            //Buscamos las campañas que posean su intervalo horario dentro el intervalo de busqueda
            var campaniasHoras = campanias.Where(p => p.iHoraInicio >= pHoraInicio && p.iHoraFin <= pHoraFin);
            
            //Buscamos las campañas que posean al menos la hora de inicio entre el intervalo de busqueda
            var campaniasHoras2 = campanias.Where(p => p.iHoraInicio <= pHoraInicio && p.iHoraFin >= pHoraInicio);

            //Buscamos las campañas que posean al menos la hora de fin entre el intervalo de busqueda
            var campaniasHoras3 = campanias.Where(p => p.iHoraInicio <= pHoraFin && p.iHoraFin >= pHoraFin);

            //Concatenamos todos los resultados en una unica lista.
            campaniasHoras = campaniasHoras.Concat(campaniasHoras2);
            campaniasHoras = campaniasHoras.Concat(campaniasHoras3);

            //eliminamos resultados repetidos
            IQueryable<Campaña> campaniasResultado = (from campania in campaniasHoras select campania).Distinct();

            return campaniasResultado.ToList<Campaña>();
        }

        /// <summary>
        /// Devuelve la campaña que esta siendo publicitada, si no hay devuelve una vacia
        /// </summary>
        /// <returns></returns>
        public Campaña campañaActiva()
        {
            Campaña camp = new Campaña(); //Campaña vacia
            List<Campaña> lista = iUnitOfWork.CampañaRepository.Queryable.ToList(); //Todas las campañas
            foreach (Campaña c in lista)
            {
                if (c.iFechaInicio <= DateTime.Now.Date && c.iFechaFin >= DateTime.Now.Date) //Si coinciden las fechas
                {
                    if (c.iHoraInicio <= DateTime.Now.TimeOfDay && c.iHoraFin >= DateTime.Now.TimeOfDay) //Si coinciden sus horarios
                    {
                        return camp = c;    //Entra aqui se encontro una campaña
                    }
                }
            }
            return camp;    //Entra aqui si no se encontro ninguna campaña
        }

        #endregion 

    }
}
