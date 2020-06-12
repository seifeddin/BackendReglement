using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.ENTITY;

namespace ENGAGEMENT.SERVICES.Interfaces
{
    public interface ICaisseService : ICommonService<Caisse>
    {
        CaisseDto Insert(CaisseDto caisseDto);
        CaisseDto Update(CaisseDto caisseDto);
    }
}
