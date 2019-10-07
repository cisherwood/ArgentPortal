using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArgentPortal.Data
{
    public class CardCategory
    {
        [Key]
        public int CardCategoryId { get; set; }


        [Required]
        public int CardId { get; set; }

        [Required]
        public int CategoryId { get; set; }


        public Card Card { get; set; }
        public Category Category { get; set; }
    }
}
