using $rootnamespace$.DI;
using $rootnamespace$.DI.Autofac;
using $rootnamespace$.DI.Autofac.Modules;
using Autofac;
using Autofac.Core;

public class CompositionRoot
{
    public static IDependencyInjectionContainer Compose()
    {
// Create a container builder
        var builder = new ContainerBuilder();
        builder.RegisterModule(new MvcSiteMapProviderModule());
        builder.RegisterModule(new MvcModule());

// Create the DI container
        var container = builder.Build();

// Return our DI container wrapper instance
        return new AutofacDependencyInjectionContainer(container);
    }
}

