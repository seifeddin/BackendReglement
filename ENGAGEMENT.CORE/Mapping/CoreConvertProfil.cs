using AutoMapper;
using ENGAGEMENT.CORE.Converter;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGAGEMENT.CORE.Mapping
{
    public class CoreConvertProfil : Profile
    {
        public CoreConvertProfil()
        {
            this.CreateMap<Fournisseur, FournisseurDto>().ConvertUsing<FournisseurToFournisseurDtoConverter>();
        }
    }
}
