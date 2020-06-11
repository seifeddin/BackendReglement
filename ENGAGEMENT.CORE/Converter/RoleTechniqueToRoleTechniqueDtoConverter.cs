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
    public class RoleTechniqueToRoleTechniqueDtoConverter : ITypeConverter<RoleTechnique,RoleTechniqueDto>
    {
        private readonly IMapper mapper;

        public RoleTechniqueToRoleTechniqueDtoConverter(IMapper mapper)
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public RoleTechniqueDto Convert(RoleTechnique source, RoleTechniqueDto destination, ResolutionContext context)
        {
            if (source == null)
            {
                return null;
            }

            return new RoleTechniqueDto
            {
                Id = source.Id,
                Description = source.Description,
                FoncTechRoles = source.FoncTechRole.Select(this.mapper.Map<FoncTechRoleDto>).ToList(),
            };
        }
    }
}
