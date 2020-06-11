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
    public class RetenuToRetenuDtoConverter : ITypeConverter<Retenu,RetenuDto>
    {
        private readonly IMapper mapper;

        public RetenuToRetenuDtoConverter(IMapper mapper)
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public RetenuDto Convert(Retenu source, RetenuDto destination, ResolutionContext context)
        {
            if (source == null)
            {
                return null;
            }

            return  new RetenuDto
            {
                Id =  source.Id,
                Reglement = source.Reglement.Select(this.mapper.Map<ReglementDto>).ToList(),
                ValiderPar = source.ValiderPar,
                DateValidation = source.DateValidation,
                RubriqueRetenu = source.RubriqueRetenu.Select(this.mapper.Map<RubriqueRetenuDto>).ToList(),
                Date = source.Date,
                NumeroCertficat = source.NumeroCertficat,
                TypeMontant =  source.TypeMontant,
                
            };
        }
    }
}
