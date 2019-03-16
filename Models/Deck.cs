using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace SpellAndSummon.Models
{
    public class Deck
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public ICollection<DeckSlot> DeckSlots {get; set;}
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public Deck() => DeckSlots = new Collection<DeckSlot>();
    }
}