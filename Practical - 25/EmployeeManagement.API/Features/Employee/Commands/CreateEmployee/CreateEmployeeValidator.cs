using FluentValidation;

namespace EmployeeManagement.API.Features.Employee.Commands.CreateEmployee
{
    public class CreateEmployeeValidator : AbstractValidator<CreateEmployeeCommand>
    {
        public CreateEmployeeValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name Is Required");

            RuleFor(x => x.Salary).GreaterThan(0).WithMessage("Salary Must Be Greater Than Zero");
            
            RuleFor(x => x.DepartmentId).GreaterThan(0).WithMessage("Department Id Must Be Greater Than Zero");

            RuleFor(x => x.EmailId).NotEmpty().EmailAddress().WithMessage("Invalid Email");
        }
    }
}
