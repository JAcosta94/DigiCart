using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    /// <summary>
    /// Excepcion utilizada cuando una campaña no esta disponible en un rango de fechas y horario determinado
    /// </summary>
   public class CampañaNoDisponibleException : Exception
    {

        public CampañaNoDisponibleException(string Mensaje) : base(Mensaje) { }
    }
}
