using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENGAGEMENT.DATA.Interfaces;
using ENGAGEMENT.ENTITY;

namespace ENGAGEMENT.DATA.Implements
{
    public class RetenuRepository : Repository<Retenu>, IRetenuRepository
    {
        public RetenuRepository(REG_FSS_DB context) : base(context)
        {
        }
    }
}
