using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.ENTITY;

namespace ENGAGEMENT.SERVICES.Interfaces
{
    public interface IBonAPayerService : ICommonService<BonAPayer>
    {
        BonAPayerDto Insert(BonAPayerDto bonAPayerDto);
        BonAPayerDto Update(BonAPayerDto bonAPayerDto);
        List<LookupDto> GetLookupDto();
    }
}
