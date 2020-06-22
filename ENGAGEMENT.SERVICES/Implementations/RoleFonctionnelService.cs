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
    public class RoleFonctionnelService : CommonService<RoleFonctionnel>,IRoleFonctionnelService
    {
        private readonly IRoleFonctionnelRepository repository;
        private readonly IUtilisateurRepository useRepository;
        private readonly IFoncTechRoleRepository foncTechRoleRepository;
        private readonly IMapper mapper;
        public RoleFonctionnelService(IRoleFonctionnelRepository repository, IUtilisateurRepository useRepository, IFoncTechRoleRepository foncTechRoleRepository, IMapper mapper) : base(repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.useRepository = useRepository ?? throw new ArgumentNullException(nameof(useRepository));
            this.foncTechRoleRepository = foncTechRoleRepository ??
                                          throw new ArgumentNullException(nameof(foncTechRoleRepository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public RoleFonctionnelDto Insert(RoleFonctionnelDto roleFonctionnelDto)
        {
            RoleFonctionnel roleFonctionnelt = this.repository.Insert(this.mapper.Map<RoleFonctionnel>(new RoleFonctionnelDto{Description = roleFonctionnelDto.Description}));

            foreach (var utilisateur in roleFonctionnelDto.Utilisateur)
            {
                Utilisateur ToUpdate = this.useRepository.GetById(utilisateur.Id);
                ToUpdate.IdRoleFonctionnel = roleFonctionnelt.Id;
                this.useRepository.Update(ToUpdate);
            }

            return this.mapper.Map<RoleFonctionnelDto>(roleFonctionnelt);
        }
        public RoleFonctionnelDto Update(RoleFonctionnelDto roleFonctionnelDto)
        {
            try
            {
                RoleFonctionnel roleFonctionneltUpdate = this.repository.Update(this.mapper.Map<RoleFonctionnel>(new RoleFonctionnelDto
                    { Id = roleFonctionnelDto.Id, Description = roleFonctionnelDto.Description }));
                List<Utilisateur> UserroleFonctionnelt = this.useRepository.GetAll().Where(p=>p.IdRoleFonctionnel == roleFonctionneltUpdate.Id ).ToList();

                foreach (var user in UserroleFonctionnelt)
                {
                    Utilisateur ToUpdate = this.useRepository.GetById(user.Id);
                    ToUpdate.IdRoleFonctionnel = null;
                    this.useRepository.Update(ToUpdate);
                }

                foreach (var user in roleFonctionnelDto.Utilisateur)
                {
                    Utilisateur ToUpdate = this.useRepository.GetById(user.Id);
                    ToUpdate.IdRoleFonctionnel = roleFonctionnelDto.Id;
                    this.useRepository.Update(ToUpdate);
                }



                return this.mapper.Map<RoleFonctionnelDto>(roleFonctionneltUpdate);
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                RoleFonctionnel role = this.GetById(id);
                foreach (var user in role.Utilisateur)
                {
                    Utilisateur ToUpdate = this.useRepository.GetById(user.Id);
                    ToUpdate.IdRoleFonctionnel = null;
                    this.useRepository.Update(ToUpdate);
                }

                this.repository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        public RoleFonctionnelDto AddRoleTechniqueToRoleFonctionnel(RoleFonctionnelDto roleFonctionnelDto)
        {
            foreach (var item in roleFonctionnelDto.FoncTechRole)
            {
                this.foncTechRoleRepository.Insert(new FoncTechRole
                {
                    IdFoncRole = roleFonctionnelDto.Id,
                    IdTechRole = item.Id
                });
            }

            return roleFonctionnelDto;
        }

        public void DeleteRoleTechniqueFormFonctionnelRole(int roleTechniqueId, int roleFonctionnelId)
        {
            this.foncTechRoleRepository.Delete(this.foncTechRoleRepository.GetAll().FirstOrDefault(p => p.IdFoncRole == roleFonctionnelId && p.IdTechRole == roleTechniqueId)?.Id);
        }
        public List<LookupDto> GetLookupDto()
        {
            return this.repository.GetAll()
                .Select(p => new LookupDto { Id = p.Id, Designation = p.Description }).ToList();
        }
    }
}
