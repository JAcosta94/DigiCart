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
            //Se utiliza para que la UOF haga Dispose luego de abandonar el scope
            using (UnitOfWork UOF = this.iUnitOfWork)
            {
                iUnitOfWork.CampañaRepository.Insert(pCampaña);
                iUnitOfWork.Save();
            }            
        }


        /// <summary>
        /// Metodo para modificar una campaña en la base de datos desde la interfaz de usuario
        /// </summary>
        /// <param name="pCampaña">campaña a modificar</param>
        public void ModificarCampaña(Campaña pCampaña)
        {
            //Se utiliza para que la UOF haga Dispose luego de abandonar el scope
            using (UnitOfWork UOF = this.iUnitOfWork)
            {
                iUnitOfWork.CampañaRepository.Update(pCampaña);
                iUnitOfWork.Save();        
            }            
        }

    }
}
