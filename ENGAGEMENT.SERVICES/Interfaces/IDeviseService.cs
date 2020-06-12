using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.ENTITY;

namespace ENGAGEMENT.SERVICES.Interfaces
{
    public interface IDeviseService : ICommonService<Devise>
    {
        DeviseDto Insert(DeviseDto deviseDto);
        DeviseDto Update(DeviseDto deviseDto);
        List<LookupDto> GetLookupDto();
    }
}
