using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmartMVCCaseStudy.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buyers",
                columns: table => new
                {
                    Bid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BUname = table.Column<string>(nullable: true),
                    BPassword = table.Column<string>(nullable: true),
                    BEmail = table.Column<string>(nullable: true),
                    BMobileNo = table.Column<int>(nullable: false),
                    BDOB = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyers", x => x.Bid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buyers");
        }
    }
}
