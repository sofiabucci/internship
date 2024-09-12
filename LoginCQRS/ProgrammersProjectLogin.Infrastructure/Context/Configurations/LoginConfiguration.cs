using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProgrammersProjectLogin.Domain.Models;

namespace ProgrammersProjectLogin.Infrastructure.Context.Configurations
{
    public class LoginConfiguration : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.HasKey(l => l.Id);
            builder.Property(p => p.TaxId).IsRequired().HasMaxLength(100);
        }
    }
}
