using CgsSite.Web.DI;
using CgsSite.Web.DI.Autofac;
using CgsSite.Web.DI.Autofac.Modules;
using Autofac;
using Autofac.Core;
using Autofac.Integration.Mvc;
using System.Reflection;
using CgsSite.Application;
using CgsSite.Domain;
using CgsSite.Infrastructure.Respositories;
using CgsSite.Web.Services;

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
        //builder.RegisterFilterProvider();
// Create the DI container
        var container = builder.Build();

// Return our DI container wrapper instance
        return new AutofacDependencyInjectionContainer(container);
    }
}

