﻿using System;
using System.Collections.Generic;

namespace PIndividual.DAL.CF
{
    public class Student
    {
        public int ID { get; set; }

        public string LastName { get; set; }

        public string FirstMidName { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }
}