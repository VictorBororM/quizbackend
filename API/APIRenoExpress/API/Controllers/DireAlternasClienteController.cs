using Oriflame.Facturacion.BBL;
using Oriflame.Facturacion.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Oriflame.Facturacion.API.Controllers
{
    public class DireAlternasClienteController : ApiController
    {
        // GET: api/DireAlternasCliente
        [HttpGet]
        [CustomErrorFilter]
        [Authorize]
        public IEnumerable<Cliente> GetDirAlternasCliente(string CodigoCliente, string Cod_Emp, string Cod_Pais, string Cod_TipoCliente, string Cod_Tribafiliado)
        {
            IEnumerable<Cliente> result = null;
            Cliente iCliente = new Cliente();
            iCliente.CodigoCliente = CodigoCliente;
            iCliente.Cod_Emp = Cod_Emp;
            iCliente.Cod_Pais = Cod_Pais;
            iCliente.TipoCliente = Cod_TipoCliente;
            iCliente.Cod_Trib = Cod_Tribafiliado;
            Error oError = null;
            using (var model = new GetDireccionAlternaCliente_BBL())
            {
                result = model.GetDirAlternasCliente(iCliente, ref oError);
            }
            if (oError != null)
            {
                ExceptionResults exception = new ExceptionResults(oError.Descripcion);
                exception.ErrorResult = oError.Resultado;
                throw exception;
            }
            return result;
        }
    }
}
