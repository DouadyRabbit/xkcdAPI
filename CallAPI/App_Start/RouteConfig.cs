using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CallAPI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


            routes.MapRoute(name: "xkcdImages",
                            url: "{controller}/{action}/{id}",
                            defaults: new { controller = "Home", action = "LoadImage", id = UrlParameter.Optional });

            routes.MapRoute(name: "xkcdImagesNext",
                           url: "{controller}/{action}/{id}",
                           defaults: new { controller = "Home", action = "MoveNext", id = UrlParameter.Optional });

            routes.MapRoute(name: "xkcdImagesPrev",
                           url: "{controller}/{action}/{id}",
                           defaults: new { controller = "Home", action = "MovePrevious", id = UrlParameter.Optional });
        }
    }
}
