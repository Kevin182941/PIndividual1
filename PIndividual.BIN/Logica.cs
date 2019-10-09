using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIndividual.DAL;

namespace PIndividual.BIN
{
    public class Logica
    {

        public static int AgregarAvion(AE_TIPOS_AVIONES avion)
        {
            AeropuertoEntities contexto = null;
            try
            {
                contexto = new AeropuertoEntities(); 
                contexto.AE_TIPOS_AVIONES.Add(avion); 
                contexto.SaveChanges(); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return 1;
        }

        public static int AgregarPasajeros(AE_PASAJEROS pasajeros)
        {
            AeropuertoEntities contexto = null;
            try
            {
                contexto = new AeropuertoEntities();
                contexto.AE_PASAJEROS.Add(pasajeros);
                contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return 1;
        }

        public static int AgregarPais(AE_PAISES pais)
        {
            AeropuertoEntities contexto = null;
            try
            {
                contexto = new AeropuertoEntities();
                contexto.AE_PAISES.Add(pais);
                contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return 1;
        }

        public static int AgregarClase(AE_CLASE clase)
        {
            AeropuertoEntities contexto = null;
            try
            {
                contexto = new AeropuertoEntities();
                contexto.AE_CLASE.Add(clase);
                contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return 1;
        }

        public static int AgregarCompania(AE_COMPANIA compania)
        {
            AeropuertoEntities contexto = null;
            try
            {
                contexto = new AeropuertoEntities();
                contexto.AE_COMPANIA.Add(compania);
                contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return 1;
        }

        public static int AgregarBoletosAv(AE_BOLETOS_AVION boleto)
        {
            AeropuertoEntities contexto = null;
            try
            {
                contexto = new AeropuertoEntities();
                contexto.AE_BOLETOS_AVION.Add(boleto);
                contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return 1;
        }

        public static int AgregarEscalaVu(AE_ESCALAS_VUELOS escala)
        {
            AeropuertoEntities contexto = null;
            try
            {
                contexto = new AeropuertoEntities();
                contexto.AE_ESCALAS_VUELOS.Add(escala);
                contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return 1;
        }

        public static int AgregarPagoBo(AE_PAGO_BOLETO pago)
        {
            AeropuertoEntities contexto = null;
            try
            {
                contexto = new AeropuertoEntities();
                contexto.AE_PAGO_BOLETO.Add(pago);
                contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return 1;
        }

        public static int AgregarReservaBo(AE_PAGO_BOLETO reserva)
        {
            AeropuertoEntities contexto = null;
            try
            {
                contexto = new AeropuertoEntities();
                contexto.AE_PAGO_BOLETO.Add(reserva);
                contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return 1;
        }

        public static int AgregarVuelo(AE_VUELOS vuelo)
        {
            AeropuertoEntities contexto = null;
            try
            {
                contexto = new AeropuertoEntities();
                contexto.AE_VUELOS.Add(vuelo);
                contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (contexto != null)
                    contexto.Dispose();
            }

            return 1;
        }

        /////////////////////////////

        public void ModificarAvion()
        {
            using (AeropuertoEntities context = new AeropuertoEntities()) 
            try
            {
                var vuelo = context.AE_TIPOS_AVIONES.Where(x => x.id == 1).SingleOrDefault();
                vuelo.desc_avion = "cambio";
                context.SaveChanges();
            }
            catch (Exception exp)
            {

                Console.WriteLine("Error: " + exp.Message);
            }
        }



    }
}
