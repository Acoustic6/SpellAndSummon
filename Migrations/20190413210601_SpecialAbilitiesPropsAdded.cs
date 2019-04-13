using Microsoft.EntityFrameworkCore.Migrations;

namespace SpellAndSummon.Migrations
{
    public partial class SpecialAbilitiesPropsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Params",
                table: "SpecialAbilities",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "SpecialAbilities",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Params",
                table: "SpecialAbilities");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "SpecialAbilities");
        }
    }
}
