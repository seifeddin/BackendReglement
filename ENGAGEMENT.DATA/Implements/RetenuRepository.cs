using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENGAGEMENT.DATA.Interfaces;
using ENGAGEMENT.ENTITY;
using System.Data.Entity;

namespace ENGAGEMENT.DATA.Implements
{
    public class RetenuRepository : Repository<Retenu>, IRetenuRepository
    {
        private REG_FSS_DB context;
        public RetenuRepository(REG_FSS_DB context) : base(context)
        {
            this.context = context;
        }

        public Retenu InsertWithTransaction(Retenu obj)
        {
            var trans = this.context.Database.BeginTransaction();
            try
            {
                Insert(obj);
                trans.Commit();
                return obj;
            }
            catch (Exception ex)
            {
                trans.Rollback();
                return null;
            }
        }
    }
}
