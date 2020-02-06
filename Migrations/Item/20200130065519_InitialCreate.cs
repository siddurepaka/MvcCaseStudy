using Microsoft.EntityFrameworkCore.Migrations;

namespace EmartMVCCaseStudy.Migrations.Item
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category_id = table.Column<string>(nullable: true),
                    subcategory_id = table.Column<string>(nullable: true),
                    price = table.Column<float>(nullable: false),
                    item_name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    stock_number = table.Column<int>(nullable: false),
                    remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
