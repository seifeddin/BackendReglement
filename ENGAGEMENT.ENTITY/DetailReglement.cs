//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class DetailReglement
    {
        public int Id { get; set; }
        public Nullable<int> IdBanque { get; set; }
        public Nullable<int> IdCaisse { get; set; }
        public Nullable<int> IdDevise { get; set; }
        public Nullable<int> IdModeReglement { get; set; }
        public Nullable<decimal> Montant { get; set; }
    
        public virtual Banque Banque { get; set; }
        public virtual Caisse Caisse { get; set; }
        public virtual Devise Devise { get; set; }
        public virtual ModeReglement ModeReglement { get; set; }
    }
}
