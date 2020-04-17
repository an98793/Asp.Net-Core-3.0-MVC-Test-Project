using Microsoft.EntityFrameworkCore.Migrations;

namespace EFModels.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Introductions",
                columns: table => new
                {
                    CustomerId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressLine1 = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(nullable: true),
                    StudentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Introductions", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Introductions_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Introductions_StudentId",
                table: "Introductions",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Introductions");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
