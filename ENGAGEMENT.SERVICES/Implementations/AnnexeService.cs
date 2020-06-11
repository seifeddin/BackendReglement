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
    public class AnnexeService : CommonService<Annexe> , IAnnexeService
    {
        private readonly IAnnexeRepository repository;
        private readonly IMapper mapper;
        public AnnexeService(IAnnexeRepository repository, IMapper mapper) : base(repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public AnnexeDto Insert(AnnexeDto annexeDto)
        {
           Annexe annexe = this.repository.Insert(this.mapper.Map<Annexe>(annexeDto));
           return this.mapper.Map<AnnexeDto>(annexe);
        }
        public AnnexeDto Update(AnnexeDto annexeDto)
        {
            Annexe annexe = this.repository.Update(this.mapper.Map<Annexe>(annexeDto));
            return this.mapper.Map<AnnexeDto>(annexe);
        }
    }
}
