using Microsoft.EntityFrameworkCore;
using Models;

namespace TemplateApi.Repositories
{
    public class UserContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public UserContext(DbContextOptions options) : base(options)
        {

        }
    }
}