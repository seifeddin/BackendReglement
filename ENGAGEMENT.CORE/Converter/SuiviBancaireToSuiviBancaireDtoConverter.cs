using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.ENTITY;

namespace ENGAGEMENT.CORE.Converter
{
    public class SuiviBancaireToSuiviBancaireDtoConverter : ITypeConverter<SuiviBancaire,SuiviBancaireDto>
    {
        private readonly IMapper mapper;

        public SuiviBancaireToSuiviBancaireDtoConverter(IMapper mapper)
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public SuiviBancaireDto Convert(SuiviBancaire source, SuiviBancaireDto destination, ResolutionContext context)
        {
            if (source == null)
            {
                return null;
            }

            return new SuiviBancaireDto
            {
                Id =  source.Id,
                EstRegle = source.EstRegle,
                EstImpayes = source.EstImpayes,
                EstPreavis = source.EstPreavis,
                Reglements = source.Reglement.Select(this.mapper.Map<ReglementDto>).ToList(),
            };
        }
    }
}
