using MVCApp1._01.Models;
using System.Collections.Generic;

namespace MVCApp1._01.ViewModel
{
    public class StudentNameWithCourseResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Courses { get; set; } = new List<string>();
        public List<int> Degrees{ get; set; } = new List<int> ();
    }
}
