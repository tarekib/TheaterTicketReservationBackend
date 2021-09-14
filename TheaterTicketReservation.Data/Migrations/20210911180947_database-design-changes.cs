using Microsoft.EntityFrameworkCore.Migrations;

namespace TheaterTicketReservation.DAL.Migrations
{
    public partial class databasedesignchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SeatReserveds");

            migrationBuilder.AddColumn<int>(
                name: "ReservationId",
                table: "Seats",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Reserved",
                table: "Seats",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Seats_ReservationId",
                table: "Seats",
                column: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Reservations_ReservationId",
                table: "Seats",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Reservations_ReservationId",
                table: "Seats");

            migrationBuilder.DropIndex(
                name: "IX_Seats_ReservationId",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "Reserved",
                table: "Seats");

            migrationBuilder.CreateTable(
                name: "SeatReserveds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationId = table.Column<int>(type: "int", nullable: true),
                    SeatId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatReserveds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeatReserveds_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SeatReserveds_Seats_SeatId",
                        column: x => x.SeatId,
                        principalTable: "Seats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SeatReserveds_ReservationId",
                table: "SeatReserveds",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatReserveds_SeatId",
                table: "SeatReserveds",
                column: "SeatId");
        }
    }
}
