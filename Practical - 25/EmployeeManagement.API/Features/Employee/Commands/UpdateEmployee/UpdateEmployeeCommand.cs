using MediatR;

namespace EmployeeManagement.API.Features.Employee.Commands.UpdateEmployee
{
    public class UpdateEmployeeCommand : IRequest<string>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
        public string EmailId { get; set; }
    }
}
