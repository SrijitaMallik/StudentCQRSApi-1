using MediatR;
using StudentCQRSApi.Features.Students.Commands;
using StudentCQRSApi.Repositories;
using StudentCQRSApi.Models;

namespace StudentCQRSApi.Features.Students.Handlers
{
    public class AddStudentHandler : IRequestHandler<AddStudentCommand, Student>
    {
        private readonly IStudentRepository _repo;

        public AddStudentHandler(IStudentRepository repo)
        {
            _repo = repo;
        }

        public async Task<Student> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            var dto = request.Student;

            var student = new Student
            {
                Name = dto.Name,
                Age = dto.Age,
                Email = dto.Email
            };

            await _repo.AddAsync(student);
            return student;
        }
    }
}
