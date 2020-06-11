using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGAGEMENT.CORE.Dto
{
    public class SuiviBancaireDto
    {
        public int Id { get; set; }
        public bool? EstPreavis { get; set; }
        public bool? EstImpayes { get; set; }
        public bool? EstRegle { get; set; }
        public List<ReglementDto> Reglements { get; set; }
    }
}
