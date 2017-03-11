using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    /// <summary>
    /// Clase utilizada para representar los datos de una imagen.
    /// </summary>
    public class Imagen
    {

        #region Atributos

            [Key]//Como el atributo no se llama ID (no respeta la convencion de EF) se agrega KEY para denotar que es la clave primaria
            /// <summary>
            /// Atributo identificador de la imagen.
            /// </summary>
             public int iIdImagen { get; set; }

            /// <summary>
            /// Atributo que contiene la ruta de la imagen dentro de la PC.
            /// </summary>
            public string iRuta { get; set; }

            /// <summary>
            /// Atributo que contiene la duracion de la imagen.
            /// </summary>
            public TimeSpan iDuracion { get; set; }

            /// <summary>
            /// Atributo que contiene la posicion de la imagen en la campaña.
            /// </summary>
            public int iPosicion { get; set; }
        #endregion
                
        /// <summary>
            /// Constructor de una instancia de la clase Imagen.
            /// </summary>
            public Imagen() { }
    }


}

