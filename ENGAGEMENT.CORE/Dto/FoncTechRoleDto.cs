using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGAGEMENT.CORE.Dto
{
    public class FoncTechRoleDto
    {
        public int IdTechRole { get; set; }
        public int? IdFoncRole { get; set; }
        public int Id { get; set; }
        public RoleFonctionnelDto RoleFonctionnel { get; set; }
        public RoleTechniqueDto RoleTechnique { get; set; }
    }
}
