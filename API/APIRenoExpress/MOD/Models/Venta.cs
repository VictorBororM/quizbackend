using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD.RenoExpress.Models
{
    public class Venta
    {
        public string nombreVenta { get; set; }
        public string observacionVenta{ get; set; }
        public string fechaVenta{ get; set; }
        public string usuarioID { get; set; }

        public List<DetalleVenta> detalleVenta { get; set; }
     
    }

    public class DetalleVenta
    {
        public int ProdID { get; set; }
        public int cantidadDte { get; set; }
        public double precioVentaDte { get; set; }
    }
}
