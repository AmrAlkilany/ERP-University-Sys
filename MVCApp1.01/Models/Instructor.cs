using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCApp1._01.Models
{
    public class Instructor
    {
        public int Id { get; set; }

        [Display(Name = "Instructor Name")]
        [Required(ErrorMessage = "Name is required")]
        [RegularExpression(pattern: "^[a-z,A-Z]{3,}$",
            ErrorMessage = "Name must contain charechter only and more than 2 letters")]
        [Remote(action:"NameExist",controller:"Instructor",
            ErrorMessage ="Name Already Exist",AdditionalFields = "Id")]
        public string Name { get; set; }

        [Display(Name = "Profile Image")]
        public string Image { get; set; }

        [DataType(DataType.Currency)]
        public int Salary { get; set; }

        [MaxLength(50)]
        public string Address { get; set; }

        //[ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }


        [ForeignKey("Course")]
        public int CrsId { get; set; }
        public Course Course { get; set; }
    }
}
