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
    public class RubriqueRetenuToRubriqueRetenuDtoConverter : ITypeConverter<RubriqueRetenu,RubriqueRetenuDto>
    {
        private readonly IMapper mapper;

        public RubriqueRetenuToRubriqueRetenuDtoConverter(IMapper mapper)
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public RubriqueRetenuDto Convert(RubriqueRetenu source, RubriqueRetenuDto destination, ResolutionContext context)
        {
            if (source == null)
            {
                return null;
            }

            return new RubriqueRetenuDto
            {
                Id = source.Id,
                IdRetenu = source.IdRetenu,
                Annexe = this.mapper.Map<AnnexeDto>(source.Annexe),
                Retenu = this.mapper.Map<RetenuDto>(source.Retenu),
                IdAnnexe = source.IdAnnexe,
                IdRubrique = source.IdRubrique,
                MontantHt = source.MontantHt,
                MontantTtc = source.MontantTtc,
                Rubrique =  this.mapper.Map<RubriqueDto>(source.Rubrique),
                Tva = source.Tva,
            };
        }
    }
}
