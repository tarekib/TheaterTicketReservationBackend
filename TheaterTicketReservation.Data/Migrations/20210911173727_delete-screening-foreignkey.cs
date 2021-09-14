using Microsoft.EntityFrameworkCore.Migrations;

namespace TheaterTicketReservation.DAL.Migrations
{
    public partial class deletescreeningforeignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeatReserveds_Screenings_ScreeningId",
                table: "SeatReserveds");

            migrationBuilder.DropIndex(
                name: "IX_SeatReserveds_ScreeningId",
                table: "SeatReserveds");

            migrationBuilder.DropColumn(
                name: "ScreeningId",
                table: "SeatReserveds");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ScreeningId",
                table: "SeatReserveds",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SeatReserveds_ScreeningId",
                table: "SeatReserveds",
                column: "ScreeningId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeatReserveds_Screenings_ScreeningId",
                table: "SeatReserveds",
                column: "ScreeningId",
                principalTable: "Screenings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
