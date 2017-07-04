﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Dominio;

namespace Persistencia
{
    /// <summary>
    /// Definicion de sets correspondientes a las clases de dominio. Util para la creacion de la DB. 
    /// </summary>
    public class CarteleriaContext: DbContext
    {

        public DbSet<Banner> Banner { get; set; }
        public DbSet<Campaña> Campaña { get; set; }
        public DbSet<Imagen> Imagen { get; set; }
        public DbSet<FuenteRSS> FuenteRSS { get; set; }
        public DbSet<BannerFuenteTextoFijo> FuenteTextoFijo { get; set; }


        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);            
            builder.Entity<BannerFuenteRSS>().HasRequired(t => t.iFuenteRSS).WithMany().HasForeignKey(p => p.iIdFuenteRSS).WillCascadeOnDelete(false);            
        }
 
    }
}
