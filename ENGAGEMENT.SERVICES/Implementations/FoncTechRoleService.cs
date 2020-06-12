using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.DATA.Interfaces;
using ENGAGEMENT.ENTITY;
using ENGAGEMENT.SERVICES.Interfaces;

namespace ENGAGEMENT.SERVICES.Implementations
{
    public class FoncTechRoleService : CommonService<FoncTechRole>, IFoncTechRoleService
    {
        private readonly IFoncTechRoleRepository repository;
        private readonly IMapper mapper;
        public FoncTechRoleService(IFoncTechRoleRepository repository, IMapper mapper) : base(repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public FoncTechRoleDto Insert(FoncTechRoleDto foncTechRoleDto)
        {
            FoncTechRole foncTechRole = this.repository.Insert(this.mapper.Map<FoncTechRole>(foncTechRoleDto));
            return this.mapper.Map<FoncTechRoleDto>(foncTechRole);
        }
        public FoncTechRoleDto Update(FoncTechRoleDto foncTechRoleDto)
        {
            FoncTechRole foncTechRole = this.repository.Update(this.mapper.Map<FoncTechRole>(foncTechRoleDto));
            return this.mapper.Map<FoncTechRoleDto>(foncTechRole);
        }
        public List<LookupDto> GetLookupDto()
        {
            return this.repository.GetAll()
                .Select(p => new LookupDto { Id = p.Id, Designation = p.Id.ToString() }).ToList();
        }
    }
}
