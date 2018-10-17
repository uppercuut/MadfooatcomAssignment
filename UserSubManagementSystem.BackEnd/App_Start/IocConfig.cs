
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;

using System.Reflection;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using UserSubManagementSystem.BackEnd.Controllers.Api;
using UserSubManagementSystem.BackEnd.Core;

using UserSubManagementSystem.BackEnd.Persistence;

namespace UserSubManagementSystem.BackEnd.App_Start
{
    public static class IocConfig
    {
        public static void Configure()
        {
            // Create the container as usual.
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            // Register your types, for instance using the scoped lifestyle:
        

            // Configuration
            container.Register<IUnitOfWork>(() => new UintOfWork(new UserMSDBContext()),
                Lifestyle.Transient);



            // This is an extension method from the integration package.
            container.Verify();
            GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator),
       new ControllersActivator(
           container,
           GlobalConfiguration.Configuration.Services.GetHttpControllerActivator()));



        }
    }
}