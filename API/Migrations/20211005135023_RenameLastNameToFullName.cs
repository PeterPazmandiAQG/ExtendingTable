using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class RenameLastNameToFullName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Employee",
                newName: "FullName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Employee",
                newName: "LastName");
        }
    }
}
