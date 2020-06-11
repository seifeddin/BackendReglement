using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGAGEMENT.CORE.Dto
{
    public class RubriqueRetenuDto
    {
        public int Id { get; set; }
        public int IdRubrique { get; set; }
        public int IdRetenu { get; set; }
        public decimal? MontantHt { get; set; }
        public double? Tva { get; set; }
        public decimal? MontantTtc { get; set; }
        public int? IdAnnexe { get; set; }

        public AnnexeDto Annexe { get; set; }
        public RetenuDto Retenu { get; set; }
        public RubriqueDto Rubrique { get; set; }
    }
}
