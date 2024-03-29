using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        // In the following, the DB table name will be Users
        public DbSet<AppUser> Users { get; set; }
    }
}