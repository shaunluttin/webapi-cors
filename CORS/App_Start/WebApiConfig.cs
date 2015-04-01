using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CORS
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            EnableCrossSiteRequests(config);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        private static void EnableCrossSiteRequests(HttpConfiguration config)
        {
#if DEBUG
            var cors = new EnableCorsAttribute(origins: "*", headers: "*", methods: "*");
#else
            var cors = new EnableCorsAttribute("http://attendance1.azurewebsites.net", headers: "*", methods: "*");
#endif
            config.EnableCors(cors);
        }
    }
}
