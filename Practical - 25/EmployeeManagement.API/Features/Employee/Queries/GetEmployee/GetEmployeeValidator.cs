using FluentValidation;
using MediatR;

namespace EmployeeManagement.API.Features.Employee.Queries.GetEmployee
{
    public class GetEmployeeValidator : AbstractValidator<GetEmployeeQuery>
    {
        public GetEmployeeValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).When(x => x.Id.HasValue).WithMessage("Invalid Employee Id");
        }
    }
}
