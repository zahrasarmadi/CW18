using CW18.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CW18.Configuration
{
    public class ReporterConfiguration : IEntityTypeConfiguration<Reporter>
    {
        public void Configure(EntityTypeBuilder<Reporter> builder)
        {
            builder.ToTable("Reporters");
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedOnAdd();
            builder.Property(r => r.Id).IsRequired();
            builder.Property(r => r.FisrtName).IsRequired().HasMaxLength(50);
            builder.Property(r => r.LastName).IsRequired().HasMaxLength(50);
            builder.Property(r => r.Email).IsRequired().HasMaxLength(50);
            builder.Property(r => r.Password).IsRequired().HasMaxLength(10);
            builder.Property(r => r.IsAdmin).IsRequired().HasDefaultValue(false) ;
        }
    }
}