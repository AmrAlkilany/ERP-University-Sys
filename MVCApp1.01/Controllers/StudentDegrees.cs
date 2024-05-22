using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCApp1._01.Models;
using MVCApp1._01.ViewModel;
using System.Linq;

namespace MVCApp1._01.Controllers
{
    public class StudentDegrees : Controller
    {
        FirstMvcAppEntities context = new FirstMvcAppEntities();
        public IActionResult ShowResult(int id)
        {
            Student stdModel = context.Students.Include(c => c.Courses).
                Include(r=>r.CoursesResults).FirstOrDefault(i=>i.Id==id);

            StudentNameWithCourseResult stdVM = new StudentNameWithCourseResult();

            stdVM.Id = stdModel.Id;
            stdVM.Name = stdModel.Name;
           
            foreach (var item in stdModel.Courses)
            {

                stdVM.Courses.Add(item.Name);
            }

            foreach (var item in stdModel.CoursesResults)
            {
                stdVM.Degrees.Add(item.Degree);
            }

           
            return View(stdVM);
        }
    }
}
