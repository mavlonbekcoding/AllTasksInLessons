using Microsoft.EntityFrameworkCore;
using test.Models;

namespace Exam.DataContext
{
    public class EfCoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Integrated Security=True;Connect Timeout=30");
        }
        public DbSet<User> Users { get; set; }
    }
}
