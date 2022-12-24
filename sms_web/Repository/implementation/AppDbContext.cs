using Microsoft.EntityFrameworkCore;
using sms_web.Models;

namespace sms_web.Repository.implementation
{

    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Student> students { get; set; }
    }
}
