﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projeto_Lunary.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LunaryEntities : DbContext
    {
        public LunaryEntities()
            : base("name=LunaryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Campanhas> Campanhas { get; set; }
        public virtual DbSet<Estabelecimento> Estabelecimento { get; set; }
        public virtual DbSet<Restaurante> Restaurante { get; set; }
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Ranking> Ranking { get; set; }
    }
}