﻿using System;
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
        private readonly IMapper mapper;
        public RoleFonctionnelService(IRoleFonctionnelRepository repository, IUtilisateurRepository useRepository, IMapper mapper) : base(repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.useRepository = useRepository ?? throw new ArgumentNullException(nameof(useRepository));
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
            RoleFonctionnel roleFonctionnelt = this.repository.Update(this.mapper.Map<RoleFonctionnel>(roleFonctionnelDto));
            return this.mapper.Map<RoleFonctionnelDto>(roleFonctionnelt);
        }
        public List<LookupDto> GetLookupDto()
        {
            return this.repository.GetAll()
                .Select(p => new LookupDto { Id = p.Id, Designation = p.Description }).ToList();
        }
    }
}
