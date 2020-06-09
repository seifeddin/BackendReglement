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
    public class SuiviBancaireSevice : CommonService<SuiviBancaire>, ISuiviBancaireSevice
    {
        private readonly ISuiviBancaireRepository repository;
        public SuiviBancaireSevice(ISuiviBancaireRepository repository) : base(repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
    }
}
