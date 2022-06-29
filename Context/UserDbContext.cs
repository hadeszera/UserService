using Microsoft.EntityFrameworkCore;
using UserService.Entity;

namespace UserService.Context
{
    public class UserDbContext : DbContext
    {

        public UserDbContext(DbContextOptions<UserDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}
