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
    public class BonAPayerToBonAPayerDtoConverter : ITypeConverter<BonAPayer,BonAPayerDto>
    {
        private readonly IMapper mapper;
        public BonAPayerToBonAPayerDtoConverter(IMapper mapper)
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public BonAPayerDto Convert(BonAPayer source, BonAPayerDto destination, ResolutionContext context)
        {
            if (source == null)
            {
                return null;
            }
            return  new BonAPayerDto
            {
                Id =  source.Id,
                DateSignature = source.DateSignature,
                DateValidation = source.DateValidation,
                EstRegle = source.EstRegle,
                MontantRetenu = source.MontantRetenu,
                MontantTotalEcheance = source.MontantTotalEcheance,
                NetAPayer = source.NetAPayer,
                Reglement = source.Reglement.Select(this.mapper.Map<ReglementDto>).ToList(),
                ValiderPar =  source.ValiderPar,
            };
        }
    }
}
