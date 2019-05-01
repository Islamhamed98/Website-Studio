using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SecondTaskSupportWebCrew.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } 
        public string Gender { get; set; }
        public byte AdminRole { get; set; }

    }
}