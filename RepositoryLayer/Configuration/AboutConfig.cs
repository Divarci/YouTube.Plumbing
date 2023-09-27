using EntityLayer.WebApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RepositoryLayer.Configuration
{
    public class AboutConfig : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            builder.Property(x => x.UpdatedDate).HasMaxLength(10);
            builder.Property(x => x.RowVersion).IsRowVersion();

            builder.Property(x => x.Header).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(5000);
            builder.Property(x => x.Clients).IsRequired().HasMaxLength(5);
            builder.Property(x => x.Projects).IsRequired().HasMaxLength(5);
            builder.Property(x => x.HoursOfSupport).IsRequired().HasMaxLength(5);
            builder.Property(x => x.HardWorkers).IsRequired().HasMaxLength(5);

            builder.HasData(new About
            {
                Id = 1,
                Header = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. In nibh mauris cursus mattis molestie a iaculis at erat. Odio ut enim blandit volutpat maecenas volutpat blandit aliquam etiam. Suspendisse sed nisi lacus sed viverra tellus in. Amet volutpat consequat mauris nunc congue. Diam maecenas sed enim ut sem. Et magnis dis parturient montes nascetur. Morbi tempus iaculis urna id volutpat lacus laoreet. Urna condimentum mattis pellentesque id nibh tortor id. Fames ac turpis egestas maecenas pharetra convallis posuere. Nunc mi ipsum faucibus vitae aliquet.",
                Clients = 5,
                Projects = 5,
                HoursOfSupport = 150,
                HardWorkers = 3,
                FileName = "test",
                FileType = "test",
                SocialMediaId = 1,
            });

          


        }
    }
}
