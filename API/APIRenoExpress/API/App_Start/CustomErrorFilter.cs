using MOD.RenoExpress;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http.Filters;

namespace API.RenoExpress
{
    public class CustomErrorFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            HttpStatusCode status = HttpStatusCode.InternalServerError;
            String message = String.Empty;
            var exceptionType = actionExecutedContext.Exception.GetType();
            if (exceptionType == typeof(UnauthorizedAccessException))
            {
                message = "Access to the Web API is not authorized.";
                status = HttpStatusCode.Unauthorized;
            }
            else if (exceptionType == typeof(DivideByZeroException))
            {
                message = "Internal Server Error.";
                status = HttpStatusCode.InternalServerError;
            }
            else if (exceptionType == typeof(ExceptionResults))
            {
                ExceptionResults exception = (ExceptionResults)actionExecutedContext.Exception;
                if (exception.ErrorResult.Equals("1"))
                {
                    message = "{ \"Resultado\": \"" + actionExecutedContext.Exception.Message + "\" }";
                    status = HttpStatusCode.OK;
                }
                else if (exception.ErrorResult.Equals("0"))
                {
                    message = "{ \"Error\": \"" + actionExecutedContext.Exception.Message + "\" }";
                    status = HttpStatusCode.InternalServerError;
                }else
                {
                    message = "{ \"Error\": \"" + "Internal Server Error." + "\" }";
                    status = HttpStatusCode.InternalServerError;
                }
            }
            else
            {
                message = actionExecutedContext.Exception.Message;
                status = HttpStatusCode.NotFound;
            }
            var formatter = new JsonMediaTypeFormatter();
            actionExecutedContext.Response = new HttpResponseMessage()
            {
                Content = new StringContent(message, System.Text.Encoding.UTF8, "application/json"),
                StatusCode = status
            };
            base.OnException(actionExecutedContext);
        }
    }
}