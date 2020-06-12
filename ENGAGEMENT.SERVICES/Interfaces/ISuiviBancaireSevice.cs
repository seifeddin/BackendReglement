using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.ENTITY;

namespace ENGAGEMENT.SERVICES.Interfaces
{
    public interface ISuiviBancaireSevice : ICommonService<SuiviBancaire>
    {
        SuiviBancaireDto Insert(SuiviBancaireDto suiviBancaireDto);
        SuiviBancaireDto Update(SuiviBancaireDto suiviBancaireDto);
        List<LookupDto> GetLookupDto();
    }
}
