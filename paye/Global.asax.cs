﻿using AutoMapper;
using Paye.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Paye
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<MessageProfile>();
                cfg.AddProfile<RoomProfile>();
                cfg.AddProfile<UserProfile>();
            });

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
