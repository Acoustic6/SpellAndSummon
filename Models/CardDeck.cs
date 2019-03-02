using System.ComponentModel.DataAnnotations.Schema;

namespace SpellAndSummon.Models
{
    [Table("CardDecks")]
    public class CardDeck
    {
        public int DeckId { get; set; }
        public Deck Deck { get; set; }

        public int CardId { get; set; }
        public Card Card { get; set; }
    }
}