using Microsoft.EntityFrameworkCore;
using Project.Domain.Models;
using System.Collections.Generic;

namespace Project.Infrastructure.Context
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
