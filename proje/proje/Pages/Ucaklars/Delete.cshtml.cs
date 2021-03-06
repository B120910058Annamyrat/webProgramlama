﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using proje.Models;

namespace proje.Pages.Ucaklars
{
    public class DeleteModel : PageModel
    {
        private readonly proje.Models.PlaneVeriContext _context;

        public DeleteModel(proje.Models.PlaneVeriContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ucaklar = await _context.Ucaklaris.FindAsync(id);

            if (Ucaklar != null)
            {
                _context.Ucaklaris.Remove(Ucaklar);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
