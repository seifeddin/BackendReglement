using ENGAGEMENT.DATA.Interfaces;
using ENGAGEMENT.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGAGEMENT.DATA.Implements
{
    public class FacturesRepository:Repository<Facture>,IFacturesRepository
    {
        public FacturesRepository(REG_FSS_DB context) : base(context)
        {

        }

    }
}
