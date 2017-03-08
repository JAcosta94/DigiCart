using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class FuenteTextoFijo : ITipoBanner
    {
        private int iIdTextoFijo { get; set; }
        public string Texto { get; set; }
        public void Actualizar() { }

    }
}
