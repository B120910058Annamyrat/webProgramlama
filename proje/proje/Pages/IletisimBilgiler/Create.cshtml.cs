using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using proje.Models;

namespace proje.Pages.IletisimBilgiler
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
            return Page();
        }

        [BindProperty]
        public IletisimBilgileri IletisimBilgileri { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.IletisimBilgileris.Add(IletisimBilgileri);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
