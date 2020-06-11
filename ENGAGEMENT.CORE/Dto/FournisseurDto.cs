using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENGAGEMENT.ENTITY;

namespace ENGAGEMENT.CORE.Dto
{
   public class FournisseurDto
    {
        public int Id { get; set; }
        public string RaisonSocial { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public decimal? FraisGeneraux { get; set; }
        public decimal? Solde { get; set; }
        public bool? EstPhysique { get; set; }
        public bool? EstMorale { get; set; }
        public List<FactureDto> Factures { get; set; }

    }
}
