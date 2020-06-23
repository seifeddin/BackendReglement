using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.ENTITY;

namespace ENGAGEMENT.SERVICES.Interfaces
{
    public interface IRoleTechniqueService : ICommonService<RoleTechnique>
    {
        RoleTechniqueDto Insert(RoleTechniqueDto roleTechniqueDto);
        RoleTechniqueDto Update(RoleTechniqueDto roleTechniqueDto);
        List<RoleTechniqueDto> GetNotAffectedRoleTechnique(int idRoleFonctionnel);
        List<LookupDto> GetLookupDto();
    }
}
