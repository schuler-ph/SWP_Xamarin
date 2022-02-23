using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace SWP_Xamarin_Hotel_API.Migrations
{
    public partial class additionalServices_cleanup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guests_AdditionalServices");

            migrationBuilder.DropColumn(
                name: "BeginDate",
                table: "AdditionalServices");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "AdditionalServices");

            migrationBuilder.AddColumn<DateTime>(
                name: "BeginDate",
                table: "Bills_AdditionalServices",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<float>(
                name: "Discount",
                table: "Bills_AdditionalServices",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Bills_AdditionalServices",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "GuestPassportNumber",
                table: "Bills_AdditionalServices",
                type: "varchar(767)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServiceName",
                table: "AdditionalServices",
                type: "text",
                nullable: false);

            migrationBuilder.CreateIndex(
                name: "IX_Bills_AdditionalServices_GuestPassportNumber",
                table: "Bills_AdditionalServices",
                column: "GuestPassportNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_AdditionalServices_Guests_GuestPassportNumber",
                table: "Bills_AdditionalServices",
                column: "GuestPassportNumber",
                principalTable: "Guests",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_AdditionalServices_Guests_GuestPassportNumber",
                table: "Bills_AdditionalServices");

            migrationBuilder.DropIndex(
                name: "IX_Bills_AdditionalServices_GuestPassportNumber",
                table: "Bills_AdditionalServices");

            migrationBuilder.DropColumn(
                name: "BeginDate",
                table: "Bills_AdditionalServices");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Bills_AdditionalServices");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Bills_AdditionalServices");

            migrationBuilder.DropColumn(
                name: "GuestPassportNumber",
                table: "Bills_AdditionalServices");

            migrationBuilder.DropColumn(
                name: "ServiceName",
                table: "AdditionalServices");

            migrationBuilder.AddColumn<DateTime>(
                name: "BeginDate",
                table: "AdditionalServices",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "AdditionalServices",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Guests_AdditionalServices",
                columns: table => new
                {
                    Guests_AdditionalServicesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AdditionalServiceId = table.Column<int>(type: "int", nullable: true),
                    GuestPassportNumber = table.Column<string>(type: "varchar(767)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests_AdditionalServices", x => x.Guests_AdditionalServicesId);
                    table.ForeignKey(
                        name: "FK_Guests_AdditionalServices_AdditionalServices_AdditionalServi~",
                        column: x => x.AdditionalServiceId,
                        principalTable: "AdditionalServices",
                        principalColumn: "AdditionalServiceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Guests_AdditionalServices_Guests_GuestPassportNumber",
                        column: x => x.GuestPassportNumber,
                        principalTable: "Guests",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Guests_AdditionalServices_AdditionalServiceId",
                table: "Guests_AdditionalServices",
                column: "AdditionalServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Guests_AdditionalServices_GuestPassportNumber",
                table: "Guests_AdditionalServices",
                column: "GuestPassportNumber");
        }
    }
}
