using Microsoft.EntityFrameworkCore.Migrations;

namespace TheaterTicketReservation.DAL.Migrations
{
    public partial class seatrowindex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Movies_MovieId",
                table: "Seats");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "Seats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Row",
                table: "Seats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Movies_MovieId",
                table: "Seats",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Movies_MovieId",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "Row",
                table: "Seats");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "Seats",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Movies_MovieId",
                table: "Seats",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
