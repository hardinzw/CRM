using Microsoft.EntityFrameworkCore;

namespace CRM.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Bug> Bug { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite(@"Data Source=C:\SqliteDB\CRM.DB");
    }
}
