using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class BannerNoDisponibleException : Exception
    {
        public BannerNoDisponibleException(string Mensaje) : base(Mensaje) { }
    }
}
