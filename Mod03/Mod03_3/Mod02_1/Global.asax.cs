using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Mod02_1.DAL;
using System.Data.Entity;


namespace Mod02_1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Database.SetInitializer(new OperasInitializer());
            GlobalFilters.Filters.Add(new LogActionFilter());
        }
    }
}
