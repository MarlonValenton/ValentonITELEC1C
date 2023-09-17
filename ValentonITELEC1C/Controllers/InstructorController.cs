using Microsoft.AspNetCore.Mvc;
using ValentonITELEC1C.Models;


namespace ValentonITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>
            {
                new Instructor()
                {
                    Id= 1,FirstName = "Gabriel",LastName = "Montano", Rank = Rank.Professor, HiringDate = DateTime.Parse("2022-08-26"), Email = "ghaby021@gmail.com", IsTenured = "Yes"
                },
                new Instructor()
                {
                    Id= 2,FirstName = "Zyx",LastName = "Montano", Rank = Rank.AssociateProfessor, HiringDate = DateTime.Parse("2022-08-07"), Email = "zyx@gmail.com", IsTenured = "No"
                },
                new Instructor()
                {
                    Id= 3,FirstName = "Aerdriel",LastName = "Montano", Rank = Rank.Instructor,  HiringDate = DateTime.Parse("2020-01-25"), Email = "aerdriel@gmail.com", IsTenured = "Yes"
                }
            };
        public IActionResult Index()
        {

            return View(InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = InstructorList.FirstOrDefault(ins => ins.Id == id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();
        }

    }
}
