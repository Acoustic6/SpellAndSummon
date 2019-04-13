using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpellAndSummon.Models

{
    [Table("SpecialAbilities")]
    public class SpecialAbility
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Params { get; set; }
        public ICollection<SpecialAbilityCard> SpecialAbilityCards { get; set; }
        public SpecialAbility()
        {
            SpecialAbilityCards = new Collection<SpecialAbilityCard>();
        }
    }
}