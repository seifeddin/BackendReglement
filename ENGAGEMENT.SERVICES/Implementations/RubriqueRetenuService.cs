using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENGAGEMENT.DATA.Interfaces;
using ENGAGEMENT.ENTITY;
using ENGAGEMENT.SERVICES.Interfaces;

namespace ENGAGEMENT.SERVICES.Implementations
{
    public class RubriqueRetenuService : CommonService<RubriqueRetenu>, IRubriqueRetenuService
    {
        private readonly IRubriqueRetenuRepository repository;
        public RubriqueRetenuService(IRubriqueRetenuRepository repository) : base(repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
    }
}
