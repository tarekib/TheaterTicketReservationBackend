using Microsoft.EntityFrameworkCore.Migrations;

namespace TheaterTicketReservation.DAL.Migrations
{
    public partial class linkmovietotheater : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Screenings_Theaters_TheaterId",
                table: "Screenings");

            migrationBuilder.DropIndex(
                name: "IX_Screenings_TheaterId",
                table: "Screenings");

            migrationBuilder.DropColumn(
                name: "TheaterId",
                table: "Screenings");

            migrationBuilder.AddColumn<int>(
                name: "TheaterId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_TheaterId",
                table: "Movies",
                column: "TheaterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Theaters_TheaterId",
                table: "Movies",
                column: "TheaterId",
                principalTable: "Theaters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Theaters_TheaterId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_TheaterId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "TheaterId",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "TheaterId",
                table: "Screenings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_TheaterId",
                table: "Screenings",
                column: "TheaterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Screenings_Theaters_TheaterId",
                table: "Screenings",
                column: "TheaterId",
                principalTable: "Theaters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
