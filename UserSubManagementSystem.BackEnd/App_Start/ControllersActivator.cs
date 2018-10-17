using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using UserSubManagementSystem.BackEnd.Controllers.Api;
using SimpleInjector;



namespace UserSubManagementSystem.BackEnd.App_Start
{

    //this calss is to activate Simple injector for a specific controllers
    public class ControllersActivator : IHttpControllerActivator
    {
        private readonly Container container;
        private readonly IHttpControllerActivator original;

        public ControllersActivator(Container container, IHttpControllerActivator original)
        {
            this.container = container;
            this.original = original;
        }

        public IHttpController Create(
            HttpRequestMessage req, HttpControllerDescriptor desc, Type type)
        {
            if (type == typeof(UserApiController))
            {
                return (IHttpController)container.GetInstance(type);
            }

            return this.original.Create(req, desc, type);
        }
    }
}