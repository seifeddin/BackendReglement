﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.ENTITY;

namespace ENGAGEMENT.SERVICES.Interfaces
{
    public interface IAnnexeService : ICommonService<Annexe>
    {
        AnnexeDto Insert(AnnexeDto annexeDto);
        AnnexeDto Update(AnnexeDto annexeDto);
        List<LookupDto> GetLookupDto();
    }
}
