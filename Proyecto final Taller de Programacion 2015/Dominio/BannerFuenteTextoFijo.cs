using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    //Clase que representa el banner con un texto fijo
    public class BannerFuenteTextoFijo : Banner
    {
        #region Atributos
        

        public string TextoFijo { get; set; }
        #endregion

        /// <summary>
        /// Constructor de una instancia de la clase BannerFuenteTextoFijo .
        /// </summary>
        public BannerFuenteTextoFijo() { }
        
    }
}
