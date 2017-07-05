using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Servicio_FuenteRSS
{
    public class ServicioDisponibilidad
    {
        /// <summary>
        /// Metodo para verificar si una campaña esta disponible en un rango de fechas y horario.
        /// </summary>
        /// <param name="pCampaña">campaña a verificar la disponibilidad</param>
        /// <param name="pListaCampañas">campañas actuales en la bd</param>
        /// <returns></returns>
        public bool CampañaDisponible(Campaña pCampaña, List<Campaña> pListaCampañas)
        {
            bool result = true;

            pListaCampañas.Remove(pCampaña);
            
            //IQueryable<Campaña> campañas = pListaCampañas.AsQueryable<Campaña>();
            foreach (Campaña c in pListaCampañas)
            {
                if (((c.iFechaInicio <= pCampaña.iFechaInicio && c.iFechaFin >= pCampaña.iFechaInicio)
                    || (c.iFechaFin <= pCampaña.iFechaFin && c.iFechaFin >= pCampaña.iFechaFin))
                    || (pCampaña.iFechaFin <= c.iFechaInicio) && (pCampaña.iFechaFin >= c.iFechaFin))
                {
                    if (((c.iHoraInicio <= pCampaña.iHoraInicio && c.iHoraFin >= pCampaña.iHoraInicio)
                        || (c.iHoraFin >= pCampaña.iHoraFin && c.iHoraInicio <= pCampaña.iHoraFin))
                        || (pCampaña.iHoraInicio <= c.iHoraInicio && pCampaña.iHoraFin >= c.iHoraFin))
                    {
                        return (result = false);                        
                    }
                }
            }
            return result;            
        }

        /// <summary>
        /// Metodo para verificar si un banner esta disponible en un rango de fechas y horario.
        /// </summary>
        /// <param name="pBanner">banner a comprobar la disponibilidad</param>
        /// <param name="pListaBanners">banners actuales en la bd</param>
        /// <returns></returns>
        public bool BannerDisponible(Banner pBanner, List<Banner> pListaBanners)
        {
            bool result = true;
            pListaBanners.Remove(pBanner);

            foreach (Banner b in pListaBanners)
            {
                if (((b.iFechaInicio <= pBanner.iFechaInicio && b.iFechaFin >= pBanner.iFechaInicio)
                    || (b.iFechaFin <= pBanner.iFechaFin && b.iFechaFin >= pBanner.iFechaFin))
                    || (pBanner.iFechaFin <= b.iFechaInicio) && (pBanner.iFechaFin >= b.iFechaFin))
                {
                    if (((b.iHoraInicio <= pBanner.iHoraInicio && b.iHoraFin >= pBanner.iHoraInicio)
                        || (b.iHoraFin >= pBanner.iHoraFin && b.iHoraInicio <= pBanner.iHoraFin))
                        || (pBanner.iHoraInicio <= b.iHoraInicio && pBanner.iHoraFin >= b.iHoraFin))
                    {
                        return (result = false);
                    }
                }
            }
            return result;            
        }

        /// <summary>
        /// Constructor del servicio disponibilidad
        /// </summary>
        public ServicioDisponibilidad(){}        
    }
}
