﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using UserSubManagementSystem.BackEnd.Core;
using UserSubManagementSystem.BackEnd.Controllers.Api;
using System.Reflection;
using UserSubManagementSystem.BackEnd.App_Start;

namespace UserSubManagementSystem.BackEnd
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            IocConfig.Configure();

            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

        

      
        }
    }
}