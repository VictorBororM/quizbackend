using Microsoft.Owin;
using API.RenoExpress.Provider;
using System;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using System.Web;


namespace API.RenoExpress.App_Start
{
    public delegate void SendToLog(HttpRequestMessage request, HttpResponseMessage response, ClaimsPrincipal user, bool isReply);

    public class CustomLogHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            ClaimsPrincipal user = ((OwinContext)request.GetOwinContext()).Authentication.User;
            var response = await base.SendAsync(request, cancellationToken);
            return response;
        }
    }
}