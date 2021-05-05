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
    public class AsociadosClienteController : ApiController
    {
        // GET: api/AsociadosCliente
        [HttpGet]
        [CustomErrorFilter]
        [Authorize]
        public IEnumerable<Cliente> GetDatosGeneralesClienteAsociado(string CodigoCliente, string Cod_Emp, string Cod_Pais, string TipoCliente)
        {
            IEnumerable<Cliente> result = null;
            Cliente iCliente = new Cliente();
            iCliente.CodigoCliente = CodigoCliente;
            iCliente.Cod_Emp = Cod_Emp;
            iCliente.Cod_Pais = Cod_Pais;
            iCliente.TipoCliente = TipoCliente;
            Error oError = null;
            using (var model = new ClienteAsociado_BBL())
            {
                result = model.GetDatosGeneralesClienteAsociado(iCliente, ref oError);
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
