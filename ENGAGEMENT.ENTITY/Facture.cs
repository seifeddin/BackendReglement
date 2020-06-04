//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ENGAGEMENT.ENTITY
{
    using System;
    using System.Collections.Generic;
    
    public partial class Facture
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Facture()
        {
            this.ReglementFacture = new HashSet<ReglementFacture>();
        }
    
        public int Id { get; set; }
        public string Reference { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.DateTime> Echeance { get; set; }
        public Nullable<decimal> MontantTotale { get; set; }
        public Nullable<decimal> MontantDev { get; set; }
        public Nullable<decimal> MontantRegle { get; set; }
        public Nullable<decimal> MontantReste { get; set; }
        public string Statut { get; set; }
        public int IdFournisseur { get; set; }
    
        public virtual Fournisseur Fournisseur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReglementFacture> ReglementFacture { get; set; }
    }
}
