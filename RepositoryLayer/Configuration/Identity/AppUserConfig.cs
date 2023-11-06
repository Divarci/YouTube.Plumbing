using EntityLayer.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RepositoryLayer.Configuration.Identity
{
    public class AppUserConfig : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var admin = new AppUser
            {
                Id = Guid.Parse("070A9212-D4A9-44DA-8479-4EC813B63621").ToString(),
                Email = "test.video.lesson@gmail.com",
                NormalizedEmail = "TEST.VIDEO.LESSON@GMAIL.COM",
                UserName = "TestAdmin",
                NormalizedUserName = "TESTADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            var adminPasswordHash = PasswordHash(admin, "Password12**");
            admin.PasswordHash = adminPasswordHash;
            builder.HasData(admin);

            var member = new AppUser
            {
                Id = Guid.Parse("6B0E483C-EBAE-4ED3-827E-8ED27F7D9131").ToString(),
                Email = "test.video.lesson2@gmail.com",
                NormalizedEmail = "TEST.VIDEO.LESSON2@GMAIL.COM",
                UserName = "TestMember",
                NormalizedUserName = "TESTMEMBER",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            var memberPasswordHash = PasswordHash(member, "Password12**");
            member.PasswordHash = memberPasswordHash;
            builder.HasData(member);

        }

        private string PasswordHash(AppUser user, string password)
        {
            var passwordHasher = new PasswordHasher<AppUser>();
            return passwordHasher.HashPassword(user, password);
        }
    }
}
