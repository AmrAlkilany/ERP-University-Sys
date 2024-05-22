using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCApp1._01.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCApp1._01.Controllers
{
    public class StudentController : Controller
    {
        FirstMvcAppEntities context = new FirstMvcAppEntities();

        public IActionResult Index()
        {
            List<Student> studentsModel = context.Students.ToList();


            return View(studentsModel);
        }

        public IActionResult New()
        {
            ViewData["Courses"] = context.Students;
            return View();
        }
    }
}
