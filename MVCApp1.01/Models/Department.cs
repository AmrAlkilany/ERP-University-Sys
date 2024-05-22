using System.Collections;
using System.Collections.Generic;

namespace MVCApp1._01.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }
        public ICollection<Instructor> Instructors { get; set; }




    }
}