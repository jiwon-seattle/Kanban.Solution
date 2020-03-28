using Microsoft.EntityFrameworkCore.Migrations;

namespace Kanban.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Done",
                table: "Statuses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InProgress",
                table: "Statuses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Testing",
                table: "Statuses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ToDo",
                table: "Statuses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Done",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "InProgress",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "Testing",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "ToDo",
                table: "Statuses");
        }
    }
}
