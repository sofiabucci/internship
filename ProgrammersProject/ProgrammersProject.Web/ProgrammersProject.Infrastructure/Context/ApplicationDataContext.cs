using Microsoft.EntityFrameworkCore;
using Project.Domain.Models;
using System.Reflection;

namespace Project.Infrastructure.Context
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : base(options) { }

        public DbSet<Product> Products => Set<Product>();

        public DbSet<Brand> Brands => Set<Brand>();

        public DbSet<Category> Categories => Set<Category>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}