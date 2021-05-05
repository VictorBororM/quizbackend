using System;

namespace MOD.RenoExpress.Models.Usuario
{

    public class Usuario
    {
        #region Properties
        public string usuario { get; set; }

        public string Contrasenia { get; set; }

        public string PrimerNombre { get; set; }

        public string SegundoNombre { get; set; }

        public string PrimerApellido { get; set; }

        public string SegundoApellido { get; set; }

        public string CorreoElectronico { get; set; }


        public bool Activo { get; set; }

        public bool CambiarContrasenia { get; set; }

        public string Token { get; set; }
      
        public DateTime? TokenFechaDeUso { get; set; }

        public DateTime FechaCreacion { get; set; }
        public string usuariocreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string usuariomodificacion { get; set; }

        public bool AutenticaAD { get; set; }
        public string Message { get; set; }

        public bool Respuesta { get; set; }

        public bool Autenticated { get; set; }
        #endregion
    }
}


