using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt2_programowanie.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

        //dodane
        public string Nick { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
    }
}
