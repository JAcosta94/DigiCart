using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
   public class CampañaNoDisponibleException : Exception
    {

        public CampañaNoDisponibleException(string Mensaje) : base(Mensaje) { }
    }
}
