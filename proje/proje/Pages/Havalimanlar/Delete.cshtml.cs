using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using proje.Models;

namespace proje.Pages.Havalimanlar
{
    public class DeleteModel : PageModel
    {
        private readonly proje.Models.PlaneVeriContext _context;

        public DeleteModel(proje.Models.PlaneVeriContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Havalimanlari = await _context.Havalimanlaris.FindAsync(id);

            if (Havalimanlari != null)
            {
                _context.Havalimanlaris.Remove(Havalimanlari);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
