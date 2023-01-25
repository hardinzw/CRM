using Microsoft.EntityFrameworkCore;

namespace CRM.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> opts) : base()
        {

        }

        public DbSet<Bug> Bug { get; set; }
    }
}
