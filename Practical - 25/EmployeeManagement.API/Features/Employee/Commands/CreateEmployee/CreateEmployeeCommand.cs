using MediatR;

namespace EmployeeManagement.API.Features.Employee.Commands.CreateEmployee
{
    public class CreateEmployeeCommand : IRequest<string>
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
        public string EmailId { get; set; }
    }
}
