using FluentValidation;

namespace EmployeeManagement.API.Features.Employee.Commands.DeleteEmployee
{
    public class DeleteEmployeeValidator : AbstractValidator<DeleteEmployeeCommand>
    {
        public DeleteEmployeeValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("Invalid Employee Id");
        }
    }
}
