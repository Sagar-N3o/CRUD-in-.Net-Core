using System.ComponentModel.DataAnnotations;

namespace CodeFirstCrud.Models
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Deprtment name is required field")]
        [MinLength(50, ErrorMessage = "Department name must be within 50 characters.")]
        [Display(Name = "Department Name")]
        public string Name { get; set; }
    }
}