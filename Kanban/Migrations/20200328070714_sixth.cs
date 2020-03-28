using Microsoft.EntityFrameworkCore.Migrations;

namespace Kanban.Migrations
{
    public partial class sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "ToDo",
                table: "Statuses",
                newName: "StatusName");

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "StatusId", "StatusName" },
                values: new object[,]
                {
                    { 1, "To-Do" },
                    { 2, "In Progress" },
                    { 3, "Testing" },
                    { 4, "Done" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "StatusId",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "StatusName",
                table: "Statuses",
                newName: "ToDo");

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
        }
    }
}
