using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    /// <summary>
    /// Excepcion utilizada cuando un banner no esta disponible en un rango horario y de fechas determinado
    /// </summary>
    public class BannerNoDisponibleException : Exception
    {
        public BannerNoDisponibleException(string Mensaje) : base(Mensaje) { }
    }
}
