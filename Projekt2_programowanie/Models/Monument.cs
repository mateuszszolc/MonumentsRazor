using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt2_programowanie.Models
{
    public class Monument
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string MonumentName { get; set; }
        [Required]
        public string MonumentDescription { get; set; }
        
        public string Image { get; set; }
        [Required]
        public string Country { get; set; }

        [Display(Name = "Adding User")]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }
   
    }
}
