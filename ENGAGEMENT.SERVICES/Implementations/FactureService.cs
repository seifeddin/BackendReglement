using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.DATA.Interfaces;
using ENGAGEMENT.ENTITY;
using ENGAGEMENT.SERVICES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMapper = AutoMapper.IMapper;

namespace ENGAGEMENT.SERVICES.Implementations
{
    public class FactureService : CommonService<Facture>, IFactureService
    {
        private IFacturesRepository factureRepository;
        private IMapper mapper;
        public FactureService(IFacturesRepository repository,IMapper mapper) : base(repository)
        {
            this.factureRepository = repository ?? throw new NullReferenceException(nameof(repository));
            this.mapper = mapper ?? throw new NullReferenceException(nameof(mapper));
        }

        public IEnumerable<FactureDto> GetFacturesByFournisseur (int idFournisseur)
        {
         return   this.factureRepository.GetAll().Where(x => x.IdFournisseur == idFournisseur).Select(f => this.mapper.Map<FactureDto>(f)); ;
        }

        public FactureDto Insert(FactureDto factureDto)
        {
            Facture facture = this.factureRepository.Insert(this.mapper.Map<Facture>(factureDto));
            return this.mapper.Map<FactureDto>(facture);
        }
        public FactureDto Update(FactureDto factureDto)
        {
            Facture facture = this.factureRepository.Update(this.mapper.Map<Facture>(factureDto));
            return this.mapper.Map<FactureDto>(facture);
        }
        public List<LookupDto> GetLookupDto()
        {
            return this.factureRepository.GetAll()
                .Select(p => new LookupDto { Id = p.Id, Designation = p.Reference }).ToList();
        }


    }
}
