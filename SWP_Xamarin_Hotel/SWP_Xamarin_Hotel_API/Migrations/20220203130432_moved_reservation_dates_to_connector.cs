using Microsoft.EntityFrameworkCore.Migrations;

namespace SWP_Xamarin_Hotel_API.Migrations
{
    public partial class moved_reservation_dates_to_connector : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BeginReservation",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "EndReservation",
                table: "Bills");

            migrationBuilder.AddColumn<DateTime>(
                name: "BeginReservation",
                table: "Bills_Rooms",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndReservation",
                table: "Bills_Rooms",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BeginReservation",
                table: "Bills_Rooms");

            migrationBuilder.DropColumn(
                name: "EndReservation",
                table: "Bills_Rooms");

            migrationBuilder.AddColumn<DateTime>(
                name: "BeginReservation",
                table: "Bills",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndReservation",
                table: "Bills",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
