using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.DATA.Interfaces;
using ENGAGEMENT.ENTITY;
using ENGAGEMENT.SERVICES.Interfaces;

namespace ENGAGEMENT.SERVICES.Implementations
{
  public class ModeReglementService : CommonService<ModeReglement>,IModeReglementService
  {
      private readonly IModeReglementRepository repository;
      private readonly IMapper mapper;
      public ModeReglementService(IModeReglementRepository repository, IMapper mapper) : base(repository)
      {
          this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
          this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
      }
      public ModeReglementDto Insert(ModeReglementDto modeReglementDto)
      {
          ModeReglement modeReglement = this.repository.Insert(this.mapper.Map<ModeReglement>(modeReglementDto));
          return this.mapper.Map<ModeReglementDto>(modeReglement);
      }
      public ModeReglementDto Update(ModeReglementDto modeReglementDto)
      {
          ModeReglement modeReglement = this.repository.Update(this.mapper.Map<ModeReglement>(modeReglementDto));
          return this.mapper.Map<ModeReglementDto>(modeReglement);
      }
    }
}
