using DAL.RenoExpress.DAL;
using MOD.RenoExpress.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace BLL.RenoExpress.BL
{
    public class ProductosBL : IDisposable
    {
        public void Dispose()
        {

        }

        public object ConsultaProductoBL()
        {
            DatosProductosDAL db = new DatosProductosDAL();
            var datos = db.GetProductosDAL();
            string jsonDatos = JsonConvert.SerializeObject(datos);
            var obj = Json.Decode(jsonDatos);
            return obj;
        }

        public bool RealizarCompraBL(Compra compra)
        {
            DatosProductosDAL db = new DatosProductosDAL();
            var datos = db.RealizarCompraDAL(compra);
       
            return datos;
        }

        public bool RealizarVentaBL(Venta venta)
        {
            DatosProductosDAL db = new DatosProductosDAL();
            var datos = db.RealizarVentaDAL(venta);
            return datos;
        }
    }
}
