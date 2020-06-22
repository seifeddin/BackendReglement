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
    public class RoleTechniqueService : CommonService<RoleTechnique>, IRoleTechniqueService
    {
        private readonly IRoleTechniqueRepository repository;
        private readonly IMapper mapper;
        public RoleTechniqueService(IRoleTechniqueRepository repository, IMapper mapper) : base(repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public RoleTechniqueDto Insert(RoleTechniqueDto roleTechniqueDto)
        {
            RoleTechnique roleTechniquet = this.repository.Insert(this.mapper.Map<RoleTechnique>(roleTechniqueDto));
            return this.mapper.Map<RoleTechniqueDto>(roleTechniquet);
        }
        public RoleTechniqueDto Update(RoleTechniqueDto roleTechniqueDto)
        {
            RoleTechnique roleTechniquet = this.repository.Update(this.mapper.Map<RoleTechnique>(roleTechniqueDto));
            return this.mapper.Map<RoleTechniqueDto>(roleTechniquet);
        }

        public List<RoleTechniqueDto> GetNotAffectedRoleTechnique(int idRoleFonctionnel)
        {
            return this.repository.GetNotAffectedRoleTechnique(idRoleFonctionnel).Select(this.mapper.Map<RoleTechniqueDto>).ToList();
        }
        public List<LookupDto> GetLookupDto()
        {
            return this.repository.GetAll()
                .Select(p => new LookupDto { Id = p.Id, Designation = p.Description }).ToList();
        }
    }
}
