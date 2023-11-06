using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    /// <inheritdoc />
    public partial class addClaim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUserClaims",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "3d447b49-d7a0-467d-aa03-8280a80f3eb2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "351d4dea-21f4-4b9c-8831-7dd930ea227a");

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "Discriminator", "UserId" },
                values: new object[] { 1, "AdminObserverExpireDate", "06/11/2023", "AppUserClaim", "6b0e483c-ebae-4ed3-827e-8ed27f7d9131" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb9ee921-1793-46b9-ab01-2373693fd07a", "AQAAAAIAAYagAAAAEHfp4WmjE2goOFbabYyLVdxc/eJFVilBLL7AcNaZKjkQSHslmu6Jp0Vr7nEh/W2zng==", "983c06b7-27da-4d91-905b-713e2b714e34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e907e3e6-4869-40b9-a381-686737e94915", "AQAAAAIAAYagAAAAEPxGx2iSs17wlQ1vReGnqPMxh1Fsgvs80uVO5Ydl6Wvhsy4owrSQxrxgIXnbv34ToQ==", "8e60273e-13fd-4719-9b96-9d74082f883a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUserClaims");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "eaa18caa-44a8-4b73-bd72-1aec51bceedf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "a0710810-3ece-47fc-9901-4d88d52d469c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8214a22-64cc-4ab8-aec7-a405c76ea8a4", "AQAAAAIAAYagAAAAEG0sQ2KYM3fRn2u8JvcaH/kwnx2wRv55lzf5xTad3mffW7Pa6Icwc4wnVasQ2ortDA==", "73c2b1be-f448-4c47-9012-d957124e10e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee0e2473-3f35-4179-9b4f-d84c80a66abf", "AQAAAAIAAYagAAAAEKtcdxK2WJaX473XS88uUgaUIVyrOvzOEKnADTnJhx2rJgtw/lYeRx1MioEn1WBAlg==", "81231597-55a3-4ab8-b595-92a50cac8760" });
        }
    }
}
