using Microsoft.AspNetCore.Mvc;
using MVCApp1._01.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCApp1._01.Controllers
{
    public class DeptController : Controller
    {
        public FirstMvcAppEntities context;
        public DeptController(FirstMvcAppEntities _context)
        {
            context = _context;
        }
        //get all depts
        public IActionResult Index()
        {   
            //FirstMvcAppEntities context = new FirstMvcAppEntities();
            List<Department> deptsModel = context.Departments.ToList();
            return View(deptsModel);
        }
    }
}
