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
    public class MyMonumentsModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public MyMonumentsModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IList<Monument> MyMonuments { get; set; }

        public async Task<IActionResult> OnGet()
        {
            MyMonuments = await _db.Monument.ToListAsync();

            return Page();
        }
    }
}