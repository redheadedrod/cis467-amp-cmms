using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CIS467_AMP
{
    public class RouteConfig
    {

        /**
         * 
         * Routes will be configured and mapped to each individual area of the web application
         *
         */
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


            /**
             * 
             * Default routes configured to each Area of the project
             * 
             */
    
            routes.MapRoute(
                name: "Admin",
                url: "Admin/{controller}/{action}/{id}",
                defaults: new { controller = "Admin", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "StockRoom",
                url: "StockRoom/{controller}/{action}/{id}",
                defaults: new { controller = "StockRoom", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Maintenance",
                url: "Maintenance/{controller}/{action}/{id}",
                defaults: new { controller = "Maintenance", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Logbook",
                url: "Logbook/{controller}/{action}/{id}",
                defaults: new { controller = "Logbook", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Shared",
                url: "Shared/{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
