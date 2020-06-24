using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGAGEMENT.CORE.Dto
{
    public class BonAPayerDto
    {
        public int Id { get; set; }
        public decimal? MontantRetenu { get; set; }
        public decimal? MontantTotalEcheance { get; set; }
        public int? IdReglement { get; set; }
        public decimal? NetAPayer { get; set; }
        public string ValiderPar { get; set; }
        public DateTime? DateValidation { get; set; }
        public DateTime? DateSignature { get; set; }
        public bool? EstRegle { get; set; }
        public List<ReglementDto> Reglement { get; set; }
    }
}
