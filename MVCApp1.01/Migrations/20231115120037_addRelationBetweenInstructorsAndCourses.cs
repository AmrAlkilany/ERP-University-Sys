using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCApp1._01.Migrations
{
    public partial class addRelationBetweenInstructorsAndCourses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Instructors_CrsId",
                table: "Instructors",
                column: "CrsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Courses_CrsId",
                table: "Instructors",
                column: "CrsId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Courses_CrsId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_CrsId",
                table: "Instructors");
        }
    }
}
