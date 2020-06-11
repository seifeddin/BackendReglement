using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.ENTITY;

namespace ENGAGEMENT.CORE.Converter
{
    public class DetailReglementToDetailReglementDtoConverter : ITypeConverter<DetailReglement,DetailReglementDto>
    {
        private readonly IMapper mapper;
        public DetailReglementToDetailReglementDtoConverter(IMapper mapper)
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public DetailReglementDto Convert(DetailReglement source, DetailReglementDto destination, ResolutionContext context)
        {
            if (source == null)
            {
                return null;
            }

            return new DetailReglementDto
            {
                Id = source.Id,
                Caisse = this.mapper.Map<CaisseDto>(source.Caisse),
                Banque =  this.mapper.Map<BanqueDto>(source.Banque),
                Reglement =  this.mapper.Map<ReglementDto>(source.Reglement),
                ModeReglement =  this.mapper.Map<ModeReglementDto>(source.ModeReglement),
                Devise = this.mapper.Map<DeviseDto>(source.Devise),
                IdBanque = source.IdBanque,
                IdCaisse = source.IdCaisse,
                IdDevise = source.IdDevise,
                IdModeReglement = source.IdModeReglement,
                IdReglement = source.IdReglement,
                Montant = source.Montant
            };
        }
    }
}
