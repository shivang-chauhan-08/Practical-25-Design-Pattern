using MediatR;

namespace EmployeeManagement.API.Features.Employee.Queries.GetEmployee
{
    public class GetEmployeeQuery : IRequest<object>
    {
        public int? Id { get; set; }
    }
}
