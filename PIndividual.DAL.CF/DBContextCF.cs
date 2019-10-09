using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIndividual.DAL.CF
{
    public class DBContextCF : DbContext
    {
        //Llamar al constructor padre, esta llam
        public DBContextCF() 
            : base("name=CFEntities")
        {

        }
        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<Enrollment> Enrollments { get; set; }

        public virtual DbSet<Student> Students { get; set; }
    }
}
