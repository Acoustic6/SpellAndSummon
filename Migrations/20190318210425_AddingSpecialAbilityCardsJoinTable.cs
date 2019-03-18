using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SpellAndSummon.Migrations
{
    public partial class AddingSpecialAbilityCardsJoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Atack",
                table: "Cards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Healt",
                table: "Cards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManaCost",
                table: "Cards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SpecialAbilities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialAbilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpecialAbilityCards",
                columns: table => new
                {
                    CardId = table.Column<int>(nullable: false),
                    SpecialAbilityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialAbilityCards", x => new { x.CardId, x.SpecialAbilityId });
                    table.ForeignKey(
                        name: "FK_SpecialAbilityCards_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpecialAbilityCards_SpecialAbilities_SpecialAbilityId",
                        column: x => x.SpecialAbilityId,
                        principalTable: "SpecialAbilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SpecialAbilityCards_SpecialAbilityId",
                table: "SpecialAbilityCards",
                column: "SpecialAbilityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpecialAbilityCards");

            migrationBuilder.DropTable(
                name: "SpecialAbilities");

            migrationBuilder.DropColumn(
                name: "Atack",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "Healt",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "ManaCost",
                table: "Cards");
        }
    }
}
