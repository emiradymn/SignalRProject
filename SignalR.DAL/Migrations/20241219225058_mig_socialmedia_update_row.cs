using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR.DAL.Migrations
{
    public partial class mig_socialmedia_update_row : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "SocialMedias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "SocialMedias");
        }
    }
}
