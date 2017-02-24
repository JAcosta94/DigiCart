using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class FuenteRSS
    {
        #region Región: Atributos
        /// <summary>
        /// Atributo identificador de la fuente RSS
        /// </summary>
        private int iIdRSS;

        /// <summary>
        /// Atributo que contiene la URL de la fuente RSS
        /// </summary>
        private string iUrl;

        /// <summary>
        /// Atributo que contiene la descripcion de la fuente RSS
        /// </summary>
        private string iDescripcion;

        /// <summary>
        /// Atributo que contiene todos los feeds que se obtuvieron la ultima vez que se uso la fuente RSS.
        /// </summary>
        private string iUltimaObtencionDeFeeds;
        #endregion        

        #region Región: Propiedades
        /// <summary>
        /// Propiedad de lectura y escritura de la id de la fuente rss.
        /// </summary>
        public int Id
        {
            get { return this.iIdRSS; }
            set { this.iIdRSS = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura de la descripcion de la fuente rss.
        /// </summary>
        public string Descripcion
        {
            get { return this.iDescripcion; }
            set { this.iDescripcion = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura de la URL de la campaña.
        /// </summary>
        public string Url
        {
            get { return this.iUrl; }
            set { this.iUrl = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura de la ultima obtencion de la fuente rss
        /// </summary>
        public string UltimaObtencionFeeds
        {
            get { return this.iUltimaObtencionDeFeeds; }
            set { this.iUltimaObtencionDeFeeds = value; }
        
        }
        #endregion

        /// <summary>
        /// Constructor de una instancia de la clase FuenteRSS .
        /// </summary>
        public FuenteRSS() { }

    }
}

