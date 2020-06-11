using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGAGEMENT.CORE.Dto
{
   public class FactureDto
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Echeance { get; set; }
        public decimal? MontantTotale { get; set; }
        public decimal? MontantDev { get; set; }
        public decimal? MontantRegle { get; set; }
        public decimal? MontantReste { get; set; }
        public string Statut { get; set; }
        public int IdFournisseur { get; set; }
        public List<ReglementFactureDto> ReglementFactures { get; set; }
        public virtual FournisseurDto Fournisseur { get; set; }
    }
}
