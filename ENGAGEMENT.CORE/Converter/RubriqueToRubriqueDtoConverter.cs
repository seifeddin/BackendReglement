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
    public class RubriqueToRubriqueDtoConverter : ITypeConverter<Rubrique,RubriqueDto>
    {
        private readonly IMapper mapper;

        public RubriqueToRubriqueDtoConverter(IMapper mapper)
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public RubriqueDto Convert(Rubrique source, RubriqueDto destination, ResolutionContext context)
        {
            if (source == null)
            {
                return null;
            }

            return new RubriqueDto
            {
                Id = source.Id,
                Description = source.Description,
                RubriqueRetenu = source.RubriqueRetenu.Select(this.mapper.Map<RubriqueRetenuDto>).ToList(),
            };
        }
    }
}
