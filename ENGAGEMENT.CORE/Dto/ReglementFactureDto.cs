using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGAGEMENT.CORE.Dto
{
    public class ReglementFactureDto
    {
        public int Id { get; set; }
        public int IdFacture { get; set; }
        public int IdReglement { get; set; }
        public decimal? MontantTotale { get; set; }
        public FactureDto Facture { get; set; }
        public ReglementDto Reglement { get; set; }
    }
}
