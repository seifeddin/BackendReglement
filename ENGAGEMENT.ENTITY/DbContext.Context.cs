﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ENGAGEMENT.ENTITY
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class REG_FSS_DB : DbContext
    {
        public REG_FSS_DB()
            : base("name=REG_FSS_DB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Annexe> Annexe { get; set; }
        public virtual DbSet<Banque> Banque { get; set; }
        public virtual DbSet<BonAPayer> BonAPayer { get; set; }
        public virtual DbSet<Caisse> Caisse { get; set; }
        public virtual DbSet<Devise> Devise { get; set; }
        public virtual DbSet<Facture> Facture { get; set; }
        public virtual DbSet<ModeReglement> ModeReglement { get; set; }
        public virtual DbSet<ReglementFacture> ReglementFacture { get; set; }
        public virtual DbSet<Retenu> Retenu { get; set; }
        public virtual DbSet<RoleFonctionnel> RoleFonctionnel { get; set; }
        public virtual DbSet<RoleTechnique> RoleTechnique { get; set; }
        public virtual DbSet<Rubrique> Rubrique { get; set; }
        public virtual DbSet<RubriqueRetenu> RubriqueRetenu { get; set; }
        public virtual DbSet<SuiviBancaire> SuiviBancaire { get; set; }
        public virtual DbSet<Utilisateur> Utilisateur { get; set; }
        public virtual DbSet<FoncTechRole> FoncTechRole { get; set; }
        public virtual DbSet<Reglement> Reglement { get; set; }
        public virtual DbSet<DetailReglement> DetailReglement { get; set; }
        public virtual DbSet<Fournisseur> Fournisseur { get; set; }
    }
}
