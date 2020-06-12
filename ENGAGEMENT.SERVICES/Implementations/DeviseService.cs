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
    public class DeviseService : CommonService<Devise>, IDeviseService
    {
        private readonly IDeviseRepository repository;
        private readonly IMapper mapper;
        public DeviseService(IDeviseRepository repository, IMapper mapper) : base(repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public DeviseDto Insert(DeviseDto deviseDto)
        {
            Devise devise = this.repository.Insert(this.mapper.Map<Devise>(deviseDto));
            return this.mapper.Map<DeviseDto>(devise);
        }

        public DeviseDto Update(DeviseDto deviseDto)
        {
            Devise devise = this.repository.Update(this.mapper.Map<Devise>(deviseDto));
            return this.mapper.Map<DeviseDto>(devise);
        }
        public List<LookupDto> GetLookupDto()
        {
            return this.repository.GetAll()
                .Select(p => new LookupDto { Id = p.Id, Designation = p.CodeDevise }).ToList();
        }
    }
}
