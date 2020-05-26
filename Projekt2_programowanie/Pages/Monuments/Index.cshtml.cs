using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projekt2_programowanie.Data;
using Projekt2_programowanie.Models;
using Projekt2_programowanie.Models.ViewModel;

namespace Projekt2_programowanie.Pages.Monuments
{
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IList<Monument> Monument { get; set; }


        public async Task<IActionResult> OnGet(string searchCountry = null, string searchUser = null)
        {
            Monument = await _db.Monument.ToListAsync();
            StringBuilder param = new StringBuilder();
            param.Append("/Monuments?productPage=:");
            param.Append("&searchCountry=");
            if (searchCountry != null)
            {
                param.Append(searchCountry);
            }
            param.Append("&searchUser=");
            if (searchUser != null)
            {
                param.Append(searchUser);
            }
            

            if (searchCountry != null)
            {
                Monument = await _db.Monument.Where(u => u.Country.ToLower().Contains(searchCountry.ToLower())).ToListAsync();
            }
            else
            {
                if (searchUser != null)
                {
                    Monument = await _db.Monument.Where(u => u.AddingUser.ToLower().Contains(searchUser.ToLower())).ToListAsync();
                }
            }
           
            
            
            return Page();
        }

        


    }
}