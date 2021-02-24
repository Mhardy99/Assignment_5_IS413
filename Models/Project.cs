using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_5_IS413.Models
{
    public class Project
    { //identifying the public key
        [Key]
        [Required]
        public int BookID { get; set; }
        [Required] 
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string AuthorLast { get; set; }
        [Required]
        public string? AuthorMiddle { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        //Using regex to validate the ISBN
        [RegularExpression(@"^[0-9]{3}-[0-9]{10}", ErrorMessage = "You're ISBN is Wrong")]
        public string ISBN { get; set; }
        [Required]
        public string Classification { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int PageNum { get; set; }

    }
}
