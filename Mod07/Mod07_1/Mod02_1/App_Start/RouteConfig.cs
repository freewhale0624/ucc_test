using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Mod02_1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //  name: "OperaTitleRoute",
            //  url: "opera/title/{title}",
            //  defaults: new {
            //      controller = "opera",
            //      action = "DetailsByTitle",
            //      title = UrlParameter.Optional }
            //);

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Opera", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
