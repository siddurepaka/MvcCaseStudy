using Microsoft.EntityFrameworkCore.Migrations;

namespace EmartMVCCaseStudy.Migrations.SubCategory
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubCategorys",
                columns: table => new
                {
                    SubId = table.Column<string>(nullable: false),
                    SubName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategorys", x => x.SubId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubCategorys");
        }
    }
}
