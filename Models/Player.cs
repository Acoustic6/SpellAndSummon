using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace SpellAndSummon.Models
{
    public class Player
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Surname { get; set; }
        [Required]
        [StringLength(255)]
        public string NickName { get; set; }
        public ICollection<Deck> Decks { get; set; }
        public Player() => Decks = new Collection<Deck>();
    }
}