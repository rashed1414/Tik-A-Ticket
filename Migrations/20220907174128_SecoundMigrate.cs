using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tik_A_Ticket.Migrations
{
    public partial class SecoundMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fans_Tickets_FanTicketTicketID",
                table: "Fans");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Matches_MatchId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_PricingCategories_PricingId",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "TicketID",
                table: "Tickets",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "FanTicketTicketID",
                table: "Fans",
                newName: "FanTicketId");

            migrationBuilder.RenameIndex(
                name: "IX_Fans_FanTicketTicketID",
                table: "Fans",
                newName: "IX_Fans_FanTicketId");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Tickets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SeatNo",
                table: "Tickets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PricingId",
                table: "Tickets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MatchId",
                table: "Tickets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Zip",
                table: "Stadiums",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<long>(
                name: "Capacity",
                table: "Stadiums",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Fans_Tickets_FanTicketId",
                table: "Fans",
                column: "FanTicketId",
                principalTable: "Tickets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Matches_MatchId",
                table: "Tickets",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_PricingCategories_PricingId",
                table: "Tickets",
                column: "PricingId",
                principalTable: "PricingCategories",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fans_Tickets_FanTicketId",
                table: "Fans");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Matches_MatchId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_PricingCategories_PricingId",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tickets",
                newName: "TicketID");

            migrationBuilder.RenameColumn(
                name: "FanTicketId",
                table: "Fans",
                newName: "FanTicketTicketID");

            migrationBuilder.RenameIndex(
                name: "IX_Fans_FanTicketId",
                table: "Fans",
                newName: "IX_Fans_FanTicketTicketID");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SeatNo",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PricingId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MatchId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Zip",
                table: "Stadiums",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Capacity",
                table: "Stadiums",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_Fans_Tickets_FanTicketTicketID",
                table: "Fans",
                column: "FanTicketTicketID",
                principalTable: "Tickets",
                principalColumn: "TicketID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Matches_MatchId",
                table: "Tickets",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_PricingCategories_PricingId",
                table: "Tickets",
                column: "PricingId",
                principalTable: "PricingCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
