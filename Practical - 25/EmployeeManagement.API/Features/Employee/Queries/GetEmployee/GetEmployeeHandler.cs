using EmployeeManagement.DAL.Repository;
using MediatR;

namespace EmployeeManagement.API.Features.Employee.Queries.GetEmployee
{
    public class GetEmployeeHandler : IRequestHandler<GetEmployeeQuery, object>
    {
        private readonly IEmployeeRepository _repo;

        public GetEmployeeHandler(IEmployeeRepository repo)
        {
            _repo = repo;
        }

        public async Task<object> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            if(request.Id == null)
            {
                var employees = await _repo.GetAll();
                return employees.Where(x => x.IsDeleted == false);
            }

            var employee = await _repo.GetById(request.Id.Value);

            if (employee == null || employee.IsDeleted == true)
            {
                return "Employee Not Found";
            }

            return employee;
        }
    }
}
