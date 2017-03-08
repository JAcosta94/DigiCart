using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Campaña
    {

        #region Región: Atributos
        /// <summary>
        /// Atributo identificador de la campaña
        /// </summary>
        public int iIdCampaña { get; set; }

        /// <summary>
        /// Atributo que contiene nombre de la campaña
        /// </summary>
        public string iNombre { get; set; }

        /// <summary>
        /// Atributo que contiene la fecha de inicio de la campaña
        /// </summary>
        public DateTime iFechaInicio { get; set; }

        /// <summary>
        /// Atributo que contiene la fecha de finalizacion de la campaña
        /// </summary>
        public DateTime iFechaFin { get; set; }
        
        /// <summary>
        /// Atributo que contiene la hora de inicio de la campaña
        /// </summary>
        public TimeSpan iHoraInicio { get; set; }
        
        /// <summary>
        /// Atributo que contiene la hora de finalizacion de la campaña
        /// </summary>
        public TimeSpan iHoraFin { get; set; }

        /// <summary>
        /// Lista de las imagenes de la campaña.
        /// </summary>
        public IList<Imagen> iImagenes { get; set; }
              
        #endregion               

        /// <summary>
        /// Constructor de una instancia de la clase campaña .
        /// </summary>
        public Campaña() { }

    }
}
