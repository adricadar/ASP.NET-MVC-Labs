using System.Web.Mvc;
using System.Web.Routing;

namespace Lab12.MiniApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "redirect",
                url: "{name}",
                defaults: new { controller = "Url", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Url", action = "Shorten", id = UrlParameter.Optional }
            );
        }
    }
}
