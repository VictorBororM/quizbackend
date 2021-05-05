
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using MOD.RenoExpress;
using MOD.RenoExpress.Models.Usuario;
using System.Reflection;
using System.Security.Claims;
using System.Threading.Tasks;

namespace API.RenoExpress
{
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            Error oError = new Error();
            try
            {
                string usuarioLogin = context.UserName;
                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

                IFormCollection parameters = await context.Request.ReadFormAsync();


                SesionUsuario sesionUsuario = new SesionUsuario();
                string GUID = Assembly.GetExecutingAssembly().GetType().GUID.ToString().ToUpper();
                Usuario userData = new Usuario()
                {
                    usuario = context.UserName
                };

                identity.AddClaim(new Claim(ClaimTypes.Name, usuarioLogin));
                identity.AddClaim(new Claim(ClaimTypes.GivenName, "nombre"));
                identity.AddClaim(new Claim(ClaimTypes.Country, context.Scope[0].ToString())); //Pais del usuario
                identity.AddClaim(new Claim(ClaimTypes.Locality, context.UserName.ToString()));//Localidad usuario
                identity.AddClaim(new Claim(ClaimTypes.System, context.Request.RemoteIpAddress));//Ip del cliente
                identity.AddClaim(new Claim(ClaimTypes.Hash, new Utils().GenerateStrongPassword(50)));  //Hash para logs
                identity.AddClaim(new Claim(ClaimTypes.GroupSid, userData.AutenticaAD.ToString()));//Tipo de autenticación

                var ticket = new AuthenticationTicket(identity, null);
                context.Validated(ticket);
            }
            catch (System.Exception ex)
            {
                context.SetError("ERROR - " + ex.Message);
                return;
            }
        }
    }
}