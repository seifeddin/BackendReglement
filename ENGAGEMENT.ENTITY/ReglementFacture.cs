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
    
    public partial class ReglementFacture
    {
        public int Id { get; set; }
        public int IdFacture { get; set; }
        public int IdReglement { get; set; }
        public Nullable<decimal> MontantTotale { get; set; }
    
        public virtual Facture Facture { get; set; }
        public virtual Reglement Reglement { get; set; }
    }
}
