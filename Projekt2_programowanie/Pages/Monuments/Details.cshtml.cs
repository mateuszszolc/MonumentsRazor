using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projekt2_programowanie.Data;
using Projekt2_programowanie.Models;

namespace Projekt2_programowanie.Pages.Monuments
{
    public class DetailsModel : PageModel
    {
        private readonly Projekt2_programowanie.Data.ApplicationDbContext _context;

        public DetailsModel(Projekt2_programowanie.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Monument Monument { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Monument = await _context.Monument.FirstOrDefaultAsync(m => m.Id == id);

            if (Monument == null)
            {
                return NotFound();
            }
            return Page();
        }
    }   
}
