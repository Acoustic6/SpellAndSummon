using System.ComponentModel.DataAnnotations.Schema;

namespace SpellAndSummon.Models
{
    [Table("SpecialAbilityCards")]
    public class SpecialAbilityCard
    {
        public int CardId { get; set; }
        public Card Card { get; set; }
        public int SpecialAbilityId { get; set; }
        public SpecialAbility SpecialAbility { get; set; }
    }
}