using Microsoft.AspNetCore.Mvc;
using ValentonITELEC1C.Data;
using ValentonITELEC1C.Models;
using ValentonITELEC1C.Services;

namespace ValentonITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _dbContext;

        public StudentController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public IActionResult Index()
        {

            return View(_dbContext.Students);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = _dbContext.Students.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {
            _dbContext.Students.Add(newStudent);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", _dbContext.Students);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Student? student = _dbContext.Students.FirstOrDefault(st => st.Id == id);

            if (student != null)
                return View(student);

            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Student studentChange)
        {
            Student? student = _dbContext.Students.FirstOrDefault(st => st.Id == studentChange.Id);
            if (student != null)
            {
                student.Id = studentChange.Id;
                student.FirstName = studentChange.FirstName;
                student.LastName = studentChange.LastName;
                student.Course = studentChange.Course;
                student.GPA = studentChange.GPA;
                student.Email = studentChange.Email;
                student.DateEnrolled = studentChange.DateEnrolled;
                _dbContext.SaveChanges();

            }
            return View("Index", _dbContext.Students);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Student? student = _dbContext.Students.FirstOrDefault(st => st.Id == id);

            if (student != null)
                return View(student);

            return NotFound();
        }

        [HttpPost]

        public IActionResult Delete(Student deleteStudent, int id)
        {
            Student? student = _dbContext.Students.FirstOrDefault(st => st.Id == id);

            if (student != null)
            {
                _dbContext.Students.Remove(student);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }



    }


}
