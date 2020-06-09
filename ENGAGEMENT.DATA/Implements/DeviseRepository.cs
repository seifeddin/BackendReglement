using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENGAGEMENT.DATA.Interfaces;
using ENGAGEMENT.ENTITY;

namespace ENGAGEMENT.DATA.Implements
{
    public class DeviseRepository : Repository<Devise>, IDeviseRepository
    {
        public DeviseRepository(REG_FSS_DB context) : base(context)
        {
        }
    }
}
