using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    //Clase que representa el texto fijo de un banner
    public class FuenteTextoFijo : IFuente
    {
        #region Atributos

        //Como el atributo no se llama ID (no respeta la convencion de EF) se agrega KEY para denotar que es la clave primaria
        [Key]
        public int iIdTextoFijo { get; set; }
        public string Tipo { get; set; }
        public string Texto { get; set; }
        #endregion

        public void Actualizar() { }

    }
}
