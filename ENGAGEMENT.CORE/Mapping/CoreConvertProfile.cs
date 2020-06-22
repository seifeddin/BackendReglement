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
            this.CreateMap<Fournisseur, FournisseurDto>().ReverseMap();
            this.CreateMap<Facture, FactureDto>().ConvertUsing<FactureToFactureDtoConverter>();
            this.CreateMap<Facture, FactureDto>().ReverseMap();
            this.CreateMap<Annexe, AnnexeDto>().ConvertUsing<AnnexeToAnnexeDtoConverter>();
            this.CreateMap<Annexe, AnnexeDto>().ReverseMap();
            this.CreateMap<Banque,BanqueDto>().ConvertUsing<BanqueToBanqueDtoConverter>();
            this.CreateMap<Banque, BanqueDto>().ReverseMap();
            this.CreateMap<Caisse,CaisseDto>().ConvertUsing<CaisseToCaisseDtoConverter>();
            this.CreateMap<Caisse, CaisseDto>().ReverseMap();
            this.CreateMap<DetailReglement,DetailReglementDto>().ConvertUsing<DetailReglementToDetailReglementDtoConverter>();
            this.CreateMap<DetailReglement,DetailReglementDto>().ReverseMap();
            this.CreateMap<Devise,DeviseDto>().ConvertUsing<DeviseToDeviseDtoConverter>();
            this.CreateMap<Devise, DeviseDto>().ReverseMap();
            this.CreateMap<FoncTechRole,FoncTechRoleDto>().ConvertUsing<FoncTechRoleToFoncTechRoleDtoConverter>();
            this.CreateMap<FoncTechRole, FoncTechRoleDto>().ReverseMap();
            this.CreateMap<ModeReglement,ModeReglementDto>().ConvertUsing<ModeReglementToModeReglementDtoConverter>();
            this.CreateMap<ModeReglement, ModeReglementDto>().ReverseMap();
            this.CreateMap<Reglement,ReglementDto>().ConvertUsing<ReglementToReglementDtoConverter>();
            this.CreateMap<Reglement, ReglementDto>().ReverseMap();
            this.CreateMap<ReglementFacture,ReglementFactureDto>().ConvertUsing<ReglementFactureToReglementFactureDtoConverter>();
            this.CreateMap<ReglementFacture, ReglementFactureDto>().ReverseMap();
            this.CreateMap<Retenu,RetenuDto>().ConvertUsing<RetenuToRetenuDtoConverter>();
            this.CreateMap<Retenu, RetenuDto>().ReverseMap();
            this.CreateMap<RoleFonctionnel,RoleFonctionnelDto>().ConvertUsing<RoleFonctionnelToRoleFonctionnelDtoConverter>();
            this.CreateMap<RoleFonctionnel, RoleFonctionnelDto>().ReverseMap();
            this.CreateMap<RoleTechnique,RoleTechniqueDto>().ConvertUsing<RoleTechniqueToRoleTechniqueDtoConverter>();
            this.CreateMap<Rubrique,RubriqueDto>().ConvertUsing<RubriqueToRubriqueDtoConverter>();
            this.CreateMap<RubriqueRetenu,RubriqueRetenuDto>().ConvertUsing<RubriqueRetenuToRubriqueRetenuDtoConverter>();
            this.CreateMap<RubriqueRetenu, RubriqueRetenuDto>().ReverseMap();
            this.CreateMap<SuiviBancaire,SuiviBancaireDto>().ConvertUsing<SuiviBancaireToSuiviBancaireDtoConverter>();
            this.CreateMap<SuiviBancaire, SuiviBancaireDto>().ReverseMap();
            this.CreateMap<Utilisateur,UtilisateurDto>().ConvertUsing<UtilisateurToUtilisateurDtoConverter>();
            this.CreateMap<Utilisateur, UtilisateurDto>().ReverseMap();
            this.CreateMap<BonAPayer,BonAPayerDto>().ConvertUsing<BonAPayerToBonAPayerDtoConverter>();
            this.CreateMap<BonAPayer, BonAPayerDto>().ReverseMap();


        }
    }
}
