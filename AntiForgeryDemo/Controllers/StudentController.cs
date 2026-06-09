using Microsoft.AspNetCore.Mvc;
using AntiForgeryDemo.Models;

namespace AntiForgeryDemo.Controllers
{
    public class StudentController : Controller
    {
        // GET METHOD
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // POST METHOD
        [HttpPost]

        [ValidateAntiForgeryToken]

        public IActionResult Register(Student student)
        {
            ViewBag.Message =
                "Student Registered Successfully";

            return View();
        }

    }
}