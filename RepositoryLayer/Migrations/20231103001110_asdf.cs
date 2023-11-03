using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    /// <inheritdoc />
    public partial class asdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_Categories_CategoryId",
                table: "Portfolios");

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: "03/11/2023");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: "03/11/2023");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: "03/11/2023");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: "03/11/2023");

            migrationBuilder.UpdateData(
                table: "HomePages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: "03/11/2023");

            migrationBuilder.UpdateData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: "03/11/2023");

            migrationBuilder.UpdateData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: "03/11/2023");

            migrationBuilder.UpdateData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: "03/11/2023");

            migrationBuilder.UpdateData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: "03/11/2023");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: "03/11/2023");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: "03/11/2023");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: "03/11/2023");

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: "03/11/2023");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: "03/11/2023");

            migrationBuilder.UpdateData(
                table: "Testimonals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: "03/11/2023");

            migrationBuilder.UpdateData(
                table: "Testimonals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: "03/11/2023");

            migrationBuilder.UpdateData(
                table: "Testimonals",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: "03/11/2023");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_Categories_CategoryId",
                table: "Portfolios",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_Categories_CategoryId",
                table: "Portfolios");

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: "02/11/2023");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: "02/11/2023");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: "02/11/2023");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: "02/11/2023");

            migrationBuilder.UpdateData(
                table: "HomePages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: "02/11/2023");

            migrationBuilder.UpdateData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: "02/11/2023");

            migrationBuilder.UpdateData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: "02/11/2023");

            migrationBuilder.UpdateData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: "02/11/2023");

            migrationBuilder.UpdateData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: "02/11/2023");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: "02/11/2023");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: "02/11/2023");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: "02/11/2023");

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: "02/11/2023");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: "02/11/2023");

            migrationBuilder.UpdateData(
                table: "Testimonals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: "02/11/2023");

            migrationBuilder.UpdateData(
                table: "Testimonals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: "02/11/2023");

            migrationBuilder.UpdateData(
                table: "Testimonals",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: "02/11/2023");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_Categories_CategoryId",
                table: "Portfolios",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
