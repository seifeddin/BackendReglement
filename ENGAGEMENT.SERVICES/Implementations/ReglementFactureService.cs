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
    public class ReglementFactureService : CommonService<ReglementFacture>, IReglementFactureService
    {
        private readonly IReglementFactureRepository repository;
        private readonly IMapper mapper;
        public ReglementFactureService(IReglementFactureRepository repository, IMapper mapper) : base(repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public ReglementFactureDto Insert(ReglementFactureDto reglementFactureDto)
        {
            ReglementFacture reglementFacturet = this.repository.Insert(this.mapper.Map<ReglementFacture>(reglementFactureDto));
            return this.mapper.Map<ReglementFactureDto>(reglementFacturet);
        }
        public ReglementFactureDto Update(ReglementFactureDto reglementFactureDto)
        {
            ReglementFacture reglementFacturet = this.repository.Update(this.mapper.Map<ReglementFacture>(reglementFactureDto));
            return this.mapper.Map<ReglementFactureDto>(reglementFacturet);
        }
        public List<LookupDto> GetLookupDto()
        {
            return this.repository.GetAll()
                .Select(p => new LookupDto { Id = p.Id, Designation = p.Id.ToString() }).ToList();
        }
    }
}
