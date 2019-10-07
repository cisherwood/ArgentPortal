using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArgentPortal.Data
{
    public class Deck
    {
        [Key]
        public int DeckId { get; set; }

        [MaxLength(500)]
        public string Name { get; set; }


        public ICollection<CardDeck> CardDecks { get; set; }
    }
}
