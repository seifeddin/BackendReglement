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
    public class BonAPayerService : CommonService<BonAPayer>, IBonAPayerService
    {
        private readonly IBonAPayerRepository repository;
        private readonly IReglementRepository reglementRepository;
        private readonly IMapper mapper;
        public BonAPayerService(IBonAPayerRepository repository, IReglementRepository reglementRepository, IMapper mapper) : base(repository)
        {
            this.reglementRepository = reglementRepository ?? throw new ArgumentNullException(nameof(reglementRepository));
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public BonAPayerDto Insert(BonAPayerDto bonAPayerDto)
        {
            BonAPayer bonAPayer = this.repository.Insert(this.mapper.Map<BonAPayer>(bonAPayerDto));
            Reglement reglementToUpdate = this.reglementRepository.GetById(bonAPayerDto.IdReglement);
            reglementToUpdate.IdBonAPayer = bonAPayer.Id;
            this.reglementRepository.Update(reglementToUpdate);
            
            return this.mapper.Map<BonAPayerDto>(bonAPayer);
        }
        public BonAPayerDto Update(BonAPayerDto bonAPayerDto)
        {
            BonAPayer toUpdate = this.GetById(bonAPayerDto.Id);
            toUpdate.DateSignature = bonAPayerDto.DateSignature;
            toUpdate.DateValidation = bonAPayerDto.DateValidation;
            toUpdate.EstRegle = bonAPayerDto.EstRegle;
            toUpdate.MontantRetenu = bonAPayerDto.MontantRetenu;
            toUpdate.MontantTotalEcheance = bonAPayerDto.MontantTotalEcheance;
            toUpdate.NetAPayer = bonAPayerDto.NetAPayer;
            toUpdate.ValiderPar = bonAPayerDto.ValiderPar;
            return this.mapper.Map<BonAPayerDto>(this.repository.Update(toUpdate));
        }
        public List<LookupDto> GetLookupDto()
        {
            return this.repository.GetAll()
                .Select(bonAPayer => new LookupDto
                {
                    Id = bonAPayer.Id, Designation = bonAPayer.Id.ToString()

                }).ToList();
        }
        public List<ListBonAPayer> GetAllBonApayer()
        {
            return this.repository.GetAllBonApayer();
        }

        public List<ListBonAPayer> GetBonsRecuperes()
        {
            return this.repository.GetAllBonApayer().Where(x=>(x.EstValide==true && x.EstRegle!=true)).ToList();
        }
    }
}
