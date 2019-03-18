using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpellAndSummon.Models
{
    public class Card
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public ICollection<DeckSlot> DeckSlots { get; set; }
        public int Healt { get; set; }
        public int Atack { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "ManaCost can'b be below 0")]
        public int ManaCost { get; set; }
        public ICollection<SpecialAbilityCard> SpecialAbilityCards { get; set; }
        public Card()
        {
            DeckSlots = new Collection<DeckSlot>();
            SpecialAbilityCards = new Collection<SpecialAbilityCard>();
        }
    }
}