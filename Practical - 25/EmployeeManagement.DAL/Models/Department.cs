using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Models
{
    public class Department : BaseEntity
    {
        public ICollection<Employee> Employees { get; set; }
    }
}
