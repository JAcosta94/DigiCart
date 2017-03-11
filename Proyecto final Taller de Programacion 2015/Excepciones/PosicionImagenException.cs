using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    /// <summary>
    /// Excepcion que representa un error en la posicion de una imagen en la campaña. Como por ejemplo si 
    /// quisiesemos poner Posicion -1
    /// </summary>
    public class PosicionImagenException : Exception
    {

        public PosicionImagenException(string Mensaje) : base(Mensaje) { }

    }
}
