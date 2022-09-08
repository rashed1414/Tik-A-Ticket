using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tik_A_Ticket.Migrations
{
    public partial class SecoundMigtation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Logo",
                table: "Teams",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "FanId",
                table: "Fans",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "ChampionShips",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "ChampionShips",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Logo",
                table: "ChampionShips",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nation",
                table: "ChampionShips",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "ChampionShips",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "ChampionShips");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "ChampionShips");

            migrationBuilder.DropColumn(
                name: "Logo",
                table: "ChampionShips");

            migrationBuilder.DropColumn(
                name: "Nation",
                table: "ChampionShips");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "ChampionShips");

            migrationBuilder.AlterColumn<long>(
                name: "FanId",
                table: "Fans",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
