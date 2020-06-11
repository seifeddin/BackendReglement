using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.ENTITY;

namespace ENGAGEMENT.CORE.Converter
{
    public class ModeReglementToModeReglementDtoConverter : ITypeConverter<ModeReglement,ModeReglementDto>
    {
        private readonly IMapper mapper;
        public ModeReglementToModeReglementDtoConverter()
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public ModeReglementDto Convert(ModeReglement source, ModeReglementDto destination, ResolutionContext context)
        {
            if (source == null)
            {
                return null;
            }

            return new ModeReglementDto
            {
                Id = source.Id,
                Description =  source.Description,
                DetailReglements = source.DetailReglement.Select(this.mapper.Map<DetailReglementDto>).ToList(),
            };
        }
    }
}
