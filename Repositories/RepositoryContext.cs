using System.Reflection;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Repositories.Config;

namespace Repositories
{
    public class RepositoryContext : IdentityDbContext<IdentityUser>
    {
        private DbContextOptionsBuilder dbContextOptionsBuilder;

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            : base(options)
        {

        }

        public RepositoryContext(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            this.dbContextOptionsBuilder = dbContextOptionsBuilder;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // modelBuilder.ApplyConfiguration(new ProductConfig()); ALTERNATİF YOL
            // modelBuilder.ApplyConfiguration(new CategoryConfig());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}