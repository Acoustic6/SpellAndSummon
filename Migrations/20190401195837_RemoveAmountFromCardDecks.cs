using Microsoft.EntityFrameworkCore.Migrations;

namespace SpellAndSummon.Migrations
{
    public partial class RemoveAmountFromCardDecks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "CardDecks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "CardDecks",
                nullable: false,
                defaultValue: 0);
        }
    }
}
