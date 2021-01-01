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
    public class DetailsModel : PageModel
    {
        private readonly proje.Models.PlaneVeriContext _context;

        public DetailsModel(proje.Models.PlaneVeriContext context)
        {
            _context = context;
        }

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
    }
}
