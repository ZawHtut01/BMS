using BMS.Application.Interfaces;
using BMS.Domain.Entities;

namespace BMS.Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            return await _unitOfWork.Student.GetAll();
        }

        public async Task<Student> GetByIdAsync(int id)
        {
            return await _unitOfWork.Student.FirstOrDefault(x => x.Id == id);
        }

        public async Task AddAsync(Student student)
        {
            await _unitOfWork.Student.AddAsync(student);
            _unitOfWork.Complete();
        }

        public async Task UpdateAsync(Student student)
        {
            _unitOfWork.Student.Update(student);
            _unitOfWork.Complete();
        }

        public async Task DeleteAsync(int id)
        {
            var student = await _unitOfWork.Student.FirstOrDefault(x => x.Id == id);
            if (student != null)
            {
                _unitOfWork.Student.Remove(student);
                _unitOfWork.Complete();
            }
        }
    }
}
