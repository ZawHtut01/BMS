using BMS.Application.Interfaces;
using BMS.Domain.Entities;
using BMS.Infrastructure.Data;

namespace BMS.Infrastructure.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
