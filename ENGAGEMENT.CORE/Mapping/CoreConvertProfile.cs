using AutoMapper;
using ENGAGEMENT.CORE.Converter;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.ENTITY;


namespace ENGAGEMENT.CORE.Mapping
{
    public class CoreConvertProfile : Profile
    {
        public CoreConvertProfile()
        {
            this.CreateMap<Fournisseur, FournisseurDto>().ConvertUsing<FournisseurToFournisseurDtoConverter>();
            this.CreateMap<Facture, FactureDto>().ConvertUsing<FactureToFactureDtoConverter>();
        }
    }
}
