using MediatR;
using StudentCQRSApi.Features.Students.Commands;
using StudentCQRSApi.Repositories;

namespace StudentCQRSApi.Features.Students.Handlers
{
    public class DeleteStudentHandler : IRequestHandler<DeleteStudentCommand, bool>
    {
        private readonly IStudentRepository _repo;

        public DeleteStudentHandler(IStudentRepository repo)
        {
            _repo = repo;
        }

        public async Task<bool> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            return await _repo.DeleteAsync(request.Id);
        }
    }
}
