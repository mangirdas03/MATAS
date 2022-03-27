using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PVP.Migrations
{
    public partial class DBFullHotfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "shows",
                table: "Infos");

            migrationBuilder.DropPrimaryKey(
                name: "id",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "id1",
                table: "Devices");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Devices",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "tag",
                table: "Devices",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "id",
                table: "Devices",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "shows",
                table: "Infos",
                column: "fk_device_id",
                principalTable: "Devices",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "shows",
                table: "Infos");

            migrationBuilder.DropPrimaryKey(
                name: "id",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "tag",
                table: "Devices");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "Devices",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "id1",
                table: "Devices",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "id",
                table: "Devices",
                column: "id1");

            migrationBuilder.AddForeignKey(
                name: "shows",
                table: "Infos",
                column: "fk_device_id",
                principalTable: "Devices",
                principalColumn: "id1",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
