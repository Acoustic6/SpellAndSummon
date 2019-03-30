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
        [Required]
        [StringLength(255)]
        public string CardText { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "ManaCost can'b be below 0")]
        public int ManaCost { get; set; }
        public CardType CardType { get; set; }
        public ICollection<CardDeck> CardDecks { get; set; }
        public ICollection<SpecialAbilityCard> SpecialAbilityCards { get; set; }
        public Card()
        {
            CardDecks = new Collection<CardDeck>();
            SpecialAbilityCards = new Collection<SpecialAbilityCard>();
        }
    }
    public enum CardType
    {
        Spell = 0,
        Creature = 1
    }
}