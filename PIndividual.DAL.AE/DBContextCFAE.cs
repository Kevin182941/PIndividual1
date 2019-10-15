using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIndividual.DAL.AE
{
    public class DBContextCFAE : DbContext
    {
        //Llamar al constructor padre, esta llam
        public DBContextCFAE()
            : base("name=AECFEntities")
        {

        }
        public virtual DbSet<Avion> Aviones { get; set; }

        public virtual DbSet<Pasajero> Pasajeros { get; set; }

        public virtual DbSet<Pais> Paises { get; set; }

        public virtual DbSet<Clase> Clases { get; set; }

        public virtual DbSet<Compania> Companias { get; set; }

        public virtual DbSet<Vuelo> Vuelos { get; set; }

        public virtual DbSet<Reserva> Reservas { get; set; }

        public virtual DbSet<Pago> Pagos { get; set; }

        public virtual DbSet<Escala> Escalas { get; set; }
        
        public virtual DbSet<Boleto> Boletos { get; set; }


    }
}
