using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RepositoryLayer.Migrations
{
    /// <inheritdoc />
    public partial class assignRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cd80fb7-0afc-4c63-b15e-4f67c8eafaf2",
                column: "ConcurrencyStamp",
                value: "186446b5-cb92-4724-9a05-d4579e703acd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a790a698-8058-4fb6-bbbb-63123d01b4d4",
                column: "ConcurrencyStamp",
                value: "8c9e905a-263d-4eeb-9949-79c597244b71");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { "A790A698-8058-4FB6-BBBB-63123D01B4D4", "2A9459B8-FADB-4EE7-9424-F34A6AEB5BCD", "AppUserRole" },
                    { "3CD80FB7-0AFC-4C63-B15E-4F67C8EAFAF2", "5D596359-CCD9-40DB-9442-74BEB060584A", "AppUserRole" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a9459b8-fadb-4ee7-9424-f34a6aeb5bcd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "306f35c6-4aa5-4a76-b0de-f520d5a2115b", "AQAAAAIAAYagAAAAEMOG9ruBvKkn/evRRTGRV9/EVnd8NMi3TFhR7b0Oh810MTbXD5Nc5ocDa+DvDvqeQg==", "404313c2-4842-4fb7-82e6-184ecc105762" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d596359-ccd9-40db-9442-74beb060584a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b4d12dc-f1f9-40db-be6c-73c383ac9fb1", "AQAAAAIAAYagAAAAEBnqHUQnn+2/yrhd/hEp/y8YgIPFzkmDbdafWoyQmJY7z7z6jKvzfDavhN9DX+lhYQ==", "fb06bed3-6c39-43a3-9185-9bdfb6380355" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "A790A698-8058-4FB6-BBBB-63123D01B4D4", "2A9459B8-FADB-4EE7-9424-F34A6AEB5BCD" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3CD80FB7-0AFC-4C63-B15E-4F67C8EAFAF2", "5D596359-CCD9-40DB-9442-74BEB060584A" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cd80fb7-0afc-4c63-b15e-4f67c8eafaf2",
                column: "ConcurrencyStamp",
                value: "c4934b56-4cdc-4938-9315-488ca6f54bc2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a790a698-8058-4fb6-bbbb-63123d01b4d4",
                column: "ConcurrencyStamp",
                value: "3d2fd2be-8e5e-4197-bdae-af66edecf354");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a9459b8-fadb-4ee7-9424-f34a6aeb5bcd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ec0b48b-290d-41c7-812c-97d9e9a8cd9f", "AQAAAAIAAYagAAAAEK9rpXRCB+8BMQJliMG1WMDuvp+8cS+LAxbvFFgFgb1ILBQC9zRV6sclbrXR6oyrXA==", "aefd3147-a6db-4587-a1dd-3ffd4f273a9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d596359-ccd9-40db-9442-74beb060584a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34776801-48bc-4a2c-b63e-941caefbd4dd", "AQAAAAIAAYagAAAAEMWng/kG4M2aftv6TObgKMwye5THXATVn2/dKkzOxs/hMof/hOSrLovQGAGlaLPS9g==", "f0cf61eb-3689-40dc-8198-a5e776b80b48" });
        }
    }
}
