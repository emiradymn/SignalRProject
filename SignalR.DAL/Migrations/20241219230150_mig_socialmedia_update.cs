using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR.DAL.Migrations
{
    public partial class mig_socialmedia_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "SocialMedias");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "SocialMedias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
