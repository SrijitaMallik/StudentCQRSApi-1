using MediatR;
using StudentCQRSApi.Models;

namespace StudentCQRSApi.Features.Students.Queries
{
    public record GetAllStudentsQuery() : IRequest<IReadOnlyList<Student>>;
}
