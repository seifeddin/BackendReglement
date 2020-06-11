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
    public class ReglementFactureToReglementFactureDtoConverter : ITypeConverter<ReglementFacture,ReglementFactureDto>
    {
        private readonly IMapper mapper;

        public ReglementFactureToReglementFactureDtoConverter(IMapper mapper)
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public ReglementFactureDto Convert(ReglementFacture source, ReglementFactureDto destination, ResolutionContext context)
        {
            if (source == null)
            {
                return null;
            }

            return new ReglementFactureDto
            {
                Id =  source.Id,
                Reglement = this.mapper.Map<ReglementDto>(source.Reglement),
                Facture = this.mapper.Map<FactureDto>(source.Facture),
                IdReglement = source.IdReglement,
                IdFacture =  source.IdFacture,
                MontantTotale = source.MontantTotale,
            };
        }
    }
}
