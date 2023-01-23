using System.Net;

namespace TemplateApi.Commons.Exceptions
{
    public class NotFoundException : HttpException
    {
        public NotFoundException(string message) : base(HttpStatusCode.NotFound, message)
        {
        }
    }
}