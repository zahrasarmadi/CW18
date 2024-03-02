using CW18.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CW18.Configuration
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedOnAdd();
            builder.Property(r => r.Id).IsRequired();
            builder.Property(r => r.Title).IsRequired().HasMaxLength(50);
            builder.Property(r => r.Description).IsRequired().HasMaxLength(500);
            builder.Property(r => r.Like).IsRequired().HasDefaultValue(0);
            builder.Property(r => r.DisLike).IsRequired().HasDefaultValue(0);
            builder.Property(r=>r.IsConfrim).IsRequired().HasDefaultValue(false);
            builder.HasOne(a => a.Article)
            .WithMany(a => a.Comments)
            .HasForeignKey(a => a.ArticleId).OnDelete(DeleteBehavior.Restrict); ;

        }
    }
}