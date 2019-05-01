using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstCrud.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Deprtment name is required field")]
        [MinLength(50, ErrorMessage = "Department name must be within 50 characters")]
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
