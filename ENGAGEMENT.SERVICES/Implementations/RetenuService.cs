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
    public class RetenuService : CommonService<Retenu>, IRetenuService
    {
        private readonly IRetenuRepository repository;
        private readonly IReglementRepository reglementRepository;
        private readonly IMapper mapper;
        public RetenuService(IRetenuRepository repository, IReglementRepository reglementRepository, IMapper mapper) : base(repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.reglementRepository = reglementRepository ?? throw new ArgumentNullException(nameof(reglementRepository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public RetenuDto Insert(RetenuDto retenuDto)
        {
            Retenu retenut = this.repository.Insert(this.mapper.Map<Retenu>(retenuDto));
            return this.mapper.Map<RetenuDto>(retenut);
        }
        public RetenuDto Update(RetenuDto retenuDto)
        {
            Retenu retenut = this.repository.Update(this.mapper.Map<Retenu>(retenuDto));
            return this.mapper.Map<RetenuDto>(retenut);
        }
        public List<LookupDto> GetLookupDto()
        {
            return this.repository.GetAll()
                .Select(p => new LookupDto { Id = p.Id, Designation = p.Id.ToString() }).ToList();
        }

        public RetenuDto InsertWithTransaction(RetenuDto retenuDto)
        {
            try
            {
                Retenu retenu = this.repository.InsertWithTransaction(this.mapper.Map<Retenu>(retenuDto));
                Reglement toUpdate = this.reglementRepository.GetById(retenuDto.IdReglement);
                toUpdate.IdRetenu = retenu.Id;
                this.reglementRepository.Update(toUpdate);
                return this.mapper.Map<RetenuDto>(retenu);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }


    }
}
