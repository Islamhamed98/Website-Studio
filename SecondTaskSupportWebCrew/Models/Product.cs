using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace SecondTaskSupportWebCrew.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        [Display(Name="Product Name")]
        public string Name { get; set; }
        [StringLength(255)]
        public string Price { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [Display(Name="Category")]
        public string ProductCategory { get; set; }
        public string Image { get; set; }

    }
}