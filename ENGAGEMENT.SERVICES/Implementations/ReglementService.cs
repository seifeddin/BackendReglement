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
        private readonly ISuiviBancaireRepository suiviBancaireRepository;
        private readonly IMapper mapper;
        public ReglementService(IReglementRepository repository,ISuiviBancaireRepository suiviBancaireRepository,IMapper mapper) : base(repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.suiviBancaireRepository = suiviBancaireRepository ?? throw new ArgumentNullException(nameof(suiviBancaireRepository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public ReglementDto Insert(ReglementDto reglementDto)
        {
            SuiviBancaire suivi = this.suiviBancaireRepository.Insert(new SuiviBancaire { EstImpayes  = false , EstRegle = false, EstPreavis = false});
            reglementDto.IdSuiviBancaire = suivi.Id;
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

        public decimal GetMontantRegelement(int id)
        {
            decimal res = 0;
            foreach ( var item in this.repository.GetById(id).DetailReglement)
            {
                res += item.Montant ?? 0;
            }

            return res;
        }
        public decimal GetTotalMontantRetenu(int id)
        {
            decimal res = 0;
            foreach ( var item in this.repository.GetById(id).Retenu.RubriqueRetenu)
            {
                res += item.MontantTtc ?? 0;
            }

            return res;
        }
    }
}
