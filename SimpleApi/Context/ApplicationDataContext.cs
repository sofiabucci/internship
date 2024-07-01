using Microsoft.EntityFrameworkCore;
using SimpleApi.Models;

namespace SimpleApi.Context
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : base (options) { }
        
        public DbSet<Product> Product { get; set; }
        
    }
}
