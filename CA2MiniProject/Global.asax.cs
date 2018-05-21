using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Http;
using CA2MiniProject.App_Start;
using CA2MiniProject.DAL;
using CA2MiniProject.Logging;
using System.Data.Entity.Infrastructure.Interception;

namespace CA2MiniProject
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DbInterception.Add(new EnergyUsedInterceptorTransientErrors());
            DbInterception.Add(new EnergyUsedInterceptorLogging());
        }
    }
}
