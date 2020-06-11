using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGAGEMENT.CORE.Dto
{
    public class DeviseDto
    {
        public int Id { get; set; }
        public string CodeDevise { get; set; }
        public List<DetailReglementDto> DetailReglements { get; set; }
    }
}
