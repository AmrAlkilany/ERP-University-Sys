using Microsoft.AspNetCore.Authentication.Cookies;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCApp1._01.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Instructor> Instructors { get; set; }
        public int MinDegree { get; set; }

        public ICollection<CourseResult> CoursesResults { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}
