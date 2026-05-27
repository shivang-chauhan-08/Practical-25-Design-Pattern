using EmployeeManagement.DAL.Data;
using EmployeeManagement.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Repository
{
    public class EmployeeRepository : GenericRepo<Employee>, IEmployeeRepository
    {
        private readonly ApplicationDBContext _context;
        public EmployeeRepository(ApplicationDBContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Employee> GetEmployeeWithDepartment(int id)
        {
            var employee = await _context.Employees.Include(x => x.Department).FirstOrDefaultAsync(x => x.Id == id);
            
            if(employee == null)
            {
                throw new Exception("Employee Not Found");
            }

            return employee;
        }
    }
}
