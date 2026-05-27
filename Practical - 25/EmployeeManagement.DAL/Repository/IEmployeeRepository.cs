using EmployeeManagement.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Repository
{
    public interface IEmployeeRepository : IGenericRepo<Employee>
    {
        Task<Employee> GetEmployeeWithDepartment(int id);
    }
}