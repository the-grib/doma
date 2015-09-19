using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Owin;
using Todom.Facade;

[assembly: OwinStartup(typeof (Startup))]

namespace Todom.Facade
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            ConfigureWebApi(config);

            app.UseCors(CorsOptions.AllowAll);
            app.UseWebApi(config);
            app.UseStageMarker(PipelineStage.MapHandler);
        }

        public static void ConfigureWebApi(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute("DefaultApi", "{controller}/{id}", new {id = RouteParameter.Optional});
            config.Routes.MapHttpRoute("DefaultCatchall", "{*url}", new {controller = "Error", action = "404"});

            config.Formatters.JsonFormatter.SerializerSettings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                NullValueHandling = NullValueHandling.Ignore
            };
        }
    }
}