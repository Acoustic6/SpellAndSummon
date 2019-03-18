
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpellAndSummon.Models
{
    [Table("SpecialAbilities")]
    public class SpecialAbility
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public ICollection<SpecialAbilityCard> SpecialAbilityCards { get; set; }
        public SpecialAbility()
        {
            SpecialAbilityCards = new Collection<SpecialAbilityCard>();
        }
    }
}