using Autofac;
using Autofac.Integration.WebApi;
using ENGAGEMENT.SERVICES.Implementations;
using ENGAGEMENT.SERVICES.Interfaces;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using ENGAGEMENT.CORE.Converter;
using ENGAGEMENT.CORE.Mapping;
using ENGAGEMENT.DATA;
using ENGAGEMENT.DATA.Interfaces;
using ENGAGEMENT.DATA.Implements;
using ENGAGEMENT.ENTITY;
using IMapper = AutoMapper.IMapper;

namespace ENGAGEMENT
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
          
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            var builder = new ContainerBuilder();

            // Get your HttpConfiguration.
            var config = GlobalConfiguration.Configuration;

            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // OPTIONAL: Register the Autofac filter provider.
            builder.RegisterWebApiFilterProvider(config);

            // OPTIONAL: Register the Autofac model binder provider.
            builder.RegisterWebApiModelBinderProvider();
            builder.RegisterType<REG_FSS_DB>();
            builder.RegisterGeneric(typeof(CommonService<>)).As(typeof(ICommonService<>));
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));
            builder.RegisterType<FournisseurService>().As<IFournisseurService>().InstancePerRequest();
            builder.RegisterType<FournisseursRepository>().As<IFournisseursRepository>().InstancePerRequest();
            builder.RegisterType<FacturesRepository>().As<IFacturesRepository>().InstancePerRequest();
            builder.RegisterType<FactureService>().As<IFactureService>().InstancePerRequest();
            builder.RegisterType<AnnexeRepository>().As<IAnnexeRepository>().InstancePerRequest();
            builder.RegisterType<AnnexeService>().As<IAnnexeService>().InstancePerRequest();
            builder.RegisterType<BanqueRepository>().As<IBanqueRepository>().InstancePerRequest();
            builder.RegisterType<BanqueService>().As<IBanqueService>().InstancePerRequest();
            builder.RegisterType<BonAPayerRepository>().As<IBonAPayerRepository>().InstancePerRequest();
            builder.RegisterType<BonAPayerService>().As<IBonAPayerService>().InstancePerRequest();
            builder.RegisterType<CaisseRepository>().As<ICaisseRepository>().InstancePerRequest();
            builder.RegisterType<CaisseService>().As<ICaisseService>().InstancePerRequest();
            builder.RegisterType<DetailReglementRepository>().As<IDetailReglementRepository>().InstancePerRequest();
            builder.RegisterType<DetailReglementService>().As<IDetailReglementService>().InstancePerRequest();
            builder.RegisterType<DeviseRepository>().As<IDeviseRepository>().InstancePerRequest();
            builder.RegisterType<DeviseService>().As<IDeviseService>().InstancePerRequest();
            builder.RegisterType<FoncTechRoleRepository>().As<IFoncTechRoleRepository>().InstancePerRequest();
            builder.RegisterType<FoncTechRoleService>().As<IFoncTechRoleService>().InstancePerRequest();
            builder.RegisterType<ModeReglementRepository>().As<IModeReglementRepository>().InstancePerRequest();
            builder.RegisterType<ModeReglementService>().As<IModeReglementService>().InstancePerRequest();
            builder.RegisterType<ReglementRepository>().As<IReglementRepository>().InstancePerRequest();
            builder.RegisterType<ReglementService>().As<IReglementService>().InstancePerRequest();
            builder.RegisterType<ReglementFactureRepository>().As<IReglementFactureRepository>().InstancePerRequest();
            builder.RegisterType<ReglementFactureService>().As<IReglementFactureService>().InstancePerRequest();
            builder.RegisterType<RetenuRepository>().As<IRetenuRepository>().InstancePerRequest();
            builder.RegisterType<RetenuService>().As<IRetenuService>().InstancePerRequest();
            builder.RegisterType<RoleFonctionnelRepository>().As<IRoleFonctionnelRepository>().InstancePerRequest();
            builder.RegisterType<RoleFonctionnelService>().As<IRoleFonctionnelService>().InstancePerRequest();
            builder.RegisterType<RoleTechniqueRepository>().As<IRoleTechniqueRepository>().InstancePerRequest();
            builder.RegisterType<RoleTechniqueService>().As<IRoleTechniqueService>().InstancePerRequest();
            builder.RegisterType<RubriqueRepository>().As<IRubriqueRepository>().InstancePerRequest();
            builder.RegisterType<RubriqueService>().As<IRubriqueService>().InstancePerRequest();
            builder.RegisterType<RubriqueRetenuRepository>().As<IRubriqueRetenuRepository>().InstancePerRequest();
            builder.RegisterType<RubriqueRetenuService>().As<IRubriqueRetenuService>().InstancePerRequest();
            builder.RegisterType<SuiviBancaireRepository>().As<ISuiviBancaireRepository>().InstancePerRequest();
            builder.RegisterType<SuiviBancaireSevice>().As<ISuiviBancaireSevice>().InstancePerRequest();
            builder.RegisterType<UtilisateurRepository>().As<IUtilisateurRepository>().InstancePerRequest();
            builder.RegisterType<UtilisateurService>().As<IUtilisateurService>().InstancePerRequest();

            // We must register the custom converter also the system not able to registered automatic
            builder.RegisterType<FournisseurToFournisseurDtoConverter>().AsSelf();
            builder.RegisterType<FactureToFactureDtoConverter>().AsSelf();

            builder.Register(context => new MapperConfiguration(cfg =>
            {
                //we should add all ours profile converter here to inject him 
                cfg.AddProfile(new CoreConvertProfile());
                //cfg.CreateMap<MyModel MyDto>;
                //etc...
            })).AsSelf().SingleInstance();

            builder.Register(c =>
                {
                    //This resolves a new context that can be used later.
                    var context = c.Resolve<IComponentContext>();
                    var configMapper = context.Resolve<MapperConfiguration>();
                    return configMapper.CreateMapper(context.Resolve);
                }).As<IMapper>().InstancePerLifetimeScope();


            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
