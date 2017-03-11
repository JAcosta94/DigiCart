using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Persistencia;

namespace Controladores
{
    public class ControladorImagen
    {       
        private UnitOfWork iUnitOfWork;

        /// <summary>
        /// Constructor de la fachada
        /// </summary>
        public ControladorImagen()
        {
            this.iUnitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// Metodo para agregar una Imagen a la base de datos desde la interfaz de usuario
        /// </summary>
        /// <param name="pImagen">Imagen a agregar</param>
        public void AgregarImagen(Imagen pImagen)
        {
            //Se utiliza para que la UOF haga Dispose luego de abandonar el scope
            using (UnitOfWork UOF = this.iUnitOfWork)
            {
                iUnitOfWork.ImagenRepository.Insert(pImagen);
                iUnitOfWork.Save();
            }            
        }

        /// <summary>
        /// Metodo para modificar una imagen en la base de datos desde la interfaz de usuario
        /// </summary>
        /// <param name="pImagen">Imagen a modificar</param>
        public void ModificarImagen(Imagen pImagen)
        {
             //Se utiliza para que la UOF haga Dispose luego de abandonar el scope
            using (UnitOfWork UOF = this.iUnitOfWork)
            {
                iUnitOfWork.ImagenRepository.Update(pImagen);
                iUnitOfWork.Save();
            }
        }


    }
}
