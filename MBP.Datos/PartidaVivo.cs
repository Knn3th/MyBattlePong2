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
    
    public partial class PartidaVivo
    {
        public int idPartida { get; set; }
        public string Publico { get; set; }
        public int Disparos { get; set; }
        public System.DateTime Fecha { get; set; }
        public int Jugador1_idCuenta { get; set; }
        public int Jugador2_idCuenta { get; set; }
        public int Tamano { get; set; }
        public string Estado { get; set; }
    
        public virtual Jugador Jugador { get; set; }
        public virtual Jugador Jugador1 { get; set; }
    }
}
