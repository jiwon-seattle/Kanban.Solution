using Microsoft.EntityFrameworkCore.Migrations;

namespace Kanban.Migrations
{
    public partial class ToDoProjectManager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDoLists_Managers_ManagerId",
                table: "ToDoLists");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerId",
                table: "ToDoLists",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectManagerId",
                table: "ToDoLists",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ToDoLists_ProjectManagerId",
                table: "ToDoLists",
                column: "ProjectManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoLists_Managers_ManagerId",
                table: "ToDoLists",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "ManagerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoLists_ProjectManagers_ProjectManagerId",
                table: "ToDoLists",
                column: "ProjectManagerId",
                principalTable: "ProjectManagers",
                principalColumn: "ProjectManagerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDoLists_Managers_ManagerId",
                table: "ToDoLists");

            migrationBuilder.DropForeignKey(
                name: "FK_ToDoLists_ProjectManagers_ProjectManagerId",
                table: "ToDoLists");

            migrationBuilder.DropIndex(
                name: "IX_ToDoLists_ProjectManagerId",
                table: "ToDoLists");

            migrationBuilder.DropColumn(
                name: "ProjectManagerId",
                table: "ToDoLists");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerId",
                table: "ToDoLists",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoLists_Managers_ManagerId",
                table: "ToDoLists",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "ManagerId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
