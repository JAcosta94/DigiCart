﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public interface ITipoBanner
    {
        
        //string Texto { get; set; }
        
        /// <summary>
        /// Modifica el contenido del banner.
        /// </summary>
        void Actualizar();
    }
}
