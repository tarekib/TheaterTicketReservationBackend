using Microsoft.EntityFrameworkCore.Migrations;

namespace TheaterTicketReservation.DAL.Migrations
{
    public partial class removerowfromseat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "Seats");

            migrationBuilder.RenameColumn(
                name: "Row",
                table: "Seats",
                newName: "Index");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Index",
                table: "Seats",
                newName: "Row");

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Seats",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
