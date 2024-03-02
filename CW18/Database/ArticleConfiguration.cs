using CW18.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CW18.Configuration;

public class ArticleConfiguration : IEntityTypeConfiguration<Article>
{
    public void Configure(EntityTypeBuilder<Article> builder)
    {
        builder.ToTable("Articles");
        builder.HasOne(a => a.Reporter)
        .WithMany(a => a.Articles)
        .HasForeignKey(a => a.ReporterId);
        builder.HasKey(r => r.Id);
        builder.Property(a => a.Id).IsRequired();
        builder.Property(a => a.Id).ValueGeneratedOnAdd();
        builder.Property(a => a.Title).IsRequired().HasMaxLength(100);
        builder.Property(a => a.Description).IsRequired().HasMaxLength(500);
        builder.Property(a => a.Image).IsRequired().HasMaxLength(500);
        builder.Property(a => a.IsConfrim).HasDefaultValue(false).IsRequired();
    }
}