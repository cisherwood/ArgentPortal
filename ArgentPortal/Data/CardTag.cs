using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArgentPortal.Data
{
    public class CardTag
    {
        [Key]
        public int CardTagId { get; set; }

        [Required]
        public int CardId { get; set; }


        [Required]
        public int TagId { get; set; }



        public Tag Tag { get; set; }
        public Card Card { get; set; }
    }
}
