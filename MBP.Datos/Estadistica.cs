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
    
    public partial class Estadistica
    {
        public int Jugador_Usuario_Cuenta_idCuenta { get; set; }
        public int TotalPartidas { get; set; }
        public int TotalGanadas { get; set; }
        public int TotalDisparos { get; set; }
        public int TotalAcertados { get; set; }
        public int TotalPuntos { get; set; }
        public int PuntosGanados { get; set; }
    
        public virtual Jugador Jugador { get; set; }
    }
}
