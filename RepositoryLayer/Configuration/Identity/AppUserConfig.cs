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
                Id = Guid.Parse("2A9459B8-FADB-4EE7-9424-F34A6AEB5BCD").ToString(),
                Email = "test.video.lesson@gmail.com",
                NormalizedEmail = "TEST.VIDEO.LESSON@GMAIL.COM",
                UserName = "TestAdmin",
                NormalizedUserName = "TESTADMIN",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            };

            var passwordHashAdmin = PasswordHash(admin, "Password12**");
            admin.PasswordHash = passwordHashAdmin;
            builder.HasData(admin);


            var member = new AppUser
            {
                Id = Guid.Parse("5D596359-CCD9-40DB-9442-74BEB060584A").ToString(),
                Email = "test.video.lesson2@gmail.com",
                NormalizedEmail = "TEST.VIDEO.LESSON2@GMAIL.COM",
                UserName = "TestMember",
                NormalizedUserName = "TESTMEMBER",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            };

            var passwordHashMember = PasswordHash(member, "Password12**");
            member.PasswordHash = passwordHashMember;
            builder.HasData(member);
        }


        private string PasswordHash(AppUser user, string password)
        {
            var passwordhasher = new PasswordHasher<AppUser>();
            return passwordhasher.HashPassword(user, password);

        }
    }

}
