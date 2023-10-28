using Microsoft.EntityFrameworkCore.Migrations;

namespace ManiSaeedi.Migrations
{
    public partial class mig_CorrectAboutMe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "AboutMe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "AboutMe",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
