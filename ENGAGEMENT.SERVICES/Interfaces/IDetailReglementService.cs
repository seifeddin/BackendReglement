using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.ENTITY;

namespace ENGAGEMENT.SERVICES.Interfaces
{
    public interface IDetailReglementService : ICommonService<DetailReglement>
    {
        DetailReglementDto Insert(DetailReglementDto detailReglementDto);
        DetailReglementDto Update(DetailReglementDto detailReglementDto);
        List<LookupDto> GetLookupDto();
    }
}
