namespace WindowsFormsApplication
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empezarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bannersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoBannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificar_eliminarBannerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campañasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCampañaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCampañaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuentesRSSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaFuenteRSSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarFuenteRSSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.configuracionesToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empezarToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // empezarToolStripMenuItem
            // 
            this.empezarToolStripMenuItem.Name = "empezarToolStripMenuItem";
            this.empezarToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.empezarToolStripMenuItem.Text = "Empezar.";
            this.empezarToolStripMenuItem.Click += new System.EventHandler(this.empezarToolStripMenuItem_Click);
            // 
            // configuracionesToolStripMenuItem
            // 
            this.configuracionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bannersToolStripMenuItem,
            this.campañasToolStripMenuItem,
            this.fuentesRSSToolStripMenuItem});
            this.configuracionesToolStripMenuItem.Name = "configuracionesToolStripMenuItem";
            this.configuracionesToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.configuracionesToolStripMenuItem.Text = "Administración";
            this.configuracionesToolStripMenuItem.Click += new System.EventHandler(this.configuracionesToolStripMenuItem_Click);
            // 
            // bannersToolStripMenuItem
            // 
            this.bannersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoBannerToolStripMenuItem,
            this.modificar_eliminarBannerMenuItem});
            this.bannersToolStripMenuItem.Name = "bannersToolStripMenuItem";
            this.bannersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bannersToolStripMenuItem.Text = "Banners";
            // 
            // nuevoBannerToolStripMenuItem
            // 
            this.nuevoBannerToolStripMenuItem.Name = "nuevoBannerToolStripMenuItem";
            this.nuevoBannerToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.nuevoBannerToolStripMenuItem.Text = "Nuevo banner";
            this.nuevoBannerToolStripMenuItem.Click += new System.EventHandler(this.nuevoBannerToolStripMenuItem_Click);
            // 
            // modificar_eliminarBannerMenuItem
            // 
            this.modificar_eliminarBannerMenuItem.Name = "modificar_eliminarBannerMenuItem";
            this.modificar_eliminarBannerMenuItem.Size = new System.Drawing.Size(207, 22);
            this.modificar_eliminarBannerMenuItem.Text = "Modificar/Eliminar Banner(s)";
            this.modificar_eliminarBannerMenuItem.Click += new System.EventHandler(this.modificar_eliminarBannerMenuItem_Click);
            // 
            // campañasToolStripMenuItem
            // 
            this.campañasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCampañaToolStripMenuItem,
            this.modificarCampañaToolStripMenuItem});
            this.campañasToolStripMenuItem.Name = "campañasToolStripMenuItem";
            this.campañasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.campañasToolStripMenuItem.Text = "Campañas";
            // 
            // crearCampañaToolStripMenuItem
            // 
            this.crearCampañaToolStripMenuItem.Name = "crearCampañaToolStripMenuItem";
            this.crearCampañaToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.crearCampañaToolStripMenuItem.Text = "Nueva campaña";
            this.crearCampañaToolStripMenuItem.Click += new System.EventHandler(this.crearCampañaToolStripMenuItem_Click);
            // 
            // modificarCampañaToolStripMenuItem
            // 
            this.modificarCampañaToolStripMenuItem.Name = "modificarCampañaToolStripMenuItem";
            this.modificarCampañaToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.modificarCampañaToolStripMenuItem.Text = "Modificar/Eliminar Campaña(s)";
            this.modificarCampañaToolStripMenuItem.Click += new System.EventHandler(this.modificarCampañaToolStripMenuItem_Click);
            // 
            // fuentesRSSToolStripMenuItem
            // 
            this.fuentesRSSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaFuenteRSSToolStripMenuItem,
            this.modificarFuenteRSSToolStripMenuItem});
            this.fuentesRSSToolStripMenuItem.Name = "fuentesRSSToolStripMenuItem";
            this.fuentesRSSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fuentesRSSToolStripMenuItem.Text = "Fuentes RSS";
            // 
            // nuevaFuenteRSSToolStripMenuItem
            // 
            this.nuevaFuenteRSSToolStripMenuItem.Name = "nuevaFuenteRSSToolStripMenuItem";
            this.nuevaFuenteRSSToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.nuevaFuenteRSSToolStripMenuItem.Text = "Nueva(s) fuente(s) RSS";
            this.nuevaFuenteRSSToolStripMenuItem.Click += new System.EventHandler(this.nuevaFuenteRSSToolStripMenuItem_Click);
            // 
            // modificarFuenteRSSToolStripMenuItem
            // 
            this.modificarFuenteRSSToolStripMenuItem.Name = "modificarFuenteRSSToolStripMenuItem";
            this.modificarFuenteRSSToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.modificarFuenteRSSToolStripMenuItem.Text = "Modificar/Eliminar fuente(s) RSS";
            this.modificarFuenteRSSToolStripMenuItem.Click += new System.EventHandler(this.modificarFuenteRSSToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.manualDeUsuarioToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.manualDeUsuarioToolStripMenuItem.Text = "Ver la Ayuda";
            this.manualDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.manualDeUsuarioToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = false;
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem configuracionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem campañasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCampañaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarCampañaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuentesRSSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaFuenteRSSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarFuenteRSSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bannersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoBannerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificar_eliminarBannerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empezarToolStripMenuItem;
    }
}



