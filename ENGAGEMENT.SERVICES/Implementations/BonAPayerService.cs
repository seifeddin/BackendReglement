using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENGAGEMENT.DATA.Interfaces;
using ENGAGEMENT.ENTITY;
using ENGAGEMENT.SERVICES.Interfaces;

namespace ENGAGEMENT.SERVICES.Implementations
{
    public class BonAPayerService : CommonService<BonAPayer>, IBonAPayerService
    {
        private readonly IBonAPayerRepository repository;
        public BonAPayerService(IBonAPayerRepository repository) : base(repository)
        {
            this.repository = this.repository ?? throw new ArgumentNullException(nameof(repository));
        }
    }
}
