using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Sample
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
           name: "Sample1",
           url: "Sample1",
           defaults: new { controller = "Sample1", action = "Index1", id = UrlParameter.Optional }
       );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Sample", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
