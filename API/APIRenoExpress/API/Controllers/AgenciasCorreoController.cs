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
    public class AgenciasCorreoController : ApiController
    {
        // GET: api/AgenciasCorreo
        [HttpGet]
        [CustomErrorFilter]
        [Authorize]
        public IEnumerable<Agencias> GetDatosAgencias(string CodigoCliente, string Cod_Emp, string Cod_Pais, int TipoBusqueda)
        {
            IEnumerable<Agencias> result = null;
            Agencias iAgencias = new Agencias();
            iAgencias.CodigoCliente = CodigoCliente;
            iAgencias.Cod_Emp = Cod_Emp;
            iAgencias.Cod_Pais = Cod_Pais;
            iAgencias.TipoBusqueda = TipoBusqueda;
            Error oError = null;
            using (var model = new AgenciasCorreo_BBL())
            {
                result = model.GetAgenciasCorreo(iAgencias, ref oError);
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
