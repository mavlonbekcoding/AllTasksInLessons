using Microsoft.EntityFrameworkCore;
using test.Models;

namespace Exam.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } // User klassining ma'lumotlar bazasidagi qatorini belgilaymiz

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
