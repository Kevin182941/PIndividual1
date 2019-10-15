namespace PIndividual.DAL.AE
{
    public class Pago
    {
        public int IDPago { get; set; }

        public int Comprobante { get; set; }

        public int Cod_reserva { get; set; }

        public decimal  Monto_boleto { get; set; }

        public int Impuesto { get; set; }


        public string Ind_estado { get; set; }

        public virtual System.Collections.Generic.ICollection<Reserva> Reservas { get; set; }
    }
}