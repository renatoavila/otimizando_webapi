using webapi.Helpers;
using System.Net.Http;
using System.Web.Http.Filters;

namespace webapi.Attribute
{
    public class GZipCompressionAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            var content = actionExecutedContext.Response.Content;
            var bytes = content?.ReadAsByteArrayAsync().Result;
            var compressedContent = bytes == null ? new byte[0] :
            CompressionHelper.GZipByte(bytes);
            actionExecutedContext.Response.Content = new ByteArrayContent(compressedContent);
            actionExecutedContext.Response.Content.Headers.Add("Content-encoding", "gzip");
            actionExecutedContext.Response.Content.Headers.Remove("Content-Type");
            actionExecutedContext.Response.Content.Headers.Add("Content-Type", "application/json");
            base.OnActionExecuted(actionExecutedContext);
        }
    }


}