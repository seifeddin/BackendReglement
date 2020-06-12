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
    public class ReglementService: CommonService<Reglement>, IReglementService
    {
        private readonly IReglementRepository repository;
        private readonly IMapper mapper;
        public ReglementService(IReglementRepository repository,IMapper mapper) : base(repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public ReglementDto Insert(ReglementDto reglementDto)
        {
            Reglement reglement = this.repository.Insert(this.mapper.Map<Reglement>(reglementDto));
            return this.mapper.Map<ReglementDto>(reglement);
        }
        public ReglementDto Update(ReglementDto reglementDto)
        {
            Reglement reglement = this.repository.Update(this.mapper.Map<Reglement>(reglementDto));
            return this.mapper.Map<ReglementDto>(reglement);
        }
        public List<LookupDto> GetLookupDto()
        {
            return this.repository.GetAll()
                .Select(p => new LookupDto { Id = p.Id, Designation = p.Id.ToString() }).ToList();
        }
    }
}
