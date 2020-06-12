using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.ENTITY;

namespace ENGAGEMENT.SERVICES.Interfaces
{
    public interface IRubriqueRetenuService : ICommonService<RubriqueRetenu>
    {
        RubriqueRetenuDto Insert(RubriqueRetenuDto rubriqueRetenuDto);
        RubriqueRetenuDto Update(RubriqueRetenuDto rubriqueRetenuDto);
        List<LookupDto> GetLookupDto();
    }
}
