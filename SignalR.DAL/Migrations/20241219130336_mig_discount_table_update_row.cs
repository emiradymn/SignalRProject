using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR.DAL.Migrations
{
    public partial class mig_discount_table_update_row : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Discounts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Discounts");
        }
    }
}
