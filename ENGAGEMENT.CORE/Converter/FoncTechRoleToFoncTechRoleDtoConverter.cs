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
    public class FoncTechRoleToFoncTechRoleDtoConverter : ITypeConverter<FoncTechRole,FoncTechRoleDto>
    {
        private readonly IMapper mapper;
        public FoncTechRoleToFoncTechRoleDtoConverter(IMapper mapper)
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public FoncTechRoleDto Convert(FoncTechRole source, FoncTechRoleDto destination, ResolutionContext context)
        {
            if (source == null)
            {
                return null;
            }

            return new FoncTechRoleDto
             {
                 Id =  source.Id,
                 IdFoncRole = source.IdFoncRole,
                 IdTechRole = source.IdTechRole,
                 RoleFonctionnel = this.mapper.Map<RoleFonctionnelDto>(source.RoleFonctionnel),
                 RoleTechnique = this.mapper.Map<RoleTechniqueDto>(source.RoleTechnique),
             };
        }
    }
}
