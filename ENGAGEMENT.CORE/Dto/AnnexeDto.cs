using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGAGEMENT.CORE.Dto
{
    public class AnnexeDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<RubriqueRetenuDto> RubriqueRetenu { get; set; }
    }
}
