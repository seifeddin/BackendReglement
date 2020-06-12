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
    public class CaisseService : CommonService<Caisse>, ICaisseService
    {
        private readonly ICaisseRepository repository;
        private readonly IMapper mapper;

        public CaisseService(ICaisseRepository repository, IMapper mapper) : base(repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public CaisseDto Insert(CaisseDto caisseDto)
        {
            Caisse caisse = this.repository.Insert(this.mapper.Map<Caisse>(caisseDto));
            return this.mapper.Map<CaisseDto>(caisse);
        }

        public CaisseDto Update(CaisseDto caisseDto)
        {
            Caisse caisse = this.repository.Update(this.mapper.Map<Caisse>(caisseDto));
            return this.mapper.Map<CaisseDto>(caisse);
        }
    }
}