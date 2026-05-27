using AutoMapper;
using EmployeeManagement.DAL.Repository;
using MediatR;

namespace EmployeeManagement.API.Features.Employee.Commands.UpdateEmployee
{
    public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeCommand, string>
    {
        private readonly IEmployeeRepository _repo;

        public UpdateEmployeeHandler(IEmployeeRepository repo)
        {
            _repo = repo;
        }

        public async Task<string> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _repo.GetById(request.Id);

            if(employee == null)
            {
                return "Employee Not Found";
            }

            employee.Name = request.Name;
            employee.Salary = request.Salary;
            employee.DepartmentId = request.DepartmentId;
            employee.EmailId = request.EmailId;

            await _repo.Update(employee);

            return "Employee Updated";
        }
    }
}
