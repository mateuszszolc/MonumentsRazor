using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projekt2_programowanie.Data;
using Projekt2_programowanie.Models;

namespace Projekt2_programowanie.Pages.Monuments
{
    [Authorize(Roles = "Admin, Customer")]
    public class EditModel : PageModel
    {
        private readonly Projekt2_programowanie.Data.ApplicationDbContext _context;
        private readonly IHostingEnvironment hostingEnvironment;

        public EditModel(Projekt2_programowanie.Data.ApplicationDbContext context, IHostingEnvironment environment)
        {
            _context = context;
            this.hostingEnvironment = environment;
        }

        [BindProperty]
        public Monument Monument { get; set; }

        public string img { get; set; }
    

        
        [BindProperty]
        public IFormFile Image { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Monument = await _context.Monument
                .FirstOrDefaultAsync(m => m.Id == id);

            

            string img = Monument.Image;

            if (Monument == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (this.Image != null)
            {
                var fileName = GetUniqueName(this.Image.FileName);
                var uploads = Path.Combine(hostingEnvironment.WebRootPath, "uploads");
                var filePath = Path.Combine(uploads, fileName);
                this.Image.CopyTo(new FileStream(filePath, FileMode.Create));
                this.Monument.Image = fileName; // Set the file name

                
            }

            if (Image == null)
            {
                this.Monument.Image = img;
            }


            _context.Attach(Monument).State = EntityState.Modified;
            

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MonumentExists(Monument.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private string GetUniqueName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                   + "_" + Guid.NewGuid().ToString().Substring(0, 4)
                   + Path.GetExtension(fileName);
        }

        private bool MonumentExists(int id)
        {
            return _context.Monument.Any(e => e.Id == id);
        }
    }
}
