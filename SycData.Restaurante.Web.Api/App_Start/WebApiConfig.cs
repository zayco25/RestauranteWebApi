using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApiSegura.Security;

namespace SycData.Restaurante.Web.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            // Configuración y servicios de API web
            // Rutas de API web
             
             

            config.MapHttpAttributeRoutes(); 
            config.MessageHandlers.Add(new TokenValidationHandler());



            var corsAttr = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(corsAttr);




            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

        }
    }
}
