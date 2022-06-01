using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_EternaDatabase.Migrations
{
    public partial class PortfolioTablesChanged1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MainImage",
                table: "Portfolios",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainImage",
                table: "Portfolios");
        }
    }
}
