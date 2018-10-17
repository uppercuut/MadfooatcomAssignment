﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using UserSubManagementSystem.BackEnd.Controllers.Api;
using UserSubManagementSystem.BackEnd.Core;
using UserSubManagementSystem.BackEnd.Persistence;

namespace UserSubManagementSystem.BackEnd
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

 


        }
    }
}
