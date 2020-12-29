using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using proje.Models;

namespace proje.Pages.konumlar
{
    public class DeleteModel : PageModel
    {
        private readonly proje.Models.PlaneVeriContext _context;

        public DeleteModel(proje.Models.PlaneVeriContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Konum = await _context.Konums.FindAsync(id);

            if (Konum != null)
            {
                _context.Konums.Remove(Konum);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
