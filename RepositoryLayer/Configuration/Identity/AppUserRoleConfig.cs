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
                UserId = Guid.Parse("070A9212-D4A9-44DA-8479-4EC813B63621").ToString(),
                RoleId = Guid.Parse("9B67832B-7091-48E8-AA0A-F1B3BAECA418").ToString()
            }, new AppUserRole
            {
                UserId = Guid.Parse("6B0E483C-EBAE-4ED3-827E-8ED27F7D9131").ToString(),
                RoleId = Guid.Parse("AFFEDC34-9713-423A-880E-4A61CEEFB7B1").ToString()
            });
        }
    }
}
