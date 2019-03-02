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
        public ICollection<Card> Cards {get; set;}
        public Deck() => this.Cards = new Collection<Card>();
    }
}