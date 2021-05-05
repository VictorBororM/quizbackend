using Oriflame.Facturacion.BBL;
using Oriflame.Facturacion.BE;
using System.Collections.Generic;
using System.Web.Http;

namespace Oriflame.Facturacion.API.Controllers
{
    public class ProdcutoController : ApiController
    {
        // GET: api/Prodcuto
        [HttpGet]
        [CustomErrorFilter]
        [Authorize]
        public IEnumerable<Producto> GetProducto(string Codigo_Producto, string Cod_Emp, string Cod_Pais)
        {
            IEnumerable<Producto> result = null;
            Producto iProducto = new Producto();
            iProducto.Codigo_Producto = Codigo_Producto;
            iProducto.Cod_Emp = Cod_Emp;
            iProducto.Cod_Pais = Cod_Pais;
            Error oError = null;
            using (var model = new Producto_BBL())
            {
                result = model.ObtenerProducto(iProducto, ref oError);
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
