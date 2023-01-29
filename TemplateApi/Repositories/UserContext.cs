//this sets the database.

using Microsoft.EntityFrameworkCore;
using TemplateApi.Models;

namespace TemplateApi.Repositories
{
    public class UserContext : DbContext
    {
        public DbSet<User> users { get; set; }
        #nullable disable
        public UserContext(DbContextOptions options) : base(options)
        #nullable enable
        {

        }
    }
}