﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.ENTITY;

namespace ENGAGEMENT.SERVICES.Interfaces
{
    public interface IRoleFonctionnelService : ICommonService<RoleFonctionnel>
    {
        RoleFonctionnelDto Insert(RoleFonctionnelDto roleFonctionnelDto);
        RoleFonctionnelDto Update(RoleFonctionnelDto roleFonctionnelDto);
        RoleFonctionnelDto AddRoleTechniqueToRoleFonctionnel(RoleFonctionnelDto roleFonctionnelDto);
        void DeleteRoleTechniqueFormFonctionnelRole(int roleTechniqueId, int roleFonctionnelId);
        void Delete(int id);
        List<LookupDto> GetLookupDto();
    }
}
