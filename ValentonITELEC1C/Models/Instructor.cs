﻿

namespace ValentonITELEC1C.Models
{
    public enum Rank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }

    public class Instructor
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IsTenured { get; set; }
        public Rank Rank { get; set; }
        public DateTime HiringDate { get; set; }
        public string Email { get; set; }

    }
}