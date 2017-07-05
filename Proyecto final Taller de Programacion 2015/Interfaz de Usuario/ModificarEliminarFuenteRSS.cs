using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;
using Dominio;
using System.Data.Entity.Infrastructure;
//using Excepciones;

namespace WindowsFormsApplication
{
    public partial class ModificarEliminarFuenteRSS : Form
    {        
        private ControladorFuenteBanner iFachadaFuente;
        
        public ModificarEliminarFuenteRSS()
        {
            this.iFachadaFuente = new ControladorFuenteBanner();
            InitializeComponent();            
        }
        

        private void rb_url_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_descripcion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarEliminarFuenteRSS_Load(object sender, EventArgs e)
        {
            DGV_Fuentes.AutoGenerateColumns = false;
            DGV_Fuentes.MultiSelect = false;
            
            IQueryable<FuenteRSS> fuentes = iFachadaFuente.ObtenerFuentesRSS();

            foreach (FuenteRSS fuente in fuentes)
            {
                DGV_Fuentes.Rows.Add(fuente.iIdFuenteRSS, fuente.iDescripcion, fuente.iUrl);

            }         
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            //Obtiene la fuente a modificar a partir del ID de la grilla
            FuenteRSS fuente = iFachadaFuente.ObtenerFuenteRSS(Convert.ToInt32(DGV_Fuentes.CurrentRow.Cells[0].Value));

            // Abre el formulario de alta de fuente tomando los datos de la fuente a modificar
            AgregarFuenteRSS fuenteRSSInterfaz = new AgregarFuenteRSS(fuente);
            fuenteRSSInterfaz.ShowDialog();
            
            DGV_Fuentes.Refresh();

            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;

            this.Close();

        
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
         
        }


        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idFuenteAEliminar = Convert.ToInt32(DGV_Fuentes.CurrentRow.Cells[0].Value);
                iFachadaFuente.EliminarFuenteRSS(idFuenteAEliminar);

                //Actualizamos la grilla
                DGV_Fuentes.Rows.Remove((DGV_Fuentes.CurrentRow));
                MessageBox.Show("La fuente fue eliminada con exito!");
                DGV_Fuentes.Refresh();

                btn_modificar.Enabled = false;
                btn_eliminar.Enabled = false;
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Error! La Fuente RSS a eliminar esta asociada a uno o mas banners");
            }      

        }

        private void DGV_Fuentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (iBanner == null)
            //{
            //    btn_eliminar.Enabled = true;
            //    btn_modificar.Enabled = true;
            //}
        }

        

       

        

        
       
       
    }
}
