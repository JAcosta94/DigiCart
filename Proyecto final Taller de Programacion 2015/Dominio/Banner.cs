using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Banner
    {
        #region Región: Atributos
        
        [Key]
        /// <summary>
        /// Atributo que contiene la id del banner
        /// </summary>
        public int iIdBanner { get; set; }

        /// <summary>
        /// Atributo que contiene el nombre del banner
        /// </summary>
        public string iNombre { get; set; }

        /// <summary>
        /// Atributo que contiene la hora de inicio del banner
        /// </summary>
        public TimeSpan iHoraInicio { get; set; }

        /// <summary>
        /// Atributo que contiene la hora de finalizacion del banner
        /// </summary>
        public TimeSpan iHoraFin { get; set; }

        /// <summary>
        /// Atributo que contiene la fecha de inicio del banner
        /// </summary>
        public DateTime iFechaInicio { get; set; }

        /// <summary>
        /// Atributo que contiene la fecha de finalizacion del banner
        /// </summary>
        public DateTime iFechaFin { get; set; }

        /// <summary>
        /// Atributo de tipo interfaz que indica si el banner es Texto Fijo o Fuente RSS
        /// </summary>
        public ITipoBanner iTipoBanner { get; set; }
        #endregion

        /// <summary>
        /// Constructor de una instancia de la clase Banner .
        /// </summary>
        public Banner() { }
    }
}
