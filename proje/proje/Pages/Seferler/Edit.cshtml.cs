using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using proje.Models;

namespace proje.Pages.Seferler
{
    public class EditModel : PageModel
    {
        private readonly proje.Models.PlaneVeriContext _context;

        public EditModel(proje.Models.PlaneVeriContext context)
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
           ViewData["HavalimanId"] = new SelectList(_context.Havalimanlaris, "Id", "Ad");
           ViewData["UcakId"] = new SelectList(_context.Ucaklaris, "Id", "Id");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Sefer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SeferExists(Sefer.Id))
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

        private bool SeferExists(int id)
        {
            return _context.Sefers.Any(e => e.Id == id);
        }
    }
}
