using EntityLayer.WebApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RepositoryLayer.Configuration.WebApplication
{
    public class Testimonalconfig : IEntityTypeConfiguration<Testimonal>
    {
        public void Configure(EntityTypeBuilder<Testimonal> builder)
        {
            builder.Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            builder.Property(x => x.UpdatedDate).HasMaxLength(10);
            builder.Property(x => x.RowVersion).IsRowVersion();

            builder.Property(x => x.FullName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Comment).IsRequired().HasMaxLength(2000);
            builder.Property(x => x.FileName).IsRequired();
            builder.Property(x => x.FileType).IsRequired();

            builder.HasData(new Testimonal
            {
                Id = 1,
                CreatedDate = "05/05/2025",
                Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. In nibh mauris cursus mattis molestie a iaculis at erat. Odio ut enim blandit volutpat maecenas volutpat blandit aliquam etiam.",
                Title = "interesting",
                FullName = "Merlyn Monroe",
                FileName = "test",
                FileType = "test",
            }, new Testimonal
            {
                Id = 2,
                CreatedDate = "05/05/2025",
                Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. In nibh mauris cursus mattis molestie a iaculis at erat. Odio ut enim blandit volutpat maecenas volutpat blandit aliquam etiam.",
                Title = "interesting",
                FullName = "Jackie Chan",
                FileName = "test",
                FileType = "test",
            }, new Testimonal
            {
                Id = 3,
                CreatedDate = "05/05/2025",
                Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. In nibh mauris cursus mattis molestie a iaculis at erat. Odio ut enim blandit volutpat maecenas volutpat blandit aliquam etiam.",
                Title = "interesting",
                FullName = "Bruce Wills",
                FileName = "test",
                FileType = "test",
            });
        }
    }
}
