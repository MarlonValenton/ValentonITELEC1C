using Microsoft.AspNetCore.Mvc;
using ValentonITELEC1C.Data;
using ValentonITELEC1C.Models;
using ValentonITELEC1C.Services;


namespace ValentonITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
       private readonly AppDbContext _dbContext;

        public InstructorController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public IActionResult Index()
        {

            return View(_dbContext.Instructors);
        }


        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(ins => ins.Id == id);

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
            _dbContext.Instructors.Add(newInstructor);
            _dbContext.SaveChanges();
            return View("Index", _dbContext.Instructors);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Instructor instructorChange)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == instructorChange.Id);
            if (instructor != null)
            {
               
                instructor.FirstName = instructorChange.FirstName;
                instructor.LastName = instructorChange.LastName;
                instructor.Rank = instructorChange.Rank;
                instructor.IsTenured = instructorChange.IsTenured;
                instructor.Email = instructorChange.Email;
                instructor.HiringDate = instructorChange.HiringDate;
                _dbContext.SaveChanges();

            }
            return View("Index", _dbContext.Instructors);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }

        [HttpPost]

        public IActionResult Delete(Instructor deleteInstructor, int id)
        {
            Instructor? instructor = _dbContext.Instructors.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
            {
                _dbContext.Instructors.Remove(instructor);
                _dbContext.SaveChanges();    
                return RedirectToAction("Index");
            }
            return NotFound();
        }

    }


}