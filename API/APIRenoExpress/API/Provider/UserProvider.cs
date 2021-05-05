using System.Linq;
using System.Security.Claims;

namespace API.RenoExpress.Provider
{
    public class UserProvider
    {
        public SesionUsuario Usuario { get; } = new SesionUsuario();

        public UserProvider(ClaimsPrincipal user)
        {
            try {


                #region CodigoEmpresa
                var lstEmpresa = user.Claims.Where(c => c.Type == ClaimTypes.Locality)
                                  .Select(c => c.Value);
                if (lstEmpresa.Count() < 1)
                {
                    Usuario.Cod_emp = "ND";
                }
                else
                {
                    var codempresa = lstEmpresa.First();
                    Usuario.Cod_emp = (codempresa == null ? "" : codempresa.ToString());
                }
                #endregion

                #region CodigoPais
                var lstPais = user.Claims.Where(c => c.Type == ClaimTypes.Country)
                                  .Select(c => c.Value);
                if (lstPais.Count() < 1)
                {
                    Usuario.Cod_Pais = "ND";
                }
                else
                {
                    var codpais = lstPais.First();
                    Usuario.Cod_Pais = (codpais == null ? "" : codpais.ToString());
                }
                #endregion

                #region DateOfBirth
                var lstDateOfBirth = user.Claims.Where(c => c.Type == ClaimTypes.DateOfBirth)
                                  .Select(c => c.Value);
                if (lstDateOfBirth.Count() < 1)
                {
                    Usuario.Rol_nombre = "ND";
                }
                else
                {
                    var Date_of_birth = lstDateOfBirth.First();
                    Usuario.Date_of_birth = (Date_of_birth == null ? "" : Date_of_birth.ToString());
                }
                #endregion

                #region Nombrecompleto
                var lstNombreCompleto = user.Claims.Where(c => c.Type == ClaimTypes.GivenName)
                                  .Select(c => c.Value);
                if (lstNombreCompleto.Count() < 1)
                {
                    Usuario.Usuario_nombre_completo = "ND";
                }
                else
                {
                    var usuarionombrecompleto = lstNombreCompleto.First();
                    Usuario.Usuario_nombre_completo = (usuarionombrecompleto == null ? "" : usuarionombrecompleto.ToString());
                }
                #endregion

                #region UsuarioNombre
                var lstUsuarioNombre = user.Claims.Where(c => c.Type == ClaimTypes.Name)
                                  .Select(c => c.Value);
                if (lstUsuarioNombre.Count() < 1)
                {
                    Usuario.Usuario_nombre = "ND";
                }
                else
                {
                    var usuarionombre = lstUsuarioNombre.First();
                    Usuario.Usuario_nombre = (usuarionombre == null ? "" : usuarionombre.ToString());
                }
                #endregion

                #region Token
                var lsttoken = user.Claims.Where(c => c.Type == ClaimTypes.Hash)
                   .Select(c => c.Value);
                if (lsttoken.Count() < 1)
                {
                    Usuario.Token = "ND";
                }
                else
                {
                    var token = lsttoken.First();
                    Usuario.Token = (token == null ? "" : token.ToString());
                }

                #endregion

                #region IP
                var lstip = user.Claims.Where(c => c.Type == ClaimTypes.System)
                   .Select(c => c.Value);
                if (lstip.Count() < 1)
                {
                    Usuario.Ip = "ND";
                }
                else
                {
                    var ip = lstip.First();
                    Usuario.Ip = (ip == null ? "" : ip.ToString());
                }
                #endregion

                #region Pais
                var lstpais = user.Claims.Where(c => c.Type == ClaimTypes.GroupSid)
                   .Select(c => c.Value);
                if (lstpais.Count() < 1)
                {
                    Usuario.Pais = "ND";
                }
                else
                {
                    var pais = lstpais.First();
                    Usuario.Pais = (pais == null ? "" : pais.ToString());
                }
                #endregion

            }catch
            {
                throw;
            }
        }
    }
}