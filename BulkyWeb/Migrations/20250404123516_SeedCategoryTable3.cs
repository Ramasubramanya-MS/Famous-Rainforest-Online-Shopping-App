using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulkyWeb.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategoryTable3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[] { 12, 2, "Booze" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
