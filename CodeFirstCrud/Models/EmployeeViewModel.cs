using System.ComponentModel.DataAnnotations;

namespace CodeFirstCrud.Models
{
    public class EmployeeViewModel
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

        [Display(Name = "RelationShip Status")]
        public bool Single { get; set; }

        [Display(Name = "Department Name")]
        [Range(0, int.MaxValue, ErrorMessage = "Select valid department")]
        public int? DepartmentId { get; set; }

        public DepartmentViewModel Department { get; set; }
    }
}
