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
            DetailReglement toUpdate = this.GetById(detailReglementDto.Id);
            toUpdate.Id = detailReglementDto.Id;
            toUpdate.IdBanque = detailReglementDto.IdBanque;
            toUpdate.IdCaisse = detailReglementDto.IdCaisse;
            toUpdate.IdDevise = detailReglementDto.IdDevise;
            toUpdate.IdModeReglement = detailReglementDto.IdModeReglement;
            toUpdate.IdReglement = toUpdate.IdReglement;
            return this.mapper.Map<DetailReglementDto>(this.repository.Update(toUpdate));
        }
        public List<LookupDto> GetLookupDto()
        {
            return this.repository.GetAll()
                .Select(p => new LookupDto { Id = p.Id, Designation = p.Id.ToString() }).ToList();
        }
    }
}
