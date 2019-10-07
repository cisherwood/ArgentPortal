using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArgentPortal.Data
{
    public class CardDeck
    {
        [Key]
        public int CardDeckId { get; set; }

        [Required]
        public int CardId { get; set; }

        [Required]
        public int DeckId { get; set; }

        public short Quantity { get; set; }

        public Card Card { get; set; }
        public Deck Deck { get; set; }
    }
}
