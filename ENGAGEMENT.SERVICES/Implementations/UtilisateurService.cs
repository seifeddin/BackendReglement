using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.DATA.Interfaces;
using ENGAGEMENT.ENTITY;
using ENGAGEMENT.SERVICES.Interfaces;

namespace ENGAGEMENT.SERVICES.Implementations
{
    public class UtilisateurService : CommonService<Utilisateur>, IUtilisateurService
    {
        private readonly IUtilisateurRepository repository;
        private readonly IMapper mapper;
        public UtilisateurService(IUtilisateurRepository repository, IMapper mapper) : base(repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public UtilisateurDto Insert(UtilisateurDto utilisateurDto)
        {
            Utilisateur utilisateur = this.repository.Insert(this.mapper.Map<Utilisateur>(utilisateurDto));
            return this.mapper.Map<UtilisateurDto>(utilisateur);
        }
        public UtilisateurDto Update(UtilisateurDto utilisateurDto)
        {
            Utilisateur utilisateurt = this.repository.Update(this.mapper.Map<Utilisateur>(utilisateurDto));
            return this.mapper.Map<UtilisateurDto>(utilisateurt);
        }
        public List<LookupDto> GetLookupDto()
        {
            return this.repository.GetAll()
                .Select(p => new LookupDto { Id = p.Id, Designation = $"{p.Prenom} {p.Nom}" }).ToList();
        }
    }
}
