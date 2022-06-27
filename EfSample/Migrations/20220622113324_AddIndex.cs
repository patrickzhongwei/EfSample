using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSample.Migrations
{
    public partial class AddIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Class_ClassLanguage",
                table: "Class",
                column: "ClassLanguage");

            migrationBuilder.CreateIndex(
                name: "IX_Class_ClassName",
                table: "Class",
                column: "ClassName",
                unique: true,
                filter: "[ClassName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Class_ClassLanguage",
                table: "Class");

            migrationBuilder.DropIndex(
                name: "IX_Class_ClassName",
                table: "Class");
        }
    }
}
