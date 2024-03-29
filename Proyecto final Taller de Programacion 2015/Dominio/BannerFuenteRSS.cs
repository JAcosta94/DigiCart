﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class BannerFuenteRSS: Banner
    {
        #region Atributos       

        /// <summary>
        /// Atributo que contiene la fuente rss
        /// </summary>
        public int iIdFuenteRSS { get; set; }

        [ForeignKey("iIdFuenteRSS")]
        /// <summary>
        /// Atributo que contiene la fuente rss
        /// </summary>        
        public virtual FuenteRSS iFuenteRSS { get; set; }

        #endregion        

        /// <summary>
        /// Constructor de una instancia de la clase BannerFuenteRSS .
        /// </summary>
        public BannerFuenteRSS() { }     

    }
}

