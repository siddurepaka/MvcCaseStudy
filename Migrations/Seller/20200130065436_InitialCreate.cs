using Microsoft.EntityFrameworkCore.Migrations;

namespace EmartMVCCaseStudy.Migrations.Seller
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    Sid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SUname = table.Column<string>(nullable: true),
                    SPassword = table.Column<string>(nullable: true),
                    SEmail = table.Column<string>(nullable: true),
                    SMobileNo = table.Column<int>(nullable: false),
                    SCompanyName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.Sid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sellers");
        }
    }
}
