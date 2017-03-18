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
        public bool Disponible(Campaña pCampaña, IQueryable<Campaña> pListaCampañas )
        {
            bool result = true;
            IList<Campaña> campañas = pListaCampañas as List<Campaña>;

            if (pListaCampañas.Count() == 0)
            {
                return result;
            }

            else
            {
                IList<Campaña> CampañasComprometidas = new List<Campaña>();



                foreach(Campaña campañaGuardada in pListaCampañas)
                {
                    DateTime FechaInicio = campañaGuardada.iFechaInicio;
                    DateTime FechaFin = campañaGuardada.iFechaFin;
                   // int IdIntervalo = pListaCampañas.ElementAt(i).IdIntervalo;

                    if ((pCampaña.iIdCampaña != campañaGuardada.iIdCampaña) &&
                           ((pCampaña.iFechaInicio == FechaInicio & pCampaña.iFechaFin == FechaFin & pCampaña.iFechaFin >= FechaInicio) |
                            (pCampaña.iFechaInicio <= FechaInicio & pCampaña.iFechaFin >= FechaInicio & pCampaña.iFechaFin <= FechaFin) |
                            (pCampaña.iFechaInicio >= FechaInicio & pCampaña.iFechaInicio <= FechaFin & pCampaña.iFechaFin >= FechaFin) |
                            (pCampaña.iFechaInicio < FechaInicio & pCampaña.iFechaFin > FechaFin) |
                            (pCampaña.iFechaInicio > FechaInicio & pCampaña.iFechaFin < FechaFin)))
                    {


                        CampañasComprometidas.Add(campañaGuardada);
                    }
                }

                if (CampañasComprometidas.Count > 0)
                {
                    foreach (Campaña campañaComprometida in CampañasComprometidas)
                    {
                        

                        if (
                            ((pCampaña.iHoraInicio >= campañaComprometida.iHoraInicio) &&
                                (pCampaña.iHoraInicio < campañaComprometida.iHoraFin) &&
                                (pCampaña.iHoraFin >= campañaComprometida.iHoraFin))
                               ||
                            ((pCampaña.iHoraInicio <= campañaComprometida.iHoraInicio) &&
                                (pCampaña.iHoraFin > campañaComprometida.iHoraInicio) &&
                                (pCampaña.iHoraFin <= campañaComprometida.iHoraFin))
                               ||
                            ((pCampaña.iHoraInicio < campañaComprometida.iHoraInicio) &&
                              (pCampaña.iHoraFin > campañaComprometida.iHoraFin))
                               ||
                            ((pCampaña.iHoraInicio > campañaComprometida.iHoraInicio) &&
                                (pCampaña.iHoraFin < campañaComprometida.iHoraFin))
                              )
                        {
                            //Si se da alguno de los casos es porque no esta disponible en ese rango horario
                            // algunos de los casos son (Hi hora inicio, Hf hora fin): 
                            // Hi1 Hi2 Hf1 Hf2  
                            // Hi2 Hi1 Hf2 Hi2
                            // Hi1=Hi2 Hf1=Hf2
                            // Hi1=Hi2 Hf1 Hf2
                            // Hi1 Hi2 Hf2 Hf1
                            // Hi2 Hi1 Hf1 Hf2

                            result = false;
                            break;
                        }
                    }
                }

                return result;
            }
        }

            public ServicioDisponibilidad()
            {}

        


    }
}
