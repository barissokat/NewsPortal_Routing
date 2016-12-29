using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NewsPortal_Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Home",
                url: "home",
                defaults: new { controller = "Website", action = "HomePage" }
            );

            routes.MapRoute(
                name: "Category",
                url: "category/{category}",
                defaults: new { controller = "NewsCategory", action = "HomePage" }
            );
        }
    }
}
