using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projekt2_programowanie.Data;
using Projekt2_programowanie.Models;


namespace Projekt2_programowanie.Pages.Monuments
{
    [Authorize(Roles = "Admin, Customer")]
    public class DeleteModel : PageModel
    {
        private readonly Projekt2_programowanie.Data.ApplicationDbContext _context;

        public DeleteModel(Projekt2_programowanie.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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


        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Monument = await _context.Monument.FindAsync(id);

            if (Monument != null)
            {
                _context.Monument.Remove(Monument);
                if(System.IO.File.Exists(Monument.Image))
                {
                    System.IO.File.Delete(@"C:\Users\mateu\source\repos\Projekt2_programowanie\Projekt2_programowanie\wwwroot\uploads\" + Monument.Image);
                }
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
