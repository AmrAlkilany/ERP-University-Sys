using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MVCApp1._01.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCApp1._01.Controllers
{
    public class InstructorController : Controller
    {
        FirstMvcAppEntities context = new FirstMvcAppEntities();

        public IActionResult Index()
        {
            List<Instructor> instructorsModel = context.Instructors.
                Include(t => t.Department).Include(t => t.Course).ToList();


            return View(instructorsModel);
        }

        public IActionResult New()  //Instructor newInstructor
        {
            ViewData["Courses"] = context.Courses.ToList();
            ViewData["Depts"] = context.Departments.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult SaveNew(Instructor newInstructor)
        {
            if (ModelState.IsValid == true)
            {
                context.Instructors.Add(newInstructor);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            ViewData["Courses"] = context.Courses.ToList();
            ViewData["Depts"] = context.Departments.ToList();
            return View("New", newInstructor);

        }


        public IActionResult Edit(int id)
        {
            Instructor instructor = context.Instructors.FirstOrDefault(t => t.Id == id);

            ViewData["Courses"] = context.Courses.ToList();
            ViewData["Depts"] = context.Departments.ToList();
            return View(instructor);
        }
        public IActionResult SaveEdit([FromRoute] int id, Instructor instructor)
        {
           
            if (ModelState.IsValid == true)
            {
                Instructor oldInstructor = context.Instructors.FirstOrDefault(t => t.Id == id);
                oldInstructor.Name = instructor.Name;
                oldInstructor.Image = instructor.Image;
                oldInstructor.Salary = instructor.Salary;
                oldInstructor.Address = instructor.Address;
                oldInstructor.DepartmentId = instructor.DepartmentId;
                oldInstructor.CrsId = instructor.CrsId;

                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["Courses"] = context.Courses.ToList();
            ViewData["Depts"] = context.Departments.ToList();
            return View("edit", instructor);


        }

        public IActionResult NameExist(string Name,int Id)//*** Handling edit and new fields *** //
        {
            Instructor inst = context.Instructors.FirstOrDefault(i => i.Name == Name);
            if(inst == null)
            {
                return Json(true);
            }
            return inst.Id==Id?Json(true):Json(false);  

        }

        public IActionResult Test()
        {

            return View();
        }
    }
}
