using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using proje.Models;

namespace proje.Pages.konumlar
{
    public class EditModel : PageModel
    {
        private readonly proje.Models.PlaneVeriContext _context;

        public EditModel(proje.Models.PlaneVeriContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Konum Konum { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Konum = await _context.Konums
                .Include(k => k.UstKonum).FirstOrDefaultAsync(m => m.Id == id);

            if (Konum == null)
            {
                return NotFound();
            }
           ViewData["UstKonumId"] = new SelectList(_context.Konums, "Id", "Konum1");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Konum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KonumExists(Konum.Id))
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

        private bool KonumExists(int id)
        {
            return _context.Konums.Any(e => e.Id == id);
        }
    }
}
