using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using TemplateApi.Commons.Exceptions;

namespace TemplateApi.Commons.Filters
{
    public class TemplateExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is HttpException)
            {
                context.Result = new ContentResult
                {
                    Content = context.Exception.Message, 
                    StatusCode = (int)((HttpException)context.Exception).Status
                };
            }

        }
    }
}