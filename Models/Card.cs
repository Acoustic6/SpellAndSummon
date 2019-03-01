namespace SpellAndSummon.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Deck Deck {get; set;}
        public int DeckId {get; set;}
    }
}