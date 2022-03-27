using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PVP.Migrations
{
    public partial class DBFull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    id1 = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fk_user = table.Column<int>(type: "int", nullable: false),
                    is_on = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    is_realtime = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    setup_string = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    id = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    treshold = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("id", x => x.id1);
                    table.ForeignKey(
                        name: "has",
                        column: x => x.fk_user,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RealtimeInfos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fk_device_id = table.Column<int>(type: "int", nullable: false),
                    wattage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("id", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Infos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fk_device_id = table.Column<int>(type: "int", nullable: false),
                    date_time = table.Column<DateTime>(type: "datetime", nullable: false),
                    wattage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("id", x => x.id);
                    table.ForeignKey(
                        name: "shows",
                        column: x => x.fk_device_id,
                        principalTable: "Devices",
                        principalColumn: "id1",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "fk_user",
                table: "Devices",
                column: "fk_user");

            migrationBuilder.CreateIndex(
                name: "fk_device_id",
                table: "Infos",
                column: "fk_device_id");

            migrationBuilder.CreateIndex(
                name: "fk_device_id",
                table: "RealtimeInfos",
                column: "fk_device_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Infos");

            migrationBuilder.DropTable(
                name: "RealtimeInfos");

            migrationBuilder.DropTable(
                name: "Devices");
        }
    }
}
