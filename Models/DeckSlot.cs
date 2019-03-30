using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpellAndSummon.Models
{
    public class CardDeck
    {
        public int Id { get; set; }
        [Range(1, 100, ErrorMessage = "The number of cards copies must be greater than 0")]
        public int Amount { get; set; }
        [Required]
        public int CardId { get; set; }
        public Card Card { get; set; }
        [Required]
        public int DeckId { get; set; }
        public Deck Deck { get; set; }
    }
}