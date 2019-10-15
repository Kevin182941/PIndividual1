using System;

namespace PIndividual.DAL.AE
{
    public class Pasajero
    {
        public int IDPasajero { get; set; }

        public string Identificacion { get; set; }

        public string Nombre { get; set; }

        public int Pasaporte { get; set; }

        public int Visa { get; set; }

        public DateTime? Fec_nacimiento { get; set; }

        public string correo_electronico { get; set; }

        public int telefono { get; set; }

        public int cod_estado { get; set; }

    }
}