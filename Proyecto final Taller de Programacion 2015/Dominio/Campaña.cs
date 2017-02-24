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
        private int iIdCampaña;

        /// <summary>
        /// Atributo que contiene la fecha de inicio de la campaña
        /// </summary>
        private DateTime iFechaInicio;

        /// <summary>
        /// Atributo que contiene la fecha de finalizacion de la campaña
        /// </summary>
        private DateTime iFechaFin;
        
        /// <summary>
        /// Atributo que contiene la hora de inicio de la campaña
        /// </summary>
        private TimeSpan iHoraInicio;
        
        /// <summary>
        /// Atributo que contiene la hora de finalizacion de la campaña
        /// </summary>
        private TimeSpan iHoraFin;

        /// <summary>
        /// Lista de las imagenes de la campaña.
        /// </summary>
        private IList<Imagen> iImagenes;
        
        /// <summary>
        /// Atributo que contiene nombre de la campaña
        /// </summary>
        private string iNombre;
        #endregion       

        #region Región: Propiedades
        /// <summary>
        /// Propiedad de lectura y escritura de la id de la campaña.
        /// </summary>
        public int Id
        {
            get { return this.iIdCampaña; }
            set { this.iIdCampaña = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura de la hora de inicio de la campaña.
        /// </summary>
        public TimeSpan HoraInicio
        {
            get { return this.iHoraInicio; }
            set { this.iHoraInicio = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura de la hora de finalizacion de la campaña.
        /// </summary>
        public TimeSpan HoraFin
        {
            get { return this.iHoraFin; }
            set { this.iHoraFin = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura de las imagenes de la campaña.
        /// </summary>
        public IList<Imagen> Imagenes
        {
            get { return this.iImagenes; }
            set { this.iImagenes = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura de la fecha de inicio de la campaña
        /// </summary>
        public DateTime FechaInicio
        {
            get { return this.iFechaInicio; }
            set { this.iFechaInicio = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura de la fecha de inicio de la campaña
        /// </summary>
        public DateTime FechaFin
        {
            get { return this.iFechaFin; }
            set { this.iFechaFin = value; }
        }

        public string Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }
        #endregion

        /// <summary>
        /// Constructor de una instancia de la clase campaña .
        /// </summary>
        public Campaña() { }

    }
}
