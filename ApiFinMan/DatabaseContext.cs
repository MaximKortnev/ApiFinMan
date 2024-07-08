using Microsoft.EntityFrameworkCore;
using ApiFinMan.Models;


namespace ApiFinMan
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
           : base(options)
        {
            Database.Migrate();
        }
    }
}
