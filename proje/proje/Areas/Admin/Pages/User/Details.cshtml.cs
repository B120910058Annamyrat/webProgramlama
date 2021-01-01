using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using proje.Models;

namespace proje.Areas.Admin.Pages.User
{
    public class DetailsModel : PageModel
    {
        private readonly proje.Models.PlaneVeriContext _context;

        public DetailsModel(proje.Models.PlaneVeriContext context)
        {
            _context = context;
        }

        public Kullanici Kullanici { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Kullanici = await _context.Kullanicis.FirstOrDefaultAsync(m => m.Id == id);

            if (Kullanici == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
