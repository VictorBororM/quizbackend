
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MOD.RenoExpress
{
    public class Error
    {
        public string Resultado { get; set; }
        public string Descripcion { get; set; }
        [JsonProperty("Error")]
        public string error { get; set; }
        public object DatosAdicionales { get; set; }
        public string message_helpshift { get; set; }
        public string aplica_fcc { get; set; } = "false";
        public string codigo_feic { get; set; } 
    }
}
