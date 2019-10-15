using System.Collections.Generic;

namespace PIndividual.DAL.AE
{
    public class Boleto
    {
        public int IDBoleto { get; set; }

        public int Cod_vuelo { get; set; }

        public decimal Precio { get; set; }

        public string Ind_estado { get; set; }

        public virtual ICollection<Vuelo> Vuelos { get; set; }
    }
}