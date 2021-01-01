using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using proje.Models;

namespace proje.Pages.Seferler
{
    public class DeleteModel : PageModel
    {
        private readonly proje.Models.PlaneVeriContext _context;

        public DeleteModel(proje.Models.PlaneVeriContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Sefer Sefer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sefer = await _context.Sefers
                .Include(s => s.Havaliman)
                .Include(s => s.Ucak).FirstOrDefaultAsync(m => m.Id == id);

            if (Sefer == null)
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

            Sefer = await _context.Sefers.FindAsync(id);

            if (Sefer != null)
            {
                _context.Sefers.Remove(Sefer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
