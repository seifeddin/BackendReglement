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
    public class DeviseToDeviseDtoConverter : ITypeConverter<Devise,DeviseDto>
    {
        private readonly IMapper mapper;
        public DeviseToDeviseDtoConverter(IMapper mapper)
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public DeviseDto Convert(Devise source, DeviseDto destination, ResolutionContext context)
        {
            if (source == null)
            {
                return null;
            }

            return  new DeviseDto
            {
                Id = source.Id,
                CodeDevise =  source.CodeDevise,
                DetailReglements = source.DetailReglement.Select(this.mapper.Map<DetailReglementDto>).ToList(),
                
            };
        }
    }
}
