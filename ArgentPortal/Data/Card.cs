using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArgentPortal.Data
{
    public class Card
    {

        [Key]
        public int CardId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Url { get; set; }

        [MaxLength(1000)]
        public string Text { get; set; }

        public ICollection<CardCategory> CardCategories { get; set; }
        public ICollection<CardTag> CardTags { get; set; }
        public ICollection<CardDeck> CardDecks { get; set; }
        public ICollection<CardEffect> CardEffects { get; set; }
    }
}
