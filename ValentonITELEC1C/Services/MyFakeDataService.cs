
using ValentonITELEC1C.Services;
using ValentonITELEC1C.Models;
namespace ValentonITELEC1C.Services
{
    public class MyFakeDataService : IMyFakeDataService
    {
        public List<Student> StudentList { get; }
        public List<Instructor> InstructorList { get; }
        //Constructor
        public MyFakeDataService()
        {
            StudentList = new List<Student>()
            {
                new Student()
                {
                    Id= 1,FirstName = "Gabriel",LastName = "Montano", Course = Course.BSIT, DateEnrolled = DateTime.Parse("2022-08-26"), GPA = 1.5, Email = "ghaby021@gmail.com"
                },
                new Student()
                {
                    Id= 2,FirstName = "Zyx",LastName = "Montano", Course = Course.BSIS, DateEnrolled = DateTime.Parse("2022-08-07"), GPA = 1, Email = "zyx@gmail.com"
                },
                new Student()
                {
                    Id= 3,FirstName = "Aerdriel",LastName = "Montano", Course = Course.BSCS, DateEnrolled = DateTime.Parse("2020-01-25"), GPA = 1.5, Email = "aerdriel@gmail.com"
                }
            };

            InstructorList = new List<Instructor>()
            {
                new Instructor()
                {
                    Id= 1,FirstName = "Gabriel",LastName = "Montano", Rank = Rank.Professor, HiringDate = DateTime.Parse("2022-08-26"), Email = "ghaby021@gmail.com", IsTenured = IsTenured.Permanent
                },
                new Instructor()
                {
                    Id= 2,FirstName = "Zyx",LastName = "Montano", Rank = Rank.AssociateProfessor, HiringDate = DateTime.Parse("2022-08-07"), Email = "zyx@gmail.com", IsTenured = IsTenured.Probationary
                },
                new Instructor()
                {
                    Id= 3,FirstName = "Aerdriel",LastName = "Montano", Rank = Rank.Instructor,  HiringDate = DateTime.Parse("2020-01-25"), Email = "aerdriel@gmail.com", IsTenured = IsTenured.Permanent
                }
            };
        }

    }
}
