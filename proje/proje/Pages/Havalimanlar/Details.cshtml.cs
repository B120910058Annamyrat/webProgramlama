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
    public class DetailsModel : PageModel
    {
        private readonly proje.Models.PlaneVeriContext _context;

        public DetailsModel(proje.Models.PlaneVeriContext context)
        {
            _context = context;
        }

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
    }
}
