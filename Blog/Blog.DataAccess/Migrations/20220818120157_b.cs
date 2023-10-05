using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.DataAccess.Migrations
{
    public partial class b : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: "d11a1528-c47d-4f11-86e6-063993345c98");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Subcategory",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Active", "Email", "Name", "Password", "Rol" },
                values: new object[] { "97514786-c4bb-4017-af49-83ba0ab059b5", true, null, "admin", "123456", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: "97514786-c4bb-4017-af49-83ba0ab059b5");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Subcategory");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Active", "Email", "Name", "Password", "Rol" },
                values: new object[] { "d11a1528-c47d-4f11-86e6-063993345c98", true, null, "admin", "123456", 0 });
        }
    }
}
