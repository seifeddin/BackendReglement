using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.ENTITY;

namespace ENGAGEMENT.SERVICES.Interfaces
{
    public interface IReglementFactureService : ICommonService<ReglementFacture>
    {
        ReglementFactureDto Insert(ReglementFactureDto reglementFactureDto);
        ReglementFactureDto Update(ReglementFactureDto reglementFactureDto);
        List<LookupDto> GetLookupDto();
    }
}
