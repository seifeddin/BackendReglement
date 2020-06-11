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
    public class AnnexeToAnnexeDtoConverter : ITypeConverter<Annexe,AnnexeDto>
    {
        private readonly IMapper mapper;
        public AnnexeToAnnexeDtoConverter(IMapper mapper)
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public AnnexeDto Convert(Annexe source, AnnexeDto destination, ResolutionContext context)
        {
            if (source == null)
            {
                return null;
            }

            return new AnnexeDto
            {
                Description =  source.Description,
                Id = source.Id,
                RubriqueRetenu = source.RubriqueRetenu.Select(this.mapper.Map<RubriqueRetenuDto>).ToList(),
            };
        }
    }
}
