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
    public class BanqueService : CommonService<Banque>, IBanqueService
    {
        private readonly IBanqueRepository repository;
        private readonly IMapper mapper;
        public BanqueService(IBanqueRepository repository, IMapper mapper) : base(repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public BanqueDto Insert(BanqueDto banqueDto)
        {
            Banque banque = this.repository.Insert(this.mapper.Map<Banque>(banqueDto));
            return this.mapper.Map<BanqueDto>(banque);
        }
        public BanqueDto Update(BanqueDto banqueDto)
        {
            Banque banque = this.repository.Insert(this.mapper.Map<Banque>(banqueDto));
            return this.mapper.Map<BanqueDto>(banque);
        }
        public List<LookupDto> GetLookupDto()
        {
            return this.repository.GetAll()
                .Select(banque => new LookupDto { Id = banque.Id, Designation = banque.Description }).ToList();
        }
    }
}
