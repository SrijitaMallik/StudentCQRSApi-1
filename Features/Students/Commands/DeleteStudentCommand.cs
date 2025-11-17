using MediatR;

namespace StudentCQRSApi.Features.Students.Commands
{
    public record DeleteStudentCommand(Guid Id) : IRequest<bool>;
}
