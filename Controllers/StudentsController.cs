using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentCQRSApi.DTOs;
using StudentCQRSApi.Features.Students.Commands;
using StudentCQRSApi.Features.Students.Queries;

namespace StudentCQRSApi.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add(StudentDto dto)
        {
            var result = await _mediator.Send(new AddStudentCommand(dto));
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, StudentDto dto)
        {
            var result = await _mediator.Send(new UpdateStudentCommand(id, dto));
            if (result == null) return NotFound("Student not found");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _mediator.Send(new DeleteStudentCommand(id));
            return result ? Ok("Deleted") : NotFound("Student not found");
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllStudentsQuery());
            return Ok(result);
        }
    }
}
