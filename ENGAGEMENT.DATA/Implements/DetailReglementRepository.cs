using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENGAGEMENT.DATA.Interfaces;
using ENGAGEMENT.ENTITY;

namespace ENGAGEMENT.DATA.Implements
{
    public class DetailReglementRepository : Repository<DetailReglement>, IDetailReglementRepository
    {
        public DetailReglementRepository(REG_FSS_DB context) : base(context)
        {
        }
    }
}
