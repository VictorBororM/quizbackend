using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD.RenoExpress.Models
{
    public class Compra
    {
        public string nombreCompra{ get; set; }
        public string observacionCompra { get; set; }
        public string fechaCompra { get; set; }
        public string usuarioID { get; set; }

        public List<DetalleCompra> detalleCompra { get; set; }

    }

    public class DetalleCompra
    {
        public int ProdID { get; set; }
        public int cantidadDte { get; set; }
        public double precioCompraDte { get; set; }
    }
}
