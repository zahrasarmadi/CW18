using CW18.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CW18.Configuration
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.ToTable("Admins");
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(r => r.FisrtName).IsRequired().HasMaxLength(50);
            builder.Property(r => r.LastName).IsRequired().HasMaxLength(50);
            builder.Property(r => r.Email).IsRequired().HasMaxLength(50);
            builder.Property(r => r.Password).IsRequired().HasMaxLength(10);
            builder.Property(r => r.IsAdmin).IsRequired().HasDefaultValue(true);
        }
    }
}