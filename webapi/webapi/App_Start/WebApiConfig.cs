using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Web.Http;
using webapi.Attribute;

namespace webapi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var formatters = config.Formatters;
            formatters.Remove(formatters.XmlFormatter);

            //var jsonSettings = formatters.JsonFormatter.SerializerSettings;
            //// Transforma o atributo em lowerCamelCase segundo recomendação
            //jsonSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            ////// Ignora valores nulos
            //jsonSettings.NullValueHandling = NullValueHandling.Ignore;
            ////// Ignora valores default
            //jsonSettings.DefaultValueHandling = DefaultValueHandling.Ignore;

            //// Comprimindo usando o algoritmo GZip
            //config.MapHttpAttributeRoutes();
            //config.Filters.Add(new GZipCompressionAttribute());

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
