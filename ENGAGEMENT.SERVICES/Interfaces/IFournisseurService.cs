using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGAGEMENT.SERVICES.Interfaces
{
    public interface IFournisseurService : ICommonService<Fournisseur>
    {
        IEnumerable<FournisseurDto> GetAllFournisseurs();
        List<LookupDto> GetLookupFournisseurs();
        FournisseurDto Insert(FournisseurDto fournisseurDto);
        FournisseurDto Update(FournisseurDto fournisseurDto);
    }
}
