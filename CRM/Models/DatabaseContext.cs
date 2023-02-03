using Microsoft.EntityFrameworkCore;

namespace CRM.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Bug> Bugs { get; set; }
        public DbSet<Account> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite(@"Data Source=crm.db");
    }
}
