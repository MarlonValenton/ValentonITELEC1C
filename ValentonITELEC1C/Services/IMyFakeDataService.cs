using ValentonITELEC1C.Models;

namespace ValentonITELEC1C.Services
{
    public interface IMyFakeDataService
    {
        List<Student> StudentList { get; }
        List<Instructor> InstructorList { get; }
    }
}
