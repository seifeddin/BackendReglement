using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGAGEMENT.SERVICES.Interfaces
{
   public interface IFactureService:ICommonService<Facture>
    {
        IEnumerable<FactureDto> GetFacturesByFournisseur(int idFournisseur);
        FactureDto Insert(FactureDto factureDto);
        FactureDto Update(FactureDto factureDto);
    }
}
