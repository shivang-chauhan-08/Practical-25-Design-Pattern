using AutoMapper;
using EmployeeManagement.DAL.Repository;
using MediatR;

namespace EmployeeManagement.API.Features.Employee.Commands.CreateEmployee
{
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, string>
    {
        private readonly IEmployeeRepository _repo;

        public CreateEmployeeHandler(IEmployeeRepository repo)
        {
            _repo = repo;
        }

        public async Task<string> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = new EmployeeManagement.DAL.Models.Employee()
            {
                Name = request.Name,
                Salary = request.Salary,
                DepartmentId = request.DepartmentId,
                EmailId = request.EmailId
            };

            await _repo.Create(employee);

            return "Employee Created";
        }
    }
}
