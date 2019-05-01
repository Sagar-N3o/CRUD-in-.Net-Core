using System.ComponentModel.DataAnnotations;

namespace CodeFirstCrud.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Maximum 50 character allowed for FirstName")]
        public string FirstName { get; set; }

        [StringLength(50, ErrorMessage = "Maximum 50 character allowed for LastName")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Enter Email Address")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$",
            ErrorMessage = "Please Enter Correct Email Address")]
        public string Email { get; set; }

        public bool Single { get; set; }

        public int? DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
