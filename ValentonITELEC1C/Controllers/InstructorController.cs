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
        [HttpGet]
        public IActionResult AddInstructor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            InstructorList.Add(newInstructor);
            return View("Index", InstructorList);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Instructor instructorChange)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == instructorChange.Id);
            if (instructor != null)
            {
               
                instructor.FirstName = instructorChange.FirstName;
                instructor.LastName = instructorChange.LastName;
                instructor.Rank = instructorChange.Rank;
                instructor.IsTenured = instructorChange.IsTenured;
                instructor.Email = instructorChange.Email;
                instructor.HiringDate = instructorChange.HiringDate;

            }
            return View("Index", InstructorList);
        }
    }


}