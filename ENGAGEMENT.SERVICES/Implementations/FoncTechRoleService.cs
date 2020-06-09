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
    public class FoncTechRoleService : CommonService<FoncTechRole>, IFoncTechRoleService
    {
        private readonly IFoncTechRoleRepository repository;
        public FoncTechRoleService(IFoncTechRoleRepository repository) : base(repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
    }
}
