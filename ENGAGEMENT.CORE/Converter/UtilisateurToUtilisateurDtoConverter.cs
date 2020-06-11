
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
    public class UtilisateurToUtilisateurDtoConverter : ITypeConverter<Utilisateur,UtilisateurDto>
    {
        private readonly IMapper mapper;

        public UtilisateurToUtilisateurDtoConverter(IMapper mapper)
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public UtilisateurDto Convert(Utilisateur source, UtilisateurDto destination, ResolutionContext context)
        {
            if (source == null)
            {
                return null;
            }

            return new UtilisateurDto
            {
                Id = source.Id,
                RoleFonctionnel = this.mapper.Map<RoleFonctionnelDto>(source.RoleFonctionnel),
                Email = source.Email,
                EstActive = source.EstActive,
                IdRoleFonctionnel = source.IdRoleFonctionnel,
                MotDePasse = source.MotDePasse,
                Nom = source.Nom,
                NomUtilisateur = source.NomUtilisateur,
                Prenom = source.Prenom,
                Telephone = source.Telephone,
            };
        }
    }
}
