using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGAGEMENT.CORE.Dto
{
   public class FournisseurDto
    {
        public int Id { get; set; }
        public string RaisonSocial { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Nullable<decimal> FraisGeneraux { get; set; }
        public Nullable<decimal> Solde { get; set; }
        public Nullable<bool> EstPhysique { get; set; }
        public Nullable<bool> EstMorale { get; set; }

    }
}
