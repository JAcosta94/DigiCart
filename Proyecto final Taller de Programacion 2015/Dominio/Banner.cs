using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Banner
    {
        #region Región: Atributos
        /// <summary>
        /// Atributo que contiene la id del banner
        /// </summary>
        private int iIdBanner;

        /// <summary>
        /// Atributo que contiene el nombre del banner
        /// </summary>
        private string iNombre;

        /// <summary>
        /// Atributo que contiene la hora de inicio del banner
        /// </summary>
        private TimeSpan iHoraInicio;

        /// <summary>
        /// Atributo que contiene la hora de finalizacion del banner
        /// </summary>
        private TimeSpan iHoraFin;

        /// <summary>
        /// Atributo que contiene la fecha de inicio del banner
        /// </summary>
        private DateTime iFechaInicio;

        /// <summary>
        /// Atributo que contiene la fecha de finalizacion del banner
        /// </summary>
        private DateTime iFechaFin;

        /// <summary>
        /// Atributo de tipo interfaz que indica si el banner es Texto Fijo o Fuente RSS
        /// </summary>
        private ITipoBanner iTipoBanner;

        /// <summary>
        /// Atributo que contiene o no el texto fijo del banner
        /// </summary>
        private string iTextoFijo;

        /// <summary>
        /// Atributo que contiene o no la id de la fuente rss que usa el banner
        /// </summary>
        private int? iFuenteRSSId;
        #endregion

        #region Región: Propiedades
        /// <summary>
        /// Propiedad de lectura y escritura de la id del banner.
        /// </summary>
        public int IdBanner
        {
            get { return this.iIdBanner; }
            set { this.iIdBanner = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del nombre del banner.
        /// </summary>
        public string Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura de la hora de inicio del banner.
        /// </summary>
        public TimeSpan HoraInicio
        {
            get { return this.iHoraInicio; }
            set { this.iHoraInicio = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura de la hora de finalizacion del banner.
        /// </summary>
        public TimeSpan HoraFin
        {
            get { return this.iHoraFin; }
            set { this.iHoraFin = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura de la fecha de inicio de la banner
        /// </summary>
        public DateTime FechaInicio
        {
            get { return this.iFechaInicio; }
            set { this.iFechaInicio = value; }        
        }

        /// <summary>
        /// Propiedad de lectura y escritura de la fecha de inicio de la banner
        /// </summary>
        public DateTime FechaFin
        {
            get { return this.iFechaFin; }
            set { this.iFechaFin = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del texto fijo
        /// </summary>
        public string TextoFijo 
        {
            get { return this.iTextoFijo; }
            set { this.iTextoFijo = value; }

        }

        /// <summary>
        /// Propiedad de lectura y escritura de la id de la fuente rss que usa el banner
        /// </summary>
        public int? FuenteRSSId 
        {
            get { return this.iFuenteRSSId; }
            set { this.iFuenteRSSId = value; }
        }
        #endregion

        /// <summary>
        /// Constructor de una instancia de la clase Banner .
        /// </summary>
        public Banner() { }
    }
}
