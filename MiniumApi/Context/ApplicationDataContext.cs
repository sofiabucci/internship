using Microsoft.EntityFrameworkCore;
using MiniumApi.Domain;

namespace MiniumApi.Context
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : base (options) { }
        
        public DbSet<Product> Product { get; set; }
        
    }
}
