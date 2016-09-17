using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Integround.Hubi.WebSite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "ComponentsRoute",
                url: "components/{action}",
                defaults: new { controller = "components", action = "index" }
            );

            routes.MapRoute(
                name: "DocumentationRoute",
                url: "documentation/{action}",
                defaults: new { controller = "documentation", action = "index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{action}",
                defaults: new { controller = "home", action = "index" }
            );
        }
    }
}
