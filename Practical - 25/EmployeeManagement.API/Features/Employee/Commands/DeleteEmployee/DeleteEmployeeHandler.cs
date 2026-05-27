using AutoMapper;
using EmployeeManagement.DAL.Repository;
using MediatR;

namespace EmployeeManagement.API.Features.Employee.Commands.DeleteEmployee
{
    public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployeeCommand, string>
    {
        private readonly IEmployeeRepository _repo;

        public DeleteEmployeeHandler(IEmployeeRepository repo)
        {
            _repo = repo;
        }

        public async Task<string> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _repo.GetById(request.Id);

            if(employee == null)
            {
                return "Employee Not Found";
            }

            employee.IsDeleted = true;
            employee.Status = false;

            await _repo.Update(employee);

            return "Employee Deleted";
        }
    }
}
