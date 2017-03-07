using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    /// <summary>
    /// Clase utilizada para representar los datos de una imagen.
    /// </summary>
    public class Imagen
    {

        #region Región: Atributos
        /// <summary>
            /// Atributo identificador de la imagen.
            /// </summary>
            private int iIdImagen;

            /// <summary>
            /// Atributo que contiene la ruta de la imagen dentro de la PC.
            /// </summary>
            private string iRuta;

            /// <summary>
            /// Atributo que contiene la duracion de la imagen.
            /// </summary>
            private TimeSpan iDuracion;

            /// <summary>
            /// Atributo que contiene la posicion de la imagen en la campaña.
            /// </summary>
            private int iPosicion;
        #endregion
            
        #region Región: Propiedades
            /// <summary>
            /// Propiedad de lectura y escritura de la id de la imagen.
            /// </summary>
            public int Id
            {
                get { return this.iIdImagen; }
                set { this.iIdImagen = value; }
            }

            /// <summary>
            /// Propiedad de lectura y escritura de la ruta de la imagen.
            /// </summary>
            public string RutaImagen
            {
                get { return this.iRuta; }
                set { this.iRuta = value; }
            }

            /// <summary>
            /// Propiedad de lectura y escritura de la duracion de la imagen.
            /// </summary>
            public TimeSpan Duracion
            {
                get { return this.iDuracion; }
                set { this.iDuracion = value; }
            }
   
            /// <summary>
            /// Propiedad de lectura y escritura de la posicion de la imagen en la campaña.
            /// </summary>
            public int Posicion
            {
                get { return this.iPosicion; }
                set { this.iPosicion = value; }
            }
            #endregion
            
        
        /// <summary>
            /// Constructor de una instancia de la clase Imagen .
            /// </summary>
            public Imagen() { }
    }


}

