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
    
    public partial class Fournisseur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fournisseur()
        {
            this.Facture = new HashSet<Facture>();
        }
    
        public int Id { get; set; }
        public string RaisonSocial { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Nullable<decimal> FraisGeneraux { get; set; }
        public Nullable<decimal> Solde { get; set; }
        public Nullable<bool> EstPhysique { get; set; }
        public Nullable<bool> EstMorale { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facture> Facture { get; set; }
    }
}
