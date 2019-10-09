using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIndividual.DAL.CF
{
    public class Course
    {
        public int CourseID { get; set; }

        public string Title { get; set; }

        public int Cedits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
