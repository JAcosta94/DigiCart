using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Controladores
{
    public class ControladorBanner
    {
        private UnitOfWork iUnitOfWork;

        /// <summary>
        /// Constructor de la fachada
        /// </summary>
        public ControladorBanner()
        {
            this.iUnitOfWork = new UnitOfWork();
        }
    }
}
