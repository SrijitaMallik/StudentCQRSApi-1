using MediatR;
using StudentCQRSApi.Features.Students.Commands;
using StudentCQRSApi.Repositories;
using StudentCQRSApi.Models;

namespace StudentCQRSApi.Features.Students.Handlers
{
    public class UpdateStudentHandler : IRequestHandler<UpdateStudentCommand, Student?>
    {
        private readonly IStudentRepository _repo;

        public UpdateStudentHandler(IStudentRepository repo)
        {
            _repo = repo;
        }

        public async Task<Student?> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var existing = await _repo.GetByIdAsync(request.Id);
            if (existing == null) return null;

            existing.Name = request.Student.Name;
            existing.Age = request.Student.Age;
            existing.Email = request.Student.Email;

            await _repo.UpdateAsync(existing);
            return existing;
        }
    }
}
