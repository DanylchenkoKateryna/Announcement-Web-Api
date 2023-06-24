using Data.Entities;
using EmployeeDirectory.Data;
using Microsoft.EntityFrameworkCore;

namespace Data.Data
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
        : base(options)
        {
        }
        public DbSet<Announcement> Announcements { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Announcement>().HasData(SeedData.WebAppDev().Generate(25));
        }
    }

}
