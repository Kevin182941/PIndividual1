using System;
using System.Collections.Generic;

namespace PIndividual.DAL.AE
{
    public class Vuelo
    {
        public int IDVuelo { get; set; }

        public int Cod_compania { get; set; }

        public int Cod_pais_abordaje { get; set; }

        public int Cod_pais_destino { get; set; }

        public int Cod_avion { get; set; }

        public string Duracion { get; set; }

        public DateTime? Fec_vuelo { get; set; }

        public DateTime? Fec_salida { get; set; }

        public DateTime? Fec_entrada { get; set; }

        public string ind_estado { get; set; }




        public virtual ICollection<Compania> Companias { get; set; }

        public virtual ICollection<Pais> Paises { get; set; }

        public virtual ICollection<Avion> Avions { get; set; }


    }
}