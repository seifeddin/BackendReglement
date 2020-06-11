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
    public class RoleFonctionnelToRoleFonctionnelDtoConverter : ITypeConverter<RoleFonctionnel,RoleFonctionnelDto>
    {
        private readonly IMapper mapper;

        public RoleFonctionnelToRoleFonctionnelDtoConverter(IMapper mapper)
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public RoleFonctionnelDto Convert(RoleFonctionnel source, RoleFonctionnelDto destination, ResolutionContext context)
        {
            if (source == null)
            {
                return null;
            }

            return  new RoleFonctionnelDto
            {
                Id =  source.Id,
                Description = source.Description,
                FoncTechRole = source.FoncTechRole.Select(this.mapper.Map<FoncTechRoleDto>).ToList(),
                Utilisateur = source.Utilisateur.Select(this.mapper.Map<UtilisateurDto>).ToList(),
            };
        }
    }
}
