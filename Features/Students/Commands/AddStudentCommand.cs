using MediatR;
using StudentCQRSApi.Models;
using StudentCQRSApi.DTOs;

namespace StudentCQRSApi.Features.Students.Commands
{
    public record AddStudentCommand(StudentDto Student) : IRequest<Student>;
}
