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
    
    public partial class HistorialPartida
    {
        public int idHistorialPartida { get; set; }
        public Nullable<int> Ganador { get; set; }
        public Nullable<int> NavesDestruidas1 { get; set; }
        public Nullable<int> NavesDestruidas2 { get; set; }
        public int Partida_idPartida { get; set; }
    
        public virtual Partida Partida { get; set; }
    }
}