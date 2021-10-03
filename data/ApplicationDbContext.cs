using First_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace First_Project.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
    }
}
