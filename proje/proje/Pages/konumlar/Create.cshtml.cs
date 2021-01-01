using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using proje.Models;

namespace proje.Areas.Admin.Pages.Konumlar
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
        ViewData["UstKonumId"] = new SelectList(_context.Konums, "Id", "Konum1");
            return Page();
        }

        [BindProperty]
        public Konum Konum { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Konums.Add(Konum);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
