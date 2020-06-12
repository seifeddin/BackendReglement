using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.ENTITY;

namespace ENGAGEMENT.SERVICES.Interfaces
{
    public interface IRetenuService : ICommonService<Retenu>
    {
        RetenuDto Insert(RetenuDto retenuDto);
        RetenuDto Update(RetenuDto retenuDto);
    }
}
