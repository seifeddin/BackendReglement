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
            Annexe toUpdate = this.GetById(annexeDto.Id);
            toUpdate.Description = annexeDto.Description;
            return this.mapper.Map<AnnexeDto>(this.repository.Update(toUpdate));
        }

        public List<LookupDto> GetLookupDto()
        {
            return this.repository.GetAll()
                .Select(annexe => new LookupDto {Id = annexe.Id, Designation = annexe.Description}).ToList();
        }
    }
}
