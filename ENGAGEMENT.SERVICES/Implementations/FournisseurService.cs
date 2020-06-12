
using AutoMapper;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.DATA.Interfaces;
using ENGAGEMENT.ENTITY;
using ENGAGEMENT.SERVICES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ENGAGEMENT.SERVICES.Implementations
{
    public class FournisseurService : CommonService<Fournisseur>, IFournisseurService
    {
        private IFournisseursRepository fournisseurRepository;
        private IMapper _mapper;
        public FournisseurService(IFournisseursRepository repository,IMapper mapper) : base(repository)
        {
            this.fournisseurRepository = repository??throw new NullReferenceException(nameof(repository));
            this._mapper = mapper ?? throw new NullReferenceException(nameof(mapper));
        }

        public IEnumerable<FournisseurDto> GetAllFournisseurs()
        {
           return fournisseurRepository.GetAll().Select(x => this._mapper.Map<FournisseurDto>(x)).ToList();
        }

        public List<LookupDto> GetLookupFournisseurs()
        {
          return fournisseurRepository.GetAll().Select(x => new LookupDto { Id = x.Id, Designation = x.Nom }).ToList();
        }
        public FournisseurDto Insert(FournisseurDto fournisseurDto)
        {
            Fournisseur fournisseur = this.fournisseurRepository.Insert(this._mapper.Map<Fournisseur>(fournisseurDto));
            return this._mapper.Map<FournisseurDto>(fournisseur);
        }
        public FournisseurDto Update(FournisseurDto fournisseurDto)
        {
            Fournisseur fournisseur = this.fournisseurRepository.Update(this._mapper.Map<Fournisseur>(fournisseurDto));
            return this._mapper.Map<FournisseurDto>(fournisseur);
        }

    }
}
