using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace attendence_final
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "department",
              url: "department/{action}/{id}",
              defaults: new { controller = "departments", action = "Index", id = UrlParameter.Optional }
          );

            routes.MapRoute(
               name: "admin",
               url: "admin/{action}/{id}",
               defaults: new { controller = "Admins", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "faculty",
               url: "faculty/{action}/{id}",
               defaults: new { controller = "Faculties", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "student",
               url: "student/{action}/{id}",
               defaults: new { controller = "Students", action = "Index", id = UrlParameter.Optional }
           );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
