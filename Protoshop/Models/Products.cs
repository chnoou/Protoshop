using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Protoshop.Models {
    public class Products {
        public int ID { get; set; }
        [Required(ErrorMessage = "Du måste fylla i namn!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Du måste fylla i en beskrivning!")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "Beskrivning mellan 10 och 500 karaktärer")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Du måste fylla i ett pris!")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "Priset måste vara mellan 10 och 500 kr!")]
        public double Price { get; set; }
        [Required]
        [Range(0,10000)]
        public string ImageFile { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}