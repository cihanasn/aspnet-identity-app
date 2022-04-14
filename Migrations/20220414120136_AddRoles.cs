using Microsoft.EntityFrameworkCore.Migrations;

namespace aspnet_identity_app.Migrations
{
    public partial class AddRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b3032721-9d92-40ad-83e0-07374990436a", "f4ee146c-3ceb-4511-ab13-c75d93250ed1", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "70aea6d3-5474-4d58-aa49-f1e393f650d0", "c401f7e4-fcaf-4310-968b-141f7da954bf", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70aea6d3-5474-4d58-aa49-f1e393f650d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3032721-9d92-40ad-83e0-07374990436a");
        }
    }
}
