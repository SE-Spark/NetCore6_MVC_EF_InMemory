using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sms_web.Models;
using sms_web.Repository.Interface;

namespace sms_web.Controllers
{
    
    public class StudentController : Controller
    {
        private IStudent studentRepo;
        public StudentController(IStudent studentRepo)
        {
            this.studentRepo = studentRepo;
        }
        // GET: StudentController
        public ActionResult Index()
        {
            var students = studentRepo.GetStudents();
            return View(students);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            var student = studentRepo.GetStudent(id);
            return View(student);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            try
            {                

                studentRepo.createStudent(student);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            var student = studentRepo.GetStudent(id);
            return View(student);
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Student student)
        {
            try
            {
                studentRepo.EditStudent(id, student);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            var student = studentRepo.GetStudent(id);
            return View(student);
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                studentRepo.DeleteStudent(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
