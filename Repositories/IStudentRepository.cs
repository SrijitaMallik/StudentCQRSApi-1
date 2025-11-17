using StudentCQRSApi.Models;

namespace StudentCQRSApi.Repositories
{
    public interface IStudentRepository
    {
        Task AddAsync(Student student);
        Task UpdateAsync(Student student);
        Task<bool> DeleteAsync(Guid id);
        Task<IReadOnlyList<Student>> GetAllAsync();
        Task<Student?> GetByIdAsync(Guid id);
    }
}
