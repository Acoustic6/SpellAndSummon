using Microsoft.EntityFrameworkCore.Migrations;

namespace SpellAndSummon.Migrations
{
    public partial class CardDecksChangeTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardDeck_Cards_CardId",
                table: "CardDeck");

            migrationBuilder.DropForeignKey(
                name: "FK_CardDeck_Decks_DeckId",
                table: "CardDeck");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardDeck",
                table: "CardDeck");

            migrationBuilder.RenameTable(
                name: "CardDeck",
                newName: "CardDecks");

            migrationBuilder.RenameIndex(
                name: "IX_CardDeck_DeckId",
                table: "CardDecks",
                newName: "IX_CardDecks_DeckId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardDecks",
                table: "CardDecks",
                columns: new[] { "CardId", "DeckId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CardDecks_Cards_CardId",
                table: "CardDecks",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CardDecks_Decks_DeckId",
                table: "CardDecks",
                column: "DeckId",
                principalTable: "Decks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardDecks_Cards_CardId",
                table: "CardDecks");

            migrationBuilder.DropForeignKey(
                name: "FK_CardDecks_Decks_DeckId",
                table: "CardDecks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardDecks",
                table: "CardDecks");

            migrationBuilder.RenameTable(
                name: "CardDecks",
                newName: "CardDeck");

            migrationBuilder.RenameIndex(
                name: "IX_CardDecks_DeckId",
                table: "CardDeck",
                newName: "IX_CardDeck_DeckId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardDeck",
                table: "CardDeck",
                columns: new[] { "CardId", "DeckId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CardDeck_Cards_CardId",
                table: "CardDeck",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CardDeck_Decks_DeckId",
                table: "CardDeck",
                column: "DeckId",
                principalTable: "Decks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
