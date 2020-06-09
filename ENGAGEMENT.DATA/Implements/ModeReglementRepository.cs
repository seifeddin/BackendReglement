using ENGAGEMENT.DATA.Interfaces;
using ENGAGEMENT.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENGAGEMENT.DATA.Interfaces;

namespace ENGAGEMENT.DATA.Implements
{
   public class ModeReglementRepository : Repository<ModeReglement>, IModeReglementRepository
    {
        public ModeReglementRepository(REG_FSS_DB context) : base(context)
        {
        }
    }
}
