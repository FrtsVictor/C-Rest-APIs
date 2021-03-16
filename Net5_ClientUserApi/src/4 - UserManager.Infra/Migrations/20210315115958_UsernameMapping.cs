using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManager.Infra.Migrations
{
    public partial class UsernameMapping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "User",
                newName: "username");

            migrationBuilder.AlterColumn<string>(
                name: "username",
                table: "User",
                type: "VARCHAR(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "username",
                table: "User",
                newName: "Username");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "User",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(20)",
                oldMaxLength: 20);
        }
    }
}
