using StudentCQRSApi.Models;
using System.Collections.Concurrent;

namespace StudentCQRSApi.Repositories
{
    public class InMemoryStudentRepository : IStudentRepository
    {
        private readonly ConcurrentDictionary<Guid, Student> _store = new();

        public Task AddAsync(Student student)
        {
            _store[student.Id] = student;
            return Task.CompletedTask;
        }

        public Task UpdateAsync(Student student)
        {
            _store[student.Id] = student;
            return Task.CompletedTask;
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            return Task.FromResult(_store.TryRemove(id, out _));
        }

        public Task<IReadOnlyList<Student>> GetAllAsync()
        {
            var list = _store.Values.ToList().AsReadOnly();
            return Task.FromResult((IReadOnlyList<Student>)list);
        }


        public Task<Student?> GetByIdAsync(Guid id)
        {
            _store.TryGetValue(id, out var student);
            return Task.FromResult(student);
        }
    }
}
