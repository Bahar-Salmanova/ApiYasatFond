using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class SehidTeltif : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Şəhids",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Surname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FathersName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FinNom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DistrictDied = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateDied = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false),
                    PhotoPassport = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Şəhids", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Homeİnformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeDocument = table.Column<bool>(type: "bit", nullable: false),
                    PersonPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaKvMetr = table.Column<int>(type: "int", nullable: false),
                    RoomQuantity = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    RoomPhoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ŞəhidId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homeİnformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Homeİnformations_Şəhids_ŞəhidId",
                        column: x => x.ŞəhidId,
                        principalTable: "Şəhids",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ŞəhidMedals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ŞəhidId = table.Column<int>(type: "int", nullable: false),
                    MedalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ŞəhidMedals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ŞəhidMedals_Şəhids_ŞəhidId",
                        column: x => x.ŞəhidId,
                        principalTable: "Şəhids",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ŞəhidOvlads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Surname = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    FinCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PassportPhoto = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ŞəhidId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ŞəhidOvlads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ŞəhidOvlads_Şəhids_ŞəhidId",
                        column: x => x.ŞəhidId,
                        principalTable: "Şəhids",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Homeİnformations_ŞəhidId",
                table: "Homeİnformations",
                column: "ŞəhidId");

            migrationBuilder.CreateIndex(
                name: "IX_ŞəhidMedals_ŞəhidId",
                table: "ŞəhidMedals",
                column: "ŞəhidId");

            migrationBuilder.CreateIndex(
                name: "IX_ŞəhidOvlads_ŞəhidId",
                table: "ŞəhidOvlads",
                column: "ŞəhidId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Homeİnformations");

            migrationBuilder.DropTable(
                name: "ŞəhidMedals");

            migrationBuilder.DropTable(
                name: "ŞəhidOvlads");

            migrationBuilder.DropTable(
                name: "Şəhids");
        }
    }
}
