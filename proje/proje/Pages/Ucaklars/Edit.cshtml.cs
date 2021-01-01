using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using proje.Models;

namespace proje.Pages.Ucaklars
{
    public class EditModel : PageModel
    {
        private readonly proje.Models.PlaneVeriContext _context;

        public EditModel(proje.Models.PlaneVeriContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Ucaklar Ucaklar { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ucaklar = await _context.Ucaklaris.FirstOrDefaultAsync(m => m.Id == id);

            if (Ucaklar == null)
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

            _context.Attach(Ucaklar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UcaklarExists(Ucaklar.Id))
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

        private bool UcaklarExists(int id)
        {
            return _context.Ucaklaris.Any(e => e.Id == id);
        }
    }
}
