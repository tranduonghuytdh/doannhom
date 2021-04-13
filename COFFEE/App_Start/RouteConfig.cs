using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Xml.Linq;

namespace COFFEE
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        { 
         routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{*botdetect}",
            new { botdetect = @"(.*)BotDetectCaptcha\.ashx" });

            routes.MapRoute(
               name: "san-pham",
               url: "san-pham",
               defaults: new { controller = "Product", action = "Index", id = UrlParameter.Optional
                },
               namespaces: new[] { "COFFEE.Controllers" }
           );
            routes.MapRoute(
                name: "them-gio-hang",
                url: "them-gio-hang",
                defaults: new { controller = "CartItem", action = "AddItem", id = UrlParameter.Optional },
                namespaces: new[] { "COFFEE.Controllers" }

            );
            routes.MapRoute(
               name: "gio-hang",
               url: "gio-hang",
               defaults: new { controller = "CartItem", action = "Index", id = UrlParameter.Optional },
               namespaces: new[] { "COFFEE.Controllers" }

            );
            routes.MapRoute(
              name: "Payment",
              url: "thanh-toan",
              defaults: new { controller = "CartItem", action = "Payment", id = UrlParameter.Optional },
              namespaces: new[] { "COFFEE.Controllers" }
            );
            routes.MapRoute(
                name: "Home",
                url: "home-master",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "COFFEE.Controllers" }
            );
            routes.MapRoute(
                 name: "Success",
                 url: "hoan-thanh",
                 defaults: new { controller = "CartItem", action = "Success", id = UrlParameter.Optional },
                 namespaces: new[] { "COFFEE.Controllers" }
             );
            routes.MapRoute(
                name: "Contact",
                url: "lien-he",
                defaults: new { controller = "Contect", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "COFFEE.Controllers" }
            );
            routes.MapRoute(
                name: "Register",
                url: "dang-ky",
                defaults: new { controller = "User", action = "Register", id = UrlParameter.Optional },
                namespaces: new[] { "COFFEE.Controllers" }
            );
            routes.MapRoute(
         name: "Login",
         url: "dang-nhap",
         defaults: new { controller = "User", action = "Login", id = UrlParameter.Optional },
         namespaces: new[] { "COFFEE.Controllers" }
     );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "COFFEE.Controllers" }
            );

        }
    }
}
