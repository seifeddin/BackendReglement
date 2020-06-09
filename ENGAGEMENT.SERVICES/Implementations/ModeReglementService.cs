using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ENGAGEMENT.DATA.Interfaces;
using ENGAGEMENT.ENTITY;
using ENGAGEMENT.SERVICES.Interfaces;

namespace ENGAGEMENT.SERVICES.Implementations
{
  public class ModeReglementService : CommonService<ModeReglement>,IModeReglementService
  {
      private readonly IModeReglementRepository repository;
      public ModeReglementService(IModeReglementRepository repository) : base(repository)
      {
          this.repository = this.repository ?? throw new ArgumentNullException(nameof(repository));
      }
    }
}
