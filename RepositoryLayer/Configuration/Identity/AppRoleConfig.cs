using EntityLayer.Identity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RepositoryLayer.Configuration.Identity
{
    public class AppRoleConfig : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasData(new AppRole
            {
                Id = Guid.Parse("A790A698-8058-4FB6-BBBB-63123D01B4D4").ToString(),
                Name = "SuperAdmin",
                NormalizedName = "SUPERADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            }, new AppRole
            {
                Id = Guid.Parse("3CD80FB7-0AFC-4C63-B15E-4F67C8EAFAF2").ToString(),
                Name = "Member",
                NormalizedName = "MEMBER",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            });
        }
    }
}
