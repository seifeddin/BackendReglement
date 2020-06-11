using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGAGEMENT.CORE.Dto
{
    public class RetenuDto
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int? NumeroCertficat { get; set; }
        public string TypeMontant { get; set; }
        public DateTime? DateValidation { get; set; }
        public string ValiderPar { get; set; }
        public List<RubriqueRetenuDto> RubriqueRetenu { get; set; }
        public List<ReglementDto> Reglement { get; set; }
    }
}
