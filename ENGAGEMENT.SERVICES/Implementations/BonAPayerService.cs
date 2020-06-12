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
    public class BonAPayerService : CommonService<BonAPayer>, IBonAPayerService
    {
        private readonly IBonAPayerRepository repository;
        private readonly IMapper mapper;
        public BonAPayerService(IBonAPayerRepository repository, IMapper mapper) : base(repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public BonAPayerDto Insert(BonAPayerDto bonAPayerDto)
        {
            BonAPayer bonAPayer = this.repository.Insert(this.mapper.Map<BonAPayer>(bonAPayerDto));
            return this.mapper.Map<BonAPayerDto>(bonAPayer);
        }
        public BonAPayerDto Update(BonAPayerDto bonAPayerDto)
        {
            BonAPayer bonAPayer = this.repository.Update(this.mapper.Map<BonAPayer>(bonAPayerDto));
            return this.mapper.Map<BonAPayerDto>(bonAPayer);
        }
        public List<LookupDto> GetLookupDto()
        {
            return this.repository.GetAll()
                .Select(bonAPayer => new LookupDto
                {
                    Id = bonAPayer.Id, Designation = bonAPayer.Id.ToString()

                }).ToList();
        }
    }
}
