using Microsoft.EntityFrameworkCore.Migrations;

namespace Kanban.Migrations
{
    public partial class change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDoLists_ProjectManagers_ProjectManagerId",
                table: "ToDoLists");

            migrationBuilder.DropIndex(
                name: "IX_ToDoLists_ProjectManagerId",
                table: "ToDoLists");

            migrationBuilder.DropColumn(
                name: "ProjectManagerId",
                table: "ToDoLists");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectManagerId",
                table: "ToDoLists",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ToDoLists_ProjectManagerId",
                table: "ToDoLists",
                column: "ProjectManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoLists_ProjectManagers_ProjectManagerId",
                table: "ToDoLists",
                column: "ProjectManagerId",
                principalTable: "ProjectManagers",
                principalColumn: "ProjectManagerId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
