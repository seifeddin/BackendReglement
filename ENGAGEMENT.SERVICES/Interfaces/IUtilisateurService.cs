using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.ENTITY;

namespace ENGAGEMENT.SERVICES.Interfaces
{
    public interface IUtilisateurService : ICommonService<Utilisateur>
    {
        UtilisateurDto Insert(UtilisateurDto utilisateurDto);
        UtilisateurDto Update(UtilisateurDto utilisateurDto);
        List<LookupDto> GetLookupDto();
    }
}
