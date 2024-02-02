using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoList.Migrations
{
    public partial class MigrationThree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TasksToDo",
                table: "TasksToDo");

            migrationBuilder.RenameTable(
                name: "TasksToDo",
                newName: "Tasks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Title",
                value: 6);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks");

            migrationBuilder.RenameTable(
                name: "Tasks",
                newName: "TasksToDo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TasksToDo",
                table: "TasksToDo",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "TasksToDo",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TasksToDo",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TasksToDo",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TasksToDo",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TasksToDo",
                keyColumn: "Id",
                keyValue: 5,
                column: "Title",
                value: 5);
        }
    }
}
