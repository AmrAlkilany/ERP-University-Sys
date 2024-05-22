using System.ComponentModel.DataAnnotations.Schema;

namespace MVCApp1._01.Models
{
    public class CourseResult
    {
        //[ForeignKey("Student")]
        public int StudentId { get; set; }

        //[ForeignKey("Course")]
        public int CourseId { get; set; }

        public int Degree { get; set; }

    }
}
