using AutoMapper;
using EmployeeManagement.API.Features.Employee.Commands.CreateEmployee;
using EmployeeManagement.API.Features.Employee.Commands.DeleteEmployee;
using EmployeeManagement.API.Features.Employee.Commands.UpdateEmployee;
using EmployeeManagement.API.Features.Employee.Queries.GetEmployee;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetEmployee")]
        public async Task<IActionResult> GetEmployee([FromQuery] int? id)
        {
            var query = new GetEmployeeQuery()
            {
                Id = id
            };

            var result = await _mediator.Send(query);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost("CreateEmployee")]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeCommand cmd)
        {
            var result = await _mediator.Send(cmd);
            return Ok(result);
        }

        [HttpPut("UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployee(UpdateEmployeeCommand cmd)
        {
            var result = await _mediator.Send(cmd);
            return Ok(result);
        }

        [HttpDelete("DeleteEmployee/{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var cmd = new DeleteEmployeeCommand
            {
                Id = id
            };

            var result = await _mediator.Send(cmd);
            return Ok(result);
        }
    }
}
