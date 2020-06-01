using Microsoft.EntityFrameworkCore.Migrations;

namespace Kanban.Migrations
{
    public partial class ToDoManager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "ToDoLists",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ToDoLists_ManagerId",
                table: "ToDoLists",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoLists_Managers_ManagerId",
                table: "ToDoLists",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "ManagerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDoLists_Managers_ManagerId",
                table: "ToDoLists");

            migrationBuilder.DropIndex(
                name: "IX_ToDoLists_ManagerId",
                table: "ToDoLists");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "ToDoLists");
        }
    }
}
