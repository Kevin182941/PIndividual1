using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIndividual.BIN;
using PIndividual.DAL.CF;
using PIndividual.DAL.AE;

namespace PIndividual.Pruebas
{
    class Program 
    {
        static void Main(string[] args)
        {
            using (var context = new DBContextCFAE())
            {
                Console.WriteLine("Adding new Avion");

                var avion = new Avion
                {
                    IDAvion = 1,
                    Descripcion = "Pruebas",
                    Ind_estado = "Activo",
                    Asientos = 25

                };
                context.Aviones.Add(avion);
                context.SaveChanges();
            }



            //using (var context = new DBContextCF())
            //{
            //    Console.WriteLine("Adding new students");

            //    var student = new Student
            //    {
            //        FirstMidName = "Alain",
            //        LastName = "Bomer",
            //        EnrollmentDate = DateTime.Parse(DateTime.Today.ToString())

            //    };
            //    context.Students.Add(student);
            //    context.SaveChanges();
            //}

            //Logica.EliminarAvion();
        }


        
       /* public static void DataBaseFirst()
        {
            Logica p = new Logica();
            p.EliminarAvion();

        }*/
       
    }
}
