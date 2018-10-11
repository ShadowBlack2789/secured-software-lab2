using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1B.Models
{
    public class Dealership
    {
        [Key]
        public string ID { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name="Phone")]
        public int PhoneNumber { get; set; }
    }
}
