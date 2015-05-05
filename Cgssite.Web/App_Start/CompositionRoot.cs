using Cgssite.Web.DI;
using Cgssite.Web.DI.Autofac;
using Cgssite.Web.DI.Autofac.Modules;
using Autofac;
using Autofac.Core;
using Autofac.Integration.Mvc;
using System.Reflection;
using Cgssite.Application;
using Cgssite.Domain;
using Cgssite.Infrastructure.Respositories;
using Cgssite.Web.Services;

public class CompositionRoot
{
    public static IDependencyInjectionContainer Compose()
    {
// Create a container builder
        var builder = new ContainerBuilder();
        builder.RegisterModule(new MvcSiteMapProviderModule());
        builder.RegisterModule(new MvcModule());
        builder.RegisterControllers(Assembly.GetExecutingAssembly());
        builder.RegisterAssemblyTypes(typeof(ArticleService).Assembly).Where(t => t.Name.EndsWith("Service"))
            .AsImplementedInterfaces();
        builder.RegisterAssemblyTypes(typeof(AriticleRespository).Assembly).Where(t => t.Name.EndsWith("Respository"))
             .AsImplementedInterfaces();
        builder.RegisterType<AuthenticationService>().As<IAuthenticationService>();
        builder.RegisterFilterProvider();
// Create the DI container
        var container = builder.Build();

// Return our DI container wrapper instance
        return new AutofacDependencyInjectionContainer(container);
    }
}

