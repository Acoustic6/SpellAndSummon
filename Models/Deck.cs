using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SpellAndSummon.Models
{
    public class Deck
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Card> Cards {get; set;}
        public Deck() => this.Cards = new Collection<Card>();
    }
}