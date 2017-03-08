using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class FuenteRSS: ITipoBanner
    {
        #region Región: Atributos
        /// <summary>
        /// Atributo identificador de la fuente RSS
        /// </summary>
        public int iIdRSS { get; set; }

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

        public string Texto { get; set; }
        #endregion        

        /// <summary>
        /// Constructor de una instancia de la clase FuenteRSS .
        /// </summary>
        public FuenteRSS() { }

        
        
        public void Actualizar(){}


    }
}

