﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.ENTITY;

namespace ENGAGEMENT.SERVICES.Interfaces
{
    public interface IBanqueService : ICommonService<Banque>
    {
        BanqueDto Insert(BanqueDto BanqueDto);
        BanqueDto Update(BanqueDto BanqueDto);
        List<LookupDto> GetLookupDto();
    }
}
