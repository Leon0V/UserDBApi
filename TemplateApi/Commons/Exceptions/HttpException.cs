using System.Net;

namespace TemplateApi.Commons.Exceptions
{
    public class HttpException : Exception
    {
        public HttpStatusCode Status { get; set; }
        public HttpException(HttpStatusCode status, string message) : base(message)
        {
            Status = status;
        }
    }
}