using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace SecondTaskSupportWebCrew.Models
{
    public class Session
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Photgrapher { get; set; }
        
        [Required]
        [StringLength(255)]
        [Display(Name="Location")]
        public string Location { get; set; }

        [StringLength(255)]
        public string Price { get; set; }
        
        [StringLength(500)]
        public string Description { get; set; }
        
        [Display(Name="City")]
        public string City { get; set; }
        public string Image { get; set; }

    }
}