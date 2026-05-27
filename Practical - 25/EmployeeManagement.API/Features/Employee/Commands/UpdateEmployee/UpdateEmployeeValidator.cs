using FluentValidation;

namespace EmployeeManagement.API.Features.Employee.Commands.UpdateEmployee
{
    public class UpdateEmployeeValidator : AbstractValidator<UpdateEmployeeCommand>
    {
        public UpdateEmployeeValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("Invalid Employee Id");

            RuleFor(x => x.Name).NotEmpty().WithMessage("Name Is Required");

            RuleFor(x => x.Salary).GreaterThan(0).WithMessage("Salary Must Be Greater Than Zero");

            RuleFor(x => x.DepartmentId).GreaterThan(0).WithMessage("Department Id Must Be Greater Than Zero");

            RuleFor(x => x.EmailId).NotEmpty().EmailAddress().WithMessage("Invalid Email");
        }
    }
}
