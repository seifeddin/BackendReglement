using Autofac;
using Autofac.Integration.WebApi;
using ENGAGEMENT.SERVICES.Implementations;
using ENGAGEMENT.SERVICES.Interfaces;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ENGAGEMENT.DATA;
using ENGAGEMENT.DATA.Interfaces;
using ENGAGEMENT.DATA.Implements;
using ENGAGEMENT.ENTITY;

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
            builder.RegisterType<REG_FSS_DB>().SingleInstance();
            builder.RegisterGeneric(typeof(CommonService<>)).As(typeof(ICommonService<>));
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));
            builder.RegisterType<FournisseurService>().As<IFournisseurService>().InstancePerRequest();
            builder.RegisterType<FournisseursRepository>().As<IFournisseursRepository>().InstancePerRequest();
            

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
