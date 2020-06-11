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
    public class ReglementToReglementDtoConverter : ITypeConverter<Reglement,ReglementDto>
    {
        private readonly IMapper mapper;

        public ReglementToReglementDtoConverter(IMapper mapper)
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public ReglementDto Convert(Reglement source, ReglementDto destination, ResolutionContext context)
        {
            if (source == null)
            {
                return null;
            }

            return new ReglementDto
            {
                Id = source.Id,
                DetailReglement = source.DetailReglement.Select(this.mapper.Map<DetailReglementDto>).ToList(),
                DateValidation = source.DateValidation,
                ValiderPar = source.ValiderPar,
                ReglementFacture = source.ReglementFacture.Select(this.mapper.Map<ReglementFactureDto>).ToList(),
                BonAPayer = this.mapper.Map<BonAPayerDto>(source.BonAPayer),
                DateReglement =  source.DateReglement,
                Echeance =  source.Echeance,
                IdBonAPayer = source.IdBonAPayer,
                IdRetenu =  source.IdRetenu,
                IdSuiviBancaire = source.IdSuiviBancaire,
                Retenu =  this.mapper.Map<RetenuDto>(source.Retenu),
                SuiviBancaire = this.mapper.Map<SuiviBancaireDto>(source.SuiviBancaire),
            };
        }
    }
}
