using Microsoft.EntityFrameworkCore;

namespace ConsoleDiary
{
    public class DiaryContext : DbContext
    {
        public DbSet<JournalEntries> JournalEntries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Replace with your Azure SQL connection string
            optionsBuilder.UseSqlServer("");
        }
    }
}