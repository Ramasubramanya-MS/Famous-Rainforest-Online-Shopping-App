using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulkyWeb.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MyProperty",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[] { 11, 1, "Drama" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MyProperty",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
