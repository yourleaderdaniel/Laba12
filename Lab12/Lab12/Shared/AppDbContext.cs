using Microsoft.EntityFrameworkCore;
using Shared.Models;
using System.Collections.Generic;

namespace Shared
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EfCoreDb;Trusted_Connection=True;");
        }
    }
}
