using Microsoft.EntityFrameworkCore.Migrations;

namespace account_api.Migrations
{
    public partial class moreusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "First", "Last" },
                values: new object[] { "bob", "smith" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Email", "First", "Last" },
                values: new object[] { 2, "jim.roberts@gmail.com", "jim", "roberts" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Email", "First", "Last" },
                values: new object[] { 3, "alison.jacobs@aol.com", "alison", "jacobs" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "First", "Last" },
                values: new object[] { "Bob", "Smith" });
        }
    }
}
