using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    //Clase que representa el texto fijo de un banner
    class FuenteTextoFijo : ITipoBanner
    {
        [Key]
        private int iIdTextoFijo { get; set; }
        public string Texto { get; set; }
        public void Actualizar() { }

    }
}
