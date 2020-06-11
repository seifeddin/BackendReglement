using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGAGEMENT.CORE.Dto
{
    public class DetailReglementDto
    {
        public int Id { get; set; }
        public int? IdBanque { get; set; }
        public int? IdCaisse { get; set; }
        public int? IdDevise { get; set; }
        public int? IdModeReglement { get; set; }
        public decimal? Montant { get; set; }
        public int IdReglement { get; set; }
        public BanqueDto Banque { get; set; }
        public CaisseDto Caisse { get; set; }
        public DeviseDto Devise { get; set; }
        public ModeReglementDto ModeReglement { get; set; }
        public ReglementDto Reglement { get; set; }
    }
}
