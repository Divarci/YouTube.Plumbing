using EntityLayer.Identity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RepositoryLayer.Configuration.Identity
{
    public class AppUserRoleConfig : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasData(new AppUserRole
            {
                UserId = "2A9459B8-FADB-4EE7-9424-F34A6AEB5BCD",
                RoleId = "A790A698-8058-4FB6-BBBB-63123D01B4D4"
            }, new AppUserRole
            {
                UserId = "5D596359-CCD9-40DB-9442-74BEB060584A",
                RoleId = "3CD80FB7-0AFC-4C63-B15E-4F67C8EAFAF2"
            });
        }
    }
}
