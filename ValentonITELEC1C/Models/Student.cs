﻿

namespace ValentonITELEC1C.Models
{
    public enum Course
    {
        BSIT, BSCS, BSIS, OTHER
    }

    public class Student
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateEnrolled { get; set; }
        public double GPA { get; set; }
        public Course Course { get; set; }
        public string Email { get; set; }

    }
}
