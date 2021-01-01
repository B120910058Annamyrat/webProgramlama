using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using proje.Models;

namespace proje.Pages.Seferler
{
    public class CreateModel : PageModel
    {
        private readonly proje.Models.PlaneVeriContext _context;

        public CreateModel(proje.Models.PlaneVeriContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            var havaId= new SelectList(_context.Havalimanlaris, "Id", "Ad");
            ViewData["HavalimanId"] = havaId;
            var konumlar = new SelectList(_context.Konumis, "Id", "Konum1");
            ViewData["KonumId"] = konumlar;
            ViewData["UcakId"] = new SelectList(_context.Ucaklaris, "Id", "Ad");
            return Page();
        }

        [BindProperty]
        public Sefer Sefer { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Sefers.Add(Sefer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
