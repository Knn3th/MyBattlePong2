//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MBP.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public int Cuenta_idCuenta { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Tipo { get; set; }
        public System.DateTime FechaInscripcion { get; set; }
    
        public virtual Cuenta Cuenta { get; set; }
        public virtual Jugador Jugador { get; set; }
        public virtual Moderador Moderador { get; set; }
    }
}
