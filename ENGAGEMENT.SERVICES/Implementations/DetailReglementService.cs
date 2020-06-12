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
    public class DetailReglementService : CommonService<DetailReglement>, IDetailReglementService
    {
        private readonly IDetailReglementRepository repository;
        private readonly IMapper mapper;
        public DetailReglementService(IDetailReglementRepository repository, IMapper mapper) : base(repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public DetailReglementDto Insert(DetailReglementDto detailReglementDto)
        {
            DetailReglement detailReglement = this.repository.Insert(this.mapper.Map<DetailReglement>(detailReglementDto));
            return this.mapper.Map<DetailReglementDto>(detailReglement);
        }

        public DetailReglementDto Update(DetailReglementDto detailReglementDto)
        {
            DetailReglement detailReglement = this.repository.Update(this.mapper.Map<DetailReglement>(detailReglementDto));
            return this.mapper.Map<DetailReglementDto>(detailReglement);
        }
        public List<LookupDto> GetLookupDto()
        {
            return this.repository.GetAll()
                .Select(p => new LookupDto { Id = p.Id, Designation = p.Id.ToString() }).ToList();
        }
    }
}
