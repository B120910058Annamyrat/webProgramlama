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
    public class DeleteModel : PageModel
    {
        private readonly proje.Models.PlaneVeriContext _context;

        public DeleteModel(proje.Models.PlaneVeriContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Kullanici = await _context.Kullanicis.FindAsync(id);

            if (Kullanici != null)
            {
                _context.Kullanicis.Remove(Kullanici);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
