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

            int subcategoryBranchingNumber = 3;
            string categoryUrl = "category";
            string newsUrl = "news";

            for (int i = 0; i < subcategoryBranchingNumber; i++)
            {
                categoryUrl += "/{category" + i + "}";

                routes.MapRoute(
                    name: "Category " + i,
                    url: categoryUrl,
                    defaults: new { controller = "NewsCategory", action = "HomePage" }
                );

                newsUrl += "/{category" + i + "}";

                routes.MapRoute(
                    name: "News " + i,
                    url: newsUrl + "/{news}",
                    defaults: new { controller = "News", action = "Details" }
                );
            }

            routes.MapRoute(
               name: "Archive",
               url: "archive",
               defaults: new { controller = "Website", action = "Archive" }
            );

            routes.MapRoute(
                name: "ArchiveDate",
                url: "archive/{date}",
                defaults: new { controller = "Website", action = "ArchiveDate" }
            );
        }
    }
}
