using MediatR;
using StudentCQRSApi.DTOs;
using StudentCQRSApi.Models;

namespace StudentCQRSApi.Features.Students.Commands
{
    public record UpdateStudentCommand(Guid Id, StudentDto Student) : IRequest<Student?>;
}
