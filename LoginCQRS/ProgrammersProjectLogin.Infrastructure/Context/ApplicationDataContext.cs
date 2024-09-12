
using Microsoft.EntityFrameworkCore;
using ProgrammersProjectLogin.Domain.Models;
using System.Reflection;

namespace ProgrammersProjectLogin.Infrastructure.Context
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : base(options) { }
        public DbSet<Login> Logins => Set<Login>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
