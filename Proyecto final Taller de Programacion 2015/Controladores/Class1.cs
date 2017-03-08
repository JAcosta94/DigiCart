using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Dominio;

namespace Controladores
{
    public class FachadaABM
    {
        private UnitOfWork iUnitOfWork;


        public void AgregarCampaña(Campaña pCampaña)
        {
            iUnitOfWork.CampañaRepository.Insert(pCampaña);
           
        }

    }
}
