﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SchoolProject.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
