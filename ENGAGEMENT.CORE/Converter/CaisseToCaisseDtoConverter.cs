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
    public class CaisseToCaisseDtoConverter : ITypeConverter<Caisse,CaisseDto>
    {
        private readonly IMapper mapper;
        public CaisseToCaisseDtoConverter(IMapper mapper)
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public CaisseDto Convert(Caisse source, CaisseDto destination, ResolutionContext context)
        {
            if (source == null)
            {
                return null;
            }

            return new CaisseDto
            {
                Id = source.Id,
                Description =  source.Description,
                DetailReglement = source.DetailReglement.Select(this.mapper.Map<DetailReglementDto>).ToList(),
            };
        }
    }
}
