using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIndividual.Pruebas.PrimerServicio;

namespace PIndividual.Pruebas
{
    class Program 
    {
        static void Main(string[] args)
        {

            PrimerServicioSoapClient cliente = new PrimerServicioSoapClient();
            String respuesta = cliente.HelloWorld();
            //using (var context = new DBContextCF())
            //{
            //    Console.WriteLine("Adding new Students");

            //    var student = new Student
            //    {
                   
            //        FirstMidName = "Pruebas",
            //        LastName = "Activo",
            //        EnrollmentDate = Convert.ToDateTime("01/01/2019")
                    
                 

            //    };
            //    context.Students.Add(student);
            //    context.SaveChanges();
        



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
