using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGAGEMENT.CORE.Dto
{
    public class ReglementDto
    {
        public int Id { get; set; }
        public DateTime? Echeance { get; set; }
        public DateTime? DateValidation { get; set; }
        public string ValiderPar { get; set; }
        public string DateReglement { get; set; }
        public int? IdRetenu { get; set; }
        public int? IdSuiviBancaire { get; set; }
        public int? IdBonAPayer { get; set; }

        public BonAPayerDto BonAPayer { get; set; }
        public RetenuDto Retenu { get; set; }
        public SuiviBancaireDto SuiviBancaire { get; set; }
        public List<ReglementFactureDto> ReglementFacture { get; set; }
        public List<DetailReglementDto> DetailReglement { get; set; }
    }
}
