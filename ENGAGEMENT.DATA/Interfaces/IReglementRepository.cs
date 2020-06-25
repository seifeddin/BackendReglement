using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENGAGEMENT.DATA.Model;
using ENGAGEMENT.ENTITY;

namespace ENGAGEMENT.DATA.Interfaces
{
    public interface IReglementRepository: IRepository<Reglement>
    {
        List<CanvasReglement> GetReglementPourSuivi();
    }
}
