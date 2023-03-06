using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace TodoAPI.Models
{
    public class TodoContext : DbContext
    {
        public DbSet<info_users> info_users { get; set; }
        public DbSet<users> users { get; set; }

        public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
        {
        }
    }
}
