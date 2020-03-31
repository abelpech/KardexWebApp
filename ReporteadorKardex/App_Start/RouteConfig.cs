using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;
using ReporteadorKardex.App_Start;

namespace ReporteadorKardex
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            //routes.EnableFriendlyUrls(settings);
            routes.EnableFriendlyUrls(settings, new MyWebFormsFriendlyUrlResolver());

        }
    }
}
