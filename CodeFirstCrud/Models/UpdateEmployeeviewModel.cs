using System.Collections.Generic;

namespace CodeFirstCrud.Models
{
    public class UpdateEmployeeviewModel
    {
        public EmployeeViewModel Employee { get; set; }
        public List<DepartmentViewModel> Departments { get; set; }
    }
}
