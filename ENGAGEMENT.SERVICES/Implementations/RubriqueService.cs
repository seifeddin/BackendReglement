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
    public class RubriqueService : CommonService<Rubrique>, IRubriqueService
    {
        private readonly IRubriqueRepository repository;
        private readonly IMapper mapper;
        public RubriqueService(IRubriqueRepository repository, IMapper mapper) : base(repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public RubriqueDto Insert(RubriqueDto rubriqueDto)
        {
            Rubrique rubrique = this.repository.Insert(this.mapper.Map<Rubrique>(rubriqueDto));
            return this.mapper.Map<RubriqueDto>(rubrique);
        }
        public RubriqueDto Update(RubriqueDto rubriqueDto)
        {
            Rubrique rubrique = this.repository.Update(this.mapper.Map<Rubrique>(rubriqueDto));
            return this.mapper.Map<RubriqueDto>(rubrique);
        }
    }
}
