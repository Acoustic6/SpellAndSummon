using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpellAndSummon.Models
{
    [Table("Tables")]
    public class Card
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public Deck Deck {get; set;}
        public int DeckId {get; set;}
    }
}