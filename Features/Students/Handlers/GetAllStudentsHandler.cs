using MediatR;
using StudentCQRSApi.Features.Students.Queries;
using StudentCQRSApi.Repositories;
using StudentCQRSApi.Models;

namespace StudentCQRSApi.Features.Students.Handlers
{
    public class GetAllStudentsHandler : IRequestHandler<GetAllStudentsQuery, IReadOnlyList<Student>>
    {
        private readonly IStudentRepository _repo;

        public GetAllStudentsHandler(IStudentRepository repo)
        {
            _repo = repo;
        }

        public async Task<IReadOnlyList<Student>> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
        {
            return await _repo.GetAllAsync();
        }
    }
}
