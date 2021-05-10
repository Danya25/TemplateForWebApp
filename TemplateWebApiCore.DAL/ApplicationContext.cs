using Microsoft.EntityFrameworkCore;
using TemplateWebApiCore.DAL.Entity;

namespace TemplateWebApiCore.DAL
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
