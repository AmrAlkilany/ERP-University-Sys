using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCApp1._01.Migrations
{
    public partial class addCrsIdColumnToTableInstructors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_DeptId",
                table: "Instructors");

            migrationBuilder.RenameColumn(
                name: "DeptId",
                table: "Instructors",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_DeptId",
                table: "Instructors",
                newName: "IX_Instructors_DepartmentId");

            migrationBuilder.AddColumn<int>(
                name: "CrsId",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_DepartmentId",
                table: "Instructors",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_DepartmentId",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "CrsId",
                table: "Instructors");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Instructors",
                newName: "DeptId");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_DepartmentId",
                table: "Instructors",
                newName: "IX_Instructors_DeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_DeptId",
                table: "Instructors",
                column: "DeptId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
