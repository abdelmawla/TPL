﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameWorkLearn.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public decimal? Grade { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
