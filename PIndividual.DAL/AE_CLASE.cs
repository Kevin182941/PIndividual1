//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PIndividual.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class AE_CLASE
    {
        public AE_CLASE()
        {
            this.AE_RESERVA_BOLETO = new HashSet<AE_RESERVA_BOLETO>();
        }
    
        public int id { get; set; }
        public string desc_clase { get; set; }
        public string ind_estado { get; set; }
    
        public virtual ICollection<AE_RESERVA_BOLETO> AE_RESERVA_BOLETO { get; set; }
    }
}
