using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManager.Infra.Migrations
{
    public partial class UpdateNameLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "User",
                type: "VARCHAR(75)",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(70)",
                oldMaxLength: 70);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "User",
                type: "VARCHAR(70)",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(75)",
                oldMaxLength: 75);
        }
    }
}
