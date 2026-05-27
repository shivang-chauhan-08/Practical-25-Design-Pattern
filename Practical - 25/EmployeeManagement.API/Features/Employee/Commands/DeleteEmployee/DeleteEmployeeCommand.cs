using MediatR;

namespace EmployeeManagement.API.Features.Employee.Commands.DeleteEmployee
{
    public class DeleteEmployeeCommand : IRequest<string>
    {
        public int Id { get; set; }
    }
}
