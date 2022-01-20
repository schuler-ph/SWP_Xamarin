using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace SWP_Xamarin_Hotel_API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdditionalServices",
                columns: table => new
                {
                    AdditionalServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    BeginDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    StandardPrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalServices", x => x.AdditionalServiceId);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    StreetName = table.Column<string>(type: "text", nullable: false),
                    HouseNumber = table.Column<string>(type: "text", nullable: false),
                    ZipCode = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    PassportNumber = table.Column<string>(type: "varchar(767)", nullable: false),
                    Firstname = table.Column<string>(type: "text", nullable: false),
                    Lastname = table.Column<string>(type: "text", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.PassportNumber);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RoomNumber = table.Column<string>(type: "text", nullable: false),
                    NumberOfBeds = table.Column<int>(type: "int", nullable: false),
                    HasKitchen = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    HasBalcony = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    HasTerrace = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PricePerNight = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomId);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    BillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    GuestPassportNumber = table.Column<string>(type: "varchar(767)", nullable: true),
                    IsPaid = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    BeginReservation = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndReservation = table.Column<DateTime>(type: "datetime", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.BillId);
                    table.ForeignKey(
                        name: "FK_Bills_Guests_GuestPassportNumber",
                        column: x => x.GuestPassportNumber,
                        principalTable: "Guests",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Guests_AdditionalServices",
                columns: table => new
                {
                    Guests_AdditionalServicesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    GuestPassportNumber = table.Column<string>(type: "varchar(767)", nullable: true),
                    AdditionalServiceId = table.Column<int>(type: "int", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Guests_Addresses",
                columns: table => new
                {
                    Guests_AddressesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    GuestPassportNumber = table.Column<string>(type: "varchar(767)", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests_Addresses", x => x.Guests_AddressesId);
                    table.ForeignKey(
                        name: "FK_Guests_Addresses_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Guests_Addresses_Guests_GuestPassportNumber",
                        column: x => x.GuestPassportNumber,
                        principalTable: "Guests",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bills_AdditionalServices",
                columns: table => new
                {
                    Bills_AdditionalServicesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    BillId = table.Column<int>(type: "int", nullable: true),
                    AdditionalServiceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills_AdditionalServices", x => x.Bills_AdditionalServicesId);
                    table.ForeignKey(
                        name: "FK_Bills_AdditionalServices_AdditionalServices_AdditionalServic~",
                        column: x => x.AdditionalServiceId,
                        principalTable: "AdditionalServices",
                        principalColumn: "AdditionalServiceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bills_AdditionalServices_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "BillId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bills_Rooms",
                columns: table => new
                {
                    Bills_RoomsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    BillId = table.Column<int>(type: "int", nullable: true),
                    RoomId = table.Column<int>(type: "int", nullable: true),
                    Discount = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills_Rooms", x => x.Bills_RoomsId);
                    table.ForeignKey(
                        name: "FK_Bills_Rooms_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "BillId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bills_Rooms_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_GuestPassportNumber",
                table: "Bills",
                column: "GuestPassportNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_AdditionalServices_AdditionalServiceId",
                table: "Bills_AdditionalServices",
                column: "AdditionalServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_AdditionalServices_BillId",
                table: "Bills_AdditionalServices",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_Rooms_BillId",
                table: "Bills_Rooms",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_Rooms_RoomId",
                table: "Bills_Rooms",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Guests_AdditionalServices_AdditionalServiceId",
                table: "Guests_AdditionalServices",
                column: "AdditionalServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Guests_AdditionalServices_GuestPassportNumber",
                table: "Guests_AdditionalServices",
                column: "GuestPassportNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Guests_Addresses_AddressId",
                table: "Guests_Addresses",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Guests_Addresses_GuestPassportNumber",
                table: "Guests_Addresses",
                column: "GuestPassportNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bills_AdditionalServices");

            migrationBuilder.DropTable(
                name: "Bills_Rooms");

            migrationBuilder.DropTable(
                name: "Guests_AdditionalServices");

            migrationBuilder.DropTable(
                name: "Guests_Addresses");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "AdditionalServices");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Guests");
        }
    }
}
