using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using System.Reflection;
using CgsSite.Application;
using CgsSite.Domain;
using CgsSite.Infrastructure.Respositories;
using CgsSite.Web.Services;

namespace CgsSite.Web
{
    public class Bootstraper
    {
        public static void Run()
        {
            SetAutofac();
        }

        private static void SetAutofac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterAssemblyTypes(typeof(ArticleService).Assembly).Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces().InstancePerHttpRequest();
            builder.RegisterAssemblyTypes(typeof(AriticleRespository).Assembly).Where(t => t.Name.EndsWith("Respository"))
                 .AsImplementedInterfaces().InstancePerHttpRequest();
            builder.RegisterType<AuthenticationService>().As<IAuthenticationService>();
            builder.RegisterFilterProvider();
            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}