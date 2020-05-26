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
using Projekt2_programowanie.Data;
using Projekt2_programowanie.Models;
using Projekt2_programowanie.Utility;


namespace Projekt2_programowanie.Pages.Monuments
{
    [Authorize(Roles ="Admin, Customer")]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        private readonly IHostingEnvironment hostingEnvironment;
        

        [BindProperty]
        public Monument Monument { get; set; }

        [BindProperty]
        public ApplicationUser ApplicationUser { get; set; }

        [BindProperty]
        public IFormFile Image { set; get; }

        public CreateModel(ApplicationDbContext db, IHostingEnvironment environment)
        {
            _db = db;
            this.hostingEnvironment = environment;
        }

       
        public async Task<IActionResult> OnPostAsync(Monument monument)
        {
            

            if(!ModelState.IsValid)
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

            _db.Monument.Add(Monument);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }

        private string GetUniqueName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                   + "_" + Guid.NewGuid().ToString().Substring(0, 4)
                   + Path.GetExtension(fileName);
        }

    }
}