using System.Collections.Generic;

namespace PIndividual.DAL.AE
{
    public class Reserva
    {
        public int IDReserva { get; set; }

        public int Cod_boleto { get; set; }

        public int Cod_pasajero { get; set; }

        public int Cod_clase { get; set; }

        public string Num_asiento { get; set; }

        public string Ind_estado { get; set; }


        public virtual ICollection<Boleto> Boletos { get; set; }

        public virtual ICollection<Pasajero> Pasajeros { get; set; }

        public virtual ICollection<Clase> Clases { get; set; }

        




    }
}