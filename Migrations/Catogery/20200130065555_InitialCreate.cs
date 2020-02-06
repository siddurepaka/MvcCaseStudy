using Microsoft.EntityFrameworkCore.Migrations;

namespace EmartMVCCaseStudy.Migrations.Catogery
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "catogeries",
                columns: table => new
                {
                    CID = table.Column<string>(nullable: false),
                    CName = table.Column<string>(nullable: true),
                    CDetails = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_catogeries", x => x.CID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "catogeries");
        }
    }
}
