
using BMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BMS.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) : base (options )
        {
            
        }

        DbSet<Student> Students { get; set; }

    }
}
