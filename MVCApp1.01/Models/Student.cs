using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCApp1._01.Models
{
    public class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }

        public ICollection<CourseResult> CoursesResults { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
