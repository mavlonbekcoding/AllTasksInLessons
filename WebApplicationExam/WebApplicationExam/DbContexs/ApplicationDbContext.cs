using Microsoft.EntityFrameworkCore;
using WebApplicationExam.Models;

namespace WebApplicationExam.DbContexs
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
            
        }

        public DbSet<UserModel> Users { get; set; }
    }
}
