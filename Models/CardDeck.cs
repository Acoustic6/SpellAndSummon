namespace SpellAndSummon.Models
{
    public class CardDeck
    {
        public int DeckId { get; set; }
        public Deck Deck { get; set; }
        
        public int CardId { get; set; }
        public Card Card { get; set; }
    }
}