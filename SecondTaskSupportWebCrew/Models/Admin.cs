using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace SecondTaskSupportWebCrew.Models
{
    public class Admin
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]

        public string Name { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please Don't Leave Field is Empty!")]
        public string Password { get; set; }
        public string Gender { get; set; }
        public int AdminRole { get; set; }
        
    }
}