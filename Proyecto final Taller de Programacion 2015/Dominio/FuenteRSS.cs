using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class FuenteRSS
    {
        #region Atributos
        [Key]
        /// <summary>
        /// Atributo que contiene la id de la fuente RSS
        /// </summary>
        public int iIdFuenteRSS { get; set; }
        

        /// <summary>
        /// Atributo que contiene la URL de la fuente RSS
        /// </summary>
        public string iUrl { get; set; }

        /// <summary>
        /// Atributo que contiene la descripcion de la fuente RSS
        /// </summary>
        public string iDescripcion { get; set; }

        /// <summary>
        /// Atributo que contiene todos los feeds que se obtuvieron la ultima vez que se uso la fuente RSS.
        /// </summary>
        public string iUltimaObtencionDeFeeds { get; set; }

        #endregion

        /// <summary>
        /// Contructor de una fuente rss
        /// </summary>
        public FuenteRSS() { }
    }
}
