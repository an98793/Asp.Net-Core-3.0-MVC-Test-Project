using Microsoft.EntityFrameworkCore.Migrations;

namespace EFModels.Migrations
{
    public partial class Student : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Introductions_Students_StudentId",
                table: "Introductions");

            migrationBuilder.AddColumn<bool>(
                name: "Enabled",
                table: "Students",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Introductions",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Introductions_Students_StudentId",
                table: "Introductions",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Introductions_Students_StudentId",
                table: "Introductions");

            migrationBuilder.DropColumn(
                name: "Enabled",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Introductions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Introductions_Students_StudentId",
                table: "Introductions",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
