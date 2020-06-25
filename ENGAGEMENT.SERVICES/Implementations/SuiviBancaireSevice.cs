using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.DATA.Interfaces;
using ENGAGEMENT.DATA.Model;
using ENGAGEMENT.ENTITY;
using ENGAGEMENT.SERVICES.Interfaces;

namespace ENGAGEMENT.SERVICES.Implementations
{
    public class SuiviBancaireSevice : CommonService<SuiviBancaire>, ISuiviBancaireSevice
    {
        private readonly ISuiviBancaireRepository repository;
        private readonly IReglementRepository reglementRepository;
        private readonly IMapper mapper;
        public SuiviBancaireSevice(ISuiviBancaireRepository repository, IReglementRepository reglementRepository, IMapper mapper) : base(repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.reglementRepository = reglementRepository ?? throw new ArgumentNullException(nameof(reglementRepository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public SuiviBancaireDto Insert(SuiviBancaireDto suiviBancaireDto)
        {
            SuiviBancaire suiviBancaire = this.repository.Insert(this.mapper.Map<SuiviBancaire>(suiviBancaireDto));
            return this.mapper.Map<SuiviBancaireDto>(suiviBancaire);
        }
        public SuiviBancaireDto Update(SuiviBancaireDto suiviBancaireDto)
        {
            SuiviBancaire suiviBancairet = this.repository.Update(this.mapper.Map<SuiviBancaire>(suiviBancaireDto));
            return this.mapper.Map<SuiviBancaireDto>(suiviBancairet);
        }

        public List<CanvasReglement> GetReglementPourSuivi()
        {
            return this.reglementRepository.GetReglementPourSuivi().ToList();
        }
        public List<LookupDto> GetLookupDto()
        {
            return this.repository.GetAll()
                .Select(p => new LookupDto { Id = p.Id, Designation = p.Id.ToString() }).ToList();
        }
    }
}
