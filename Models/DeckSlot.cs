namespace SpellAndSummon.Models
{
    public class DeckSlot
    {
        public int Id { get; set; }
        public int Position { get; set; }
        public int CardId { get; set; }
        public int DeckId { get; set; }
        public Card Card { get; set; }
        public Deck Deck { get; set; }
    }
}