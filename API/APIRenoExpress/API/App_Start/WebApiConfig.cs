using API.RenoExpress.App_Start;
using System.Web.Http;

namespace API.RenoExpress
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Filters.Add(new CustomErrorFilter());
            config.MessageHandlers.Add(new CustomLogHandler());
        }
    }
}
