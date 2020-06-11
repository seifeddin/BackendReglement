using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.ENTITY;

namespace ENGAGEMENT.CORE.Converter
{
    public class BanqueToBanqueDtoConverter :ITypeConverter<Banque,BanqueDto>
    {
        private readonly IMapper mapper;
        public BanqueToBanqueDtoConverter(IMapper mapper)
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public BanqueDto Convert(Banque source, BanqueDto destination, ResolutionContext context)
        {
            if (source == null)
            {
                return null;
            }
            return new BanqueDto
            {
               Description = source.Description,
               DetailReglement =  source.DetailReglement.Select(this.mapper.Map<DetailReglementDto>).ToList(),
               Id =  source.Id,
            };
        }
    }
}
