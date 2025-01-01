using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogProject3.DataAccessLayer.Migrations
{
    public partial class mig14CategoryArticleCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryArticleCount",
                table: "Categories",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryArticleCount",
                table: "Categories");
        }
    }
}
