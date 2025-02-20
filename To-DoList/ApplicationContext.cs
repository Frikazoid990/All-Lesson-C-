using Microsoft.EntityFrameworkCore;

namespace To_DoList
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Note> Note => Set<Note>();
        public ApplicationContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = @"C:\Users\micro\source\repos\Youtube\YouTube Lessons\All les\To-DoList\To-DoListDataBase.db";
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

    }
}
