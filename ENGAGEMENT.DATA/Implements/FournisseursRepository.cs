using ENGAGEMENT.DATA.Interfaces;
using ENGAGEMENT.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGAGEMENT.DATA.Implements
{
    public class FournisseursRepository : Repository<Fournisseur>, IFournisseursRepository
    {
        public FournisseursRepository(REG_FSS_DB context):base(context)
        {
        }
    }
}
