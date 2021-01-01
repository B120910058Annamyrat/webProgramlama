using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using proje.Models;

namespace proje.Pages.Havalimanlar
{
    public class EditModel : PageModel
    {
        private readonly proje.Models.PlaneVeriContext _context;

        public EditModel(proje.Models.PlaneVeriContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Havalimanlari Havalimanlari { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Havalimanlari = await _context.Havalimanlaris
                .Include(h => h.Konum).FirstOrDefaultAsync(m => m.Id == id);

            if (Havalimanlari == null)
            {
                return NotFound();
            }
           ViewData["KonumId"] = new SelectList(_context.Konumis, "Id", "Konum1");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Havalimanlari).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HavalimanlariExists(Havalimanlari.Id))
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

        private bool HavalimanlariExists(int id)
        {
            return _context.Havalimanlaris.Any(e => e.Id == id);
        }
    }
}
