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
        public bool CampañaDisponible(Campaña pCampaña, List<Campaña> pListaCampañas)
        {
            bool result = true;            
            
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

        public bool BannerDisponible(Banner pBanner, List<Banner> pListaBanners)
        {
            bool result = true;
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

            public ServicioDisponibilidad()
            {}

        


    }
}
