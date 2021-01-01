﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using proje.Models;

namespace proje.Pages.ius
{
    public class CreateModel : PageModel
    {
        private readonly proje.Models.PlaneVeriContext _context;

        public CreateModel(proje.Models.PlaneVeriContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Kullanici Kullanici { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Kullanicis.Add(Kullanici);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
