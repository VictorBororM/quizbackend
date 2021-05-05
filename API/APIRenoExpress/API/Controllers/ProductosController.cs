using BLL.RenoExpress.BL;
using MOD.RenoExpress.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Script.Serialization;
namespace API.RenoExpress.Controllers
{
    public class ProductosController : ApiController
    {
        [HttpGet]
        [CustomErrorFilter]
        [Route("~/api/GetProductos")]
        public HttpResponseMessage PreCallBackAcepta()
        {
            ProductosBL logic = new ProductosBL();
            var respuesta = logic.ConsultaProductoBL();
            return Request.CreateResponse<object>(respuesta);
        }

        [HttpPost]
        [CustomErrorFilter]
        [Route("~/api/IngresarCompra")]
        public HttpResponseMessage IngresarCompra(Compra compra)
        {
            ProductosBL logic = new ProductosBL();
            var respuesta = logic.RealizarCompraBL(compra);
            return Request.CreateResponse<bool>(respuesta);
        }

        [HttpPost]
        [CustomErrorFilter]
        [Route("~/api/IngresarVenta")]
        public HttpResponseMessage IngresarVenta(Venta venta)
        {
            ProductosBL logic = new ProductosBL();
            var respuesta = logic.RealizarVentaBL(venta);
            return Request.CreateResponse<bool>(respuesta);
        }
    }
}