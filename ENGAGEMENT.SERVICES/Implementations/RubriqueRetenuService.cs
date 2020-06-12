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
    public class RubriqueRetenuService : CommonService<RubriqueRetenu>, IRubriqueRetenuService
    {
        private readonly IRubriqueRetenuRepository repository;
        private readonly IMapper mapper;
        public RubriqueRetenuService(IRubriqueRetenuRepository repository, IMapper mapper) : base(repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public RubriqueRetenuDto Insert(RubriqueRetenuDto rubriqueRetenuDto)
        {
            RubriqueRetenu rubriqueRetenu = this.repository.Insert(this.mapper.Map<RubriqueRetenu>(rubriqueRetenuDto));
            return this.mapper.Map<RubriqueRetenuDto>(rubriqueRetenu);
        }
        public RubriqueRetenuDto Update(RubriqueRetenuDto rubriqueRetenuDto)
        {
            RubriqueRetenu rubriqueRetenu = this.repository.Update(this.mapper.Map<RubriqueRetenu>(rubriqueRetenuDto));
            return this.mapper.Map<RubriqueRetenuDto>(rubriqueRetenu);
        }
    }
}
