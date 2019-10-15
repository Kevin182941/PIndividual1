using System;
using System.Collections.Generic;

namespace PIndividual.DAL.AE
{
    public class Escala
    {
        public int IDEscala { get; set; }

        public int Cod_vuelo { get; set; }

        public int Cod_pais { get; set; }

        public string duracion_escala { get; set; }

        public DateTime? Fec_vuelo { get; set; }

        public string Ind_estado { get; set; }

        public virtual ICollection<Vuelo> Vuelos { get; set; }

        public virtual ICollection<Pais> Pais { get; set; }
    }
}